1. Facade Pattern giúp đơn giản hóa việc gọi nhiều service nhỏ lẻ bằng cách cung cấp một điểm truy cập duy nhất.
2. Nếu không dùng Facade Pattern, khi đặt vé máy bay, bạn phải:
Gọi service tìm chuyến bay,
Gọi service đặt chỗ ngồi,
Gọi service thanh toán,
khiến API Controller phải tự quản lý từng bước này.
Code khó bảo trì, nếu thay đổi cách đặt chỗ hoặc thanh toán, ta phải sửa nhiều nơi.
