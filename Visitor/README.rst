Visitor
====================

EN

Visitor pattern lets you add further operations to objects without having to modify them.

VI

Để thêm các tác vụ cho một đối tượng khi đối tượng này sẽ được mở rộng trong 
tương lai mà không phải cấu trúc lại đối tượng đó.

VD: Một cửa hàng tiện lợi có bán Sách và Thức ăn. Lúc đầu cả 2 đều chấp nhận hình thức 
thanh toán bằng tiền mặt. Sau đó một thời gian có thêm hình thức thanh toán bằng VISA. 
Một thời gian sau lại có thêm hình thức thanh toán bằng Ví Điện Tử. 
Với mỗi hình thức lại có cách giảm giá khác nhau khiến cho đối tượng ngày càng rối rắm. 
Tách rời việc có thể thêm hình thức thanh toán mới (Further Operations) và 
cách tính giá tiền cho mỗi hình thức là điều cần thiết. 
