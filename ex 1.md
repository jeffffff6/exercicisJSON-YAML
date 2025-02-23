# Exercici 1: Processament i emmagatzematge d'arxius en C#

En aquest exercici, presentaré diverses biblioteques i documentació per a processar i emmagatzemar fitxers en formats XML, YAML i BPML.

## 1. XML (Extensible Markup Language)

Per treballar amb arxius XML en C#, faig servir la llibreria **System.Xml**, que ofereix diverses eines per llegir, modificar i escriure arxius XML. Algunes de les classes més rellevants són:

- **XmlDocument**: Permet carregar, modificar i desar documents XML.
- **XDocument** (Llibreria LINQ to XML): Ofereix una forma més moderna i eficient de gestionar XML.
- **XmlSerializer**: S'utilitza per a la serialització i deserialització d'objectes en format XML.

### Documentació
- [Microsoft Docs / System.Xml](https://learn.microsoft.com/en-us/dotnet/api/system.xml)
- [Microsoft Docs / LINQ to XML](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/linq-to-xml-overview)

## 2. YAML (YAML Ain't Markup Language)

Per treballar amb YAML en C#, utilitzo la llibreria **YamlDotNet**, que facilita la càrrega, modificació i desament de dades en aquest format. És molt útil per a configuracions i per a l'intercanvi de dades.

Algunes de les funcionalitats que ofereix són:
- Serialització i deserialització d'objectes.
- Suport per a estructures jeràrquiques complexes.
- Manipulació eficient de dades YAML.

### Documentació
- [YamlDotNet GitHub](https://github.com/aaubry/YamlDotNet)
- [YamlDotNet NuGet](https://www.nuget.org/packages/YamlDotNet)

## 3. BPML (Business Process Modeling Language)

El format BPML s'utilitza per modelar processos de negoci i es fonamenta en XML. En C#, puc treballar amb BPML utilitzant llibreries XML com:
- **System.Xml.Linq**: Facilita la manipulació de documents BPML en format XML.
- **BPMN Model API**: Algunes solucions de tercers proporcionen suport per a BPML i BPMN (Business Process Model and Notation).
- **Camunda Model API**

### Documentació
- [Microsoft Docs / System.Xml.Linq](https://learn.microsoft.com/en-us/dotnet/api/system.xml.linq)
- [Camunda BPMN](https://docs.camunda.org/manual/latest/user-guide/model-api/)

## Conclusió

Aquestes llibreries ens permeten gestionar diversos formats de dades en C# per facilitar-nos el tractamentde les dades. 