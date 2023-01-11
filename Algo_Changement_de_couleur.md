# Gestion de la souris

OBJECTIF : trouver le pion qui doit changer de couleur

Récuperer la position de la souris
SI Clic gauche de la souris activé
    ALORS 
        SI Pion sous la souris est un Pawn 
            ALORS
            Déclencher le changement de couleur dans le Pawn 
        FIN-SI
FIN-SI

# Changement de couleur

OBJECTIF : Changer la couleur du pion

VARIABLE NumeroCouleur : int
VARIABLE ListeCouleur : Couleur[]
SI NumeroCouleur < 0 OU NumeroCouleur >= Longueur(ListeCouleur)-1
    ALORS
    NumeroCouleur = 0
    SINON
    NumeroCouleur = NumeroCouleur + 1
FIN-SI
Appliquer la couleur : ListeCouleur[NumeroCouleur]
