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
	/// Generated by Infer.NET 2.7.1803.1901 at 7:05 PM on Wednesday, August 15, 2018.
	/// </remarks>
	public partial class Model6_VMP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>True if Changed_vdouble__22 has executed. Set this to false to force re-execution of Changed_vdouble__22</summary>
		public bool Changed_vdouble__22_isDone;
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vdouble__22 property</summary>
		private double[] Vdouble__22;
		public DistributionStructArray<Gaussian,double> vdouble__22_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__23_F;
		/// <summary>Message to marginal of 'w'</summary>
		public VectorGaussian w_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__22'</summary>
		public double[] vdouble__22
		{
			get {
				return this.Vdouble__22;
			}
			set {
				if ((value!=null)&&(value.Length!=8)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+8)+" was expected for variable \'vdouble__22\'");
				}
				this.Vdouble__22 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_vdouble__22_isDone = false;
			}
		}

		#endregion

		#region Methods
		/// <summary>Computations that depend on the observed value of vdouble__22</summary>
		private void Changed_vdouble__22()
		{
			if (this.Changed_vdouble__22_isDone) {
				return ;
			}
			this.vdouble__22_marginal = new DistributionStructArray<Gaussian,double>(8, delegate(int index11) {
				return Gaussian.Uniform();
			});
			this.vdouble__22_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__22_marginal, this.Vdouble__22);
			Vector[] x = new Vector[8];
			x[0] = DenseVector.FromArray(new double[2] {1.0, -3.0});
			x[1] = DenseVector.FromArray(new double[2] {1.0, -2.1});
			x[2] = DenseVector.FromArray(new double[2] {1.0, -1.3});
			x[3] = DenseVector.FromArray(new double[2] {1.0, 0.5});
			x[4] = DenseVector.FromArray(new double[2] {1.0, 1.2});
			x[5] = DenseVector.FromArray(new double[2] {1.0, 3.3});
			x[6] = DenseVector.FromArray(new double[2] {1.0, 4.4});
			x[7] = DenseVector.FromArray(new double[2] {1.0, 5.5});
			DenseVector vVector25 = DenseVector.FromArray(new double[2] {0.0, 0.0});
			PositiveDefiniteMatrix vPositiveDefiniteMatrix0 = new PositiveDefiniteMatrix(new double[2, 2] {{1.0, 0.0}, {0.0, 1.0}});
			VectorGaussian w_F = ArrayHelper.MakeUniform<VectorGaussian>(VectorGaussian.Uniform(vVector25.Count));
			this.w_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(VectorGaussian.Uniform(vVector25.Count));
			VectorGaussian w_use_B = ArrayHelper.MakeUniform<VectorGaussian>(VectorGaussian.Uniform(vVector25.Count));
			// Message to 'w' from VectorGaussian factor
			w_F = VectorGaussianOp.SampleAverageLogarithm(vVector25, vPositiveDefiniteMatrix0, w_F);
			DistributionStructArray<Gaussian,double> vdouble__23_use_B;
			// Create array for 'vdouble__23_use' Backwards messages.
			vdouble__23_use_B = new DistributionStructArray<Gaussian,double>(8);
			DistributionRefArray<VectorGaussian,Vector> w_rep_B;
			// Create array for 'w_rep' Backwards messages.
			w_rep_B = new DistributionRefArray<VectorGaussian,Vector>(8);
			for(int index11 = 0; index11<8; index11++) {
				vdouble__23_use_B[index11] = Gaussian.Uniform();
				// Message to 'vdouble__23_use' from GaussianFromMeanAndVariance factor
				vdouble__23_use_B[index11] = GaussianFromMeanAndVarianceOp.MeanAverageLogarithm(this.Vdouble__22[index11], 1.0);
				w_rep_B[index11] = ArrayHelper.MakeUniform<VectorGaussian>(VectorGaussian.Uniform(vVector25.Count));
				// Message to 'w_rep' from InnerProduct factor
				w_rep_B[index11] = InnerProductOpBase.BAverageLogarithm(vdouble__23_use_B[index11], x[index11], w_rep_B[index11]);
			}
			// Message to 'w_use' from Replicate factor
			w_use_B = ReplicateOp.DefAverageLogarithm<VectorGaussian>(w_rep_B, w_use_B);
			DenseVector w_rep_F_index11__BMean_reduced = default(DenseVector);
			// Message to 'vdouble__23' from InnerProduct factor
			w_rep_F_index11__BMean_reduced = InnerProductOpBase.BMeanInit(this.w_marginal_F);
			PositiveDefiniteMatrix w_rep_F_index11__BVariance_reduced = default(PositiveDefiniteMatrix);
			// Message to 'vdouble__23' from InnerProduct factor
			w_rep_F_index11__BVariance_reduced = InnerProductOpBase.BVarianceInit(this.w_marginal_F);
			// Message to 'w_marginal' from Variable factor
			this.w_marginal_F = VariableVmpOp.MarginalAverageLogarithm<VectorGaussian>(w_use_B, w_F, this.w_marginal_F);
			// Create array for 'vdouble__23' Forwards messages.
			this.vdouble__23_F = new DistributionStructArray<Gaussian,double>(8);
			// Message to 'vdouble__23' from InnerProduct factor
			w_rep_F_index11__BVariance_reduced = InnerProductOpBase.BVariance(this.w_marginal_F, w_rep_F_index11__BVariance_reduced);
			// Message to 'vdouble__23' from InnerProduct factor
			w_rep_F_index11__BMean_reduced = InnerProductOpBase.BMean(this.w_marginal_F, w_rep_F_index11__BVariance_reduced, w_rep_F_index11__BMean_reduced);
			for(int index11 = 0; index11<8; index11++) {
				this.vdouble__23_F[index11] = Gaussian.Uniform();
				// Message to 'vdouble__23' from InnerProduct factor
				this.vdouble__23_F[index11] = InnerProductOpBase.InnerProductAverageLogarithm(x[index11], w_rep_F_index11__BMean_reduced, w_rep_F_index11__BVariance_reduced);
			}
			this.Changed_vdouble__22_isDone = true;
		}

		/// <summary>Update all marginals, by iterating message passing the given number of times</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		/// <param name="initialise">If true, messages that initialise loops are reset when observed values change</param>
		private void Execute(int numberOfIterations, bool initialise)
		{
			this.Changed_vdouble__22();
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
			if (variableName=="vdouble__22") {
				return this.vdouble__22;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName)
		{
			if (variableName=="vdouble__22") {
				return this.Vdouble__22Marginal();
			}
			if (variableName=="w") {
				return this.WMarginal();
			}
			if (variableName=="vdouble__23") {
				return this.Vdouble__23Marginal();
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
			if (variableName=="vdouble__22") {
				this.vdouble__22 = (double[])value;
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
		/// Returns the marginal distribution for 'vdouble__22' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__22Marginal()
		{
			return this.vdouble__22_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__23' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__23Marginal()
		{
			return this.vdouble__23_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'w' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian WMarginal()
		{
			return this.w_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
