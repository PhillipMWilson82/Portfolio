

/*
Start Menu in Unity:  
    https://www.youtube.com/watch?v=zc8ac_qUXQY&list=PLPV2KyIb3jR4JsOygkHOd2q0CFoslwZOZ

1. Two scenes -  Game/Menu
2. Heirarchy - Create UI -- Panel
    name Background
    Inspector - set image to sprite and darken
3. Hierarchy - add Text Mesh Pro (must be imported) 
    Scale text and center
    Set font, boldness, size
    Add underlay for shadow
    Project - Create -- TextMeshPro -- Color Gradient
    Inspector - drag gradient scheme into color preset slot
4. Hierarchy - Add Button
    name PlayButton
    delete text child
    replace with Text mesh Pro text
    Inspector - 
        set alpha for button image to 0
        set alpha settings clearer for highlighted, and clearer for pressed
5. Hierarchy - duplicate playbutton twice
    name OptionsButton and QuitButton
6. Hierachy - create Empty
    name MainMenu
    Size around the buttons
    move buttons inside
7. Hierarchy - duplicate MainMenu
    name OptionsMenu
    Move options button text to child of menu to create title
    Change text of QuitButton to BACK
8. Hierarchy -- Create -- UI -- Slider
    name VolumeSlider
    disable handle image
    change background color and alpha
    select fill color
9. Hierarchy - Duplicate title text
    change text to Volume
    place over slider as label
10. Hierarchy -- select MainMenu -- add script MainMenu
    must be using UnityEngine.SceneManagement
    Add function to switch the scene to the next scene in the build menu
11. File -- Build Settings --  add both active scenes to build list
12. Inspector - Drag MainMenu Object into PlayButtons OnClick Event list
    set function to PlayGame()
13. MainMenu script - add QuitGame function to stop application
    this will not work inn the unity editor
    Inspector - Add MainMenu to OnClick event list for QuitButton
14. Inspector - OptionsButton - add events to OnClick
    one event to disable the MainMenu
    one event to enable the OptionsMenu
15. Inspector -  BackButton - add events to OnClick
    same idea as before but in reverse
    








*/
