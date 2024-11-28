# Hotel Management System  

This repository features a **.NET-based Hotel Management System**, offering a comprehensive and efficient solution for managing hotel operations. The system includes a RESTful API to streamline the management of **customers**, **rooms**, and **reservations**, ensuring a seamless experience for hotel administrators.  

## Features  

### Customer Management  
- **View All Customers**: Retrieve a list of all registered customers.  
- **View Specific Customer**: Access details of a particular customer.  
- **Add New Customer**: Register new customers into the system.  
- **Update Customer Information**: Modify existing customer details.  
- **Delete Customer**: Remove a customer record when no longer needed.  

### Room Management  
- **View All Rooms**: Display a list of available and occupied rooms.  
- **View Specific Room**: Retrieve information about a specific room.  
- **Add New Room**: Add new rooms to the inventory.  
- **Update Room Details**: Modify room details, such as amenities or pricing.  
- **Delete Room**: Remove a room record from the system.  

### Reservation Management  
- **View All Reservations**: List all current and past reservations.  
- **View Specific Reservation**: Retrieve details of a particular reservation.  
- **Add New Reservation**: Create a new reservation for a customer.  
- **Update Reservation Details**: Adjust existing reservation details.  
- **Delete Reservation**: Cancel or remove a reservation record.  

## Technology Stack  

- **.NET Core**: For building a high-performance, scalable application.  
- **ASP.NET Core**: To create the RESTful API endpoints.  
- **Entity Framework Core**: For seamless interaction with the database using an ORM approach.  

## Project Highlights  

- **RESTful API Design**: Ensures easy integration with front-end or third-party applications.  
- **Database Integration**: Utilizes Entity Framework Core for efficient data storage and retrieval.  
- **Scalable Architecture**: Designed to handle growing data and operational demands.  

## How to Run  

1. Clone the repository:  
   ```bash  
   git clone https://github.com/yourusername/hotel-management-system.git  
   ```  
2. Configure the database connection string in the `appsettings.json` file.  
3. Run the project using the .NET CLI:  
   ```bash  
   dotnet run  
   ```  
4. Access the API documentation (e.g., Swagger) at `http://localhost:<port>/swagger`.  

---  

This project is an ideal solution for hotel operations and can be expanded further to meet specific requirements. Contributions and suggestions for improvement are welcome!  
