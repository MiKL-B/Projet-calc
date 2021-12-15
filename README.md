# calculatrice

1. Effectuer les 5 opérations en réel : +, -, *, /, %
2. Intégrer les parenthèses
3. Respecter la priorité des opérateurs
4. Interface textuelle & Interface graphique
5. Intégrer la notion de variable :
	a. Affectation d'une valeur ou d'une expression à une variable
	b. Utilisation d'une variable dans une expression
	c. Reset des variables
6. Historique des calculs  & est-il persistant ? (Merci Louis)
7. Afficher en Notation polonaise inversée
	Ex: 2 4 6 - +
		3 2 5 * +  
8. Afficher en prefixé (à la mode lisp)
	Ex : (+ 2 (- 4 6))
9. Intégrer des fonctions (cos, sin, tan, puissance, racinecarree, ...)


# Quid :

 	Que faire en cas d'erreur ?
 		I. division  par zéro : Infini ou Erreur
 		II. En cas d'une variable non initialisée ? 0 ou Erreur ou valeur

 	Notation décimale classique seule ou notation scientifique ou autre ?

 	Quelle précision ?

 	Pensez à PI et e



Protocole  Interface -> Cerveau

2 possibilités :
* Demander un calcul
* Demander un calcul de l'historique


Protocole  Cerveau -> Interface

3 possibilités :
* Donner le résultat d'un calcul
* Renvoyer une erreur
* Renvoyer un calcul de l'historique


# Grammaire BNF (Backus Naur Form) (permet l'analyse lexico-syntaxique)

SNT : symbole non terminal noté <SNT>
ST : symbole terminal noté entre simples quotes '(' ou '1.414' ou 'sqrt'
```
<SCRIPT>          := <AFFECT_EXPR> <END_SCRIPT>
                  := <ARITH_EXPR> <END_SCRIPT>
<END_SCRIPT>      := ';' <SCRIPT>
				  := ';'
				  :=

<AFFECT_EXPR>     := <VARIABLE> <END_AFFECT_EXPR>
<END_AFFECT_EXPR> := '<-' <ARITH_EXPR>

// a * x * x + b * x + c
<ARITH_EXPR>      := <TERM> <END_ARITH_EXPR>
// + b * x + c
<END_ARITH_EXPR>  := '+' <ARITH_EXPR>
                  := '-' <ARITH_EXPR>
                  := 

// b * x
<TERM>            := <FACTOR> <END_TERM>
<END_TERM>        := '*' <TERM>
                  := '/' <TERM>
                  := '%' <TERM>
                  :=
// b ou x
<FACTOR>          := <VARIABLE>
                  := <NUMERIC>
                  := <FUNCTION>
                  := '(' <ARITH_EXPR> ')'
                  := 

// Une variable est une suite de 1 ou plus lettres
<VARIABLE>       := <LETTER> <END_VARIABLE>
<END_VARIABLE>   := <VARIABLE>
				 :=

// 1 ou 12 ou 1.2 ou 0.1 
<NUMERIC>        := <INT_PART> <END_NUMERIC>
<END_NUMERIC>    := '.' <INT_PART>
				 :=
<INT_PART>       := <DIGIT> <END_INT_PART>
<END_INT_PART>   := <INT_PART>
				 :=
<FUNCTION>       := <FUNC_NAME> <END_FUNCTION>
<END_FUNCTION>   := '(' <ARG_LIST> ')'

<ARG_LIST>       := <ARITH_EXPR> <END_ARG_LIST>
<END_ARG_LIST>   := ',' <ARG_LIST>
				 := 

<FUNC_NAME>      := 'sqrt' | 'pow' | 'sin' | 'cos' | 'tan' | 'asin'
				| 'acos' | 'atan' | ...

<LETTER>  := [a-zA-Z]
<DIGIT>  := [0-9]
// ou 
// <DIGIT>  := '0' | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9'
```
