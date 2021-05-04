using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace Subcriber
{
    class Subcriber

    {
        static void Main(string[] args)
        {


            MqttClient client = new MqttClient("localhost");

            // register to message received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);


           

            // subscribe to the topic "/home/temperature" with QoS 2
            client.Subscribe(new string[] { "/home/temperature" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });



            static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
            {
                var msg = System.Text.Encoding.Default.GetString(e.Message);
                System.Console.WriteLine("Message Received: " + msg);

            }

            

        }
    }
}
