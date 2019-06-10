Mediator
====================

EN

Mediator pattern adds a third party object (called mediator) to control 
the interaction between two objects (called colleagues). It helps reduce the coupling 
between the classes communicating with each other. Because now they don't need 
to have the knowledge of each other's implementation.

VI

Tạo ra một Object Third Party để giúp kiểm soát sự tương tác giữa các object với nhau.

VD: Chúng ta có 2 users (Colleagues) muốn nhắn tin cho nhau. 
Tin nhắn phải thông qua nhà mạng (Mediator) Mobi, Vina, Viettel. Ở đây các nhà mạng chỉ
sẽ điều phối tin nhắn đến đúng địa chỉ.
