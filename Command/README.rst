Command
====================

EN

Allows you to encapsulate actions in objects. The key idea behind this pattern 
is to provide the means to decouple client from receiver.

VI

Đóng gói các hành động thành đối tượng, tách rời giữa hành động gửi và thực thi lệnh.

VD: Chúng ta có các thiết bị như tv và radio. Các thiết bị này đều có các chức năng chung 
như on, off, volume up, volume down. Việc đóng gói các chức năng trên thành các object 
giúp cho chúng ta dễ dàng mở rộng mà không phải lặp đi lặp lại các chức năng 
cho từng device

Invoker: remove control
Command: on, off
Receiver: tv, radio
