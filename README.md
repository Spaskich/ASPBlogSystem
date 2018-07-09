# ASP.NET Blog System
A (very) simple blog system created with ASP.NET MVC Framework


## Project Specifications
 - ASP.NET MVC Application
 - MS SQL Server Database
 - User Roles – User, Author and Administrator


## Primary Features
 - Home Page (Last 4 posts) – shows excerpts from the last 4 blog posts;
 - Posts Page - shows all published blog posts.
 - User Registration – email, full name, password, confirm password requirements;
 - User Login – email and password;
 - Admin Panel - change password.

## Additional Features
### Post Model
- **Index** - a list containing information about all published posts with links for details, editing and deletion;
- **Details** - Title, Author, Full Body, and Publishing Date of the selected post;
- **Create** - a form for creating a new post with fields for Title and Body;
- **Edit** - a form for editing the Title and Body of the selected post;
- **Delete** - a confirmation form for deleting the selected post.
### Roles
- User (default - no role);
- Author;
- Administrator.
###  Authentication
- Logged out users can only visit the main page, the posts list and details, as well as the Login/Register pages;
- Users can also visit the main page, the posts list and details, as well as the admin panel where they can change their password, and the Logout page;
- Authors can visit all of the above, as well as the Create Post page, and the Edit and Delete pages for their own posts;
- Administrators can visit all of the above, as well as the Edit and Delete pages for **all** published posts.
### Dynamic Loading
- The **Latest Posts** section on the main page and the **Posts** page reload dynamically, letting the user see when a new post is created (or an old one is edited/deleted) without needing to reload the page.
