# Pràctica Tractament de Dades

Aquest repositori conté diversos exercicis per practicar el tractament de dades utilitzant diferents formats i tecnologies en C#.

## Exercicis

### Exercici 1: Processament i emmagatzematge d'arxius en C#

En el primer exercici es fa una clàsica recerca d'informació a la xarxa de les 3 formes de donar-li format les dades que s'ens demana.

#### Conclusió
Ha sigut divertit veure com a StackOverflow o a forums la gent discutia per què era més cómode utilitzar BPML que YAML o quin era millor que l'altre.

### Exercici 2: JSON a YML API REST

#### Descripció
En aquest exercici es crea una API REST utilitzant C# per convertir dades en format JSON a YAML. La conversió es realitza mitjançant una API que rep un objecte JSON i retorna la versió YAML d'aquest objecte.

```bash
# exemple utilitzat, a la screenshot el resultat
curl -X POST http://localhost:5077/api/jsontoyaml -H "Content-Type: application/json" -d '
    {"name":
        "Youssef", 
        "age":21, 
        "city":"Figueres", 
        "skills":["C#", "SQL", "JavaScript"]
    }'
```

### Exercici 3: archiu a JSON a Base De Dades

*ajaj nidea*
