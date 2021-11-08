a = 2
b = 3

print(a ** 3)
print('======')

#python dictionary
MLB_team = {    
    'Colorado': 'Rockies',    
    'Boston': 'Red Sox',    
    'Minnesota': 'Twins',
}
print(MLB_team['Minnesota']) #akses value
MLB_team['Boston'] = 'Red Fox'
MLB_team['Boston'] = ['Red Fox', 'White Fox']
MLB_team['Boston'].append('Grey Fox')

#Adding an entry to an existing dictionary
MLB_team['Kansas City'] = 'Royals'
print(MLB_team)
