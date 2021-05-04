using System;
using System.Text;
using System.Threading;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace Publisher
{
    class Publisher
    {
        static void Main(string[] args)
        {
            MqttClient client = new MqttClient("localhost");

            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);

            while (true)
            {
                Random random = new Random();
                int value = random.Next(1000);
                string strValue = Convert.ToString(value) + "°C";
                client.Publish("/home/temperature", Encoding.UTF8.GetBytes(strValue), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                Thread.Sleep(1000);
            }



        }
    }
}
