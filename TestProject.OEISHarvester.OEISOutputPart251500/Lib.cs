using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A086875
{
public static readonly long[] Value={ 1L,21L,1147L,211965L,143331811L };
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
public class A086875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086875Inst : IEnumerable<long>
{
public static readonly long[] Value=A086875.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086875.Bytes);
public long this[int i]=>Value[i];

public static A086875Inst Instance=new A086875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086876
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,4L,2L,2L,4L,4L,4L,2L,2L,4L,4L,4L,4L,4L,4L,4L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,6L,2L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,6L,2L,4L,4L,4L,4L,4L,4L,6L,4L,6L,6L,6L,6L,6L,2L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,6L,2L,4L,4L,4L,4L,4L,4L,6L,4L,6L,6L,6L };
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
public class A086876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086876Inst : IEnumerable<long>
{
public static readonly long[] Value=A086876.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086876.Bytes);
public long this[int i]=>Value[i];

public static A086876Inst Instance=new A086876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086877
{
public static readonly long[] Value={ 5L,37L,4651L,1273609L };
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
public class A086877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086877Inst : IEnumerable<long>
{
public static readonly long[] Value=A086877.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086877.Bytes);
public long this[int i]=>Value[i];

public static A086877Inst Instance=new A086877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086878
{
public static readonly long[] Value={ 191L,701L,743L,1111L,1389L,1479L,2103L,2215L,2375L,2681L,2951L,4281L,4423L,4491L,4743L,5337L,5517L,5895L,6319L,6367L,6491L,6703L,6751L,7247L,7319L,7463L,7481L,7571L,7751L,7909L,7993L,8043L,8083L,8269L,8425L,8537L,8839L,8853L,8971L,9479L,10481L };
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
public class A086878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086878Inst : IEnumerable<long>
{
public static readonly long[] Value=A086878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086878.Bytes);
public long this[int i]=>Value[i];

public static A086878Inst Instance=new A086878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086879
{
public static readonly BigInteger[] Value={ 1L,4L,36L,576L,18880L,1208320L,155553792L,39821770752L,20417644331008L,20907667794952192L,BigInteger.Parse("42834024773286100992"),BigInteger.Parse("175448165471379869663232"),BigInteger.Parse("1437398154830976169705209856"),BigInteger.Parse("23550331368750713564450158280704") };
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
public class A086879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086879.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086879Inst Instance=new A086879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086880
{
public static readonly long[] Value={ 2L,1L,2L,3L,7L,17L,45L,128L,391L,1287L,4524L,16889L,66657L,276982L,1207598L,5507362L,26203307L,129757596L,667358910L,3558097578L,19632277761L,111930731957L,658482495614L,3992062349412L,24911272290567L,159833355923362L };
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
public class A086880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086880Inst : IEnumerable<long>
{
public static readonly long[] Value=A086880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086880.Bytes);
public long this[int i]=>Value[i];

public static A086880Inst Instance=new A086880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086881
{
public static readonly BigInteger[] Value={ 1L,34L,1788L,146256L,17485920L,2894002560L,635331029760L,178910029670400L,62920533840998400L,BigInteger.Parse("27042268338763776000"),BigInteger.Parse("13950701922125574144000"),BigInteger.Parse("8509745665997194493952000"),BigInteger.Parse("6059691013778107566981120000") };
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
public class A086881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086881Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086881.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086881.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086881Inst Instance=new A086881Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086882
{
public static readonly long[] Value={ 0L,0L,2L,2L,0L,4L,4L,5L,4L,0L,6L,6L,6L,10L,8L,6L,0L,8L,8L,10L,8L,10L,12L,11L,8L,0L,10L,10L,12L,16L,10L,17L,11L,12L,14L,10L,0L,12L,12L,12L,12L,16L,12L,16L,16L,16L,26L,17L,12L,0L,14L,14L,16L,22L,16L,16L,14L,16L,20L,18L,16L,36L,20L,14L,0L,16L,16L,22L,16L,26L,18L,27L,16L,30L,20L,17L,26L,22L };
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
public class A086882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086882Inst : IEnumerable<long>
{
public static readonly long[] Value=A086882.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086882.Bytes);
public long this[int i]=>Value[i];

public static A086882Inst Instance=new A086882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086883
{
public static readonly long[] Value={ 3L,6L,9L,11L,12L,15L,18L,22L,24L,30L,33L,36L,44L,45L,48L,55L,60L,66L,72L,75L,88L,90L,91L,96L,99L,101L,110L,111L,120L,132L,137L,144L,150L,165L,176L,180L,182L,192L,198L,220L,225L,240L,264L,273L,275L,288L,300L,303L,330L,333L,352L,360L,364L,375L,384L,396L,440L,444L };
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
public class A086883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086883Inst : IEnumerable<long>
{
public static readonly long[] Value=A086883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086883.Bytes);
public long this[int i]=>Value[i];

public static A086883Inst Instance=new A086883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086948
{
public static readonly long[] Value={ 12L,192L,1992L,19992L,199992L,1999992L,19999992L,199999992L,1999999992L,19999999992L,199999999992L,1999999999992L,19999999999992L,199999999999992L,1999999999999992L,19999999999999992L,199999999999999992L };
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
public class A086948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086948Inst : IEnumerable<long>
{
public static readonly long[] Value=A086948.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086948.Bytes);
public long this[int i]=>Value[i];

public static A086948Inst Instance=new A086948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086949
{
public static readonly long[] Value={ 41L,491L,4991L,49991L,499991L,4999991L,49999991L,499999991L,4999999991L,49999999991L,499999999991L,4999999999991L,49999999999991L,499999999999991L,4999999999999991L,49999999999999991L,499999999999999991L };
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
public class A086949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086949Inst : IEnumerable<long>
{
public static readonly long[] Value=A086949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086949.Bytes);
public long this[int i]=>Value[i];

public static A086949Inst Instance=new A086949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086950
{
public static readonly long[] Value={ 0L,1L,12L,60L,224L,720L,2112L,5824L,15360L,39168L,97280L,236544L,565248L,1331200L,3096576L,7127040L,16252928L,36765696L,82575360L,184287232L,408944640L,902823936L,1983905792L,4341104640L,9462349824L,20552089600L,44493176832L };
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
public class A086950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086950Inst : IEnumerable<long>
{
public static readonly long[] Value=A086950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086950.Bytes);
public long this[int i]=>Value[i];

public static A086950Inst Instance=new A086950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086951
{
public static readonly long[] Value={ 0L,1L,14L,99L,540L,2565L,11178L,45927L,180792L,688905L,2558790L,9310059L,33303636L,117448461L,409209570L,1410975855L,4821232752L,16343405073L,55013709438L,184024732275L,612124372620L,2025821736981L,6673705343514L,21893519253879L };
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
public class A086951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086951Inst : IEnumerable<long>
{
public static readonly long[] Value=A086951.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086951.Bytes);
public long this[int i]=>Value[i];

public static A086951Inst Instance=new A086951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086952
{
public static readonly long[] Value={ 0L,1L,16L,144L,1024L,6400L,36864L,200704L,1048576L,5308416L,26214400L,126877696L,603979776L,2835349504L,13153337344L,60397977600L,274877906944L,1241245548544L,5566277615616L,24807731101696L,109951162777600L };
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
public class A086952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086952Inst : IEnumerable<long>
{
public static readonly long[] Value=A086952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086952.Bytes);
public long this[int i]=>Value[i];

public static A086952Inst Instance=new A086952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086953
{
public static readonly long[] Value={ 1L,0L,0L,2L,6L,12L,22L,42L,84L,170L,342L,684L,1366L,2730L,5460L,10922L,21846L,43692L,87382L,174762L,349524L,699050L,1398102L,2796204L,5592406L,11184810L,22369620L,44739242L,89478486L,178956972L,357913942L,715827882L,1431655764L,2863311530L,5726623062L };
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
public class A086953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086953Inst : IEnumerable<long>
{
public static readonly long[] Value=A086953.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086953.Bytes);
public long this[int i]=>Value[i];

public static A086953Inst Instance=new A086953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086954
{
public static readonly long[] Value={ 1L,1L,4L,14L,38L,92L,214L,490L,1108L,2474L,5462L,11948L,25942L,55978L,120148L,256682L,546134L,1157804L,2446678L,5155498L,10835284L,22719146L,47535446L,99265196L,206918998L,430615210L,894784852L,1856678570L,3847574870L,7963585196L };
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
public class A086954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086954Inst : IEnumerable<long>
{
public static readonly long[] Value=A086954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086954.Bytes);
public long this[int i]=>Value[i];

public static A086954Inst Instance=new A086954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086955
{
public static readonly long[] Value={ 1L,6L,9L,18L,25L,38L,49L,66L,81L,102L,121L,146L,169L,198L,225L,258L,289L,326L,361L,402L,441L,486L,529L,578L,625L,678L,729L,786L,841L,902L,961L,1026L,1089L,1158L,1225L,1298L,1369L,1446L,1521L,1602L,1681L,1766L,1849L,1938L,2025L,2118L,2209L,2306L,2401L,2502L };
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
public class A086955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086955Inst : IEnumerable<long>
{
public static readonly long[] Value=A086955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086955.Bytes);
public long this[int i]=>Value[i];

public static A086955Inst Instance=new A086955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086956
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,7L,2L,3L,5L,11L,3L,13L,7L,3L,4L,17L,6L,19L,4L,7L,11L,23L,4L,5L,13L,9L,14L,29L,6L,31L,8L,11L,17L,35L,6L,37L,19L,13L,8L,41L,14L,43L,22L,9L,23L,47L,8L,49L,10L,17L,26L,53L,9L,55L,14L,19L,29L,59L,10L,61L,31L,21L,16L,65L,22L,67L,34L,23L,10L,71L,12L,73L,37L,15L,38L };
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
public class A086956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086956Inst : IEnumerable<long>
{
public static readonly long[] Value=A086956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086956.Bytes);
public long this[int i]=>Value[i];

public static A086956Inst Instance=new A086956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086957
{
public static readonly long[] Value={ 1L,4L,9L,16L,5L,18L,7L,32L,27L,50L,11L,72L,13L,28L,75L,64L,17L,108L,19L,100L,63L,44L,23L,192L,125L,52L,81L,196L,29L,180L,31L,128L,99L,68L,35L,288L,37L,76L,117L,200L,41L,294L,43L,176L,225L,92L,47L,384L,49L,250L,153L,208L,53L,486L,55L,392L,171L,116L,59L,420L,61L };
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
public class A086957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086957Inst : IEnumerable<long>
{
public static readonly long[] Value=A086957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086957.Bytes);
public long this[int i]=>Value[i];

public static A086957Inst Instance=new A086957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086958
{
public static readonly long[] Value={ 2L,6L,12L,20L,10L,30L,14L,40L,45L,60L,22L,84L,26L,42L,90L,80L,34L,126L,38L,120L,147L,66L,46L,216L,150L,78L,135L,224L,58L,210L,62L,160L,132L,102L,245L,324L,74L,114L,156L,320L,82L,336L,86L,220L,315L,138L,94L,432L,98L,300L,204L,260L,106L,540L,110L,448L,228L,174L };
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
public class A086958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086958Inst : IEnumerable<long>
{
public static readonly long[] Value=A086958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086958.Bytes);
public long this[int i]=>Value[i];

public static A086958Inst Instance=new A086958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086959
{
public static readonly long[] Value={ 3L,8L,15L,24L,25L,36L,21L,48L,54L,70L,33L,96L,39L,56L,105L,112L,51L,144L,57L,140L,168L,88L,69L,240L,175L,104L,162L,252L,87L,270L,93L,256L,165L,136L,280L,360L,111L,152L,195L,400L,123L,378L,129L,264L,405L,184L,141L,480L,343L,350L,255L,312L,159L,594L,275L,504L };
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
public class A086959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086959Inst : IEnumerable<long>
{
public static readonly long[] Value=A086959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086959.Bytes);
public long this[int i]=>Value[i];

public static A086959Inst Instance=new A086959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086960
{
public static readonly long[] Value={ 2L,3L,1L,6L,10L,8L,14L,4L,12L,25L,22L,15L,26L,21L,9L,20L,34L,30L,38L,24L,7L,33L,46L,16L,5L,39L,45L,42L,58L,36L,62L,40L,11L,51L,245L,18L,74L,57L,13L,48L,82L,56L,86L,66L,54L,69L,94L,32L,98L,60L,17L,78L,106L,27L,110L,28L,19L,87L,118L,70L,122L,93L,147L,80L,130L,88L,134L };
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
public class A086960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086960Inst : IEnumerable<long>
{
public static readonly long[] Value=A086960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086960.Bytes);
public long this[int i]=>Value[i];

public static A086960Inst Instance=new A086960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086961
{
public static readonly long[] Value={ 3L,1L,2L,8L,25L,4L,21L,6L,15L,5L,33L,9L,39L,7L,12L,24L,51L,36L,57L,16L,14L,11L,69L,20L,10L,13L,54L,56L,87L,18L,93L,48L,22L,17L,280L,30L,111L,19L,26L,32L,123L,28L,129L,88L,27L,23L,141L,40L,343L,70L,34L,104L,159L,45L,275L,42L,38L,29L,177L,50L,183L,31L,168L,112L,325L };
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
public class A086961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086961Inst : IEnumerable<long>
{
public static readonly long[] Value=A086961.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086961.Bytes);
public long this[int i]=>Value[i];

public static A086961Inst Instance=new A086961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086962
{
public static readonly long[] Value={ 1L,3L,2L,4L,5L,8L,7L,6L,9L,25L,11L,15L,13L,21L,12L,16L,17L,18L,19L,24L,14L,33L,23L,20L,10L,39L,27L,28L,29L,36L,31L,32L,22L,51L,35L,30L,37L,57L,26L,48L,41L,56L,43L,44L,54L,69L,47L,40L,49L,50L,34L,52L,53L,45L,55L,42L,38L,87L,59L,70L,61L,93L,63L,64L,65L,88L,67L,68L,46L };
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
public class A086962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086962Inst : IEnumerable<long>
{
public static readonly long[] Value=A086962.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086962.Bytes);
public long this[int i]=>Value[i];

public static A086962Inst Instance=new A086962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086963
{
public static readonly long[] Value={ 3L,2L,1L,8L,25L,6L,21L,4L,15L,10L,33L,12L,39L,14L,9L,24L,51L,36L,57L,20L,7L,22L,69L,16L,5L,26L,54L,56L,87L,30L,93L,48L,11L,34L,280L,18L,111L,38L,13L,40L,123L,42L,129L,88L,45L,46L,141L,32L,343L,70L,17L,104L,159L,27L,275L,28L,19L,58L,177L,60L,183L,62L,168L,112L,325L };
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
public class A086963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086963Inst : IEnumerable<long>
{
public static readonly long[] Value=A086963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A086963.Bytes);
public long this[int i]=>Value[i];

public static A086963Inst Instance=new A086963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087044
{
public static readonly long[] Value={ 9L,8L,6L,2L,4L,9L,0L,1L,5L,0L,4L,4L,8L,5L,9L,3L,3L,6L,3L,7L,0L,0L,3L,4L,7L,4L,3L,0L,0L,5L,8L,8L,2L,7L,8L,2L,3L,1L,1L,3L,2L,5L,3L,4L,2L,6L,0L,8L,6L,4L,6L,3L,3L,0L,1L,5L,5L,9L,5L,1L,4L,9L,4L,2L,1L,5L,8L,8L,4L,1L,2L,6L,7L,7L,7L,6L,1L,5L,0L,8L,1L,0L,5L,1L,5L,3L,9L,1L,6L,4L,8L,3L,8L,1L,1L,0L,0L,7L,5L,0L };
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
public class A087044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087044Inst : IEnumerable<long>
{
public static readonly long[] Value=A087044.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087044.Bytes);
public long this[int i]=>Value[i];

public static A087044Inst Instance=new A087044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087045
{
public static readonly long[] Value={ 1L,4L,64L,400L,489L,519L,2164L,3589L,8703L,84761L,358837L,1463825L,1668392L };
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
public class A087045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087045Inst : IEnumerable<long>
{
public static readonly long[] Value=A087045.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087045.Bytes);
public long this[int i]=>Value[i];

public static A087045Inst Instance=new A087045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087046
{
public static readonly BigInteger[] Value={ 1L,2L,12L,240L,65280L,4294901760L,18446744069414584320UL,BigInteger.Parse("340282366920938463444927863358058659840"),BigInteger.Parse("115792089237316195423570985008687907852929702298719625575994209400481361428480") };
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
public class A087046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087046.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087046Inst Instance=new A087046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087047
{
public static readonly BigInteger[] Value={ 1L,4L,40L,800L,28000L,1568000L,131712000L,15805440000L,2607897600000L,573737472000000L,164088916992000000L,BigInteger.Parse("59728365785088000000"),BigInteger.Parse("27176406432215040000000"),BigInteger.Parse("15218787602040422400000000") };
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
public class A087047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087047Inst Instance=new A087047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087048
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,4L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,4L,1L,1L,2L,4L,2L,1L,2L,1L,1L,2L,4L,2L,1L,2L,2L,2L,2L,4L,1L,4L,2L,4L,3L,1L,2L,2L,4L,1L,4L,2L,1L,4L,4L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,4L,1L,1L,2L,2L,4L,4L,2L,2L,1L,2L,2L,2L,4L,4L,4L,2L,3L,2L,1L,2L,2L,4L };
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
public class A087048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087048Inst : IEnumerable<long>
{
public static readonly long[] Value=A087048.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087048.Bytes);
public long this[int i]=>Value[i];

public static A087048Inst Instance=new A087048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087049
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L };
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
public class A087049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087049Inst : IEnumerable<long>
{
public static readonly long[] Value=A087049.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087049.Bytes);
public long this[int i]=>Value[i];

public static A087049Inst Instance=new A087049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087050
{
public static readonly long[] Value={ 2L,2L,3L,2L,4L,3L,2L,2L,5L,3L,2L,4L,6L,2L,2L,3L,4L,7L,5L,2L,3L,2L,2L,3L,8L,2L,6L,5L,2L,4L,9L,2L,2L,3L,2L,4L,7L,3L,10L,2L,6L,4L,2L,3L,2L,11L,2L,5L,3L,8L,2L,3L,2L,2L,12L,7L,2L,5L,2L,3L,2L,4L,9L,2L,2L,13L,3L,2L,5L,4L,6L,2L,2L,3L,8L,14L,3L,10L,2L,3L,4L,2L,6L,2L,4L,15L,2L,2L,3L,2L,4L,11L,9L,2L,7L,2L,5L,6L,16L,2L,3L };
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
public class A087050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087050Inst : IEnumerable<long>
{
public static readonly long[] Value=A087050.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087050.Bytes);
public long this[int i]=>Value[i];

public static A087050Inst Instance=new A087050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087051
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10000L,11111L,11112L,11113L,11114L,11115L,11116L,11117L,11118L,11119L,20000L,21111L,22222L,22223L,22224L,22225L,22226L,22227L,22228L,22229L,30000L,31111L,32222L,33333L,33334L,33335L,33336L,33337L,33338L,33339L,40000L,41111L,42222L };
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
public class A087051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087051Inst : IEnumerable<long>
{
public static readonly long[] Value=A087051.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087051.Bytes);
public long this[int i]=>Value[i];

public static A087051Inst Instance=new A087051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087052
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,29L,29L,29L,29L,29L,29L,29L,29L,29L,29L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,59L,59L,59L,59L,59L,59L,59L,59L,59L,59L,69L,69L,69L,69L,69L,69L,69L,69L,69L,69L,79L,79L,79L,79L,79L,79L,79L,79L,79L,79L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L };
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
public class A087052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087052Inst : IEnumerable<long>
{
public static readonly long[] Value=A087052.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087052.Bytes);
public long this[int i]=>Value[i];

public static A087052Inst Instance=new A087052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087053
{
public static readonly long[] Value={ 31L,41L,61L,59L,71L,91L,71L,87L,101L,101L,121L,113L,103L,129L,151L,131L,161L,143L,119L,191L,171L,131L,167L,211L,151L,221L,185L,151L,241L,167L,191L,213L,227L,271L,221L,199L,301L,191L,311L,269L,243L,167L,211L,341L,275L,297L,269L,361L,215L,311L,293L,247L,371L };
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
public class A087053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087053Inst : IEnumerable<long>
{
public static readonly long[] Value=A087053.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087053.Bytes);
public long this[int i]=>Value[i];

public static A087053Inst Instance=new A087053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087054
{
public static readonly long[] Value={ 31L,41L,59L,61L,71L,101L,103L,113L,131L,151L,167L,191L,199L,211L,227L,239L,241L,251L,263L,269L,271L,281L,293L,311L,331L,347L,359L,383L,401L,419L,421L,431L,439L,461L,467L,479L,487L,491L,503L,521L,541L,563L,571L,587L,599L,607L,617L,631L,641L,647L,653L,661L,691L };
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
public class A087054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087054Inst : IEnumerable<long>
{
public static readonly long[] Value=A087054.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087054.Bytes);
public long this[int i]=>Value[i];

public static A087054Inst Instance=new A087054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087055
{
public static readonly long[] Value={ 1L,4L,16L,25L,49L,64L,81L,121L,144L,196L,225L,256L,324L,361L,441L,484L,576L,625L,676L,784L,841L,961L,1024L,1089L,1225L,1296L,1444L,1521L,1681L,1764L,1849L,2025L,2116L,2304L,2401L,2500L,2704L,2809L,3025L,3136L,3249L,3481L,3600L,3844L,3969L,4225L,4356L,4489L };
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
public class A087055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087055Inst : IEnumerable<long>
{
public static readonly long[] Value=A087055.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087055.Bytes);
public long this[int i]=>Value[i];

public static A087055Inst Instance=new A087055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087056
{
public static readonly long[] Value={ 1L,4L,2L,7L,1L,8L,17L,7L,18L,4L,17L,32L,14L,31L,9L,28L,2L,23L,46L,16L,41L,7L,34L,63L,25L,56L,14L,47L,1L,36L,73L,23L,62L,8L,49L,92L,34L,79L,17L,64L,113L,47L,98L,28L,81L,7L,62L,119L,41L,100L,18L,79L,142L,56L,121L,31L,98L,4L,73L,144L,46L,119L,17L,92L,169L,63L,142L,32L,113L,196L,82L };
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
public class A087056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087056Inst : IEnumerable<long>
{
public static readonly long[] Value=A087056.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087056.Bytes);
public long this[int i]=>Value[i];

public static A087056Inst Instance=new A087056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087057
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,10L,12L,13L,15L,16L,17L,19L,20L,22L,23L,25L,26L,27L,29L,30L,32L,33L,34L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,51L,53L,54L,56L,57L,58L,60L,61L,63L,64L,66L,67L,68L,70L,71L,73L,74L,75L,77L,78L,80L,81L,83L,84L,85L,87L,88L,90L,91L,92L,94L,95L,97L,98L,99L,101L };
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
public class A087057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087057Inst : IEnumerable<long>
{
public static readonly long[] Value=A087057.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087057.Bytes);
public long this[int i]=>Value[i];

public static A087057Inst Instance=new A087057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087058
{
public static readonly long[] Value={ 4L,9L,25L,36L,64L,81L,100L,144L,169L,225L,256L,289L,361L,400L,484L,529L,625L,676L,729L,841L,900L,1024L,1089L,1156L,1296L,1369L,1521L,1600L,1764L,1849L,1936L,2116L,2209L,2401L,2500L,2601L,2809L,2916L,3136L,3249L,3364L,3600L,3721L,3969L,4096L,4356L,4489L };
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
public class A087058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087058Inst : IEnumerable<long>
{
public static readonly long[] Value=A087058.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087058.Bytes);
public long this[int i]=>Value[i];

public static A087058Inst Instance=new A087058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087059
{
public static readonly long[] Value={ 2L,1L,7L,4L,14L,9L,2L,16L,7L,25L,14L,1L,23L,8L,34L,17L,47L,28L,7L,41L,18L,56L,31L,4L,46L,17L,63L,32L,82L,49L,14L,68L,31L,89L,50L,9L,71L,28L,94L,49L,2L,72L,23L,97L,46L,124L,71L,16L,98L,41L,127L,68L,7L,97L,34L,128L,63L,161L,94L,25L,127L,56L,162L,89L,14L,124L,47L,161L,82L,1L,119L };
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
public class A087059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087059Inst : IEnumerable<long>
{
public static readonly long[] Value=A087059.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087059.Bytes);
public long this[int i]=>Value[i];

public static A087059Inst Instance=new A087059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087060
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,8L,2L,7L,7L,4L,14L,1L,14L,8L,9L,17L,2L,23L,7L,16L,18L,7L,31L,4L,25L,17L,14L,32L,1L,36L,14L,23L,31L,8L,49L,9L,34L,28L,17L,49L,2L,47L,23L,28L,46L,7L,62L,16L,41L,41L,18L,68L,7L,56L,34L,31L,63L,4L,73L,25L,46L,56L,17L,89L,14L,63L,47L,32L,82L,1L,82L,36L,49L,73L,14L,103L,23L,68L };
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
public class A087060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087060Inst : IEnumerable<long>
{
public static readonly long[] Value=A087060.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087060.Bytes);
public long this[int i]=>Value[i];

public static A087060Inst Instance=new A087060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087061
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,3L,2L,2L,3L,4L,3L,2L,3L,4L,5L,4L,3L,3L,4L,5L,6L,5L,4L,3L,4L,5L,6L,7L,6L,5L,4L,4L,5L,6L,7L,8L,7L,6L,5L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,5L,6L,7L,8L,9L,10L,9L,8L,7L,6L,5L,6L,7L,8L,9L,10L,11L,11L,9L,8L,7L,6L,6L,7L,8L,9L,11L,11L,12L,11L,12L,9L,8L,7L,6L,7L,8L,9L,12L,11L,12L,13L,12L,12L,13L,9L,8L };
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
public class A087061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087061Inst : IEnumerable<long>
{
public static readonly long[] Value=A087061.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087061.Bytes);
public long this[int i]=>Value[i];

public static A087061Inst Instance=new A087061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087062
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,3L,2L,1L,1L,2L,3L,3L,2L,1L,1L,2L,3L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,10L,2L,3L,4L,5L,5L,4L,3L,2L,10L,11L,10L,3L,4L,5L,6L,5L,4L,3L,10L,11L,11L,11L,10L,4L,5L,6L,6L,5L,4L,10L,11L,11L,11L,12L,11L,10L,5L,6L,7L,6L,5L,10L,11L,12L,11L,11L,12L,12L };
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
public class A087062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087062Inst : IEnumerable<long>
{
public static readonly long[] Value=A087062.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087062.Bytes);
public long this[int i]=>Value[i];

public static A087062Inst Instance=new A087062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087063
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,9L,10L,12L,13L,15L,16L,18L,20L,21L,24L,25L,27L,29L,30L,32L,33L,35L,36L,38L,40L,41L,43L,44L,47L,49L,50L,52L,53L,56L,58L,59L,61L,62L,64L,65L,67L,69L,71L,73L,74L,76L,78L,79L,81L,82L,84L,85L,87L,89L,90L,92L,94L,96L,98L,99L,101L,102L,104L,105L,107L,109L,110L,113L };
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
public class A087063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087063Inst : IEnumerable<long>
{
public static readonly long[] Value=A087063.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087063.Bytes);
public long this[int i]=>Value[i];

public static A087063Inst Instance=new A087063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087064
{
public static readonly long[] Value={ 0L,1L,3L,7L,9L,12L,17L,18L,22L,26L,29L,30L,37L,39L,41L,44L,49L,54L,56L,58L,63L,64L,67L,73L,77L,79L,83L,85L,88L,92L,95L,96L,103L,106L,112L,113L,117L,120L,122L,124L,131L,132L,135L,138L,142L,143L,151L,153L,158L,161L,164L,168L,171L,173L,177L,178L,183L,183L,188L,191L,192L };
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
public class A087064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087064Inst : IEnumerable<long>
{
public static readonly long[] Value=A087064.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087064.Bytes);
public long this[int i]=>Value[i];

public static A087064Inst Instance=new A087064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087065
{
public static readonly long[] Value={ 0L,1L,4L,7L,10L,13L,17L,21L,24L,27L,31L,35L,37L,42L,46L,49L,52L,56L,61L,63L,67L,72L,74L,78L,81L,86L,90L,93L,97L,101L,103L,107L,111L,114L,119L,122L,127L,130L,132L,138L,141L,144L,147L,152L,155L,158L,164L,167L,170L,175L,178L,182L,185L,189L,193L,196L,199L,202L,207L,211L };
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
public class A087065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087065Inst : IEnumerable<long>
{
public static readonly long[] Value=A087065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087065.Bytes);
public long this[int i]=>Value[i];

public static A087065Inst Instance=new A087065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087066
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,21L,23L,24L,25L,26L,28L,29L,30L,31L,33L,34L,35L,36L,38L,39L,40L,41L,43L,44L,46L,47L,48L,50L,51L,52L,53L,55L,56L,57L,58L,60L,61L,62L,63L,65L,66L,67L,69L,70L,72L,73L,74L,75L,77L,78L,79L,80L,82L,83L,84L,85L,87L,88L,89L,90L };
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
public class A087066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087066Inst : IEnumerable<long>
{
public static readonly long[] Value=A087066.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087066.Bytes);
public long this[int i]=>Value[i];

public static A087066Inst Instance=new A087066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087067
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,9L,10L,12L,14L,15L,17L,18L,19L,21L,22L,23L,26L,27L,28L,30L,31L,32L,34L,35L,36L,39L,41L,42L,44L,45L,46L,48L,49L,50L,53L,54L,55L,57L,58L,59L,61L,62L,63L,66L,67L,68L,70L,71L,72L,74L,75L,76L,80L,81L,82L,84L,85L,86L,88L,89L,90L,93L,94L,95L,97L,98L,99L,101L,102L };
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
public class A087067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087067Inst : IEnumerable<long>
{
public static readonly long[] Value=A087067.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087067.Bytes);
public long this[int i]=>Value[i];

public static A087067Inst Instance=new A087067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087068
{
public static readonly long[] Value={ 0L,1L,3L,6L,8L,11L,14L,17L,20L,23L,24L,28L,32L,33L,37L,39L,43L,46L,50L,51L,53L,58L,59L,64L,67L,69L,73L,77L,78L,80L,83L,87L,90L,92L,95L,99L,103L,104L,108L,112L,113L,118L,120L,122L,125L,128L,132L,134L,138L,139L,142L,146L,150L,152L,157L,158L,161L,165L,168L,171L,173L,178L };
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
public class A087068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087068Inst : IEnumerable<long>
{
public static readonly long[] Value=A087068.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087068.Bytes);
public long this[int i]=>Value[i];

public static A087068Inst Instance=new A087068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087069
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,18L,21L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,34L,36L,37L,38L,39L,42L,43L,44L,45L,47L,48L,49L,50L,52L,53L,54L,55L,57L,58L,59L,60L,63L,64L,65L,66L,68L,69L,70L,71L,73L,74L,75L,76L,78L,79L,80L,81L,85L,86L,87L,88L,90L,91L,92L,93L };
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
public class A087069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087069Inst : IEnumerable<long>
{
public static readonly long[] Value=A087069.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087069.Bytes);
public long this[int i]=>Value[i];

public static A087069Inst Instance=new A087069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087070
{
public static readonly long[] Value={ 0L,1L,4L,7L,11L,14L,18L,21L,26L,29L,34L,37L,41L,45L,48L,53L,57L,61L,65L,69L,73L,74L,79L,84L,89L,91L,95L,100L,102L,107L,112L,116L,121L,122L,128L,131L,136L,137L,144L,146L,152L,155L,158L,164L,166L,171L,174L,178L,184L,185L,190L,195L,198L,201L,207L,211L,214L,220L,222L,226L };
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
public class A087070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087070Inst : IEnumerable<long>
{
public static readonly long[] Value=A087070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087070.Bytes);
public long this[int i]=>Value[i];

public static A087070Inst Instance=new A087070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087071
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,1L,15L,39L };
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
public class A087071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087071Inst : IEnumerable<long>
{
public static readonly long[] Value=A087071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087071.Bytes);
public long this[int i]=>Value[i];

public static A087071Inst Instance=new A087071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087072
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,11L,13L,14L,16L,19L,20L,21L,22L,25L,27L,29L,32L,33L,34L,35L,37L,38L,40L,43L,44L,45L,46L,47L,50L,51L,54L,55L,57L,61L,62L,63L,64L,65L,66L,69L,70L,73L,74L,76L,79L,80L,81L,82L,85L,86L,87L,89L,91L,92L,93L,94L,96L,99L,103L,104L,105L,106L,107L,108L,110L,111L };
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
public class A087072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087072Inst : IEnumerable<long>
{
public static readonly long[] Value=A087072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087072.Bytes);
public long this[int i]=>Value[i];

public static A087072Inst Instance=new A087072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087073
{
public static readonly long[] Value={ 2L,0L,1L,0L,3L,0L,5L,0L,0L,0L,9L,0L,11L,0L,1L,0L,15L,0L,17L,0L,1L,0L,21L,0L,0L,0L,0L,0L,27L,0L,29L,0L,3L,0L,7L,0L,35L,0L,3L,0L,39L,0L,41L,0L,0L,0L,45L,0L,0L,0L,5L,0L,51L,0L,3L,0L,5L,0L,57L,0L,59L,0L,0L,0L,15L,0L,65L,0L,7L,0L,69L,0L,71L,0L,0L,0L,15L,0L,77L,0L,0L,0L,81L,0L,21L,0L,9L,0L,87L,0L,5L,0L,9L,0L,9L };
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
public class A087073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087073Inst : IEnumerable<long>
{
public static readonly long[] Value=A087073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087073.Bytes);
public long this[int i]=>Value[i];

public static A087073Inst Instance=new A087073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087074
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,3L,1L,3L,12L,66L,378L,1890L,7560L,22680L,45360L,45360L,1L,3L,33L,426L,5466L,65520L,720720L,7207200L,64864800L,518918400L,3632428800L,21794572800L,108972864000L,435891456000L,1307674368000L,2615348736000L,2615348736000L,1L };
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
public class A087074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087074Inst : IEnumerable<long>
{
public static readonly long[] Value=A087074.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087074.Bytes);
public long this[int i]=>Value[i];

public static A087074Inst Instance=new A087074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087075
{
public static readonly long[] Value={ 71L,42L,12L,83L,54L,24L,95L,66L,37L,7L,78L,49L,19L,81L,5L,11L,21L,19L,12L,61L,33L,14L,1L,47L,15L,41L,61L,16L,81L,75L,18L,21L,89L,19L,62L,3L,21L,2L,17L,22L,42L,31L,23L,82L,45L,25L,22L,59L,26L,62L,73L,28L,2L,87L,29L,43L,1L,30L,83L,15L,32L,23L,29L,33L,63L,43L,35L,3L,57L,36L,43L,71L };
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
public class A087075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087075Inst : IEnumerable<long>
{
public static readonly long[] Value=A087075.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087075.Bytes);
public long this[int i]=>Value[i];

public static A087075Inst Instance=new A087075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087076
{
public static readonly long[] Value={ 0L,1L,10L,56L,240L,880L,2912L,8960L,26112L,72960L,197120L,518144L,1331200L,3354624L,8314880L,20316160L,49020928L,116981760L,276430848L,647495680L,1504706560L,3471835136L,7958691840L,18136170496L,41104179200L,92694118400L,208071032832L };
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
public class A087076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087076Inst : IEnumerable<long>
{
public static readonly long[] Value=A087076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087076.Bytes);
public long this[int i]=>Value[i];

public static A087076Inst Instance=new A087076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087077
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,21L,29L,73L,105L,193L,288L,677L,853L,1957L,2961L,4913L,6809L,15145L,19605L,43105L,57889L,98849L,151457L,327505L,397825L,784945L,1201189L,2009229L,2772729L,5901185L,7364945L,15609825L,21206049L,36440033L };
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
public class A087077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087077Inst : IEnumerable<long>
{
public static readonly long[] Value=A087077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087077.Bytes);
public long this[int i]=>Value[i];

public static A087077Inst Instance=new A087077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087078
{
public static readonly long[] Value={ 0L,1L,3L,11L,22L,73L,115L,341L,545L,1141L,1864L,4849L,6505L,16285L,26245L,47093L,68981L,163937L,221957L,517937L,726737L,1312865L,2093745L,4753105L,5953777L,12335601L,19516365L,34112821L,48603289L,107522689L,137759953L,302797921L,422868865L };
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
public class A087078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087078Inst : IEnumerable<long>
{
public static readonly long[] Value=A087078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087078.Bytes);
public long this[int i]=>Value[i];

public static A087078Inst Instance=new A087078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087079
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,32L,64L,128L,256L,1L,5L,22L,92L,376L,1520L,6112L,24512L,98176L,392960L,2L,22L,200L,1696L,13952L,113152L,911360L,7315456L,58621952L,469368832L,4L,92L,1696L,28928L,477184L,7749632L,124911616L,2005925888L,32153534464L,514926313472L,8L };
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
public class A087079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087079Inst : IEnumerable<long>
{
public static readonly long[] Value=A087079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087079.Bytes);
public long this[int i]=>Value[i];

public static A087079Inst Instance=new A087079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087080
{
public static readonly long[] Value={ 0L,1L,4L,12L,20L,52L,60L,148L,196L,300L,332L,780L,828L,1904L,2080L,2348L,2812L,6352L,6608L,14736L,15632L,17456L,18640L,41152L,42432L,60912L,64800L,80928L,85408L,186304L,187584L,406400L,457344L,497472L,523456L,585280L,596288L,1284224L };
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
public class A087080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087080Inst : IEnumerable<long>
{
public static readonly long[] Value=A087080.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087080.Bytes);
public long this[int i]=>Value[i];

public static A087080Inst Instance=new A087080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087081
{
public static readonly long[] Value={ 0L,1L,6L,24L,48L,156L,192L,580L,836L,1444L,1660L,4596L,4980L,13184L,14768L,17308L,21756L,55888L,58768L,146416L,157552L,181008L,196304L,481664L,500096L,765648L,825152L,1073920L,1148288L,2745728L,2768768L,6505728L,7453952L,8233792L,8736960L };
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
public class A087081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087081Inst : IEnumerable<long>
{
public static readonly long[] Value=A087081.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087081.Bytes);
public long this[int i]=>Value[i];

public static A087081Inst Instance=new A087081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087082
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,55L,56L,56L,55L,53L,50L,46L,41L,35L,28L,64L,65L,66L,65L,63L,60L,56L,51L,45L,38L,72L,73L,74L,75L,73L,70L,66L,61L,55L,48L,79L,80L,81L,82L,83L,80L,76L,71L,65L,58L,85L,86L,87L,88L,89L,90L,86L,81L,75L,68L,90L,91L,92L,93L,94L,95L,96L,91L,85L,78L };
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
public class A087082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087082Inst : IEnumerable<long>
{
public static readonly long[] Value=A087082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087082.Bytes);
public long this[int i]=>Value[i];

public static A087082Inst Instance=new A087082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087083
{
public static readonly long[] Value={ 45L,44L,42L,39L,35L,30L,24L,17L,9L,495L,4500L,168L,154L,138L,120L,100L,78L,54L,28L,484L,492L,3916L,224L,198L,170L,140L,108L,74L,38L,462L,469L,476L,3276L,258L,220L,180L,138L,94L,48L,429L,435L,441L,447L,2613L,270L,220L,168L,114L,58L,385L,390L,395L };
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
public class A087083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087083Inst : IEnumerable<long>
{
public static readonly long[] Value=A087083.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087083.Bytes);
public long this[int i]=>Value[i];

public static A087083Inst Instance=new A087083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087084
{
public static readonly BigInteger[] Value={ 0L,0L,2L,32L,1536L,1048576L,171798691840L,BigInteger.Parse("1770887431076116955136"),BigInteger.Parse("76223250190290215815795912064716079366144") };
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
public class A087084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087084Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087084.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087084.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087084Inst Instance=new A087084Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087085
{
public static readonly BigInteger[] Value={ 0L,0L,2L,48L,3072L,2621440L,515396075520L,BigInteger.Parse("6198106008766409342976"),BigInteger.Parse("304893000761160863263183648258864317464576") };
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
public class A087085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087085Inst Instance=new A087085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087086
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,12L,16L,18L,20L,22L,24L,28L,32L,40L,48L,56L,64L,66L,68L,70L,72L,76L,80L,82L,84L,86L,88L,92L,96L,104L,112L,120L,128L,132L,144L,148L,160L,176L,192L,196L,208L,212L,224L,240L,256L,258L,264L,272L,274L,280L,288L,296L,304L,312L,320L,322L,328L,336L,338L,344L };
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
public class A087086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087086Inst : IEnumerable<long>
{
public static readonly long[] Value=A087086.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087086.Bytes);
public long this[int i]=>Value[i];

public static A087086Inst Instance=new A087086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087087
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,13L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,28L,29L,32L,33L,48L,49L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,76L,77L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,92L,93L,96L,97L,112L,113L,128L,129L,132L,133L,144L,145L,148L,149L,192L,193L,196L,197L };
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
public class A087087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087087Inst : IEnumerable<long>
{
public static readonly long[] Value=A087087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087087.Bytes);
public long this[int i]=>Value[i];

public static A087087Inst Instance=new A087087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087088
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,2L,1L,5L,3L,1L,2L,6L,1L,4L,2L,1L,3L,7L,1L,2L,5L,1L,3L,2L,1L,4L,8L,1L,2L,3L,1L,6L,2L,1L,4L,3L,1L,2L,5L,1L,9L,2L,1L,3L,4L,1L,2L,7L,1L,3L,2L,1L,5L,4L,1L,2L,3L,1L,6L,2L,1L,10L,3L,1L,2L,4L,1L,5L,2L,1L,3L,8L,1L,2L,4L,1L,3L,2L,1L,6L,5L,1L,2L,3L,1L,4L,2L,1L,7L,3L,1L,2L,11L,1L,4L,2L,1L,3L,5L,1L,2L,6L,1L,3L,2L };
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
public class A087088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087088Inst : IEnumerable<long>
{
public static readonly long[] Value=A087088.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087088.Bytes);
public long this[int i]=>Value[i];

public static A087088Inst Instance=new A087088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087089
{
public static readonly long[] Value={ 1L,2L,4L,8L,3L,6L,16L,6L,5L,12L,10L,12L,32L,12L,10L,4L,5L,7L,24L,24L,20L,20L,8L,8L,7L,24L,10L,14L,9L,64L,24L,10L,16L,14L,20L,8L,18L,14L,9L,48L,48L,14L,20L,40L,6L,48L,16L,9L,40L,40L,7L,18L,48L,16L,20L,16L,28L,18L,9L,28L };
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
public class A087089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087089Inst : IEnumerable<long>
{
public static readonly long[] Value=A087089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087089.Bytes);
public long this[int i]=>Value[i];

public static A087089Inst Instance=new A087089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087090
{
public static readonly long[] Value={ 0L,5L,12L,15L,17L,20L,24L,35L,45L,50L,59L,75L,90L,92L,105L,110L,119L,120L,132L,134L,167L,174L,182L,222L,225L,230L,264L,269L,285L,320L,335L,339L,362L,365L,372L,390L,419L,434L,437L,455L,462L,470L,479L,495L,539L,540L,549L,572L,594L,705L,710L,714L,759L,785L,789L };
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
public class A087090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087090Inst : IEnumerable<long>
{
public static readonly long[] Value=A087090.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087090.Bytes);
public long this[int i]=>Value[i];

public static A087090Inst Instance=new A087090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087091
{
public static readonly long[] Value={ 1L,4L,10L,16L,19L,31L,34L,43L,55L,58L,61L,70L,73L,79L,85L,94L,100L,118L,148L,154L,160L,175L,196L,199L,211L,214L,223L,226L,229L,238L,253L,274L,313L,340L,424L,430L,469L,499L,508L,529L,538L,541L,550L,565L,640L,658L,673L,706L,724L,760L,763L,781L };
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
public class A087091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087091Inst : IEnumerable<long>
{
public static readonly long[] Value=A087091.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087091.Bytes);
public long this[int i]=>Value[i];

public static A087091Inst Instance=new A087091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087108
{
public static readonly long[] Value={ 1L,1L,4L,6L,4L,1L,1L,24L,176L,624L,1251L,1500L,1070L,420L,70L,1L,124L,3126L,33124L,191251L,681000L,1596120L,2543520L,2780820L,2058000L,987000L,277200L,34650L,1L,624L,49376L,1350624L,18308751L,146500500L,763418870L,2749648020L,7101675070L,13440210000L };
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
public class A087108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087108Inst : IEnumerable<long>
{
public static readonly long[] Value=A087108.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087108.Bytes);
public long this[int i]=>Value[i];

public static A087108Inst Instance=new A087108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087109
{
public static readonly long[] Value={ 1L,1L,5L,10L,10L,5L,1L,1L,35L,370L,1920L,5835L,11253L,14240L,11830L,6230L,1890L,252L,1L,215L,8830L,148480L,1352615L,7665757L,29224020L,78518790L,152794740L,218270220L,229279512L,175227360L,94864770L,34504470L,7567560L,756756L,1L,1295L,191890L };
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
public class A087109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087109Inst : IEnumerable<long>
{
public static readonly long[] Value=A087109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087109.Bytes);
public long this[int i]=>Value[i];

public static A087109Inst Instance=new A087109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087110
{
public static readonly long[] Value={ 1L,1L,6L,15L,20L,15L,6L,1L,1L,48L,687L,4850L,20385L,55908L,104959L,137886L,127050L,80640L,33642L,8316L,924L,1L,342L,21267L,527876L,7020525L,58015362L,324610399L,1297791264L,3839203452L,8595153000L,14760228672L,19560928464L,19987430694L };
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
public class A087110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087110Inst : IEnumerable<long>
{
public static readonly long[] Value=A087110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087110.Bytes);
public long this[int i]=>Value[i];

public static A087110Inst Instance=new A087110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087111
{
public static readonly long[] Value={ 1L,1L,7L,21L,35L,35L,21L,7L,1L,1L,63L,1169L,10703L,58821L,214123L,545629L,1004307L,1356194L,1347318L,974862L,500346L,172788L,36036L,3432L,1L,511L,45633L,1589567L,29302889L,333924087L,2577462937L,14287393351L,59159005164L,188008120188L };
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
public class A087111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087111Inst : IEnumerable<long>
{
public static readonly long[] Value=A087111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087111.Bytes);
public long this[int i]=>Value[i];

public static A087111Inst Instance=new A087111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087112
{
public static readonly long[] Value={ 4L,6L,9L,10L,15L,25L,14L,21L,35L,49L,22L,33L,55L,77L,121L,26L,39L,65L,91L,143L,169L,34L,51L,85L,119L,187L,221L,289L,38L,57L,95L,133L,209L,247L,323L,361L,46L,69L,115L,161L,253L,299L,391L,437L,529L,58L,87L,145L,203L,319L,377L,493L,551L,667L,841L,62L,93L,155L,217L,341L };
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
public class A087112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087112Inst : IEnumerable<long>
{
public static readonly long[] Value=A087112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087112.Bytes);
public long this[int i]=>Value[i];

public static A087112Inst Instance=new A087112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087113
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L };
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
public class A087113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087113Inst : IEnumerable<long>
{
public static readonly long[] Value=A087113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087113.Bytes);
public long this[int i]=>Value[i];

public static A087113Inst Instance=new A087113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087114
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,1L,6L,1L };
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
public class A087114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087114Inst : IEnumerable<long>
{
public static readonly long[] Value=A087114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087114.Bytes);
public long this[int i]=>Value[i];

public static A087114Inst Instance=new A087114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087115
{
public static readonly long[] Value={ 0L,1L,18L,137L,650L,2350L,6860L,17609L,39870L,83976L,162382L,301070L,522886L,885284L,1424468L,2254537L,3419448L,5143987L,7448874L,10750712L,15015872L,20948610L,28373444L,38539022L,50863150L,67454492L,87209316L,113326308L,143748766L,183759900L,229271536L };
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
public class A087115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087115Inst : IEnumerable<long>
{
public static readonly long[] Value=A087115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087115.Bytes);
public long this[int i]=>Value[i];

public static A087115Inst Instance=new A087115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087116
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,1L,0L,1L,1L,2L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,0L,1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,2L,1L,1L,1L,2L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,0L,1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,2L,1L,2L,2L,3L,2L,3L,3L,3L,2L,2L,2L,3L,2L,2L,2L,2L,1L,1L,1L,2L,1L,2L,2L };
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
public class A087116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087116Inst : IEnumerable<long>
{
public static readonly long[] Value=A087116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087116.Bytes);
public long this[int i]=>Value[i];

public static A087116Inst Instance=new A087116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087117
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,1L,0L,3L,2L,1L,1L,2L,1L,1L,0L,4L,3L,2L,2L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,0L,5L,4L,3L,3L,2L,2L,2L,2L,3L,2L,1L,1L,2L,1L,1L,1L,4L,3L,2L,2L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,0L,6L,5L,4L,4L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,4L,3L,2L,2L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,5L,4L,3L,3L,2L,2L };
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
public class A087117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087117Inst : IEnumerable<long>
{
public static readonly long[] Value=A087117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087117.Bytes);
public long this[int i]=>Value[i];

public static A087117Inst Instance=new A087117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087118
{
public static readonly long[] Value={ 0L,2L,4L,5L,6L,8L,9L,11L,12L,13L,14L,16L,17L,19L,23L,24L,25L,27L,28L,29L,30L,32L,33L,35L,39L,47L,48L,49L,51L,55L,56L,57L,59L,60L,61L,62L,64L,65L,67L,71L,79L,95L,96L,97L,99L,103L,111L,112L,113L,115L,119L,120L,121L,123L,124L,125L,126L,128L,129L,131L,135L,143L,159L,191L };
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
public class A087118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087118Inst : IEnumerable<long>
{
public static readonly long[] Value=A087118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087118.Bytes);
public long this[int i]=>Value[i];

public static A087118Inst Instance=new A087118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087119
{
public static readonly long[] Value={ 10L,18L,20L,21L,22L,26L,34L,36L,37L,38L,40L,41L,42L,43L,44L,45L,46L,50L,52L,53L,54L,58L,66L,68L,69L,70L,72L,73L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,98L,100L,101L,102L,104L,105L,106L,107L,108L,109L,110L,114L,116L,117L,118L,122L };
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
public class A087119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087119Inst : IEnumerable<long>
{
public static readonly long[] Value=A087119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087119.Bytes);
public long this[int i]=>Value[i];

public static A087119Inst Instance=new A087119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087120
{
public static readonly long[] Value={ 1L,0L,10L,42L,170L,682L,2730L,10922L,43690L,174762L,699050L,2796202L,11184810L,44739242L,178956970L,715827882L,2863311530L,11453246122L,45812984490L,183251937962L,733007751850L,2932031007402L,11728124029610L,46912496118442L };
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
public class A087120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087120Inst : IEnumerable<long>
{
public static readonly long[] Value=A087120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087120.Bytes);
public long this[int i]=>Value[i];

public static A087120Inst Instance=new A087120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087121
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,29L,29L,29L,29L,29L,29L,29L,29L,29L,29L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,59L,59L,59L,59L,59L,59L,59L,59L,59L,59L,69L,69L,69L,69L,69L,69L,69L,69L,69L,69L,79L,79L,79L,79L,79L,79L,79L,79L,79L,79L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,199L,109L,109L,109L,109L,109L,109L,109L,109L,109L,199L,199L };
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
public class A087121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087121Inst : IEnumerable<long>
{
public static readonly long[] Value=A087121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087121.Bytes);
public long this[int i]=>Value[i];

public static A087121Inst Instance=new A087121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087122
{
public static readonly long[] Value={ 1L,3L,5L,12L,9L,15L,13L,32L,45L,27L,21L,60L,25L,39L,45L,128L,33L,135L,37L,108L,65L,63L,45L,160L,225L,75L,189L,156L,57L,135L,61L,320L,105L,99L,117L,540L,73L,111L,125L,288L,81L,195L,85L,252L,405L,135L,93L,640L,637L,675L,165L,300L,105L,567L,189L,416L,185L,171L,117L,540L,121L,183L,585L,1280L,225L,315L,133L,396L,225L,351L };
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
public class A087122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087122Inst : IEnumerable<long>
{
public static readonly long[] Value=A087122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087122.Bytes);
public long this[int i]=>Value[i];

public static A087122Inst Instance=new A087122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087123
{
public static readonly long[] Value={ 1L,2L,1L,5L,2L,13L,5L,34L,13L,89L,34L,233L,89L,610L,233L,1597L,610L,4181L,1597L,10946L,4181L,28657L,10946L,75025L,28657L,196418L,75025L,514229L,196418L,1346269L,514229L,3524578L,1346269L,9227465L,3524578L,24157817L,9227465L,63245986L,24157817L };
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
public class A087123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087123Inst : IEnumerable<long>
{
public static readonly long[] Value=A087123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087123.Bytes);
public long this[int i]=>Value[i];

public static A087123Inst Instance=new A087123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087140
{
public static readonly long[] Value={ 10L,13L,14L,16L,17L,18L,19L,20L,21L,23L,25L,26L,27L,28L,29L,30L,31L,32L,34L,35L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,49L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,89L,90L,91L };
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
public class A087140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087140Inst : IEnumerable<long>
{
public static readonly long[] Value=A087140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087140.Bytes);
public long this[int i]=>Value[i];

public static A087140Inst Instance=new A087140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087141
{
public static readonly long[] Value={ 10L,18L,20L,21L,27L,30L,40L,42L,45L,50L,54L,60L,63L,70L,72L,80L,81L,84L,90L,100L,102L,108L,110L,114L,117L,120L,133L,140L,150L,152L,153L,156L,171L,180L,190L,192L,195L,198L,200L,201L,204L,207L,209L,210L,220L,225L,228L,230L,234L,240L,243L,247L,252L,261L,266L,270L };
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
public class A087141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087141Inst : IEnumerable<long>
{
public static readonly long[] Value=A087141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087141.Bytes);
public long this[int i]=>Value[i];

public static A087141Inst Instance=new A087141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087142
{
public static readonly long[] Value={ 11L,15L,22L,33L,44L,55L,66L,77L,88L,99L,115L,122L,124L,128L,155L,168L,175L,184L,212L,244L,248L,366L,384L,412L,424L,488L,515L,636L,672L,728L,784L,816L,824L,848L,1111L,1112L,1113L,1115L,1124L,1131L,1144L,1155L,1176L,1184L,1197L,1222L,1244L,1248L };
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
public class A087142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087142Inst : IEnumerable<long>
{
public static readonly long[] Value=A087142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087142.Bytes);
public long this[int i]=>Value[i];

public static A087142Inst Instance=new A087142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087143
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,48L,50L,51L,52L,53L,54L,55L,57L,60L,61L,62L,63L,64L,66L,70L,71L,72L,73L,75L,80L,81L,82L,84L,90L };
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
public class A087143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087143Inst : IEnumerable<long>
{
public static readonly long[] Value=A087143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087143.Bytes);
public long this[int i]=>Value[i];

public static A087143Inst Instance=new A087143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087144
{
public static readonly long[] Value={ 29L,38L,47L,49L,56L,58L,59L,65L,67L,68L,69L,74L,76L,77L,78L,79L,83L,85L,86L,87L,88L,89L,92L,94L,95L,96L,97L,98L,119L,128L,137L,139L,146L,148L,149L,155L,157L,158L,159L,164L,166L,167L,168L,169L,173L,175L,176L,177L,178L,179L,182L,184L,185L,186L,187L,188L,191L,193L };
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
public class A087144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087144Inst : IEnumerable<long>
{
public static readonly long[] Value=A087144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087144.Bytes);
public long this[int i]=>Value[i];

public static A087144Inst Instance=new A087144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087145
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,4L,2L,4L,1L };
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
public class A087145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087145Inst : IEnumerable<long>
{
public static readonly long[] Value=A087145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087145.Bytes);
public long this[int i]=>Value[i];

public static A087145Inst Instance=new A087145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087146
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,13L,14L,17L,27L,28L,33L,39L,103L,115L,205L,291L,1431L,1532L,1710L,1937L,3901L,3981L,4682L,6569L,20266L,20662L };
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
public class A087146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087146Inst : IEnumerable<long>
{
public static readonly long[] Value=A087146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087146.Bytes);
public long this[int i]=>Value[i];

public static A087146Inst Instance=new A087146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087147
{
public static readonly long[] Value={ 0L,3L,7L,9L,67L,291L,1343L,6984L,12861L };
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
public class A087147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087147Inst : IEnumerable<long>
{
public static readonly long[] Value=A087147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087147.Bytes);
public long this[int i]=>Value[i];

public static A087147Inst Instance=new A087147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087148
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,13L,14L,16L,18L,21L,22L,28L,37L,43L,45L,48L,51L,58L,59L,69L,76L,81L,91L,94L,109L,115L,142L,143L,170L,184L,208L,209L,241L,250L,258L,265L,282L,295L,306L,319L,356L,361L,398L,405L,430L,441L,466L,481L,483L,505L,532L,535L,570L,594L,616L,629L,633L,638L };
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
public class A087148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087148Inst : IEnumerable<long>
{
public static readonly long[] Value=A087148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087148.Bytes);
public long this[int i]=>Value[i];

public static A087148Inst Instance=new A087148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087149
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,19L,28L,39L,52L,67L,83L,101L,122L,147L,176L,210L,250L,295L,343L,395L,452L,515L,584L,661L,749L,845L,951L,1065L,1193L,1334L,1492L,1667L,1861L,2075L,2308L,2560L,2833L,3132L,3453L,3800L,4172L,4579L,5011L,5477L,5975L,6513L,7080L,7683L,8325L,9008L };
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
public class A087149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087149Inst : IEnumerable<long>
{
public static readonly long[] Value=A087149.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087149.Bytes);
public long this[int i]=>Value[i];

public static A087149Inst Instance=new A087149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087150
{
public static readonly long[] Value={ 1L,2L,6L,20L,40L,42L,54L,90L,168L,236L,406L,712L,1094L,1602L,2240L,2970L,3690L,4874L,5008L,5710L,8338L,9714L,10496L,11314L,12812L,19924L,27678L,37748L,49142L,55996L,71438L,92420L,104866L,110158L,128642L,143030L,151098L,158264L,208234L,213902L };
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
public class A087150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087150Inst : IEnumerable<long>
{
public static readonly long[] Value=A087150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087150.Bytes);
public long this[int i]=>Value[i];

public static A087150Inst Instance=new A087150Inst();

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