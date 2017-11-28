using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PTUtility.TcpClientSocket
{

    public class EndPoint
    {
        public static string endpoint { set; get; }
        public static int port { set; get; }
        public EndPoint(string _endpoint, int _port)
        {
            endpoint = _endpoint;
            port = _port;
        }
    }

    public class Sockets
    {
        static string gMessage = "";
        static string gResponse = "";
        static string gError = "";

        public event EventHandler<string> RequestMessageCompleted;

        static Thread thread;

        public void RequestMessage(string message, EndPoint endpoint)
        {
            try
            {
                gMessage = message;
                gResponse = "";
                GC.Collect();
                thread = new Thread(Connect);
                thread.Start();
            }
            catch(Exception ex)
            {
                ThrowError(ex);
            }
        }

        private void OnRequestMessageCompleted(string response)
        {
            try
            {
                if (RequestMessageCompleted != null)
                {
                    //gError = response;
                    RequestMessageCompleted(null, response);
                }
            }
            catch (Exception ex)
            {
                ThrowError(ex);
            }
        }


        void Connect()
        {
            try
            {
                Socket clientSocket = new Socket(
                  AddressFamily.InterNetwork,
                  SocketType.Stream,
                  ProtocolType.Tcp);
                IAsyncResult asyncConnect = clientSocket.BeginConnect(EndPoint.endpoint, EndPoint.port,
                  new AsyncCallback(connectCallback),
                  clientSocket);
                Console.WriteLine("Connection in progress.");
                if (writeDot(asyncConnect))
                {
                    Thread.Sleep(500);
                }
            }
            catch(Exception ex)
            {
                ThrowError(ex);
            }
        }

        class StateObject
        {
            internal byte[] sBuffer;
            internal Socket sSocket;
            internal StateObject(int size, Socket sock)
            {
                sBuffer = new byte[size];
                sSocket = sock;
            }
        }

        void connectCallback(IAsyncResult asyncConnect)
        {
            try
            {
                Socket clientSocket =
              (Socket)asyncConnect.AsyncState;
                clientSocket.EndConnect(asyncConnect);
                // arriving here means the operation completed
                // (asyncConnect.IsCompleted = true) but not
                // necessarily successfully
                if (clientSocket.Connected == false)
                {
                    OnRequestMessageCompleted("Error98");
                    Console.WriteLine("Client is not connected.");
                    return;
                }
                else Console.WriteLine("Client is connected.");

                byte[] sendBuffer = Encoding.ASCII.GetBytes(gMessage);
                IAsyncResult asyncSend = clientSocket.BeginSend(
                  sendBuffer,
                  0,
                  sendBuffer.Length,
                  SocketFlags.None,
                  new AsyncCallback(sendCallback),
                  clientSocket);

                Console.WriteLine("Sending data.");
                writeDot(asyncSend); 
            }
            catch(Exception ex)
            { 
                ThrowError(ex);
            } 
        }

        void sendCallback(IAsyncResult asyncSend)
        {
            try
            { 
                Socket clientSocket = (Socket)asyncSend.AsyncState;
                int bytesSent = clientSocket.EndSend(asyncSend);
                Console.WriteLine(
                  ".{0} bytes sent.",
                  bytesSent.ToString());

                StateObject stateObject =
                  new StateObject(256, clientSocket);

                // this call passes the StateObject because it
                // needs to pass the buffer as well as the socket
                IAsyncResult asyncReceive =
                  clientSocket.BeginReceive(
                    stateObject.sBuffer,
                    0,
                    stateObject.sBuffer.Length,
                    SocketFlags.None,
                    new AsyncCallback(receiveCallback),
                    stateObject);

                Console.WriteLine("Receiving response.");
                bool status = writeDot(asyncReceive);
                //if(!status)
                //{
                //    stateObject.sSocket.Shutdown(SocketShutdown.Both);
                //    stateObject.sSocket.Close();
                //}
            }
            catch(Exception ex)
            {
                ThrowError(ex);
            }
        }

        void receiveCallback(IAsyncResult asyncReceive)
        {
            try
            {
                StateObject stateObject =
             (StateObject)asyncReceive.AsyncState;

                int bytesReceived =
                  stateObject.sSocket.EndReceive(asyncReceive);

                string response = Encoding.ASCII.GetString(stateObject.sBuffer);
                Console.WriteLine(
                  ".{0} bytes received: {1} - Shutting down.",
                  bytesReceived.ToString(),
                  response);

                OnRequestMessageCompleted(response);

                stateObject.sSocket.Shutdown(SocketShutdown.Both);
                stateObject.sSocket.Close();
            }
            catch (Exception ex)
            {
                ThrowError(ex);
            } 
        }

        // times out after 45 seconds but operation continues
        bool writeDot(IAsyncResult ar)
        { 
            int i = 0;
            Console.WriteLine("Waiting for response....");
            while (!ar.IsCompleted)
            {
                if (i++ > 65)
                {
                    //StateObject stateObject =
                    //    (StateObject)ar.AsyncState;
                    //stateObject.sSocket.Shutdown(SocketShutdown.Both);
                    //stateObject.sSocket.Close();
                    Console.WriteLine("Timed out.");
                    OnRequestMessageCompleted("Error99");
                    return false;
                }
                Thread.Sleep(1000);
            }
            return true; 
        }

        void ThrowError(Exception ex)
        { 
            int errorCode = 0;
            var w32ex = ex as Win32Exception;  
            w32ex = (w32ex == null) ? ex.InnerException as Win32Exception : ex as Win32Exception;  
            errorCode = (w32ex != null) ? w32ex.ErrorCode : 0;
            OnRequestMessageCompleted(string.Format("Error{0}:{1}", (errorCode > 0) ? errorCode.ToString() : "", ex.Message.ToString()));  
            //if(gError != "Error99")
            //{
            //    OnRequestMessageCompleted(string.Format("Error{0}:{1}", (errorCode > 0) ? errorCode.ToString() : "", ex.Message.ToString()));  
            //} 
        }
    }

}
