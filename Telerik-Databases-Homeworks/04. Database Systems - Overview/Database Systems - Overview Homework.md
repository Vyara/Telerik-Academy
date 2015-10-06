## **Database Systems - Overview Homework**


 **1. What database models do you know?**
* **Hierarchial** - This is a data model in which the data is organized into a tree-like structure. The data is stored as records which are connected to one another through links. A record is a collection of fields, with each field containing only one value. The entity type of a record defines which fields the record contains.The hierarchical database model mandates that each child record has only one parent, whereas each parent record can have one or more child records. In order to retrieve data from a hierarchical database the whole tree needs to be traversed starting from the root node.
<br><br>
* **Network / graph** - This is a database model conceived as a flexible way of representing objects and their relationships. Its distinguishing feature is that the schema, viewed as a graph in which object types are nodes and relationship types are arcs, is not restricted to being a hierarchy or lattice.
<br><br>
* **Relational (table)** - This is an approach to managing data using a structure and language consistent with first-order predicate logic. In the relational model of a database, all data is represented in terms of tuples, grouped into relations. A database organized in terms of the relational model is a relational database.The purpose of the relational model is to provide a declarative method for specifying data and queries: users directly state what information the database contains and what information they want from it, and let the database management system software take care of describing data structures for storing the data and retrieval procedures for answering queries.Most relational databases use the SQL data definition and query language; these systems implement what can be regarded as an engineering approximation to the relational model. A table in an SQL database schema corresponds to a predicate variable; the contents of a table to a relation; key constraints, other constraints, and SQL queries correspond to predicates. 
<br><br>
* **Entity-relationship** - This is a data model for describing the data or information aspects of a business domain or its process requirements, in an abstract way that lends itself to ultimately being implemented in a database such as a relational database. The main components of ER models are entities (things) and the relationships that can exist among them.
<br><br>
* **Document model** - This is a computer program designed for storing, retrieving, and managing document-oriented information, also known as semi-structured data. Document-oriented databases are one of the main categories of NoSQL databases and the popularity of the term "document-oriented database" has grown with the use of the term NoSQL itself. Document-oriented databases are inherently a subclass of the key-value store, another NoSQL database concept. The difference lies in the way the data is processed; in a key-value store the data is considered to be inherently opaque to the database, whereas a document-oriented system relies on internal structure in the document order to extract metadata that the database engine uses for further optimization. Although the difference is often moot due to tools in the systems,[a] conceptually the document-store is designed to offer a richer experience with modern programming techniques. XML databases are a specific subclass of document-oriented databases that are optimized to extract their metadata from XML documents.
<br><br>
* **Entity-attribute-value** - This is a data model to describe entities where the number of attributes (properties, parameters) that can be used to describe them is potentially vast, but the number that will actually apply to a given entity is relatively modest. In mathematics, this model is known as a sparse matrix. EAV is also known as object–attribute–value model, vertical database model and open schema.
<br><br>
* **Object-oriented** - This is a database management system in which information is represented in the form of objects as used in object-oriented programming. Object databases are different from relational databases which are table-oriented. Object-relational databases are a hybrid of both approaches.
<br><br>
* **Star schema** - This is the simplest style of data mart schema. The star schema consists of one or more fact tables referencing any number of dimension tables. The star schema is an important special case of the snowflake schema, and is more effective for handling simpler queries.

**2. Which are the main functions performed by a Relational Database Management System (RDBMS)?**
* Creating / altering / deleting tables and relationships between them (database schema)
* Adding, changing, deleting, searching and retrieving of data stored in the tables
* Support for the SQL language
* Transaction management 

**3. Define what is "table" in database terms.**

A table is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect. A table has a specified number of columns, but can have any number of rows. Each row is identified by one or more values appearing in a particular column subset. 

**4. Explain the difference between a primary and a foreign key.**

The columns subset which uniquely identifies a row in a table is the primary key. The foreign key uniquely identifies a row of another table. In simpler words, the foreign key is defined in a second table, but it refers to the primary key in the first table.

**5. Explain the different kinds of relationships between tables in relational databases.**

* **One-to-many** - A single record in the first table has many corresponding records in the second table.
* **Many-to-many** - Records in the first table have many corresponding records in the second one and vice versa(Implemented through additional table).
* **One-to-one** - A single record in a table corresponds to a single record in the other table(Used to model inheritance between tables).


