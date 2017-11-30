using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A089139
{
public static readonly long[] Value={ 8L,6L,6L,6L,6L,0L,4L,4L,9L,0L,0L,3L,2L,6L,9L,5L,4L,3L,7L,2L,2L,5L,4L,7L,9L,2L,4L,8L,3L,7L,3L,6L,2L,9L,9L,2L,1L,8L,9L,4L,7L,7L,0L,1L,4L,8L,4L,3L,8L,6L,5L,3L,0L,1L,1L,7L,0L,2L,8L,8L,5L,6L,4L,3L,2L,1L,4L,9L,2L,5L,9L,5L,2L,7L,5L,9L,1L,3L,9L,2L,1L,5L,7L,3L,6L,8L,8L,3L,6L,8L,8L,2L,5L,6L,3L,9L,6L,8L,8L,7L,9L,6L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089139Inst : IEnumerable<long>
{
public static readonly long[] Value=A089139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089139.Bytes);
public long this[int i]=>Value[i];

public static A089139Inst Instance=new A089139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089140
{
public static readonly long[] Value={ 2L,4L,8L,15L,26L,40L,60L,84L,114L,149L,190L,234L,288L,346L,411L,484L,565L,649L,743L,840L,947L,1063L,1185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089140Inst : IEnumerable<long>
{
public static readonly long[] Value=A089140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089140.Bytes);
public long this[int i]=>Value[i];

public static A089140Inst Instance=new A089140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089141
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,3L,5L,4L,1L,1L,13L,11L,5L,1L,2L,23L,37L,19L,6L,1L,1L,51L,107L,81L,29L,7L,1L,4L,97L,332L,319L,151L,41L,8L,1L,1L,207L,985L,1295L,749L,253L,55L,9L,1L,2L,401L,2992L,5161L,3774L,1511L,393L,71L,10L,1L,1L,825L,8939L,20725L,19021L,9107L,2743L,577L,89L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089141Inst : IEnumerable<long>
{
public static readonly long[] Value=A089141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089141.Bytes);
public long this[int i]=>Value[i];

public static A089141Inst Instance=new A089141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089142
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,13L,88L,177L,184L,297L,304L,310L,562L,892L,1300L,4047L,5557L,9028L,15597L,28527L,56890L,77485L,79378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089142Inst : IEnumerable<long>
{
public static readonly long[] Value=A089142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089142.Bytes);
public long this[int i]=>Value[i];

public static A089142Inst Instance=new A089142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089143
{
public static readonly long[] Value={ 3L,12L,30L,66L,138L,282L,570L,1146L,2298L,4602L,9210L,18426L,36858L,73722L,147450L,294906L,589818L,1179642L,2359290L,4718586L,9437178L,18874362L,37748730L,75497466L,150994938L,301989882L,603979770L,1207959546L,2415919098L,4831838202L,9663676410L,19327352826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089143Inst : IEnumerable<long>
{
public static readonly long[] Value=A089143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089143.Bytes);
public long this[int i]=>Value[i];

public static A089143Inst Instance=new A089143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089144
{
public static readonly long[] Value={ 2L,3L,7L,17L,19L,47L,53L,59L,67L,103L,113L,127L,157L,239L,269L,283L,313L,379L,383L,397L,449L,467L,577L,613L,617L,647L,823L,829L,907L,929L,977L,1097L,1123L,1279L,1373L,1447L,1489L,1523L,1697L,1723L,1789L,1877L,1933L,2017L,2027L,2063L,2069L,2237L,2339L,2423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089144Inst : IEnumerable<long>
{
public static readonly long[] Value=A089144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089144.Bytes);
public long this[int i]=>Value[i];

public static A089144Inst Instance=new A089144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089145
{
public static readonly long[] Value={ 3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L,2L,3L,2L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089145Inst : IEnumerable<long>
{
public static readonly long[] Value=A089145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089145.Bytes);
public long this[int i]=>Value[i];

public static A089145Inst Instance=new A089145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089146
{
public static readonly long[] Value={ 4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L,1L,8L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089146Inst : IEnumerable<long>
{
public static readonly long[] Value=A089146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089146.Bytes);
public long this[int i]=>Value[i];

public static A089146Inst Instance=new A089146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089147
{
public static readonly long[] Value={ 1L,3L,9L,13L,42L,51L,54L,91L,120L,168L,510L,819L,1071L,1756L,3010L,4333L,9534L,17839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089147Inst : IEnumerable<long>
{
public static readonly long[] Value=A089147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089147.Bytes);
public long this[int i]=>Value[i];

public static A089147Inst Instance=new A089147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089148
{
public static readonly BigInteger[] Value={ 1L,0L,-1L,-1L,5L,19L,-41L,-519L,-183L,19223L,73451L,-847067L,-8554547L,32488611L,977198559L,1325135969L,-116987762287L,-860498433233L,13730866757587L,243612350234973L,-1120827248102379L,-62079344419449925L,-185852602587850681L,15185914155303053209UL };
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
public class A089148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089148Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089148.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089148Inst Instance=new A089148Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089149
{
public static readonly BigInteger[] Value={ 1L,4L,9L,16L,125L,1296L,16807L,549755813888L,BigInteger.Parse("523347633027360537213511521"),BigInteger.Parse("10000000000000000000000000000000"),BigInteger.Parse("340039485861577398992406882305761986971") };
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
public class A089149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089149Inst Instance=new A089149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089150
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,5L,13L,28L,31L,37L,58L,89L,747L,1252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089150Inst : IEnumerable<long>
{
public static readonly long[] Value=A089150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089150.Bytes);
public long this[int i]=>Value[i];

public static A089150Inst Instance=new A089150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089151
{
public static readonly long[] Value={ 2L,3L,11L,13L,19L,31L,41L,53L,59L,71L,73L,101L,139L,173L,193L,239L,269L,271L,313L,349L,353L,379L,433L,449L,521L,563L,613L,643L,683L,823L,829L,881L,941L,1051L,1061L,1093L,1223L,1249L,1259L,1373L,1399L,1439L,1471L,1571L,1621L,1669L,1723L,1811L,1861L,1951L,1973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089151Inst : IEnumerable<long>
{
public static readonly long[] Value=A089151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089151.Bytes);
public long this[int i]=>Value[i];

public static A089151Inst Instance=new A089151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089152
{
public static readonly long[] Value={ 3L,11L,13L,19L,31L,41L,59L,71L,73L,101L,139L,193L,239L,269L,271L,313L,349L,433L,521L,643L,823L,829L,881L,1051L,1061L,1093L,1621L,1669L,1723L,1951L,2549L,2999L,3359L,3373L,3463L,3469L,3583L,4019L,4219L,4481L,4483L,4519L,5233L,5639L,5881L,6089L,6131L,6133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089152Inst : IEnumerable<long>
{
public static readonly long[] Value=A089152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089152.Bytes);
public long this[int i]=>Value[i];

public static A089152Inst Instance=new A089152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089153
{
public static readonly long[] Value={ 1L,6L,59L,812L,14389L,104038L,534113L,15837352L,177575597L,6681333014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089153Inst : IEnumerable<long>
{
public static readonly long[] Value=A089153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089153.Bytes);
public long this[int i]=>Value[i];

public static A089153Inst Instance=new A089153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089154
{
public static readonly long[] Value={ 4L,30L,190L,1176L,7252L,44694L,275422L,1697232L,10458820L,64450158L,397159774L,2447408808L,15081612628L,92937084582L,572704120126L,3529161805344L,21747674952196L,134015211518526L,825838944063358L,5089048875898680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089154Inst : IEnumerable<long>
{
public static readonly long[] Value=A089154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089154.Bytes);
public long this[int i]=>Value[i];

public static A089154Inst Instance=new A089154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089155
{
public static readonly BigInteger[] Value={ 1L,5L,47L,687L,14001L,369645L,12013695L,463731975L,20719022625L,1051207269525L,59685242540175L,3748724456313375L,258029176261158225L,BigInteger.Parse("19313242781012905725"),BigInteger.Parse("1561734017924407502175"),BigInteger.Parse("135675820682608239408375") };
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
public class A089155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089155Inst Instance=new A089155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089156
{
public static readonly BigInteger[] Value={ 0L,16L,576L,25600L,1254400L,65028096L,3497066496L,192980975616L,10855179878400L,619683355033600L,35792910586740736L,2087229562810269696L,BigInteger.Parse("122682715414070296576"),BigInteger.Parse("7259332273021911040000"),BigInteger.Parse("432004345063916175360000"),BigInteger.Parse("25835779854133582469529600") };
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
public class A089156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089156Inst Instance=new A089156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089157
{
public static readonly long[] Value={ 0L,3L,62L,115L,188L,524L,535L,647L,1459L,2656L,2960L,3370L,8595L,8889L,9201L,9491L,11364L,11808L,12508L,13425L,13968L,14241L,15448L,15669L,20887L,22214L,24545L,27457L,28524L,31982L,32602L,34079L,34786L,35608L,36375L,37295L,38226L,38520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089157Inst : IEnumerable<long>
{
public static readonly long[] Value=A089157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089157.Bytes);
public long this[int i]=>Value[i];

public static A089157Inst Instance=new A089157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089158
{
public static readonly BigInteger[] Value={ 89L,178481L,1103L,616318177L,164511353L,9719L,4513L,69431L,3203431780337L,761838257287L,48544121L,2298041L,202029703L,BigInteger.Parse("57912614113275649087721"),BigInteger.Parse("13842607235828485645766393"),341117531003194129L,BigInteger.Parse("3976656429941438590393") };
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
public class A089158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089158Inst Instance=new A089158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089159
{
public static readonly BigInteger[] Value={ 2089L,2099863L,13264529L,20394401L,212885833L,9361973132609L,1113491139767L,65993L,165799L,1654058017289L,110211473L,70084436712553223L,BigInteger.Parse("1489459109360039866456940197095433721664951999121"),7648337L,39940132241L };
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
public class A089159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089159Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089159.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089159Inst Instance=new A089159Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089160
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,9L,10L,14L,15L,17L,21L,27L,29L,34L,35L,36L,38L,43L,48L,49L,57L,62L,64L,69L,70L,71L,79L,86L,90L,93L,108L,112L,115L,119L,122L,127L,128L,133L,136L,141L,142L,147L,149L,157L,164L,167L,174L,181L,183L,188L,191L,204L,218L,223L,225L,226L,240L,244L,274L,276L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089160Inst : IEnumerable<long>
{
public static readonly long[] Value=A089160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089160.Bytes);
public long this[int i]=>Value[i];

public static A089160Inst Instance=new A089160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089161
{
public static readonly long[] Value={ 0L,3L,4L,6L,7L,11L,20L,27L,28L,42L,47L,49L,53L,55L,56L,59L,62L,66L,67L,69L,74L,75L,88L,89L,105L,108L,115L,117L,118L,125L,130L,137L,138L,140L,144L,150L,151L,154L,159L,165L,180L,182L,188L,195L,206L,227L,231L,237L,243L,248L,249L,251L,258L,262L,269L,279L,284L,286L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089161Inst : IEnumerable<long>
{
public static readonly long[] Value=A089161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089161.Bytes);
public long this[int i]=>Value[i];

public static A089161Inst Instance=new A089161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089162
{
public static readonly long[] Value={ 3L,7L,31L,127L,23L,89L,8191L,131071L,524287L,47L,178481L,233L,1103L,2089L,2147483647L,223L,616318177L,13367L,164511353L,431L,9719L,2099863L,2351L,4513L,13264529L,6361L,69431L,20394401L,179951L,3203431780337L,2305843009213693951L,193707721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089162Inst : IEnumerable<long>
{
public static readonly long[] Value=A089162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089162.Bytes);
public long this[int i]=>Value[i];

public static A089162Inst Instance=new A089162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089163
{
public static readonly BigInteger[] Value={ 71L,331L,29927L,745181L,2002867877L,50642213021L,32309L,1196347L,303168989L,203778431L,17685389279L,BigInteger.Parse("111998979662707645844109121"),645845309L,146309L,499L,BigInteger.Parse("706132008101135602203621405289"),BigInteger.Parse("59813046375181769306016700165290169537") };
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
public class A089163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089163Inst Instance=new A089163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089164
{
public static readonly long[] Value={ 3L,19L,107L,591L,3259L,18019L,99987L,556831L,3111347L,17436915L,97981179L,551871087L,3114878571L,17613879747L,99768824355L,565962587199L,3214923140707L,18284737574611L,104110467624075L,593397580894351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089164Inst : IEnumerable<long>
{
public static readonly long[] Value=A089164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089164.Bytes);
public long this[int i]=>Value[i];

public static A089164Inst Instance=new A089164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089165
{
public static readonly long[] Value={ 1L,4L,17L,80L,401L,2084L,11073L,59712L,325441L,1788004L,9885457L,54932176L,306528145L,1716461764L,9640310017L,54282691840L,306337928449L,1732172652868L,9811489710737L,55660919625680L,316204733423121L,1798580947651044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089165Inst : IEnumerable<long>
{
public static readonly long[] Value=A089165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089165.Bytes);
public long this[int i]=>Value[i];

public static A089165Inst Instance=new A089165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089166
{
public static readonly long[] Value={ 4L,5L,6L,7L,8L,9L,9L,13L,11L,13L,14L,15L,15L,17L,16L,19L,19L,19L,21L,23L,20L,23L,23L,28L,21L,31L,25L,23L,30L,32L,30L,29L,31L,32L,34L,30L,34L,40L,32L,36L,39L,37L,37L,40L,38L,39L,44L,42L,45L,44L,42L,42L,45L,42L,48L,52L,49L,45L,50L,48L,51L,55L,56L,47L,52L,56L,56L,53L,49L,58L,62L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089166Inst : IEnumerable<long>
{
public static readonly long[] Value=A089166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089166.Bytes);
public long this[int i]=>Value[i];

public static A089166Inst Instance=new A089166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089167
{
public static readonly long[] Value={ 1L,3L,5L,5L,11L,19L,13L,19L,23L,39L,19L,37L,37L,37L,53L,53L,47L,47L,31L,61L,61L,71L,53L,53L,89L,73L,47L,89L,83L,91L,127L,89L,101L,127L,167L,109L,73L,145L,199L,137L,127L,193L,101L,109L,163L,149L,137L,241L,211L,163L,251L,281L,151L,265L,181L,339L,269L,229L,209L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089167Inst : IEnumerable<long>
{
public static readonly long[] Value=A089167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089167.Bytes);
public long this[int i]=>Value[i];

public static A089167Inst Instance=new A089167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089168
{
public static readonly long[] Value={ 3L,5L,15L,17L,7L,21L,27L,33L,13L,41L,19L,9L,57L,59L,5L,69L,11L,71L,75L,77L,89L,31L,99L,101L,9L,105L,111L,7L,117L,119L,43L,131L,141L,143L,147L,153L,23L,155L,161L,167L,173L,189L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089168Inst : IEnumerable<long>
{
public static readonly long[] Value=A089168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089168.Bytes);
public long this[int i]=>Value[i];

public static A089168Inst Instance=new A089168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089169
{
public static readonly long[] Value={ 2L,4L,3L,4L,6L,6L,5L,8L,10L,12L,5L,12L,14L,16L,7L,9L,18L,18L,8L,20L,22L,7L,11L,13L,24L,28L,30L,30L,15L,10L,32L,36L,14L,38L,40L,9L,11L,21L,42L,42L,44L,46L,23L,25L,48L,16L,52L,54L,13L,27L,20L,58L,60L,11L,60L,62L,33L,14L,66L,22L,68L,70L,72L,19L,35L,37L,72L,74L,78L,39L,80L,82L,13L,16L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089169Inst : IEnumerable<long>
{
public static readonly long[] Value=A089169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089169.Bytes);
public long this[int i]=>Value[i];

public static A089169Inst Instance=new A089169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089170
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,17L,1L,1L,1L,1L,1L,1L,1L,527L,1L,1L,1L,1L,31L,1L,1L,731L,1L,41L,1L,1L,1L,37L,1333L,17L,1L,1L,1L,31L,1L,1L,1L,17L,73L,1L,1L,1L,43L,1271L,59L,629L,1L,73L,2759L,43L,1L,1L,1L,17L,1L,67L,7519L,1L,31L,89L,1L,289L,1L,29020032511L,1L,10573L,1L,1L,1L,2227L,486029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089170Inst : IEnumerable<long>
{
public static readonly long[] Value=A089170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089170.Bytes);
public long this[int i]=>Value[i];

public static A089170Inst Instance=new A089170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089171
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,-17L,31L,-691L,5461L,-929569L,3202291L,-221930581L,4722116521L,-56963745931L,14717667114151L,-2093660879252671L,86125672563201181L,BigInteger.Parse("-129848163681107301953"),BigInteger.Parse("868320396104950823611"),BigInteger.Parse("-209390615747646519456961"),BigInteger.Parse("14129659550745551130667441") };
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
public class A089171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089171Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089171.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089171Inst Instance=new A089171Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089172
{
public static readonly long[] Value={ 11L,19L,24L,27L,29L,33L,34L,35L,39L,43L,44L,48L,49L,50L,51L,53L,54L,55L,59L,61L,62L,64L,65L,67L,69L,71L,75L,76L,79L,80L,83L,84L,87L,89L,90L,91L,94L,97L,98L,99L,101L,103L,104L,105L,107L,108L,109L,111L,113L,114L,115L,116L,118L,119L,120L,123L,124L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089172Inst : IEnumerable<long>
{
public static readonly long[] Value=A089172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089172.Bytes);
public long this[int i]=>Value[i];

public static A089172Inst Instance=new A089172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089173
{
public static readonly long[] Value={ 2L,2L,4L,3L,6L,3L,5L,4L,4L,10L,9L,6L,14L,5L,11L,16L,6L,5L,8L,20L,15L,7L,24L,8L,26L,12L,19L,7L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089173Inst : IEnumerable<long>
{
public static readonly long[] Value=A089173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089173.Bytes);
public long this[int i]=>Value[i];

public static A089173Inst Instance=new A089173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089174
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,17L,19L,23L,37L,41L,59L,73L,101L,137L,157L,239L,257L,271L,547L,2153L,2251L,4649L,7309L,9091L,19697L,21683L,94331L,333667L,928163L,3324301L,4403881L,7532639L,8983031L,10901027L,1111211111L,11195538763L,139381546141L,1102732004467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089174Inst : IEnumerable<long>
{
public static readonly long[] Value=A089174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089174.Bytes);
public long this[int i]=>Value[i];

public static A089174Inst Instance=new A089174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089175
{
public static readonly long[] Value={ 0L,1L,3L,3L,5L,6L,8L,8L,9L,10L,12L,13L,15L,16L,16L,17L,20L,20L,23L,23L,24L,25L,27L,28L,29L,30L,30L,31L,33L,33L,37L,37L,38L,39L,40L,40L,43L,44L,44L,45L,48L,48L,51L,51L,52L,52L,56L,57L,58L,58L,59L,59L,62L,63L,64L,64L,65L,65L,68L,69L,71L,72L,74L,74L,75L,75L,79L,80L,81L,81L,84L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089175Inst : IEnumerable<long>
{
public static readonly long[] Value=A089175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089175.Bytes);
public long this[int i]=>Value[i];

public static A089175Inst Instance=new A089175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089176
{
public static readonly long[] Value={ 2L,7L,23L,43L,47L,61L,73L,79L,97L,151L,167L,173L,223L,241L,277L,313L,331L,349L,359L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089176Inst : IEnumerable<long>
{
public static readonly long[] Value=A089176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089176.Bytes);
public long this[int i]=>Value[i];

public static A089176Inst Instance=new A089176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089177
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,2L,1L,4L,4L,1L,1L,5L,6L,2L,1L,6L,9L,4L,1L,7L,12L,6L,1L,8L,16L,10L,1L,1L,9L,20L,14L,2L,1L,10L,25L,20L,4L,1L,11L,30L,26L,6L,1L,12L,36L,35L,10L,1L,13L,42L,44L,14L,1L,14L,49L,56L,20L,1L,15L,56L,68L,26L,1L,16L,64L,84L,36L,1L,1L,17L,72L,100L,46L,2L,1L,18L,81L,120L,60L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089177Inst : IEnumerable<long>
{
public static readonly long[] Value=A089177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089177.Bytes);
public long this[int i]=>Value[i];

public static A089177Inst Instance=new A089177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089178
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,1L,1L,4L,2L,1L,5L,4L,1L,6L,6L,1L,7L,9L,1L,1L,8L,12L,2L,1L,9L,16L,4L,1L,10L,20L,6L,1L,11L,25L,10L,1L,12L,30L,14L,1L,13L,36L,20L,1L,14L,42L,26L,1L,15L,49L,35L,1L,1L,16L,56L,44L,2L,1L,17L,64L,56L,4L,1L,18L,72L,68L,6L,1L,19L,81L,84L,10L,1L,20L,90L,100L,14L,1L,21L,100L,120L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089178Inst : IEnumerable<long>
{
public static readonly long[] Value=A089178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089178.Bytes);
public long this[int i]=>Value[i];

public static A089178Inst Instance=new A089178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089179
{
public static readonly long[] Value={ 1L,2L,6L,20L,85L,402L,2464L,15752L,119655L,976190L,9331894L,91769988L,1077214879L,12570658310L,168390947820L,2337860163248L,35513649943201L,544140329564898L,9660558198790510L,166372364728477220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089179Inst : IEnumerable<long>
{
public static readonly long[] Value=A089179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089179.Bytes);
public long this[int i]=>Value[i];

public static A089179Inst Instance=new A089179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089180
{
public static readonly long[] Value={ 2L,54L,654926L,6904737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089180Inst : IEnumerable<long>
{
public static readonly long[] Value=A089180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089180.Bytes);
public long this[int i]=>Value[i];

public static A089180Inst Instance=new A089180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089181
{
public static readonly long[] Value={ 1L,2L,-3L,-20L,-19L,102L,337L,-40L,-2439L,-4598L,7877L,47940L,40741L,-254098L,-793383L,191920L,5937521L,10531602L,-20499443L,-114720100L,-85944099L,631152502L,1863913697L,-690240120L,-14427876119L,-24024071398L,52946990037L,274062479860L,177496029461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089181Inst : IEnumerable<long>
{
public static readonly long[] Value=A089181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089181.Bytes);
public long this[int i]=>Value[i];

public static A089181Inst Instance=new A089181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089182
{
public static readonly long[] Value={ 2L,22L,232L,2332L,23532L,235532L,2357532L,23577532L,235817532L,2358217532L,23582417532L,235824417532L,2358248417532L,23582488417532L,235824908417532L,2358249108417532L,23582491508417532L,235824915508417532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089182Inst : IEnumerable<long>
{
public static readonly long[] Value=A089182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089182.Bytes);
public long this[int i]=>Value[i];

public static A089182Inst Instance=new A089182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089183
{
public static readonly long[] Value={ 1L,11L,101L,1001L,10201L,102201L,1023201L,10233201L,102313201L,1023113201L,10231013201L,102310013201L,1023102013201L,10231022013201L,102310232013201L,1023102332013201L,10231023132013201L,102310231132013201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089183Inst : IEnumerable<long>
{
public static readonly long[] Value=A089183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089183.Bytes);
public long this[int i]=>Value[i];

public static A089183Inst Instance=new A089183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089184
{
public static readonly long[] Value={ 1L,22L,111L,4444L,33333L,333333L,3333333L,13333133L,133331133L,3323333233L,31133331133L,333343333433L,3333333333333L,33333333333333L,333333333333333L,3313333333313333L,31133333333113333L,333323333333323333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089184Inst : IEnumerable<long>
{
public static readonly long[] Value=A089184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089184.Bytes);
public long this[int i]=>Value[i];

public static A089184Inst Instance=new A089184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089185
{
public static readonly long[] Value={ 1L,11L,12L,21L,43L,190L,216L,251L,258L,370L,384L,408L,440L,462L,669L,762L,804L,809L,871L,884L,919L,1188L,1519L,1520L,1521L,1790L,1800L,1875L,2305L,2312L,2538L,2997L,3151L,3210L,3362L,3474L,4026L,4561L,5110L,5490L,5521L,5569L,5726L,5762L,5785L,7216L,7521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089185Inst : IEnumerable<long>
{
public static readonly long[] Value=A089185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089185.Bytes);
public long this[int i]=>Value[i];

public static A089185Inst Instance=new A089185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089186
{
public static readonly long[] Value={ 9L,8L,7L,6L,5L,4L,3L,2L,1L,90L,89L,88L,87L,86L,85L,84L,83L,82L,81L,80L,79L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089186Inst : IEnumerable<long>
{
public static readonly long[] Value=A089186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089186.Bytes);
public long this[int i]=>Value[i];

public static A089186Inst Instance=new A089186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089187
{
public static readonly long[] Value={ 1L,3L,7L,14L,24L,40L,59L,87L,121L,164L,210L,274L,345L,430L,523L,632L,749L,890L,1039L,1222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089187Inst : IEnumerable<long>
{
public static readonly long[] Value=A089187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089187.Bytes);
public long this[int i]=>Value[i];

public static A089187Inst Instance=new A089187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089188
{
public static readonly long[] Value={ 3L,11L,59L,71L,107L,179L,191L,227L,239L,311L,347L,419L,431L,599L,659L,827L,1019L,1031L,1091L,1319L,1427L,1487L,1607L,1619L,1787L,1871L,1931L,2027L,2087L,2111L,2267L,2339L,2591L,2687L,2711L,2999L,3119L,3167L,3299L,3359L,3371L,3467L,3527L,3539L,3671L,3767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089188Inst : IEnumerable<long>
{
public static readonly long[] Value=A089188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089188.Bytes);
public long this[int i]=>Value[i];

public static A089188Inst Instance=new A089188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089189
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,23L,29L,31L,37L,43L,47L,53L,59L,61L,67L,71L,79L,83L,101L,103L,107L,127L,131L,139L,149L,151L,157L,167L,173L,179L,181L,191L,197L,199L,211L,223L,227L,229L,239L,263L,269L,277L,283L,293L,307L,311L,317L,331L,347L,349L,359L,367L,373L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089189Inst : IEnumerable<long>
{
public static readonly long[] Value=A089189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089189.Bytes);
public long this[int i]=>Value[i];

public static A089189Inst Instance=new A089189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089190
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,8L,10L,11L,13L,16L,18L,21L,23L,24L,26L,29L,33L,34L,37L,39L,40L,43L,46L,49L,53L,55L,56L,58L,59L,61L,69L,71L,74L,75L,80L,81L,84L,87L,89L,92L,96L,97L,102L,103L,105L,106L,113L,119L,121L,122L,124L,127L,128L,133L,136L,139L,142L,143L,147L,149L,150L,155L,162L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089190Inst : IEnumerable<long>
{
public static readonly long[] Value=A089190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089190.Bytes);
public long this[int i]=>Value[i];

public static A089190Inst Instance=new A089190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089191
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,19L,29L,37L,41L,43L,59L,61L,67L,73L,83L,89L,97L,101L,109L,113L,131L,137L,139L,149L,157L,163L,173L,179L,181L,193L,197L,211L,227L,229L,233L,241L,251L,257L,277L,281L,283L,293L,307L,313L,317L,331L,337L,347L,349L,353L,373L,379L,389L,397L,401L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089191Inst : IEnumerable<long>
{
public static readonly long[] Value=A089191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089191.Bytes);
public long this[int i]=>Value[i];

public static A089191Inst Instance=new A089191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089192
{
public static readonly long[] Value={ 5L,6L,7L,9L,10L,12L,13L,15L,18L,19L,22L,24L,25L,27L,30L,33L,34L,37L,39L,40L,43L,45L,48L,52L,54L,55L,57L,58L,60L,67L,69L,72L,73L,78L,79L,82L,85L,87L,90L,93L,94L,99L,100L,102L,103L,109L,115L,117L,118L,120L,123L,124L,129L,132L,135L,138L,139L,142L,144L,145L,150L,157L,159L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089192Inst : IEnumerable<long>
{
public static readonly long[] Value=A089192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089192.Bytes);
public long this[int i]=>Value[i];

public static A089192Inst Instance=new A089192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089193
{
public static readonly long[] Value={ 5L,7L,9L,13L,15L,19L,25L,27L,33L,37L,39L,43L,45L,55L,67L,69L,73L,79L,85L,87L,93L,99L,103L,109L,115L,117L,123L,129L,135L,139L,145L,157L,159L,169L,177L,183L,187L,193L,195L,213L,219L,223L,225L,235L,237L,243L,249L,253L,255L,265L,277L,285L,289L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089193Inst : IEnumerable<long>
{
public static readonly long[] Value=A089193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089193.Bytes);
public long this[int i]=>Value[i];

public static A089193Inst Instance=new A089193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089194
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,19L,29L,37L,43L,59L,61L,67L,83L,101L,131L,139L,149L,157L,173L,179L,181L,197L,211L,227L,229L,277L,283L,293L,307L,317L,331L,347L,349L,373L,389L,397L,419L,421L,443L,461L,467L,491L,509L,523L,547L,557L,563L,571L,587L,613L,619L,643L,653L,659L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089194Inst : IEnumerable<long>
{
public static readonly long[] Value=A089194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089194.Bytes);
public long this[int i]=>Value[i];

public static A089194Inst Instance=new A089194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089195
{
public static readonly long[] Value={ 5L,37L,101L,197L,677L,4357L,5477L,8837L,12101L,16901L,17957L,21317L,28901L,42437L,44101L,52901L,98597L,106277L,148997L,164837L,184901L,217157L,220901L,224677L,324901L,401957L,417317L,427717L,454277L,476101L,509797L,682277L,792101L,820837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089195Inst : IEnumerable<long>
{
public static readonly long[] Value=A089195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089195.Bytes);
public long this[int i]=>Value[i];

public static A089195Inst Instance=new A089195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089196
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,3L,2L,4L,0L,5L,0L,6L,4L,7L,0L,8L,0L,9L,6L,10L,0L,11L,4L,12L,8L,13L,0L,14L,0L,15L,10L,16L,6L,17L,0L,18L,12L,19L,0L,20L,0L,21L,14L,22L,0L,23L,6L,24L,16L,25L,0L,26L,10L,27L,18L,28L,0L,29L,0L,30L,20L,31L,12L,32L,0L,33L,22L,34L,0L,35L,0L,36L,24L,37L,10L,38L,0L,39L,26L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089196Inst : IEnumerable<long>
{
public static readonly long[] Value=A089196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089196.Bytes);
public long this[int i]=>Value[i];

public static A089196Inst Instance=new A089196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089197
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,7L,8L,10L,11L,13L,15L,17L,20L,22L,25L,28L,31L,35L,38L,42L,46L,50L,55L,60L,65L,71L,76L,83L,89L,96L,103L,111L,119L,128L,136L,146L,156L,167L,178L,189L,201L,214L,227L,241L,255L,270L,286L,302L,319L,337L,355L,375L,394L,415L,436L,458L,481L,505L,529L,555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089197Inst : IEnumerable<long>
{
public static readonly long[] Value=A089197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089197.Bytes);
public long this[int i]=>Value[i];

public static A089197Inst Instance=new A089197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089198
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,2L,1L,1L,1L,0L,0L,0L,0L,1L,2L,1L,1L,1L,0L,0L,0L,0L,0L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,2L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,3L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,3L,3L,2L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089198Inst : IEnumerable<long>
{
public static readonly long[] Value=A089198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089198.Bytes);
public long this[int i]=>Value[i];

public static A089198Inst Instance=new A089198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089199
{
public static readonly long[] Value={ 7L,23L,31L,47L,53L,71L,79L,103L,107L,127L,151L,167L,191L,199L,223L,239L,263L,269L,271L,311L,359L,367L,383L,431L,439L,463L,479L,487L,499L,503L,593L,599L,607L,631L,647L,701L,719L,727L,743L,751L,809L,823L,839L,863L,887L,911L,919L,967L,971L,983L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089199Inst : IEnumerable<long>
{
public static readonly long[] Value=A089199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089199.Bytes);
public long this[int i]=>Value[i];

public static A089199Inst Instance=new A089199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089200
{
public static readonly long[] Value={ 17L,41L,73L,89L,97L,109L,113L,137L,163L,193L,233L,241L,251L,257L,271L,281L,313L,337L,353L,379L,401L,409L,433L,449L,457L,487L,521L,541L,569L,577L,593L,601L,617L,641L,673L,751L,757L,761L,769L,809L,811L,857L,881L,919L,929L,937L,953L,977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089200Inst : IEnumerable<long>
{
public static readonly long[] Value=A089200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089200.Bytes);
public long this[int i]=>Value[i];

public static A089200Inst Instance=new A089200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089201
{
public static readonly long[] Value={ 683L,1747L,2659L,3253L,4253L,4397L,7253L,7549L,8747L,9829L,10253L,12253L,13037L,14747L,16253L,16747L,17747L,18253L,18637L,19891L,20747L,21269L,23747L,25253L,25747L,27253L,28123L,29501L,30253L,31253L,34253L,34603L,34747L,35747L,37253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089201Inst : IEnumerable<long>
{
public static readonly long[] Value=A089201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089201.Bytes);
public long this[int i]=>Value[i];

public static A089201Inst Instance=new A089201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089202
{
public static readonly long[] Value={ 4457L,10987L,15377L,20873L,32587L,39877L,51109L,53377L,54623L,60127L,66877L,74873L,101873L,107377L,112997L,115589L,120877L,121123L,125197L,126443L,128873L,135623L,143719L,148957L,155377L,161053L,161377L,162623L,168127L,169373L,174877L,176123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089202Inst : IEnumerable<long>
{
public static readonly long[] Value=A089202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089202.Bytes);
public long this[int i]=>Value[i];

public static A089202Inst Instance=new A089202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089203
{
public static readonly long[] Value={ 169373L,371873L,574373L,741877L,843127L,979373L,1146877L,1615871L,1688123L,1754377L,1789373L,1855627L,2004833L,2093123L,2260627L,2498123L,2665627L,2700623L,2782757L,2903123L,3206873L,3374377L,3510623L,3560681L,3611873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089203Inst : IEnumerable<long>
{
public static readonly long[] Value=A089203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089203.Bytes);
public long this[int i]=>Value[i];

public static A089203Inst Instance=new A089203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089236
{
public static readonly long[] Value={ 251L,111497L,74453L,1397609L,642427L,5321191L,23921299L,55410683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089236Inst : IEnumerable<long>
{
public static readonly long[] Value=A089236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089236.Bytes);
public long this[int i]=>Value[i];

public static A089236Inst Instance=new A089236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089237
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,9L,11L,13L,16L,17L,19L,23L,25L,29L,31L,36L,37L,41L,43L,47L,49L,53L,59L,61L,64L,67L,71L,73L,79L,81L,83L,89L,97L,100L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,144L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,196L,197L,199L,211L,223L,225L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089237Inst : IEnumerable<long>
{
public static readonly long[] Value=A089237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089237.Bytes);
public long this[int i]=>Value[i];

public static A089237Inst Instance=new A089237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089238
{
public static readonly long[] Value={ 2L,4L,6L,10L,14L,16L,20L,24L,26L,34L,40L,44L,54L,56L,60L,64L,70L,76L,86L,90L,104L,110L,116L,120L,124L,126L,130L,136L,140L,146L,150L,154L,164L,166L,174L,186L,194L,200L,204L,230L,240L,244L,260L,264L,286L,300L,306L,336L,346L,354L,374L,386L,394L,400L,414L,416L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089238Inst : IEnumerable<long>
{
public static readonly long[] Value=A089238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089238.Bytes);
public long this[int i]=>Value[i];

public static A089238Inst Instance=new A089238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089239
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,6L,4L,1L,1L,5L,10L,9L,3L,0L,1L,6L,15L,17L,7L,0L,0L,1L,7L,21L,28L,14L,1L,0L,0L,1L,8L,28L,43L,25L,3L,0L,0L,0L,1L,9L,36L,62L,41L,7L,0L,0L,0L,0L,1L,10L,45L,86L,63L,13L,0L,0L,0L,0L,0L,1L,11L,55L,115L,93L,23L,0L,0L,0L,0L,0L,0L,1L,12L,66L,150L,132L,37L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089239Inst : IEnumerable<long>
{
public static readonly long[] Value=A089239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089239.Bytes);
public long this[int i]=>Value[i];

public static A089239Inst Instance=new A089239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089240
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,3L,7L,14L,25L,41L,63L,93L,132L,182L,244L,321L,414L,526L,658L,814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089240Inst : IEnumerable<long>
{
public static readonly long[] Value=A089240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089240.Bytes);
public long this[int i]=>Value[i];

public static A089240Inst Instance=new A089240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089241
{
public static readonly long[] Value={ 6L,8L,12L,16L,24L,28L,36L,40L,48L,60L,64L,76L,84L,88L,96L,108L,120L,124L,136L,144L,148L,160L,168L,180L,196L,204L,208L,216L,220L,228L,256L,264L,276L,280L,300L,304L,316L,328L,336L,348L,360L,364L,384L,388L,396L,400L,424L,448L,456L,460L,468L,480L,484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089241Inst : IEnumerable<long>
{
public static readonly long[] Value=A089241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089241.Bytes);
public long this[int i]=>Value[i];

public static A089241Inst Instance=new A089241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089242
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089242Inst : IEnumerable<long>
{
public static readonly long[] Value=A089242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089242.Bytes);
public long this[int i]=>Value[i];

public static A089242Inst Instance=new A089242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089243
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,22L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089243Inst : IEnumerable<long>
{
public static readonly long[] Value=A089243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089243.Bytes);
public long this[int i]=>Value[i];

public static A089243Inst Instance=new A089243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089244
{
public static readonly long[] Value={ 7L,5L,44L,37L,301L,277L,2425L,2294L,2085L,18569L,17960L,164398L,156173L,152498L,145864L,1373605L,1301889L,1280368L,12216944L,11867816L,11704114L,11250879L,109764259L,105999788L,101534616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089244Inst : IEnumerable<long>
{
public static readonly long[] Value=A089244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089244.Bytes);
public long this[int i]=>Value[i];

public static A089244Inst Instance=new A089244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089245
{
public static readonly long[] Value={ 10L,7L,5L,50L,44L,40L,37L,35L,333L,316L,301L,288L,277L,267L,258L,2500L,2425L,2357L,2294L,2236L,2182L,2132L,2085L,2041L,20000L,19611L,19245L,18898L,18569L,18257L,17960L,17677L,17407L,17149L,16903L,166666L,164398L,162221L,160128L,158113L,156173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089245Inst : IEnumerable<long>
{
public static readonly long[] Value=A089245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089245.Bytes);
public long this[int i]=>Value[i];

public static A089245Inst Instance=new A089245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089246
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,5L,5L,3L,0L,1L,14L,15L,9L,4L,0L,1L,43L,50L,31L,14L,5L,0L,1L,144L,180L,118L,54L,20L,6L,0L,1L,523L,695L,481L,229L,85L,27L,7L,0L,1L,2048L,2869L,2081L,1035L,395L,125L,35L,8L,0L,1L,8597L,12616L,9535L,4929L,1951L,629L,175L,44L,9L,0L,1L,38486L,58862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089246Inst : IEnumerable<long>
{
public static readonly long[] Value=A089246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089246.Bytes);
public long this[int i]=>Value[i];

public static A089246Inst Instance=new A089246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089247
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,12L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,20L,51L,52L,53L,24L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089247Inst : IEnumerable<long>
{
public static readonly long[] Value=A089247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089247.Bytes);
public long this[int i]=>Value[i];

public static A089247Inst Instance=new A089247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089248
{
public static readonly long[] Value={ 1L,2L,2L,8L,12L,40L,144L,128L,644L,3504L,7000L,48224L,130992L,861792L,3257600L,32768L,425988L,5833312L,27621672L,415526656L,1987852432L,17674429440L,157807273408L,265515959680L,2848581615344L,30980959604096L,114059874705248L,1365388896050048L,6215927122198944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089248Inst : IEnumerable<long>
{
public static readonly long[] Value=A089248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089248.Bytes);
public long this[int i]=>Value[i];

public static A089248Inst Instance=new A089248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089249
{
public static readonly long[] Value={ 1L,3L,4L,6L,16L,11L,10L,40L,55L,26L,15L,80L,165L,156L,57L,21L,140L,385L,546L,399L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089249Inst : IEnumerable<long>
{
public static readonly long[] Value=A089249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089249.Bytes);
public long this[int i]=>Value[i];

public static A089249Inst Instance=new A089249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089250
{
public static readonly long[] Value={ 5L,3L,6L,3L,7L,1L,4L,8L,7L,5L,7L,0L,1L,9L,1L,5L,4L,5L,0L,6L,8L,4L,8L,6L,5L,5L,0L,5L,4L,9L,1L,7L,2L,4L,0L,0L,6L,3L,1L,9L,3L,8L,1L,5L,1L,1L,5L,9L,7L,3L,2L,7L,0L,4L,2L,1L,9L,6L,1L,6L,6L,7L,1L,4L,5L,2L,9L,0L,3L,8L,6L,2L,8L,4L,0L,8L,4L,2L,0L,1L,1L,0L,8L,4L,0L,2L,5L,6L,0L,4L,7L,5L,6L,4L,3L,3L,9L,2L,8L,9L,1L,0L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089250Inst : IEnumerable<long>
{
public static readonly long[] Value=A089250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089250.Bytes);
public long this[int i]=>Value[i];

public static A089250Inst Instance=new A089250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089251
{
public static readonly long[] Value={ 1L,3L,5L,11L,13L,32L,31L,71L,83L,147L,140L,364L,273L,550L,681L,1108L,916L,2157L,1598L,3604L,3549L,5102L,4509L,11548L,8192L,13514L,15199L,24911L,18461L,45062L,28630L,59662L,56544L,78484L,79350L,167219L,99134L,175771L,189108L,331455L,215309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089251Inst : IEnumerable<long>
{
public static readonly long[] Value=A089251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089251.Bytes);
public long this[int i]=>Value[i];

public static A089251Inst Instance=new A089251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089252
{
public static readonly BigInteger[] Value={ 1L,6L,72L,1392L,38016L,1347840L,58752000L,3036579840L,181428387840L,12299042488320L,932514044313600L,78184097316864000L,7181946863065497600L,BigInteger.Parse("717283471185779097600"),BigInteger.Parse("77383645289778040012800") };
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
public class A089252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089252Inst Instance=new A089252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089253
{
public static readonly long[] Value={ 4L,5L,6L,8L,9L,11L,12L,14L,17L,18L,21L,23L,24L,26L,29L,32L,33L,36L,38L,39L,42L,44L,47L,51L,53L,54L,56L,57L,59L,66L,68L,71L,72L,77L,78L,81L,84L,86L,89L,92L,93L,98L,99L,101L,102L,108L,114L,116L,117L,119L,122L,123L,128L,131L,134L,137L,138L,141L,143L,144L,149L,156L,158L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089253Inst : IEnumerable<long>
{
public static readonly long[] Value=A089253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089253.Bytes);
public long this[int i]=>Value[i];

public static A089253Inst Instance=new A089253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089254
{
public static readonly long[] Value={ 1L,-1L,0L,-2L,1L,-2L,2L,-2L,5L,-3L,8L,-3L,13L,-6L,16L,-15L,21L,-28L,21L,-52L,22L,-90L,23L,-136L,40L,-190L,79L,-237L,185L,-254L,385L,-219L,740L,-116L,1279L,49L,2039L,198L,2923L,130L,3785L,-541L,4215L,-2464L,3638L,-6581L,1204L,-14062L,-3889L,-26110L,-12267L,-43399L,-23264L,-65206L,-34085L,-87955L,-37666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089254Inst : IEnumerable<long>
{
public static readonly long[] Value=A089254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089254.Bytes);
public long this[int i]=>Value[i];

public static A089254Inst Instance=new A089254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089255
{
public static readonly long[] Value={ 5L,9L,11L,17L,21L,23L,29L,33L,39L,47L,51L,53L,57L,59L,71L,77L,81L,89L,93L,99L,101L,117L,119L,123L,131L,137L,141L,143L,149L,159L,161L,171L,177L,179L,189L,197L,201L,203L,207L,213L,219L,227L,231L,233L,257L,263L,273L,281L,287L,291L,299L,303L,309L,311L,323L,329L,333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089255Inst : IEnumerable<long>
{
public static readonly long[] Value=A089255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089255.Bytes);
public long this[int i]=>Value[i];

public static A089255Inst Instance=new A089255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089256
{
public static readonly long[] Value={ 155L,274L,2191L,104579630L,142857142L,189126664L,195488721L,241758243L,280035755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089256Inst : IEnumerable<long>
{
public static readonly long[] Value=A089256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089256.Bytes);
public long this[int i]=>Value[i];

public static A089256Inst Instance=new A089256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089257
{
public static readonly long[] Value={ 4L,6L,8L,12L,14L,18L,24L,26L,32L,36L,38L,42L,44L,54L,56L,66L,68L,72L,78L,84L,86L,92L,98L,102L,108L,114L,116L,122L,128L,134L,138L,144L,156L,158L,168L,176L,182L,186L,192L,194L,212L,218L,222L,224L,234L,236L,242L,246L,248L,252L,254L,264L,276L,284L,288L,296L,302L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089257Inst : IEnumerable<long>
{
public static readonly long[] Value=A089257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089257.Bytes);
public long this[int i]=>Value[i];

public static A089257Inst Instance=new A089257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089258
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,1L,3L,5L,6L,9L,1L,4L,10L,16L,24L,44L,1L,5L,17L,38L,65L,120L,265L,1L,6L,26L,78L,168L,326L,720L,1854L,1L,7L,37L,142L,393L,872L,1957L,5040L,14833L,1L,8L,50L,236L,824L,2208L,5296L,13700L,40320L,133496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089258Inst : IEnumerable<long>
{
public static readonly long[] Value=A089258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089258.Bytes);
public long this[int i]=>Value[i];

public static A089258Inst Instance=new A089258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089259
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,22L,36L,61L,101L,166L,267L,433L,686L,1088L,1709L,2671L,4140L,6403L,9824L,15028L,22864L,34657L,52288L,78646L,117784L,175865L,261657L,388145L,573936L,846377L,1244475L,1825170L,2669776L,3895833L,5671127L,8236945L,11936594L,17261557L,24909756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089259Inst : IEnumerable<long>
{
public static readonly long[] Value=A089259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089259.Bytes);
public long this[int i]=>Value[i];

public static A089259Inst Instance=new A089259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089260
{
public static readonly long[] Value={ 1L,8L,3L,8L,0L,2L,3L,5L,9L,6L,9L,2L,9L,5L,5L,6L,0L,4L,9L,1L,3L,9L,6L,9L,0L,1L,0L,1L,5L,1L,2L,6L,6L,7L,3L,4L,2L,5L,7L,1L,2L,2L,7L,1L,9L,8L,6L,5L,3L,4L,2L,8L,1L,7L,0L,9L,4L,9L,6L,0L,8L,2L,7L,7L,0L,1L,4L,4L,7L,8L,9L,4L,0L,4L,7L,7L,4L,0L,6L,1L,4L,5L,6L,6L,5L,4L,9L,6L,3L,4L,8L,5L,8L,7L,8L,3L,7L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089260Inst : IEnumerable<long>
{
public static readonly long[] Value=A089260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089260.Bytes);
public long this[int i]=>Value[i];

public static A089260Inst Instance=new A089260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089261
{
public static readonly long[] Value={ 0L,5L,2L,3L,1L,2L,2L,5L,6L,13L,2L,7L,2L,2L,1L,1L,5L,1L,4L,1L,4L,16L,1L,1L,2L,1L,1L,4L,2L,1L,1L,3L,1L,2L,2L,1L,6L,1L,4L,4L,1L,7L,2L,1L,2L,3L,1L,1L,7L,2L,1L,16L,1L,2L,1L,1L,67L,462L,1L,2L,4L,1L,3L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,14L,1L,1L,2L,1L,1L,1L,9L,2L,2L,1L,1107L,2L,3L,10L,2L,4L,1L,1L,1L,1L,1L,44L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089261Inst : IEnumerable<long>
{
public static readonly long[] Value=A089261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089261.Bytes);
public long this[int i]=>Value[i];

public static A089261Inst Instance=new A089261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089262
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,0L,0L,4L,4L,4L,4L,0L,0L,0L,0L,8L,8L,8L,8L,8L,8L,8L,8L,0L,0L,0L,0L,0L,0L,0L,0L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089262Inst : IEnumerable<long>
{
public static readonly long[] Value=A089262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089262.Bytes);
public long this[int i]=>Value[i];

public static A089262Inst Instance=new A089262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089263
{
public static readonly long[] Value={ 0L,0L,1L,-1L,2L,-1L,0L,-1L,3L,-1L,0L,-1L,1L,-1L,0L,-1L,4L,-1L,0L,-1L,1L,-1L,0L,-1L,2L,-1L,0L,-1L,1L,-1L,0L,-1L,5L,-1L,0L,-1L,1L,-1L,0L,-1L,2L,-1L,0L,-1L,1L,-1L,0L,-1L,3L,-1L,0L,-1L,1L,-1L,0L,-1L,2L,-1L,0L,-1L,1L,-1L,0L,-1L,6L,-1L,0L,-1L,1L,-1L,0L,-1L,2L,-1L,0L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089263Inst : IEnumerable<long>
{
public static readonly long[] Value=A089263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089263.Bytes);
public long this[int i]=>Value[i];

public static A089263Inst Instance=new A089263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089264
{
public static readonly long[] Value={ 3L,6L,17L,42L,102L,242L,564L,1296L,2944L,6624L,14784L,32768L,72192L,158208L,345088L,749568L,1622016L,3497984L,7520256L,16121856L,34471936L,73531392L,156499968L,332398592L,704643072L,1491075072L,3149922304L,6643777536L,13992198144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089264Inst : IEnumerable<long>
{
public static readonly long[] Value=A089264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089264.Bytes);
public long this[int i]=>Value[i];

public static A089264Inst Instance=new A089264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089265
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,3L,6L,3L,8L,5L,10L,4L,12L,7L,14L,4L,16L,9L,18L,6L,20L,11L,22L,5L,24L,13L,26L,8L,28L,15L,30L,5L,32L,17L,34L,10L,36L,19L,38L,7L,40L,21L,42L,12L,44L,23L,46L,6L,48L,25L,50L,14L,52L,27L,54L,9L,56L,29L,58L,16L,60L,31L,62L,6L,64L,33L,66L,18L,68L,35L,70L,11L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089265Inst : IEnumerable<long>
{
public static readonly long[] Value=A089265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089265.Bytes);
public long this[int i]=>Value[i];

public static A089265Inst Instance=new A089265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089266
{
public static readonly long[] Value={ 2L,3L,4L,4L,6L,7L,6L,9L,10L,8L,12L,11L,10L,15L,16L,12L,14L,19L,14L,21L,22L,14L,24L,22L,18L,27L,22L,20L,30L,31L,20L,26L,34L,24L,36L,37L,22L,32L,40L,28L,42L,34L,30L,45L,38L,32L,38L,49L,32L,51L,52L,28L,54L,55L,38L,57L,46L,38L,50L,56L,42L,51L,64L,44L,66L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089266Inst : IEnumerable<long>
{
public static readonly long[] Value=A089266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089266.Bytes);
public long this[int i]=>Value[i];

public static A089266Inst Instance=new A089266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089267
{
public static readonly BigInteger[] Value={ 0L,1L,1L,23L,1L,2L,1L,18815L,3L,1L,23L,3L,1L,23L,1L,2L,1L,106597754640383L,3L,1L,23L,1L,3L,23L,1L,3L,18815L,1L,2L,1L,23L,3L,1L,23L,1L,2L,1L,18815L,3L,1L,23L,3L,1L,23L,1L,2L,1L,BigInteger.Parse("1715738475058821295603924428015888899408203312889855"),3L,1L };
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
public class A089267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A089267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A089267Inst Instance=new A089267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089332
{
public static readonly long[] Value={ 30L,15L,31L,17L,23L,10L,26L,13L,20L,17L,5L,22L,30L,7L,15L,12L,20L,18L,16L,4L,32L,20L,8L,16L,24L,12L,10L,28L,16L,25L,13L,21L,10L,8L,36L,25L,33L,21L,0L,28L,17L,35L,4L,32L,51L,0L,8L,47L,55L,14L,23L,1L,10L,59L,17L,46L,45L,13L,52L,31L,20L,38L,27L,26L,45L,3L,82L,21L,20L,39L,37L,46L,85L,4L,43L,92L,-9L,60L,48L,57L,26L,15L,64L,73L,32L,31L,50L,49L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089332Inst : IEnumerable<long>
{
public static readonly long[] Value=A089332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089332.Bytes);
public long this[int i]=>Value[i];

public static A089332Inst Instance=new A089332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089333
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,4L,6L,8L,11L,14L,19L,24L,31L,39L,51L,63L,80L,99L,124L,153L,190L,233L,288L,353L,432L,527L,643L,780L,947L,1145L,1383L,1665L,2002L,2399L,2874L,3431L,4090L,4865L,5779L,6847L,8103L,9568L,11283L,13280L,15610L,18313L,21462L,25108L,29337L,34227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089333Inst : IEnumerable<long>
{
public static readonly long[] Value=A089333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089333.Bytes);
public long this[int i]=>Value[i];

public static A089333Inst Instance=new A089333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A089334
{
public static readonly long[] Value={ 3L,2L,5L,7L,29L,13L,41L,73L,11L,19L,23L,43L,311L,367L,269L,1423L,47L,37L,239L,67L,89L,241L,719L,1381L,149L,787L,653L,313L,3539L,277L,443L,3733L,83L,211L,1103L,421L,2087L,61L,317L,379L,4421L,463L,3659L,2719L,863L,967L,509L,1483L,1013L,1123L,1427L,883L,113L,541L,887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A089334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A089334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A089334Inst : IEnumerable<long>
{
public static readonly long[] Value=A089334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A089334.Bytes);
public long this[int i]=>Value[i];

public static A089334Inst Instance=new A089334Inst();

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