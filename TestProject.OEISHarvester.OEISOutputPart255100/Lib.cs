using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A131514
{
public static readonly long[] Value={ 1L,1L,1L,15L,1L,71L,1L,280L,15L,71L,1L,3660L,1L,71L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131514Inst : IEnumerable<long>
{
public static readonly long[] Value=A131514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131514.Bytes);
public long this[int i]=>Value[i];

public static A131514Inst Instance=new A131514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131515
{
public static readonly BigInteger[] Value={ 1L,16L,545L,18516L,629001L,21367520L,725866681L,24658099636L,837649520945L,28455425612496L,966646821303921L,32837536498720820L,1115509594135203961L,BigInteger.Parse("37894488664098213856"),BigInteger.Parse("1287297104985204067145"),BigInteger.Parse("43730207080832840069076"),BigInteger.Parse("1485539743643331358281441") };
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
public class A131515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131515Inst Instance=new A131515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131516
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,1L,6L,1L,8L,9L,10L,1L,12L,1L,14L,15L,16L,1L,18L,1L,20L,21L,22L,1L,24L,25L,26L,27L,28L,1L,30L,1L,32L,33L,34L,35L,36L,1L,38L,39L,40L,1L,42L,1L,44L,45L,46L,1L,48L,49L,50L,51L,52L,1L,54L,55L,56L,57L,58L,1L,60L,1L,62L,63L,64L,65L,66L,1L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131516Inst : IEnumerable<long>
{
public static readonly long[] Value=A131516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131516.Bytes);
public long this[int i]=>Value[i];

public static A131516Inst Instance=new A131516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131517
{
public static readonly long[] Value={ 1L,4L,8L,11L,4L,8L,11L,1L,8L,11L,1L,4L,11L,3L,6L,10L,4L,8L,11L,1L,8L,11L,1L,4L,11L,3L,6L,10L,1L,4L,8L,11L,8L,11L,1L,4L,11L,3L,6L,10L,1L,4L,8L,11L,4L,8L,11L,1L,11L,3L,6L,10L,3L,6L,10L,11L,6L,10L,1L,5L,10L,11L,3L,6L,4L,8L,11L,1L,8L,11L,1L,4L,11L,3L,6L,10L,1L,4L,8L,11L,8L,11L,1L,4L,11L,3L,6L,10L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131517Inst : IEnumerable<long>
{
public static readonly long[] Value=A131517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131517.Bytes);
public long this[int i]=>Value[i];

public static A131517Inst Instance=new A131517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131518
{
public static readonly BigInteger[] Value={ 2L,6L,14L,122L,362L,5282L,20582L,397154L,2027090L,46177922L,303147902L,7699478162L,63517159994L,1745540360930L,17676592058582L,517137940132802L,6290714838241442L,194139271606482434L,2782486941099788270L,BigInteger.Parse("90105513853333901042"),BigInteger.Parse("1495993248737211995402"),BigInteger.Parse("50671468195931300884322") };
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
public class A131518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131518Inst Instance=new A131518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131519
{
public static readonly BigInteger[] Value={ 1L,6L,66L,714L,7710L,83226L,898350L,9696810L,104667486L,1129781946L,12194877966L,131631637962L,1420833250878L,15336488688474L,165542216262126L,1786864380862314L,19287432460962078L,208188743880291834L,2247191437542514638L,BigInteger.Parse("24256207433904571146"),BigInteger.Parse("261821751919823278590") };
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
public class A131519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131519Inst Instance=new A131519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131520
{
public static readonly long[] Value={ 2L,6L,12L,22L,40L,74L,140L,270L,528L,1042L,2068L,4118L,8216L,16410L,32796L,65566L,131104L,262178L,524324L,1048614L,2097192L,4194346L,8388652L,16777262L,33554480L,67108914L,134217780L,268435510L,536870968L,1073741882L,2147483708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131520Inst : IEnumerable<long>
{
public static readonly long[] Value=A131520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131520.Bytes);
public long this[int i]=>Value[i];

public static A131520Inst Instance=new A131520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131521
{
public static readonly BigInteger[] Value={ 1L,10L,190L,4420L,113950L,3128140L,89608780L,2647358920L,80065458910L,2466432898300L,77115832253380L,2440820453410360L,78053018025315340L,2517915855707814520L,BigInteger.Parse("81839894422876183000"),BigInteger.Parse("2677554649095487584400") };
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
public class A131521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131521Inst Instance=new A131521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131522
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,0L,-1L,-1L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131522Inst : IEnumerable<long>
{
public static readonly long[] Value=A131522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131522.Bytes);
public long this[int i]=>Value[i];

public static A131522Inst Instance=new A131522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131523
{
public static readonly long[] Value={ 2498L,8571L,9995L,9998L,11241L,11371L,11379L,11398L,11669L,11994L,12353L,14285L,14997L,14998L,15009L,17122L,19146L,19996L,21058L,21079L,21131L,21372L,22122L,22413L,22564L,22856L,23317L,24006L,24293L,24982L,24994L,24995L,25006L,26672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131523Inst : IEnumerable<long>
{
public static readonly long[] Value=A131523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131523.Bytes);
public long this[int i]=>Value[i];

public static A131523Inst Instance=new A131523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131524
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,4L,4L,7L,7L,12L,12L,20L,20L,33L,33L,54L,54L,88L,88L,143L,143L,232L,232L,376L,376L,609L,609L,986L,986L,1596L,1596L,2583L,2583L,4180L,4180L,6764L,6764L,10945L,10945L,17710L,17710L,28656L,28656L,46367L,46367L,75024L,75024L,121392L,121392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131524Inst : IEnumerable<long>
{
public static readonly long[] Value=A131524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131524.Bytes);
public long this[int i]=>Value[i];

public static A131524Inst Instance=new A131524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131525
{
public static readonly BigInteger[] Value={ 1L,2L,13L,371L,17389L,1369057L,168362459L,28396593031L,6237698137129L,1823043651343241L,654314519766396223L,BigInteger.Parse("288203550242534470051"),BigInteger.Parse("151792464548141462268029"),BigInteger.Parse("95104739612472479469277141"),BigInteger.Parse("68849533918239714802762113739"),BigInteger.Parse("58193958459903387205593351715847") };
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
public class A131525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131525Inst Instance=new A131525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131526
{
public static readonly BigInteger[] Value={ 1L,1L,0L,3L,11L,40L,184L,1036L,12949L,88488L,807008L,7362586L,113572183L,1238477032L,15630890560L,228998728050L,4141605806441L,62222251093216L,1030119451142656L,19050688698470434L,412037845709792107L,8102391640556570616L,BigInteger.Parse("165794307361686866432") };
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
public class A131526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131526Inst Instance=new A131526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131527
{
public static readonly long[] Value={ 1152L,4235L,51072L,1844766L,67267200L,1489787937L,20516082048L,194830108540L,1389727430784L,7923082634775L,37759956198272L,155476758621786L,566979054415488L,1866434208254637L,5629739963760000L,15745829707255032L,41231732634193024L,101887952581305891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131527Inst : IEnumerable<long>
{
public static readonly long[] Value=A131527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131527.Bytes);
public long this[int i]=>Value[i];

public static A131527Inst Instance=new A131527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131656
{
public static readonly BigInteger[] Value={ -1L,3L,0L,3L,5L,18L,66L,298L,1511L,8670L,55168L,386394L,2951673L,24428654L,217723390L,2079109386L,21177620171L,229195610430L,2626388037372L,31768201320634L,404485298533085L,5407570127090958L,75736453324821754L,1108952444876609898L,16943545270848408495UL };
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
public class A131656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131656Inst Instance=new A131656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131657
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,36L,36L,144L,144L,1440L,1440L,17280L,17280L,241920L,3628800L,29030400L,29030400L,1567641600L,1567641600L,783820800000L,9876142080000L,651825377280000L,217275125760000L,8691005030400000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131657Inst : IEnumerable<long>
{
public static readonly long[] Value=A131657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131657.Bytes);
public long this[int i]=>Value[i];

public static A131657Inst Instance=new A131657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131658
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,36L,36L,144L,144L,1440L,1440L,17280L,17280L,241920L,3628800L,29030400L,29030400L,1567641600L,1567641600L,156764160000L,49380710400000L,217275125760000L,1086375628800000L,1738201006080000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131658Inst : IEnumerable<long>
{
public static readonly long[] Value=A131658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131658.Bytes);
public long this[int i]=>Value[i];

public static A131658Inst Instance=new A131658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131659
{
public static readonly long[] Value={ 2L,2L,8L,9L,4L,5L,9L,7L,7L,1L,6L,9L,8L,8L,0L,0L,3L,4L,8L,2L,8L,6L,8L,5L,4L,7L,0L,2L,7L,0L,6L,1L,1L,7L,4L,2L,3L,2L,9L,4L,5L,8L,9L,6L,2L,5L,8L,3L,0L,6L,2L,3L,1L,4L,3L,0L,2L,7L,2L,4L,6L,1L,4L,2L,9L,4L,4L,2L,7L,5L,5L,3L,9L,7L,6L,9L,6L,5L,2L,1L,5L,9L,5L,6L,7L,2L,4L,6L,5L,4L,0L,5L,5L,0L,9L,7L,9L,4L,1L,5L,4L,0L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131659Inst : IEnumerable<long>
{
public static readonly long[] Value=A131659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131659.Bytes);
public long this[int i]=>Value[i];

public static A131659Inst Instance=new A131659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131660
{
public static readonly long[] Value={ 218L,241L,264L,269L,280L,287L,354L,1159L,1836L,1871L,1872L,1886L,1891L,1892L,1914L,5023L,5026L,5039L,9165L,9170L,9171L,9180L,15166L,17909L,91192L,91194L,91277L,91289L,91290L,91293L,92029L,92031L,92033L,92038L,93913L,93927L,93928L,97369L,97839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131660Inst : IEnumerable<long>
{
public static readonly long[] Value=A131660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131660.Bytes);
public long this[int i]=>Value[i];

public static A131660Inst Instance=new A131660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131661
{
public static readonly long[] Value={ 0L,0L,2L,5L,14L,22L,44L,68L,107L,172L,261L,396L,606L,950L,1414L,2238L,3418L,5411L,8368L,13297L,20840L,33268L,52549L,84120L,133775L,214611L,343025L,551064L,883600L,1421767L,2284870L,3680296L,5924725L,9551161L,15393855L,24834827L,40061700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131661Inst : IEnumerable<long>
{
public static readonly long[] Value=A131661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131661.Bytes);
public long this[int i]=>Value[i];

public static A131661Inst Instance=new A131661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131662
{
public static readonly long[] Value={ 2519L,11879L,13320L,14399L,15840L,25200L,27719L,27720L,30239L,39599L,41040L,42119L,43560L,52920L,55439L,55440L,57959L,67319L,68760L,69839L,71280L,80640L,83159L,83160L,85679L,95039L,96480L,97559L,99000L,108360L,110879L,110880L,113399L,122759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131662Inst : IEnumerable<long>
{
public static readonly long[] Value=A131662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131662.Bytes);
public long this[int i]=>Value[i];

public static A131662Inst Instance=new A131662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131663
{
public static readonly long[] Value={ 720L,1799L,2519L,2520L,3240L,4319L,5039L,5040L,5760L,6839L,7559L,7560L,8280L,9359L,10079L,10080L,10800L,11879L,12599L,12600L,13320L,14399L,15119L,15120L,15840L,16919L,17639L,17640L,18360L,19439L,20159L,20160L,20880L,21959L,22679L,22680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131663Inst : IEnumerable<long>
{
public static readonly long[] Value=A131663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131663.Bytes);
public long this[int i]=>Value[i];

public static A131663Inst Instance=new A131663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131664
{
public static readonly long[] Value={ 1L,11L,11L,111L,111L,111L,1111L,1111L,1111L,1111L,11111L,11111L,11111L,11111L,11111L,111111L,111111L,111111L,111111L,111111L,111111L,1111111L,1111111L,1111111L,1111111L,1111111L,1111111L,1111111L,11111111L,11111111L,11111111L,11111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131664Inst : IEnumerable<long>
{
public static readonly long[] Value=A131664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131664.Bytes);
public long this[int i]=>Value[i];

public static A131664Inst Instance=new A131664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131665
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,11L,15L,24L,27L,39L,36L,45L,27L,18L,-27L,-81L,-162L,-297L,-405L,-648L,-729L,-1053L,-972L,-1215L,-729L,-486L,729L,2187L,4374L,8019L,10935L,17496L,19683L,28431L,26244L,32805L,19683L,13122L,-19683L,-59049L,-118098L,-216513L,-295245L,-472392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131665Inst : IEnumerable<long>
{
public static readonly long[] Value=A131665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131665.Bytes);
public long this[int i]=>Value[i];

public static A131665Inst Instance=new A131665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131666
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,7L,14L,29L,57L,114L,227L,455L,910L,1821L,3641L,7282L,14563L,29127L,58254L,116509L,233017L,466034L,932067L,1864135L,3728270L,7456541L,14913081L,29826162L,59652323L,119304647L,238609294L,477218589L,954437177L,1908874354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131666Inst : IEnumerable<long>
{
public static readonly long[] Value=A131666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131666.Bytes);
public long this[int i]=>Value[i];

public static A131666Inst Instance=new A131666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131667
{
public static readonly long[] Value={ 2L,-1L,0L,4L,-3L,0L,6L,-5L,0L,8L,-7L,0L,10L,-9L,0L,12L,-11L,0L,14L,-13L,0L,16L,-15L,0L,18L,-17L,0L,20L,-19L,0L,22L,-21L,0L,24L,-23L,0L,26L,-25L,0L,28L,-27L,0L,30L,-29L,0L,32L,-31L,0L,34L,-33L,0L,36L,-35L,0L,38L,-37L,0L,40L,-39L,0L,42L,-41L,0L,44L,-43L,0L,46L,-45L,0L,48L,-47L,0L,50L,-49L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131667Inst : IEnumerable<long>
{
public static readonly long[] Value=A131667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131667.Bytes);
public long this[int i]=>Value[i];

public static A131667Inst Instance=new A131667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131668
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,29L,49L,69L,89L,199L,399L,599L,799L,999L,2999L,4999L,6999L,8999L,19999L,39999L,59999L,79999L,99999L,299999L,499999L,699999L,899999L,1999999L,3999999L,5999999L,7999999L,9999999L,29999999L,49999999L,69999999L,89999999L,199999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131668Inst : IEnumerable<long>
{
public static readonly long[] Value=A131668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131668.Bytes);
public long this[int i]=>Value[i];

public static A131668Inst Instance=new A131668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131669
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L,1L,3L,5L,7L,9L,2L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131669Inst : IEnumerable<long>
{
public static readonly long[] Value=A131669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131669.Bytes);
public long this[int i]=>Value[i];

public static A131669Inst Instance=new A131669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131670
{
public static readonly long[] Value={ 1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131670Inst : IEnumerable<long>
{
public static readonly long[] Value=A131670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131670.Bytes);
public long this[int i]=>Value[i];

public static A131670Inst Instance=new A131670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131671
{
public static readonly long[] Value={ 3L,1L,2L,8L,3L,2L,9L,2L,9L,5L,0L,8L,8L,8L,1L,8L,3L,8L,3L,3L,3L,2L,5L,9L,3L,6L,3L,9L,6L,8L,5L,3L,6L,4L,2L,1L,7L,5L,6L,8L,3L,3L,6L,8L,7L,7L,6L,7L,1L,1L,7L,3L,8L,5L,3L,1L,9L,8L,6L,5L,1L,3L,0L,1L,9L,7L,6L,7L,9L,7L,2L,6L,1L,9L,0L,7L,0L,3L,4L,8L,1L,3L,0L,7L,6L,2L,3L,3L,2L,2L,3L,0L,0L,0L,7L,6L,8L,4L,5L,5L,0L,5L,1L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131671Inst : IEnumerable<long>
{
public static readonly long[] Value=A131671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131671.Bytes);
public long this[int i]=>Value[i];

public static A131671Inst Instance=new A131671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131720
{
public static readonly long[] Value={ 0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L,0L,1L,-1L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131720Inst : IEnumerable<long>
{
public static readonly long[] Value=A131720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131720.Bytes);
public long this[int i]=>Value[i];

public static A131720Inst Instance=new A131720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131721
{
public static readonly long[] Value={ 1L,1L,3L,7L,17L,41L,100L,240L,580L,1400L,3380L,8160L,19700L,47560L,114820L,277200L,669220L,1615640L,3900500L,9416640L,22733780L,54884200L,132502180L,319888560L,772279300L,1864447160L,4501173620L,10866794400L,26234762420L,63336319240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131721Inst : IEnumerable<long>
{
public static readonly long[] Value=A131721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131721.Bytes);
public long this[int i]=>Value[i];

public static A131721Inst Instance=new A131721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131722
{
public static readonly long[] Value={ 0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L,10L,10L,10L,10L,0L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131722Inst : IEnumerable<long>
{
public static readonly long[] Value=A131722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131722.Bytes);
public long this[int i]=>Value[i];

public static A131722Inst Instance=new A131722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131723
{
public static readonly long[] Value={ 0L,2L,-3L,6L,-8L,12L,-15L,20L,-24L,30L,-35L,42L,-48L,56L,-63L,72L,-80L,90L,-99L,110L,-120L,132L,-143L,156L,-168L,182L,-195L,210L,-224L,240L,-255L,272L,-288L,306L,-323L,342L,-360L,380L,-399L,420L,-440L,462L,-483L,506L,-528L,552L,-575L,600L,-624L,650L,-675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131723Inst : IEnumerable<long>
{
public static readonly long[] Value=A131723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131723.Bytes);
public long this[int i]=>Value[i];

public static A131723Inst Instance=new A131723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131724
{
public static readonly long[] Value={ 1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L,1L,9L,7L,13L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131724Inst : IEnumerable<long>
{
public static readonly long[] Value=A131724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131724.Bytes);
public long this[int i]=>Value[i];

public static A131724Inst Instance=new A131724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131725
{
public static readonly long[] Value={ 0L,1L,3L,8L,10L,19L,19L,28L,36L,41L,49L,50L,50L,51L,53L,58L,60L,69L,69L,78L,86L,91L,99L,100L,100L,101L,103L,108L,110L,119L,119L,128L,136L,141L,149L,150L,150L,151L,153L,158L,160L,169L,169L,178L,186L,191L,199L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131725Inst : IEnumerable<long>
{
public static readonly long[] Value=A131725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131725.Bytes);
public long this[int i]=>Value[i];

public static A131725Inst Instance=new A131725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131726
{
public static readonly long[] Value={ 0L,0L,0L,0L,10L,20L,70L,160L,400L,980L,2370L,5740L,13860L,33460L,80780L,195020L,470830L,1136680L,2744210L,6625100L,15994420L,38613960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131726Inst : IEnumerable<long>
{
public static readonly long[] Value=A131726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131726.Bytes);
public long this[int i]=>Value[i];

public static A131726Inst Instance=new A131726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131727
{
public static readonly long[] Value={ 1L,2L,7L,16L,40L,98L,237L,574L,1386L,3346L,8078L,19502L,47083L,113668L,274421L,662510L,1599442L,3861396L,9322235L,22505868L,54333972L,131173812L,316681596L,764537004L,1845755605L,4456048214L,10757852035L,25971752284L,62701356604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131727Inst : IEnumerable<long>
{
public static readonly long[] Value=A131727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131727.Bytes);
public long this[int i]=>Value[i];

public static A131727Inst Instance=new A131727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131728
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,3L,2L,0L,2L,5L,3L,0L,3L,7L,4L,0L,4L,9L,5L,0L,5L,11L,6L,0L,6L,13L,7L,0L,7L,15L,8L,0L,8L,17L,9L,0L,9L,19L,10L,0L,10L,21L,11L,0L,11L,23L,12L,0L,12L,25L,13L,0L,13L,27L,14L,0L,14L,29L,15L,0L,15L,31L,16L,0L,16L,33L,17L,0L,17L,35L,18L,0L,18L,37L,19L,0L,19L,39L,20L,0L,20L,41L,21L,0L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131728Inst : IEnumerable<long>
{
public static readonly long[] Value=A131728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131728.Bytes);
public long this[int i]=>Value[i];

public static A131728Inst Instance=new A131728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131729
{
public static readonly long[] Value={ 0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131729Inst : IEnumerable<long>
{
public static readonly long[] Value=A131729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131729.Bytes);
public long this[int i]=>Value[i];

public static A131729Inst Instance=new A131729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131730
{
public static readonly long[] Value={ 0L,-1L,1L,0L,1L,-2L,2L,-1L,2L,-3L,3L,-2L,3L,-4L,4L,-3L,4L,-5L,5L,-4L,5L,-6L,6L,-5L,6L,-7L,7L,-6L,7L,-8L,8L,-7L,8L,-9L,9L,-8L,9L,-10L,10L,-9L,10L,-11L,11L,-10L,11L,-12L,12L,-11L,12L,-13L,13L,-12L,13L,-14L,14L,-13L,14L,-15L,15L,-14L,15L,-16L,16L,-15L,16L,-17L,17L,-16L,17L,-18L,18L,-17L,18L,-19L,19L,-18L,19L,-20L,20L,-19L,20L,-21L,21L,-20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131730Inst : IEnumerable<long>
{
public static readonly long[] Value=A131730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131730.Bytes);
public long this[int i]=>Value[i];

public static A131730Inst Instance=new A131730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131731
{
public static readonly long[] Value={ 2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L,2L,-3L,4L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131731Inst : IEnumerable<long>
{
public static readonly long[] Value=A131731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131731.Bytes);
public long this[int i]=>Value[i];

public static A131731Inst Instance=new A131731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131732
{
public static readonly long[] Value={ 1L,-3L,2L,0L,3L,-7L,4L,0L,5L,-11L,6L,0L,7L,-15L,8L,0L,9L,-19L,10L,0L,11L,-23L,12L,0L,13L,-27L,14L,0L,15L,-31L,16L,0L,17L,-35L,18L,0L,19L,-39L,20L,0L,21L,-43L,22L,0L,23L,-47L,24L,0L,25L,-51L,26L,0L,27L,-55L,28L,0L,29L,-59L,30L,0L,31L,-63L,32L,0L,33L,-67L,34L,0L,35L,-71L,36L,0L,37L,-75L,38L,0L,39L,-79L,40L,0L,41L,-83L,42L,0L,43L,-87L,44L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131732Inst : IEnumerable<long>
{
public static readonly long[] Value=A131732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131732.Bytes);
public long this[int i]=>Value[i];

public static A131732Inst Instance=new A131732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131733
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,2L,4L,4L,6L,10L,10L,14L,16L,16L,18L,22L,26L,26L,30L,32L,32L,36L,38L,42L,48L,50L,50L,52L,52L,54L,66L,68L,72L,72L,80L,80L,84L,88L,90L,94L,98L,98L,106L,106L,108L,108L,118L,128L,130L,130L,132L,136L,136L,144L,148L,152L,156L,156L,160L,162L,162L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131733Inst : IEnumerable<long>
{
public static readonly long[] Value=A131733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131733.Bytes);
public long this[int i]=>Value[i];

public static A131733Inst Instance=new A131733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131734
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131734Inst : IEnumerable<long>
{
public static readonly long[] Value=A131734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131734.Bytes);
public long this[int i]=>Value[i];

public static A131734Inst Instance=new A131734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131735
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131735Inst : IEnumerable<long>
{
public static readonly long[] Value=A131735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131735.Bytes);
public long this[int i]=>Value[i];

public static A131735Inst Instance=new A131735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131784
{
public static readonly long[] Value={ 1L,5L,2L,11L,7L,3L,19L,14L,9L,4L,29L,23L,17L,11L,5L,41L,34L,27L,20L,13L,6L,55L,47L,39L,31L,23L,15L,7L,71L,62L,53L,44L,35L,26L,27L,8L,89L,79L,69L,59L,49L,39L,29L,19L,9L,109L,98L,87L,76L,65L,54L,43L,32L,21L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131784Inst : IEnumerable<long>
{
public static readonly long[] Value=A131784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131784.Bytes);
public long this[int i]=>Value[i];

public static A131784Inst Instance=new A131784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131785
{
public static readonly long[] Value={ 1L,2L,8L,32L,156L,820L,4744L,29544L,196708L,1388012L,10320096L,80474620L,655800496L,5569011668L,49164525468L,450312766892L,4271622415228L,41898174547952L,424319014633656L,4431086950025056L,47656288619258248L,527272509796024344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131785Inst : IEnumerable<long>
{
public static readonly long[] Value=A131785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131785.Bytes);
public long this[int i]=>Value[i];

public static A131785Inst Instance=new A131785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131786
{
public static readonly long[] Value={ 1L,4L,20L,104L,592L,3592L,23212L,158652L,1141964L,8621820L,68063300L,560324488L,4799515756L,42690098440L,393605305676L,3755794383536L,37034899306132L,376877989985712L,3953002335087184L,42686126230197500L,474037727935110620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131786Inst : IEnumerable<long>
{
public static readonly long[] Value=A131786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131786.Bytes);
public long this[int i]=>Value[i];

public static A131786Inst Instance=new A131786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131787
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,17L,23L,28L,35L,45L,51L,63L,76L,83L,92L,108L,117L,135L,144L,156L,177L,199L,205L,224L,249L,264L,279L,307L,319L,349L,364L,385L,418L,443L,456L,492L,529L,553L,566L,606L,629L,671L,696L,713L,758L,804L,817L,862L,899L,929L,962L,1014L,1041L,1089L,1114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131787Inst : IEnumerable<long>
{
public static readonly long[] Value=A131787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131787.Bytes);
public long this[int i]=>Value[i];

public static A131787Inst Instance=new A131787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131788
{
public static readonly long[] Value={ 1L,2L,3L,6L,18L,22L,74L,173L,350L,627L,1903L,3980L,11139L,29437L,72720L,108312L,337079L,379735L,988163L,1354929L,4458118L,12200929L,32148649L,78234718L,208109020L,546549127L,1108402372L,3055896646L,8105184898L,8151267237L,29457007624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131788Inst : IEnumerable<long>
{
public static readonly long[] Value=A131788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131788.Bytes);
public long this[int i]=>Value[i];

public static A131788Inst Instance=new A131788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131789
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131789Inst : IEnumerable<long>
{
public static readonly long[] Value=A131789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131789.Bytes);
public long this[int i]=>Value[i];

public static A131789Inst Instance=new A131789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131790
{
public static readonly long[] Value={ 1L,1L,10L,1L,5L,1L,3L,1L,5L,1L,2L,1L,4L,1L,11L,1L,16L,1L,8L,1L,5L,1L,2L,1L,4L,1L,10L,2L,2L,1L,9L,2L,4L,1L,1L,2L,9L,1L,11L,1L,4L,1L,10L,1L,10L,1L,1L,1L,6L,1L,1L,1L,10L,1L,9L,1L,7L,1L,30L,1L,9L,2L,1L,1L,22L,1L,4L,2L,8L,1L,28L,1L,4L,1L,4L,1L,4L,1L,33L,1L,3L,1L,9L,1L,5L,1L,26L,1L,18L,1L,4L,1L,5L,1L,10L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131790Inst : IEnumerable<long>
{
public static readonly long[] Value=A131790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131790.Bytes);
public long this[int i]=>Value[i];

public static A131790Inst Instance=new A131790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131791
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,3L,5L,6L,6L,5L,3L,1L,1L,4L,9L,15L,21L,26L,29L,30L,30L,29L,26L,21L,15L,9L,4L,1L,1L,5L,14L,29L,50L,76L,105L,135L,165L,194L,220L,241L,256L,265L,269L,270L,270L,269L,265L,256L,241L,220L,194L,165L,135L,105L,76L,50L,29L,14L,5L,1L,1L,6L,20L,49L,99L,175L,280L,415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131791Inst : IEnumerable<long>
{
public static readonly long[] Value=A131791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131791.Bytes);
public long this[int i]=>Value[i];

public static A131791Inst Instance=new A131791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131792
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,76L,280L,1045L,3936L,14925L,56892L,217791L,836706L,3224157L,12456225L,48232162L,187131664L,727309265L,2831193004L,11036424667L,43076087806L,168322335246L,658416150496L,2577945422410L,10102468839284L,39621592646545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131792Inst : IEnumerable<long>
{
public static readonly long[] Value=A131792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131792.Bytes);
public long this[int i]=>Value[i];

public static A131792Inst Instance=new A131792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131793
{
public static readonly long[] Value={ 1L,3L,5L,2L,4L,6L,7L,9L,11L,8L,10L,12L,13L,15L,17L,14L,16L,18L,19L,21L,23L,20L,22L,24L,25L,27L,29L,26L,28L,30L,31L,33L,35L,32L,34L,36L,37L,39L,41L,38L,40L,42L,43L,45L,47L,44L,46L,48L,49L,51L,53L,50L,52L,54L,55L,57L,59L,56L,58L,60L,61L,63L,65L,62L,64L,66L,67L,69L,71L,68L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131793Inst : IEnumerable<long>
{
public static readonly long[] Value=A131793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131793.Bytes);
public long this[int i]=>Value[i];

public static A131793Inst Instance=new A131793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131794
{
public static readonly long[] Value={ 1L,1L,0L,0L,-1L,-1L,0L,1L,0L,-1L,0L,0L,1L,2L,1L,-2L,-3L,-1L,1L,2L,3L,0L,-3L,-1L,2L,2L,0L,-2L,-6L,-3L,4L,7L,3L,-2L,-5L,-6L,2L,8L,3L,-5L,-6L,-2L,4L,12L,7L,-10L,-15L,-6L,5L,13L,12L,-4L,-18L,-7L,11L,14L,6L,-10L,-24L,-14L,20L,32L,12L,-12L,-29L,-24L,9L,36L,15L,-22L,-30L,-13L,22L,50L,27L,-36L,-63L,-26L,24L,56L,45L,-22L,-69L,-30L,42L,62L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131794Inst : IEnumerable<long>
{
public static readonly long[] Value=A131794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131794.Bytes);
public long this[int i]=>Value[i];

public static A131794Inst Instance=new A131794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131795
{
public static readonly long[] Value={ 1L,0L,1L,-1L,1L,-1L,2L,-2L,2L,-3L,4L,-4L,5L,-6L,7L,-8L,9L,-11L,13L,-14L,17L,-20L,22L,-25L,29L,-33L,37L,-42L,48L,-54L,61L,-68L,77L,-87L,96L,-108L,122L,-135L,150L,-168L,187L,-207L,230L,-255L,283L,-313L,345L,-382L,422L,-464L,511L,-564L,620L,-680L,748L,-821L,900L,-986L,1079L,-1182L,1293L,-1411L,1542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131795Inst : IEnumerable<long>
{
public static readonly long[] Value=A131795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131795.Bytes);
public long this[int i]=>Value[i];

public static A131795Inst Instance=new A131795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131796
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,-1L,0L,1L,0L,-1L,0L,0L,1L,2L,1L,-2L,-3L,-1L,1L,2L,3L,0L,-3L,-1L,2L,2L,0L,-2L,-6L,-3L,4L,7L,3L,-2L,-5L,-6L,2L,8L,3L,-5L,-6L,-2L,4L,12L,7L,-10L,-15L,-6L,5L,13L,12L,-4L,-18L,-7L,11L,14L,6L,-10L,-24L,-14L,20L,32L,12L,-12L,-29L,-24L,9L,36L,15L,-22L,-30L,-13L,22L,50L,27L,-36L,-63L,-26L,24L,56L,45L,-22L,-69L,-30L,42L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131796Inst : IEnumerable<long>
{
public static readonly long[] Value=A131796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131796.Bytes);
public long this[int i]=>Value[i];

public static A131796Inst Instance=new A131796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131797
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,0L,1L,1L,0L,-1L,0L,1L,0L,0L,-1L,-2L,-1L,2L,3L,1L,-1L,-2L,-3L,0L,3L,1L,-2L,-2L,0L,2L,6L,3L,-4L,-7L,-3L,2L,5L,6L,-2L,-8L,-3L,5L,6L,2L,-4L,-12L,-7L,10L,15L,6L,-5L,-13L,-12L,4L,18L,7L,-11L,-14L,-6L,10L,24L,14L,-20L,-32L,-12L,12L,29L,24L,-9L,-36L,-15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131797Inst : IEnumerable<long>
{
public static readonly long[] Value=A131797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131797.Bytes);
public long this[int i]=>Value[i];

public static A131797Inst Instance=new A131797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131798
{
public static readonly long[] Value={ 2L,3L,4L,4L,4L,6L,6L,6L,6L,6L,6L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131798Inst : IEnumerable<long>
{
public static readonly long[] Value=A131798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131798.Bytes);
public long this[int i]=>Value[i];

public static A131798Inst Instance=new A131798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131799
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,4L,5L,5L,5L,7L,8L,8L,8L,12L,14L,15L,15L,19L,21L,22L,22L,28L,33L,35L,37L,43L,48L,50L,52L,61L,69L,74L,78L,90L,98L,103L,107L,122L,135L,143L,152L,170L,186L,194L,203L,225L,247L,261L,275L,305L,330L,348L,362L,396L,429L,454L,477L,519L,561L,590L,618L,666L,717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131799Inst : IEnumerable<long>
{
public static readonly long[] Value=A131799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131799.Bytes);
public long this[int i]=>Value[i];

public static A131799Inst Instance=new A131799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131912
{
public static readonly long[] Value={ 1L,7L,12L,18L,23L,29L,34L,40L,45L,51L,56L,62L,67L,73L,78L,84L,89L,95L,100L,106L,111L,117L,122L,128L,133L,139L,144L,150L,155L,161L,166L,172L,177L,183L,188L,194L,199L,205L,210L,216L,221L,227L,232L,238L,243L,249L,254L,260L,265L,271L,276L,282L,287L,293L,298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131912Inst : IEnumerable<long>
{
public static readonly long[] Value=A131912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131912.Bytes);
public long this[int i]=>Value[i];

public static A131912Inst Instance=new A131912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131913
{
public static readonly long[] Value={ 1L,3L,6L,13L,25L,48L,89L,163L,294L,525L,929L,1632L,2849L,4947L,8550L,14717L,25241L,43152L,73561L,125075L,212166L,359133L,606721L,1023168L,1722625L,2895843L,4861254L,8149933L,13646809L,22825200L,38136089L,63653827L,106146534L,176849517L,294401825L,489706272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131913Inst : IEnumerable<long>
{
public static readonly long[] Value=A131913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131913.Bytes);
public long this[int i]=>Value[i];

public static A131913Inst Instance=new A131913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131914
{
public static readonly long[] Value={ 1L,4L,2L,7L,5L,3L,10L,8L,6L,4L,13L,11L,9L,7L,5L,16L,14L,12L,10L,8L,6L,19L,17L,15L,13L,11L,9L,7L,22L,20L,18L,16L,14L,12L,10L,8L,25L,23L,21L,19L,17L,15L,13L,11L,9L,28L,26L,24L,22L,20L,18L,16L,14L,12L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131914Inst : IEnumerable<long>
{
public static readonly long[] Value=A131914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131914.Bytes);
public long this[int i]=>Value[i];

public static A131914Inst Instance=new A131914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131915
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,0L,9L,3L,4L,0L,7L,3L,1L,7L,6L,0L,5L,2L,2L,7L,6L,8L,6L,1L,5L,4L,3L,5L,2L,9L,4L,4L,4L,7L,1L,0L,2L,4L,5L,6L,5L,0L,2L,7L,8L,6L,3L,1L,6L,2L,6L,6L,7L,0L,5L,2L,8L,1L,6L,0L,6L,7L,2L,1L,9L,9L,4L,9L,0L,7L,5L,6L,2L,6L,5L,2L,2L,3L,4L,6L,6L,7L,6L,9L,1L,3L,5L,0L,0L,4L,0L,9L,1L,5L,5L,7L,0L,0L,2L,1L,8L,7L,7L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131915Inst : IEnumerable<long>
{
public static readonly long[] Value=A131915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131915.Bytes);
public long this[int i]=>Value[i];

public static A131915Inst Instance=new A131915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131916
{
public static readonly long[] Value={ 1L,8L,4L,2L,1L,5L,1L,1L,5L,1L,1L,3L,8L,1L,4L,2L,6L,9L,5L,97L,2L,1L,1L,2L,9L,8L,5L,3L,16L,1L,31L,2L,1L,8L,7L,1L,2L,1L,15L,1L,1L,1L,3L,1L,12L,3L,11L,2L,1L,1L,13L,1L,3L,6L,1L,15L,9L,3L,4L,1L,2L,1L,5L,1L,1L,1L,18L,2L,5L,8L,1L,3L,1L,1L,2L,3L,12L,1L,8L,1L,2L,1L,1L,1L,2L,17L,13L,3L,1L,1L,1L,5L,1L,1L,3L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131916Inst : IEnumerable<long>
{
public static readonly long[] Value=A131916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131916.Bytes);
public long this[int i]=>Value[i];

public static A131916Inst Instance=new A131916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131917
{
public static readonly long[] Value={ 3L,7L,3L,9L,2L,9L,7L,5L,1L,9L,4L,5L,1L,1L,8L,4L,2L,0L,7L,3L,6L,6L,3L,3L,2L,8L,6L,9L,6L,8L,6L,1L,5L,1L,7L,2L,5L,6L,6L,2L,6L,3L,6L,8L,5L,4L,5L,6L,4L,1L,9L,2L,1L,7L,8L,3L,0L,7L,8L,9L,8L,1L,2L,1L,0L,0L,7L,9L,5L,7L,2L,3L,2L,6L,2L,0L,3L,5L,2L,5L,4L,5L,3L,0L,1L,7L,9L,7L,0L,9L,4L,2L,3L,7L,1L,7L,7L,6L,2L,2L,8L,5L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131917Inst : IEnumerable<long>
{
public static readonly long[] Value=A131917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131917.Bytes);
public long this[int i]=>Value[i];

public static A131917Inst Instance=new A131917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131918
{
public static readonly long[] Value={ 3L,1L,2L,1L,5L,11L,7L,6L,1L,2L,6L,1L,10L,15L,7L,1L,11L,12L,1L,1L,4L,3L,1L,1L,9L,3L,4L,10L,4L,1L,1L,26L,1L,1L,8L,10L,1L,2L,1L,1L,1L,2L,2L,1L,1L,3L,1L,3L,3L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,2L,4L,2L,1L,49L,7L,1L,2L,1L,1L,2L,16L,1L,283L,1L,1L,5L,1L,1L,1L,2L,1L,30L,19L,1L,11L,2L,5L,10L,3L,1L,4L,1L,6L,2L,19L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131918Inst : IEnumerable<long>
{
public static readonly long[] Value=A131918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131918.Bytes);
public long this[int i]=>Value[i];

public static A131918Inst Instance=new A131918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131919
{
public static readonly long[] Value={ 1L,3L,3L,5L,3L,5L,7L,4L,4L,7L,9L,5L,5L,5L,9L,11L,6L,6L,6L,6L,11L,13L,7L,7L,7L,7L,7L,13L,15L,8L,8L,8L,8L,8L,8L,15L,17L,9L,9L,9L,9L,9L,9L,9L,17L,19L,10L,10L,10L,10L,10L,10L,10L,10L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131919Inst : IEnumerable<long>
{
public static readonly long[] Value=A131919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131919.Bytes);
public long this[int i]=>Value[i];

public static A131919Inst Instance=new A131919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131920
{
public static readonly long[] Value={ 2L,8L,8L,5L,3L,9L,0L,0L,8L,1L,7L,7L,7L,9L,2L,6L,8L,1L,4L,7L,1L,9L,8L,4L,9L,3L,6L,2L,0L,0L,3L,7L,8L,4L,2L,7L,4L,8L,5L,3L,2L,9L,1L,9L,0L,8L,3L,0L,5L,9L,7L,1L,8L,6L,8L,2L,7L,0L,8L,9L,8L,8L,1L,3L,8L,6L,2L,2L,1L,8L,4L,3L,8L,3L,6L,2L,3L,7L,0L,1L,5L,9L,7L,7L,1L,0L,5L,3L,2L,4L,5L,7L,8L,7L,0L,1L,2L,6L,8L,8L,9L,9L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131920Inst : IEnumerable<long>
{
public static readonly long[] Value=A131920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131920.Bytes);
public long this[int i]=>Value[i];

public static A131920Inst Instance=new A131920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131921
{
public static readonly long[] Value={ 8L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,8L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,8L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,8L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131921Inst : IEnumerable<long>
{
public static readonly long[] Value=A131921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131921.Bytes);
public long this[int i]=>Value[i];

public static A131921Inst Instance=new A131921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131922
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,5L,4L,7L,7L,7L,5L,9L,9L,9L,9L,6L,11L,11L,11L,11L,11L,7L,13L,13L,13L,13L,13L,13L,8L,15L,15L,15L,15L,15L,15L,15L,9L,17L,17L,17L,17L,17L,17L,17L,17L,10L,19L,19L,19L,19L,19L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131922Inst : IEnumerable<long>
{
public static readonly long[] Value=A131922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131922.Bytes);
public long this[int i]=>Value[i];

public static A131922Inst Instance=new A131922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131923
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,4L,6L,6L,4L,5L,8L,10L,8L,5L,6L,10L,15L,15L,10L,6L,7L,12L,21L,26L,21L,12L,7L,8L,14L,28L,42L,42L,28L,14L,8L,9L,16L,36L,64L,78L,64L,36L,9L,10L,18L,45L,93L,135L,135L,93L,45L,18L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131923Inst : IEnumerable<long>
{
public static readonly long[] Value=A131923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131923.Bytes);
public long this[int i]=>Value[i];

public static A131923Inst Instance=new A131923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131924
{
public static readonly long[] Value={ 1L,4L,10L,20L,36L,62L,106L,184L,328L,602L,1134L,2180L,4252L,8374L,16594L,33008L,65808L,131378L,262486L,524668L,1048996L,2097614L,4194810L,8389160L,16777816L,33555082L,67109566L,134218484L,268436268L,536871782L,1073742754L,2147484640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131924Inst : IEnumerable<long>
{
public static readonly long[] Value=A131924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131924.Bytes);
public long this[int i]=>Value[i];

public static A131924Inst Instance=new A131924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131925
{
public static readonly long[] Value={ 1L,5L,3L,5L,7L,5L,9L,7L,9L,7L,9L,11L,9L,11L,9L,13L,11L,13L,11L,13L,11L,13L,15L,13L,15L,13L,15L,13L,17L,15L,17L,15L,17L,15L,17L,15L,17L,19L,17L,19L,17L,19L,17L,19L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131925Inst : IEnumerable<long>
{
public static readonly long[] Value=A131925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131925.Bytes);
public long this[int i]=>Value[i];

public static A131925Inst Instance=new A131925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131926
{
public static readonly BigInteger[] Value={ 1L,6L,78L,1266L,23010L,448062L,9140118L,192804954L,4171347258L,92051810934L,2063947865694L,46885775086338L,1076785174781394L,24959959877000238L,583201632981980454L,13721408509737851754UL,BigInteger.Parse("324797812150741560618"),BigInteger.Parse("7729580015834558984934"),BigInteger.Parse("184829586432121709114478") };
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
public class A131926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131926Inst Instance=new A131926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131927
{
public static readonly BigInteger[] Value={ 0L,1L,8L,136L,2888L,68680L,1749896L,46707976L,1289214152L,36496595656L,1053849164552L,30918300671368L,919029058099784L,27617782977715528L,837674888992142984L,BigInteger.Parse("25610757376777402888"),BigInteger.Parse("788450850824647610312") };
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
public class A131927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131927.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131927Inst Instance=new A131927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131960
{
public static readonly BigInteger[] Value={ 6L,21L,155L,889L,106483L,2228207L,9961453L,66571993057L,BigInteger.Parse("140656423562035331011"),BigInteger.Parse("55088331748199422233011027879"),BigInteger.Parse("17361742620725829882898847100829589") };
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
public class A131960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131960Inst Instance=new A131960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131961
{
public static readonly long[] Value={ 1L,1L,3L,2L,2L,1L,0L,3L,2L,4L,2L,0L,1L,2L,2L,3L,0L,2L,2L,2L,4L,0L,1L,4L,2L,2L,1L,0L,2L,0L,4L,0L,2L,4L,4L,1L,0L,4L,0L,2L,3L,0L,2L,2L,4L,0L,0L,2L,2L,0L,2L,3L,2L,4L,2L,2L,0L,3L,4L,4L,0L,0L,2L,0L,0L,4L,0L,2L,0L,2L,1L,0L,8L,2L,2L,2L,2L,3L,2L,4L,0L,0L,0L,2L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131961Inst : IEnumerable<long>
{
public static readonly long[] Value=A131961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131961.Bytes);
public long this[int i]=>Value[i];

public static A131961Inst Instance=new A131961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131962
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,0L,0L,2L,1L,0L,0L,1L,1L,1L,2L,0L,2L,0L,1L,1L,0L,2L,2L,1L,1L,1L,0L,1L,1L,2L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,2L,3L,0L,1L,0L,1L,1L,1L,2L,0L,1L,1L,1L,1L,0L,3L,1L,1L,2L,0L,0L,1L,2L,0L,0L,1L,1L,2L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131962Inst : IEnumerable<long>
{
public static readonly long[] Value=A131962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131962.Bytes);
public long this[int i]=>Value[i];

public static A131962Inst Instance=new A131962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131963
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,0L,1L,2L,1L,1L,1L,1L,1L,0L,2L,0L,0L,1L,0L,2L,1L,3L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,2L,2L,1L,1L,0L,1L,1L,1L,2L,0L,0L,1L,1L,2L,0L,0L,2L,0L,1L,0L,1L,1L,2L,2L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,3L,0L,1L,0L,0L,1L,2L,2L,0L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131963Inst : IEnumerable<long>
{
public static readonly long[] Value=A131963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131963.Bytes);
public long this[int i]=>Value[i];

public static A131963Inst Instance=new A131963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131964
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,1L,0L,1L,0L,2L,1L,1L,1L,0L,1L,2L,2L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,2L,1L,1L,0L,1L,1L,1L,3L,0L,0L,0L,2L,1L,1L,2L,1L,2L,1L,0L,0L,0L,2L,1L,0L,2L,0L,2L,0L,0L,1L,1L,0L,1L,0L,1L,2L,1L,2L,1L,1L,1L,1L,0L,0L,0L,2L,1L,2L,0L,2L,2L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131964Inst : IEnumerable<long>
{
public static readonly long[] Value=A131964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131964.Bytes);
public long this[int i]=>Value[i];

public static A131964Inst Instance=new A131964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131965
{
public static readonly BigInteger[] Value={ 1L,1L,4L,21L,131L,943L,7701L,70409L,712891L,7921011L,95844233L,1254688141L,17670191319L,266412115271L,4281623281141L,73073037331473L,1319881736799731L,25155393101359579L,504505383866156001L,10621165976129600021UL,BigInteger.Parse("234196709773657680463"),BigInteger.Parse("5397676549069062730671") };
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
public class A131965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131965Inst Instance=new A131965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131966
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,9L,8L,10L,11L,14L,13L,15L,12L,16L,19L,28L,21L,17L,20L,22L,26L,24L,28L,23L,27L,25L,29L,33L,31L,35L,30L,34L,32L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131966Inst : IEnumerable<long>
{
public static readonly long[] Value=A131966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131966.Bytes);
public long this[int i]=>Value[i];

public static A131966Inst Instance=new A131966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131967
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,5L,2L,1L,6L,4L,3L,5L,7L,2L,1L,8L,6L,4L,9L,3L,10L,5L,7L,11L,2L,1L,12L,8L,6L,4L,9L,3L,10L,5L,7L,11L,13L,2L,1L,14L,12L,8L,6L,15L,4L,9L,16L,3L,17L,10L,5L,18L,7L,11L,13L,19L,2L,1L,20L,14L,12L,8L,6L,15L,4L,21L,9L,16L,3L,17L,10L,22L,5L,18L,7L,11L,13L,19L,23L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131967Inst : IEnumerable<long>
{
public static readonly long[] Value=A131967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131967.Bytes);
public long this[int i]=>Value[i];

public static A131967Inst Instance=new A131967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131968
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,11L,10L,8L,7L,18L,17L,14L,13L,9L,29L,28L,23L,21L,15L,12L,42L,41L,35L,33L,25L,20L,16L,61L,60L,51L,48L,37L,32L,26L,19L,86L,85L,71L,68L,54L,46L,38L,31L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131968Inst : IEnumerable<long>
{
public static readonly long[] Value=A131968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131968.Bytes);
public long this[int i]=>Value[i];

public static A131968Inst Instance=new A131968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131969
{
public static readonly long[] Value={ 3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L,3L,-2L,6L,-3L,2L,-6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131969Inst : IEnumerable<long>
{
public static readonly long[] Value=A131969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131969.Bytes);
public long this[int i]=>Value[i];

public static A131969Inst Instance=new A131969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131970
{
public static readonly BigInteger[] Value={ 1L,122L,12222L,1222222L,122222222L,12222222222L,1222222222222L,122222222222222L,12222222222222222L,1222222222222222222L,BigInteger.Parse("122222222222222222222"),BigInteger.Parse("12222222222222222222222") };
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
public class A131970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131970Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131970.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A131970.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131970Inst Instance=new A131970Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131971
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,3L,5L,3L,3L,2L,8L,2L,0L,10L,12L,7L,13L,15L,17L,7L,19L,1L,5L,2L,8L,15L,25L,21L,5L,22L,18L,14L,22L,21L,23L,31L,3L,20L,16L,0L,36L,11L,5L,9L,25L,39L,27L,44L,14L,36L,44L,43L,19L,0L,8L,27L,35L,13L,17L,6L,36L,59L,39L,8L,42L,24L,8L,7L,39L,54L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131971Inst : IEnumerable<long>
{
public static readonly long[] Value=A131971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131971.Bytes);
public long this[int i]=>Value[i];

public static A131971Inst Instance=new A131971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131972
{
public static readonly long[] Value={ 2L,24L,180L,7420L,33264L,991848L,3938220L,103832872L,389398464L,9620555000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131972Inst : IEnumerable<long>
{
public static readonly long[] Value=A131972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131972.Bytes);
public long this[int i]=>Value[i];

public static A131972Inst Instance=new A131972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131973
{
public static readonly long[] Value={ 121L,242L,363L,484L,605L,726L,847L,968L,121L,242L,363L,484L,605L,726L,847L,968L,121L,242L,363L,484L,605L,726L,847L,968L,121L,242L,363L,484L,605L,726L,847L,968L,121L,242L,363L,484L,605L,726L,847L,968L,121L,242L,363L,484L,605L,726L,847L,968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131973Inst : IEnumerable<long>
{
public static readonly long[] Value=A131973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131973.Bytes);
public long this[int i]=>Value[i];

public static A131973Inst Instance=new A131973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131974
{
public static readonly long[] Value={ 1L,2L,3L,4L,-5L,-4L,-3L,-2L,1L,2L,3L,4L,-5L,-4L,-3L,-2L,1L,2L,3L,4L,-5L,-4L,-3L,-2L,1L,2L,3L,4L,-5L,-4L,-3L,-2L,1L,2L,3L,4L,-5L,-4L,-3L,-2L,1L,2L,3L,4L,-5L,-4L,-3L,-2L,1L,2L,3L,4L,-5L,-4L,-3L,-2L,1L,2L,3L,4L,-5L,-4L,-3L,-2L,1L,2L,3L,4L,-5L,-4L,-3L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131974Inst : IEnumerable<long>
{
public static readonly long[] Value=A131974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131974.Bytes);
public long this[int i]=>Value[i];

public static A131974Inst Instance=new A131974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131975
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,9L,12L,13L,16L,19L,22L,44L,66L,88L,110L,132L,154L,176L,179L,201L,223L,245L,267L,289L,311L,333L,355L,710L,1065L,1420L,1775L,2130L,2485L,2840L,3195L,3550L,3905L,4260L,4615L,4970L,5325L,5680L,6035L,6390L,6745L,7100L,7455L,7810L,8165L,8520L,8875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131975Inst : IEnumerable<long>
{
public static readonly long[] Value=A131975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131975.Bytes);
public long this[int i]=>Value[i];

public static A131975Inst Instance=new A131975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131976
{
public static readonly long[] Value={ 1L,1L,5L,12L,22L,34L,50L,65L,78L,78L,86L,78L,78L,65L,50L,34L,22L,12L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131976Inst : IEnumerable<long>
{
public static readonly long[] Value=A131976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131976.Bytes);
public long this[int i]=>Value[i];

public static A131976Inst Instance=new A131976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131977
{
public static readonly long[] Value={ 1L,1L,3L,5L,8L,8L,12L,8L,8L,5L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131977Inst : IEnumerable<long>
{
public static readonly long[] Value=A131977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131977.Bytes);
public long this[int i]=>Value[i];

public static A131977Inst Instance=new A131977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131978
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,24L,24L,192L,1728L,17280L,17280L,207360L,207360L,414720L,6220800L,99532800L,696729600L,12541132800L,12541132800L,250822656000L,5267275776000L,10534551552000L,10534551552000L,252829237248000L,1264146186240000L,12641461862400000L,3754514173132800000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131978Inst : IEnumerable<long>
{
public static readonly long[] Value=A131978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131978.Bytes);
public long this[int i]=>Value[i];

public static A131978Inst Instance=new A131978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131979
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,2L,3L,5L,7L,9L,2L,4L,5L,7L,10L,2L,4L,6L,7L,12L,1L,8L,9L,12L,1L,2L,4L,6L,2L,3L,5L,7L,9L,2L,4L,5L,7L,10L,2L,4L,6L,7L,12L,3L,8L,9L,12L,1L,2L,4L,6L,1L,3L,4L,6L,2L,4L,5L,7L,10L,2L,4L,6L,7L,12L,5L,9L,10L,11L,1L,2L,4L,6L,1L,3L,4L,6L,1L,3L,5L,6L,11L,2L,4L,6L,7L,12L,7L,10L,11L,12L,1L,3L,5L,7L,8L,1L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131979Inst : IEnumerable<long>
{
public static readonly long[] Value=A131979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131979.Bytes);
public long this[int i]=>Value[i];

public static A131979Inst Instance=new A131979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131980
{
public static readonly long[] Value={ 1L,2L,6L,2L,24L,24L,120L,240L,24L,720L,2400L,720L,5040L,25200L,15120L,720L,40320L,282240L,282240L,40320L,362880L,3386880L,5080320L,1451520L,40320L,3628800L,43545600L,91445760L,43545600L,3628800L,39916800L,598752000L,1676505600L,1197504000L,199584000L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131980Inst : IEnumerable<long>
{
public static readonly long[] Value=A131980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131980.Bytes);
public long this[int i]=>Value[i];

public static A131980Inst Instance=new A131980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131981
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,5L,5L,6L,6L,6L,6L,6L,6L,6L,7L,8L,9L,9L,10L,10L,10L,10L,10L,10L,11L,12L,13L,14L,14L,15L,15L,15L,15L,15L,16L,17L,18L,19L,20L,20L,21L,21L,21L,21L,22L,23L,24L,25L,26L,27L,27L,28L,28L,28L,29L,30L,31L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131981Inst : IEnumerable<long>
{
public static readonly long[] Value=A131981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131981.Bytes);
public long this[int i]=>Value[i];

public static A131981Inst Instance=new A131981Inst();

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