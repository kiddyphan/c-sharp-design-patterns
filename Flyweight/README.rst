Flyweight
====================

EN

It is used to minimize memory usage or computational expenses 
by sharing as much as possible with similar objects. A common practice is to hold state 
in external data structures and pass them to the flyweight object when needed.

**Flyweight is when you have many different kinds of a single thing**

**Singleton is when you have a single thing**

VI

Dùng để chia sẻ tài nguyên khi cần dùng đến mà không phải tạo lại cùng một object.

VD: Giống như việc các quán cà phê take away luôn pha dư một lượng cà phê đã được order trước đó, 
để khi khách hàng tiếp theo order cùng một loại cà phê thì không phải pha chế lại. 
Làm như vậy sẽ tiết kiệm được thời gian, công sức.
