using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A097241
{
public static readonly long[] Value={ 7L,19L,41L,79L,131L,193L,269L,491L,1303L,2099L,2689L,3643L,6547L,8707L,9931L,11239L,12703L,14939L,16703L,22571L,26317L,33199L,35419L,37493L,39241L,41263L,48371L,52631L,57529L,73681L,84163L,114797L,119129L,133481L,136027L,138373L,151573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097241Inst : IEnumerable<long>
{
public static readonly long[] Value=A097241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097241.Bytes);
public long this[int i]=>Value[i];

public static A097241Inst Instance=new A097241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097242
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,2L,3L,3L,3L,5L,4L,6L,7L,7L,8L,11L,10L,13L,15L,16L,18L,23L,22L,27L,31L,33L,37L,45L,45L,53L,60L,64L,71L,84L,86L,99L,111L,119L,131L,151L,157L,178L,198L,212L,233L,264L,277L,310L,342L,367L,401L,449L,474L,525L,576L,618L,673L,746L,790L,869L,949L,1017L,1104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097242Inst : IEnumerable<long>
{
public static readonly long[] Value=A097242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097242.Bytes);
public long this[int i]=>Value[i];

public static A097242Inst Instance=new A097242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097243
{
public static readonly long[] Value={ 1L,32L,256L,1408L,6144L,22976L,76800L,235264L,671744L,1809568L,4640256L,11404416L,27009024L,61905088L,137803776L,298806528L,632684544L,1310891584L,2662655232L,5310231424L,10412576768L,20098970624L,38231811072L,71734039808L,132875747328L,243175399136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097243Inst : IEnumerable<long>
{
public static readonly long[] Value=A097243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097243.Bytes);
public long this[int i]=>Value[i];

public static A097243Inst Instance=new A097243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097244
{
public static readonly long[] Value={ 27625L,47125L,55250L,60125L,61625L,66625L,78625L,82875L,86125L,87125L,94250L,99125L,110500L,112625L,118625L,120250L,123250L,129625L,133250L,134125L,141375L,144625L,148625L,155125L,157250L,157625L,164125L,165750L,172250L,174250L,177125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097244Inst : IEnumerable<long>
{
public static readonly long[] Value=A097244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097244.Bytes);
public long this[int i]=>Value[i];

public static A097244Inst Instance=new A097244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097245
{
public static readonly long[] Value={ 71825L,93925L,122525L,143650L,156325L,173225L,187850L,209525L,215475L,223925L,244205L,245050L,257725L,267325L,273325L,281775L,287300L,296225L,308425L,312650L,346450L,357425L,367575L,375700L,376025L,382925L,409825L,419050L,426725L,430950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097245Inst : IEnumerable<long>
{
public static readonly long[] Value=A097245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097245.Bytes);
public long this[int i]=>Value[i];

public static A097245Inst Instance=new A097245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097246
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,7L,6L,5L,10L,11L,9L,13L,14L,15L,9L,17L,10L,19L,15L,21L,22L,23L,18L,7L,26L,15L,21L,29L,30L,31L,18L,33L,34L,35L,15L,37L,38L,39L,30L,41L,42L,43L,33L,25L,46L,47L,27L,11L,14L,51L,39L,53L,30L,55L,42L,57L,58L,59L,45L,61L,62L,35L,27L,65L,66L,67L,51L,69L,70L,71L,30L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097246Inst : IEnumerable<long>
{
public static readonly long[] Value=A097246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097246.Bytes);
public long this[int i]=>Value[i];

public static A097246Inst Instance=new A097246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097247
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,7L,6L,5L,10L,11L,5L,13L,14L,15L,5L,17L,10L,19L,15L,21L,22L,23L,10L,7L,26L,15L,21L,29L,30L,31L,10L,33L,34L,35L,15L,37L,38L,39L,30L,41L,42L,43L,33L,7L,46L,47L,15L,11L,14L,51L,39L,53L,30L,55L,42L,57L,58L,59L,25L,61L,62L,35L,15L,65L,66L,67L,51L,69L,70L,71L,30L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097247Inst : IEnumerable<long>
{
public static readonly long[] Value=A097247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097247.Bytes);
public long this[int i]=>Value[i];

public static A097247Inst Instance=new A097247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097248
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,7L,6L,5L,10L,11L,5L,13L,14L,15L,5L,17L,10L,19L,15L,21L,22L,23L,10L,7L,26L,15L,21L,29L,30L,31L,10L,33L,34L,35L,15L,37L,38L,39L,30L,41L,42L,43L,33L,7L,46L,47L,15L,11L,14L,51L,39L,53L,30L,55L,42L,57L,58L,59L,7L,61L,62L,35L,15L,65L,66L,67L,51L,69L,70L,71L,30L,73L,74L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097248Inst : IEnumerable<long>
{
public static readonly long[] Value=A097248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097248.Bytes);
public long this[int i]=>Value[i];

public static A097248Inst Instance=new A097248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097249
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L,0L,2L,0L,1L,0L,1L,0L,0L,0L,2L,1L,0L,1L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,3L,0L,0L,1L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,3L,2L,0L,0L,2L,0L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,1L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097249Inst : IEnumerable<long>
{
public static readonly long[] Value=A097249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097249.Bytes);
public long this[int i]=>Value[i];

public static A097249Inst Instance=new A097249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097250
{
public static readonly BigInteger[] Value={ 1L,4L,12L,60L,420L,4620L,60060L,1021020L,19399380L,446185740L,12939386460L,401120980260L,14841476269620L,608500527054420L,26165522663340060L,1229779565176982820L,BigInteger.Parse("65178316954380089460"),BigInteger.Parse("3845520700308425278140"),BigInteger.Parse("234576762718813941966540"),BigInteger.Parse("15716643102160534111758180") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097250Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097250.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097250Inst Instance=new A097250Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097251
{
public static readonly long[] Value={ 0L,4L,20L,24L,100L,104L,120L,124L,500L,504L,520L,524L,600L,604L,620L,624L,2500L,2504L,2520L,2524L,2600L,2604L,2620L,2624L,3000L,3004L,3020L,3024L,3100L,3104L,3120L,3124L,12500L,12504L,12520L,12524L,12600L,12604L,12620L,12624L,13000L,13004L,13020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097251Inst : IEnumerable<long>
{
public static readonly long[] Value=A097251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097251.Bytes);
public long this[int i]=>Value[i];

public static A097251Inst Instance=new A097251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097252
{
public static readonly long[] Value={ 0L,5L,30L,35L,180L,185L,210L,215L,1080L,1085L,1110L,1115L,1260L,1265L,1290L,1295L,6480L,6485L,6510L,6515L,6660L,6665L,6690L,6695L,7560L,7565L,7590L,7595L,7740L,7745L,7770L,7775L,38880L,38885L,38910L,38915L,39060L,39065L,39090L,39095L,39960L,39965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097252Inst : IEnumerable<long>
{
public static readonly long[] Value=A097252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097252.Bytes);
public long this[int i]=>Value[i];

public static A097252Inst Instance=new A097252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097253
{
public static readonly long[] Value={ 0L,6L,42L,48L,294L,300L,336L,342L,2058L,2064L,2100L,2106L,2352L,2358L,2394L,2400L,14406L,14412L,14448L,14454L,14700L,14706L,14742L,14748L,16464L,16470L,16506L,16512L,16758L,16764L,16800L,16806L,100842L,100848L,100884L,100890L,101136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097253Inst : IEnumerable<long>
{
public static readonly long[] Value=A097253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097253.Bytes);
public long this[int i]=>Value[i];

public static A097253Inst Instance=new A097253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097254
{
public static readonly long[] Value={ 0L,7L,56L,63L,448L,455L,504L,511L,3584L,3591L,3640L,3647L,4032L,4039L,4088L,4095L,28672L,28679L,28728L,28735L,29120L,29127L,29176L,29183L,32256L,32263L,32312L,32319L,32704L,32711L,32760L,32767L,229376L,229383L,229432L,229439L,229824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097254Inst : IEnumerable<long>
{
public static readonly long[] Value=A097254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097254.Bytes);
public long this[int i]=>Value[i];

public static A097254Inst Instance=new A097254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097255
{
public static readonly long[] Value={ 0L,8L,72L,80L,648L,656L,720L,728L,5832L,5840L,5904L,5912L,6480L,6488L,6552L,6560L,52488L,52496L,52560L,52568L,53136L,53144L,53208L,53216L,58320L,58328L,58392L,58400L,58968L,58976L,59040L,59048L,472392L,472400L,472464L,472472L,473040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097255Inst : IEnumerable<long>
{
public static readonly long[] Value=A097255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097255.Bytes);
public long this[int i]=>Value[i];

public static A097255Inst Instance=new A097255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097256
{
public static readonly long[] Value={ 0L,9L,90L,99L,900L,909L,990L,999L,9000L,9009L,9090L,9099L,9900L,9909L,9990L,9999L,90000L,90009L,90090L,90099L,90900L,90909L,90990L,90999L,99000L,99009L,99090L,99099L,99900L,99909L,99990L,99999L,900000L,900009L,900090L,900099L,900900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097256Inst : IEnumerable<long>
{
public static readonly long[] Value=A097256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097256.Bytes);
public long this[int i]=>Value[i];

public static A097256Inst Instance=new A097256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097257
{
public static readonly long[] Value={ 0L,10L,110L,120L,1210L,1220L,1320L,1330L,13310L,13320L,13420L,13430L,14520L,14530L,14630L,14640L,146410L,146420L,146520L,146530L,147620L,147630L,147730L,147740L,159720L,159730L,159830L,159840L,160930L,160940L,161040L,161050L,1610510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097257Inst : IEnumerable<long>
{
public static readonly long[] Value=A097257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097257.Bytes);
public long this[int i]=>Value[i];

public static A097257Inst Instance=new A097257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097258
{
public static readonly long[] Value={ 0L,11L,132L,143L,1584L,1595L,1716L,1727L,19008L,19019L,19140L,19151L,20592L,20603L,20724L,20735L,228096L,228107L,228228L,228239L,229680L,229691L,229812L,229823L,247104L,247115L,247236L,247247L,248688L,248699L,248820L,248831L,2737152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097258Inst : IEnumerable<long>
{
public static readonly long[] Value=A097258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097258.Bytes);
public long this[int i]=>Value[i];

public static A097258Inst Instance=new A097258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097259
{
public static readonly long[] Value={ 0L,12L,156L,168L,2028L,2040L,2184L,2196L,26364L,26376L,26520L,26532L,28392L,28404L,28548L,28560L,342732L,342744L,342888L,342900L,344760L,344772L,344916L,344928L,369096L,369108L,369252L,369264L,371124L,371136L,371280L,371292L,4455516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097259Inst : IEnumerable<long>
{
public static readonly long[] Value=A097259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097259.Bytes);
public long this[int i]=>Value[i];

public static A097259Inst Instance=new A097259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097260
{
public static readonly long[] Value={ 0L,13L,182L,195L,2548L,2561L,2730L,2743L,35672L,35685L,35854L,35867L,38220L,38233L,38402L,38415L,499408L,499421L,499590L,499603L,501956L,501969L,502138L,502151L,535080L,535093L,535262L,535275L,537628L,537641L,537810L,537823L,6991712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097260Inst : IEnumerable<long>
{
public static readonly long[] Value=A097260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097260.Bytes);
public long this[int i]=>Value[i];

public static A097260Inst Instance=new A097260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097261
{
public static readonly long[] Value={ 0L,14L,210L,224L,3150L,3164L,3360L,3374L,47250L,47264L,47460L,47474L,50400L,50414L,50610L,50624L,708750L,708764L,708960L,708974L,711900L,711914L,712110L,712124L,756000L,756014L,756210L,756224L,759150L,759164L,759360L,759374L,10631250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097261Inst : IEnumerable<long>
{
public static readonly long[] Value=A097261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097261.Bytes);
public long this[int i]=>Value[i];

public static A097261Inst Instance=new A097261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097262
{
public static readonly long[] Value={ 0L,15L,240L,255L,3840L,3855L,4080L,4095L,61440L,61455L,61680L,61695L,65280L,65295L,65520L,65535L,983040L,983055L,983280L,983295L,986880L,986895L,987120L,987135L,1044480L,1044495L,1044720L,1044735L,1048320L,1048335L,1048560L,1048575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097262Inst : IEnumerable<long>
{
public static readonly long[] Value=A097262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097262.Bytes);
public long this[int i]=>Value[i];

public static A097262Inst Instance=new A097262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097263
{
public static readonly long[] Value={ 1L,3L,7L,1L,7L,9L,3L,11L,5L,9L,1L,15L,17L,1L,11L,13L,19L,5L,13L,3L,3L,15L,9L,7L,23L,23L,25L,7L,21L,11L,3L,21L,21L,27L,5L,17L,25L,7L,17L,31L,7L,1L,15L,17L,1L,33L,27L,21L,3L,3L,19L,29L,29L,13L,19L,35L,23L,31L,9L,33L,39L,25L,7L,9L,39L,7L,9L,29L,35L,37L,13L,19L,5L,27L,21L,27L,11L,21L,43L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097263Inst : IEnumerable<long>
{
public static readonly long[] Value=A097263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097263.Bytes);
public long this[int i]=>Value[i];

public static A097263Inst Instance=new A097263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097264
{
public static readonly long[] Value={ 2L,2L,4L,4L,6L,2L,4L,2L,2L,8L,12L,6L,6L,6L,8L,4L,4L,4L,6L,14L,6L,12L,12L,14L,10L,2L,2L,2L,12L,12L,16L,14L,6L,6L,6L,20L,8L,16L,4L,8L,4L,8L,18L,6L,18L,6L,8L,12L,24L,8L,22L,14L,2L,14L,2L,10L,24L,12L,24L,4L,4L,18L,30L,18L,2L,6L,2L,20L,4L,16L,16L,8L,8L,18L,18L,6L,18L,2L,6L,24L,12L,32L,4L,24L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097264Inst : IEnumerable<long>
{
public static readonly long[] Value=A097264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097264.Bytes);
public long this[int i]=>Value[i];

public static A097264Inst Instance=new A097264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097265
{
public static readonly long[] Value={ 2L,6L,4L,8L,6L,6L,12L,10L,14L,12L,12L,10L,6L,18L,16L,16L,8L,20L,18L,18L,22L,16L,20L,22L,10L,14L,10L,26L,16L,24L,24L,18L,22L,14L,30L,20L,20L,28L,28L,8L,32L,32L,26L,30L,30L,10L,24L,28L,28L,36L,26L,22L,26L,34L,34L,14L,24L,24L,32L,24L,12L,30L,30L,38L,18L,42L,42L,28L,28L,20L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097265Inst : IEnumerable<long>
{
public static readonly long[] Value=A097265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097265.Bytes);
public long this[int i]=>Value[i];

public static A097265Inst Instance=new A097265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097266
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,2L,1L,2L,2L,3L,4L,3L,2L,5L,3L,4L,7L,4L,4L,6L,5L,6L,6L,6L,7L,9L,6L,6L,11L,8L,7L,12L,5L,9L,12L,9L,9L,10L,12L,10L,14L,11L,7L,14L,11L,12L,16L,10L,12L,19L,12L,13L,16L,14L,13L,18L,14L,12L,18L,16L,17L,21L,12L,16L,23L,17L,20L,18L,17L,18L,24L,18L,13L,28L,18L,19L,25L,16L,19L,26L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097266Inst : IEnumerable<long>
{
public static readonly long[] Value=A097266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097266.Bytes);
public long this[int i]=>Value[i];

public static A097266Inst Instance=new A097266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097267
{
public static readonly long[] Value={ 1L,3L,9L,19L,21L,27L,39L,33L,59L,51L,75L,57L,63L,103L,81L,0L,93L,121L,111L,99L,133L,123L,181L,129L,141L,153L,159L,211L,147L,227L,183L,171L,217L,263L,271L,201L,189L,219L,0L,307L,237L,243L,261L,249L,301L,267L,367L,485L,231L,291L,303L,409L,309L,419L,327L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097267Inst : IEnumerable<long>
{
public static readonly long[] Value=A097267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097267.Bytes);
public long this[int i]=>Value[i];

public static A097267Inst Instance=new A097267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097268
{
public static readonly long[] Value={ 5L,8L,13L,17L,20L,25L,29L,32L,37L,40L,41L,45L,52L,53L,61L,65L,68L,72L,73L,80L,85L,89L,97L,100L,101L,104L,109L,113L,116L,117L,125L,128L,136L,137L,145L,148L,149L,153L,157L,160L,164L,169L,173L,180L,181L,185L,193L,197L,200L,205L,208L,212L,221L,225L,229L,232L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097268Inst : IEnumerable<long>
{
public static readonly long[] Value=A097268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097268.Bytes);
public long this[int i]=>Value[i];

public static A097268Inst Instance=new A097268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097269
{
public static readonly long[] Value={ 2L,10L,18L,26L,34L,50L,58L,74L,82L,90L,98L,106L,122L,130L,146L,162L,170L,178L,194L,202L,218L,226L,234L,242L,250L,274L,290L,298L,306L,314L,338L,346L,362L,370L,386L,394L,410L,442L,450L,458L,466L,482L,490L,514L,522L,530L,538L,554L,562L,578L,586L,610L,626L,634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097269Inst : IEnumerable<long>
{
public static readonly long[] Value=A097269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097269.Bytes);
public long this[int i]=>Value[i];

public static A097269Inst Instance=new A097269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097270
{
public static readonly long[] Value={ 3L,7L,9L,11L,12L,15L,16L,19L,21L,23L,24L,27L,28L,31L,33L,35L,36L,39L,43L,44L,47L,48L,49L,51L,55L,56L,57L,59L,60L,63L,64L,67L,69L,71L,75L,76L,77L,79L,81L,83L,84L,87L,88L,91L,92L,93L,95L,96L,99L,103L,105L,107L,108L,111L,112L,115L,119L,120L,121L,123L,124L,127L,129L,131L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097270Inst : IEnumerable<long>
{
public static readonly long[] Value=A097270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097270.Bytes);
public long this[int i]=>Value[i];

public static A097270Inst Instance=new A097270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097271
{
public static readonly long[] Value={ 1L,4L,6L,14L,22L,30L,38L,42L,46L,54L,62L,66L,70L,78L,86L,94L,102L,110L,114L,118L,126L,134L,138L,142L,150L,154L,158L,166L,174L,182L,186L,190L,198L,206L,210L,214L,222L,230L,238L,246L,254L,258L,262L,266L,270L,278L,282L,286L,294L,302L,310L,318L,322L,326L,330L,334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097271Inst : IEnumerable<long>
{
public static readonly long[] Value=A097271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097271.Bytes);
public long this[int i]=>Value[i];

public static A097271Inst Instance=new A097271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097272
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,6L,3L,8L,9L,6L,3L,12L,3L,6L,15L,16L,3L,18L,3L,12L,15L,6L,3L,24L,9L,6L,27L,12L,3L,30L,3L,32L,15L,6L,15L,36L,3L,6L,15L,24L,3L,30L,3L,12L,45L,6L,3L,48L,9L,18L,15L,12L,3L,54L,15L,24L,15L,6L,3L,60L,3L,6L,45L,64L,15L,30L,3L,12L,15L,30L,3L,72L,3L,6L,45L,12L,15L,30L,3L,48L,81L,6L,3L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097272Inst : IEnumerable<long>
{
public static readonly long[] Value=A097272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097272.Bytes);
public long this[int i]=>Value[i];

public static A097272Inst Instance=new A097272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097273
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,15L,16L,18L,24L,27L,30L,32L,36L,45L,48L,54L,60L,64L,72L,81L,90L,96L,105L,108L,120L,128L,135L,144L,162L,180L,192L,210L,216L,225L,240L,243L,256L,270L,288L,315L,324L,360L,384L,405L,420L,432L,450L,480L,486L,512L,540L,576L,630L,648L,675L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097273Inst : IEnumerable<long>
{
public static readonly long[] Value=A097273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097273.Bytes);
public long this[int i]=>Value[i];

public static A097273Inst Instance=new A097273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097274
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,18L,16L,27L,54L,12L,15L,30L,32L,81L,162L,64L,243L,486L,128L,729L,1458L,24L,36L,45L,90L,256L,2187L,4374L,512L,6561L,13122L,1024L,19683L,39366L,48L,108L,135L,270L,2048L,59049L,118098L,4096L,177147L,354294L,72L,225L,450L,8192L,531441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097274Inst : IEnumerable<long>
{
public static readonly long[] Value=A097274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097274.Bytes);
public long this[int i]=>Value[i];

public static A097274Inst Instance=new A097274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097275
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,12L,18L,8L,15L,60L,30L,9L,24L,105L,420L,54L,16L,36L,120L,840L,4620L,90L,27L,45L,180L,1155L,9240L,60060L,162L,32L,48L,240L,1260L,13860L,120120L,1021020L,210L,64L,72L,315L,1680L,15015L,180180L,2042040L,19399380L,270L,81L,96L,360L,2520L,18480L,240240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097275Inst : IEnumerable<long>
{
public static readonly long[] Value=A097275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097275.Bytes);
public long this[int i]=>Value[i];

public static A097275Inst Instance=new A097275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097276
{
public static readonly long[] Value={ 5L,38L,29L,11L,4L,79L,14L,28L,24L,5L,13L,53L,18L,4L,213L,13L,10L,8L,5L,79L,9L,7L,4L,176L,40L,11L,8L,5L,40L,10L,9L,4L,39L,14L,27L,13L,5L,13L,6L,83L,4L,17L,8L,10L,23L,5L,7L,32L,22L,4L,19L,26L,28L,19L,5L,78L,38L,11L,4L,26L,14L,36L,18L,5L,12L,26L,17L,4L,16L,25L,9L,7L,5L,26L,11L,8L,4L,21L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097276Inst : IEnumerable<long>
{
public static readonly long[] Value=A097276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097276.Bytes);
public long this[int i]=>Value[i];

public static A097276Inst Instance=new A097276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097277
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,35L,155L,791L,2590L,6756L,59091L,414986L,3520583L,31103150L,168701533L,701447397L,9487636929L,99912639989L,1238924779043L,15635917876565L,118729653870976L,678787849773474L,12421571493668547L,174412390122722852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097277Inst : IEnumerable<long>
{
public static readonly long[] Value=A097277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097277.Bytes);
public long this[int i]=>Value[i];

public static A097277Inst Instance=new A097277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097278
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,3L,3L,2L,1L,0L,0L,3L,6L,8L,9L,9L,35L,35L,32L,26L,18L,9L,0L,0L,35L,70L,102L,128L,146L,155L,155L,0L,0L,35L,105L,207L,335L,481L,636L,791L,0L,0L,0L,35L,140L,347L,682L,1163L,1799L,2590L,6756L,6756L,6756L,6756L,6721L,6581L,6234L,5552L,4389L,2590L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097278Inst : IEnumerable<long>
{
public static readonly long[] Value=A097278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097278.Bytes);
public long this[int i]=>Value[i];

public static A097278Inst Instance=new A097278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097279
{
public static readonly long[] Value={ 5L,11L,23L,59L,67L,83L,89L,101L,107L,109L,127L,163L,167L,197L,229L,233L,251L,283L,311L,317L,349L,421L,491L,557L,577L,643L,673L,683L,719L,727L,761L,827L,1009L,1061L,1129L,1163L,1193L,1231L,1327L,1373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097279Inst : IEnumerable<long>
{
public static readonly long[] Value=A097279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097279.Bytes);
public long this[int i]=>Value[i];

public static A097279Inst Instance=new A097279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097280
{
public static readonly long[] Value={ 5L,7L,9L,13L,19L,29L,45L,71L,113L,181L,291L,469L,757L,1223L,1977L,3197L,5171L,8365L,13533L,21895L,35425L,57317L,92739L,150053L,242789L,392839L,635625L,1028461L,1664083L,2692541L,4356621L,7049159L,11405777L,18454933L,29860707L,48315637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097280Inst : IEnumerable<long>
{
public static readonly long[] Value=A097280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097280.Bytes);
public long this[int i]=>Value[i];

public static A097280Inst Instance=new A097280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097281
{
public static readonly long[] Value={ 0L,1L,2L,5L,9L,18L,35L,71L,144L,294L,601L,1231L,2526L,5191L,10672L,21950L,45159L,92920L,191214L,393512L,809864L,1666775L,3430425L,7060297L,14531166L,29907455L,61554442L,126689294L,260747884L,536663296L,1104544280L,2273340315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097281Inst : IEnumerable<long>
{
public static readonly long[] Value=A097281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097281.Bytes);
public long this[int i]=>Value[i];

public static A097281Inst Instance=new A097281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097282
{
public static readonly long[] Value={ 32045L,40885L,45305L,58565L,64090L,67405L,69745L,77285L,80665L,81770L,90610L,91205L,96135L,98345L,98605L,99905L,101065L,107185L,111605L,114985L,117130L,120445L,122655L,124865L,127465L,128180L,128945L,130645L,134810L,135915L,137605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097282Inst : IEnumerable<long>
{
public static readonly long[] Value=A097282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097282.Bytes);
public long this[int i]=>Value[i];

public static A097282Inst Instance=new A097282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097283
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,2L,3L,1L,5L,2L,4L,1L,6L,2L,5L,3L,4L,1L,7L,2L,6L,3L,5L,1L,8L,2L,7L,3L,6L,4L,5L,1L,9L,2L,8L,3L,7L,4L,6L,1L,10L,2L,9L,3L,8L,4L,7L,5L,6L,1L,11L,2L,10L,3L,9L,4L,8L,5L,7L,1L,12L,2L,11L,3L,10L,4L,9L,5L,8L,6L,7L,1L,13L,2L,12L,3L,11L,4L,10L,5L,9L,6L,8L,1L,14L,2L,13L,3L,12L,4L,11L,5L,10L,6L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097283Inst : IEnumerable<long>
{
public static readonly long[] Value=A097283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097283.Bytes);
public long this[int i]=>Value[i];

public static A097283Inst Instance=new A097283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097284
{
public static readonly long[] Value={ 1L,3L,2L,5L,7L,4L,9L,11L,8L,6L,13L,15L,17L,12L,10L,19L,21L,23L,18L,16L,14L,25L,27L,29L,31L,24L,22L,20L,33L,35L,37L,39L,32L,30L,28L,26L,41L,43L,45L,47L,49L,40L,38L,36L,34L,51L,53L,55L,57L,59L,50L,48L,46L,44L,42L,61L,63L,65L,67L,69L,71L,60L,58L,56L,54L,52L,73L,75L,77L,79L,81L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097284Inst : IEnumerable<long>
{
public static readonly long[] Value=A097284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097284.Bytes);
public long this[int i]=>Value[i];

public static A097284Inst Instance=new A097284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097285
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,1L,4L,2L,4L,3L,4L,1L,5L,2L,5L,3L,5L,4L,5L,1L,6L,2L,6L,3L,6L,4L,6L,5L,6L,1L,7L,2L,7L,3L,7L,4L,7L,5L,7L,6L,7L,1L,8L,2L,8L,3L,8L,4L,8L,5L,8L,6L,8L,7L,8L,1L,9L,2L,9L,3L,9L,4L,9L,5L,9L,6L,9L,7L,9L,8L,9L,1L,10L,2L,10L,3L,10L,4L,10L,5L,10L,6L,10L,7L,10L,8L,10L,9L,10L,1L,11L,2L,11L,3L,11L,4L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097285Inst : IEnumerable<long>
{
public static readonly long[] Value=A097285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097285.Bytes);
public long this[int i]=>Value[i];

public static A097285Inst Instance=new A097285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097286
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,4L,13L,9L,6L,8L,21L,15L,11L,10L,14L,31L,23L,17L,12L,16L,22L,43L,33L,25L,19L,18L,24L,32L,57L,45L,35L,27L,20L,26L,34L,44L,73L,59L,47L,37L,29L,28L,36L,46L,58L,91L,75L,61L,49L,39L,30L,38L,48L,60L,74L,111L,93L,77L,63L,51L,41L,40L,50L,62L,76L,92L,133L,113L,95L,79L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097286Inst : IEnumerable<long>
{
public static readonly long[] Value=A097286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097286.Bytes);
public long this[int i]=>Value[i];

public static A097286Inst Instance=new A097286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097287
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,6L,7L,5L,4L,12L,13L,9L,0L,8L,20L,21L,15L,11L,10L,14L,30L,31L,23L,17L,0L,16L,22L,42L,43L,33L,25L,19L,18L,24L,32L,56L,57L,45L,35L,27L,0L,26L,34L,44L,72L,73L,59L,47L,37L,29L,28L,36L,46L,58L,90L,91L,75L,61L,49L,39L,0L,38L,48L,60L,74L,110L,111L,93L,77L,63L,51L,41L,40L,50L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097287Inst : IEnumerable<long>
{
public static readonly long[] Value=A097287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097287.Bytes);
public long this[int i]=>Value[i];

public static A097287Inst Instance=new A097287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097288
{
public static readonly long[] Value={ 2L,1L,6L,3L,4L,12L,7L,5L,8L,20L,13L,9L,10L,14L,30L,21L,15L,11L,16L,22L,42L,31L,23L,17L,18L,24L,32L,56L,43L,33L,25L,19L,26L,34L,44L,72L,57L,45L,35L,27L,28L,36L,46L,58L,90L,73L,59L,47L,37L,29L,38L,48L,60L,74L,110L,91L,75L,61L,49L,39L,40L,50L,62L,76L,92L,132L,111L,93L,77L,63L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097288Inst : IEnumerable<long>
{
public static readonly long[] Value=A097288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097288.Bytes);
public long this[int i]=>Value[i];

public static A097288Inst Instance=new A097288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097289
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,3L,1L,4L,4L,2L,3L,1L,5L,5L,2L,4L,1L,6L,6L,2L,5L,3L,4L,1L,7L,7L,2L,6L,3L,5L,1L,8L,8L,2L,7L,3L,6L,4L,5L,1L,9L,9L,2L,8L,3L,7L,4L,6L,1L,10L,10L,2L,9L,3L,8L,4L,7L,5L,6L,1L,11L,11L,2L,10L,3L,9L,4L,8L,5L,7L,1L,12L,12L,2L,11L,3L,10L,4L,9L,5L,8L,6L,7L,1L,13L,13L,2L,12L,3L,11L,4L,10L,5L,9L,6L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097289Inst : IEnumerable<long>
{
public static readonly long[] Value=A097289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097289.Bytes);
public long this[int i]=>Value[i];

public static A097289Inst Instance=new A097289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097290
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,8L,11L,7L,9L,13L,16L,12L,10L,14L,18L,21L,23L,17L,15L,19L,25L,28L,30L,24L,22L,20L,26L,32L,35L,37L,39L,31L,29L,27L,33L,41L,44L,46L,48L,40L,38L,36L,34L,42L,50L,53L,55L,57L,59L,49L,47L,45L,43L,51L,61L,64L,66L,68L,70L,60L,58L,56L,54L,52L,62L,72L,75L,77L,79L,81L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097290Inst : IEnumerable<long>
{
public static readonly long[] Value=A097290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097290.Bytes);
public long this[int i]=>Value[i];

public static A097290Inst Instance=new A097290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097291
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,3L,2L,3L,1L,4L,4L,2L,4L,3L,4L,1L,5L,5L,2L,5L,3L,5L,4L,5L,1L,6L,6L,2L,6L,3L,6L,4L,6L,5L,6L,1L,7L,7L,2L,7L,3L,7L,4L,7L,5L,7L,6L,7L,1L,8L,8L,2L,8L,3L,8L,4L,8L,5L,8L,6L,8L,7L,8L,1L,9L,9L,2L,9L,3L,9L,4L,9L,5L,9L,6L,9L,7L,9L,8L,9L,1L,10L,10L,2L,10L,3L,10L,4L,10L,5L,10L,6L,10L,7L,10L,8L,10L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097291Inst : IEnumerable<long>
{
public static readonly long[] Value=A097291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097291.Bytes);
public long this[int i]=>Value[i];

public static A097291Inst Instance=new A097291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097292
{
public static readonly long[] Value={ 1L,2L,4L,5L,3L,9L,10L,8L,7L,16L,17L,13L,6L,12L,25L,26L,20L,15L,14L,19L,36L,37L,29L,22L,11L,21L,28L,49L,50L,40L,31L,24L,23L,30L,39L,64L,65L,53L,42L,33L,18L,32L,41L,52L,81L,82L,68L,55L,44L,35L,34L,43L,54L,67L,100L,101L,85L,70L,57L,46L,27L,45L,56L,69L,84L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097292Inst : IEnumerable<long>
{
public static readonly long[] Value=A097292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097292.Bytes);
public long this[int i]=>Value[i];

public static A097292Inst Instance=new A097292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097293
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,4L,1L,2L,5L,1L,3L,4L,1L,2L,6L,1L,3L,5L,2L,3L,4L,1L,2L,7L,1L,3L,6L,1L,4L,5L,2L,3L,5L,1L,2L,8L,1L,3L,7L,1L,4L,6L,2L,3L,6L,2L,4L,5L,1L,2L,9L,1L,3L,8L,1L,4L,7L,1L,5L,6L,2L,3L,7L,2L,4L,6L,3L,4L,5L,1L,2L,10L,1L,3L,9L,1L,4L,8L,1L,5L,7L,2L,3L,8L,2L,4L,7L,2L,5L,6L,3L,4L,6L,1L,2L,11L,1L,3L,10L,1L,4L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097293Inst : IEnumerable<long>
{
public static readonly long[] Value=A097293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097293.Bytes);
public long this[int i]=>Value[i];

public static A097293Inst Instance=new A097293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097294
{
public static readonly long[] Value={ 3L,2L,1L,4L,2L,1L,5L,2L,1L,4L,3L,1L,6L,2L,1L,5L,3L,1L,4L,3L,2L,7L,2L,1L,6L,3L,1L,5L,4L,1L,5L,3L,2L,8L,2L,1L,7L,3L,1L,6L,4L,1L,6L,3L,2L,5L,4L,2L,9L,2L,1L,8L,3L,1L,7L,4L,1L,6L,5L,1L,7L,3L,2L,6L,4L,2L,5L,4L,3L,10L,2L,1L,9L,3L,1L,8L,4L,1L,7L,5L,1L,8L,3L,2L,7L,4L,2L,6L,5L,2L,6L,4L,3L,11L,2L,1L,10L,3L,1L,9L,4L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097294Inst : IEnumerable<long>
{
public static readonly long[] Value=A097294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097294.Bytes);
public long this[int i]=>Value[i];

public static A097294Inst Instance=new A097294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097295
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,3L,2L,2L,1L,2L,2L,2L,2L,2L,3L,2L,2L,1L,1L,2L,2L,2L,2L,3L,2L,1L,1L,2L,2L,2L,2L,2L,3L,1L,1L,2L,1L,3L,2L,2L,1L,3L,3L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,3L,2L,2L,1L,1L,2L,2L,3L,2L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097295Inst : IEnumerable<long>
{
public static readonly long[] Value=A097295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097295.Bytes);
public long this[int i]=>Value[i];

public static A097295Inst Instance=new A097295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097296
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,11L,12L,13L,14L,17L,19L,20L,22L,23L,26L,27L,28L,29L,30L,31L,34L,36L,37L,38L,41L,43L,44L,46L,47L,48L,52L,53L,56L,58L,59L,61L,62L,67L,68L,70L,71L,73L,74L,76L,79L,82L,83L,86L,89L,92L,94L,97L,101L,103L,105L,106L,107L,109L,110L,113L,116L,118L,122L,124L,127L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097296Inst : IEnumerable<long>
{
public static readonly long[] Value=A097296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097296.Bytes);
public long this[int i]=>Value[i];

public static A097296Inst Instance=new A097296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097297
{
public static readonly long[] Value={ 6L,37L,133L,364L,840L,1722L,3234L,5676L,9438L,15015L,23023L,34216L,49504L,69972L,96900L,131784L,176358L,232617L,302841L,389620L,495880L,624910L,780390L,966420L,1187550L,1448811L,1755747L,2114448L,2531584L,3014440L,3570952L,4209744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097297Inst : IEnumerable<long>
{
public static readonly long[] Value=A097297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097297.Bytes);
public long this[int i]=>Value[i];

public static A097297Inst Instance=new A097297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097298
{
public static readonly long[] Value={ 6L,43L,176L,540L,1380L,3102L,6336L,12012L,21450L,36465L,59488L,93704L,143208L,213180L,310080L,441864L,618222L,850839L,1153680L,1543300L,2039180L,2664090L,3444480L,4410900L,5598450L,7047261L,8803008L,10917456L,13449040L,16463480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097298Inst : IEnumerable<long>
{
public static readonly long[] Value=A097298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097298.Bytes);
public long this[int i]=>Value[i];

public static A097298Inst Instance=new A097298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097299
{
public static readonly long[] Value={ 6L,49L,225L,765L,2145L,5247L,11583L,23595L,45045L,81510L,140998L,234702L,377910L,591090L,901170L,1343034L,1961256L,2812095L,3965775L,5509075L,7548255L,10212345L,13656825L,18067725L,23666175L,30713436L,39516444L,50433900L,63882940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097299Inst : IEnumerable<long>
{
public static readonly long[] Value=A097299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097299.Bytes);
public long this[int i]=>Value[i];

public static A097299Inst Instance=new A097299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097300
{
public static readonly long[] Value={ 6L,55L,280L,1045L,3190L,8437L,20020L,43615L,88660L,170170L,311168L,545870L,923780L,1514870L,2416040L,3759074L,5720330L,8532425L,12498200L,18007275L,25555530L,35767875L,49424700L,67492425L,91158600L,121872036L,161388480L,211822380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097300Inst : IEnumerable<long>
{
public static readonly long[] Value=A097300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097300.Bytes);
public long this[int i]=>Value[i];

public static A097300Inst Instance=new A097300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097301
{
public static readonly BigInteger[] Value={ 1L,-1L,2L,-3L,3360L,-995040L,39916800L,-656924748480L,1214047650816000L,-169382556838010880L,BigInteger.Parse("15749593891765493760000"),BigInteger.Parse("-4054844479616799289344000"),BigInteger.Parse("34017686450062663131463680000"),BigInteger.Parse("-11402327189708082115897599590400000"),BigInteger.Parse("189528830020089532044244068728832000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097301Inst Instance=new A097301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097302
{
public static readonly long[] Value={ 12L,60L,21L,1L,11L,13L,1L,17L,19L,1L,23L,1L,1L,29L,31L,1L,1L,37L,1L,41L,43L,1L,47L,1L,1L,53L,1L,1L,59L,61L,1L,1L,67L,1L,71L,73L,1L,1L,79L,1L,83L,1L,1L,89L,1L,1L,1L,97L,1L,101L,103L,1L,107L,109L,1L,113L,1L,1L,1L,1L,1L,1L,127L,1L,131L,1L,1L,137L,139L,1L,1L,1L,1L,149L,151L,1L,1L,157L,1L,1L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097302Inst : IEnumerable<long>
{
public static readonly long[] Value=A097302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097302.Bytes);
public long this[int i]=>Value[i];

public static A097302Inst Instance=new A097302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097303
{
public static readonly BigInteger[] Value={ 1L,12L,144L,8640L,103680L,1741824L,104509440L,179159040L,2149908480L,1418939596800L,23838185226240L,338068808663040L,20284128519782400L,18723810941337600L,32097961613721600L,BigInteger.Parse("229179445921972224000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097303Inst Instance=new A097303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097304
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,2L,0L,1L,0L,1L,1L,0L,3L,0L,2L,0L,1L,0L,1L,0L,3L,0L,3L,0L,2L,0L,1L,0L,1L,1L,0L,4L,0L,3L,0L,2L,0L,1L,0L,1L,0L,3L,0L,5L,0L,3L,0L,2L,0L,1L,0L,1L,1L,0L,5L,0L,5L,0L,3L,0L,2L,0L,1L,0L,1L,0L,4L,0L,6L,0L,5L,0L,3L,0L,2L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097304Inst : IEnumerable<long>
{
public static readonly long[] Value=A097304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097304.Bytes);
public long this[int i]=>Value[i];

public static A097304Inst Instance=new A097304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097305
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,3L,2L,1L,1L,1L,3L,3L,2L,1L,1L,3L,4L,2L,1L,1L,1L,4L,4L,3L,2L,1L,1L,4L,5L,4L,2L,1L,1L,1L,4L,6L,5L,3L,2L,1L,1L,5L,7L,6L,4L,2L,1L,1L,1L,5L,8L,7L,5L,3L,2L,1L,1L,5L,9L,9L,6L,4L,2L,1L,1L,1L,6L,10L,10L,8L,5L,3L,2L,1L,1L,6L,11L,12L,10L,6L,4L,2L,1L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097305Inst : IEnumerable<long>
{
public static readonly long[] Value=A097305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097305.Bytes);
public long this[int i]=>Value[i];

public static A097305Inst Instance=new A097305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097306
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,3L,4L,1L,3L,4L,5L,1L,3L,5L,6L,1L,4L,6L,7L,8L,1L,4L,7L,9L,10L,1L,4L,8L,10L,11L,12L,1L,5L,9L,12L,14L,15L,1L,5L,10L,14L,16L,17L,18L,1L,5L,11L,16L,19L,21L,22L,1L,6L,13L,19L,23L,25L,26L,27L,1L,6L,14L,21L,26L,29L,31L,32L,1L,6L,15L,24L,30L,34L,36L,37L,38L,1L,7L,17L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097306Inst : IEnumerable<long>
{
public static readonly long[] Value=A097306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097306.Bytes);
public long this[int i]=>Value[i];

public static A097306Inst Instance=new A097306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097307
{
public static readonly long[] Value={ 1L,1L,3L,3L,6L,8L,13L,15L,26L,31L,46L,56L,81L,95L,140L,160L,221L,261L,351L,406L,548L,626L,820L,945L,1221L,1393L,1788L,2035L,2566L,2928L,3656L,4139L,5146L,5810L,7148L,8078L,9850L,11086L,13461L,15116L,18214L,20441L,24489L,27400L,32708L,36516L,43329L,48345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097307Inst : IEnumerable<long>
{
public static readonly long[] Value=A097307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097307.Bytes);
public long this[int i]=>Value[i];

public static A097307Inst Instance=new A097307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097308
{
public static readonly BigInteger[] Value={ 1L,13L,337L,8749L,227137L,5896813L,153090001L,3974443213L,103182433537L,2678768828749L,69544807113937L,1805486216133613L,46873096812360001L,1216895030905226413L,BigInteger.Parse("31592397706723526737"),BigInteger.Parse("820185445343906468749"),BigInteger.Parse("21293229181234844660737"),BigInteger.Parse("552803773266762054710413") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097308Inst Instance=new A097308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097309
{
public static readonly BigInteger[] Value={ 0L,1L,26L,675L,17524L,454949L,11811150L,306634951L,7960697576L,206671502025L,5365498355074L,139296285729899L,3616337930622300L,93885489910449901L,2437406399741075126L,BigInteger.Parse("63278680903357503375"),BigInteger.Parse("1642808297087554012624") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097309Inst Instance=new A097309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097310
{
public static readonly BigInteger[] Value={ 1L,14L,391L,10934L,305761L,8550374L,239104711L,6686381534L,186979578241L,5228741809214L,146217791079751L,4088869408423814L,114342125644787041L,3197490648645613334L,BigInteger.Parse("89415396036432386311"),BigInteger.Parse("2500433598371461203374"),BigInteger.Parse("69922725358364481308161"),BigInteger.Parse("1955335876435834015425134") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097310Inst Instance=new A097310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097311
{
public static readonly BigInteger[] Value={ 0L,1L,28L,783L,21896L,612305L,17122644L,478821727L,13389885712L,374437978209L,10470873504140L,292810020137711L,8188209690351768L,228977061309711793L,6403169506981578436L,BigInteger.Parse("179059769134174484415"),BigInteger.Parse("5007270366249903985184") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097311Inst Instance=new A097311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097312
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,14L,16L,17L,20L,30L,31L,32L,34L,35L,37L,38L,50L,70L,71L,73L,74L,76L,79L,91L,92L,95L,97L,98L,101L,103L,104L,106L,107L,110L,113L,115L,118L,119L,121L,124L,125L,127L,128L,131L,133L,140L,142L,143L,146L,149L,152L,154L,157L,160L,163L,164L,166L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097312Inst : IEnumerable<long>
{
public static readonly long[] Value=A097312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097312.Bytes);
public long this[int i]=>Value[i];

public static A097312Inst Instance=new A097312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097313
{
public static readonly BigInteger[] Value={ 0L,1L,30L,899L,26940L,807301L,24192090L,724955399L,21724469880L,651009141001L,19508549760150L,584605483663499L,17518655960144820L,524975073320681101L,15731733543660288210UL,BigInteger.Parse("471427031236487965199"),BigInteger.Parse("14127079203550978667760") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097313Inst Instance=new A097313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097314
{
public static readonly BigInteger[] Value={ 1L,39L,1481L,56239L,2135601L,81096599L,3079535161L,116941239519L,4440687566561L,168629186289799L,6403468391445801L,243163169688650639L,9233796979777278481UL,BigInteger.Parse("350641122061847931639"),BigInteger.Parse("13315128841370444123801"),BigInteger.Parse("505624254850015028772799"),BigInteger.Parse("19200406555459200649242561"),BigInteger.Parse("729109824852599609642444519"),BigInteger.Parse("27686972937843325965763649161") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097314Inst Instance=new A097314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097315
{
public static readonly BigInteger[] Value={ 1L,37L,1405L,53353L,2026009L,76934989L,2921503573L,110940200785L,4212806126257L,159975692596981L,6074863512559021L,230684837784645817L,8759948972303982025L,BigInteger.Parse("332647376109766671133"),BigInteger.Parse("12631840343198829521029"),BigInteger.Parse("479677285665445755127969"),BigInteger.Parse("18215105014943739865341793"),BigInteger.Parse("691694313282196669127860165") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097315Inst Instance=new A097315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097316
{
public static readonly BigInteger[] Value={ 1L,66L,4355L,287364L,18961669L,1251182790L,82559102471L,5447649580296L,359462313197065L,23719065021425994L,1565098829100918539L,BigInteger.Parse("103272803655639197580"),BigInteger.Parse("6814439942443086121741"),BigInteger.Parse("449649763397588044837326") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097316Inst Instance=new A097316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097317
{
public static readonly BigInteger[] Value={ 177L,2530L,94932L,1647086L,1996813914L,96951758924L,232630924325880L,11398896079244882L,BigInteger.Parse("27368747343485741790"),BigInteger.Parse("3219905755813196976713916"),BigInteger.Parse("157775382034845834127656854"),BigInteger.Parse("18562115921017574302548095548340") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097317Inst Instance=new A097317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097318
{
public static readonly long[] Value={ 6L,10L,12L,14L,15L,20L,21L,22L,24L,26L,28L,30L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,51L,52L,55L,56L,57L,58L,60L,62L,63L,65L,66L,68L,69L,70L,72L,74L,76L,77L,78L,80L,82L,84L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,99L,100L,102L,104L,105L,106L,110L,111L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097318Inst : IEnumerable<long>
{
public static readonly long[] Value=A097318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097318.Bytes);
public long this[int i]=>Value[i];

public static A097318Inst Instance=new A097318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097319
{
public static readonly long[] Value={ 18L,50L,54L,75L,98L,108L,147L,162L,242L,245L,250L,324L,338L,363L,375L,486L,500L,507L,578L,605L,648L,686L,722L,845L,847L,867L,972L,1029L,1058L,1083L,1125L,1183L,1250L,1372L,1445L,1458L,1587L,1682L,1715L,1805L,1859L,1875L,1922L,1944L,2023L,2250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097319Inst : IEnumerable<long>
{
public static readonly long[] Value=A097319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097319.Bytes);
public long this[int i]=>Value[i];

public static A097319Inst Instance=new A097319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097320
{
public static readonly long[] Value={ 12L,20L,24L,28L,40L,44L,45L,48L,52L,56L,63L,68L,72L,76L,80L,88L,92L,96L,99L,104L,112L,116L,117L,124L,135L,136L,144L,148L,152L,153L,160L,164L,171L,172L,175L,176L,184L,188L,189L,192L,200L,207L,208L,212L,224L,232L,236L,244L,248L,261L,268L,272L,275L,279L,284L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097320Inst : IEnumerable<long>
{
public static readonly long[] Value=A097320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097320.Bytes);
public long this[int i]=>Value[i];

public static A097320Inst Instance=new A097320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097321
{
public static readonly long[] Value={ 24L,210L,720L,1716L,3360L,5814L,9240L,13800L,19656L,26970L,35904L,46620L,59280L,74046L,91080L,110544L,132600L,157410L,185136L,215940L,249984L,287430L,328440L,373176L,421800L,474474L,531360L,592620L,658416L,728910L,804264L,884640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097321Inst : IEnumerable<long>
{
public static readonly long[] Value=A097321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097321.Bytes);
public long this[int i]=>Value[i];

public static A097321Inst Instance=new A097321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097322
{
public static readonly long[] Value={ 1L,4L,1L,1L,4L,1L,1L,4L,1L,11L,4L,1L,1L,4L,11L,1L,4L,31L,1L,44L,29L,1L,4L,1L,11L,4L,29L,1L,4L,11L,1L,4L,31L,1L,1276L,1L,41L,4L,1L,11L,116L,1L,1L,292L,11L,1L,4L,31L,127571L,44L,1L,1L,4L,1L,319L,4L,41L,1L,4L,11L,1L,4L,899L,1L,44L,1L,1L,4L,29L,11L,4L,1L,1L,4L,583L,1L,4756L,361429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097322Inst : IEnumerable<long>
{
public static readonly long[] Value=A097322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097322.Bytes);
public long this[int i]=>Value[i];

public static A097322Inst Instance=new A097322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097323
{
public static readonly long[] Value={ 5L,247L,403L,4030L,5873L,43970L,65955L,78883L,116355L,127270L,368671L,372259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097323Inst : IEnumerable<long>
{
public static readonly long[] Value=A097323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097323.Bytes);
public long this[int i]=>Value[i];

public static A097323Inst Instance=new A097323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097324
{
public static readonly long[] Value={ 14L,18L,23L,25L,29L,35L,36L,40L,41L,42L,47L,51L,53L,58L,61L,62L,63L,69L,70L,71L,73L,80L,81L,84L,86L,88L,89L,90L,91L,95L,96L,99L,100L,102L,104L,106L,107L,109L,110L,113L,117L,118L,124L,127L,128L,130L,132L,135L,137L,139L,141L,146L,147L,150L,152L,155L,156L,157L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097324Inst : IEnumerable<long>
{
public static readonly long[] Value=A097324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097324.Bytes);
public long this[int i]=>Value[i];

public static A097324Inst Instance=new A097324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097325
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097325Inst : IEnumerable<long>
{
public static readonly long[] Value=A097325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097325.Bytes);
public long this[int i]=>Value[i];

public static A097325Inst Instance=new A097325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097326
{
public static readonly long[] Value={ 9L,4L,3L,2L,1L,1L,1L,1L,1L,9L,9L,8L,7L,7L,6L,6L,5L,5L,5L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097326Inst : IEnumerable<long>
{
public static readonly long[] Value=A097326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097326.Bytes);
public long this[int i]=>Value[i];

public static A097326Inst Instance=new A097326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097327
{
public static readonly long[] Value={ 10L,5L,4L,3L,2L,2L,2L,2L,2L,10L,10L,9L,8L,8L,7L,7L,6L,6L,6L,5L,5L,5L,5L,5L,4L,4L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097327Inst : IEnumerable<long>
{
public static readonly long[] Value=A097327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097327.Bytes);
public long this[int i]=>Value[i];

public static A097327Inst Instance=new A097327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097328
{
public static readonly long[] Value={ 1L,5L,45L,585L,9945L,69615L,348075L,10094175L,111035925L,4108329225L,168441498225L,56147166075L,393030162525L,20830598613825L,395781373662675L,24142663793423175L,24142663793423175L,555281267248733025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097328Inst : IEnumerable<long>
{
public static readonly long[] Value=A097328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097328.Bytes);
public long this[int i]=>Value[i];

public static A097328Inst Instance=new A097328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097329
{
public static readonly long[] Value={ 3L,21L,231L,1155L,21945L,504735L,4542615L,140821065L,140821065L,1830673845L,78718975335L,3699791840745L,62896461292665L,62896461292665L,3710891216267235L,3710891216267235L,248629711489904745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097329Inst : IEnumerable<long>
{
public static readonly long[] Value=A097329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097329.Bytes);
public long this[int i]=>Value[i];

public static A097329Inst Instance=new A097329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097330
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,4L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,14L,15L,15L,16L,18L,19L,20L,21L,21L,22L,23L,24L,26L,27L,29L,30L,30L,31L,33L,34L,35L,36L,36L,37L,39L,40L,41L,42L,44L,45L,48L,49L,50L,51L,51L,52L,53L,54L,54L,55L,56L,57L,63L,64L,65L,66L,68L,69L,69L,70L,74L,75L,75L,76L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097330Inst : IEnumerable<long>
{
public static readonly long[] Value=A097330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097330.Bytes);
public long this[int i]=>Value[i];

public static A097330Inst Instance=new A097330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097331
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,2L,0L,5L,0L,14L,0L,42L,0L,132L,0L,429L,0L,1430L,0L,4862L,0L,16796L,0L,58786L,0L,208012L,0L,742900L,0L,2674440L,0L,9694845L,0L,35357670L,0L,129644790L,0L,477638700L,0L,1767263190L,0L,6564120420L,0L,24466267020L,0L,91482563640L,0L,343059613650L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097331Inst : IEnumerable<long>
{
public static readonly long[] Value=A097331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097331.Bytes);
public long this[int i]=>Value[i];

public static A097331Inst Instance=new A097331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097332
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,18L,39L,90L,217L,540L,1375L,3563L,9361L,24872L,66707L,180341L,490913L,1344380L,3701159L,10237541L,28436825L,79288844L,221836403L,622599626L,1752360041L,4945087838L,13988490339L,39658308815L,112666081617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097332Inst : IEnumerable<long>
{
public static readonly long[] Value=A097332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097332.Bytes);
public long this[int i]=>Value[i];

public static A097332Inst Instance=new A097332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097333
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,7L,10L,15L,22L,32L,47L,69L,101L,148L,217L,318L,466L,683L,1001L,1467L,2150L,3151L,4618L,6768L,9919L,14537L,21305L,31224L,45761L,67066L,98290L,144051L,211117L,309407L,453458L,664575L,973982L,1427440L,2092015L,3065997L,4493437L,6585452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097333Inst : IEnumerable<long>
{
public static readonly long[] Value=A097333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097333.Bytes);
public long this[int i]=>Value[i];

public static A097333Inst Instance=new A097333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097334
{
public static readonly long[] Value={ 1L,3L,3L,7L,19L,31L,59L,135L,259L,495L,1035L,2071L,4051L,8191L,16475L,32679L,65443L,131343L,262059L,523831L,1049203L,2097439L,4192763L,8389575L,16779331L,33550383L,67108683L,134226007L,268427539L,536862271L,1073766299L,2147476455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097334Inst : IEnumerable<long>
{
public static readonly long[] Value=A097334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097334.Bytes);
public long this[int i]=>Value[i];

public static A097334Inst Instance=new A097334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097335
{
public static readonly long[] Value={ 1L,4L,4L,13L,49L,85L,202L,643L,1408L,3226L,9013L,21685L,50719L,131836L,327001L,783472L,1969996L,4913005L,11964253L,29694217L,73911262L,181589539L,448837492L,1114038850L,2748344701L,6787882129L,16814231779L,41549334088L,102640273249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097335Inst : IEnumerable<long>
{
public static readonly long[] Value=A097335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097335.Bytes);
public long this[int i]=>Value[i];

public static A097335Inst Instance=new A097335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097336
{
public static readonly long[] Value={ 1L,5L,5L,21L,101L,181L,517L,2133L,5029L,13301L,47429L,127893L,340709L,1099573L,3145861L,8597205L,26190373L,76524149L,214079429L,633125397L,1857511781L,5282782645L,15412788997L,45132977493L,129657499813L,376262123765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097336Inst : IEnumerable<long>
{
public static readonly long[] Value=A097336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097336.Bytes);
public long this[int i]=>Value[i];

public static A097336Inst Instance=new A097336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097337
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,4L,5L,5L,6L,6L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,21L,22L,23L,23L,24L,24L,25L,25L,26L,27L,27L,28L,28L,29L,30L,30L,31L,31L,32L,32L,33L,34L,34L,35L,35L,36L,36L,37L,38L,38L,39L,39L,40L,40L,41L,42L,42L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097337Inst : IEnumerable<long>
{
public static readonly long[] Value=A097337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097337.Bytes);
public long this[int i]=>Value[i];

public static A097337Inst Instance=new A097337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097338
{
public static readonly long[] Value={ 7L,8L,9L,11L,12L,14L,15L,17L,20L,21L,24L,26L,27L,29L,32L,35L,36L,39L,41L,42L,45L,47L,50L,54L,56L,57L,59L,60L,62L,69L,71L,74L,75L,80L,81L,84L,87L,89L,92L,95L,96L,101L,102L,104L,105L,111L,117L,119L,120L,122L,125L,126L,131L,134L,137L,140L,141L,144L,146L,147L,152L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097338Inst : IEnumerable<long>
{
public static readonly long[] Value=A097338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097338.Bytes);
public long this[int i]=>Value[i];

public static A097338Inst Instance=new A097338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097339
{
public static readonly long[] Value={ 1L,3L,12L,35L,80L,157L,280L,471L,768L,1241L,2024L,3379L,5824L,10389L,19128L,36143L,69632L,135985L,267976L,531147L,1056576L,2106413L,4204952L,8400775L,16791040L,33570057L,67126440L,134237411L,268457408L,536895301L,1073768824L,2147513439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097339Inst : IEnumerable<long>
{
public static readonly long[] Value=A097339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097339.Bytes);
public long this[int i]=>Value[i];

public static A097339Inst Instance=new A097339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097340
{
public static readonly long[] Value={ 1L,24L,276L,2048L,11202L,49152L,184024L,614400L,1881471L,5373952L,14478180L,37122048L,91231550L,216072192L,495248952L,1102430208L,2390434947L,5061476352L,10487167336L,21301241856L,42481784514L,83300614144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097340Inst : IEnumerable<long>
{
public static readonly long[] Value=A097340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097340.Bytes);
public long this[int i]=>Value[i];

public static A097340Inst Instance=new A097340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}