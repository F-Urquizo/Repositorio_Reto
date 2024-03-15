1. Como usuario, quiero que el juego tenga un elemento narrativo para sentirme más inmerso y conectado con el mundo del juego.
	Issues:
		Creación de escenas narrativas en Unity
	Labels:
		Frontend
		Videojuego
		No Funcional


		Habilitación de interactividad del usuario con escenas narrativas
	Labels:
		Frontend
		Videojuego
		Funcional 


2. Como usuario, quiero tener un inventario de cartas para conocer los recursos disponibles que puedo utilizar durante el juego.
	Issues:
		Creación de escenario interactivo para poder visualizar cartas
	Labels:
		Frontend
		Videojuego
		Funcional 

		Diseño de base de datos para almacenar las cartas que estén en el inventario
	Labels:
		Backend
		BDD
		Funcional 
	

3. Como usuario, quiero poder armar mi mazo con cartas de mi inventario para personalizar mi estrategia y forma de jugar.
	Issues:
		Sistema para seleccionar y guardar configuraciones de mazo.
	Labels:
		Videojuego
		Back-end / Front-end  ???
		Funcional

		Registro de mazo en base de datos
	Labels:
		BDD
		Back-end
		Funcional 


4. Como usuario, quiero recibir recompensas al superar un nivel para sentir un sentido de progreso y logro.
	Issues:
		Creación de escena de fin de nivel
	Labels:
		Videojuego
		Back-end / Front-end???
		Funcional

		Implementación de sistema de recompensas en Unity (cartas boca abajo, selección de cartas, adición al inventario)
	Labels:
		Videojuego
		Front-end
		Funcional

		Añadir cartas seleccionadas al inventario en la base de datos:
	Labels:
		BDD
		Back-end
		Funcional


5. Como usuario, quiero que haya un registro de estadísticas para poderlas ver durante el juego
	Issues:
		Implementación de sistema que indique progreso en el juego en la escena de niveles en Unity
	Labels:
	Videojuego
	Front-end
	No-funcional

		Almacenamiento de estadísticas de progreso en BDD:
	Labels:
		BDD
		Back-end
		Funcional


		Inclusión del tiempo en escena de juego:
	Labels:
		Videojuego
		Front-end
		Funcional


		Indicación de vida de cartas activas en el juego
	Labels:
		Videojuego
		Front-end
		Funcional


		Recuperación de información de cartas activas de base de datos:
	Labels:
		Web
		Back-end
		Funcional 

		Demostrar estadísticas de cartas si son seleccionadas en inventario:
	Labels:
		Videojuego
		Front-end
		Funcional 


6. Como usuario, quiero poder tener una forma segura de ingresar al juego para no ser vulnerable a la extracción de información sensible.
	Issues:
		Diseño de login en página web en la que esté hosteado el juego
	Labels:
		Web
		Front-end
		Funcional??


7. Como usuario, quiero que los niveles progresen en dificultad para mantener el juego desafiante y entretenido a medida que avanzo.
	Issues:
		Diseño de niveles (crear mazos de oponentes)
	Labels:
		Videojuego
		n/a
		Funcional

		Implementar mejoras a los rivales de cada nivel (mejor capacidad estratégica / cartas más poderosas)
	Labels:
		Videojuego
		Back-end
		Funcional


8. Como usuario, quiero que mi videojuego sea accesible desde internet para poder jugarlo en cualquier momento y lugar.
	Issues:
		Desarrollo de página web para alojar el videojuego
	Labels:
		Web
		Front-end
		Funcional

		Diseñar página web (apariencia):
	Labels:
		Web
		Front-end
		No-funcional


9. Como usuario, quiero que los niveles se jueguen en un tablero virtual para tener una experiencia de juego clara y organizada.
	Issues:
		Creación de escena de tablero:
	Labels:
		Videojuego
		Front-end
		Funcional


		Diseñar tablero:
	Labels:
		Videojuego
		Front-end
		No funcional


		Implementar interactividad con cartas en la escena:
	Labels:
		Videojuego
		Back-end
		Funcional
	

10. Como usuario, quiero que cada carta tenga una imagen descriptiva, un nombre, así como información relevante como costo, vida y daño para tomar decisiones informadas durante el juego.
	Issues:
		Mostrar estadísticas de cada carta sobre la misma carta
	Labels:
		Videojuego
		Front-end
		Funcional


		Almacenar información de las cartas:
	Labels:
		BDD
		Back-end
		Funcional 


		Diseño de apariencia de cartas:
	Labels:
		Videojuego
		Front-end
		No-funcional 


11. Como usuario, quiero que existan mecánicas que incentiven la estrategia para que el juego sea más retador y estimulante mentalmente.
	Issues:
		Desarrollo de mecánica de combate de elementos:
	Labels:
		Videojuego
		Back-end
		Funcional

		Implementación de indicador de estado ventajoso/vulnerable/neutro contra carta contraria:
	Labels:
		Videojuego
		Front-end
		Funcional


		Implementación de mecánica de obtención de Elixir en función de vida de carta
	Labels:
		Videojuego
		Back-end
		Funcional


		Implementación de indicador de estado de mayor ganancia de Elixir en cada carta activa:
	Labels:
		Videojuego
		Front-end
		Funcional


		Construcción de mazo:
	Labels:
		Videojuego
		Back-end
		Funcional


