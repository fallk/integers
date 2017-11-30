using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A013922
{
public static readonly BigInteger[] Value={ 0L,1L,1L,10L,238L,11368L,1014888L,166537616L,50680432112L,29107809374336L,32093527159296128L,BigInteger.Parse("68846607723033232640"),BigInteger.Parse("290126947098532533378816"),BigInteger.Parse("2417684612523425600721132544"),BigInteger.Parse("40013522702538780900803893881856") };
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
public class A013922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013922.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013922Inst Instance=new A013922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013921
{
public static readonly long[] Value={ 4L,10L,18L,27L,49L,63L,78L,94L,112L,132L,153L,175L,224L,250L,305L,335L,400L,434L,469L,505L,543L,582L,622L,664L,708L,753L,799L,847L,896L,946L,1158L,1214L,1271L,1329L,1389L,1514L,1578L,1643L,1846L,1916L,1988L,2062L,2290L,2368L,2448L,2529L,2611L,2695L,2780L,2866L };
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
public class A013921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013921Inst : IEnumerable<long>
{
public static readonly long[] Value=A013921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013921.Bytes);
public long this[int i]=>Value[i];

public static A013921Inst Instance=new A013921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013920
{
public static readonly long[] Value={ 4L,6L,8L,9L,12L,14L,15L,16L,18L,20L,21L,22L,25L,26L,28L,30L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,49L,50L,55L,56L,57L,58L,60L,63L,64L,65L,69L,70L,72L,74L,77L,78L,80L,81L,82L,84L,85L,86L,90L,91L,92L,94L,95L,96L,98L,104L,105L,106L,108L,110L,111L,112L,114L,115L,116L,118L,119L };
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
public class A013920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013920Inst : IEnumerable<long>
{
public static readonly long[] Value=A013920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013920.Bytes);
public long this[int i]=>Value[i];

public static A013920Inst Instance=new A013920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013919
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,38L,39L,40L,41L,42L,44L,45L,46L,49L,50L,51L,52L,55L,56L,57L,58L,59L,60L,61L,62L,65L,66L,67L,69L,70L,71L,72L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,87L,88L,89L,90L,91L,92L,93L };
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
public class A013919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013919Inst : IEnumerable<long>
{
public static readonly long[] Value=A013919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013919.Bytes);
public long this[int i]=>Value[i];

public static A013919Inst Instance=new A013919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013918
{
public static readonly long[] Value={ 2L,5L,17L,41L,197L,281L,7699L,8893L,22039L,24133L,25237L,28697L,32353L,37561L,38921L,43201L,44683L,55837L,61027L,66463L,70241L,86453L,102001L,109147L,116533L,119069L,121631L,129419L,132059L,263171L,287137L,325019L,329401L,333821L,338279L,342761L };
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
public class A013918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013918Inst : IEnumerable<long>
{
public static readonly long[] Value=A013918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013918.Bytes);
public long this[int i]=>Value[i];

public static A013918Inst Instance=new A013918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013917
{
public static readonly long[] Value={ 2L,3L,7L,13L,37L,43L,281L,311L,503L,541L,557L,593L,619L,673L,683L,733L,743L,839L,881L,929L,953L,1061L,1163L,1213L,1249L,1277L,1283L,1307L,1321L,1949L,2029L,2161L,2203L,2213L,2237L,2243L,2297L,2357L,2393L,2411L,2957L,3137L,3251L,3257L,3301L,3413L,3461L,3491L };
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
public class A013917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013917Inst : IEnumerable<long>
{
public static readonly long[] Value=A013917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013917.Bytes);
public long this[int i]=>Value[i];

public static A013917Inst Instance=new A013917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013916
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,14L,60L,64L,96L,100L,102L,108L,114L,122L,124L,130L,132L,146L,152L,158L,162L,178L,192L,198L,204L,206L,208L,214L,216L,296L,308L,326L,328L,330L,332L,334L,342L,350L,356L,358L,426L,446L,458L,460L,464L,480L,484L,488L,512L,530L,536L,548L,568L,620L,630L,676L,680L };
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
public class A013916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013916Inst : IEnumerable<long>
{
public static readonly long[] Value=A013916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013916.Bytes);
public long this[int i]=>Value[i];

public static A013916Inst Instance=new A013916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013915
{
public static readonly long[] Value={ 3L,3L,7L,10L,16L,24L,37L,57L,89L,140L,222L,354L,567L,911L,1467L,2366L,3820L,6172L,9977L,16133L,26093L,42208L,68282L,110470L,178731L,289179L,467887L,757042L,1224904L,1981920L,3206797L,5188689L,8395457L,13584116L,21979542L,35563626L,57543135L };
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
public class A013915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013915Inst : IEnumerable<long>
{
public static readonly long[] Value=A013915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013915.Bytes);
public long this[int i]=>Value[i];

public static A013915Inst Instance=new A013915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013914
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,8L,12L,16L,33L,62L,67L,186L,316L,280L,1040L,1963L,1702L,6830L,10751L,8679L,45838L,88255L,56292L,264838L,624778L };
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
public class A013914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013914Inst : IEnumerable<long>
{
public static readonly long[] Value=A013914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013914.Bytes);
public long this[int i]=>Value[i];

public static A013914Inst Instance=new A013914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013913
{
public static readonly BigInteger[] Value={ 331776L,2641807540224L,BigInteger.Parse("21035720123168587776"),BigInteger.Parse("167499529910025153071284224"),BigInteger.Parse("1333735776850284124449081472843776"),BigInteger.Parse("10620036506406716776157242913621199028224"),BigInteger.Parse("84563357566790276763032290197830086290913099776"),BigInteger.Parse("673346220481905860719963226704206593022095630190772224") };
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
public class A013913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013913Inst Instance=new A013913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013912
{
public static readonly BigInteger[] Value={ 13824L,110075314176L,876488338465357824L,BigInteger.Parse("6979147079584381377970176"),BigInteger.Parse("55572324035428505185378394701824"),BigInteger.Parse("442501521100279865673218454734216626176"),BigInteger.Parse("3523473231949594865126345424909586928788045824"),BigInteger.Parse("28056092520079410863331801112675274709253984591282176") };
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
public class A013912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013912Inst Instance=new A013912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013911
{
public static readonly BigInteger[] Value={ 576L,4586471424L,36520347436056576L,BigInteger.Parse("290797794982682557415424"),BigInteger.Parse("2315513501476187716057433112576"),BigInteger.Parse("18437563379178327736384102280592359424"),BigInteger.Parse("146811384664566452713597726037899455366168576"),BigInteger.Parse("1169003855003308785972158379694803112885582691303424") };
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
public class A013911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013911Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013911.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013911.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013911Inst Instance=new A013911Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013910
{
public static readonly BigInteger[] Value={ 24L,191102976L,1521681143169024L,BigInteger.Parse("12116574790945106558976"),BigInteger.Parse("96479729228174488169059713024"),BigInteger.Parse("768231807465763655682670928358014976"),BigInteger.Parse("6117141027690268863066571918245810640257024") };
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
public class A013910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013910Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013910.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013910.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013910Inst Instance=new A013910Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013909
{
public static readonly BigInteger[] Value={ 279841L,1801152661463L,11592836324538749809UL,BigInteger.Parse("74615470927590710561908487"),BigInteger.Parse("480250763996501976790165756943041"),BigInteger.Parse("3091058643093537522799545838540043339063"),BigInteger.Parse("19895113660064588580108197261066338165074766609"),BigInteger.Parse("128051775540161094255459334683883498184411818540470887") };
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
public class A013909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013909Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013909.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013909.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013909Inst Instance=new A013909Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013908
{
public static readonly BigInteger[] Value={ 12167L,78310985281L,504036361936467383L,BigInteger.Parse("3244150909895248285300369"),BigInteger.Parse("20880467999847912034355032910567"),BigInteger.Parse("134393854047545109686936775588697536481"),BigInteger.Parse("865004941741938633917747707002884268046728983"),BigInteger.Parse("5567468501746134532846058029734065138452687762629169") };
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
public class A013908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013908Inst Instance=new A013908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013907
{
public static readonly BigInteger[] Value={ 529L,3404825447L,21914624432020321L,BigInteger.Parse("141050039560662968926103"),BigInteger.Parse("907846434775996175406740561329"),BigInteger.Parse("5843211045545439551605946764725979847"),BigInteger.Parse("37608910510519071039902074217516707306379521"),BigInteger.Parse("242063847902005849254176436075394136454464685331703") };
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
public class A013907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013907Inst Instance=new A013907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013906
{
public static readonly BigInteger[] Value={ 23L,148035889L,952809757913927L,BigInteger.Parse("6132610415680998648961"),BigInteger.Parse("39471584120695485887249589623"),BigInteger.Parse("254052654154149545721997685422868689"),BigInteger.Parse("1635170022196481349560959748587682926364327"),BigInteger.Parse("10524515126174167358877236351104092889324551536161"),BigInteger.Parse("67739389260745218861137988047774370539553852007909099223") };
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
public class A013906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013906Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013906.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013906Inst Instance=new A013906Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013905
{
public static readonly BigInteger[] Value={ 234256L,1207269217792L,6221821273427820544L,BigInteger.Parse("32064977213018365645815808"),BigInteger.Parse("165251092644282265779977014214656"),BigInteger.Parse("851643319086537701956194499721106030592"),BigInteger.Parse("4389056261830591470007906571986683114651910144"),BigInteger.Parse("22619580800770514778759787562400873673529752979243008") };
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
public class A013905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013905Inst Instance=new A013905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013904
{
public static readonly BigInteger[] Value={ 10648L,54875873536L,282810057883082752L,BigInteger.Parse("1457498964228107529355264"),BigInteger.Parse("7511413302012830262726227918848"),BigInteger.Parse("38711059958478986452554295441868455936"),BigInteger.Parse("199502557355935975909450298726667414302359552"),BigInteger.Parse("1028162763671387035398172161927312439705897862692864") };
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
public class A013904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013904Inst Instance=new A013904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013903
{
public static readonly BigInteger[] Value={ 484L,2494357888L,12855002631049216L,BigInteger.Parse("66249952919459433152512"),BigInteger.Parse("341427877364219557396646723584"),BigInteger.Parse("1759593634476317566025195247357657088"),BigInteger.Parse("9068298061633453450429559033030337013743616"),BigInteger.Parse("46734671075972137972644189178514201804813539213312") };
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
public class A013903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013903Inst Instance=new A013903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013902
{
public static readonly BigInteger[] Value={ 22L,113379904L,584318301411328L,BigInteger.Parse("3011361496339065143296"),BigInteger.Parse("15519448971100888972574851072"),BigInteger.Parse("79981528839832616637508874879893504"),BigInteger.Parse("412195366437884247746798137865015318806528"),BigInteger.Parse("2124303230726006271483826780841554627491524509696"),BigInteger.Parse("10947877107572929152919737180202022857988400441953615872") };
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
public class A013902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013902Inst Instance=new A013902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013901
{
public static readonly BigInteger[] Value={ 194481L,794280046581L,3243919932521508681L,BigInteger.Parse("13248496640331026125580781"),BigInteger.Parse("54108198377272584130510593262881"),BigInteger.Parse("220983347100817338120002444455525554981"),BigInteger.Parse("902518308877795191433240103403256374623457081"),BigInteger.Parse("3685975927806112219127687339549342762856035687969181") };
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
public class A013901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013901Inst Instance=new A013901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013900
{
public static readonly BigInteger[] Value={ 9261L,37822859361L,154472377739119461L,BigInteger.Parse("630880792396715529789561"),BigInteger.Parse("2576580875108218291929075869661"),BigInteger.Parse("10523016528610349434285830688358359761"),BigInteger.Parse("42977062327514056734916195400155065458259861"),BigInteger.Parse("175522663228862486625127968549968702993144556569961") };
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
public class A013900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013900Inst Instance=new A013900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013899
{
public static readonly BigInteger[] Value={ 441L,1801088541L,7355827511386641L,BigInteger.Parse("30041942495081691894741"),BigInteger.Parse("122694327386105632949003612841"),BigInteger.Parse("501096025171921401632658604207540941"),BigInteger.Parse("2046526777500669368329342638102622164679041"),BigInteger.Parse("8358222058517261267863236597617557285387836027141") };
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
public class A013899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013899Inst Instance=new A013899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013898
{
public static readonly BigInteger[] Value={ 21L,85766121L,350277500542221L,BigInteger.Parse("1430568690241985328321"),BigInteger.Parse("5842587018385982521381124421"),BigInteger.Parse("23861715484377209601555171628930521"),BigInteger.Parse("97453656071460446110921078004886769746621"),BigInteger.Parse("398010574215107679422058885600836061208944572721"),BigInteger.Parse("1625515384162495488635310116741260158419511738394408821") };
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
public class A013898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013898Inst Instance=new A013898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013897
{
public static readonly BigInteger[] Value={ 160000L,512000000000L,1638400000000000000L,BigInteger.Parse("5242880000000000000000000"),BigInteger.Parse("16777216000000000000000000000000"),BigInteger.Parse("53687091200000000000000000000000000000"),BigInteger.Parse("171798691840000000000000000000000000000000000"),BigInteger.Parse("549755813888000000000000000000000000000000000000000") };
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
public class A013897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013897Inst Instance=new A013897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013896
{
public static readonly BigInteger[] Value={ 8000L,25600000000L,81920000000000000L,BigInteger.Parse("262144000000000000000000"),BigInteger.Parse("838860800000000000000000000000"),BigInteger.Parse("2684354560000000000000000000000000000"),BigInteger.Parse("8589934592000000000000000000000000000000000"),BigInteger.Parse("27487790694400000000000000000000000000000000000000") };
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
public class A013896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013896Inst Instance=new A013896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013895
{
public static readonly BigInteger[] Value={ 400L,1280000000L,4096000000000000L,BigInteger.Parse("13107200000000000000000"),BigInteger.Parse("41943040000000000000000000000"),BigInteger.Parse("134217728000000000000000000000000000"),BigInteger.Parse("429496729600000000000000000000000000000000"),BigInteger.Parse("1374389534720000000000000000000000000000000000000") };
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
public class A013895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013895Inst Instance=new A013895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013894
{
public static readonly BigInteger[] Value={ 20L,64000000L,204800000000000L,BigInteger.Parse("655360000000000000000"),BigInteger.Parse("2097152000000000000000000000"),BigInteger.Parse("6710886400000000000000000000000000"),BigInteger.Parse("21474836480000000000000000000000000000000"),BigInteger.Parse("68719476736000000000000000000000000000000000000"),BigInteger.Parse("219902325555200000000000000000000000000000000000000000") };
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
public class A013894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013894Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013894.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013894Inst Instance=new A013894Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013893
{
public static readonly BigInteger[] Value={ 130321L,322687697779L,799006685782884121L,BigInteger.Parse("1978419655660313589123979"),BigInteger.Parse("4898762930960846817716295277921"),BigInteger.Parse("12129821994589221844500501021364910179"),BigInteger.Parse("30034640110980377619945846078500632729311721"),BigInteger.Parse("74368742344158402044370289529129338200416023056379") };
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
public class A013893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013893Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013893.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013893Inst Instance=new A013893Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013892
{
public static readonly BigInteger[] Value={ 6859L,16983563041L,42052983462257059L,BigInteger.Parse("104127350297911241532841"),BigInteger.Parse("257829627945307727248226067259"),BigInteger.Parse("638411683925748518131605316913942641"),BigInteger.Parse("1580770532156861979997149793605296459437459"),BigInteger.Parse("3914144333903073791808962606796280957916632792441") };
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
public class A013892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013892Inst Instance=new A013892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013891
{
public static readonly BigInteger[] Value={ 361L,893871739L,2213314919066161L,BigInteger.Parse("5480386857784802185939"),BigInteger.Parse("13569980418174090907801371961"),BigInteger.Parse("33600614943460448322716069311260139"),BigInteger.Parse("83198449060887472631428936505541918917761"),BigInteger.Parse("206007596521214410095208558252435839890349094339") };
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
public class A013891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013891Inst Instance=new A013891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013890
{
public static readonly BigInteger[] Value={ 19L,47045881L,116490258898219L,BigInteger.Parse("288441413567621167681"),BigInteger.Parse("714209495693373205673756419"),BigInteger.Parse("1768453418076865701195582595329481"),BigInteger.Parse("4378865740046709085864680868712732574619"),BigInteger.Parse("10842505080063916320800450434338728415281531281"),BigInteger.Parse("26847115986241183138017674520015691090350184323352819") };
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
public class A013890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013890Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013890.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013890.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013890Inst Instance=new A013890Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013889
{
public static readonly BigInteger[] Value={ 104976L,198359290368L,374813367582081024L,BigInteger.Parse("708235345355337676357632"),BigInteger.Parse("1338258845052394702439737982976"),BigInteger.Parse("2528731089327963353099650821015994368"),BigInteger.Parse("4778209346999261057189801002565550445953024"),BigInteger.Parse("9028751479390699717312017900815782025058563653632") };
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
public class A013889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013889Inst Instance=new A013889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013888
{
public static readonly BigInteger[] Value={ 5832L,11019960576L,20822964865671168L,BigInteger.Parse("39346408075296537575424"),BigInteger.Parse("74347713614021927913318776832"),BigInteger.Parse("140485060518220186283313934500888576"),BigInteger.Parse("265456074833292280954988944586975024775168"),BigInteger.Parse("501597304410594428739556550045321223614364647424") };
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
public class A013888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013888Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013888.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013888.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013888Inst Instance=new A013888Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013887
{
public static readonly BigInteger[] Value={ 324L,612220032L,1156831381426176L,BigInteger.Parse("2185911559738696531968"),BigInteger.Parse("4130428534112329328517709824"),BigInteger.Parse("7804725584345565904628551916716032"),BigInteger.Parse("14747559712960682275277163588165279154176"),BigInteger.Parse("27866516911699690485530919446962290200798035968") };
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
public class A013887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013887Inst Instance=new A013887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013886
{
public static readonly BigInteger[] Value={ 18L,34012224L,64268410079232L,BigInteger.Parse("121439531096594251776"),BigInteger.Parse("229468251895129407139872768"),BigInteger.Parse("433595865796975883590475106484224"),BigInteger.Parse("819308872942260126404286866009182175232"),BigInteger.Parse("1548139828427760582529495524831238344488779776"),BigInteger.Parse("2925315479322586708409093799864313376118974623776768") };
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
public class A013886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013886Inst Instance=new A013886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013885
{
public static readonly BigInteger[] Value={ 83521L,118587876497L,168377826559400929L,BigInteger.Parse("239072435685151324847153"),BigInteger.Parse("339448671314611904643504117121"),BigInteger.Parse("481968572106750915091411825223071697"),BigInteger.Parse("684326450885775034048946719925754910487329"),BigInteger.Parse("971645701575323882519635342913622589939807491953") };
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
public class A013885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013885Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013885.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013885.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013885Inst Instance=new A013885Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013884
{
public static readonly BigInteger[] Value={ 4913L,6975757441L,9904578032905937L,BigInteger.Parse("14063084452067724991009"),BigInteger.Parse("19967568900859523802559065713"),BigInteger.Parse("28351092476867700887730107366063041"),BigInteger.Parse("40254497110927943179349807054456171205137"),BigInteger.Parse("57155629504430816618802078994918975878812205409") };
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
public class A013884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013884Inst Instance=new A013884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013883
{
public static readonly BigInteger[] Value={ 289L,410338673L,582622237229761L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("1174562876521148458974062689"),BigInteger.Parse("1667711322168688287513535727415473"),BigInteger.Parse("2367911594760467245844106297320951247361"),BigInteger.Parse("3362095853201812742282475234995233875224247377"),BigInteger.Parse("4773695331839566234818968439734627784374274207965089") };
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
public class A013883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013883Inst Instance=new A013883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013882
{
public static readonly BigInteger[] Value={ 17L,24137569L,34271896307633L,BigInteger.Parse("48661191875666868481"),BigInteger.Parse("69091933913008732880827217"),BigInteger.Parse("98100666009922840441972689847969"),BigInteger.Parse("139288917338851014461418017489467720433"),BigInteger.Parse("197770344305988984840145602058543169130838081"),BigInteger.Parse("280805607755268602048174614102036928492604365174417") };
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
public class A013882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013882Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013882.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013882.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013882Inst Instance=new A013882Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013881
{
public static readonly BigInteger[] Value={ 65536L,68719476736L,72057594037927936L,BigInteger.Parse("75557863725914323419136"),BigInteger.Parse("79228162514264337593543950336"),BigInteger.Parse("83076749736557242056487941267521536"),BigInteger.Parse("87112285931760246646623899502532662132736"),BigInteger.Parse("91343852333181432387730302044767688728495783936") };
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
public class A013881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013881Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013881.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013881.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013881Inst Instance=new A013881Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013880
{
public static readonly BigInteger[] Value={ 4096L,4294967296L,4503599627370496L,BigInteger.Parse("4722366482869645213696"),BigInteger.Parse("4951760157141521099596496896"),BigInteger.Parse("5192296858534827628530496329220096"),BigInteger.Parse("5444517870735015415413993718908291383296"),BigInteger.Parse("5708990770823839524233143877797980545530986496") };
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
public class A013880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013880Inst Instance=new A013880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013879
{
public static readonly BigInteger[] Value={ 256L,268435456L,281474976710656L,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("309485009821345068724781056"),BigInteger.Parse("324518553658426726783156020576256"),BigInteger.Parse("340282366920938463463374607431768211456"),BigInteger.Parse("356811923176489970264571492362373784095686656"),BigInteger.Parse("374144419156711147060143317175368453031918731001856") };
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
public class A013879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013879.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013879Inst Instance=new A013879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013878
{
public static readonly BigInteger[] Value={ 16L,16777216L,17592186044416L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("20282409603651670423947251286016"),BigInteger.Parse("21267647932558653966460912964485513216"),BigInteger.Parse("22300745198530623141535718272648361505980416"),BigInteger.Parse("23384026197294446691258957323460528314494920687616") };
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
public class A013878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013878Inst Instance=new A013878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013877
{
public static readonly BigInteger[] Value={ 50625L,38443359375L,29192926025390625L,BigInteger.Parse("22168378200531005859375"),BigInteger.Parse("16834112196028232574462890625"),BigInteger.Parse("12783403948858939111232757568359375"),BigInteger.Parse("9707397373664756887592375278472900390625"),BigInteger.Parse("7371554880626674761515459977090358734130859375") };
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
public class A013877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013877.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013877Inst Instance=new A013877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013876
{
public static readonly BigInteger[] Value={ 3375L,2562890625L,1946195068359375L,BigInteger.Parse("1477891880035400390625"),BigInteger.Parse("1122274146401882171630859375"),BigInteger.Parse("852226929923929274082183837890625"),BigInteger.Parse("647159824910983792506158351898193359375"),BigInteger.Parse("491436992041778317434363998472690582275390625") };
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
public class A013876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013876.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013876Inst Instance=new A013876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013875
{
public static readonly BigInteger[] Value={ 225L,170859375L,129746337890625L,BigInteger.Parse("98526125335693359375"),BigInteger.Parse("74818276426792144775390625"),BigInteger.Parse("56815128661595284938812255859375"),BigInteger.Parse("43143988327398919500410556793212890625"),BigInteger.Parse("32762466136118554495624266564846038818359375"),BigInteger.Parse("24878997722115027320114677422679960727691650390625") };
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
public class A013875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013875.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013875Inst Instance=new A013875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013874
{
public static readonly BigInteger[] Value={ 15L,11390625L,8649755859375L,6568408355712890625L,BigInteger.Parse("4987885095119476318359375"),BigInteger.Parse("3787675244106352329254150390625"),BigInteger.Parse("2876265888493261300027370452880859375"),BigInteger.Parse("2184164409074570299708284437656402587890625"),BigInteger.Parse("1658599848141001821340978494845330715179443359375") };
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
public class A013874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013874.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013874Inst Instance=new A013874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013873
{
public static readonly BigInteger[] Value={ 38416L,20661046784L,11112006825558016L,BigInteger.Parse("5976303958948914397184"),BigInteger.Parse("3214199700417740936751087616"),BigInteger.Parse("1728673739677471101567216945987584"),BigInteger.Parse("929722225368296217729286886758826377216"),BigInteger.Parse("500026926136478545004035990584179037499817984") };
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
public class A013873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013873.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013873Inst Instance=new A013873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013872
{
public static readonly BigInteger[] Value={ 2744L,1475789056L,793714773254144L,BigInteger.Parse("426878854210636742656"),BigInteger.Parse("229585692886981495482220544"),BigInteger.Parse("123476695691247935826229781856256"),BigInteger.Parse("66408730383449729837806206197059026944"),BigInteger.Parse("35716209009748467500288285041727074107129856") };
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
public class A013872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013872Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013872.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013872.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013872Inst Instance=new A013872Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013871
{
public static readonly BigInteger[] Value={ 196L,105413504L,56693912375296L,BigInteger.Parse("30491346729331195904"),BigInteger.Parse("16398978063355821105872896"),BigInteger.Parse("8819763977946281130444984418304"),BigInteger.Parse("4743480741674980702700443299789930496"),BigInteger.Parse("2551157786410604821449163217266219579080704"),BigInteger.Parse("1372073885318497127491074758162987278899500548096") };
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
public class A013871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013871Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013871.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013871.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013871Inst Instance=new A013871Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013870
{
public static readonly BigInteger[] Value={ 14L,7529536L,4049565169664L,2177953337809371136L,BigInteger.Parse("1171355575953987221848064"),BigInteger.Parse("629983141281877223603213172736"),BigInteger.Parse("338820052976784335907174521413566464"),BigInteger.Parse("182225556172186058674940229804729969934336"),BigInteger.Parse("98005277522749794820791054154499091349964324864") };
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
public class A013870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013870.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013870Inst Instance=new A013870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013869
{
public static readonly BigInteger[] Value={ 28561L,10604499373L,3937376385699289L,BigInteger.Parse("1461920290375446110677"),BigInteger.Parse("542800770374370512771595361"),BigInteger.Parse("201538126434611150798503956371773"),BigInteger.Parse("74829695578286078013428929473144712489"),BigInteger.Parse("27783742160348572763840067510872319734178277") };
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
public class A013869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013869Inst Instance=new A013869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013868
{
public static readonly BigInteger[] Value={ 2197L,815730721L,302875106592253L,BigInteger.Parse("112455406951957393129"),BigInteger.Parse("41753905413413116367045797"),BigInteger.Parse("15502932802662396215269535105521"),BigInteger.Parse("5756130429098929077956071497934208653"),BigInteger.Parse("2137210935411428674141543654682486133398329") };
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
public class A013868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013868.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013868Inst Instance=new A013868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013867
{
public static readonly BigInteger[] Value={ 169L,62748517L,23298085122481L,8650415919381337933L,BigInteger.Parse("3211838877954855105157369"),BigInteger.Parse("1192533292512492016559195008117"),BigInteger.Parse("442779263776840698304313192148785281"),BigInteger.Parse("164400841185494513395503358052498933338333"),BigInteger.Parse("61040881526285814362156628321386486455989674569") };
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
public class A013867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013867.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013867Inst Instance=new A013867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013866
{
public static readonly BigInteger[] Value={ 13L,4826809L,1792160394037L,665416609183179841L,BigInteger.Parse("247064529073450392704413"),BigInteger.Parse("91733330193268616658399616009"),BigInteger.Parse("34059943367449284484947168626829637"),BigInteger.Parse("12646218552730347184269489080961456410641"),BigInteger.Parse("4695452425098908797088971409337422035076128813") };
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
public class A013866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013866Inst Instance=new A013866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013865
{
public static readonly BigInteger[] Value={ 20736L,5159780352L,1283918464548864L,BigInteger.Parse("319479999370622926848"),BigInteger.Parse("79496847203390844133441536"),BigInteger.Parse("19781359483314150527412524285952"),BigInteger.Parse("4922235242952026704037113243122008064"),BigInteger.Parse("1224809639974238708818962962512535510581248") };
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
public class A013865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013865Inst Instance=new A013865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013864
{
public static readonly BigInteger[] Value={ 1728L,429981696L,106993205379072L,BigInteger.Parse("26623333280885243904"),BigInteger.Parse("6624737266949237011120128"),BigInteger.Parse("1648446623609512543951043690496"),BigInteger.Parse("410186270246002225336426103593500672"),BigInteger.Parse("102067469997853225734913580209377959215104"),BigInteger.Parse("25397652694505813866070015990659936347412758528") };
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
public class A013864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013864.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013864Inst Instance=new A013864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013863
{
public static readonly BigInteger[] Value={ 144L,35831808L,8916100448256L,2218611106740436992L,BigInteger.Parse("552061438912436417593344"),BigInteger.Parse("137370551967459378662586974208"),BigInteger.Parse("34182189187166852111368841966125056"),BigInteger.Parse("8505622499821102144576131684114829934592"),BigInteger.Parse("2116471057875484488839167999221661362284396544") };
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
public class A013863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013863Inst Instance=new A013863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013862
{
public static readonly BigInteger[] Value={ 12L,2985984L,743008370688L,184884258895036416L,BigInteger.Parse("46005119909369701466112"),BigInteger.Parse("11447545997288281555215581184"),BigInteger.Parse("2848515765597237675947403497177088"),BigInteger.Parse("708801874985091845381344307009569161216"),BigInteger.Parse("176372588156290374069930666601805113523699712") };
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
public class A013862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013862.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013862Inst Instance=new A013862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013861
{
public static readonly BigInteger[] Value={ 14641L,2357947691L,379749833583241L,BigInteger.Parse("61159090448414546291"),BigInteger.Parse("9849732675807611094711841"),BigInteger.Parse("1586309297171491574414436704891"),BigInteger.Parse("255476698618765889551019445759400441"),BigInteger.Parse("41144777789250865278081232758997200423491") };
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
public class A013861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013861.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013861Inst Instance=new A013861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013860
{
public static readonly BigInteger[] Value={ 1331L,214358881L,34522712143931L,5559917313492231481L,BigInteger.Parse("895430243255237372246531"),BigInteger.Parse("144209936106499234037676064081"),BigInteger.Parse("23225154419887808141001767796309131"),BigInteger.Parse("3740434344477351388916475705363381856681"),BigInteger.Parse("602400691612421918536387328824478011400331731") };
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
public class A013860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013860Inst Instance=new A013860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013859
{
public static readonly BigInteger[] Value={ 121L,19487171L,3138428376721L,505447028499293771L,BigInteger.Parse("81402749386839761113321"),BigInteger.Parse("13109994191499930367061460371"),BigInteger.Parse("2111377674535255285545615254209921"),BigInteger.Parse("340039485861577398992406882305761986971"),BigInteger.Parse("54763699237492901685126120802225273763666521") };
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
public class A013859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013859Inst Instance=new A013859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013858
{
public static readonly BigInteger[] Value={ 11L,1771561L,285311670611L,45949729863572161L,BigInteger.Parse("7400249944258160101211"),BigInteger.Parse("1191817653772720942460132761"),BigInteger.Parse("191943424957750480504146841291811"),BigInteger.Parse("30912680532870672635673352936887453361"),BigInteger.Parse("4978518112499354698647829163838661251242411") };
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
public class A013858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013858Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013858.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013858.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013858Inst Instance=new A013858Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013857
{
public static readonly BigInteger[] Value={ 10000L,1000000000L,100000000000000L,10000000000000000000UL,BigInteger.Parse("1000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000000000") };
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
public class A013857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013857Inst Instance=new A013857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013856
{
public static readonly BigInteger[] Value={ 1000L,100000000L,10000000000000L,1000000000000000000L,BigInteger.Parse("100000000000000000000000"),BigInteger.Parse("10000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000000000000000") };
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
public class A013856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013856Inst Instance=new A013856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013855
{
public static readonly BigInteger[] Value={ 100L,10000000L,1000000000000L,100000000000000000L,BigInteger.Parse("10000000000000000000000"),BigInteger.Parse("1000000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000000000000") };
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
public class A013855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013855Inst Instance=new A013855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013854
{
public static readonly BigInteger[] Value={ 10L,1000000L,100000000000L,10000000000000000L,BigInteger.Parse("1000000000000000000000"),BigInteger.Parse("100000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000"),BigInteger.Parse("1000000000000000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000000000000000") };
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
public class A013854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013854Inst Instance=new A013854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013853
{
public static readonly BigInteger[] Value={ 6561L,387420489L,22876792454961L,1350851717672992089L,BigInteger.Parse("79766443076872509863361"),BigInteger.Parse("4710128697246244834921603689"),BigInteger.Parse("278128389443693511257285776231761"),BigInteger.Parse("16423203268260658146231467800709255289"),BigInteger.Parse("969773729787523602876821942164080815560161") };
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
public class A013853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013853Inst Instance=new A013853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013852
{
public static readonly BigInteger[] Value={ 729L,43046721L,2541865828329L,150094635296999121L,BigInteger.Parse("8862938119652501095929"),BigInteger.Parse("523347633027360537213511521"),BigInteger.Parse("30903154382632612361920641803529"),BigInteger.Parse("1824800363140073127359051977856583921"),BigInteger.Parse("107752636643058178097424660240453423951129") };
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
public class A013852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013852Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013852.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013852Inst Instance=new A013852Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013851
{
public static readonly BigInteger[] Value={ 81L,4782969L,282429536481L,16677181699666569L,BigInteger.Parse("984770902183611232881"),BigInteger.Parse("58149737003040059690390169"),BigInteger.Parse("3433683820292512484657849089281"),BigInteger.Parse("202755595904452569706561330872953769"),BigInteger.Parse("11972515182562019788602740026717047105681") };
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
public class A013851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013851Inst Instance=new A013851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013850
{
public static readonly BigInteger[] Value={ 9L,531441L,31381059609L,1853020188851841L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("6461081889226673298932241"),BigInteger.Parse("381520424476945831628649898809"),BigInteger.Parse("22528399544939174411840147874772641"),BigInteger.Parse("1330279464729113309844748891857449678409") };
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
public class A013850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013850Inst Instance=new A013850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013849
{
public static readonly BigInteger[] Value={ 4096L,134217728L,4398046511104L,144115188075855872L,BigInteger.Parse("4722366482869645213696"),BigInteger.Parse("154742504910672534362390528"),BigInteger.Parse("5070602400912917605986812821504"),BigInteger.Parse("166153499473114484112975882535043072"),BigInteger.Parse("5444517870735015415413993718908291383296") };
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
public class A013849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013849Inst Instance=new A013849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013848
{
public static readonly BigInteger[] Value={ 512L,16777216L,549755813888L,18014398509481984L,BigInteger.Parse("590295810358705651712"),BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("633825300114114700748351602688"),BigInteger.Parse("20769187434139310514121985316880384"),BigInteger.Parse("680564733841876926926749214863536422912") };
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
public class A013848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013848Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013848.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013848Inst Instance=new A013848Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013847
{
public static readonly BigInteger[] Value={ 64L,2097152L,68719476736L,2251799813685248L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("2417851639229258349412352"),BigInteger.Parse("79228162514264337593543950336"),BigInteger.Parse("2596148429267413814265248164610048"),BigInteger.Parse("85070591730234615865843651857942052864") };
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
public class A013847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013847Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013847.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013847.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013847Inst Instance=new A013847Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013846
{
public static readonly BigInteger[] Value={ 8L,262144L,8589934592L,281474976710656L,9223372036854775808UL,BigInteger.Parse("302231454903657293676544"),BigInteger.Parse("9903520314283042199192993792"),BigInteger.Parse("324518553658426726783156020576256"),BigInteger.Parse("10633823966279326983230456482242756608") };
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
public class A013846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013846Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013846.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013846Inst Instance=new A013846Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013845
{
public static readonly BigInteger[] Value={ 2401L,40353607L,678223072849L,11398895185373143L,BigInteger.Parse("191581231380566414401"),BigInteger.Parse("3219905755813179726837607"),BigInteger.Parse("54116956037952111668959660849"),BigInteger.Parse("909543680129861140820205019889143"),BigInteger.Parse("15286700631942576193765185769276826401") };
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
public class A013845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013845Inst Instance=new A013845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013844
{
public static readonly BigInteger[] Value={ 343L,5764801L,96889010407L,1628413597910449L,BigInteger.Parse("27368747340080916343"),BigInteger.Parse("459986536544739960976801"),BigInteger.Parse("7730993719707444524137094407"),BigInteger.Parse("129934811447123020117172145698449"),BigInteger.Parse("2183814375991796599109312252753832343") };
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
public class A013844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013844Inst Instance=new A013844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013843
{
public static readonly BigInteger[] Value={ 49L,823543L,13841287201L,232630513987207L,3909821048582988049L,BigInteger.Parse("65712362363534280139543"),BigInteger.Parse("1104427674243920646305299201"),BigInteger.Parse("18562115921017574302453163671207"),BigInteger.Parse("311973482284542371301330321821976049"),BigInteger.Parse("5243338316756303634461458718861951455543") };
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
public class A013843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013843Inst Instance=new A013843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013842
{
public static readonly BigInteger[] Value={ 7L,117649L,1977326743L,33232930569601L,558545864083284007L,BigInteger.Parse("9387480337647754305649"),BigInteger.Parse("157775382034845806615042743"),BigInteger.Parse("2651730845859653471779023381601"),BigInteger.Parse("44567640326363195900190045974568007"),BigInteger.Parse("749048330965186233494494102694564493649") };
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
public class A013842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013842Inst Instance=new A013842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013841
{
public static readonly BigInteger[] Value={ 1296L,10077696L,78364164096L,609359740010496L,4738381338321616896L,BigInteger.Parse("36845653286788892983296"),BigInteger.Parse("286511799958070431838109696"),BigInteger.Parse("2227915756473955677973140996096"),BigInteger.Parse("17324272922341479351919144385642496"),BigInteger.Parse("134713546244127343440523266742756048896") };
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
public class A013841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013841Inst Instance=new A013841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013840
{
public static readonly BigInteger[] Value={ 216L,1679616L,13060694016L,101559956668416L,789730223053602816L,BigInteger.Parse("6140942214464815497216"),BigInteger.Parse("47751966659678405306351616"),BigInteger.Parse("371319292745659279662190166016"),BigInteger.Parse("2887378820390246558653190730940416"),BigInteger.Parse("22452257707354557240087211123792674816") };
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
public class A013840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013840Inst Instance=new A013840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013839
{
public static readonly BigInteger[] Value={ 36L,279936L,2176782336L,16926659444736L,131621703842267136L,BigInteger.Parse("1023490369077469249536"),BigInteger.Parse("7958661109946400884391936"),BigInteger.Parse("61886548790943213277031694336"),BigInteger.Parse("481229803398374426442198455156736"),BigInteger.Parse("3742042951225759540014535187298779136") };
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
public class A013839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013839Inst Instance=new A013839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013838
{
public static readonly BigInteger[] Value={ 6L,46656L,362797056L,2821109907456L,21936950640377856L,BigInteger.Parse("170581728179578208256"),BigInteger.Parse("1326443518324400147398656"),BigInteger.Parse("10314424798490535546171949056"),BigInteger.Parse("80204967233062404407033075859456"),BigInteger.Parse("623673825204293256669089197883129856") };
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
public class A013838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013838.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013838Inst Instance=new A013838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013821
{
public static readonly BigInteger[] Value={ 13824L,4586471424L,1521681143169024L,BigInteger.Parse("504857282956046106624"),BigInteger.Parse("167499529910025153071284224"),BigInteger.Parse("55572324035428505185378394701824"),BigInteger.Parse("18437563379178327736384102280592359424"),BigInteger.Parse("6117141027690268863066571918245810640257024") };
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
public class A013821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013821Inst Instance=new A013821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013820
{
public static readonly BigInteger[] Value={ 24L,7962624L,2641807540224L,876488338465357824L,BigInteger.Parse("290797794982682557415424"),BigInteger.Parse("96479729228174488169059713024"),BigInteger.Parse("32009658644406818986777955348250624"),BigInteger.Parse("10620036506406716776157242913621199028224"),BigInteger.Parse("3523473231949594865126345424909586928788045824") };
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
public class A013820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013820Inst Instance=new A013820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013819
{
public static readonly BigInteger[] Value={ 12167L,3404825447L,952809757913927L,BigInteger.Parse("266635235464391245607"),BigInteger.Parse("74615470927590710561908487"),BigInteger.Parse("20880467999847912034355032910567"),BigInteger.Parse("5843211045545439551605946764725979847"),BigInteger.Parse("1635170022196481349560959748587682926364327") };
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
public class A013819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013819.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013819Inst Instance=new A013819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013818
{
public static readonly BigInteger[] Value={ 23L,6436343L,1801152661463L,504036361936467383L,BigInteger.Parse("141050039560662968926103"),BigInteger.Parse("39471584120695485887249589623"),BigInteger.Parse("11045767571919545466173812409689943"),BigInteger.Parse("3091058643093537522799545838540043339063"),BigInteger.Parse("865004941741938633917747707002884268046728983") };
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
public class A013818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013818Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013818.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013818.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013818Inst Instance=new A013818Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013817
{
public static readonly BigInteger[] Value={ 10648L,2494357888L,584318301411328L,BigInteger.Parse("136880068015412051968"),BigInteger.Parse("32064977213018365645815808"),BigInteger.Parse("7511413302012830262726227918848"),BigInteger.Parse("1759593634476317566025195247357657088"),BigInteger.Parse("412195366437884247746798137865015318806528") };
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
public class A013817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013817Inst Instance=new A013817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013816
{
public static readonly BigInteger[] Value={ 22L,5153632L,1207269217792L,282810057883082752L,BigInteger.Parse("66249952919459433152512"),BigInteger.Parse("15519448971100888972574851072"),BigInteger.Parse("3635524038174209847159494312722432"),BigInteger.Parse("851643319086537701956194499721106030592"),BigInteger.Parse("199502557355935975909450298726667414302359552") };
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
public class A013816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013816Inst Instance=new A013816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013815
{
public static readonly BigInteger[] Value={ 9261L,1801088541L,350277500542221L,BigInteger.Parse("68122318582951682301"),BigInteger.Parse("13248496640331026125580781"),BigInteger.Parse("2576580875108218291929075869661"),BigInteger.Parse("501096025171921401632658604207540941"),BigInteger.Parse("97453656071460446110921078004886769746621"),BigInteger.Parse("18952884486433699020098042171468383867092598701") };
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
public class A013815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013815Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013815.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013815.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013815Inst Instance=new A013815Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013814
{
public static readonly BigInteger[] Value={ 21L,4084101L,794280046581L,154472377739119461L,BigInteger.Parse("30041942495081691894741"),BigInteger.Parse("5842587018385982521381124421"),BigInteger.Parse("1136272165922724266740722458520501"),BigInteger.Parse("220983347100817338120002444455525554981"),BigInteger.Parse("42977062327514056734916195400155065458259861") };
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
public class A013814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013814Inst Instance=new A013814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013813
{
public static readonly BigInteger[] Value={ 8000L,1280000000L,204800000000000L,BigInteger.Parse("32768000000000000000"),BigInteger.Parse("5242880000000000000000000"),BigInteger.Parse("838860800000000000000000000000"),BigInteger.Parse("134217728000000000000000000000000000"),BigInteger.Parse("21474836480000000000000000000000000000000"),BigInteger.Parse("3435973836800000000000000000000000000000000000") };
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
public class A013813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013813Inst Instance=new A013813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013812
{
public static readonly BigInteger[] Value={ 20L,3200000L,512000000000L,81920000000000000L,BigInteger.Parse("13107200000000000000000"),BigInteger.Parse("2097152000000000000000000000"),BigInteger.Parse("335544320000000000000000000000000"),BigInteger.Parse("53687091200000000000000000000000000000"),BigInteger.Parse("8589934592000000000000000000000000000000000") };
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
public class A013812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013812Inst Instance=new A013812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013811
{
public static readonly BigInteger[] Value={ 6859L,893871739L,116490258898219L,15181127029874798299UL,BigInteger.Parse("1978419655660313589123979"),BigInteger.Parse("257829627945307727248226067259"),BigInteger.Parse("33600614943460448322716069311260139"),BigInteger.Parse("4378865740046709085864680868712732574619"),BigInteger.Parse("570658162108627174778971075491512021856922699") };
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
public class A013811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013811Inst Instance=new A013811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013810
{
public static readonly BigInteger[] Value={ 19L,2476099L,322687697779L,42052983462257059L,BigInteger.Parse("5480386857784802185939"),BigInteger.Parse("714209495693373205673756419"),BigInteger.Parse("93076495688256089536609610280499"),BigInteger.Parse("12129821994589221844500501021364910179"),BigInteger.Parse("1580770532156861979997149793605296459437459") };
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
public class A013810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013810Inst Instance=new A013810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013809
{
public static readonly BigInteger[] Value={ 5832L,612220032L,64268410079232L,6746640616477458432L,BigInteger.Parse("708235345355337676357632"),BigInteger.Parse("74347713614021927913318776832"),BigInteger.Parse("7804725584345565904628551916716032"),BigInteger.Parse("819308872942260126404286866009182175232"),BigInteger.Parse("86007768245986699029416418046179908027154432") };
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
public class A013809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013809Inst Instance=new A013809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013808
{
public static readonly BigInteger[] Value={ 18L,1889568L,198359290368L,20822964865671168L,BigInteger.Parse("2185911559738696531968"),BigInteger.Parse("229468251895129407139872768"),BigInteger.Parse("24088659210943104643915283693568"),BigInteger.Parse("2528731089327963353099650821015994368"),BigInteger.Parse("265456074833292280954988944586975024775168") };
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
public class A013808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013808Inst Instance=new A013808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013807
{
public static readonly BigInteger[] Value={ 4913L,410338673L,34271896307633L,2862423051509815793L,BigInteger.Parse("239072435685151324847153"),BigInteger.Parse("19967568900859523802559065713"),BigInteger.Parse("1667711322168688287513535727415473"),BigInteger.Parse("139288917338851014461418017489467720433"),BigInteger.Parse("11633549665058175578832094238737833478284593") };
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
public class A013807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013807Inst Instance=new A013807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}