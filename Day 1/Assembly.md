# Assembly in .NET

An assembly is a fundamental unit of deployment and versioning in the .NET framework, containing compiled code, resources, and metadata necessary for executing a .NET application.

## What is an Assembly?

- **Definition**: An assembly is a logical grouping of one or more files that contain compiled code, metadata, and resources required for a .NET application.
- **Characteristics**:
  - **Compiled Code**: Assemblies contain compiled code in the form of intermediate language (IL) or native machine code.
  - **Metadata**: Assemblies include metadata that describe the types, members, and dependencies of the contained code.
  - **Resources**: Assemblies can include additional resources such as images, icons, configuration files, and localization data.
  - **Versioning**: Assemblies support versioning, allowing multiple versions of the same assembly to coexist on a system and ensuring compatibility between different versions of an application.

## Types of Assemblies

1. **Executable (EXE)**:

   - Executable assemblies contain code that can be executed directly by the operating system, typically representing standalone applications.

2. **Class Library (DLL)**:

   - Class library assemblies contain reusable code that can be referenced and used by other applications or assemblies.

3. **Dynamic Link Library (DLL)**:
   - Dynamic link library assemblies are similar to class library assemblies but can be dynamically loaded at runtime.
