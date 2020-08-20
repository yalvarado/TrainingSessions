TDD

# Recommended reading
![The Art of Unit Testing](https://www.pricerunner.com/product/640x640/1577337592/The-Art-of-Unit-Testing-with-examples-in-C-.jpg)

[Amazon link](https://www.amazon.co.uk/Art-Unit-Testing-examples/dp/1617290890/ref=pd_rhf_se_p_img_1?_encoding=UTF8&psc=1&refRID=9V0G720TEGHE0WY5TCBV)


# Good articles
- [The 3 rules of TDD](http://www.butunclebob.com/ArticleS.UncleBob.TheThreeRulesOfTdd)

- [The bowling game kata](http://www.butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata)


# The basics of TDD

**Red** 
- A common mistake for many people, new to TDD, is to gloss over the need to see the test fail first. The red is extremely valuable feedback that tells us our assumptions still hold true. Once in a while, they won't, and you'll have saved yourself a lot of time by finding that out immediately.

**Green** 
- Keep rough track of how long it takes you to derive a solution that passes all your tests. If you're taking 5-10 minutes on average, or more, start figuring out ways to take smaller steps.

**Refactor** 
- You should always take advantage of the refactoring step. Even if you added perfect code (that doesn't duplicate any other code in the system), treat the refactoring step as "mandatory bonus time." Poke around the area you're changing. Get rid of a warning. Rename a test. Improve the readability of an existing method. Follow the boy scout rule: Make things a little better when you leave than they were when you arrived. Note that the refactor step doesn't necessarily represent a single green test run: You should look to decompose refactoring efforts into even tinier steps, getting a rapid succession of green bars before moving on.
