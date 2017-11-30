using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A117141
{
public static readonly BigInteger[] Value={ 2L,7L,47L,383L,10321919L,51011754393599L,BigInteger.Parse("1130138339199322632554990773529330319359999999"),BigInteger.Parse("73562883979319395645666688474019139929848516028923903999999999") };
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
public class A117141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117141Inst Instance=new A117141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117142
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,10L,14L,15L,20L,21L,27L,28L,35L,36L,44L,45L,54L,55L,65L,66L,77L,78L,90L,91L,104L,105L,119L,120L,135L,136L,152L,153L,170L,171L,189L,190L,209L,210L,230L,231L,252L,253L,275L,276L,299L,300L,324L,325L,350L,351L,377L,378L,405L,406L,434L,435L,464L,465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117142Inst : IEnumerable<long>
{
public static readonly long[] Value=A117142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117142.Bytes);
public long this[int i]=>Value[i];

public static A117142Inst Instance=new A117142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117143
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,13L,17L,22L,27L,33L,41L,48L,57L,68L,78L,90L,105L,118L,134L,153L,170L,190L,214L,235L,260L,289L,315L,345L,380L,411L,447L,488L,525L,567L,615L,658L,707L,762L,812L,868L,931L,988L,1052L,1123L,1188L,1260L,1340L,1413L,1494L,1583L,1665L,1755L,1854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117143Inst : IEnumerable<long>
{
public static readonly long[] Value=A117143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117143.Bytes);
public long this[int i]=>Value[i];

public static A117143Inst Instance=new A117143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117144
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,3L,4L,5L,6L,6L,8L,9L,10L,12L,15L,16L,19L,21L,25L,28L,32L,34L,41L,46L,51L,55L,64L,70L,79L,86L,97L,106L,119L,129L,146L,159L,175L,190L,214L,232L,256L,277L,306L,334L,367L,394L,434L,472L,515L,556L,607L,654L,714L,770L,836L,901L,978L,1048L,1140L,1226L,1322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117144Inst : IEnumerable<long>
{
public static readonly long[] Value=A117144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117144.Bytes);
public long this[int i]=>Value[i];

public static A117144Inst Instance=new A117144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117145
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,2L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,2L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,2L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117145Inst : IEnumerable<long>
{
public static readonly long[] Value=A117145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117145.Bytes);
public long this[int i]=>Value[i];

public static A117145Inst Instance=new A117145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117146
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,20L,27L,34L,40L,50L,60L,70L,85L,100L,115L,136L,156L,176L,206L,234L,261L,300L,336L,370L,418L,466L,511L,572L,633L,690L,765L,840L,914L,1008L,1102L,1194L,1307L,1420L,1530L,1668L,1806L,1940L,2107L,2272L,2431L,2626L,2825L,3016L,3246L,3484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117146Inst : IEnumerable<long>
{
public static readonly long[] Value=A117146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117146.Bytes);
public long this[int i]=>Value[i];

public static A117146Inst Instance=new A117146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117147
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,3L,3L,2L,1L,3L,4L,3L,1L,1L,4L,5L,4L,2L,1L,4L,7L,6L,3L,1L,1L,5L,8L,9L,5L,1L,1L,5L,10L,11L,8L,3L,1L,6L,12L,14L,11L,5L,1L,1L,6L,14L,18L,15L,8L,2L,1L,7L,16L,23L,20L,11L,4L,1L,7L,19L,27L,27L,17L,6L,1L,1L,8L,21L,33L,34L,23L,10L,2L,1L,8L,24L,39L,43L,32L,15L,4L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117147Inst : IEnumerable<long>
{
public static readonly long[] Value=A117147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117147.Bytes);
public long this[int i]=>Value[i];

public static A117147Inst Instance=new A117147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117148
{
public static readonly long[] Value={ 1L,3L,6L,8L,15L,24L,36L,50L,75L,102L,143L,197L,264L,349L,467L,606L,789L,1016L,1299L,1656L,2100L,2634L,3302L,4117L,5106L,6306L,7772L,9523L,11639L,14185L,17216L,20839L,25166L,30280L,36361L,43551L,52022L,62004L,73753L,87510L,103638L,122507L,144496L,170133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117148Inst : IEnumerable<long>
{
public static readonly long[] Value=A117148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117148.Bytes);
public long this[int i]=>Value[i];

public static A117148Inst Instance=new A117148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117149
{
public static readonly long[] Value={ 4L,6L,10L,17L,12L,20L,34L,58L,99L,70L,119L,84L,143L,101L,72L,122L,208L,355L,251L,178L,303L,214L,365L,258L,440L,751L,531L,376L,641L,453L,321L,227L,161L,114L,194L,331L,234L,399L,282L,481L,340L,580L,990L,1690L,2885L,2040L,3482L,5944L,10147L,7175L,5074L,8661L,6124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117149Inst : IEnumerable<long>
{
public static readonly long[] Value=A117149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117149.Bytes);
public long this[int i]=>Value[i];

public static A117149Inst Instance=new A117149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117150
{
public static readonly long[] Value={ 4L,5L,7L,9L,13L,8L,11L,15L,21L,29L,41L,57L,81L,48L,67L,95L,56L,79L,111L,157L,92L,54L,32L,45L,63L,89L,125L,177L,104L,147L,207L,293L,172L,243L,343L,485L,685L,969L,568L,803L,1135L,1605L,2269L,3209L,1880L,2659L,1558L,2203L,3115L,4405L,6229L,8809L,12457L,17617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117150Inst : IEnumerable<long>
{
public static readonly long[] Value=A117150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117150.Bytes);
public long this[int i]=>Value[i];

public static A117150Inst Instance=new A117150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117151
{
public static readonly long[] Value={ 432541L,838861L,865082L,1468007L,1677722L,1730164L,1887437L,2516583L,2726299L,2936014L,3355444L,3460301L,3460328L,3774874L,5033165L,5033166L,5452598L,5872027L,5872028L,6710888L,6920602L,6920605L,6920656L,7130317L,7549748L,7549749L,10066330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117151Inst : IEnumerable<long>
{
public static readonly long[] Value=A117151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117151.Bytes);
public long this[int i]=>Value[i];

public static A117151Inst Instance=new A117151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117152
{
public static readonly long[] Value={ 0L,0L,1L,7L,25L,75L,195L,468L,1056L,2280L,4755L,9650L,19154L,37328L,71635L,135685L,254125L,471317L,866669L,1581620L,2866970L,5165630L,9256871L,16507092L,29304660L,51812160L,91264885L,160207603L,280340161L,489117135L,851054535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117152Inst : IEnumerable<long>
{
public static readonly long[] Value=A117152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117152.Bytes);
public long this[int i]=>Value[i];

public static A117152Inst Instance=new A117152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117153
{
public static readonly long[] Value={ 3L,-3L,9L,-12L,-15L,0L,33L,-42L,-36L,30L,15L,-54L,-6L,63L,-63L,-15L,54L,-36L,-42L,24L,-12L,-15L,33L,-36L,12L,39L,-30L,3L,15L,27L,39L,9L,54L,12L,33L,51L,18L,99L,60L,0L,87L,84L,36L,60L,96L,45L,102L,93L,42L,93L,111L,57L,114L,129L,57L,132L,138L,78L,81L,165L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117153Inst : IEnumerable<long>
{
public static readonly long[] Value=A117153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117153.Bytes);
public long this[int i]=>Value[i];

public static A117153Inst Instance=new A117153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117154
{
public static readonly long[] Value={ 1L,0L,0L,1L,-1L,2L,0L,1L,0L,0L,1L,-1L,2L,-2L,1L,-2L,0L,-1L,0L,0L,-1L,1L,-2L,2L,-3L,4L,-2L,3L,-2L,2L,-1L,2L,0L,1L,0L,0L,1L,-1L,2L,-2L,3L,-3L,4L,-4L,5L,-4L,4L,-3L,4L,-2L,3L,-2L,2L,-1L,2L,0L,1L,0L,0L,1L,-1L,2L,-2L,3L,-3L,4L,-4L,5L,-5L,6L,-6L,5L,-6L,4L,-5L,4L,-4L,3L,-4L,2L,-3L,2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117154Inst : IEnumerable<long>
{
public static readonly long[] Value=A117154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117154.Bytes);
public long this[int i]=>Value[i];

public static A117154Inst Instance=new A117154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117155
{
public static readonly long[] Value={ 2L,11L,17L,29L,41L,59L,71L,1009L,1087L,1093L,1213L,1279L,1297L,1303L,1429L,1447L,1483L,1489L,1549L,1567L,1579L,1609L,1663L,1693L,1783L,1867L,1873L,1993L,1999L,2039L,2083L,2137L,2203L,2239L,2269L,2293L,2347L,2377L,2389L,2437L,2473L,2539L,2617L,2659L,2683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117155Inst : IEnumerable<long>
{
public static readonly long[] Value=A117155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117155.Bytes);
public long this[int i]=>Value[i];

public static A117155Inst Instance=new A117155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117156
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,110L,630L,4210L,32150L,276210L,2636720L,27687440L,317169270L,3936056080L,52603684760L,753241509900L,11504852242400L,186705357825800L,3208160592252000L,58188413286031600L,1110946958902609400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117156Inst : IEnumerable<long>
{
public static readonly long[] Value=A117156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117156.Bytes);
public long this[int i]=>Value[i];

public static A117156Inst Instance=new A117156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117157
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,4L,11L,49L,548L,26872L,14725925L,395715057217L,5827270253948278214L,BigInteger.Parse("2305938581960065033611659323852"),BigInteger.Parse("13437327306087560724405450621249967248150551970959") };
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
public class A117157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117157Inst Instance=new A117157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117158
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,111L,642L,4326L,33333L,288901L,2782082L,29471046L,340568843L,4263603891L,57482264322L,830335952166L,12793889924553L,209449977967081L,3630626729775362L,66429958806679686L,1279448352687538463L,BigInteger.Parse("25874432578888440471"),BigInteger.Parse("548178875969847203202") };
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
public class A117158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117158Inst Instance=new A117158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117159
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,31L,37L,43L,53L,71L,73L,113L,131L,137L,151L,157L,173L,211L,223L,311L,317L,359L,367L,389L,431L,557L,571L,593L,673L,751L,827L,839L,929L,953L,983L,1117L,1151L,1153L,1171L,1223L,1279L,1297L,1367L,1447L,1511L,1531L,1553L,1571L,1579L,1597L,1621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117159Inst : IEnumerable<long>
{
public static readonly long[] Value=A117159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117159.Bytes);
public long this[int i]=>Value[i];

public static A117159Inst Instance=new A117159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117160
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,19L,43L,94L,210L,464L,1035L,2295L,5111L,11352L,25259L,56145L,124888L,277669L,617554L,1373201L,3053883L,6790995L,15102178L,33583784L,74684504L,166082706L,369337117L,821331578L,1826484804L,4061741926L,9032530513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117160Inst : IEnumerable<long>
{
public static readonly long[] Value=A117160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117160.Bytes);
public long this[int i]=>Value[i];

public static A117160Inst Instance=new A117160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117161
{
public static readonly long[] Value={ 1L,1L,3L,6L,15L,31L,73L,157L,358L,785L,1762L,3896L,8702L,19299L,42995L,95507L,212552L,472445L,1050973L,2336670L,5197036L,11556157L,25700188L,57150018L,127093805L,282627186L,628514815L,1397684691L,3108193486L,6911996344L,15370966058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117161Inst : IEnumerable<long>
{
public static readonly long[] Value=A117161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117161.Bytes);
public long this[int i]=>Value[i];

public static A117161Inst Instance=new A117161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117162
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-1L,1L,0L,-2L,-1L,1L,-1L,0L,-2L,-1L,1L,1L,-1L,-1L,-2L,-1L,1L,-1L,1L,-1L,-1L,-2L,-1L,1L,0L,0L,2L,-2L,-1L,-2L,-1L,1L,0L,1L,-1L,2L,-2L,-1L,-2L,-1L,1L,1L,-1L,3L,0L,1L,-2L,-1L,-2L,-1L,1L,-1L,1L,-1L,3L,0L,1L,-2L,-1L,-2L,-1L,1L,0L,2L,2L,0L,4L,-1L,1L,-2L,-1L,-2L,-1L,1L,-1L,0L,2L,2L,0L,4L,-1L,1L,-2L,-1L,-2L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117162Inst : IEnumerable<long>
{
public static readonly long[] Value=A117162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117162.Bytes);
public long this[int i]=>Value[i];

public static A117162Inst Instance=new A117162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117163
{
public static readonly long[] Value={ 0L,1L,-1L,-2L,0L,-1L,1L,0L,1L,-1L,1L,2L,0L,-3L,2L,2L,0L,-1L,0L,1L,0L,-1L,1L,0L,0L,-1L,1L,3L,0L,-1L,-1L,-2L,0L,0L,0L,2L,0L,-2L,2L,2L,0L,2L,-1L,0L,-2L,-2L,1L,-2L,-1L,0L,1L,3L,0L,-1L,-1L,1L,1L,0L,1L,-1L,0L,-1L,0L,1L,0L,2L,-1L,0L,0L,3L,-1L,-2L,0L,-2L,0L,3L,-2L,1L,-1L,-4L,-1L,-1L,1L,-3L,0L,1L,2L,2L,0L,2L,-1L,3L,2L,-1L,1L,4L,0L,1L,-1L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117163Inst : IEnumerable<long>
{
public static readonly long[] Value=A117163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117163.Bytes);
public long this[int i]=>Value[i];

public static A117163Inst Instance=new A117163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117164
{
public static readonly long[] Value={ 0L,0L,1L,-1L,-2L,-1L,-1L,2L,-1L,3L,-1L,2L,2L,1L,-2L,1L,2L,1L,-1L,0L,1L,1L,-1L,-2L,2L,-2L,-1L,2L,3L,1L,-1L,-3L,-2L,-2L,3L,-1L,2L,1L,-5L,0L,2L,-1L,2L,0L,4L,-1L,-2L,-1L,-1L,-4L,-3L,2L,3L,1L,2L,-4L,1L,-2L,0L,0L,-1L,1L,-1L,1L,1L,2L,2L,0L,0L,-4L,3L,-1L,-2L,-2L,-1L,1L,5L,3L,1L,-4L,-3L,-3L,-1L,-2L,-3L,-2L,-3L,1L,2L,-4L,1L,2L,3L,4L,2L,3L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117164Inst : IEnumerable<long>
{
public static readonly long[] Value=A117164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117164.Bytes);
public long this[int i]=>Value[i];

public static A117164Inst Instance=new A117164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117165
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,0L,1L,-1L,-1L,0L,1L,-2L,-1L,0L,0L,1L,1L,-2L,-1L,0L,0L,1L,-1L,-1L,-1L,0L,0L,0L,1L,3L,-2L,-1L,-1L,0L,0L,0L,1L,0L,0L,-2L,-1L,0L,0L,0L,0L,1L,4L,-2L,-1L,-1L,-1L,0L,0L,0L,0L,1L,4L,0L,-2L,-1L,-1L,0L,0L,0L,0L,0L,1L,5L,1L,-1L,-2L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,2L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,1L,7L,0L,0L,-2L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117165Inst : IEnumerable<long>
{
public static readonly long[] Value=A117165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117165.Bytes);
public long this[int i]=>Value[i];

public static A117165Inst Instance=new A117165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117166
{
public static readonly long[] Value={ 1L,-1L,-2L,-1L,-2L,1L,-1L,3L,0L,4L,4L,5L,1L,7L,6L,5L,4L,6L,3L,5L,3L,2L,5L,-3L,-5L,-1L,2L,-7L,-6L,-13L,-9L,-14L,-12L,-22L,-12L,-25L,-23L,-26L,-21L,-35L,-27L,-38L,-27L,-43L,-32L,-47L,-34L,-51L,-46L,-52L,-33L,-53L,-35L,-58L,-41L,-56L,-39L,-54L,-39L,-61L,-45L,-53L,-24L,-46L,-23L,-44L,-20L,-41L,-14L,-32L,-12L,-22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117166Inst : IEnumerable<long>
{
public static readonly long[] Value=A117166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117166.Bytes);
public long this[int i]=>Value[i];

public static A117166Inst Instance=new A117166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117167
{
public static readonly long[] Value={ 0L,1L,0L,-1L,-1L,-2L,-1L,-2L,0L,-2L,0L,1L,2L,0L,3L,3L,4L,4L,6L,5L,7L,6L,7L,10L,7L,4L,7L,10L,7L,8L,5L,7L,6L,6L,1L,5L,0L,-1L,-2L,-1L,-8L,-6L,-11L,-7L,-15L,-12L,-20L,-15L,-24L,-27L,-33L,-25L,-36L,-28L,-41L,-39L,-48L,-42L,-51L,-46L,-61L,-61L,-69L,-58L,-72L,-64L,-77L,-70L,-85L,-76L,-90L,-85L,-94L,-86L,-99L,-84L,-100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117167Inst : IEnumerable<long>
{
public static readonly long[] Value=A117167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117167.Bytes);
public long this[int i]=>Value[i];

public static A117167Inst Instance=new A117167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117168
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,-1L,-1L,-1L,-2L,-1L,-2L,-1L,-1L,0L,-2L,1L,0L,2L,1L,4L,1L,5L,3L,6L,6L,7L,4L,8L,8L,10L,8L,10L,8L,12L,9L,10L,10L,10L,8L,10L,8L,9L,6L,7L,7L,5L,5L,3L,4L,1L,-4L,-5L,-4L,-7L,-6L,-13L,-12L,-17L,-15L,-20L,-18L,-28L,-29L,-37L,-31L,-40L,-37L,-47L,-42L,-55L,-51L,-62L,-59L,-69L,-65L,-78L,-69L,-84L,-75L,-93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117168Inst : IEnumerable<long>
{
public static readonly long[] Value=A117168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117168.Bytes);
public long this[int i]=>Value[i];

public static A117168Inst Instance=new A117168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117169
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,-2L,-1L,-2L,0L,-2L,0L,1L,2L,0L,3L,3L,4L,4L,6L,5L,7L,6L,7L,10L,7L,4L,7L,10L,7L,8L,5L,7L,6L,6L,1L,5L,0L,-1L,-2L,-1L,-8L,-6L,-11L,-7L,-15L,-12L,-20L,-15L,-24L,-27L,-33L,-25L,-36L,-28L,-41L,-39L,-48L,-42L,-51L,-46L,-61L,-61L,-69L,-58L,-72L,-64L,-77L,-70L,-85L,-76L,-90L,-85L,-94L,-86L,-99L,-84L,-100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117169Inst : IEnumerable<long>
{
public static readonly long[] Value=A117169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117169.Bytes);
public long this[int i]=>Value[i];

public static A117169Inst Instance=new A117169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117170
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,2L,1L,0L,1L,3L,1L,0L,0L,1L,3L,2L,1L,0L,0L,1L,4L,1L,1L,0L,0L,0L,1L,3L,3L,1L,1L,0L,0L,0L,1L,6L,1L,2L,1L,0L,0L,0L,0L,1L,5L,4L,1L,1L,1L,0L,0L,0L,0L,1L,5L,2L,2L,1L,1L,0L,0L,0L,0L,0L,1L,6L,4L,2L,2L,1L,1L,0L,0L,0L,0L,0L,1L,7L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,7L,6L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117170Inst : IEnumerable<long>
{
public static readonly long[] Value=A117170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117170.Bytes);
public long this[int i]=>Value[i];

public static A117170Inst Instance=new A117170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117171
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,3L,6L,5L,5L,6L,7L,7L,10L,7L,8L,10L,11L,11L,14L,11L,11L,14L,16L,14L,18L,17L,17L,21L,18L,17L,23L,22L,24L,25L,21L,24L,32L,28L,27L,33L,28L,32L,39L,30L,31L,36L,38L,41L,42L,41L,38L,50L,48L,44L,48L,45L,46L,59L,49L,53L,65L,55L,59L,63L,56L,65L,71L,70L,61L,72L,62L,72L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117171Inst : IEnumerable<long>
{
public static readonly long[] Value=A117171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117171.Bytes);
public long this[int i]=>Value[i];

public static A117171Inst Instance=new A117171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117172
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,1L,3L,1L,4L,2L,4L,2L,6L,3L,6L,4L,7L,3L,10L,5L,9L,6L,10L,7L,13L,7L,12L,9L,16L,8L,17L,10L,17L,14L,18L,12L,20L,13L,24L,16L,26L,15L,27L,20L,25L,19L,30L,18L,34L,23L,33L,26L,37L,28L,41L,26L,36L,28L,45L,30L,48L,35L,47L,38L,50L,33L,55L,42L,59L,41L,60L,39L,61L,51L,61L,53L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117172Inst : IEnumerable<long>
{
public static readonly long[] Value=A117172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117172.Bytes);
public long this[int i]=>Value[i];

public static A117172Inst Instance=new A117172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117173
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,2L,3L,4L,4L,3L,6L,4L,6L,6L,4L,6L,10L,6L,6L,9L,9L,8L,11L,8L,12L,12L,9L,12L,16L,11L,12L,16L,15L,15L,18L,16L,18L,19L,17L,17L,24L,19L,20L,26L,24L,25L,27L,23L,26L,28L,21L,30L,39L,29L,30L,35L,32L,33L,38L,36L,38L,41L,36L,39L,48L,42L,41L,50L,44L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117173Inst : IEnumerable<long>
{
public static readonly long[] Value=A117173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117173.Bytes);
public long this[int i]=>Value[i];

public static A117173Inst Instance=new A117173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117174
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,7L,9L,11L,13L,12L,17L,15L,21L,23L,23L,22L,31L,27L,37L,36L,38L,36L,49L,43L,52L,54L,60L,54L,74L,58L,74L,74L,82L,83L,97L,77L,100L,104L,115L,100L,132L,107L,138L,137L,136L,130L,165L,140L,174L,165L,182L,166L,215L,189L,217L,200L,216L,207L,265L,208L,260L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117174Inst : IEnumerable<long>
{
public static readonly long[] Value=A117174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117174.Bytes);
public long this[int i]=>Value[i];

public static A117174Inst Instance=new A117174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117175
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,0L,-1L,-2L,0L,-3L,0L,-5L,-6L,-4L,-2L,-7L,-3L,-8L,-7L,-6L,-4L,-9L,-5L,-9L,-10L,-9L,-2L,-9L,3L,-2L,-4L,-4L,-7L,-2L,9L,2L,-7L,2L,9L,5L,14L,10L,7L,21L,20L,20L,28L,21L,20L,28L,35L,31L,28L,44L,45L,56L,50L,53L,65L,62L,37L,61L,54L,66L,69L,71L,59L,75L,83L,93L,97L,92L,60L,87L,74L,99L,95L,106L,98L,117L,104L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117175Inst : IEnumerable<long>
{
public static readonly long[] Value=A117175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117175.Bytes);
public long this[int i]=>Value[i];

public static A117175Inst Instance=new A117175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117176
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,16L,16L,24L,27L,35L,35L,51L,45L,65L,70L,79L,77L,107L,96L,132L,128L,146L,145L,193L,169L,211L,218L,251L,235L,308L,262L,335L,330L,373L,377L,449L,384L,483L,489L,555L,507L,638L,559L,696L,682L,726L,709L,873L,765L,923L,894L,995L,945L,1159L,1050L,1223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117176Inst : IEnumerable<long>
{
public static readonly long[] Value=A117176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117176.Bytes);
public long this[int i]=>Value[i];

public static A117176Inst Instance=new A117176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117177
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,25L,57L,115L,240L,484L,996L,1987L,4041L,8071L,16252L,32527L,65292L,130558L,261651L,523271L,1047533L,2095138L,4192255L,8384449L,16773161L,33546227L,67100496L,134201373L,268419000L,536837755L,1073709065L,2147417864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117177Inst : IEnumerable<long>
{
public static readonly long[] Value=A117177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117177.Bytes);
public long this[int i]=>Value[i];

public static A117177Inst Instance=new A117177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117178
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,1L,0L,4L,0L,1L,10L,0L,5L,0L,1L,0L,15L,0L,6L,0L,1L,35L,0L,21L,0L,7L,0L,1L,0L,56L,0L,28L,0L,8L,0L,1L,126L,0L,84L,0L,36L,0L,9L,0L,1L,0L,210L,0L,120L,0L,45L,0L,10L,0L,1L,462L,0L,330L,0L,165L,0L,55L,0L,11L,0L,1L,0L,792L,0L,495L,0L,220L,0L,66L,0L,12L,0L,1L,1716L,0L,1287L,0L,715L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117178Inst : IEnumerable<long>
{
public static readonly long[] Value=A117178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117178.Bytes);
public long this[int i]=>Value[i];

public static A117178Inst Instance=new A117178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117179
{
public static readonly long[] Value={ 1L,0L,1L,-3L,0L,1L,0L,-4L,0L,1L,5L,0L,-5L,0L,1L,0L,9L,0L,-6L,0L,1L,-7L,0L,14L,0L,-7L,0L,1L,0L,-16L,0L,20L,0L,-8L,0L,1L,9L,0L,-30L,0L,27L,0L,-9L,0L,1L,0L,25L,0L,-50L,0L,35L,0L,-10L,0L,1L,-11L,0L,55L,0L,-77L,0L,44L,0L,-11L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117179Inst : IEnumerable<long>
{
public static readonly long[] Value=A117179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117179.Bytes);
public long this[int i]=>Value[i];

public static A117179Inst Instance=new A117179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117180
{
public static readonly long[] Value={ 4L,8L,9L,3L,16L,2L,4L,3L,25L,27L,4L,32L,4L,5L,4L,5L,3L,49L,2L,4L,2L,7L,3L,7L,64L,4L,8L,3L,4L,5L,81L,3L,8L,2L,4L,3L,2L,9L,4L,8L,4L,7L,4L,9L,3L,121L,4L,125L,2L,128L,3L,5L,8L,4L,9L,3L,4L,2L,8L,9L,3L,5L,2L,4L,3L,169L,9L,4L,7L,11L,4L,8L,4L,7L,3L,4L,2L,8L,3L,9L,13L,4L,8L,4L,7L,9L,3L,8L,2L,4L,3L,2L,243L,4L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117180Inst : IEnumerable<long>
{
public static readonly long[] Value=A117180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117180.Bytes);
public long this[int i]=>Value[i];

public static A117180Inst Instance=new A117180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117181
{
public static readonly long[] Value={ 4L,8L,9L,4L,16L,9L,5L,8L,25L,27L,7L,32L,9L,8L,11L,9L,16L,49L,25L,13L,27L,8L,5L,9L,64L,17L,9L,25L,19L,16L,81L,7L,11L,9L,23L,32L,49L,11L,25L,13L,27L,16L,29L,13L,8L,121L,31L,125L,9L,128L,11L,27L,17L,7L,16L,49L,37L,25L,19L,17L,13L,32L,81L,41L,8L,169L,19L,43L,25L,16L,9L,23L,47L,27L,64L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117181Inst : IEnumerable<long>
{
public static readonly long[] Value=A117181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117181.Bytes);
public long this[int i]=>Value[i];

public static A117181Inst Instance=new A117181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117182
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,7L,1L,5L,0L,0L,3L,0L,5L,3L,7L,4L,13L,0L,23L,9L,25L,1L,2L,2L,0L,13L,1L,22L,15L,11L,0L,4L,3L,7L,19L,29L,47L,2L,21L,5L,23L,9L,25L,4L,5L,0L,27L,0L,7L,0L,8L,22L,9L,3L,7L,46L,33L,23L,11L,8L,10L,27L,79L,37L,5L,0L,10L,39L,18L,5L,5L,15L,43L,20L,61L,45L,9L,17L,14L,14L,3L,49L,19L,7L,25L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117182Inst : IEnumerable<long>
{
public static readonly long[] Value=A117182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117182.Bytes);
public long this[int i]=>Value[i];

public static A117182Inst Instance=new A117182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117183
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,2L,2L,2L,5L,3L,2L,2L,2L,2L,2L,3L,2L,7L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,11L,2L,5L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,13L,3L,2L,5L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,5L,2L,2L,2L,2L,2L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117183Inst : IEnumerable<long>
{
public static readonly long[] Value=A117183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117183.Bytes);
public long this[int i]=>Value[i];

public static A117183Inst Instance=new A117183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117184
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,4L,1L,1L,10L,4L,5L,1L,1L,10L,15L,5L,6L,1L,1L,35L,15L,21L,6L,7L,1L,1L,35L,56L,21L,28L,7L,8L,1L,1L,126L,56L,84L,28L,36L,8L,9L,1L,1L,126L,210L,84L,120L,36L,45L,9L,10L,1L,1L,462L,210L,330L,120L,165L,45L,55L,10L,11L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117184Inst : IEnumerable<long>
{
public static readonly long[] Value=A117184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117184.Bytes);
public long this[int i]=>Value[i];

public static A117184Inst Instance=new A117184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117185
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,-1L,1L,3L,-3L,-1L,1L,1L,4L,-4L,-1L,1L,-4L,4L,5L,-5L,-1L,1L,1L,-8L,8L,6L,-6L,-1L,1L,3L,-3L,-13L,13L,7L,-7L,-1L,1L,-2L,11L,-11L,-19L,19L,8L,-8L,-1L,1L,-1L,1L,24L,-24L,-26L,26L,9L,-9L,-1L,1L,1L,-12L,12L,43L,-43L,-34L,34L,10L,-10L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117185Inst : IEnumerable<long>
{
public static readonly long[] Value=A117185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117185.Bytes);
public long this[int i]=>Value[i];

public static A117185Inst Instance=new A117185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117186
{
public static readonly long[] Value={ 1L,2L,5L,9L,21L,38L,86L,157L,349L,642L,1410L,2610L,5682L,10572L,22860L,42717L,91869L,172298L,368906L,694054L,1480486L,2793012L,5938740L,11230834L,23813746L,45131348L,95462996L,181268292L,382594884L,727747608L,1533053976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117186Inst : IEnumerable<long>
{
public static readonly long[] Value=A117186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117186.Bytes);
public long this[int i]=>Value[i];

public static A117186Inst Instance=new A117186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117187
{
public static readonly long[] Value={ 1L,1L,4L,4L,15L,15L,56L,56L,210L,210L,792L,792L,3003L,3003L,11440L,11440L,43758L,43758L,167960L,167960L,646646L,646646L,2496144L,2496144L,9657700L,9657700L,37442160L,37442160L,145422675L,145422675L,565722720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117187Inst : IEnumerable<long>
{
public static readonly long[] Value=A117187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117187.Bytes);
public long this[int i]=>Value[i];

public static A117187Inst Instance=new A117187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117188
{
public static readonly long[] Value={ 1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117188Inst : IEnumerable<long>
{
public static readonly long[] Value=A117188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117188.Bytes);
public long this[int i]=>Value[i];

public static A117188Inst Instance=new A117188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117189
{
public static readonly long[] Value={ 1L,2L,5L,14L,40L,114L,324L,920L,2612L,7416L,21056L,59784L,169744L,481952L,1368400L,3885280L,11031424L,31321376L,88930368L,252498816L,716916544L,2035531648L,5779458048L,16409538688L,46591385856L,132286304768L,375598753024L,1066432564736L,3027907856384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117189Inst : IEnumerable<long>
{
public static readonly long[] Value=A117189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117189.Bytes);
public long this[int i]=>Value[i];

public static A117189Inst Instance=new A117189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117190
{
public static readonly long[] Value={ 1L,1L,1L,-3L,7L,3L,3L,-9L,7L,7L,19L,3L,-11L,-29L,-27L,-11L,61L,-3L,3L,-39L,-11L,-101L,9L,-23L,7L,13L,67L,-99L,-209L,-27L,-11L,-27L,-21L,-9L,193L,-23L,67L,43L,-59L,3L,-17L,109L,63L,57L,31L,-9L,-33L,33L,-33L,9L,-57L,121L,-231L,171L,31L,21L,3L,-93L,-149L,19L,7L,-39L,-83L,121L,-51L,49L,49L,49L,99L,9L,33L,-53L,39L,79L,-47L,129L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117190Inst : IEnumerable<long>
{
public static readonly long[] Value=A117190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117190.Bytes);
public long this[int i]=>Value[i];

public static A117190Inst Instance=new A117190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117191
{
public static readonly long[] Value={ 1L,5L,5L,4L,6L,8L,2L,2L,7L,5L,4L,8L,2L,1L,0L,0L,0L,8L,9L,8L,7L,0L,2L,3L,2L,0L,8L,0L,7L,8L,2L,8L,0L,4L,0L,0L,2L,0L,6L,0L,4L,4L,7L,3L,0L,6L,2L,6L,5L,6L,6L,1L,3L,7L,9L,0L,9L,8L,9L,2L,0L,2L,0L,4L,3L,3L,2L,8L,7L,7L,9L,4L,1L,5L,2L,9L,3L,2L,8L,0L,5L,3L,6L,5L,1L,1L,3L,9L,7L,6L,3L,8L,2L,3L,1L,8L,7L,4L,8L,9L,3L,6L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117191Inst : IEnumerable<long>
{
public static readonly long[] Value=A117191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117191.Bytes);
public long this[int i]=>Value[i];

public static A117191Inst Instance=new A117191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117192
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,2L,3L,2L,4L,6L,6L,7L,8L,12L,14L,16L,18L,24L,26L,32L,38L,46L,52L,60L,70L,83L,96L,112L,128L,148L,170L,194L,224L,256L,293L,334L,380L,432L,492L,556L,630L,712L,804L,908L,1026L,1152L,1296L,1454L,1632L,1828L,2048L,2292L,2560L,2858L,3190L,3554L,3959L,4404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117192Inst : IEnumerable<long>
{
public static readonly long[] Value=A117192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117192.Bytes);
public long this[int i]=>Value[i];

public static A117192Inst Instance=new A117192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117193
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,2L,2L,4L,4L,4L,6L,8L,10L,10L,13L,16L,20L,22L,28L,32L,38L,43L,52L,62L,72L,82L,96L,110L,128L,148L,170L,196L,224L,256L,292L,334L,380L,432L,490L,557L,630L,714L,806L,908L,1022L,1152L,1294L,1456L,1632L,1830L,2049L,2290L,2560L,2860L,3188L,3554L,3958L,4404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117193Inst : IEnumerable<long>
{
public static readonly long[] Value=A117193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117193.Bytes);
public long this[int i]=>Value[i];

public static A117193Inst Instance=new A117193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117194
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,3L,2L,4L,5L,6L,7L,8L,12L,13L,16L,18L,24L,26L,32L,37L,46L,52L,60L,70L,83L,96L,111L,128L,148L,170L,194L,224L,256L,293L,333L,380L,432L,492L,556L,630L,712L,804L,908L,1025L,1152L,1296L,1454L,1632L,1828L,2048L,2292L,2560L,2858L,3189L,3554L,3959L,4404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117194Inst : IEnumerable<long>
{
public static readonly long[] Value=A117194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117194.Bytes);
public long this[int i]=>Value[i];

public static A117194Inst Instance=new A117194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117195
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,2L,1L,1L,1L,0L,1L,1L,0L,2L,1L,2L,1L,1L,1L,0L,1L,0L,1L,1L,2L,2L,2L,1L,1L,1L,0L,1L,0L,1L,2L,2L,2L,2L,2L,1L,1L,1L,0L,1L,0L,1L,1L,3L,2L,3L,2L,2L,1L,1L,1L,0L,1L,0L,1L,2L,2L,4L,2L,3L,2L,2L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117195Inst : IEnumerable<long>
{
public static readonly long[] Value=A117195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117195.Bytes);
public long this[int i]=>Value[i];

public static A117195Inst Instance=new A117195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117196
{
public static readonly long[] Value={ 2L,11L,19L,23L,71L,863L,3989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117196Inst : IEnumerable<long>
{
public static readonly long[] Value=A117196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117196.Bytes);
public long this[int i]=>Value[i];

public static A117196Inst Instance=new A117196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117197
{
public static readonly long[] Value={ 0L,343L,17576L,250047L,1906624L,9938375L,40001688L,133432831L,385828352L,997002999L,2352637000L,5150827583L,10590025536L,20638466407L,38409197624L,68669157375L,118515478528L,198257271191L,322546580712L,511808023999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117197Inst : IEnumerable<long>
{
public static readonly long[] Value=A117197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117197.Bytes);
public long this[int i]=>Value[i];

public static A117197Inst Instance=new A117197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117198
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117198Inst : IEnumerable<long>
{
public static readonly long[] Value=A117198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117198.Bytes);
public long this[int i]=>Value[i];

public static A117198Inst Instance=new A117198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117199
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117199Inst : IEnumerable<long>
{
public static readonly long[] Value=A117199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117199.Bytes);
public long this[int i]=>Value[i];

public static A117199Inst Instance=new A117199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117200
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,1L,-1L,0L,1L,0L,0L,0L,0L,1L,2L,-1L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,0L,-1L,0L,0L,0L,1L,1L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-3L,2L,1L,-1L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117200Inst : IEnumerable<long>
{
public static readonly long[] Value=A117200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117200.Bytes);
public long this[int i]=>Value[i];

public static A117200Inst Instance=new A117200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117201
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,-1L,1L,0L,0L,1L,1L,-1L,1L,1L,0L,0L,1L,2L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,3L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,-2L,1L,0L,0L,1L,1L,2L,1L,0L,0L,0L,1L,-1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,-4L,1L,0L,0L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117201Inst : IEnumerable<long>
{
public static readonly long[] Value=A117201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117201.Bytes);
public long this[int i]=>Value[i];

public static A117201Inst Instance=new A117201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117202
{
public static readonly long[] Value={ 0L,1L,4L,15L,52L,170L,534L,1631L,4880L,14373L,41810L,120406L,343884L,975325L,2749852L,7713435L,21540304L,59917826L,166094370L,458998523L,1264919720L,3477182961L,9536877614L,26102772910L,71309161752L,194468551225L,529490287924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117202Inst : IEnumerable<long>
{
public static readonly long[] Value=A117202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117202.Bytes);
public long this[int i]=>Value[i];

public static A117202Inst Instance=new A117202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117203
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,15L,21L,23L,29L,31L,35L,39L,43L,47L,53L,59L,61L,67L,69L,71L,77L,79L,83L,85L,87L,93L,95L,103L,107L,111L,115L,119L,123L,131L,133L,139L,141L,143L,149L,155L,157L,159L,165L,167L,173L,179L,183L,187L,191L,195L,203L,205L,211L,213L,215L,219L,221L,223L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117203Inst : IEnumerable<long>
{
public static readonly long[] Value=A117203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117203.Bytes);
public long this[int i]=>Value[i];

public static A117203Inst Instance=new A117203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117204
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,11L,14L,15L,17L,19L,21L,23L,26L,29L,30L,33L,34L,35L,38L,39L,41L,42L,43L,46L,47L,51L,53L,55L,57L,59L,61L,65L,66L,69L,70L,71L,74L,77L,78L,79L,82L,83L,86L,89L,91L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117204Inst : IEnumerable<long>
{
public static readonly long[] Value=A117204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117204.Bytes);
public long this[int i]=>Value[i];

public static A117204Inst Instance=new A117204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117205
{
public static readonly long[] Value={ 1L,3L,5L,11L,13L,19L,21L,29L,33L,37L,41L,43L,51L,57L,59L,61L,65L,67L,69L,73L,77L,83L,85L,91L,93L,101L,105L,109L,113L,115L,123L,129L,131L,133L,137L,139L,141L,145L,155L,157L,163L,165L,173L,177L,181L,185L,187L,193L,201L,203L,205L,209L,211L,213L,217L,219L,221L,227L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117205Inst : IEnumerable<long>
{
public static readonly long[] Value=A117205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117205.Bytes);
public long this[int i]=>Value[i];

public static A117205Inst Instance=new A117205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117206
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,10L,11L,15L,17L,19L,21L,22L,26L,29L,30L,31L,33L,34L,35L,37L,39L,42L,43L,46L,47L,51L,53L,55L,57L,58L,62L,65L,66L,67L,69L,70L,71L,73L,78L,79L,82L,83L,87L,89L,91L,93L,94L,97L,101L,102L,103L,105L,106L,107L,109L,110L,111L,114L,115L,118L,119L,127L,129L,130L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117206Inst : IEnumerable<long>
{
public static readonly long[] Value=A117206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117206.Bytes);
public long this[int i]=>Value[i];

public static A117206Inst Instance=new A117206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117207
{
public static readonly long[] Value={ 1L,3L,1L,10L,7L,1L,35L,31L,13L,1L,126L,121L,81L,21L,1L,462L,456L,381L,181L,31L,1L,1716L,1709L,1583L,1058L,358L,43L,1L,6435L,6427L,6231L,5055L,2605L,645L,57L,1L,24310L,24301L,24013L,21661L,14605L,5785L,1081L,73L,1L,92378L,92368L,91963L,87643L,70003L,38251L,11791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117207Inst : IEnumerable<long>
{
public static readonly long[] Value=A117207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117207.Bytes);
public long this[int i]=>Value[i];

public static A117207Inst Instance=new A117207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117208
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,-1L,2L,-1L,1L,0L,1L,0L,1L,0L,0L,2L,-1L,2L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,1L,0L,2L,0L,3L,0L,0L,2L,0L,3L,0L,3L,-1L,2L,0L,4L,1L,1L,3L,-3L,5L,1L,3L,0L,2L,-1L,2L,4L,2L,4L,-5L,6L,-1L,2L,7L,-2L,1L,-1L,4L,3L,5L,2L,-2L,1L,1L,8L,2L,4L,-1L,-3L,4L,9L,4L,-2L,4L,-7L,6L,7L,10L,-1L,-3L,-1L,1L,11L,4L,8L,-15L,2L,5L,7L,13L,1L,-9L,-7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117208Inst : IEnumerable<long>
{
public static readonly long[] Value=A117208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117208.Bytes);
public long this[int i]=>Value[i];

public static A117208Inst Instance=new A117208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117209
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,-1L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,1L,2L,-1L,-1L,-2L,0L,1L,3L,-1L,0L,-1L,1L,-1L,1L,-3L,1L,-1L,1L,-2L,3L,0L,6L,-1L,-1L,-6L,2L,-4L,4L,-3L,2L,-4L,6L,-5L,6L,-2L,7L,-5L,4L,-13L,5L,-3L,11L,-6L,8L,-14L,10L,-6L,9L,-14L,11L,-14L,15L,-13L,9L,-15L,24L,-13L,19L,-21L,12L,-20L,27L,-24L,21L,-26L,22L,-24L,33L,-33L,32L,-26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117209Inst : IEnumerable<long>
{
public static readonly long[] Value=A117209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117209.Bytes);
public long this[int i]=>Value[i];

public static A117209Inst Instance=new A117209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117210
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,0L,1L,1L,0L,-1L,-1L,2L,1L,-2L,-3L,2L,4L,2L,-5L,-4L,0L,5L,2L,1L,-5L,-1L,2L,5L,-5L,-2L,-2L,5L,-1L,3L,-6L,2L,0L,11L,-6L,-4L,-10L,12L,-1L,6L,-13L,5L,-8L,16L,-8L,9L,-13L,17L,-17L,7L,-21L,25L,-10L,22L,-29L,20L,-24L,34L,-24L,27L,-44L,35L,-32L,39L,-52L,45L,-39L,66L,-53L,47L,-76L,70L,-55L,79L,-98L,66L,-84L,115L,-89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117210Inst : IEnumerable<long>
{
public static readonly long[] Value=A117210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117210.Bytes);
public long this[int i]=>Value[i];

public static A117210Inst Instance=new A117210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117211
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,1L,1L,-2L,4L,-4L,4L,-3L,2L,0L,-1L,2L,-3L,4L,-5L,5L,-4L,4L,-3L,1L,1L,-2L,3L,-5L,5L,-5L,3L,-1L,1L,3L,-4L,3L,-2L,2L,-1L,-3L,4L,-6L,4L,-4L,5L,0L,-4L,2L,-1L,4L,-2L,3L,-3L,6L,-9L,7L,-1L,1L,-4L,-8L,10L,-6L,10L,-11L,12L,-9L,-4L,7L,-7L,15L,-25L,10L,-5L,13L,1L,-6L,16L,-21L,14L,-15L,28L,-6L,-12L,-3L,1L,18L,-18L,17L,-25L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117211Inst : IEnumerable<long>
{
public static readonly long[] Value=A117211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117211.Bytes);
public long this[int i]=>Value[i];

public static A117211Inst Instance=new A117211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117212
{
public static readonly long[] Value={ 1L,-3L,-2L,1L,-4L,6L,-6L,1L,-2L,12L,-10L,-2L,-12L,18L,8L,1L,-16L,6L,-18L,-4L,12L,30L,-22L,-2L,-4L,36L,-2L,-6L,-28L,-24L,-30L,1L,20L,48L,24L,-2L,-36L,54L,24L,-4L,-40L,-36L,-42L,-10L,8L,66L,-46L,-2L,-6L,12L,32L,-12L,-52L,6L,40L,-6L,36L,84L,-58L,8L,-60L,90L,12L,1L,48L,-60L,-66L,-16L,44L,-72L,-70L,-2L,-72L,108L,8L,-18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117212Inst : IEnumerable<long>
{
public static readonly long[] Value=A117212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117212.Bytes);
public long this[int i]=>Value[i];

public static A117212Inst Instance=new A117212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117213
{
public static readonly long[] Value={ 1L,2L,6L,30L,6L,210L,30L,2310L,30030L,210L,30L,510510L,9699690L,210L,2310L,223092870L,30030L,6469693230L,30L,200560490130L,2310L,510510L,210L,7420738134810L,9699690L,30030L,304250263527210L,210L,13082761331670030L,223092870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117213Inst : IEnumerable<long>
{
public static readonly long[] Value=A117213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117213.Bytes);
public long this[int i]=>Value[i];

public static A117213Inst Instance=new A117213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117214
{
public static readonly long[] Value={ 1L,1L,2L,6L,1L,30L,3L,210L,2310L,15L,2L,30030L,510510L,10L,105L,9699690L,1155L,223092870L,1L,6469693230L,70L,15015L,6L,200560490130L,255255L,770L,7420738134810L,5L,304250263527210L,4849845L,13082761331670030L,10010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117214Inst : IEnumerable<long>
{
public static readonly long[] Value=A117214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117214.Bytes);
public long this[int i]=>Value[i];

public static A117214Inst Instance=new A117214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117215
{
public static readonly long[] Value={ 2L,4L,4L,8L,4L,2L,4L,16L,8L,2L,4L,2L,4L,2L,1L,32L,4L,14L,4L,2L,1L,2L,4L,20L,8L,2L,16L,2L,4L,2L,4L,64L,1L,2L,1L,18L,4L,2L,1L,2L,4L,2L,4L,2L,2L,2L,4L,2L,8L,14L,1L,2L,4L,70L,1L,2L,1L,2L,4L,2L,4L,2L,1L,128L,1L,2L,4L,2L,1L,2L,4L,10L,4L,2L,8L,2L,1L,2L,4L,4L,32L,2L,4L,2L,1L,2L,1L,2L,4L,2L,1L,2L,1L,2L,1L,32L,4L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117215Inst : IEnumerable<long>
{
public static readonly long[] Value=A117215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117215.Bytes);
public long this[int i]=>Value[i];

public static A117215Inst Instance=new A117215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117216
{
public static readonly long[] Value={ 1L,40L,272L,888L,2080L,4040L,6960L,11032L,16448L,23400L,32080L,42680L,55392L,70408L,87920L,108120L,131200L,157352L,186768L,219640L,256160L,296520L,340912L,389528L,442560L,500200L,562640L,630072L,702688L,780680L,864240L,953560L,1048832L,1150248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117216Inst : IEnumerable<long>
{
public static readonly long[] Value=A117216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117216.Bytes);
public long this[int i]=>Value[i];

public static A117216Inst Instance=new A117216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117217
{
public static readonly long[] Value={ 2L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,12L,12L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117217Inst : IEnumerable<long>
{
public static readonly long[] Value=A117217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117217.Bytes);
public long this[int i]=>Value[i];

public static A117217Inst Instance=new A117217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117218
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,36L,64L,144L,225L,324L,441L,576L,729L,900L,1024L,1156L,1296L,1444L,1600L,1764L,1936L,2116L,2304L,2500L,2704L,2916L,3136L,3364L,3600L,3844L,4096L,4356L,4624L,4900L,5184L,5476L,5776L,6084L,6400L,6724L,7056L,7396L,7744L,8100L,8464L,8836L,9216L,9604L,10000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117218Inst : IEnumerable<long>
{
public static readonly long[] Value=A117218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117218.Bytes);
public long this[int i]=>Value[i];

public static A117218Inst Instance=new A117218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117219
{
public static readonly long[] Value={ 0L,1L,8L,64L,216L,729L,1000L,1728L,2744L,4096L,5832L,8000L,15625L,27000L,42875L,64000L,91125L,110592L,157464L,216000L,287496L,373248L,474552L,592704L,729000L,884736L,1157625L,1404928L,1685159L,2000376L,2352637L,2744000L,3176523L,3652264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117219Inst : IEnumerable<long>
{
public static readonly long[] Value=A117219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117219.Bytes);
public long this[int i]=>Value[i];

public static A117219Inst Instance=new A117219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117220
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,12L,19L,30L,37L,61L,75L,102L,127L,217L,271L,374L,469L,588L,817L,1027L,1430L,1801L,2269L,3169L,3997L,5043L,5590L,7057L,8911L,12481L,15769L,19927L,22102L,27937L,35317L,44652L,49537L,62641L,79219L,87894L,111169L,140617L,177877L,197377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117220Inst : IEnumerable<long>
{
public static readonly long[] Value=A117220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117220.Bytes);
public long this[int i]=>Value[i];

public static A117220Inst Instance=new A117220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117221
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,22L,30L,77L,231L,385L,1575L,3010L,8349L,17977L,147273L,386155L,1741630L,5392783L,18004327L,118114304L,483502844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117221Inst : IEnumerable<long>
{
public static readonly long[] Value=A117221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117221.Bytes);
public long this[int i]=>Value[i];

public static A117221Inst Instance=new A117221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117222
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,18L,23L,53L,128L,194L,586L,947L,2070L,3667L,16762L,33036L,93402L,200626L,445869L,1517300L,3715025L,14526494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117222Inst : IEnumerable<long>
{
public static readonly long[] Value=A117222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117222.Bytes);
public long this[int i]=>Value[i];

public static A117222Inst Instance=new A117222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117223
{
public static readonly long[] Value={ 231L,399L,435L,465L,483L,651L,663L,741L,861L,885L,903L,915L,1113L,1173L,1209L,1281L,1311L,1335L,1353L,1443L,1479L,1533L,1581L,1599L,1653L,1743L,1833L,1947L,2163L,2211L,2235L,2247L,2265L,2301L,2337L,2379L,2409L,2485L,2667L,2685L,2715L,2829L,2877L,2915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117223Inst : IEnumerable<long>
{
public static readonly long[] Value=A117223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117223.Bytes);
public long this[int i]=>Value[i];

public static A117223Inst Instance=new A117223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117224
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,24L,28L,30L,37L,60L,64L,81L,87L,93L,100L,114L,118L,136L,163L,219L,222L,228L,234L,240L,252L,258L,267L,273L,276L,280L,291L,294L,300L,312L,316L,342L,343L,370L,384L,387L,433L,447L,468L,469L,477L,478L,507L,525L,534L,537L,541L,585L,591L,600L,606L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117224Inst : IEnumerable<long>
{
public static readonly long[] Value=A117224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117224.Bytes);
public long this[int i]=>Value[i];

public static A117224Inst Instance=new A117224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117225
{
public static readonly long[] Value={ 185371L,129281L,86771L,55501L,33347L,18401L,8971L,3581L,971L,97L,131L,461L,691L,641L,347L,61L,251L,1601L,5011L,11597L,22691L,39841L,64811L,99581L,146347L,207521L,285731L,383821L,504851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117225Inst : IEnumerable<long>
{
public static readonly long[] Value=A117225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117225.Bytes);
public long this[int i]=>Value[i];

public static A117225Inst Instance=new A117225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117226
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,110L,630L,4204L,32054L,274914L,2619692L,27459344L,313990182L,3889585408L,51888955808L,741668212080L,11307669002720L,183174676857608L,3141820432768752L,56882461258572976L,1084056190235653304L,BigInteger.Parse("21692744773505849952"),BigInteger.Parse("454758269790599361968") };
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
public class A117226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117226Inst Instance=new A117226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117227
{
public static readonly long[] Value={ 12L,20L,28L,33L,41L,46L,51L,54L,62L,67L,72L,75L,83L,88L,93L,96L,101L,104L,112L,117L,122L,125L,130L,133L,138L,141L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117227Inst : IEnumerable<long>
{
public static readonly long[] Value=A117227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117227.Bytes);
public long this[int i]=>Value[i];

public static A117227Inst Instance=new A117227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117228
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,111L,2112L,4224L,13131L,21112L,21312L,31113L,42624L,211112L,234432L,1113111L,2111112L,2114112L,2118112L,21122112L,61111116L,111111111L,211121112L,211242112L,211262112L,213141312L,2111111112L,2112332112L,2114114112L,2131221312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117228Inst : IEnumerable<long>
{
public static readonly long[] Value=A117228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117228.Bytes);
public long this[int i]=>Value[i];

public static A117228Inst Instance=new A117228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117229
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,3L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117229Inst : IEnumerable<long>
{
public static readonly long[] Value=A117229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117229.Bytes);
public long this[int i]=>Value[i];

public static A117229Inst Instance=new A117229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117230
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117230Inst : IEnumerable<long>
{
public static readonly long[] Value=A117230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117230.Bytes);
public long this[int i]=>Value[i];

public static A117230Inst Instance=new A117230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117231
{
public static readonly long[] Value={ 3L,2L,3L,3L,6L,7L,4L,3L,1L,6L,7L,7L,7L,7L,8L,7L,6L,1L,3L,9L,9L,3L,7L,0L,0L,8L,7L,9L,5L,2L,1L,7L,0L,4L,4L,6L,6L,5L,1L,0L,4L,6L,6L,2L,5L,7L,2L,5L,4L,6L,9L,6L,6L,1L,6L,8L,1L,0L,3L,6L,4L,4L,3L,4L,3L,1L,7L,9L,0L,3L,3L,7L,2L,1L,0L,6L,7L,2L,8L,9L,4L,4L,3L,1L,9L,3L,0L,3L,7L,0L,4L,6L,4L,1L,0L,2L,4L,5L,1L,3L,8L,0L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117231Inst : IEnumerable<long>
{
public static readonly long[] Value=A117231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117231.Bytes);
public long this[int i]=>Value[i];

public static A117231Inst Instance=new A117231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117232
{
public static readonly long[] Value={ 9L,9L,5L,2L,6L,2L,9L,1L,9L,4L,4L,3L,3L,5L,4L,1L,6L,0L,8L,9L,0L,3L,1L,1L,8L,0L,9L,4L,2L,6L,7L,2L,1L,6L,2L,1L,0L,2L,9L,4L,6L,6L,9L,2L,2L,7L,3L,4L,1L,5L,4L,3L,4L,9L,8L,0L,3L,2L,0L,8L,8L,5L,8L,0L,7L,2L,9L,8L,6L,1L,7L,9L,6L,2L,2L,8L,3L,0L,6L,3L,2L,0L,9L,9L,1L,7L,4L,9L,8L,1L,8L,9L,7L,6L,1L,8L,8L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117232Inst : IEnumerable<long>
{
public static readonly long[] Value=A117232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117232.Bytes);
public long this[int i]=>Value[i];

public static A117232Inst Instance=new A117232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117233
{
public static readonly long[] Value={ 1L,2L,7L,4L,2L,2L,4L,1L,5L,2L,8L,2L,1L,2L,2L,8L,1L,8L,8L,2L,1L,2L,3L,4L,0L,6L,3L,9L,7L,2L,5L,0L,7L,8L,0L,9L,9L,4L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117233Inst : IEnumerable<long>
{
public static readonly long[] Value=A117233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117233.Bytes);
public long this[int i]=>Value[i];

public static A117233Inst Instance=new A117233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117234
{
public static readonly long[] Value={ 3L,3L,0L,6L,8L,6L,8L,6L,4L,7L,4L,7L,5L,2L,3L,7L,2L,8L,0L,0L,7L,6L,1L,1L,3L,7L,7L,0L,8L,9L,8L,5L,1L,5L,6L,5L,7L,1L,6L,6L,4L,8L,2L,3L,6L,1L,4L,7L,6L,2L,8L,8L,2L,1L,7L,5L,0L,1L,2L,9L,3L,0L,8L,5L,4L,9L,6L,3L,0L,9L,1L,9L,9L,8L,3L,7L,8L,8L,8L,2L,9L,5L,0L,3L,5L,8L,2L,5L,4L,8L,8L,0L,7L,5L,2L,8L,3L,4L,9L,9L,1L,8L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117234Inst : IEnumerable<long>
{
public static readonly long[] Value=A117234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117234.Bytes);
public long this[int i]=>Value[i];

public static A117234Inst Instance=new A117234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117235
{
public static readonly long[] Value={ 2L,1L,4L,3L,3L,5L,2L,3L,4L,5L,9L,0L,4L,5L,9L,6L,3L,9L,4L,6L,1L,5L,2L,6L,4L,0L,0L,1L,8L,4L,7L,4L,9L,3L,9L,6L,1L,1L,3L,4L,0L,7L,2L,8L,7L,7L,8L,9L,5L,1L,6L,7L,0L,8L,0L,7L,3L,9L,3L,4L,9L,8L,5L,9L,7L,0L,9L,8L,7L,6L,7L,6L,0L,7L,4L,0L,5L,4L,5L,9L,8L,1L,6L,9L,4L,7L,9L,8L,8L,4L,7L,8L,8L,8L,3L,0L,5L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117235Inst : IEnumerable<long>
{
public static readonly long[] Value=A117235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117235.Bytes);
public long this[int i]=>Value[i];

public static A117235Inst Instance=new A117235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117236
{
public static readonly long[] Value={ 0L,6L,1L,9L,1L,3L,9L,5L,4L,4L,7L,3L,9L,9L,0L,9L,4L,2L,8L,4L,8L,1L,7L,5L,2L,1L,6L,4L,7L,3L,2L,1L,2L,1L,7L,6L,9L,9L,9L,6L,3L,8L,7L,7L,4L,9L,9L,8L,3L,6L,2L,0L,7L,6L,0L,6L,1L,4L,6L,7L,2L,5L,8L,8L,5L,9L,9L,3L,1L,0L,1L,0L,2L,9L,7L,5L,9L,6L,1L,5L,8L,4L,5L,9L,0L,7L,1L,0L,5L,6L,4L,5L,7L,5L,2L,0L,8L,7L,8L,6L,1L,3L,7L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117236Inst : IEnumerable<long>
{
public static readonly long[] Value=A117236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117236.Bytes);
public long this[int i]=>Value[i];

public static A117236Inst Instance=new A117236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117237
{
public static readonly long[] Value={ 7L,2L,5L,0L,7L,8L,3L,4L,6L,2L,6L,8L,4L,0L,1L,1L,6L,7L,4L,6L,8L,6L,8L,7L,7L,1L,9L,2L,5L,1L,1L,6L,0L,9L,6L,8L,8L,6L,9L,1L,8L,0L,5L,9L,4L,4L,7L,9L,5L,0L,8L,9L,5L,7L,8L,7L,8L,1L,6L,4L,7L,6L,9L,2L,0L,7L,7L,7L,3L,1L,8L,9L,9L,9L,4L,5L,9L,6L,2L,8L,3L,5L,7L,3L,5L,9L,2L,3L,9L,2L,7L,8L,6L,4L,7L,8L,2L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117237Inst : IEnumerable<long>
{
public static readonly long[] Value=A117237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117237.Bytes);
public long this[int i]=>Value[i];

public static A117237Inst Instance=new A117237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117238
{
public static readonly long[] Value={ 4L,2L,4L,0L,1L,1L,3L,8L,7L,0L,3L,3L,6L,8L,8L,3L,6L,3L,7L,9L,7L,4L,3L,3L,6L,6L,8L,5L,9L,3L,2L,5L,6L,4L,5L,1L,2L,4L,7L,7L,6L,2L,0L,9L,0L,6L,6L,4L,2L,7L,4L,7L,6L,2L,1L,9L,7L,1L,1L,2L,4L,9L,5L,9L,1L,3L,3L,1L,0L,1L,7L,6L,9L,5L,7L,5L,6L,3L,6L,9L,2L,2L,9L,7L,0L,7L,2L,4L,4L,2L,2L,9L,4L,4L,7L,7L,0L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117238Inst : IEnumerable<long>
{
public static readonly long[] Value=A117238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117238.Bytes);
public long this[int i]=>Value[i];

public static A117238Inst Instance=new A117238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117239
{
public static readonly long[] Value={ 7L,8L,5L,9L,3L,3L,6L,7L,4L,3L,5L,0L,3L,7L,1L,4L,5L,4L,5L,6L,5L,2L,4L,3L,9L,8L,6L,3L,2L,7L,5L,4L,5L,5L,8L,2L,9L,6L,2L,3L,9L,5L,4L,5L,9L,0L,6L,1L,8L,6L,6L,8L,1L,7L,5L,8L,1L,2L,3L,1L,8L,0L,7L,0L,9L,8L,9L,1L,0L,3L,9L,7L,1L,4L,9L,4L,1L,2L,3L,6L,5L,1L,1L,6L,7L,7L,0L,6L,3L,3L,7L,6L,5L,9L,9L,4L,4L,9L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117239Inst : IEnumerable<long>
{
public static readonly long[] Value=A117239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117239.Bytes);
public long this[int i]=>Value[i];

public static A117239Inst Instance=new A117239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117240
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,3L,8L,3L,7L,5L,8L,7L,9L,7L,9L,2L,5L,1L,2L,2L,6L,1L,0L,3L,4L,0L,7L,1L,3L,3L,1L,8L,6L,2L,0L,4L,8L,3L,9L,1L,0L,0L,7L,9L,3L,0L,0L,5L,5L,9L,4L,0L,7L,2L,5L,0L,9L,5L,6L,9L,0L,3L,0L,0L,2L,2L,7L,9L,9L,1L,7L,3L,4L,3L,6L,6L,0L,6L,8L,5L,2L,7L,4L,3L,2L,7L,6L,5L,0L,0L,8L,4L,2L,8L,4L,5L,6L,4L,7L,2L,6L,9L,9L,1L,0L,1L,5L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117240Inst : IEnumerable<long>
{
public static readonly long[] Value=A117240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117240.Bytes);
public long this[int i]=>Value[i];

public static A117240Inst Instance=new A117240Inst();

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