12. Como usuario, quiero que mi videojuego sea intuitivo para poder aprender a jugarlo rápidamente y sin frustraciones.
	Issues:
		Desarrollo de escenas de introducción al juego:
	Labels:
		Videojuego
		Front-end
		Funcional

		Manejar “edge-cases” que podrían impedir el flujo del juego (e.g. escasez de Elixir)
	Labels:
		Videojuego
		Back-end
		Funcional


13. Como usuario, quiero que mi videojuego sea divertido para disfrutar del tiempo que paso jugándolo.
	Issues:
		Playtest del juego
	Labels:
		Videojuego
		n/a
		Funcional 


14. Como usuario, quiero que el juego tenga un recurso que se deba administrar durante los niveles para añadir una capa de estrategia sobre cómo y cuándo usar mis recursos.
	Issues:
		Implementación de sistema de ganancia de Elixir por turno
	Labels:
		Videojuego
		Back-end
		Funcional

		Almacenamiento de información de Elixir de cada carta en base de datos:
	Labels:
		BDD
		Back-end
		Funcional

		Despliegue de Elixir en tiempo real durante un nivel en escena
	Labels:
		Videojuego
		Front-end
		Funcional


15. Como usuario, quiero que existan condiciones claras de victoria para saber qué objetivo tengo que alcanzar para ganar.
	Issues:
		Implementación de corte de juego en caso de insuficiencia de cartas de oponente
	Labels:
		Videojuego
		Back-end
		Funcional


16. Como usuario, quiero que existan condiciones claras de derrota para entender cómo puedo perder y aprender de mis errores.
	Issues:
		Implementación de corte de juego en caso de insuficiencia de cartas
	Labels:
		Videojuego
		Back-end
		Funcional

		Implementación de corte de juego en caso de expiración de tiempo
	Labels:
		Videojuego
		Back-end
		Funcional


17. Como usuario, quiero que mi videojuego tenga un menú principal para navegar fácilmente entre diferentes secciones del juego.
	Issues:
		Creación de escena de menú
	Labels:
		Videojuego
		Front-end
		Funcional

		Diseño de escena de menú
	Labels:
		Videojuego
		Front-end
		No-funcional

		Conexión de escena de menú principal con escenas correspondientes:
	Labels:
		Videojuego
		Back-end
		Funcional


18. Como usuario, quiero que el videojuego no sea frustrante para mantener una experiencia positiva y gratificante.
	Issues:
		???
	Labels:
		???
		???
		???


19. Como usuario, quiero que el juego sea para un solo jugador para poder disfrutar del juego a mi propio ritmo sin la necesidad de otros jugadores.
	Issues:
		Programación de IA de oponentes
	Labels:
		Videojuego
		Back-end
		Funcional

		Diseño de oponentes
	Labels:
		Videojuego
		Front-end
		No-funcional 


20. Como usuario, quiero que el juego tenga música de fondo para poder disfrutar de mi estancia jugando. 
	Issues:
		Desarrollar e integrar un reproductor de música dentro del juego que pueda manejar la reproducción de pistas de audio en bucle.
	Labels:
		Videojuego
		Front-end
		No Funcional


21. Como usuario,  quiero que las cartas se pueden diferenciar para que no arruiné mi estrategia por confusiones
	Issues:
		Crear ciertos diferenciadores entre los tipos de cartas
	Labels:
		Videojuego
		Front-end
		No Funcional


22. Como usuario, quiero que mi progreso se guarde automáticamente para que no repita el progreso sólo porque se me olvidó guardar
	Issues:
		Crear funciones que guarden el progreso del jugador (player prefs)
	Labels:
		Videojuego
		Back-end
		No Funcional ?


23. Como usuario, quiero que el juego sea agradable a la vista para que no sea un factor que me aleje del juego
	Issues:
		Tener un estilo visual para el juego
	Labels:
		Videojuego
		Front-end
		No Funcional 


24. Como usuario, quiero que el juego tenga un cierto grado de rejugabilidad para probar nuevas estrategias que no realicé la primera vez
	Issues:
		Poder repetir niveles, después que el jefe final sea derrotado
	Labels:
		Videojuego
		Front-end
		Funcional 


25. Como usuario, quiero effectos al realizar una acción para que tenga una estimulación en mis sentidos y saber el impacto de mi acción
	Issues:
		Añadir efectos de sonido
	Labels:
		Videojuego
		Front-end
		No Funcional 

		Añadir efectos  visuales cuando se realiza una acción
	Labels:
		Videojuego
		Front-end
		No Funcional 


25. Como usuario, quiero effectos al realizar una acción para que tenga una estimulación en mis sentidos y saber el impacto de mi acción
	Issues:
		Desarrollar e integrar efectos de sonido al presionar una carta
	Labels:
		Videojuego
		Front-end
		No Funcional


26. Como usuario, quiero que el juego tenga configuraciones para que pueda tener una mejor experiencia como me gusta jugar
	Issues:
		Añadir un botón de silenciar el juego
	Labels:
		Videojuego
		Front-end
		No Funcional


Issues adicionales:
	Creación de API que vincule videojuego con BDD (relación con página web??):
Labels:
	Web
	Back-end
	Funcional

	Creación de tablas de BDD:
Labels:
	BDD
	Back-end
	Funcional

	Prueba de BDD con datos dummy
Labels:
	BDD
	Back-end
	Funcional 