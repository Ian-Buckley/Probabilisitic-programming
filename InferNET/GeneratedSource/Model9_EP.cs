// <auto-generated />
#pragma warning disable 1570, 1591

using System;
using MicrosoftResearch.Infer;
using MicrosoftResearch.Infer.Distributions;
using MicrosoftResearch.Infer.Maths;
using MicrosoftResearch.Infer.Collections;
using MicrosoftResearch.Infer.Factors;

namespace MicrosoftResearch.Infer.Models.User
{
	/// <summary>
	/// Generated algorithm for performing inference.
	/// </summary>
	/// <remarks>
	/// If you wish to use this class directly, you must perform the following steps:
	/// 1) Create an instance of the class.
	/// 2) Set the value of any externally-set fields e.g. data, priors.
	/// 3) Call the Execute(numberOfIterations) method.
	/// 4) Use the XXXMarginal() methods to retrieve posterior marginals for different variables.
	/// 
	/// Generated by Infer.NET 2.7.1803.1901 at 7:26 PM on Wednesday, August 15, 2018.
	/// </remarks>
	public partial class Model9_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>True if Changed_vVector32 has executed. Set this to false to force re-execution of Changed_vVector32</summary>
		public bool Changed_vVector32_isDone;
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Message to marginal of 'vdouble75'</summary>
		public Gamma vdouble75_marginal_F;
		/// <summary>Message to marginal of 'vdouble76'</summary>
		public Gaussian vdouble76_marginal_F;
		/// <summary>Message to marginal of 'vdouble77'</summary>
		public Gaussian vdouble77_marginal_F;
		/// <summary>Field backing the vVector32 property</summary>
		private Vector VVector32;
		public PointMass<Vector> vVector32_marginal;
		/// <summary>Message to marginal of 'vVector33'</summary>
		public VectorGaussian vVector33_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vVector32'</summary>
		public Vector vVector32
		{
			get {
				return this.VVector32;
			}
			set {
				this.VVector32 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vVector32_isDone = false;
			}
		}

		#endregion

