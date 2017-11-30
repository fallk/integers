using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A227257
{
public static readonly BigInteger[] Value={ 0L,1L,24L,1760L,411861L,551247139L,2883245852086L,85948329517780776L,BigInteger.Parse("11001968794030973784902"),BigInteger.Parse("7462399462450938863305238264") };
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
public class A227257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227257Inst Instance=new A227257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227258
{
public static readonly long[] Value={ 2L,9L,98L,2201L,112349L,13855163L,4307345460L };
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
public class A227258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227258Inst : IEnumerable<long>
{
public static readonly long[] Value=A227258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227258.Bytes);
public long this[int i]=>Value[i];

public static A227258Inst Instance=new A227258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227259
{
public static readonly long[] Value={ 3L,9L,23L,50L,96L,168L,274L,423L,625L,891L,1233L,1664L,2198L,2850L,3636L,4573L,5679L,6973L,8475L,10206L,12188L,14444L,16998L,19875L,23101L,26703L,30709L,35148L,40050L,45446L,51368L,57849L,64923L,72625L,80991L,90058L,99864L,110448L,121850L,134111L };
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
public class A227259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227259Inst : IEnumerable<long>
{
public static readonly long[] Value=A227259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227259.Bytes);
public long this[int i]=>Value[i];

public static A227259Inst Instance=new A227259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227260
{
public static readonly long[] Value={ 4L,23L,98L,353L,1111L,3136L,8065L,19146L,42385L,88282L,174361L,328741L,595043L,1038979L,1757024L,2887631L,4625512L,7239575L,11095178L,16681436L,24644396L,35826978L,51316667L,72502032L,101139243L,139429856L,190111239L,256561119L };
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
public class A227260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227260Inst : IEnumerable<long>
{
public static readonly long[] Value=A227260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227260.Bytes);
public long this[int i]=>Value[i];

public static A227260Inst Instance=new A227260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227261
{
public static readonly long[] Value={ 5L,50L,353L,2201L,11932L,57146L,244818L,951917L,3403038L,11297855L,35123154L,102968348L,286360987L,759331583L,1928166887L,4706232142L,11076831313L,25210805133L,55622829033L,119222502647L,248739253915L,506020952898L };
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
public class A227261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227261Inst : IEnumerable<long>
{
public static readonly long[] Value=A227261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227261.Bytes);
public long this[int i]=>Value[i];

public static A227261Inst Instance=new A227261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227262
{
public static readonly long[] Value={ 6L,96L,1111L,11932L,112349L,937865L,6961606L,46364258L,280471755L,1557597103L,8014162577L,38505244717L,173924889597L,742804988619L,3014292672706L,11671178123287L,43274437542484L,154133395370348L,528811622382841L };
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
public class A227262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227262Inst : IEnumerable<long>
{
public static readonly long[] Value=A227262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227262.Bytes);
public long this[int i]=>Value[i];

public static A227262Inst Instance=new A227262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227263
{
public static readonly long[] Value={ 2L,3L,3L,4L,9L,4L,5L,23L,23L,5L,6L,50L,98L,50L,6L,7L,96L,353L,353L,96L,7L,8L,168L,1111L,2201L,1111L,168L,8L,9L,274L,3136L,11932L,11932L,3136L,274L,9L,10L,423L,8065L,57146L,112349L,57146L,8065L,423L,10L,11L,625L,19146L,244818L,937865L,937865L,244818L,19146L,625L,11L };
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
public class A227263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227263Inst : IEnumerable<long>
{
public static readonly long[] Value=A227263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227263.Bytes);
public long this[int i]=>Value[i];

public static A227263Inst Instance=new A227263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227264
{
public static readonly long[] Value={ 2L,8L,49L,513L,10906L,498772L,48265519L,9879827545L,4332146485870L };
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
public class A227264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227264Inst : IEnumerable<long>
{
public static readonly long[] Value=A227264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227264.Bytes);
public long this[int i]=>Value[i];

public static A227264Inst Instance=new A227264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227265
{
public static readonly long[] Value={ 3L,8L,16L,30L,54L,93L,153L,241L,365L,534L,758L,1048L,1416L,1875L,2439L,3123L,3943L,4916L,6060L,7394L,8938L,10713L,12741L,15045L,17649L,20578L,23858L,27516L,31580L,36079L,41043L,46503L,52491L,59040L,66184L,73958L,82398L,91541L,101425L,112089L,123573L };
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
public class A227265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227265Inst : IEnumerable<long>
{
public static readonly long[] Value=A227265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227265.Bytes);
public long this[int i]=>Value[i];

public static A227265Inst Instance=new A227265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227266
{
public static readonly long[] Value={ 4L,16L,49L,132L,341L,836L,1934L,4232L,8804L,17501L,33392L,61393L,109141L,188181L,315546L,515823L,823812L,1287900L,1974288L,2972226L,4400429L,6414866L,9218134L,13070650L,18303916L,25336135L,34690480L,47016343L,63113917L,83962491L };
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
public class A227266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227266Inst : IEnumerable<long>
{
public static readonly long[] Value=A227266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227266.Bytes);
public long this[int i]=>Value[i];

public static A227266Inst Instance=new A227266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227267
{
public static readonly long[] Value={ 5L,30L,132L,513L,1949L,7131L,24496L,78761L,238146L,681095L,1852355L,4813290L,11999195L,28801351L,66769946L,149914163L,326768708L,692941231L,1432287640L,2890510485L,5704099317L,11022017108L,20880164204L,38823463828L,70923212058L };
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
public class A227267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227267Inst : IEnumerable<long>
{
public static readonly long[] Value=A227267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227267.Bytes);
public long this[int i]=>Value[i];

public static A227267Inst Instance=new A227267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227268
{
public static readonly long[] Value={ 6L,54L,341L,1949L,10906L,59952L,311644L,1513042L,6877791L,29429777L,119153363L,458571762L,1684448300L,5926680882L,20037283285L,65276341407L,205423183265L,625887083947L,1850014507021L,5314738730828L,14864035315827L,40531623551553L };
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
public class A227268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227268Inst : IEnumerable<long>
{
public static readonly long[] Value=A227268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227268.Bytes);
public long this[int i]=>Value[i];

public static A227268Inst Instance=new A227268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227269
{
public static readonly long[] Value={ 2L,3L,3L,4L,8L,4L,5L,16L,16L,5L,6L,30L,49L,30L,6L,7L,54L,132L,132L,54L,7L,8L,93L,341L,513L,341L,93L,8L,9L,153L,836L,1949L,1949L,836L,153L,9L,10L,241L,1934L,7131L,10906L,7131L,1934L,241L,10L,11L,365L,4232L,24496L,59952L,59952L,24496L,4232L,365L,11L,12L,534L,8804L,78761L };
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
public class A227269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227269Inst : IEnumerable<long>
{
public static readonly long[] Value=A227269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227269.Bytes);
public long this[int i]=>Value[i];

public static A227269Inst Instance=new A227269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227270
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,18L,24L,32L,36L,42L,48L,54L,64L,72L,84L,96L,108L,126L,128L,144L,162L,168L,192L,216L,252L,256L,288L,294L,324L,336L,378L,384L,432L,486L,504L,512L,576L,588L,648L,672L,756L,768L,864L,882L,972L,1008L,1024L,1134L,1152L,1176L,1296L,1344L,1458L };
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
public class A227270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227270Inst : IEnumerable<long>
{
public static readonly long[] Value=A227270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227270.Bytes);
public long this[int i]=>Value[i];

public static A227270Inst Instance=new A227270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227271
{
public static readonly long[] Value={ 69L,105L,263L,311L,341L,425L,491L,515L,561L,575L,725L,993L,1091L,1133L,1193L,1521L,1583L,1991L,2085L,2153L,2289L,2351L,2379L,2415L,2433L,2441L,2543L,2601L,3203L,3225L,3285L,4245L,4263L,4541L,4713L,4955L,5039L,5073L,5463L,5499L,5523L,5651L,5675L,6779L,7295L };
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
public class A227271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227271Inst : IEnumerable<long>
{
public static readonly long[] Value=A227271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227271.Bytes);
public long this[int i]=>Value[i];

public static A227271Inst Instance=new A227271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227272
{
public static readonly long[] Value={ 1L,2L,4L,9L,3L,6L,17L,9L,29L,48L,4L,8L,27L,12L,51L,97L,16L,90L,192L,363L,5L,10L,39L,15L,69L,145L,20L,130L,311L,685L,25L,180L,459L,1056L };
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
public class A227272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227272Inst : IEnumerable<long>
{
public static readonly long[] Value=A227272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227272.Bytes);
public long this[int i]=>Value[i];

public static A227272Inst Instance=new A227272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227273
{
public static readonly BigInteger[] Value={ 1L,70L,3321L,135450L,5143341L,188253030L,6755426161L,239789821810L,8459827013781L,297439462109790L,10437310023978201L,365844613023404970L,12815338551339471421UL,BigInteger.Parse("448752409725746315350"),BigInteger.Parse("15710645734163363925441"),BigInteger.Parse("549958830422813492568930"),BigInteger.Parse("19250283677858902044252261") };
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
public class A227273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227273Inst Instance=new A227273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227274
{
public static readonly BigInteger[] Value={ 1L,125619267L,15780200115998021L,BigInteger.Parse("1982297155904786129853319"),BigInteger.Parse("249014713718646783738954504445833"),BigInteger.Parse("31281045560536537504251044551093148365259"),BigInteger.Parse("3929501983027158158450774377594837056318431034061"),BigInteger.Parse("493621154853416034649452413908532772153277417677215453967") };
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
public class A227274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227274Inst Instance=new A227274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227275
{
public static readonly BigInteger[] Value={ 1L,125619265L,15780199864759489L,BigInteger.Parse("1982297124344386149095809"),BigInteger.Parse("249014709754052503489782225496705"),BigInteger.Parse("31281045062507114031551757322356418422721"),BigInteger.Parse("3929501920465067535407122841792035182868864246081"),BigInteger.Parse("493621146994412131157226720050635552766405178489920173825") };
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
public class A227275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227275Inst Instance=new A227275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227276
{
public static readonly long[] Value={ 7L,17L,23L,61L,67L,71L,79L,151L,307L,311L,383L,389L,409L,439L,613L,677L,1559L,1627L,1637L,2377L,2719L,2801L,3407L,3821L,4229L,4799L,4919L,5557L,5641L,5743L,5779L,5851L,5867L,6133L,6733L,7121L,7723L,8009L,8527L,8573L,10163L,10729L,11317L,11789L,11987L,14107L,14629L,14653L,14669L,17189L,17401L,18077L };
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
public class A227276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227276Inst : IEnumerable<long>
{
public static readonly long[] Value=A227276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227276.Bytes);
public long this[int i]=>Value[i];

public static A227276Inst Instance=new A227276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227277
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,2L,1L,4L,4L,3L,1L,3L,2L,2L,1L,5L,7L,6L,2L,3L,2L,2L,1L,4L,4L,3L,1L,3L,2L,2L,1L,6L,11L,12L,6L,4L,2L,2L,1L,4L,4L,3L,1L,3L,2L,2L,1L,5L,7L,6L,2L,3L,2L,2L,1L,4L,4L,3L,1L,3L,2L,2L,1L,7L,16L,22L,16L,9L,3L,2L,1L,4L,4L,3L,1L,3L,2L,2L,1L,5L,7L,6L,2L,3L,2L,2L,1L,4L,4L,3L,1L,3L,2L,2L,1L,6L,11L,12L,6L,4L,2L,2L,1L,4L,4L,3L,1L,3L,2L,2L,1L,5L,7L,6L,2L,3L,2L,2L,1L,4L,4L,3L,1L,3L,2L,2L,1L };
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
public class A227277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227277Inst : IEnumerable<long>
{
public static readonly long[] Value=A227277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227277.Bytes);
public long this[int i]=>Value[i];

public static A227277Inst Instance=new A227277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227278
{
public static readonly BigInteger[] Value={ 1L,6L,63L,948L,18645L,454158L,13221075L,448434136L,17386204761L,759123121050L,36882981687519L,1974616464026484L,115536647641839333L,7336947898087080406L,BigInteger.Parse("502660682907018997755"),BigInteger.Parse("36961205206337621142192"),BigInteger.Parse("2903732354672613314658225"),BigInteger.Parse("242753209611983811853905330") };
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
public class A227278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227278Inst Instance=new A227278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227279
{
public static readonly long[] Value={ 9L,18L,25L,49L,50L,98L,121L,169L,242L,289L,338L,361L,529L,578L,722L,841L,961L,1058L,1369L,1681L,1682L,1849L,1922L,2209L,2738L,2809L,3362L,3481L,3698L,3721L,4418L,4489L,5041L,5329L,5618L,6241L,6889L,6926L,7442L,7921L,8978L,9409L,10082L,10201L,10609L,10658L,11449L,11881L,12482L,12769L,13778L };
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
public class A227279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227279Inst : IEnumerable<long>
{
public static readonly long[] Value=A227279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227279.Bytes);
public long this[int i]=>Value[i];

public static A227279Inst Instance=new A227279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227280
{
public static readonly long[] Value={ 81647160420L,170655787050L,211212209880L,227961624450L };
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
public class A227280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227280Inst : IEnumerable<long>
{
public static readonly long[] Value=A227280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227280.Bytes);
public long this[int i]=>Value[i];

public static A227280Inst Instance=new A227280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227281
{
public static readonly long[] Value={ 7L,11L,37L,107L,137L,151L,277L,359L,389L,401L,541L,557L,571L,877L,1033L,1493L,1663L,2221L,2251L,2879L,3271L,6269L,6673L,6703L,7457L,7487L,9431L,10103L,10133L,10567L,11981L,12457L,12973L,14723L,17047L,19387L,24061L,25643L,25673L,26861L,26891L,27337L,27367L };
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
public class A227281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227281Inst : IEnumerable<long>
{
public static readonly long[] Value=A227281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227281.Bytes);
public long this[int i]=>Value[i];

public static A227281Inst Instance=new A227281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227282
{
public static readonly long[] Value={ 47L,179L,199L,409L,619L,829L,881L,1091L,1453L,3499L,3709L,3919L,10529L,10627L,10837L,10859L,11069L,11279L,14423L,20771L,22697L,30097L,30307L,31583L,31793L,32363L,41669L,75703L,93281L,95747L,120661L,120737L,120871L,120947L,129287L,140603L,153319L,153529L };
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
public class A227282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227282Inst : IEnumerable<long>
{
public static readonly long[] Value=A227282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227282.Bytes);
public long this[int i]=>Value[i];

public static A227282Inst Instance=new A227282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227283
{
public static readonly long[] Value={ 199L,409L,619L,881L,3499L,3709L,10627L,10859L,11069L,30097L,31583L,120661L,120737L,153319L,182537L,471089L,487391L,564973L,565183L,825991L,1010747L,1280623L,1288607L,1288817L,1302281L,1302491L,1395209L,1982599L,2358841L,2359051L,2439571L,3161017L,3600521L };
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
public class A227283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227283Inst : IEnumerable<long>
{
public static readonly long[] Value=A227283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227283.Bytes);
public long this[int i]=>Value[i];

public static A227283Inst Instance=new A227283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227284
{
public static readonly long[] Value={ 199L,409L,3499L,10859L,564973L,1288607L,1302281L,2358841L,3600521L,4047803L,17160749L,20751193L,23241473L,44687567L,50655739L,53235151L,87662609L,100174043L,103468003L,110094161L,180885839L,187874017L,192205147L,221712811L,243051733L,243051943L,304570103L };
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
public class A227284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227284Inst : IEnumerable<long>
{
public static readonly long[] Value=A227284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227284.Bytes);
public long this[int i]=>Value[i];

public static A227284Inst Instance=new A227284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227285
{
public static readonly long[] Value={ 60858179L,186874511L,291297353L,1445838451L,2943023729L,4597225889L,7024895393L,8620560607L,8656181357L,19033631401L,20711172773L,25366690189L,27187846201L,32022299977L,34351919351L };
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
public class A227285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227285Inst : IEnumerable<long>
{
public static readonly long[] Value=A227285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227285.Bytes);
public long this[int i]=>Value[i];

public static A227285Inst Instance=new A227285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227286
{
public static readonly long[] Value={ 14933623L,2085471361L,132420258931L,185041386139L,682539280751L,834172298383L,834172328413L,856378247603L,856378277633L,888867525577L,931115864233L,1059709587163L,1345030977911L,1360910561113L,1578280523803L,1973348047529L,1988253536611L,2083502941613L };
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
public class A227286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227286Inst : IEnumerable<long>
{
public static readonly long[] Value=A227286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227286.Bytes);
public long this[int i]=>Value[i];

public static A227286Inst Instance=new A227286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227287
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,3L,4L,4L,1L,2L,2L,3L,2L,6L,7L,5L,1L,2L,2L,3L,1L,3L,4L,4L,1L,2L,2L,4L,6L,12L,11L,6L,1L,2L,2L,3L,1L,3L,4L,4L,1L,2L,2L,3L,2L,6L,7L,5L,1L,2L,2L,3L,1L,3L,4L,4L,1L,2L,3L,9L,16L,22L,16L,7L,1L,2L,2L,3L,1L,3L,4L,4L,1L,2L,2L,3L,2L,6L,7L,5L,1L,2L,2L,3L,1L,3L,4L,4L,1L,2L,2L,4L,6L,12L,11L,6L,1L,2L,2L,3L,1L,3L,4L,4L,1L,2L,2L,3L,2L,6L,7L,5L,1L,2L,2L,3L,1L,3L,4L,4L,1L,3L,9L,24L,36L,37L,22L,8L,1L };
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
public class A227287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227287Inst : IEnumerable<long>
{
public static readonly long[] Value=A227287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227287.Bytes);
public long this[int i]=>Value[i];

public static A227287Inst Instance=new A227287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227288
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,5L,1L,7L,2L,4L,3L,3L,1L,11L,1L,13L,2L,2L,1L,17L,1L,19L,2L,4L,3L,3L,1L,23L,1L,5L,2L,4L,1L,29L,1L,31L,1L,3L,1L,5L,1L,37L,1L,3L,1L,41L,1L,43L,2L,4L,3L,5L,1L,47L,1L,7L,1L,3L,2L,4L,1L,53L,1L,5L,1L,3L,1L,59L,1L,61L,2L,2L,1L,67L,2L,2L,1L,3L,1L,71L,1L };
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
public class A227288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227288Inst : IEnumerable<long>
{
public static readonly long[] Value=A227288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227288.Bytes);
public long this[int i]=>Value[i];

public static A227288Inst Instance=new A227288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227289
{
public static readonly long[] Value={ 1L,2L,4L,10L,6L,177L,8L,514L,500L,349L,14L,4791L,16L,5949L,1623L,863L,20L,2629L,22L,5113L,2043L,3211L,28L,7347L,4593L,11911L,1647L,12819L,34L,27325L,36L,15755L,34527L,29319L,5459L,2797L,42L,24535L,20145L,15511L,46L,26523L,48L,64895L,13335L,40769L,54L,43835L,184041L };
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
public class A227289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227289Inst : IEnumerable<long>
{
public static readonly long[] Value=A227289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227289.Bytes);
public long this[int i]=>Value[i];

public static A227289Inst Instance=new A227289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227290
{
public static readonly BigInteger[] Value={ 4L,0L,3L,1L,11L,23L,323L,BigInteger.Parse("1103323373373373373373373373373") };
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
public class A227290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227290.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227290Inst Instance=new A227290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227291
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L };
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
public class A227291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227291Inst : IEnumerable<long>
{
public static readonly long[] Value=A227291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227291.Bytes);
public long this[int i]=>Value[i];

public static A227291Inst Instance=new A227291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227292
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1L,5L,16L,80L,436L,2786L,19538L,147771L,1182095L,9890463L,85866068L,769212600L,7080642324L,66754295740L,642857161008L,6309892895338L,6300760829973L,639049976047882L,6574281878157350L,68519019810831408L,722711344283052608L,7707346411412142258L,BigInteger.Parse("83037096707432139882") };
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
public class A227292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227292.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227292Inst Instance=new A227292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227293
{
public static readonly long[] Value={ 1L,2L,-2L,4L,-2L,12L,-36L,104L,-330L,1068L,-3356L,10808L,-35156L,115192L,-380744L,1267152L,-4242778L,14285644L,-48336684L,164272984L,-560515836L,1919455464L,-6594719992L,22725877680L,-78531331524L,272062125048L,-944738639640L,3287748182064L,-11464667424744L,40053463412080L,-140178051713680L,491396601445280L };
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
public class A227293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227293Inst : IEnumerable<long>
{
public static readonly long[] Value=A227293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227293.Bytes);
public long this[int i]=>Value[i];

public static A227293Inst Instance=new A227293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227294
{
public static readonly BigInteger[] Value={ 1L,2L,-6L,28L,-138L,828L,-5180L,33528L,-223002L,1512812L,-10423796L,72743688L,-513005252L,3649850584L,-26162987064L,188758837488L,-1369529290618L,9985780112460L,-73129564342212L,537647977891688L,-3966638722824108L,29357430489994120L,-217899481094085320L,1621534636345991568L,BigInteger.Parse("-12095712639252241956") };
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
public class A227294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227294.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227294Inst Instance=new A227294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227295
{
public static readonly long[] Value={ 1L,4L,-8L,32L,-128L,768L,-4608L,28672L,-184320L,1212672L,-8127488L,55318528L,-381329408L,2656845824L,-18680250368L,132373807104L,-944459216896L,6778991403008L,-48915734839296L,354636355665920L,-2582006464118784L,18870792427143168L,-138396900373037056L,1018196233480568832L,-7512565092559355904L };
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
public class A227295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227295Inst : IEnumerable<long>
{
public static readonly long[] Value=A227295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227295.Bytes);
public long this[int i]=>Value[i];

public static A227295Inst Instance=new A227295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227296
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,4L,14L,15L,26L,23L,55L,34L,100L,90L,146L,186L,296L,199L,489L,434L,725L,807L,1254L,919L,1946L,2063L,2943L,3036L,4564L,2462L,6841L,7665L,9871L,11098L,14744L,12384L,21636L,23928L,30677L,31603L,44582L,31570L,63260L,69414L,86420L,99795L,124753L };
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
public class A227296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227296Inst : IEnumerable<long>
{
public static readonly long[] Value=A227296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227296.Bytes);
public long this[int i]=>Value[i];

public static A227296Inst Instance=new A227296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227297
{
public static readonly long[] Value={ 12167L,5425069447L,11968683934831L,28821995554247L,48689748233307L };
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
public class A227297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227297Inst : IEnumerable<long>
{
public static readonly long[] Value=A227297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227297.Bytes);
public long this[int i]=>Value[i];

public static A227297Inst Instance=new A227297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227298
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,30L,56L,102L,186L,340L,624L,1148L };
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
public class A227298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227298Inst : IEnumerable<long>
{
public static readonly long[] Value=A227298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227298.Bytes);
public long this[int i]=>Value[i];

public static A227298Inst Instance=new A227298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227299
{
public static readonly long[] Value={ 6L,10L,14L,15L,18L,21L,28L,33L,36L,39L,45L,55L,60L,66L,68L,78L,91L,95L,105L,120L,136L,138L,150L,153L,171L,189L,190L,203L,210L,231L,248L,253L,264L,276L,300L,315L,325L,333L,351L,378L,390L,406L,410L,435L,465L,473L,495L,496L,528L,561L,564L,588L,595L,630L,663L,666L,689L,703L,741L,770L,780L,798L,820L,861L,885L };
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
public class A227299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227299Inst : IEnumerable<long>
{
public static readonly long[] Value=A227299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227299.Bytes);
public long this[int i]=>Value[i];

public static A227299Inst Instance=new A227299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227300
{
public static readonly long[] Value={ 1L,2L,2L,3L,7L,11L,16L,28L,48L,77L,126L,211L,349L,573L,947L,1568L,2588L,4271L,7058L,11661L,19256L,31804L,52538L,86779L,143329L,236744L,391046L,645900L,1066850L,1762163L,2910634L,4807590L,7940870L,13116238L,21664568L,35784145L,59105987L,97627533L,161254953L,266350689L };
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
public class A227300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227300Inst : IEnumerable<long>
{
public static readonly long[] Value=A227300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227300.Bytes);
public long this[int i]=>Value[i];

public static A227300Inst Instance=new A227300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227301
{
public static readonly BigInteger[] Value={ 0L,0L,121L,578937L,58407351059L,134528360800075421L,BigInteger.Parse("7015812452559988037073365"),BigInteger.Parse("8235314565328229497795808499821534"),BigInteger.Parse("216740797236120772990968348272561831275923059"),BigInteger.Parse("127557553423846099192878370706037904215158660401579043097") };
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
public class A227301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227301Inst Instance=new A227301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227302
{
public static readonly long[] Value={ 1L,3L,12L,14L,60L,248L,336L,2160L,2340L,4064L,13104L,15120L,16380L,261888L,1089270L,4455360L,8714160L,10213632L,11784960L,16775168L,22766400L,45981824L,71495424L,98532480L,229909120L,689727360L,738152448L,4291822080L,4294934528L,5100118016L,7091219520L };
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
public class A227302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227302Inst : IEnumerable<long>
{
public static readonly long[] Value=A227302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227302.Bytes);
public long this[int i]=>Value[i];

public static A227302Inst Instance=new A227302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227303
{
public static readonly long[] Value={ 1L,2L,4L,28L,40L,78L,90L,224L,360L,496L,546L,2016L,2184L,8128L,10080L,10920L,11880L,66528L,145236L,174592L,714240L,726180L,1571328L,4333056L,6168960L,7856640L,12065760L,15177600L,33550336L,47663616L,69521760L,80196480L,91963648L,99993600L,156854880L,459818240L,492101632L };
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
public class A227303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227303Inst : IEnumerable<long>
{
public static readonly long[] Value=A227303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227303.Bytes);
public long this[int i]=>Value[i];

public static A227303Inst Instance=new A227303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227304
{
public static readonly long[] Value={ 34L,55L,285L,367L,835L,849L,919L,1241L,1505L,2911L,2914L,3305L,4149L,4188L,6111L,6903L,7170L,7913L,8506L,9360L,10251L,10541L,12566L,15086L,17273L,17815L,19005L,19689L,21411L,21462L,24882L,25020L,25501L,26610L,28125L,30361L,30593L,30789L,31485L,37741L,38211L,38983L,39787L };
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
public class A227304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227304Inst : IEnumerable<long>
{
public static readonly long[] Value=A227304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227304.Bytes);
public long this[int i]=>Value[i];

public static A227304Inst Instance=new A227304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227305
{
public static readonly long[] Value={ 2L,3L,5L,6L,10L,19L,52L,118L,1054L,3201L,8586L,9802L,16120L,60556L,140698L,145216L,11273536L,29886160L,44868748L,8748377956L,325377469696L,2368739714188L };
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
public class A227305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227305Inst : IEnumerable<long>
{
public static readonly long[] Value=A227305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227305.Bytes);
public long this[int i]=>Value[i];

public static A227305Inst Instance=new A227305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227306
{
public static readonly long[] Value={ 2L,6L,34L,50L,216L,236L,262L,386L,898L,924L,945L,1456L,2380L,5356L,6468L,6624L,8362L,14100L,23496L,26938L,46594L,80876L,196344L,212796L,1661136L,4070200L,4160920L,4626700L,5244548L,5462384L,17062316L,60464628L,217408416L,248621604L,262792908L,265371336L,323987588L };
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
public class A227306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227306Inst : IEnumerable<long>
{
public static readonly long[] Value=A227306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227306.Bytes);
public long this[int i]=>Value[i];

public static A227306Inst Instance=new A227306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227307
{
public static readonly long[] Value={ 2L,6L,15L,19L,207L,958L,1335L,1365L,1635L,2686L,2975L,3201L,4365L,4536L,8586L,14842L,16120L,18874L,19359L,20146L,24958L,33999L,36567L,42819L,53580L,56565L,64666L,74919L,79827L,79834L,84135L,92686L,109215L,111507L,116938L,122074L,138238L,147455L,161002L,162603L,166935L };
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
public class A227307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227307Inst : IEnumerable<long>
{
public static readonly long[] Value=A227307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227307.Bytes);
public long this[int i]=>Value[i];

public static A227307Inst Instance=new A227307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227308
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,14L,18L,22L,26L,30L,34L,39L,44L,49L };
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
public class A227308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227308Inst : IEnumerable<long>
{
public static readonly long[] Value=A227308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227308.Bytes);
public long this[int i]=>Value[i];

public static A227308Inst Instance=new A227308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227309
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,10L,19L,34L,63L,115L,213L,391L,723L,1333L,2463L,4547L,8403L,15522L,28686L,53006L,97963L,181042L,334606L,618415L,1142994L,2112545L,3904592L,7216810L,13338856L,24654268L,45568784L,84225393L,155675230L,287737327L,531830605L,982993368L,1816887637L,3358192905L };
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
public class A227309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227309Inst : IEnumerable<long>
{
public static readonly long[] Value=A227309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227309.Bytes);
public long this[int i]=>Value[i];

public static A227309Inst Instance=new A227309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227310
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,2L,1L,1L,3L,2L,3L,4L,4L,6L,7L,8L,11L,13L,16L,20L,24L,31L,37L,46L,58L,70L,88L,108L,133L,167L,204L,252L,315L,386L,479L,594L,731L,909L,1122L,1386L,1720L,2124L,2628L,3254L,4022L,4980L,6160L,7618L,9432L,11665L,14433L,17860L,22093L,27341L,33824L,41847L,51785L,64065L,79267L };
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
public class A227310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227310Inst : IEnumerable<long>
{
public static readonly long[] Value=A227310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227310.Bytes);
public long this[int i]=>Value[i];

public static A227310Inst Instance=new A227310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227311
{
public static readonly long[] Value={ 2L,0L,-4L,0L,0L,8L,0L,8L,0L,-16L,0L,0L,-20L,0L,32L,0L,0L,0L,48L,0L,-64L,0L,0L,0L,0L,-112L,0L,128L,0L,0L,0L,-16L,0L,256L,0L,-256L,0L,0L,18L,0L,72L,0L,-576L,0L,512L,0L,0L,0L,-40L,0L,-240L,0L,1280L,0L,-1024L,0L,0L,0L,0L,88L,0L,704L,0L,-2816L,0L,2048L,0L,0L,0L,0L,0L,-160L,0L,-1920L,0L,6144L,0L,-4096L,0L,0L,0L,0L,-52L,0L,208L,0L,4992L,0L,-13312L,0L,8192L,0L,0L,0L,0L,0L,224L,0L,0L,0L,-12544L,0L,28672L,0L,-16384L,0L,0L,0L,0L,0L,0L,-720L,0L,-1280L,0L,30720L,0L,-61440L,0L,32768L,0L,0L,0L,32L,0L,0L,0L,1984L,0L,6144L,0L,-73728L,0L,131072L,0L,-65536L };
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
public class A227311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227311Inst : IEnumerable<long>
{
public static readonly long[] Value=A227311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227311.Bytes);
public long this[int i]=>Value[i];

public static A227311Inst Instance=new A227311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227312
{
public static readonly long[] Value={ 4L,-16L,64L,-224L,864L,-3328L,12800L,-49408L,190864L,-736896L,2845440L,-10987520L,42426752L,-163825664L,632592384L,-2442673664L,9432071040L,-36420732160L,140633977856L,-543040041984L,2096879372288L,-8096830353408L,31264870391808L,-120725281128448L,466165166208064L,-1800036911561216L,6950611323771904L };
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
public class A227312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227312Inst : IEnumerable<long>
{
public static readonly long[] Value=A227312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227312.Bytes);
public long this[int i]=>Value[i];

public static A227312Inst Instance=new A227312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227313
{
public static readonly long[] Value={ 4L,16L,64L,320L,1424L,6400L,28928L,131328L,599428L,2746176L,12627520L,58237952L,269284240L,1247921152L,5794490624L,26952340480L,125559053904L,585733448080L,2735853906496L,12793091964160L,59883014554112L,280568427766016L,1315670787139840L,6174463935221760L,28998036439469524L,136279914514165568L,640867368366269056L };
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
public class A227313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227313Inst : IEnumerable<long>
{
public static readonly long[] Value=A227313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227313.Bytes);
public long this[int i]=>Value[i];

public static A227313Inst Instance=new A227313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227314
{
public static readonly long[] Value={ 2L,2L,3L,3L,1L,2L,3L,3L,2L,5L,4L,3L,3L,1L,6L,4L,1L,2L,2L,1L,6L,3L,2L,2L,2L,3L,2L,4L,4L,2L,2L,3L,8L,3L,1L,1L,1L,3L,2L,2L,2L,2L,1L,2L,3L,2L,1L,1L,3L,3L,4L,2L,1L,1L,3L,7L,7L,3L,2L,4L,4L,2L,1L,1L,2L,4L,2L,1L,3L,4L,4L,3L,1L,1L,1L,2L,5L,2L,3L,6L,2L,2L,3L,6L,5L,1L,5L,3L,2L,3L,2L,6L,7L,2L,2L,2L,6L,3L,2L,3L };
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
public class A227314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227314Inst : IEnumerable<long>
{
public static readonly long[] Value=A227314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227314.Bytes);
public long this[int i]=>Value[i];

public static A227314Inst Instance=new A227314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227315
{
public static readonly long[] Value={ 1L,2L,-2L,4L,-6L,20L,-60L,184L,-586L,1908L,-6284L,21032L,-71260L,243928L,-842456L,2931984L,-10272586L,36203996L,-128262540L,456526584L,-1631731284L,5854243512L,-21075615496L,76110581584L,-275644817124L,1000906315656L,-3643229263480L,13290759624336L,-48586176336056L,177955767765936L,-652966762175152L };
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
public class A227315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227315Inst : IEnumerable<long>
{
public static readonly long[] Value=A227315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227315.Bytes);
public long this[int i]=>Value[i];

public static A227315Inst Instance=new A227315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227316
{
public static readonly long[] Value={ 0L,2L,3L,6L,20L,30L,21L,28L,72L,90L,55L,66L,156L,182L,105L,120L,272L,306L,171L,190L,420L,462L,253L,276L,600L,650L,351L,378L,812L,870L,465L,496L,1056L,1122L,595L,630L,1332L,1406L,741L,780L,1640L,1722L,903L,946L,1980L,2070L,1081L,1128L };
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
public class A227316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227316Inst : IEnumerable<long>
{
public static readonly long[] Value=A227316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227316.Bytes);
public long this[int i]=>Value[i];

public static A227316Inst Instance=new A227316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227317
{
public static readonly long[] Value={ 1L,2L,-5L,-10L,5L,6L,10L,40L,-20L,-50L,19L,-52L,-30L,50L,-25L,74L,97L,50L,-25L,-140L,69L,-34L,-100L,-50L,-185L,-6L,83L,310L,-60L,-60L,410L,-128L,145L,-100L,-245L,250L,-87L,-90L,-400L,-410L,-151L,362L,185L,-50L,285L,30L,150L,-240L,500L,370L,-68L,222L,5L,-190L };
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
public class A227317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227317Inst : IEnumerable<long>
{
public static readonly long[] Value=A227317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227317.Bytes);
public long this[int i]=>Value[i];

public static A227317Inst Instance=new A227317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227318
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,-1L,2L,0L,1L,-2L,4L,-1L,1L,-1L,2L,0L,1L,-3L,7L,-4L,2L,-1L,2L,0L,1L,-2L,4L,-1L,1L,-1L,2L,0L,1L,-4L,11L,-10L,6L,-2L,2L,0L,1L,-2L,4L,-1L,1L,-1L,2L,0L,1L,-3L,7L,-4L,2L,-1L,2L,0L,1L,-2L,4L,-1L,1L,-1L,2L,0L,1L,-5L,16L,-20L,16L,-7L,3L,0L,1L,-2L,4L,-1L,1L,-1L,2L,0L,1L,-3L,7L,-4L,2L,-1L,2L,0L,1L,-2L,4L,-1L,1L,-1L,2L,0L,1L,-4L,11L,-10L,6L,-2L,2L,0L,1L,-2L,4L,-1L,1L,-1L,2L,0L,1L,-3L,7L,-4L,2L,-1L,2L,0L,1L,-2L,4L,-1L,1L,-1L,2L,0L,1L };
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
public class A227318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227318Inst : IEnumerable<long>
{
public static readonly long[] Value=A227318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227318.Bytes);
public long this[int i]=>Value[i];

public static A227318Inst Instance=new A227318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227319
{
public static readonly long[] Value={ 8L,243L,128L,216L,12167L,1906624L,6859L,226981L,3125L,12167L,1252726552L,325660672L,1331L,19902511000L,32768L,537824L,69934528000L,704969L,39304L,42875L,50653L,751089429L,79507L,314432L,21952L,22665187L,47437928L,1605723211L,10648L,287496L,5177717L,7414875L };
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
public class A227319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227319Inst : IEnumerable<long>
{
public static readonly long[] Value=A227319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227319.Bytes);
public long this[int i]=>Value[i];

public static A227319Inst Instance=new A227319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227320
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,0L,1L,7L,2L,6L,1L,2L,1L,4L,7L,15L,1L,15L,1L,8L,5L,8L,1L,6L,4L,14L,11L,14L,1L,6L,1L,31L,9L,18L,3L,21L,1L,16L,15L,20L,1L,26L,1L,26L,1L,20L,1L,14L,6L,21L,19L,16L,1L,6L,15L,26L,17L,30L,1L,4L,1L,28L,25L,63L,9L,58L,1L,52L,21L,38L,1L,33L,1L,38L,17L,50L,13L,54L,1L };
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
public class A227320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227320Inst : IEnumerable<long>
{
public static readonly long[] Value=A227320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227320.Bytes);
public long this[int i]=>Value[i];

public static A227320Inst Instance=new A227320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227321
{
public static readonly long[] Value={ 3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,5L,3L,8L,3L,3L,4L,5L,3L,11L,3L,3L,3L,5L,4L,3L,10L,3L,3L,11L,3L,17L,4L,3L,5L,3L,3L,7L,14L,3L,4L,15L,3L,23L,3L,3L,5L,11L,4L,3L,5L,5L,3L,19L,3L,3L,3L,8L,5L,21L,3L,32L,14L,3L,4L,3L,3L,15L,3L,5L,5L,25L,3L,38L,7L,3L,6L,3L,3L,13L,4L,3L };
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
public class A227321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227321Inst : IEnumerable<long>
{
public static readonly long[] Value=A227321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227321.Bytes);
public long this[int i]=>Value[i];

public static A227321Inst Instance=new A227321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227322
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,5L,0L,1L,19L,205L,0L,1L,65L,1795L,36317L,0L,1L,211L,14221L,636331L,23679901L,0L,1L,665L,106819L,10365005L,805351531L,56294206205L,0L,1L,2059L,778765L,162470155L,26175881341L,3735873535339L,502757743028605L };
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
public class A227322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227322Inst : IEnumerable<long>
{
public static readonly long[] Value=A227322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227322.Bytes);
public long this[int i]=>Value[i];

public static A227322Inst Instance=new A227322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227323
{
public static readonly long[] Value={ 11L,1039L,2099L,4253L,9433L,9437L,62983L,62987L,72229L,72251L,91121L,386401L,392269L,392279L,495589L,495611L,626617L,663583L,663587L,754973L,873553L,908857L,909301L,909317L,909319L,909329L,972137L,1006309L,1006331L,1138393L,1138409L,1159201L };
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
public class A227323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227323Inst : IEnumerable<long>
{
public static readonly long[] Value=A227323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227323.Bytes);
public long this[int i]=>Value[i];

public static A227323Inst Instance=new A227323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227324
{
public static readonly long[] Value={ 1L,9L,4L,3L,49L,36L,25L,81L,2L,441L,169L,12L,121L,225L,196L,27L,361L,18L,289L,147L,100L,1521L,841L,324L,7L,1089L,16L,75L,529L,1764L,1369L,729L,676L,3249L,1225L,6L,961L,2601L,484L,3969L,1849L,900L,1681L,507L,98L,7569L,2809L,108L,5L,63L,1444L,363L,2209L,144L };
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
public class A227324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227324Inst : IEnumerable<long>
{
public static readonly long[] Value=A227324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227324.Bytes);
public long this[int i]=>Value[i];

public static A227324Inst Instance=new A227324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227325
{
public static readonly BigInteger[] Value={ 1L,2L,18L,320L,8750L,326592L,15529668L,899678208L,61556811030L,4862000000000L,435644983598396L,43678490079264768L,4846281282497517772L,BigInteger.Parse("589650705050503577600"),BigInteger.Parse("78074729079345703125000"),BigInteger.Parse("11177395284330167371038720"),BigInteger.Parse("1720546364146510165684599270") };
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
public class A227325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227325Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227325.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227325.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227325Inst Instance=new A227325Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227326
{
public static readonly long[] Value={ 0L,2L,8L,8L,32L,32L,80L,128L,320L,512L,1088L,2048L,4256L,8192L,16640L,32768L,66176L,131072L,263168L,524288L,1050752L,2097152L,4198400L,8388608L,16785728L,33554432L,67125248L,134217728L,268468736L,536870912L,1073807360L,2147483648L,4295099648L,8589934592L };
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
public class A227326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227326Inst : IEnumerable<long>
{
public static readonly long[] Value=A227326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227326.Bytes);
public long this[int i]=>Value[i];

public static A227326Inst Instance=new A227326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227327
{
public static readonly long[] Value={ 0L,1L,4L,10L,22L,41L,72L,116L,180L,265L,380L,526L,714L,945L,1232L,1576L,1992L,2481L,3060L,3730L,4510L,5401L,6424L,7580L,8892L,10361L,12012L,13846L,15890L,18145L,20640L,23376L,26384L,29665L,33252L,37146L,41382L,45961L,50920L,56260L,62020L,68201L,74844L };
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
public class A227327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227327Inst : IEnumerable<long>
{
public static readonly long[] Value=A227327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227327.Bytes);
public long this[int i]=>Value[i];

public static A227327Inst Instance=new A227327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227328
{
public static readonly long[] Value={ 2L,11L,153L,4917L,366606L,66730314L,31357593706L };
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
public class A227328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227328Inst : IEnumerable<long>
{
public static readonly long[] Value=A227328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227328.Bytes);
public long this[int i]=>Value[i];

public static A227328Inst Instance=new A227328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227329
{
public static readonly long[] Value={ 4L,11L,34L,104L,285L,683L,1469L,2906L,5383L,9457L,15904L,25780L,40493L,61887L,92339L,134870L,193271L,272245L,377566L,516256L,696781L,929267L,1225737L,1600370L,2069783L,2653337L,3373468L,4256044L,5330749L,6631495L,8196863L,10070574L };
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
public class A227329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227329Inst : IEnumerable<long>
{
public static readonly long[] Value=A227329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227329.Bytes);
public long this[int i]=>Value[i];

public static A227329Inst Instance=new A227329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227330
{
public static readonly long[] Value={ 8L,34L,153L,708L,3013L,11292L,37312L,110816L,301923L,766340L,1832683L,4164473L,9050350L,18908103L,38136118L,74516301L,141474093L,261645212L,472399946L,834253036L,1443464344L,2450642643L,4087839408L,6707507638L,10837859135L };
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
public class A227330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227330Inst : IEnumerable<long>
{
public static readonly long[] Value=A227330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227330.Bytes);
public long this[int i]=>Value[i];

public static A227330Inst Instance=new A227330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227331
{
public static readonly long[] Value={ 15L,104L,708L,4917L,33297L,204206L,1108382L,5361624L,23477312L,94474684L,353596604L,1242207201L,4125406694L,13026205724L,39292608858L,113681479364L,316556625809L,850933663116L,2213918991347L,5587988935294L,13711077238915L };
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
public class A227331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227331Inst : IEnumerable<long>
{
public static readonly long[] Value=A227331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227331.Bytes);
public long this[int i]=>Value[i];

public static A227331Inst Instance=new A227331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227332
{
public static readonly long[] Value={ 26L,285L,3013L,33297L,366606L,3774137L,35026386L,290742258L,2174611745L,14827903973L,93194118189L,544831575434L,2984722060733L,15415176834304L,75441255758231L,351377507165460L,1563422116701546L,6667161613820532L };
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
public class A227332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227332Inst : IEnumerable<long>
{
public static readonly long[] Value=A227332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227332.Bytes);
public long this[int i]=>Value[i];

public static A227332Inst Instance=new A227332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227333
{
public static readonly long[] Value={ 2L,4L,4L,8L,11L,8L,15L,34L,34L,15L,26L,104L,153L,104L,26L,42L,285L,708L,708L,285L,42L,64L,683L,3013L,4917L,3013L,683L,64L,93L,1469L,11292L,33297L,33297L,11292L,1469L,93L,130L,2906L,37312L,204206L,366606L,204206L,37312L,2906L,130L,176L,5383L,110816L,1108382L };
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
public class A227333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227333Inst : IEnumerable<long>
{
public static readonly long[] Value=A227333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227333.Bytes);
public long this[int i]=>Value[i];

public static A227333Inst Instance=new A227333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227334
{
public static readonly long[] Value={ 1L,2L,8L,4L,4L,8L,48L,4L,24L,4L,120L,8L,12L,48L,8L,8L,16L,24L,360L,4L,48L,120L,528L,8L,20L,12L,72L,48L,28L,8L,960L,16L,120L,16L,48L,24L,36L,360L,24L,4L,40L,48L,1848L,120L,24L,528L,2208L,8L,336L,20L,16L,12L,52L,72L,120L,48L,360L,28L,3480L,8L,60L,960L,48L,32L };
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
public class A227334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227334Inst : IEnumerable<long>
{
public static readonly long[] Value=A227334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227334.Bytes);
public long this[int i]=>Value[i];

public static A227334Inst Instance=new A227334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227335
{
public static readonly long[] Value={ 3L,5L,17L,83L,337L,659L,2621L,1801L,24113L,24113L,503227L,894637L,9903149L,4317193L,11012317L,235397039L,8516934067L,14990671117L,6955703129L,52600764283L,6955703129L,2700022855487L,4659851923081L,6485648067251L,10643798564411L };
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
public class A227335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227335Inst : IEnumerable<long>
{
public static readonly long[] Value=A227335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227335.Bytes);
public long this[int i]=>Value[i];

public static A227335Inst Instance=new A227335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227336
{
public static readonly long[] Value={ 3L,7L,7L,0L,7L,8L,4L,2L,5L,3L,5L,3L,7L,4L,2L,9L,4L,5L,5L,0L,5L,4L,4L,2L,1L,6L,1L,3L,7L,0L,5L,4L,2L,2L,0L,4L,4L,0L,5L,0L,4L,5L,1L,9L,1L,7L,0L,5L,6L,7L,8L,7L,0L,1L,0L,4L,7L,6L,2L,2L,8L,9L,9L,8L,0L,4L,2L,2L,7L,2L,5L,9L,4L,8L,8L,8L,0L,0L,8L,2L,3L,1L,1L,6L,3L,3L,8L,0L,1L,1L,5L,5L,2L,0L,9L,6L,1L,9L,8L,1L,6L,7L,5L,9L,8L };
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
public class A227336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227336Inst : IEnumerable<long>
{
public static readonly long[] Value=A227336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227336.Bytes);
public long this[int i]=>Value[i];

public static A227336Inst Instance=new A227336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227337
{
public static readonly BigInteger[] Value={ 2L,20L,220L,5980L,173420L,8150740L,431989220L,25487363980L,1707653386660L,742559959944940L,79453915714108580L,10090647295691789660UL,BigInteger.Parse("1757620212758033277820"),BigInteger.Parse("286492094679559424284660"),BigInteger.Parse("47844179811486423855538220") };
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
public class A227337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A227337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A227337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A227337Inst Instance=new A227337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227338
{
public static readonly long[] Value={ 1L,4L,1L,12L,8L,1L,44L,40L,12L,1L,172L,176L,84L,16L,1L,772L,748L,468L,144L,20L,1L,3308L,3248L,2332L,984L,220L,24L,1L,14924L,14280L,11068L,5756L,1788L,312L,28L,1L,64956L,63768L,51472L,30760L,12108L,2944L,420L,32L,1L,294252L,285296L,237832L,155912L,72948L,22732L,4516L };
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
public class A227338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227338Inst : IEnumerable<long>
{
public static readonly long[] Value=A227338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227338.Bytes);
public long this[int i]=>Value[i];

public static A227338Inst Instance=new A227338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227339
{
public static readonly long[] Value={ 1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,3L,1L,2L,1L,3L,1L,2L,1L };
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
public class A227339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227339Inst : IEnumerable<long>
{
public static readonly long[] Value=A227339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227339.Bytes);
public long this[int i]=>Value[i];

public static A227339Inst Instance=new A227339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227340
{
public static readonly long[] Value={ 73L,457L,1801L,3049L,3529L,4057L,8209L,10369L,19609L,20809L,33289L,41521L,51217L,84121L,103969L,111409L,115201L,121081L,129049L,141529L,150169L,155689L,180097L,223129L,282769L,308929L,342841L,397849L,426889L,432457L,627217L,649801L,658969L,710449L,729649L };
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
public class A227340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227340Inst : IEnumerable<long>
{
public static readonly long[] Value=A227340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227340.Bytes);
public long this[int i]=>Value[i];

public static A227340Inst Instance=new A227340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227341
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,0L,2L,4L,1L,0L,2L,10L,7L,1L,0L,2L,22L,31L,11L,1L,0L,2L,46L,115L,75L,16L,1L,0L,2L,94L,391L,415L,155L,22L,1L,0L,2L,190L,1267L,2051L,1190L,287L,29L,1L,0L,2L,382L,3991L,9471L,8001L,2912L,490L,37L,1L,0L,2L,766L,12355L,41875L,49476L,25473L,6342L,786L,46L,1L };
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
public class A227341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227341Inst : IEnumerable<long>
{
public static readonly long[] Value=A227341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227341.Bytes);
public long this[int i]=>Value[i];

public static A227341Inst Instance=new A227341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227342
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-3L,1L,0L,5L,-6L,1L,0L,-14L,23L,-10L,1L,0L,54L,-105L,65L,-15L,1L,0L,-264L,574L,-435L,145L,-21L,1L,0L,1560L,-3682L,3199L,-1330L,280L,-28L,1L,0L,-10800L,27180L,-26124L,12649L,-3360L,490L,-36L,1L,0L,85680L,-227196L,236312L,-128205L,40089L,-7434L,798L,-45L,1L };
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
public class A227342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227342Inst : IEnumerable<long>
{
public static readonly long[] Value=A227342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227342.Bytes);
public long this[int i]=>Value[i];

public static A227342Inst Instance=new A227342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227343
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,13L,13L,6L,1L,75L,75L,37L,10L,1L,541L,541L,270L,85L,15L,1L,4683L,4683L,2341L,770L,170L,21L,1L,47293L,47293L,23646L,7861L,1890L,308L,28L,1L,545835L,545835L,272917L,90930L,22491L,4158L,518L,36L,1L,7087261L,7087261L,3543630L,1181125L,294525L,57351L,8400L,822L,45L,1L };
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
public class A227343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227343Inst : IEnumerable<long>
{
public static readonly long[] Value=A227343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227343.Bytes);
public long this[int i]=>Value[i];

public static A227343Inst Instance=new A227343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227344
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,3L,0L,0L,0L,1L,0L,3L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,1L,0L,0L,7L,0L,0L,0L,0L,1L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,11L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,13L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,16L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,20L,0L };
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
public class A227344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227344Inst : IEnumerable<long>
{
public static readonly long[] Value=A227344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227344.Bytes);
public long this[int i]=>Value[i];

public static A227344Inst Instance=new A227344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227345
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,2L,0L,0L,0L,1L,3L,0L,0L,0L,0L,1L,3L,1L,0L,0L,0L,0L,1L,3L,2L,0L,0L,0L,0L,0L,1L,5L,2L,0L,0L,0L,0L,0L,0L,1L,5L,4L,0L,0L,0L,0L,0L,0L,0L,1L,5L,6L,0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,7L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,10L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,7L,11L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,9L,13L,4L,0L };
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
public class A227345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227345Inst : IEnumerable<long>
{
public static readonly long[] Value=A227345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227345.Bytes);
public long this[int i]=>Value[i];

public static A227345Inst Instance=new A227345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227346
{
public static readonly long[] Value={ 2L,4L,2L,4L,6L,8L,6L,4L,6L,6L,8L,6L,6L,10L,14L,4L,2L,4L,24L,20L,6L,10L,6L,18L,2L,30L,4L,6L,18L,6L,6L,8L,6L,30L,4L,20L,16L,6L,14L,6L,10L,50L,10L,14L,4L,42L,38L,16L,6L,8L,16L,6L,8L,6L,6L,28L,6L,6L,24L,50L,6L,18L,70L,2L,30L,4L,20L,4L,60L,6L,24L,6L,14L,22L,20L,30L };
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
public class A227346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227346Inst : IEnumerable<long>
{
public static readonly long[] Value=A227346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227346.Bytes);
public long this[int i]=>Value[i];

public static A227346Inst Instance=new A227346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227347
{
public static readonly long[] Value={ 0L,3L,10L,23L,43L,73L,113L,166L,233L,316L,416L,536L,676L,839L,1026L,1239L,1479L,1749L,2049L,2382L,2749L,3152L,3592L,4072L,4592L,5155L,5762L,6415L,7115L,7865L,8665L,9518L,10425L,11388L,12408L,13488L,14628L,15831L,17098L,18431L,19831L,21301L,22841L,24454L };
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
public class A227347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227347Inst : IEnumerable<long>
{
public static readonly long[] Value=A227347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227347.Bytes);
public long this[int i]=>Value[i];

public static A227347Inst Instance=new A227347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227348
{
public static readonly long[] Value={ 26999L,122499L,193599L,599975L,2206775L,2620175L,3501575L,4798079L,8278599L,11631059L,14242175L,16956575L,17578799L,19048799L,49061375L,55504175L,57354725L,70963775L,75271559L,107499699L,114930639L,153536525L,165887189L,202729175L,241430399L,248688719L,257552735L,258969887L,275089919L };
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
public class A227348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227348Inst : IEnumerable<long>
{
public static readonly long[] Value=A227348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227348.Bytes);
public long this[int i]=>Value[i];

public static A227348Inst Instance=new A227348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227349
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,4L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,2L,4L,3L,3L,4L,5L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,4L,2L,2L,2L,4L,2L,2L,4L,6L,3L,3L,3L,6L,4L,4L,5L,6L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,4L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,2L,4L,3L,3L,4L,5L,2L,2L,2L,4L,2L,2L,4L,6L,2L,2L,2L,4L,4L,4L,6L,8L,3L,3L,3L,6L,3L,3L,6L,9L,4L };
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
public class A227349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227349Inst : IEnumerable<long>
{
public static readonly long[] Value=A227349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227349.Bytes);
public long this[int i]=>Value[i];

public static A227349Inst Instance=new A227349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227350
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,4L,3L,2L,2L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,5L,4L,3L,3L,4L,2L,2L,2L,3L,2L,1L,1L,2L,1L,1L,1L,4L,3L,2L,2L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,6L,5L,4L,4L,6L,3L,3L,3L,6L,4L,2L,2L,4L,2L,2L,2L,4L,3L,2L,2L,2L,1L,1L };
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
public class A227350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227350Inst : IEnumerable<long>
{
public static readonly long[] Value=A227350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227350.Bytes);
public long this[int i]=>Value[i];

public static A227350Inst Instance=new A227350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227351
{
public static readonly long[] Value={ 0L,1L,3L,7L,2L,15L,6L,4L,31L,14L,12L,8L,5L,63L,30L,28L,24L,13L,16L,9L,11L,127L,62L,60L,56L,29L,48L,25L,27L,32L,17L,19L,23L,10L,255L,126L,124L,120L,61L,112L,57L,59L,96L,49L,51L,55L,26L,64L,33L,35L,39L,18L,47L,22L,20L,511L,254L,252L,248L,125L,240L,121L,123L,224L };
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
public class A227351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227351Inst : IEnumerable<long>
{
public static readonly long[] Value=A227351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227351.Bytes);
public long this[int i]=>Value[i];

public static A227351Inst Instance=new A227351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227352
{
public static readonly long[] Value={ 0L,1L,4L,2L,7L,12L,6L,3L,11L,19L,33L,20L,10L,17L,9L,5L,18L,30L,51L,31L,54L,88L,53L,32L,16L,27L,46L,28L,15L,25L,14L,8L,29L,48L,80L,49L,83L,135L,82L,50L,87L,142L,232L,143L,86L,140L,85L,52L,26L,43L,72L,44L,75L,122L,74L,45L,24L,40L,67L,41L,23L,38L,22L,13L,47L,77L };
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
public class A227352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227352Inst : IEnumerable<long>
{
public static readonly long[] Value=A227352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227352.Bytes);
public long this[int i]=>Value[i];

public static A227352Inst Instance=new A227352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227353
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,10L,14L,18L,23L,29L,35L,42L,49L,57L,66L,75L,85L,95L,106L,118L,130L,143L,156L,170L,185L,200L,216L,232L,249L,267L,285L,304L,323L,343L,364L,385L,407L,429L,452L,476L,500L,525L,550L,576L,603L,630L,658L,686L,715L,745L,775L,806L,837L,869L,902L,935L };
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
public class A227353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227353Inst : IEnumerable<long>
{
public static readonly long[] Value=A227353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227353.Bytes);
public long this[int i]=>Value[i];

public static A227353Inst Instance=new A227353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227354
{
public static readonly long[] Value={ 1L,12L,-6L,12L,12L,0L,-6L,24L,-6L,12L,0L,0L,12L,24L,-12L,0L,12L,0L,-6L,24L,0L,24L,0L,0L,-6L,12L,-12L,12L,24L,0L,0L,24L,-6L,0L,0L,0L,12L,24L,-12L,24L,0L,0L,-12L,24L,0L,0L,0L,0L,12L,36L,-6L,0L,24L,0L,-6L,0L,-12L,24L,0L,0L,0L,24L,-12L,24L,12L,0L,0L,24L,0L,0L,0L };
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
public class A227354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227354Inst : IEnumerable<long>
{
public static readonly long[] Value=A227354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227354.Bytes);
public long this[int i]=>Value[i];

public static A227354Inst Instance=new A227354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227355
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,2L,1L,5L,4L,3L,4L,2L,3L,2L,1L,6L,5L,4L,6L,3L,6L,4L,2L,4L,3L,2L,2L,1L,7L,6L,5L,8L,4L,9L,6L,3L,8L,6L,4L,4L,2L,5L,4L,3L,4L,2L,3L,2L,1L,8L,7L,6L,10L,5L,12L,8L,4L,12L,9L,6L,6L,3L,10L,8L,6L,8L,4L,6L,4L,2L,6L,5L,4L,6L,3L,6L,4L,2L,4L,3L };
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
public class A227355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227355Inst : IEnumerable<long>
{
public static readonly long[] Value=A227355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227355.Bytes);
public long this[int i]=>Value[i];

public static A227355Inst Instance=new A227355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A227356
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,36L,65L,112L,193L,324L,544L,900L,1489L,2442L,4005L,6534L,10660L,17336L,28193L,45760L,74273L,120408L,195200L,316216L,512257L,829458L,1343077L,2174130L,3519412L,5696124L,9219105L,14919408L,24144289L };
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
public class A227356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A227356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A227356Inst : IEnumerable<long>
{
public static readonly long[] Value=A227356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A227356.Bytes);
public long this[int i]=>Value[i];

public static A227356Inst Instance=new A227356Inst();

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