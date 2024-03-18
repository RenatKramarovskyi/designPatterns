### 1. Composition Over Inheritance
The `MilitaryLicense` class showcases Composition Over Inheritance by implementing multiple interfaces (`IDocument`, `IQRcodeable`, `IDocumentAction`) 
instead of inheriting from multiple document classes. 
This approach allows for greater flexibility and avoids the complexities and rigidities associated with dep class hierarches.

### 2. Open-Closed Principle (OCP)
The code exemplifies OCP through new document functionalities implemented via the `IDocumentAction` interface.

### 3. Interface Segregation Principle (ISP)
The code follows ISP by using separate interfaces - [`IDocument`](Interfaces/IDocument.cs) for documents with and without action functions, respectively.

### 4. Dependency Inversion Principle (DIP)
DIP is demonstrated in the code by transferring objects of created documents under a common interface `IDocument`, promoting flexibility and scalability.

### 5. DRY Principle
The code avoids code duplication by implementing classes in a way that prevents redundant code. The `ActionDocument` base class object is utilized to avoid creating identical classes for different document types.

### 6. Single Responsibility Principle (SRP)
The Single Responsibility Principle (SRP) states that a class should have only one reason to change. In simpler terms, it means that a class should be responsible for doing only one thing.

The `Container` class in the codebase exemplifies SRP by managing a group of documents and outputting them in different forms. It focuses solely on this responsibility without including unrelated functionalities, such as creating documents or processing their data.
The implementation of SRP can be observed in the following part of the code:
- [Container class](Container.cs): Responsible for managing documents and their presentation.

### 7. Composition Over Inheritance
The `MilitaryLicense` class showcases Composition Over Inheritance by implementing multiple interfaces (`IDocument`, `IQRcodeable`, `IDocumentAction`, etc) instead of inheriting from multiple document classes. This approach allows for greater flexibility and avoids the complexities and rigidities associated with deep class hierarchies.

### 8. KISS Principle
The code follows KISS by maintaining simplicity, readability, and shorter classes, ensuring that client code responsibilities are clear and concise.

### 9. YAGNI Principle
The code adheres to YAGNI by avoiding implementation of redundant or additional functionalities, focusing only on required features.




