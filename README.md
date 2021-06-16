# junio16


# En el package management

```c#
Install-Package Microsoft.EntityFrameworkCore.Relational -Version 6.0.0-preview.4.21253.1
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.0-preview.4.21253.1
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.0-preview.4.21253.1
```

# En el package management, ejecutar el scaffold

```c#
// usar este
Scaffold-DbContext "Data Source=(local)\sqlexpress;Initial Catalog=Sakila;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models 
// o este
Scaffold-DbContext "Data Source=(local)\sqlexpress;Initial Catalog=Base9Junio;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models  -table Comentarios -dataannotations -force
```