# MQTT
MQTT is an OASIS standard messaging protocol for the Internet of Things (IoT). It is designed as an extremely lightweight publish/subscribe messaging transport that is ideal for connecting remote devices with a small code footprint and minimal network bandwidth
<br /><br />
MQTT stands for MQ Telemetry Transport but previously was known as Message Queuing Telemetry Transport.
<br /><br /><br />


# ADVANTAGES OF MQTT
<ul>
<li> 
  
  **Packet agnostic** 
  : Any type of data can be transported in the payload carried by the packet. The data could be text or binary. It does not matter as long as the receiving party knows how to interpret it.</li>
<li> 
  
  **Reliability** : There are some Quality of Service (QoS) options that can be used to guarantee delivery.</li>
<li> 
  
  **Scalability** : The publish/subscribe model scales well in a power-efficient way.</li>
<li>
  
  **Decoupled design** : There are several elements to the design that decouple the device and the subscribing server, which result in a more robust communication strategy.</li>
<li> 
  
  **Time** : A device can publish its data regardless of the state of the subscribing server. The subscribing server can then connect and receive the data when it is able. This decouples ...</li>
</ul>
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

# MQTT BROKERS 

The MQTT broker handles authentication of Things on the network as well as managing connections, sessions, and subscriptions. Its main responsibility is to receive all published messages and then send them subscribed clients. The MQTT broker also queues messages for subscribed clients, delivering them according to the agreed QoS level.

There are many MQTT brokers available that you can use for testing and for real applications.

There are free self hosted brokers , the most popular being Mosquitto and commercial ones like HiveMQ.
<br />
<br />

# MQTT DEVICES
There are various types of MQTT-enabled devices in the field today, ranging from simple Arduino-based devices to devices for mission-critical commercial, industrial, and medical applications. Many smart homes and businesses are also built around interconnected MQTT devices.

<br />

# Client TOPICS

MQTT messages aren’t delivered directly from Clients. Instead, they are published to "topics". The broker then delivers those messages to any subscribed clients.

<ul>
  <li>Topics are made up of one or more topic levels, separated by a forward slash : 
   
   `sensor\temperature\out` 
   
  </li>
  <li>Topics are case sensitive</li>
  <li>Topics don’t have to be pre-registered at the broker</li>
</ul>

# MQTT QoS
Where the MQTT protocol is concerned, the guarantee of delivery is defined by QoS (Quality of Service).
<br /> 
Here, you will learn how, where, and when to use MQTT QoS, and which levels are right for your own IoT applications.
<br />
### MQTT QoS levels
MQTT and MQTT-SN support multiple levels of QoS for guaranteeing message delivery.
<br />

#### QoS 0 - at most once
&nbsp;QoS 0 (zero) is used to ensure that a message reaches its destination no more than once. Unlike QoS -1, this method requires an MQTT connection meaning it is less efficient in terms of power.
<ul>
<li>Best effort message delivery</li>
<li>No acknowledgment from the recipient</li>
<li>Not retried by the sender</li>
<li>Not queued by the broker for disconnected clients with a valid subscription to the topic</li>
 </ul>

#### QoS 1 - at least once
&nbsp;QoS 1 is used when message delivery is critical. This is achieved by queueing messages until the subscriber is able to receive it.
<ul>
<li>Guarantees that a message is delivered at least one time to the recipient. </li>
<li>Sender stores the message until it receives a puback from the recipient</li>
<li>Messages may be sent or delivered multiple times.</li>
 </ul>

#### QoS 2 - exactly once
&nbsp;QoS 2 is used when the message needs to arrive once and only once. This level is used when delivery is essential.
<ul>
<li>QoS 2 is the safest and slowest Quality of Service level
</li>
<li>No acknowledgment from the recipient</li>
<li>Guarantees that each message is received only once by the intended recipients by using at least two request/response flows (a four-part handshake) between the sender and the receiver</li>
 </ul>
 
 #### QoS downgrade
&nbsp;In cases where there are many devices on the network, different levels of QoS might be needed. To achieve this, MQTT allows downgrading of the QoS level at the subscriber node. The result of this is that the QoS for a message that is published does not have to be the same as the QoS for a message that is received.
<br />
<br />
# SECURITY  

Making sure MQTT devices are secure is just as important as making sure that they work and every link or node on the network is a potential exploit vector. While MQTT itself does contain some security mechanisms, it’s important to consider factors extraneous to the transport itself.
<ul>
<li>
  
**Network-level security** :
The first place to consider security is the network itself. Ensuring that the network connection is secured by using a VPN tunnel will prevent exposure to network traffic.
</li>

<li>

**Transport-level security** : 
As with HTTP traffic, MQTT traffic can be secured at the transport layer with TLS/SSL.
</li>
<li>

**Application-level security** : 
Unique client identification and username/password credentials are provided by the protocol itself and should be considered the bare minimum security requirement.
</li>
<li>

**Payload encryption** :
Further security can be added by encrypting the payload itself at the application level.
</li>
<ul/>





