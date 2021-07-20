# Probabilistic programming in python, R & F#
## Overview
A collection of [Microsoft Azure Notebooks ](https://notebooks.azure.com/) ([Jupyter notebooks](http://jupyter.org/) hosted on [Azure](https://azure.microsoft.com/)) providing demonstrations of [probabilistic programming](https://www.oreilly.com/ideas/probabilistic-programming) using the following frameworks:
* [Infer.NET](http://infernet.azurewebsites.net/) *"Infer.NET is a framework for running Bayesian inference in graphical models. It can also be used for probabilistic programming"* **NOW OPEN SOURCE!**
* [Stan](http://mc-stan.org/) *"Stan is freedom-respecting, open-source software for facilitating statistical inference at the frontiers of applied statistics."*
* [PyMC](https://github.com/pymc-devs) (currently at  PyMC3, with PyMC4 in the works) *"PyMC3 is a Python package for Bayesian statistical modeling and probabilistic machine learning which focuses on advanced Markov chain Monte Carlo and variational fitting algorithms."*
* [Edward](http://edwardlib.org/) *"A library for probabilistic modeling, inference, and criticism."*    

using the three supported languages of [python](https://www.python.org/), [R](https://www.r-project.org/) & [F#](https://fsharp.org/).

For 
* further probabilistic programming systems see [http://probabilistic-programming.org/](http://probabilistic-programming.org/wiki/Home)
* a side-by-side comparison of Stan, PyMC3 & Edward, see Bob Carpenter's [Hello, world! Stan, PyMC3, and Edward](http://andrewgelman.com/2017/05/31/compare-stan-pymc3-edward-hello-world/)   

## Authors & attribution
Nearly all of these collected notebooks & snippets are *not* written by me (Ian). I have made only small modifications to existing code to make it run on Azure Notebooks, usually a question of [installing the correct packages](https://notebooks.azure.com/help/jupyter-notebooks/package-installation) & copying over input files such as data & Stan script files. The original authors are attributed but are requested to contact me to remove any material that they would prefer not to have hosted here. Some of the Infer.NET examples have been translated from C# to F#.   

## What is in the folders?
* Demos for each framework
    * [Edward](https://notebooks.azure.com/ian-buckley/libraries/probabilistic-programming/tree/Edward)
    * [InferNET](https://notebooks.azure.com/ian-buckley/libraries/probabilistic-programming/tree/InferNET)
    * [PyMC](https://notebooks.azure.com/ian-buckley/libraries/probabilistic-programming/tree/PyMC)
    * [Stan](https://notebooks.azure.com/ian-buckley/libraries/probabilistic-programming/tree/Stan)
* [FSharp](https://notebooks.azure.com/ian-buckley/libraries/probabilistic-programming/tree/FSharp)
    * Probability computation expression (monad)
    * Monty Hall
    * Language-oriented programming

## Getting started with Azure Notebooks
* https://notebooks.azure.com/  
* http://jupyter.org/ 
* Azure Notebooks support [JupyterLab](https://github.com/jupyterlab/jupyterlab)      
**To do**  


## Applications of Bayesian inference
### Bayesian machine learning
* Ghahramani, Zoubin. 2014. “Bayesian Machine Learning.” http://www.doc.ic.ac.uk/~mpd37/teaching/2014/ml_tutorials/2014-01-29-slides_zoubin1.pdf.
* ———. 2015. “Probabilistic Machine Learning and Artificial Intelligence.” Nature 521 (7553): 452–59. https://doi.org/10.1038/nature14541.
* Microsoft Research. 2016. Posner Lecture: Probabilistic Machine Learning - Foundations and Frontiers. https://www.youtube.com/watch?v=rafnLSdHDzk.
* Polson, Nicholas, and Vadim Sokolov. 2017. “Deep Learning: A Bayesian Perspective.” Bayesian Analysis 12 (4): 1275–1304. https://doi.org/10.1214/17-BA1082.
* Ścibior, Adam, Zoubin Ghahramani, and Andrew D. Gordon. 2015. “Practical Probabilistic Programming with Monads.” In Proceedings of the 2015 ACM SIGPLAN Symposium on Haskell, 165–176. Haskell ’15. New York, NY, USA: ACM. https://doi.org/10.1145/2804302.2804317.
* Wiecki, Thomas. 2016. “Bayesian Deep Learning.” Quantopian Blog (blog). June 1, 2016. https://blog.quantopian.com/bayesian-deep-learning/.

### Bayesian deep learning
* Gal, Yarin. 2015. “Modern Deep Learning through Bayesian Eyes,” 123.
* Ghahramani, Zoubin. 2016. “A History of Bayesian Neural Networks,” 42.
* Polson, Nicholas, and Vadim Sokolov. 2017. “Deep Learning: A Bayesian Perspective.” Bayesian Analysis 12 (4): 1275–1304. https://doi.org/10.1214/17-BA1082.
* Rowan, Andrew. 2017. “RPubs - Bayesian Deep Learning with Edward (and a Trick Using Dropout) - Andrew Rowan - PyData London 2017.” 2017. http://rpubs.com/arowan/bayesian_deep_learning.
* ———. (2017) 2018. PyDataLondon2017: Bayesian Deep Learning with Edward (and a Trick Using Dropout). HTML. https://github.com/adrowan/PyDataLondon2017.
* Sungjoon. (2018) 2018. Bayes-Nn: Lecture Notes on Bayesian Deep Learning. https://github.com/sjchoi86/bayes-nn.
* Wiecki, Thomas. 2016. “Bayesian Deep Learning.” Quantopian Blog (blog). June 1, 2016. https://blog.quantopian.com/bayesian-deep-learning/.

### Supervised learning & regression
* Carpenter, Robert. 2017. “Hello, World! Stan, PyMC3, and Edward.” Statistical Modeling, Causal Inference, and Social Science (blog). May 31, 2017. http://andrewgelman.com/2017/05/31/compare-stan-pymc3-edward-hello-world/.
* Hertzog. 2016. “Bayesian Regression with STAN: Part 1 Normal Regression.” R-Bloggers (blog). January 8, 2016. https://www.r-bloggers.com/bayesian-regression-with-stan-part-1-normal-regression/.
* Wiecki, Thomas. n.d. “GLM: Linear Regression — PyMC3 3.1 Documentation.” Accessed August 27, 2017. https://pymc-devs.github.io/pymc3/notebooks/GLM-linear.html.


### Economics & finance
* Dixon, Matthew Francis. 2017. “Deep Probabilistic Programming for Financial Modeling.” 2017. https://knect365.com/global-derivatives/article/7e2e4aaa-4115-42ca-8b84-4f4512e07974/deep-probabilistic-programming-for-financial-modeling.
* Gelman, Andrew. 2013. “Economists Argue about Bayes.” Statistical Modeling, Causal Inference, and Social Science. January 28, 2013. http://andrewgelman.com/2013/01/28/economists-argue-about-bayes/.
* Wiecki, Thomas. n.d. “Probabilistic Programming in Quantitative Finance.” Accessed August 27, 2017. http://twiecki.github.io/bayesian_risk_perf_v3.slides#/.

### Model-based machine learning
* Bishop, Christopher. 2013. “Graphical Models.” Tubingen. http://mlss.tuebingen.mpg.de/2013/2013/bishop_slides.pdf.
* ———. 2017. Keynote: Model-Based Machine Learning. https://www.youtube.com/watch?v=zKUFSKRjTIo.
* ———. 2018. AMLD2018 - Christopher Bishop, Microsoft Research: Model Based Machine Learning. https://www.youtube.com/watch?v=7T2_hkKaB5I.
* Bishop, Christopher M. 2011. Pattern Recognition and Machine Learning. 1st ed. 2006. Corr. 2nd printing 2011 edition. New York: Springer.
* ———. 2013. “Model-Based Machine Learning.” Phil. Trans. R. Soc. A 371 (1984): 20120222. https://doi.org/10.1098/rsta.2012.0222.
* Emaasit, Daniel. 2016. “An Introduction to Model-Based Machine Learning.” Data Science Blog by Domino. July 12, 2016. https://blog.dominodatalab.com/an-introduction-to-model-based-machine-learning/.
* Meent, Jan-Willem van de, Brooks Paige, Hongseok Yang, and Frank Wood. 2018. “An Introduction to Probabilistic Programming.” ArXiv:1809.10756 [Cs, Stat], September. http://arxiv.org/abs/1809.10756.
* Winn, John Michael, and Christopher Bishop. 2018a. “MBML as pdf” Tweet. @mbmlbook (blog). October 15, 2018. https://twitter.com/mbmlbook/status/1051755313060286464.
* ———. 2018b. Model-Based Machine Learning. Taylor & Francis Group. http://www.mbmlbook.com/.

## Statistical inference frameworks
### Infer.NET **OPEN SOURCE**
* [Infer.NET](http://infernet.azurewebsites.net/) *"Infer.NET is a framework for running Bayesian inference in graphical models. It can also be used for probabilistic programming"*   
* [Model-Based Machine Learning](http://www.mbmlbook.com/) by John Winn & Christopher Bishop, with Thomas Diethe (early access) takes a novel & systematic approach to machine learning pedagogy in which the algorithms play second fiddle to the problems that they are required to solve. It's the assumptions that matter, & these are distilled into a model. The model dictates the algorithm.
* Many great examples here: https://github.com/usptact 
* Open source https://github.com/dotnet/infer
 * https://www.microsoft.com/en-us/research/blog/the-microsoft-infer-net-machine-learning-framework-goes-open-source/   
 * https://www.infoworld.com/article/3311994/machine-learning/microsoft-open-sources-infernet-machine-learning.html  
 * https://mspoweruser.com/microsofts-popular-machine-learning-framework-infer-net-goes-open-source/
 * https://blog.dominodatalab.com/an-introduction-to-model-based-machine-learning/ 
 * http://rsta.royalsocietypublishing.org/content/371/1984/20120222   
 * [Keynote: Model-Based Machine Learning - Christoher Bishop](https://www.youtube.com/watch?v=zKUFSKRjTIo)

Winn, John Michael, and Christopher Bishop. 2018. Model-Based Machine Learning. Taylor & Francis Group. http://www.mbmlbook.com/.   
Abstract: *This book is unusual for a machine learning text book in that the authors do not review dozens of different algorithms. Instead they introduce all of the key ideas through a series of case studies involving real-world applications. Case studies play a central role because it is only in the context of applications that it makes sense to discuss modelling assumptions. Each chapter therefore introduces one case study which is drawn from a real-world application that has been solved using a model-based approach.*



**To do**  

### Stan
* [Stan](http://mc-stan.org/) *"Stan is freedom-respecting, open-source software for facilitating statistical inference at the frontiers of applied statistics."*   
**To do**

### PyMC
* [PyMC](https://github.com/pymc-devs) (currently at  PyMC3, with PyMC4 in the works) *"PyMC3 is a Python package for Bayesian statistical modeling and probabilistic machine learning which focuses on advanced Markov chain Monte Carlo and variational fitting algorithms."*   
**To do**

### Edward
* [Edward](http://edwardlib.org/) *"A library for probabilistic modeling, inference, and criticism."*      
**To do**  

## Getting started in probabilistic programming & statistical inference
**To do**    