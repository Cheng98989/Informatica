Supporto Utenti (MS-4.1)
_____________________________


L'ufficio Supporto Informatico Utenti di un'azienda vuole utilizzare un software per tenere traccia delle richieste di intervento che riceve dai vari reparti.

Ogni richiesta è identificata da:
	- un codice richiesta (alfanumerico di 5 caratteri)
		readonly,
		get,
		static list per univicità

	- una data\ora richiesta (si accettano richieste solo dalle 07:00 al 17:00 di ogni giorno tra il lunedì ed il venerdì)
		get,
		set,

	- una email del richiedente (obbligatorio)
		get,
		set,

	- un reparto (da scegliere tra tre possibili opzioni: “produzione”, “amministrazione”, “vendita”)
		get,
		set,
		static list per categorie,

	- descrizione richiesta
		attrib publico

	- livello urgenza (numero intero tra 1 e 100)
		get
		set

	- data-ora risoluzione problema.
		get
		set
		flag se non impostato ignoro il valore


Si vuole realizzare un programma che gestisca l'archivio delle preferenze espresse ed effettui alcune analisi dei dati.

Il programma dovrà consentire di:

1. archiviare i dati di ogni richiesta

2. dato il codice di una richiesta, consentire all'utente di inserire la data ora di risoluzione del problema

3. dato dall'utente un reparto (tra i tre previsti),  visualizzare l'elenco delle richieste inevase per quel reparto in ordine decrescente di urgenza o data-ora richiesta

4. dato  il nome di un richiedente, cancellare dall'archivio tutte le richieste di quel richiedente

5. dato un range di livelli di urgenza (es. tra 80 e 90), calcolare e visualizzare il numero di ore che sono occorse mediamente per risolvere problemi con un livello di urgenza nel range dato