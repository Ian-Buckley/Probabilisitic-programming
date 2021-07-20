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
	/// Generated by Infer.NET 2.7.1803.1901 at 6:04 PM on Wednesday, August 15, 2018.
	/// </remarks>
	public partial class Model4_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>True if Changed_numberOfIterations_vdouble__17_vVector__6 has executed. Set this to false to force re-execution of Changed_numberOfIterations_vdouble__17_vVector__6</summary>
		public bool Changed_numberOfIterations_vdouble__17_vVector__6_isDone;
		/// <summary>True if Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6 has executed. Set this to false to force re-execution of Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6</summary>
		public bool Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6_isDone;
		/// <summary>True if Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6 has performed initialisation. Set this to false to force re-execution of Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6</summary>
		public bool Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6_isInitialised;
		/// <summary>True if Changed_vdouble__17 has executed. Set this to false to force re-execution of Changed_vdouble__17</summary>
		public bool Changed_vdouble__17_isDone;
		/// <summary>True if Changed_vVector__6 has executed. Set this to false to force re-execution of Changed_vVector__6</summary>
		public bool Changed_vVector__6_isDone;
		/// <summary>True if Constant has executed. Set this to false to force re-execution of Constant</summary>
		public bool Constant_isDone;
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		/// <summary>Field backing the vdouble__17 property</summary>
		private double[] Vdouble__17;
		public DistributionStructArray<Gaussian,double> vdouble__17_marginal;
		public DistributionStructArray<Gaussian,double> vdouble__18_F;
		/// <summary>Message to marginal of 'vdouble__18'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__18_marginal_F;
		/// <summary>Message to marginal of 'vdouble__20'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__20_marginal_F;
		/// <summary>Message to marginal of 'vdouble__21'</summary>
		public DistributionStructArray<Gaussian,double> vdouble__21_marginal_F;
		/// <summary>Message to marginal of 'vdouble47'</summary>
		public Gamma vdouble47_marginal_F;
		public DistributionStructArray<Gamma,double> vdouble47_rep_B;
		/// <summary>Buffer for ReplicateOp_Divide.Marginal<Gamma></summary>
		public Gamma vdouble47_rep_B_toDef;
		/// <summary>Messages to use of 'vdouble47'</summary>
		public Gamma[] vdouble47_uses_F;
		/// <summary>Field backing the vVector__6 property</summary>
		private Vector[] VVector__6;
		public PointMass<Vector[]> vVector__6_marginal;
		/// <summary>Message to marginal of 'vVector17'</summary>
		public VectorGaussian vVector17_marginal_F;
		#endregion

		#region Properties
		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		/// <summary>The externally-specified value of 'vdouble__17'</summary>
		public double[] vdouble__17
		{
			get {
				return this.Vdouble__17;
			}
			set {
				if ((value!=null)&&(value.Length!=23)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+23)+" was expected for variable \'vdouble__17\'");
				}
				this.Vdouble__17 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6_isInitialised = false;
				this.Changed_numberOfIterations_vdouble__17_vVector__6_isDone = false;
				this.Changed_vdouble__17_isDone = false;
			}
		}

		/// <summary>The externally-specified value of 'vVector__6'</summary>
		public Vector[] vVector__6
		{
			get {
				return this.VVector__6;
			}
			set {
				if ((value!=null)&&(value.Length!=23)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+23)+" was expected for variable \'vVector__6\'");
				}
				this.VVector__6 = value;
				this.numberOfIterationsDone = 0;
				this.Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6_isInitialised = false;
				this.Changed_numberOfIterations_vdouble__17_vVector__6_isDone = false;
				this.Changed_vVector__6_isDone = false;
			}
		}

		#endregion

		#region Methods
		/// <summary>Computations that depend on the observed value of numberOfIterations and vdouble__17 and vVector__6</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		private void Changed_numberOfIterations_vdouble__17_vVector__6(int numberOfIterations)
		{
			if (this.Changed_numberOfIterations_vdouble__17_vVector__6_isDone) {
				return ;
			}
			VectorGaussian vVectorGaussian6 = VectorGaussian.FromNatural(DenseVector.FromArray(new double[2] {0.0, 0.0}), new PositiveDefiniteMatrix(new double[2, 2] {{1.0, 0.0}, {0.0, 1.0}}));
			this.vVector17_marginal_F = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
			VectorGaussian vVector17_use_B = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
			VectorGaussian[] vVector17_uses_F;
			VectorGaussian[] vVector17_uses_B;
			// Create array for 'vVector17_uses' Forwards messages.
			vVector17_uses_F = new VectorGaussian[2];
			// Create array for 'vVector17_uses' Backwards messages.
			vVector17_uses_B = new VectorGaussian[2];
			vVector17_uses_B[1] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
			vVector17_uses_B[0] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
			vVector17_uses_F[1] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
			vVector17_uses_F[0] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
			VectorGaussian vVector17_rep_F_marginal;
			// Message to 'vVector17_rep' from Replicate factor
			vVector17_rep_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVector17_uses_F[0]);
			VectorGaussian vVector17_rep_B_toDef;
			// Message to 'vVector17_rep' from Replicate factor
			vVector17_rep_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVector17_uses_F[0]);
			// Message to 'vVector17_uses' from Replicate factor
			vVector17_uses_F[0] = ReplicateOp_NoDivide.UsesAverageConditional<VectorGaussian>(vVector17_uses_B, vVectorGaussian6, 0, vVector17_uses_F[0]);
			DistributionRefArray<VectorGaussian,Vector> vVector17_rep_F;
			// Create array for 'vVector17_rep' Forwards messages.
			vVector17_rep_F = new DistributionRefArray<VectorGaussian,Vector>(23);
			for(int index10 = 0; index10<23; index10++) {
				vVector17_rep_F[index10] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
			}
			// Create array for replicates of 'vVector17_rep_F_index10__AMean'
			DenseVector[] vVector17_rep_F_index10__AMean = new DenseVector[23];
			for(int index10 = 0; index10<23; index10++) {
				// Message to 'vdouble__18' from InnerProduct factor
				vVector17_rep_F_index10__AMean[index10] = InnerProductOpBase.AMeanInit(vVector17_rep_F[index10]);
			}
			// Create array for replicates of 'vVector17_rep_F_index10__AVariance'
			PositiveDefiniteMatrix[] vVector17_rep_F_index10__AVariance = new PositiveDefiniteMatrix[23];
			for(int index10 = 0; index10<23; index10++) {
				// Message to 'vdouble__18' from InnerProduct factor
				vVector17_rep_F_index10__AVariance[index10] = InnerProductOpBase.AVarianceInit(vVector17_rep_F[index10]);
			}
			Gamma vGamma6 = Gamma.FromShapeAndRate(1.0, 0.5);
			Gamma[] vdouble47_uses_B;
			// Create array for 'vdouble47_uses' Backwards messages.
			vdouble47_uses_B = new Gamma[2];
			vdouble47_uses_B[1] = Gamma.Uniform();
			Gamma vdouble47_rep_F_marginal;
			// Message to 'vdouble47_rep' from Replicate factor
			vdouble47_rep_F_marginal = ReplicateOp_Divide.MarginalInit<Gamma>(this.vdouble47_uses_F[0]);
			// Message to 'vdouble47_uses' from Replicate factor
			this.vdouble47_uses_F[0] = ReplicateOp_NoDivide.UsesAverageConditional<Gamma>(vdouble47_uses_B, vGamma6, 0, this.vdouble47_uses_F[0]);
			DistributionStructArray<Gamma,double> vdouble47_rep_F;
			// Create array for 'vdouble47_rep' Forwards messages.
			vdouble47_rep_F = new DistributionStructArray<Gamma,double>(23);
			for(int index10 = 0; index10<23; index10++) {
				vdouble47_rep_F[index10] = Gamma.Uniform();
			}
			DistributionStructArray<Gaussian,double> vdouble__18_use_B;
			// Create array for 'vdouble__18_use' Backwards messages.
			vdouble__18_use_B = new DistributionStructArray<Gaussian,double>(23);
			for(int index10 = 0; index10<23; index10++) {
				vdouble__18_use_B[index10] = Gaussian.Uniform();
			}
			DistributionRefArray<VectorGaussian,Vector> vVector17_rep_B;
			// Create array for 'vVector17_rep' Backwards messages.
			vVector17_rep_B = new DistributionRefArray<VectorGaussian,Vector>(23);
			for(int index10 = 0; index10<23; index10++) {
				vVector17_rep_B[index10] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
			}
			for(int iteration = this.numberOfIterationsDone; iteration<numberOfIterations; iteration++) {
				// Message to 'vdouble47_rep' from Replicate factor
				vdouble47_rep_F_marginal = ReplicateOp_Divide.Marginal<Gamma>(this.vdouble47_rep_B_toDef, this.vdouble47_uses_F[0], vdouble47_rep_F_marginal);
				for(int index10 = 0; index10<23; index10++) {
					// Message to 'vdouble47_rep' from Replicate factor
					vdouble47_rep_F[index10] = ReplicateOp_Divide.UsesAverageConditional<Gamma>(this.vdouble47_rep_B[index10], vdouble47_rep_F_marginal, index10, vdouble47_rep_F[index10]);
					// Message to 'vdouble__18_use' from GaussianFromMeanAndVariance factor
					vdouble__18_use_B[index10] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(this.Vdouble__17[index10], this.vdouble__18_F[index10], vdouble47_rep_F[index10]);
					// Message to 'vVector17_rep' from InnerProduct factor
					vVector17_rep_B[index10] = InnerProductOpBase.AAverageConditional(vdouble__18_use_B[index10], this.VVector__6[index10], vVector17_rep_B[index10]);
				}
				// Message to 'vVector17_rep' from Replicate factor
				vVector17_rep_B_toDef = ReplicateOp_Divide.ToDef<VectorGaussian>(vVector17_rep_B, vVector17_rep_B_toDef);
				// Message to 'vVector17_rep' from Replicate factor
				vVector17_rep_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector17_rep_B_toDef, vVector17_uses_F[0], vVector17_rep_F_marginal);
				for(int index10 = 0; index10<23; index10++) {
					// Message to 'vVector17_rep' from Replicate factor
					vVector17_rep_F[index10] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector17_rep_B[index10], vVector17_rep_F_marginal, index10, vVector17_rep_F[index10]);
					// Message to 'vdouble__18' from InnerProduct factor
					vVector17_rep_F_index10__AVariance[index10] = InnerProductOpBase.AVariance(vVector17_rep_F[index10], vVector17_rep_F_index10__AVariance[index10]);
					// Message to 'vdouble__18' from InnerProduct factor
					vVector17_rep_F_index10__AMean[index10] = InnerProductOpBase.AMean(vVector17_rep_F[index10], vVector17_rep_F_index10__AVariance[index10], vVector17_rep_F_index10__AMean[index10]);
					// Message to 'vdouble__18' from InnerProduct factor
					this.vdouble__18_F[index10] = InnerProductOpBase.InnerProductAverageConditional(vVector17_rep_F_index10__AMean[index10], vVector17_rep_F_index10__AVariance[index10], this.VVector__6[index10]);
					// Message to 'vdouble47_rep' from GaussianFromMeanAndVariance factor
					this.vdouble47_rep_B[index10] = GaussianFromMeanAndVarianceOp.VarianceAverageConditional(this.Vdouble__17[index10], this.vdouble__18_F[index10], vdouble47_rep_F[index10]);
				}
				// Message to 'vdouble47_rep' from Replicate factor
				this.vdouble47_rep_B_toDef = ReplicateOp_Divide.ToDef<Gamma>(this.vdouble47_rep_B, this.vdouble47_rep_B_toDef);
				this.OnProgressChanged(new ProgressChangedEventArgs(iteration));
			}
			// Message to 'vVector17_uses' from Replicate factor
			vVector17_uses_B[0] = ArrayHelper.SetTo<VectorGaussian>(vVector17_uses_B[0], vVector17_rep_B_toDef);
			// Message to 'vVector17_use' from Replicate factor
			vVector17_use_B = ReplicateOp_NoDivide.DefAverageConditional<VectorGaussian>(vVector17_uses_B, vVector17_use_B);
			// Message to 'vVector17_marginal' from Variable factor
			this.vVector17_marginal_F = VariableOp.MarginalAverageConditional<VectorGaussian>(vVector17_use_B, vVectorGaussian6, this.vVector17_marginal_F);
			VectorGaussian vVector17_rep2_F_marginal;
			// Message to 'vVector17_rep2' from Replicate factor
			vVector17_rep2_F_marginal = ReplicateOp_Divide.MarginalInit<VectorGaussian>(vVector17_uses_F[1]);
			VectorGaussian vVector17_rep2_B_toDef;
			// Message to 'vVector17_rep2' from Replicate factor
			vVector17_rep2_B_toDef = ReplicateOp_Divide.ToDefInit<VectorGaussian>(vVector17_uses_F[1]);
			// Message to 'vVector17_uses' from Replicate factor
			vVector17_uses_F[1] = ReplicateOp_NoDivide.UsesAverageConditional<VectorGaussian>(vVector17_uses_B, vVectorGaussian6, 1, vVector17_uses_F[1]);
			this.vdouble47_marginal_F = Gamma.Uniform();
			Gamma vdouble47_use_B = Gamma.Uniform();
			vdouble47_uses_B[0] = Gamma.Uniform();
			this.vdouble47_uses_F[1] = Gamma.Uniform();
			// Message to 'vdouble47_uses' from Replicate factor
			vdouble47_uses_B[0] = ArrayHelper.SetTo<Gamma>(vdouble47_uses_B[0], this.vdouble47_rep_B_toDef);
			// Message to 'vdouble47_use' from Replicate factor
			vdouble47_use_B = ReplicateOp_NoDivide.DefAverageConditional<Gamma>(vdouble47_uses_B, vdouble47_use_B);
			// Message to 'vdouble47_marginal' from Variable factor
			this.vdouble47_marginal_F = VariableOp.MarginalAverageConditional<Gamma>(vdouble47_use_B, vGamma6, this.vdouble47_marginal_F);
			Gamma vdouble47_rep2_F_marginal;
			// Message to 'vdouble47_rep2' from Replicate factor
			vdouble47_rep2_F_marginal = ReplicateOp_Divide.MarginalInit<Gamma>(this.vdouble47_uses_F[1]);
			Gamma vdouble47_rep2_B_toDef;
			// Message to 'vdouble47_rep2' from Replicate factor
			vdouble47_rep2_B_toDef = ReplicateOp_Divide.ToDefInit<Gamma>(this.vdouble47_uses_F[1]);
			// Message to 'vdouble47_uses' from Replicate factor
			this.vdouble47_uses_F[1] = ReplicateOp_NoDivide.UsesAverageConditional<Gamma>(vdouble47_uses_B, vGamma6, 1, this.vdouble47_uses_F[1]);
			// Create array for 'vdouble__18_marginal' Forwards messages.
			this.vdouble__18_marginal_F = new DistributionStructArray<Gaussian,double>(23);
			for(int index10 = 0; index10<23; index10++) {
				this.vdouble__18_marginal_F[index10] = Gaussian.Uniform();
				// Message to 'vdouble__18_marginal' from DerivedVariable factor
				this.vdouble__18_marginal_F[index10] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__18_use_B[index10], this.vdouble__18_F[index10], this.vdouble__18_marginal_F[index10]);
			}
			DistributionStructArray<Gaussian,double> vdouble__20_F;
			// Create array for 'vdouble__20' Forwards messages.
			vdouble__20_F = new DistributionStructArray<Gaussian,double>(23);
			DistributionStructArray<Gamma,double> vdouble47_rep2_B;
			// Create array for 'vdouble47_rep2' Backwards messages.
			vdouble47_rep2_B = new DistributionStructArray<Gamma,double>(23);
			DistributionStructArray<Gaussian,double> vdouble__21_F;
			// Create array for 'vdouble__21' Forwards messages.
			vdouble__21_F = new DistributionStructArray<Gaussian,double>(23);
			DistributionStructArray<Gamma,double> vdouble47_rep2_F;
			// Create array for 'vdouble47_rep2' Forwards messages.
			vdouble47_rep2_F = new DistributionStructArray<Gamma,double>(23);
			// Message to 'vdouble47_rep2' from Replicate factor
			vdouble47_rep2_F_marginal = ReplicateOp_Divide.Marginal<Gamma>(vdouble47_rep2_B_toDef, this.vdouble47_uses_F[1], vdouble47_rep2_F_marginal);
			// Create array for 'vdouble__21_marginal' Forwards messages.
			this.vdouble__21_marginal_F = new DistributionStructArray<Gaussian,double>(23);
			DistributionRefArray<VectorGaussian,Vector> vVector17_rep2_B;
			// Create array for 'vVector17_rep2' Backwards messages.
			vVector17_rep2_B = new DistributionRefArray<VectorGaussian,Vector>(23);
			DistributionRefArray<VectorGaussian,Vector> vVector17_rep2_F;
			// Create array for 'vVector17_rep2' Forwards messages.
			vVector17_rep2_F = new DistributionRefArray<VectorGaussian,Vector>(23);
			// Create array for replicates of 'vVector17_rep2_F_index10__AMean'
			DenseVector[] vVector17_rep2_F_index10__AMean = new DenseVector[23];
			// Create array for replicates of 'vVector17_rep2_F_index10__AVariance'
			PositiveDefiniteMatrix[] vVector17_rep2_F_index10__AVariance = new PositiveDefiniteMatrix[23];
			// Message to 'vVector17_rep2' from Replicate factor
			vVector17_rep2_F_marginal = ReplicateOp_Divide.Marginal<VectorGaussian>(vVector17_rep2_B_toDef, vVector17_uses_F[1], vVector17_rep2_F_marginal);
			// Create array for 'vdouble__20_marginal' Forwards messages.
			this.vdouble__20_marginal_F = new DistributionStructArray<Gaussian,double>(23);
			DistributionStructArray<Gaussian,double> vdouble__20_use_B;
			// Create array for 'vdouble__20_use' Backwards messages.
			vdouble__20_use_B = new DistributionStructArray<Gaussian,double>(23);
			Gaussian vdouble__21_use_B_reduced;
			vdouble__21_use_B_reduced = Gaussian.Uniform();
			for(int index10 = 0; index10<23; index10++) {
				vdouble__20_F[index10] = Gaussian.Uniform();
				vVector17_rep2_B[index10] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
				vVector17_rep2_F[index10] = ArrayHelper.MakeUniform<VectorGaussian>(vVectorGaussian6);
				// Message to 'vdouble__20' from InnerProduct factor
				vVector17_rep2_F_index10__AMean[index10] = InnerProductOpBase.AMeanInit(vVector17_rep2_F[index10]);
				// Message to 'vdouble__20' from InnerProduct factor
				vVector17_rep2_F_index10__AVariance[index10] = InnerProductOpBase.AVarianceInit(vVector17_rep2_F[index10]);
				// Message to 'vVector17_rep2' from Replicate factor
				vVector17_rep2_F[index10] = ReplicateOp_Divide.UsesAverageConditional<VectorGaussian>(vVector17_rep2_B[index10], vVector17_rep2_F_marginal, index10, vVector17_rep2_F[index10]);
				this.vdouble__20_marginal_F[index10] = Gaussian.Uniform();
				vdouble__20_use_B[index10] = Gaussian.Uniform();
				// Message to 'vdouble__20' from InnerProduct factor
				vVector17_rep2_F_index10__AVariance[index10] = InnerProductOpBase.AVariance(vVector17_rep2_F[index10], vVector17_rep2_F_index10__AVariance[index10]);
				// Message to 'vdouble__20' from InnerProduct factor
				vVector17_rep2_F_index10__AMean[index10] = InnerProductOpBase.AMean(vVector17_rep2_F[index10], vVector17_rep2_F_index10__AVariance[index10], vVector17_rep2_F_index10__AMean[index10]);
				// Message to 'vdouble__20' from InnerProduct factor
				vdouble__20_F[index10] = InnerProductOpBase.InnerProductAverageConditional(vVector17_rep2_F_index10__AMean[index10], vVector17_rep2_F_index10__AVariance[index10], this.VVector__6[index10]);
				// Message to 'vdouble__20_marginal' from DerivedVariable factor
				this.vdouble__20_marginal_F[index10] = DerivedVariableOp.MarginalAverageConditional<Gaussian>(vdouble__20_use_B[index10], vdouble__20_F[index10], this.vdouble__20_marginal_F[index10]);
				vdouble__21_F[index10] = Gaussian.Uniform();
				vdouble47_rep2_B[index10] = Gamma.Uniform();
				vdouble47_rep2_F[index10] = Gamma.Uniform();
				// Message to 'vdouble47_rep2' from Replicate factor
				vdouble47_rep2_F[index10] = ReplicateOp_Divide.UsesAverageConditional<Gamma>(vdouble47_rep2_B[index10], vdouble47_rep2_F_marginal, index10, vdouble47_rep2_F[index10]);
				this.vdouble__21_marginal_F[index10] = Gaussian.Uniform();
				// Message to 'vdouble__21' from GaussianFromMeanAndVariance factor
				vdouble__21_F[index10] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(vdouble__21_use_B_reduced, vdouble__20_F[index10], vdouble47_rep2_F[index10]);
				// Message to 'vdouble__21_marginal' from Variable factor
				this.vdouble__21_marginal_F[index10] = VariableOp.MarginalAverageConditional<Gaussian>(vdouble__21_use_B_reduced, vdouble__21_F[index10], this.vdouble__21_marginal_F[index10]);
			}
			this.Changed_numberOfIterations_vdouble__17_vVector__6_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of numberOfIterationsDecreased and must reset on changes to vdouble__17 and vVector__6</summary>
		/// <param name="initialise">If true, reset messages that initialise loops</param>
		private void Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6(bool initialise)
		{
			if (this.Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6_isDone&&((!initialise)||this.Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6_isInitialised)) {
				return ;
			}
			for(int index10 = 0; index10<23; index10++) {
				this.vdouble__18_F[index10] = Gaussian.Uniform();
			}
			// Message to 'vdouble47_rep' from Replicate factor
			this.vdouble47_rep_B_toDef = ReplicateOp_Divide.ToDefInit<Gamma>(this.vdouble47_uses_F[0]);
			for(int index10 = 0; index10<23; index10++) {
				this.vdouble47_rep_B[index10] = Gamma.Uniform();
			}
			this.Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6_isDone = true;
			this.Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6_isInitialised = true;
		}

		/// <summary>Computations that depend on the observed value of vdouble__17</summary>
		private void Changed_vdouble__17()
		{
			if (this.Changed_vdouble__17_isDone) {
				return ;
			}
			this.vdouble__17_marginal = new DistributionStructArray<Gaussian,double>(23, delegate(int index10) {
				return Gaussian.Uniform();
			});
			this.vdouble__17_marginal = Distribution.SetPoint<DistributionStructArray<Gaussian,double>,double[]>(this.vdouble__17_marginal, this.Vdouble__17);
			this.Changed_vdouble__17_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of vVector__6</summary>
		private void Changed_vVector__6()
		{
			if (this.Changed_vVector__6_isDone) {
				return ;
			}
			this.vVector__6_marginal = new PointMass<Vector[]>(this.VVector__6);
			this.Changed_vVector__6_isDone = true;
		}

		/// <summary>Computations that do not depend on observed values</summary>
		private void Constant()
		{
			if (this.Constant_isDone) {
				return ;
			}
			// Create array for 'vdouble__18' Forwards messages.
			this.vdouble__18_F = new DistributionStructArray<Gaussian,double>(23);
			// Create array for 'vdouble47_uses' Forwards messages.
			this.vdouble47_uses_F = new Gamma[2];
			this.vdouble47_uses_F[0] = Gamma.Uniform();
			// Create array for 'vdouble47_rep' Backwards messages.
			this.vdouble47_rep_B = new DistributionStructArray<Gamma,double>(23);
			this.Constant_isDone = true;
		}

		/// <summary>Update all marginals, by iterating message passing the given number of times</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		/// <param name="initialise">If true, messages that initialise loops are reset when observed values change</param>
		private void Execute(int numberOfIterations, bool initialise)
		{
			if (numberOfIterations!=this.numberOfIterationsDone) {
				if (numberOfIterations<this.numberOfIterationsDone) {
					this.numberOfIterationsDone = 0;
					this.Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6_isDone = false;
				}
				this.Changed_numberOfIterations_vdouble__17_vVector__6_isDone = false;
			}
			this.Constant();
			this.Changed_numberOfIterationsDecreased_Init_vdouble__17_vVector__6(initialise);
			this.Changed_numberOfIterations_vdouble__17_vVector__6(numberOfIterations);
			this.Changed_vVector__6();
			this.Changed_vdouble__17();
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
			if (variableName=="vdouble__17") {
				return this.vdouble__17;
			}
			if (variableName=="vVector__6") {
				return this.vVector__6;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName)
		{
			if (variableName=="vVector17") {
				return this.VVector17Marginal();
			}
			if (variableName=="vdouble47") {
				return this.Vdouble47Marginal();
			}
			if (variableName=="vdouble__18") {
				return this.Vdouble__18Marginal();
			}
			if (variableName=="vdouble__20") {
				return this.Vdouble__20Marginal();
			}
			if (variableName=="vdouble__21") {
				return this.Vdouble__21Marginal();
			}
			if (variableName=="vVector__6") {
				return this.VVector__6Marginal();
			}
			if (variableName=="vdouble__17") {
				return this.Vdouble__17Marginal();
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
			if (variableName=="vdouble__17") {
				this.vdouble__17 = (double[])value;
				return ;
			}
			if (variableName=="vVector__6") {
				this.vVector__6 = (Vector[])value;
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
		/// Returns the marginal distribution for 'vdouble__17' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__17Marginal()
		{
			return this.vdouble__17_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__18' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__18Marginal()
		{
			return this.vdouble__18_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__20' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__20Marginal()
		{
			return this.vdouble__20_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble__21' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Gaussian,double> Vdouble__21Marginal()
		{
			return this.vdouble__21_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vdouble47' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gamma Vdouble47Marginal()
		{
			return this.vdouble47_marginal_F;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector__6' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public PointMass<Vector[]> VVector__6Marginal()
		{
			return this.vVector__6_marginal;
		}

		/// <summary>
		/// Returns the marginal distribution for 'vVector17' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public VectorGaussian VVector17Marginal()
		{
			return this.vVector17_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
