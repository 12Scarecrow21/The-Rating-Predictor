﻿// This file was auto-generated by ML.NET Model Builder.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML.Trainers.FastTree;

namespace The_Rating_Predictor
{
    public partial class MLModel1
    {
        public const string RetrainFilePath =  @"C:\Users\Mike PC\Desktop\archive\anime.csv";
        public const char RetrainSeparatorChar = ',';
        public const bool RetrainHasHeader =  true;
        public const bool RetrainAllowQuoting =  true;

         /// <summary>
        /// Train a new model with the provided dataset.
        /// </summary>
        /// <param name="outputModelPath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet"</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        public static void Train(string outputModelPath, string inputDataFilePath = RetrainFilePath, char separatorChar = RetrainSeparatorChar, bool hasHeader = RetrainHasHeader, bool allowQuoting = RetrainAllowQuoting)
        {
            var mlContext = new MLContext();

            var data = LoadIDataViewFromFile(mlContext, inputDataFilePath, separatorChar, hasHeader, allowQuoting);
            var model = RetrainModel(mlContext, data);
            SaveModel(mlContext, model, data, outputModelPath);
        }

        /// <summary>
        /// Load an IDataView from a file path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="inputDataFilePath">Path to the data file for training.</param>
        /// <param name="separatorChar">Separator character for delimited training file.</param>
        /// <param name="hasHeader">Boolean if training file has a header.</param>
        /// <returns>IDataView with loaded training data.</returns>
        public static IDataView LoadIDataViewFromFile(MLContext mlContext, string inputDataFilePath, char separatorChar, bool hasHeader, bool allowQuoting)
        {
            return mlContext.Data.LoadFromTextFile<ModelInput>(inputDataFilePath, separatorChar, hasHeader, allowQuoting: allowQuoting);
        }


        /// <summary>
        /// Save a model at the specified path.
        /// </summary>
        /// <param name="mlContext">The common context for all ML.NET operations.</param>
        /// <param name="model">Model to save.</param>
        /// <param name="data">IDataView used to train the model.</param>
        /// <param name="modelSavePath">File path for saving the model. Should be similar to "C:\YourPath\ModelName.mlnet.</param>
        public static void SaveModel(MLContext mlContext, ITransformer model, IDataView data, string modelSavePath)
        {
            // Pull the data schema from the IDataView used for training the model
            DataViewSchema dataViewSchema = data.Schema;

            using (var fs = File.Create(modelSavePath))
            {
                mlContext.Model.Save(model, dataViewSchema, fs);
            }
        }


        /// <summary>
        /// Retrain model using the pipeline generated as part of the training process.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainModel(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(@"anime_id", @"anime_id")      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"name",outputColumnName:@"name"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"genre",outputColumnName:@"genre"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"type",outputColumnName:@"type"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"episodes",outputColumnName:@"episodes"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"members",outputColumnName:@"members"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"anime_id",@"name",@"genre",@"type",@"episodes",@"members"}))      
                                    .Append(mlContext.Regression.Trainers.FastTree(new FastTreeRegressionTrainer.Options(){NumberOfLeaves=103,MinimumExampleCountPerLeaf=13,NumberOfTrees=11,MaximumBinCountPerFeature=52,FeatureFraction=0.7318780936634063,LearningRate=0.333235298840829,LabelColumnName=@"rating",FeatureColumnName=@"Features",DiskTranspose=false}));

            return pipeline;
        }
    }
 }
