/*
// Comprising a .net core c# application running server side, and a sqlite (local, memory) database. Estimated table size and ram requirements will be calculated as we go, prediting 
// max number of users/transactions we can handle before migrating to mariadb or postgresql or maybe something else?

// DB Tables - to be stored in a local mysqlite database. 

// Longer-term, large tables to be migrated to installed mariadb.
// All by 64 Id - if not default on EntityFramework, easy enough to override in a single base class.

// Welcome screen
// ->Creates an id for them, and prompts for a unique handle with which to proceed
*/

namespace puttr
{
  public class User
  {
    public int id,
    public string handle, 
    public string email, // not set if not confirmed
    // List<String> device // Array? For large numbers, 
    datetime visited,
    datetime emailConfirmed
  };
  
  public class Personal
  {
  
  };
  
  public class Authorization
  {
    int id;
    guid unique_id  //alt key
    generated_at datetime;
    user_id;//fk to User
    ip_addr from_ip; = not set if not confimed
    text to_email;
  };
  
  enum Status { None=0; SentEmail; Confirmed; Recinded; Blocked };

  // Personal

  // MediaType
  public class MediaType
  {
    public int id;
    public string description;

Media

Brand
-> brandname.puttr.uk : shop front (normal user) & control panel (admin)



Product

Design

Manufacturer

Retailer

