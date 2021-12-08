<a name='assembly'></a>
# clTest

## Contents

- [Class1](#T-clTest-Class1 'clTest.Class1')
  - [#ctor(id,nom,info,cost)](#M-clTest-Class1-#ctor-System-Int32,System-String,System-String,System-Double- 'clTest.Class1.#ctor(System.Int32,System.String,System.String,System.Double)')
  - [ChangeCostById(id,cost)](#M-clTest-Class1-ChangeCostById-System-Int32,System-Double- 'clTest.Class1.ChangeCostById(System.Int32,System.Double)')
  - [ToString()](#M-clTest-Class1-ToString 'clTest.Class1.ToString')

<a name='T-clTest-Class1'></a>
## Class1 `type`

##### Namespace

clTest

<a name='M-clTest-Class1-#ctor-System-Int32,System-String,System-String,System-Double-'></a>
### #ctor(id,nom,info,cost) `constructor`

##### Summary

Cette fonction est pour construire l'objet.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | premier paramètre, doit être différent |
| nom | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | deuxième paramètre |
| info | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | troisième paramètre |
| cost | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | quatrième paramètre |

<a name='M-clTest-Class1-ChangeCostById-System-Int32,System-Double-'></a>
### ChangeCostById(id,cost) `method`

##### Summary

Cette fonction est pour moddifier le cout de l'objet selon son id.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | premier paramètre, permet de choisir quel objet sera moddifier. |
| cost | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | deuxième paramètre, permet de moddifier le cout. |

<a name='M-clTest-Class1-ToString'></a>
### ToString() `method`

##### Summary

Cette fonction est pour recevoir le nom et les info de l'objet en override la fonction de base .ToString().

##### Returns

Retourne un string comprenant le nom et l'info séparé par un espace.

##### Parameters

This method has no parameters.
