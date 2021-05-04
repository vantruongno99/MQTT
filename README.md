# MQTT
MQTT is an OASIS standard messaging protocol for the Internet of Things (IoT). It is designed as an extremely lightweight publish/subscribe messaging transport that is ideal for connecting remote devices with a small code footprint and minimal network bandwidth
MQTT stands for MQ Telemetry Transport but previously was known as Message Queuing Telemetry Transport.
<br />

# MQTT VERSIONS
There are two different variants of MQTT and several versions.

<ul>
  <li>MQTT v3.1.0 –</li>
  <li>MQTT v3.1.1 – In Common Use</li>
  <li>MQTT v5 – Currently Limited use</li>
  <li>MQTT-SN – Not in Common Use</li>
</ul>

MQTTv3.1.1 is version in common use.

<br />

# MQTT CLIENTS

Because MQTT clients don’t have addresses like email addresses, phone numbers etc. you don’t need to assign addresses to clients like you do with most messaging systems.

Any Thing (from a microcontroller to a massive server) that runs an MQTT library and connects to a broker over a network can effectively become an MQTT client. 

Clients don’t send messages directly to and from each other but instead communicate to topics managed by the MQTT broker. These topics work a little like email inboxes. Messages are published by Things to topics; messages are then picked up when a Thing subscribes to those topics.

For MQTTv3.1.1 there is client software available in almost all programming languages and for the main operating systems Linux, Windows, Mac from the Eclipse Paho project.

<ul>
  <li>Paho Python client</li>
  <li>Node.js MQTT Client-Starting Guide< /li>
  <li>JavaScript Websockets Client</li>
  <li>C++ Client with Arduino</li>
   <li> Paho Dotnet Client </li>
</ul>

<br />

# MQTT BROKERS AND SERVER

There are many MQTT brokers available that you can use for testing and for real applications.

There are free self hosted brokers , the most popular being Mosquitto and commercial ones like HiveMQ.

Mosquitto is a free open source MQTT broker that runs on Windows and Linux.
If you don’t want to install and manage your own broker you can use a cloud based broker.

Eclipse has a free public MQTT broker and COAP server that you can also use for testing.


