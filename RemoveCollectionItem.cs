		for (int num = collection.Count - 1; num >= 0; num--)
		{
			if (collection[num].ServiceType == serviceType)
			{
				collection.RemoveAt(num);
			}
		}