		#region Methods
		/// <summary>Computations that depend on the observed value of vVector32</summary>
		private void Changed_vVector32()
		{
			if (this.Changed_vVector32_isDone) {
				return ;
			}
			this.vVector32_marginal = new PointMass<Vector>(this.VVector32);
			VectorGaussian vVectorGaussian10 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[2] {1744.7460836560538, 28.704344345583781}), new PositiveDefiniteMatrix(new double[2, 2] {{493071.92980116926, 6968.9399143843029}, {6968.9399143843029, 100.34330884967395}}));
			this.vVector33_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian10);
			VectorGaussian vVector33_use_B = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian10);
			// Message to 'vVector33_marginal' from Variable factor
			this.vVector33_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector33_use_B, vVectorGaussian10, this.vVector33_marginal_F);
			Gamma vGamma10 = Gamma.FromShapeAndRate(12.108571971274765, 52.199378692499536);
			this.vdouble75_marginal_F = Gamma.Uniform();
			Gamma vdouble75_use_B = Gamma.Uniform();
			// Message to 'vdouble75_marginal' from Variable factor
			this.vdouble75_marginal_F = VariableOp.MarginalAverageConditional<Gamma>(vdouble75_use_B, vGamma10, this.vdouble75_marginal_F);
			Gaussian vdouble76_F = default(Gaussian);
			this.vdouble76_marginal_F = Gaussian.Uniform();
			Gaussian vdouble76_use_B = Gaussian.Uniform();
			DenseVector vVector33_use_F_AMean;
			// Message to 'vdouble76' from InnerProduct factor
			vVector33_use_F_AMean = InnerProductOpBase.AMeanInit(vVectorGaussian10);
			PositiveDefiniteMatrix vVector33_use_F_AVariance;
			// Message to 'vdouble76' from InnerProduct factor
			vVector33_use_F_AVariance = InnerProductOpBase.AVarianceInit(vVectorGaussian10);
			// Message to 'vdouble76' from InnerProduct factor
			vVector33_use_F_AVariance = InnerProductOpBase.AVariance(vVectorGaussian10, vVector33_use_F_AVariance);
			// Message to 'vdouble76' from InnerProduct factor
			vVector33_use_F_AMean = InnerProductOpBase.AMean(vVectorGaussian10, vVector33_use_F_AVariance, vVector33_use_F_AMean);
			// Message to 'vdouble76' from InnerProduct factor
			vdouble76_F = InnerProductOpBase.InnerProductAverageConditional(vVector33_use_F_AMean, vVector33_use_F_AVariance, this.VVector32);
			// Message to 'vdouble76_marginal' from DerivedVariable factor
			this.vdouble76_marginal_F = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble76_use_B, vdouble76_F, this.vdouble76_marginal_F);
			Gaussian vdouble77_F = default(Gaussian);
			this.vdouble77_marginal_F = Gaussian.Uniform();
			Gaussian vdouble77_use_B = Gaussian.Uniform();
			// Message to 'vdouble77' from GaussianFromMeanAndVariance factor
			vdouble77_F = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble77_use_B, vdouble76_F, vGamma10);
			// Message to 'vdouble77_marginal' from Variable factor
			this.vdouble77_marginal_F = VariableOp.MarginalAverageConditional<Gaussian>(vdouble77_use_B, vdouble77_F, this.vdouble77_marginal_F);
			this.Changed_vVector32_isDone = true;
		}

		/// <summary>Update all marginals, by iterating message passing the given number of times</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		/// <param name="initialise">If true, messages that initialise loops are reset when observed values change</param>
		private void Execute(int numberOfIterations, bool initialise)
		{
			this.Changed_vVector32();
			this.numberOfIterationsDone = numberOfIterations;
		}

		/// <summary>Update all marginals, by iterating message-passing the given number of times</summary>
		/// <param name="numberOfIterations">The total number of iterations that should be executed for the current set of observed values.  If this is more than the number already done, only the extra iterations are done.  If this is less than the number already done, message-passing is restarted from the beginning.  Changing the observed values resets the iteration count to 0.</param>
		public void Execute(int numberOfIterations)
		{
			this.Execute(numberOfIterations, true);
		}

		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="vVector32") {
				return this.vVector32;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName)
		{
			if (variableName=="vVector32") {
				return this.VVector32Marginal();
			}
			if (variableName=="vVector33") {
				return this.VVector33Marginal();
			}
			if (variableName=="vdouble75") {
				return this.Vdouble75Marginal();
			}
			if (variableName=="vdouble76") {
				return this.Vdouble76Marginal();
			}
			if (variableName=="vdouble77") {
				return this.Vdouble77Marginal();
			}
			throw new ArgumentException("This class was not built to infer "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName));
		}

		/// <summary>Get the query-specific marginal distribution of a variable.</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName, string query)
		{
			if (query=="Marginal") {
				return this.Marginal(variableName);
			}
			throw new ArgumentException(((("This class was not built to infer \'"+variableName)+"\' with query \'")+query)+"\'");
		}

		/// <summary>Get the query-specific marginal distribution of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName, string query)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName, query));
		}

		private void OnProgressChanged(ProgressChangedEventArgs e)
		{
			// Make a temporary copy of the event to avoid a race condition
			// if the last subscriber unsubscribes immediately after the null check and before the event is raised.
			EventHandler<ProgressChangedEventArgs> handler = this.ProgressChanged;
			if (handler!=null) {
				handler(this, e);
			}
		}

		/// <summary>Reset all messages to their initial values.  Sets NumberOfIterationsDone to 0.</summary>
		public void Reset()
		{
			this.Execute(0);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="vVector32") {
				this.vVector32 = (Vector)value;
				return ;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Update all marginals, by iterating message-passing an additional number of times</summary>
		/// <param name="additionalIterations">The number of iterations that should be executed, starting from the current message state.  Messages are not reset, even if observed values have changed.</param>
		public void Update(int additionalIterations)
		{
			this.Execute(checked(this.numberOfIterationsDone+additionalIterations), false);
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble75' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gamma Vdouble75Marginal()
		{
			return this.vdouble75_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble76' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian Vdouble76Marginal()
		{
			return this.vdouble76_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble77' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian Vdouble77Marginal()
		{
			return this.vdouble77_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector32' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector> VVector32Marginal()
		{
			return this.vVector32_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector33' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector33Marginal()
		{
			return this.vVector33_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
