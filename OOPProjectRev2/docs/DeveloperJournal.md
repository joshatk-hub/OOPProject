### 10/24/2026
- established initial project structure and classes/models/services (base and derived classes); under commit `14f9b4a`
- no notable errors or bugs
- utilized AI to assist with understanding the requirements for the project

### 10/29/2026
- implemented models and DataStore to read and write json files;
- made account an abstract class, created customer and admin accounts;
- implemented cart class to hold orders, calculate prices; persistent data via DataStore use
- removed unneeded classes that were taking up space
- utilized AI to assist in understand JSON serialization and deserialization
- cart class wasn't saving data for a bit, but was fixed by adding a save method to the cart class and calling it in the appropriate places

### 11/3/2026
- implemented seasonal visibility
- no notable errors or bugs
- no AI assistance 

### 11/10/2026
- implemented cart add/change/remove functionality, found out i can't use many abstract classes due to json serialization
- turned in 3B for grading
- began adding pricing and operations rules
- encountered a bug with the baker's dozen rule; it was calling name instead of category. fixed
- implemented the beginnings of an account system; only loose string passwords. worked as a prototype
- utilized AI to assist in understanding how to structure the data
- utilized AI to assit in implementing an interface (IDataRepository)

### 11/16/2026
- implemented account system with proper password hashing and salting; replaced the loose string password matching
- implemented order confirmation system tied to accounts; guest order confirmations are shown but not persisted
- implemented order saving, deleting, and applying to the cart; tied directly to accounts
- bug with order confirmation system; it was tied to a separate json and the account couldn't pull from it lol. fixed
- first implemented order confirmation system for accounts only; then created a simple guest version
- utilized AI to assist in understanding how to structure the data further
- utilized AI to assist in implementing a secure password hashing and salting system
- utilized AI to assist in implementing the order confirmation system and wiring it to controls

### 11/17/2026
- final bug fixes and testing; no notable errors or bugs
- final pushes
- done