# 📚 **Estructuras de Datos Lineales - Pilas, Colas y Listas** 🖥️

## 🎯 Descripción

¡Proyecto de **Estructuras de Datos Lineales**! En esta aplicación desarrollada en **C#** con **Windows Forms**, vas a aprender a manejar y trabajar con tres estructuras de datos fundamentales: **Pilas**, **Colas** y **Listas**. La aplicación está pensada para resolver problemas prácticos mediante la implementación de **Stack<T>**, **Queue<T>** y **List<T>** de las colecciones genéricas de C#.

## 🛠️ Requisitos y Funcionalidades

### 🚪 **Interfaz de Seguridad Inicial**
- La aplicación presenta una **pantalla de inicio** que solicita una contraseña enmascarada (valor: **123**).
- Si la contraseña es correcta, el usuario accederá a un menú de opciones con tres módulos diferentes, que corresponden a las estructuras de datos: **Pila**, **Cola** y **Lista**.

### 🏗️ **Implementación de Estructuras de Datos Lineales**

#### 1️⃣ **Estructura Pila: PilaBolos (Stack<T>)**
La empresa **Bolera Robles S.A.S** desea gestionar las reservas de sus pistas de bolos utilizando una pila, en la que el último registro ingresado sea el primero en salir (LIFO). La reserva se realiza con los siguientes detalles:
- Datos del titular (número de identificación, nombre, dirección).
- Número de jugadores (1-6).
- Selección del número de pista de bolos (1-4).
- Fecha de la reserva.
- Afiliación a caja de compensación.

**Cálculo del valor de la reserva**:
- **Valor base:** $50,000.
- **Valor adicional por número de jugadores** y **pista seleccionada** (según tablas de referencia).
- **Descuento** si está afiliado a una caja de compensación.

Se mostrarán los registros de las reservas realizadas en un **DataGridView** y se calculará la **sumatoria total** de las reservas al hacer clic en la opción **Reportes**.

#### 2️⃣ **Estructura Cola: ColaEPS (Queue<T>)**
La **EPS SanarteYa** necesita gestionar el flujo de pacientes que se atienden para sus citas médicas usando una cola, donde el primer registro ingresado será el primero en salir (FIFO). Los pacientes son registrados con:
- Número de identificación.
- Nombre completo.
- Edad (0+).
- Tipo de consulta (prioritaria, general, urgencia).
- Fecha de cita médica.

**Cálculo del tiempo de espera**:
- Basado en la edad del paciente y el tipo de consulta (según la tabla de tiempos de espera).

En este módulo, los registros de pacientes se mostrarán en un **DataGridView** y al elegir la opción de **Reportes**, se mostrará el **total de registros** ingresados.

#### 3️⃣ **Estructura Lista: ListaJardin (List<T>)**
El **jardín infantil Los Millenials** requiere gestionar el registro de estudiantes, permitiendo agregar, consultar y eliminar registros. Cada estudiante tiene:
- Número de registro civil.
- Nombre completo.
- Condición especial (autismo, hiperactividad, discapacidad).
- Estrato socioeconómico (1-6).
- Fecha de nacimiento.
- Necesidad de terapia (sí/no).

Los estudiantes se gestionan con una **Lista** y se pueden **eliminar** mediante la consulta de su número de registro civil. Si el estudiante existe, se procede a eliminarlo.

#### 📝 **Menú de Opciones**
El usuario podrá acceder a las siguientes opciones desde un menú de navegación:
- **Registrar**: Añadir nuevos registros a las estructuras (Pila, Cola o Lista).
- **Eliminar**: Eliminar registros de las estructuras.
- **Reportes**: Ver reportes con la información acumulada.
  
**Nota**: Los registros se visualizarán en un **DataGridView** para cada módulo, y algunos valores (como el tiempo de espera y el valor de las reservas) estarán calculados y no podrán ser editados manualmente.

---

## 🧑‍💻 **Cómo Funciona la Aplicación**

1. **Pantalla de Acceso**:
   - El sistema solicita una **contraseña enmascarada** (valor **123**).
   - Al ingresar la contraseña correcta, el usuario es redirigido al menú de **Pilas, Colas y Listas**.
   
2. **Formulario de la Pila (PilaBolos)**:
   - Se pueden registrar las reservas y calcular el valor a pagar con base en las condiciones definidas (número de jugadores, pista seleccionada, afiliación a caja de compensación).
   - Los datos se almacenan en una estructura **Pila** (último en entrar, primero en salir).
   - Los registros se visualizan en el formulario y se calcula el total acumulado.

3. **Formulario de la Cola (ColaEPS)**:
   - Se gestionan los registros de pacientes (nombre, edad, tipo de consulta).
   - Se calcula el tiempo de espera en función de la edad y tipo de consulta.
   - Los registros se almacenan en una estructura **Cola** (primero en entrar, primero en salir).
   - Al seleccionar **Reportes**, se muestra el número total de registros.

4. **Formulario de la Lista (ListaJardin)**:
   - Se gestionan los estudiantes inscritos (nombre, número de registro, condición especial, etc.).
   - Se pueden eliminar registros mediante la consulta del número de registro civil.
   - Los registros se almacenan en una **Lista** y se visualizan en un **DataGridView**.
