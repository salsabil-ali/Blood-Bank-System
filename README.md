# Blood Bank Management System

## 1. Project Overview
A system to manage blood donors, donations, blood units, hospitals, and blood requests efficiently using **C#**, **Windows Forms**, **ADO.NET**, and **SQL Server**.

---

## 2. System Architecture
The system follows a **3-Tier Architecture** to separate concerns and improve maintainability:

|       Layer           |      Responsibility        |
| :-------------------- | :------------------------- |
| **Presentation (UI)** | Forms and User Interaction |
| **Business Logic (BLL)** | Processing & Validation |
| **Data Access (DAL)** | Database Communication     |

---

## 3. Technology Stack
*   **Language:** C#
*   **UI Framework:** Windows Forms (WinForms)
*   **Data Access:** ADO.NET
*   **Database:** SQL Server (T-SQL)

--

##**Blood Bank Management System – System Description**

A Blood Bank Management System is a database system designed to organize and manage all information related to blood donation, storage, and distribution. The system helps blood banks maintain accurate records of donors, blood types, blood units, hospitals, and requests for blood. Its main goal is to ensure that blood is available when needed while maintaining safe and efficient management of blood resources.
The system stores information about donors, including their personal details, contact information, and blood type. Each donor may donate blood multiple times over a period of time. Every donation is recorded in the system along with important information such as the donation date and the amount of blood collected.
After blood is donated, it is stored in the blood bank as blood units. 


Each unit has a specific blood type, collection date, and expiration date. The system tracks these blood units to ensure proper storage and to prevent the use of expired blood.
Hospitals or medical centers may send blood requests to the blood bank when they need blood for patients. 


The system records each request and links it to the hospital that made the request. Once a request is approved, the blood bank supplies the appropriate blood units from its inventory.



This system improves efficiency by reducing manual record keeping and minimizing errors. It also allows the blood bank staff to quickly search for compatible blood types, monitor available inventory, and track donation history.
 
