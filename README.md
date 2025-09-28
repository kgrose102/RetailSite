# Laptops 4 You
Find your next great laptop to up your gaming experience.

### All your orders saved to your account
Visit the registration page to create your account.

Once signed in you'll be able to:
- Explore Laptops and view their specs, and pricing.
- Add laptops and accessories to your cart.
- Place your order.
- View previous orders and know if any item is back ordered.

### Prefer to shop in store?
Visit the Branch finder to locate your 3 closest branches.

## Details:
C#, Vue.js, .Net, Entity Framework, SQL, Visual Studio.

### Requirments to Run Locally:
- Visual Studio.
- .NET 9.0 Runtime.
- ASP.NET and web development package.
- Node.js.

### Setup:
Front already contained withing the "wwwroot", no additonal setup required.

For the backend:
1. Create a new database and update "DefaultDonnection" inside "appsettings.json" with your database connectiong string.
2. Restore NuGet Packages.
3. Within the "Package Manager Console" run the update-database command to create the local tables matching the Domain Classes.
4. Use the included SQL files to populate the static tables of Branches, Brands, and Products. (Customers, Orders and OrderItems are dynamically populated based on user registration, and order creation.)

### Using Site:
1. Start the program. If your browser windows does not open navigate to "localhost:7261/index.html" (this is the default verify if it is different within the command prompt window that appears.)
2. Without Registration you can only visit the Login, Logout, and Branches pages.
3. Visit the Registration page and register as a new user.
4. Once registered visit the Login Page and use the information you registered.
5. You can now explore all the pages.

