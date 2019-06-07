Singleton
====================

**Beware of The Singleton. It is considered an anti-pattern**

Why?

Singleton is basically a way to use global variables. 
And global variables are bad because any code anywhere in the system can change their values. 
So when debugging, it can be difficult to figure out which code path lead to the singleton's current state.

EN

Ensures that only one object of a particular class is ever created.

VI

Để giảm thiểu nguồn tài nguyên khi khởi tạo mới một đối tượng, 
mỗi đối tượng chỉ khởi tạo một lần trong vòng đời của nó. 
