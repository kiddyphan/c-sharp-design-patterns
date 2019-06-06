Factory Method
====================

Purpose
-------

EN

It provides a way to delegate the instantiation logic to child classes.
It means the FactoryMethod class depends on abstractions, not concrete classes. 
This is the real trick compared to SimpleFactory.

VI

Khác với SimpleFactory, Factory Method phụ thuộc vào một class abtractions factory 
và chỉ định việc khởi tạo cho class con đã kế thừa từ abtractions factory.