**6. When is a certain database schema normalized?**
  * **What are the advantages of normalized databases?**
  
  A database schema is normalized, when its columns (attributes) and tables (relations) are organized in such a way, that it minimizes redundancy. 
  
  The advantages are:
  
  * The collection of relations is freed from undesirable insertion, update and deletion dependencies;
  * The need for restructuring the collection of relations, as new types of data are introduced, is reduced, and thus the life span of application programs is increased;
  * The relational model becomes more informative to users;
  * The collection of relations is made neutral to the query statistics, where these statistics are liable to change as time goes by;

**7. What are database integrity constraints and when are they used?**

They ensure data integrity in the database tables and enforce data rules which cannot be violated.

The constrains can be:
* **Primary key constraint** - it ensures that the primary key of a table has unique value for each table row;
* **Unique key constraint** - it ensures that all values in a certain column (or a group of columns) are unique;
* **Foreign key constraint** - it ensures that the value in given column is a key from another table;
* **Check constraint** - it ensures that values in a certain column meet some predefined condition;

The integrity constraints are used when the database needs increased:

* **stability** (one centralized system performs all data integrity operations)
* **performance** (all data integrity operations are performed in the same tier as the consistency model)
* **re-usability** (all applications benefit from a single centralized data integrity system)
* **maintainability** (one centralized system for all data integrity administration)


**8. Point out the pros and cons of using indexes in a database.**

**Pros:**
* speed up searching of values in a certain column or group of columns;
* can be used in big tables;

**Cons:**
* adding and deleting records in indexed tables is slower
* should only be used for big tables;

**9. What's the main purpose of the SQL language?**

Its main purpose is managing data held in a relational database management system, which consists of:
* Creating, altering, deleting tables and other objects in the database;
* Searching, retrieving, inserting, modifying and deleting table data (rows)

**10. What are transactions used for?**

Transactions are a sequence of database operations which are executed as a single unit - either all of them execute successfully or none of them are executed at all.
They are used to guarantee the consistency and the integrity of the database.

**11. Give an example.**

Withdrawing money from an ATM or a Bank account. The transaction in such a case should not be processed if one or more of the following steps fails:

1) Verify account details.
2) Accept withdrawal request
3) Check balance
4) Update balance
4) Dispense money

In other words, the money withdrawal should only be processed when all of the above steps are valid processes.

**12. What is a NoSQL database?**

It is a database, that provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases.They mostly use a document-based model (non-relational).

**13. Explain the classical non-relational data models.**
* Data is stored as documents;
* Single entity (document) is a single record;
* Documents do not have a fixed structure;

**14. Give few examples of NoSQL databases and their pros and cons.**

 #### Redis:
 
**Pros:**
* Very fast
* Stores data in a variety of formats: list, array, sets and sorted sets
* Mass insertion of data to prime a cache
* Can back data to disk

**Cons:**
* Complex to configure


 #### MongoDB:

 **Pros:**
 * Schema-less. If you have a flexible schema, this is ideal for a document store like MongoDB. This is difficult to implement in a performant manner in RDBMS
 * Ease of scale-out. Scale reads by using replica sets. Scale writes by using sharding (auto balancing). Just fire up another machine and away you go. Adding more machines = adding more RAM over which to distribute your working set.
 * You can choose what level of consistency you want depending on the value of the data 
 
 **Cons:** 
* Data size in MongoDB is typically higher due to e.g. each document has field names stored it
* Less flexibity with querying (e.g. no JOINs)
* No support for transactions - certain atomic operations are supported, at a single document level
* Less up to date information available/fast evolving product

#### CouchDB
**Pros:**
* Simplicity. You can store any JSON data, and each document can have any number of binary attachments.
* Thanks to map/reduce, querying data is somewhat separated from the data itself. This means that you can index deeply within your data, and on whether or not something exists, and across types, without paying a significant penalty. You just need to write your view functions to handle them.

**Cons:**
* Arbitrary queries are expensive. To do a query that you haven't created a view for, you need to create a temporary view. 
* There's a bit of extra space overhead with CouchDB compared to most alternatives.
