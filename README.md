# BugTracker - Programación en Capas


## 1. Programación en 3 Capas 

- **Presentación (GUILayer):** Mediante la capa de presentación se separa la interacción del usuario respecto a la lógica de negocio.
- **Lógica (BusinessLayer):** La capa de negocio expone la lógica necesaria a la capa de presentación para que el usuario, a través de la interfaz, interactúe con las funcionalidades de la aplicación.
- **Acceso a datos (Data Access):**  La necesidad de vincular los datos guardados en una base de datos relacional, con los objetos de una aplicación orientada a objetos, determinó la aparición del concepto de persistencia de objetos. Siguiendo el estilo de desarrollo en tres capas, la persistencia queda recogida en su propia capa, separada de la lógica de negocio y de la interfaz de usuario.

- **Entidades (Entity):** Aunque aparentemente es una cuarta capa realmente no lo es. Se encarga de contener todos aquellos objetos (clases) que representan al negocio, y esta es la única que puede ser instanciada en las 3 capas anteriores, es decir, solo ella puede tener comunicación con el resto pero su función se limita a únicamente ser un puente de transporte de datos. Esta capa complementa a la Capa de Negocio

**![](https://lh5.googleusercontent.com/o76z7uQg0dRkDHxpMdMwBfyJOb6fftiCzMah3wk5X94-oiaYaROi1ohtM_mEuWXW_87Jo9Qp3aCJR213Y4jMcN6SlPXc2dlQYDBVPmfwkE0_wAJaAljLUjTecL49Jzli40jmfV1V)**

## 2. Patrón Data Access Object (DAO)

Dado lo anterior, el patrón DAO propone separar por completo la lógica de negocio de la lógica para acceder a los datos, de esta forma, el DAO proporcionará los métodos necesarios para insertar, actualizar, borrar y consultar la información; por otra parte, la capa de negocio solo se preocupa por lógica de negocio y utiliza el DAO para interactuar con la fuente de datos.

**![](https://jossjack.files.wordpress.com/2014/06/dao.jpg)**

## 3. Patrón Mapper

Patrón Mapper, que toma como argumento algún tipo de fuente de datos "en bruto" (por ejemplo, un ADO.NET DataReader o DataSet) y asigna los campos a propiedades en un objeto de negocio / dominio.

**![](https://martinfowler.com/eaaCatalog/databaseMapperSketch.gif)**

## 4. Paso a paso hacia programación en 3 Capas
