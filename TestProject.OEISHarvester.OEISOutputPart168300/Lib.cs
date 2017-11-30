using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198757
{
public static readonly long[] Value={ 2L,1L,2L,8L,1L,2L,6L,4L,6L,5L,6L,8L,4L,9L,2L,2L,4L,8L,7L,6L,5L,2L,4L,6L,8L,7L,9L,4L,9L,8L,3L,7L,9L,9L,1L,6L,8L,7L,8L,0L,9L,2L,8L,5L,3L,5L,0L,6L,7L,8L,4L,2L,3L,6L,7L,6L,4L,1L,1L,3L,0L,9L,6L,6L,3L,2L,8L,4L,3L,7L,0L,2L,2L,9L,8L,8L,7L,0L,2L,6L,3L,1L,0L,4L,7L,9L,5L,4L,3L,3L,1L,1L,1L,5L,2L,5L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198757Inst : IEnumerable<long>
{
public static readonly long[] Value=A198757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198757.Bytes);
public long this[int i]=>Value[i];

public static A198757Inst Instance=new A198757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198758
{
public static readonly long[] Value={ 1L,9L,1L,8L,9L,2L,7L,8L,1L,6L,3L,3L,5L,2L,4L,4L,2L,9L,7L,2L,0L,4L,4L,7L,6L,8L,9L,0L,0L,4L,0L,2L,8L,3L,7L,0L,1L,3L,5L,4L,5L,6L,7L,7L,7L,3L,7L,9L,5L,4L,2L,6L,8L,9L,5L,0L,9L,7L,4L,0L,7L,7L,0L,7L,4L,9L,6L,0L,4L,7L,6L,7L,4L,1L,4L,5L,7L,8L,9L,0L,6L,7L,6L,8L,4L,6L,0L,3L,0L,3L,8L,8L,1L,4L,2L,9L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198758Inst : IEnumerable<long>
{
public static readonly long[] Value=A198758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198758.Bytes);
public long this[int i]=>Value[i];

public static A198758Inst Instance=new A198758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198759
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,15L,20L,25L,30L,36L,42L,48L,54L,60L,66L,73L,80L,87L,94L,101L,108L,115L,122L,129L,136L,143L,150L,158L,166L,174L,182L,190L,198L,206L,214L,222L,230L,238L,246L,254L,262L,270L,278L,286L,294L,302L,310L,318L,326L,334L,342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198759Inst : IEnumerable<long>
{
public static readonly long[] Value=A198759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198759.Bytes);
public long this[int i]=>Value[i];

public static A198759Inst Instance=new A198759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198760
{
public static readonly long[] Value={ 2L,8L,32L,136L,596L,2712L,12642L,60234L,291840L,1434184L,7130640L,35807114L,181339236L,925139186L,4750176056L,24528421712L,127294780994L,663591911824L,3473315219722L,18246162722278L,96169600405626L,508413199626078L,2695245063006696L,14324688031734740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198760Inst : IEnumerable<long>
{
public static readonly long[] Value=A198760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198760.Bytes);
public long this[int i]=>Value[i];

public static A198760Inst Instance=new A198760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198761
{
public static readonly long[] Value={ 2L,20L,648L,45472L,5644880L,1099056000L,310007943616L,119777421416192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198761Inst : IEnumerable<long>
{
public static readonly long[] Value=A198761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198761.Bytes);
public long this[int i]=>Value[i];

public static A198761Inst Instance=new A198761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198762
{
public static readonly long[] Value={ 2L,14L,74L,374L,1874L,9374L,46874L,234374L,1171874L,5859374L,29296874L,146484374L,732421874L,3662109374L,18310546874L,91552734374L,457763671874L,2288818359374L,11444091796874L,57220458984374L,286102294921874L,1430511474609374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198762Inst : IEnumerable<long>
{
public static readonly long[] Value=A198762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198762.Bytes);
public long this[int i]=>Value[i];

public static A198762Inst Instance=new A198762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198763
{
public static readonly long[] Value={ 3L,19L,99L,499L,2499L,12499L,62499L,312499L,1562499L,7812499L,39062499L,195312499L,976562499L,4882812499L,24414062499L,122070312499L,610351562499L,3051757812499L,15258789062499L,76293945312499L,381469726562499L,1907348632812499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198763Inst : IEnumerable<long>
{
public static readonly long[] Value=A198763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198763.Bytes);
public long this[int i]=>Value[i];

public static A198763Inst Instance=new A198763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198764
{
public static readonly long[] Value={ 5L,29L,149L,749L,3749L,18749L,93749L,468749L,2343749L,11718749L,58593749L,292968749L,1464843749L,7324218749L,36621093749L,183105468749L,915527343749L,4577636718749L,22888183593749L,114440917968749L,572204589843749L,2861022949218749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198764Inst : IEnumerable<long>
{
public static readonly long[] Value=A198764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198764.Bytes);
public long this[int i]=>Value[i];

public static A198764Inst Instance=new A198764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198765
{
public static readonly long[] Value={ 6L,34L,174L,874L,4374L,21874L,109374L,546874L,2734374L,13671874L,68359374L,341796874L,1708984374L,8544921874L,42724609374L,213623046874L,1068115234374L,5340576171874L,26702880859374L,133514404296874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198765Inst : IEnumerable<long>
{
public static readonly long[] Value=A198765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198765.Bytes);
public long this[int i]=>Value[i];

public static A198765Inst Instance=new A198765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198766
{
public static readonly long[] Value={ 3L,17L,87L,437L,2187L,10937L,54687L,273437L,1367187L,6835937L,34179687L,170898437L,854492187L,4272460937L,21362304687L,106811523437L,534057617187L,2670288085937L,13351440429687L,66757202148437L,333786010742187L,1668930053710937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198766Inst : IEnumerable<long>
{
public static readonly long[] Value=A198766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198766.Bytes);
public long this[int i]=>Value[i];

public static A198766Inst Instance=new A198766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198767
{
public static readonly long[] Value={ 7L,39L,199L,999L,4999L,24999L,124999L,624999L,3124999L,15624999L,78124999L,390624999L,1953124999L,9765624999L,48828124999L,244140624999L,1220703124999L,6103515624999L,30517578124999L,152587890624999L,762939453124999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198767Inst : IEnumerable<long>
{
public static readonly long[] Value=A198767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198767.Bytes);
public long this[int i]=>Value[i];

public static A198767Inst Instance=new A198767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198768
{
public static readonly long[] Value={ 8L,44L,224L,1124L,5624L,28124L,140624L,703124L,3515624L,17578124L,87890624L,439453124L,2197265624L,10986328124L,54931640624L,274658203124L,1373291015624L,6866455078124L,34332275390624L,171661376953124L,858306884765624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198768Inst : IEnumerable<long>
{
public static readonly long[] Value=A198768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198768.Bytes);
public long this[int i]=>Value[i];

public static A198768Inst Instance=new A198768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198769
{
public static readonly long[] Value={ 2L,11L,56L,281L,1406L,7031L,35156L,175781L,878906L,4394531L,21972656L,109863281L,549316406L,2746582031L,13732910156L,68664550781L,343322753906L,1716613769531L,8583068847656L,42915344238281L,214576721191406L,1072883605957031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198769Inst : IEnumerable<long>
{
public static readonly long[] Value=A198769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198769.Bytes);
public long this[int i]=>Value[i];

public static A198769Inst Instance=new A198769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198770
{
public static readonly long[] Value={ 10L,54L,274L,1374L,6874L,34374L,171874L,859374L,4296874L,21484374L,107421874L,537109374L,2685546874L,13427734374L,67138671874L,335693359374L,1678466796874L,8392333984374L,41961669921874L,209808349609374L,1049041748046874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198770Inst : IEnumerable<long>
{
public static readonly long[] Value=A198770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198770.Bytes);
public long this[int i]=>Value[i];

public static A198770Inst Instance=new A198770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198771
{
public static readonly long[] Value={ 5L,27L,137L,687L,3437L,17187L,85937L,429687L,2148437L,10742187L,53710937L,268554687L,1342773437L,6713867187L,33569335937L,167846679687L,839233398437L,4196166992187L,20980834960937L,104904174804687L,524520874023437L,2622604370117187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198771Inst : IEnumerable<long>
{
public static readonly long[] Value=A198771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198771.Bytes);
public long this[int i]=>Value[i];

public static A198771Inst Instance=new A198771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198772
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,9L,12L,13L,16L,19L,21L,25L,27L,28L,31L,36L,37L,39L,43L,48L,52L,57L,61L,63L,64L,67L,73L,75L,76L,79L,81L,84L,93L,97L,100L,103L,108L,109L,111L,112L,117L,121L,124L,127L,129L,139L,144L,148L,151L,156L,157L,163L,171L,172L,175L,181L,183L,189L,192L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198772Inst : IEnumerable<long>
{
public static readonly long[] Value=A198772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198772.Bytes);
public long this[int i]=>Value[i];

public static A198772Inst Instance=new A198772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198773
{
public static readonly long[] Value={ 49L,91L,133L,147L,169L,196L,217L,247L,259L,273L,301L,343L,361L,364L,399L,403L,427L,441L,469L,481L,507L,511L,532L,553L,559L,588L,589L,651L,676L,679L,703L,721L,741L,763L,777L,784L,793L,817L,819L,868L,871L,889L,903L,949L,961L,973L,988L,1027L,1029L,1036L,1057L,1083L,1092L,1099L,1141L,1147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198773Inst : IEnumerable<long>
{
public static readonly long[] Value=A198773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198773.Bytes);
public long this[int i]=>Value[i];

public static A198773Inst Instance=new A198773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198774
{
public static readonly long[] Value={ 637L,931L,1183L,1519L,1813L,1911L,2107L,2401L,2527L,2548L,2793L,2989L,3211L,3283L,3549L,3577L,3724L,3871L,4557L,4693L,4732L,4753L,5047L,5239L,5341L,5439L,5733L,6076L,6223L,6253L,6321L,6727L,6811L,7203L,7252L,7267L,7399L,7581L,7644L,7693L,7987L,8379L,8428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198774Inst : IEnumerable<long>
{
public static readonly long[] Value=A198774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198774.Bytes);
public long this[int i]=>Value[i];

public static A198774Inst Instance=new A198774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198775
{
public static readonly long[] Value={ 1729L,2821L,3367L,3913L,4123L,4459L,4921L,5187L,5551L,5719L,6097L,6517L,6643L,6916L,7189L,7657L,8029L,8113L,8463L,8827L,8911L,9139L,9331L,9373L,9709L,9919L,10101L,10507L,10621L,10633L,11137L,11284L,11557L,11739L,12369L,12649L,12691L,12901L,13237L,13377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198775Inst : IEnumerable<long>
{
public static readonly long[] Value=A198775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198775.Bytes);
public long this[int i]=>Value[i];

public static A198775Inst Instance=new A198775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198776
{
public static readonly long[] Value={ 53L,2L,43L,31L,59L,59L,23L,59L,5L,67L,23L,67L,67L,67L,47L,29L,17L,67L,31L,47L,7L,5L,83L,41L,17L,73L,97L,23L,53L,53L,3L,37L,29L,37L,73L,37L,73L,37L,67L,73L,79L,59L,47L,73L,3L,67L,53L,23L,31L,17L,61L,11L,11L,19L,7L,79L,47L,79L,37L,5L,2L,29L,13L,47L,61L,2L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198776Inst : IEnumerable<long>
{
public static readonly long[] Value=A198776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198776.Bytes);
public long this[int i]=>Value[i];

public static A198776Inst Instance=new A198776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198777
{
public static readonly long[] Value={ 577L,431L,421L,593L,359L,593L,359L,677L,677L,467L,709L,947L,467L,463L,631L,809L,401L,283L,241L,173L,739L,997L,449L,353L,3L,337L,293L,937L,373L,733L,337L,773L,673L,739L,709L,491L,853L,233L,331L,151L,661L,211L,199L,79L,479L,937L,857L,2L,29L,547L,29L,43L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198777Inst : IEnumerable<long>
{
public static readonly long[] Value=A198777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198777.Bytes);
public long this[int i]=>Value[i];

public static A198777Inst Instance=new A198777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198778
{
public static readonly long[] Value={ 577L,421L,3359L,3593L,5939L,9923L,8677L,2677L,6709L,6947L,6329L,2917L,4951L,1447L,401L,4283L,2417L,6449L,5003L,3733L,3767L,7673L,9491L,2039L,853L,5323L,6211L,4793L,7937L,857L,7057L,29L,3547L,6043L,587L,6733L,7331L,3313L,1399L,7541L,5413L,4139L,8423L,4877L,503L,8431L,3109L,1093L,9973L,3613L,8893L,8933L,17L,7247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198778Inst : IEnumerable<long>
{
public static readonly long[] Value=A198778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198778.Bytes);
public long this[int i]=>Value[i];

public static A198778Inst Instance=new A198778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198779
{
public static readonly long[] Value={ 64901L,59399L,48677L,77267L,26777L,66467L,36947L,6329L,32917L,17467L,49807L,24809L,92353L,50033L,74293L,42937L,37337L,33773L,79259L,24709L,70949L,9491L,16567L,70853L,53233L,33151L,31517L,28621L,62119L,79847L,98479L,84793L,50857L,29921L,14669L,96043L,35267L,52673L,40129L,12967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198779Inst : IEnumerable<long>
{
public static readonly long[] Value=A198779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198779.Bytes);
public long this[int i]=>Value[i];

public static A198779Inst Instance=new A198779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198780
{
public static readonly long[] Value={ 939923L,992359L,746749L,241739L,644923L,350033L,500333L,374293L,937337L,773767L,160087L,670853L,532331L,199501L,79847L,847937L,29921L,299213L,325421L,526733L,673313L,331399L,12967L,375413L,395491L,954911L,38431L,93997L,939973L,60889L,271351L,349291L,79843L,984301L,341777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198780Inst : IEnumerable<long>
{
public static readonly long[] Value=A198780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198780.Bytes);
public long this[int i]=>Value[i];

public static A198780Inst Instance=new A198780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198781
{
public static readonly long[] Value={ 2402431L,5933593L,8677267L,7726777L,6467093L,6709369L,6947063L,2417399L,7394279L,4709491L,9160087L,5670853L,8532331L,1528621L,7984793L,7400299L,29921L,299213L,2542151L,5190587L,3754139L,1395491L,1116851L,4234877L,1093997L,939973L,3997361L,6088933L,2676001L,7247953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198781Inst : IEnumerable<long>
{
public static readonly long[] Value=A198781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198781.Bytes);
public long this[int i]=>Value[i];

public static A198781Inst Instance=new A198781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198782
{
public static readonly long[] Value={ 72156649L,31042159L,35939923L,93992359L,98805767L,80576723L,77766467L,36947063L,33374293L,33742937L,42937337L,33773767L,25824709L,87352039L,8532331L,15286211L,28621199L,50798479L,7984793L,299213L,40296043L,51028079L,80798423L,84234877L,20503843L,93997361L,6088933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198782Inst : IEnumerable<long>
{
public static readonly long[] Value=A198782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198782.Bytes);
public long this[int i]=>Value[i];

public static A198782Inst Instance=new A198782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198783
{
public static readonly long[] Value={ 215664901L,593359399L,235988057L,362241739L,739976449L,33374293L,337429373L,733773767L,87352039L,670853233L,146694029L,151905877L,267331399L,413954911L,984234877L,384310939L,310939973L,93997361L,939973613L,306088933L,60889331L,759271351L,549570661L,789358679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198783Inst : IEnumerable<long>
{
public static readonly long[] Value=A198783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198783.Bytes);
public long this[int i]=>Value[i];

public static A198783Inst Instance=new A198783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198784
{
public static readonly long[] Value={ 7215664901L,1566490153L,3286060651L,6060651209L,9008240243L,4310421593L,2159335939L,9235988057L,8486772677L,8070824809L,2836224173L,3622417399L,3997644923L,33374293L,2582470949L,6008735203L,87352039L,3151776611L,5015079847L,7400299213L,3139925401L,3754139549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198784Inst : IEnumerable<long>
{
public static readonly long[] Value=A198784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198784.Bytes);
public long this[int i]=>Value[i];

public static A198784Inst Instance=new A198784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198785
{
public static readonly long[] Value={ 1L,1L,3L,5L,14L,28L,77L,173L,485L,1165L,3335L,8341L,24331L,62455L,184783L,483127L,1445429L,3830911L,11562247L,30969809L,94134108L,254285698L,777410651L,2114690863L,6496549393L,17774924057L,54831676621L,150766702399L,466729836290L,1288810006264L,4002059363580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198785Inst : IEnumerable<long>
{
public static readonly long[] Value=A198785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198785.Bytes);
public long this[int i]=>Value[i];

public static A198785Inst Instance=new A198785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198786
{
public static readonly long[] Value={ 1L,2L,4L,4L,0L,-4L,0L,8L,0L,-20L,0L,56L,0L,-168L,0L,528L,0L,-1716L,0L,5720L,0L,-19448L,0L,67184L,0L,-235144L,0L,832048L,0L,-2971600L,0L,10697760L,0L,-38779380L,0L,141430680L,0L,-518579160L,0L,1910554800L,0L,-7069052760L,0L,26256481680L,0L,-97865068080L,0L,365930254560L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198786Inst : IEnumerable<long>
{
public static readonly long[] Value=A198786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198786.Bytes);
public long this[int i]=>Value[i];

public static A198786Inst Instance=new A198786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198787
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,3L,0L,4L,5L,6L,0L,6L,8L,9L,10L,0L,9L,12L,13L,14L,15L,0L,12L,16L,18L,19L,20L,21L,0L,16L,21L,24L,25L,26L,27L,28L,0L,20L,27L,30L,32L,33L,34L,35L,36L,0L,25L,33L,37L,40L,41L,42L,43L,44L,45L,0L,30L,40L,45L,48L,50L,51L,52L,53L,54L,55L,0L,36L,48L,54L,57L,60L,61L,62L,63L,64L,65L,66L,0L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198787Inst : IEnumerable<long>
{
public static readonly long[] Value=A198787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198787.Bytes);
public long this[int i]=>Value[i];

public static A198787Inst Instance=new A198787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198788
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,4L,3L,2L,1L,5L,1L,2L,1L,1L,6L,3L,1L,2L,2L,1L,7L,5L,4L,2L,1L,1L,1L,8L,7L,1L,1L,2L,1L,2L,1L,9L,1L,4L,5L,2L,3L,3L,1L,1L,10L,3L,7L,2L,1L,4L,2L,3L,2L,1L,11L,5L,1L,6L,6L,4L,4L,3L,2L,1L,1L,12L,7L,4L,1L,3L,3L,5L,1L,3L,2L,2L,1L,13L,9L,7L,5L,8L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198788Inst : IEnumerable<long>
{
public static readonly long[] Value=A198788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198788.Bytes);
public long this[int i]=>Value[i];

public static A198788Inst Instance=new A198788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198789
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,2L,3L,4L,1L,1L,2L,1L,5L,1L,2L,2L,1L,3L,6L,1L,1L,1L,2L,4L,5L,7L,1L,2L,1L,2L,1L,1L,7L,8L,1L,1L,3L,3L,2L,5L,4L,1L,9L,1L,2L,3L,2L,4L,1L,2L,7L,3L,10L,1L,1L,2L,3L,4L,4L,6L,6L,1L,5L,11L,1L,2L,2L,3L,1L,5L,3L,3L,1L,4L,7L,12L,1L,1L,1L,4L,2L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198789Inst : IEnumerable<long>
{
public static readonly long[] Value=A198789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198789.Bytes);
public long this[int i]=>Value[i];

public static A198789Inst Instance=new A198789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198790
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,2L,2L,1L,1L,4L,1L,1L,2L,2L,3L,2L,3L,3L,4L,4L,1L,5L,3L,4L,1L,2L,4L,4L,1L,2L,4L,5L,3L,2L,5L,1L,3L,4L,1L,1L,3L,4L,1L,2L,5L,4L,2L,3L,5L,1L,3L,3L,5L,1L,3L,4L,2L,1L,4L,5L,2L,3L,5L,5L,2L,3L,5L,1L,4L,3L,1L,2L,4L,5L,2L,2L,4L,5L,2L,3L,1L,6L,5L,1L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198790Inst : IEnumerable<long>
{
public static readonly long[] Value=A198790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198790.Bytes);
public long this[int i]=>Value[i];

public static A198790Inst Instance=new A198790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198791
{
public static readonly long[] Value={ 1L,5L,19L,27L,87L,989L,3119L,5399L,8189L,99663L,57455L,222397L,2603047L,8476649L,117917347L,290190179L,360064247L,1344262919L,3181391639L,39179386959L,204692414215L,165424388219L,2254874520599L,2922139183443L,594630799853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198791Inst : IEnumerable<long>
{
public static readonly long[] Value=A198791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198791.Bytes);
public long this[int i]=>Value[i];

public static A198791Inst Instance=new A198791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198792
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,4L,6L,3L,1L,0L,8L,16L,12L,4L,1L,0L,16L,40L,40L,20L,5L,1L,0L,32L,96L,120L,80L,30L,6L,1L,0L,64L,224L,336L,280L,140L,42L,7L,1L,0L,128L,512L,896L,896L,560L,224L,56L,8L,1L,0L,256L,1152L,2304L,2688L,2016L,1008L,336L,72L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198792Inst : IEnumerable<long>
{
public static readonly long[] Value=A198792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198792.Bytes);
public long this[int i]=>Value[i];

public static A198792Inst Instance=new A198792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198793
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,3L,6L,4L,0L,1L,4L,12L,16L,8L,0L,1L,5L,20L,40L,40L,16L,0L,1L,6L,30L,80L,120L,96L,32L,0L,1L,7L,42L,140L,280L,336L,224L,64L,0L,1L,8L,56L,224L,560L,896L,896L,512L,128L,0L,1L,9L,72L,336L,1008L,2016L,2688L,2304L,1152L,256L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198793Inst : IEnumerable<long>
{
public static readonly long[] Value=A198793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198793.Bytes);
public long this[int i]=>Value[i];

public static A198793Inst Instance=new A198793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198794
{
public static readonly long[] Value={ 4L,29L,179L,1079L,6479L,38879L,233279L,1399679L,8398079L,50388479L,302330879L,1813985279L,10883911679L,65303470079L,391820820479L,2350924922879L,14105549537279L,84633297223679L,507799783342079L,3046798700052479L,18280792200314879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198794Inst : IEnumerable<long>
{
public static readonly long[] Value=A198794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198794.Bytes);
public long this[int i]=>Value[i];

public static A198794Inst Instance=new A198794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198795
{
public static readonly long[] Value={ 6L,41L,251L,1511L,9071L,54431L,326591L,1959551L,11757311L,70543871L,423263231L,2539579391L,15237476351L,91424858111L,548549148671L,3291294892031L,19747769352191L,118486616113151L,710919696678911L,4265518180073471L,25593109080440831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198795Inst : IEnumerable<long>
{
public static readonly long[] Value=A198795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198795.Bytes);
public long this[int i]=>Value[i];

public static A198795Inst Instance=new A198795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198796
{
public static readonly long[] Value={ 2L,17L,107L,647L,3887L,23327L,139967L,839807L,5038847L,30233087L,181398527L,1088391167L,6530347007L,39182082047L,235092492287L,1410554953727L,8463329722367L,50779978334207L,304679870005247L,1828079220031487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198796Inst : IEnumerable<long>
{
public static readonly long[] Value=A198796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198796.Bytes);
public long this[int i]=>Value[i];

public static A198796Inst Instance=new A198796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198797
{
public static readonly long[] Value={ 3L,23L,143L,863L,5183L,31103L,186623L,1119743L,6718463L,40310783L,241864703L,1451188223L,8707129343L,52242776063L,313456656383L,1880739938303L,11284439629823L,67706637778943L,406239826673663L,2437438960041983L,14624633760251903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198797Inst : IEnumerable<long>
{
public static readonly long[] Value=A198797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198797.Bytes);
public long this[int i]=>Value[i];

public static A198797Inst Instance=new A198797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198798
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,5L,-1L,3L,-1L,1L,7L,-1L,1L,5L,11L,3L,5L,11L,-1L,1L,7L,11L,-1L,7L,11L,13L,17L,-1L,3L,17L,-1L,5L,7L,17L,19L,1L,7L,11L,17L,23L,-1L,9L,11L,15L,17L,1L,13L,17L,19L,23L,-1L,1L,11L,17L,23L,29L,-1L,5L,9L,11L,21L,1L,5L,7L,11L,25L,31L,5L,7L,11L,17L,25L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198798Inst : IEnumerable<long>
{
public static readonly long[] Value=A198798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198798.Bytes);
public long this[int i]=>Value[i];

public static A198798Inst Instance=new A198798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198799
{
public static readonly long[] Value={ 2L,0L,49L,637L,1729L,8281L,12103L,1529437L,53599L,157339L,593047L,19882681L,375193L,68574961L,2989441L,7709611L,1983163L,47738317081L,4877509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198799Inst : IEnumerable<long>
{
public static readonly long[] Value=A198799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198799.Bytes);
public long this[int i]=>Value[i];

public static A198799Inst Instance=new A198799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198800
{
public static readonly BigInteger[] Value={ 1L,0L,20L,0L,1140L,480L,102800L,151200L,12310900L,38707200L,1812247920L,9574488000L,313983978000L,2391608419200L,62051403928800L,611744666332800L,13627749414064500L,160896284989440000L,3253345101771050000L,BigInteger.Parse("43527416858084016000"),BigInteger.Parse("829176006298475046640") };
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
public class A198800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198800Inst Instance=new A198800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198801
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,121645100408832000L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198801Inst : IEnumerable<long>
{
public static readonly long[] Value=A198801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198801.Bytes);
public long this[int i]=>Value[i];

public static A198801Inst Instance=new A198801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198802
{
public static readonly BigInteger[] Value={ 1L,0L,18L,36L,918L,5400L,82800L,801360L,10907190L,132053040L,1802041668L,24199809480L,340640607384L,4834708246368L,70229958125184L,1032223723667136L,15391538570569590L,231935110984687968L,3531542904056225916L,BigInteger.Parse("54244559313713885688"),BigInteger.Parse("839979883121036697468") };
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
public class A198802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198802Inst Instance=new A198802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198803
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,355687428096000L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198803Inst : IEnumerable<long>
{
public static readonly long[] Value=A198803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198803.Bytes);
public long this[int i]=>Value[i];

public static A198803Inst Instance=new A198803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198804
{
public static readonly BigInteger[] Value={ 1L,0L,16L,0L,720L,0L,50560L,0L,4649680L,0L,514031616L,0L,64941883776L,0L,9071319628800L,0L,1369263687414480L,0L,219705672931613440L,0L,BigInteger.Parse("37024402443528248320"),0L,BigInteger.Parse("6493814173413849784320"),0L,BigInteger.Parse("1177304833671218302960000"),0L,BigInteger.Parse("219456611569479963675136000"),0L };
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
public class A198804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198804Inst Instance=new A198804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198805
{
public static readonly long[] Value={ 1L,0L,0L,30L,0L,360L,7650L,0L,302400L,4544400L,11226600L,324324000L,4310633250L,24324300000L,437404968000L,5634178329780L,45972927000000L,697866761592000L,8962716395833200L,88725951057744000L,1258898645656852200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198805Inst : IEnumerable<long>
{
public static readonly long[] Value=A198805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198805.Bytes);
public long this[int i]=>Value[i];

public static A198805Inst Instance=new A198805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198806
{
public static readonly long[] Value={ 1L,0L,14L,0L,546L,0L,32900L,10080L,2570050L,2540160L,238935564L,465696000L,25142196156L,76886409600L,2900343069624L,12211317518400L,359067702643650L,1915829643087360L,47006105030584700L,300455419743198720L,6437718469449262996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198806Inst : IEnumerable<long>
{
public static readonly long[] Value=A198806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198806.Bytes);
public long this[int i]=>Value[i];

public static A198806Inst Instance=new A198806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198807
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6227020800L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198807Inst : IEnumerable<long>
{
public static readonly long[] Value=A198807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198807.Bytes);
public long this[int i]=>Value[i];

public static A198807Inst Instance=new A198807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198808
{
public static readonly long[] Value={ 1L,0L,12L,24L,396L,2160L,23160L,186480L,1845900L,17213280L,171575712L,1703560320L,17365421304L,178323713568L,1856554560432L,19487791106784L,206411964321420L,2201711191213248L,23642813637773616L,255355132936441824L,2772650461148938656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198808Inst : IEnumerable<long>
{
public static readonly long[] Value=A198808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198808.Bytes);
public long this[int i]=>Value[i];

public static A198808Inst Instance=new A198808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198809
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,39916800L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198809Inst : IEnumerable<long>
{
public static readonly long[] Value=A198809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198809.Bytes);
public long this[int i]=>Value[i];

public static A198809Inst Instance=new A198809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198810
{
public static readonly long[] Value={ 1L,0L,0L,18L,0L,0L,2430L,0L,0L,640080L,0L,0L,215488350L,0L,0L,84569753268L,0L,0L,36905812607664L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198810Inst : IEnumerable<long>
{
public static readonly long[] Value=A198810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198810.Bytes);
public long this[int i]=>Value[i];

public static A198810Inst Instance=new A198810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198811
{
public static readonly long[] Value={ 2L,3L,1L,3L,5L,8L,9L,3L,4L,9L,0L,4L,8L,4L,8L,7L,9L,2L,2L,4L,4L,5L,3L,0L,4L,1L,3L,3L,6L,6L,6L,6L,7L,2L,8L,0L,7L,6L,1L,5L,6L,6L,4L,7L,2L,0L,7L,2L,0L,6L,7L,7L,3L,7L,5L,2L,1L,7L,0L,4L,8L,3L,6L,4L,1L,9L,2L,1L,9L,6L,8L,8L,7L,1L,5L,5L,4L,2L,7L,3L,4L,2L,5L,0L,0L,0L,1L,1L,5L,7L,7L,6L,3L,7L,2L,3L,4L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198811Inst : IEnumerable<long>
{
public static readonly long[] Value=A198811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198811.Bytes);
public long this[int i]=>Value[i];

public static A198811Inst Instance=new A198811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198812
{
public static readonly long[] Value={ 2L,1L,6L,0L,8L,1L,9L,4L,5L,8L,1L,0L,8L,3L,9L,5L,5L,4L,4L,9L,4L,7L,6L,8L,7L,7L,6L,3L,5L,0L,8L,3L,4L,8L,3L,3L,5L,9L,8L,2L,3L,6L,0L,1L,7L,6L,0L,5L,1L,8L,3L,5L,5L,9L,7L,2L,1L,1L,6L,1L,4L,5L,3L,0L,2L,5L,2L,0L,5L,1L,4L,2L,3L,6L,1L,2L,1L,3L,2L,4L,6L,3L,5L,9L,5L,1L,9L,1L,7L,5L,7L,1L,7L,0L,8L,6L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198812Inst : IEnumerable<long>
{
public static readonly long[] Value=A198812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198812.Bytes);
public long this[int i]=>Value[i];

public static A198812Inst Instance=new A198812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198813
{
public static readonly long[] Value={ 2L,5L,4L,6L,3L,9L,0L,7L,7L,5L,8L,0L,2L,8L,8L,8L,7L,7L,6L,8L,5L,6L,1L,7L,2L,7L,0L,9L,3L,9L,3L,6L,1L,2L,8L,9L,5L,0L,3L,7L,3L,3L,5L,1L,2L,3L,1L,9L,1L,4L,5L,9L,0L,3L,8L,1L,8L,4L,1L,2L,9L,9L,7L,9L,3L,4L,1L,7L,9L,8L,3L,1L,9L,5L,8L,4L,9L,9L,6L,8L,7L,3L,0L,0L,1L,2L,8L,1L,7L,6L,7L,8L,9L,1L,7L,1L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198813Inst : IEnumerable<long>
{
public static readonly long[] Value=A198813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198813.Bytes);
public long this[int i]=>Value[i];

public static A198813Inst Instance=new A198813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198814
{
public static readonly long[] Value={ 1L,1L,1L,7L,8L,9L,0L,5L,8L,7L,7L,5L,6L,7L,5L,3L,7L,5L,9L,7L,9L,6L,8L,8L,7L,1L,6L,9L,5L,7L,9L,1L,6L,2L,9L,5L,6L,1L,8L,6L,1L,7L,5L,8L,7L,0L,3L,7L,5L,4L,0L,6L,9L,4L,6L,9L,4L,6L,7L,1L,9L,3L,0L,1L,4L,5L,1L,3L,9L,9L,2L,4L,3L,9L,1L,1L,8L,6L,3L,1L,6L,2L,9L,5L,3L,1L,4L,1L,9L,6L,9L,3L,8L,1L,0L,2L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198814Inst : IEnumerable<long>
{
public static readonly long[] Value=A198814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198814.Bytes);
public long this[int i]=>Value[i];

public static A198814Inst Instance=new A198814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198815
{
public static readonly long[] Value={ 2L,7L,8L,3L,1L,1L,4L,7L,5L,6L,5L,0L,3L,0L,2L,0L,3L,0L,0L,6L,3L,9L,9L,2L,2L,7L,2L,9L,2L,3L,6L,9L,5L,8L,5L,1L,8L,5L,9L,8L,8L,1L,3L,0L,7L,0L,3L,5L,6L,5L,4L,2L,1L,3L,4L,2L,4L,9L,6L,8L,8L,7L,3L,8L,8L,0L,8L,9L,3L,7L,9L,2L,4L,2L,7L,8L,6L,8L,9L,4L,7L,2L,5L,9L,6L,6L,3L,7L,0L,1L,3L,5L,1L,5L,9L,5L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198815Inst : IEnumerable<long>
{
public static readonly long[] Value=A198815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198815.Bytes);
public long this[int i]=>Value[i];

public static A198815Inst Instance=new A198815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198816
{
public static readonly long[] Value={ 1L,1L,7L,6L,5L,0L,1L,9L,3L,9L,9L,0L,1L,8L,3L,2L,4L,0L,0L,4L,4L,7L,3L,7L,7L,2L,6L,8L,7L,3L,1L,0L,4L,0L,9L,8L,6L,6L,2L,3L,7L,1L,2L,3L,5L,8L,9L,8L,1L,2L,9L,2L,4L,1L,4L,4L,2L,8L,6L,6L,0L,1L,8L,4L,9L,8L,5L,8L,6L,6L,3L,7L,4L,4L,1L,5L,1L,3L,5L,9L,0L,7L,3L,4L,3L,3L,0L,0L,4L,7L,1L,5L,7L,1L,5L,9L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198816Inst : IEnumerable<long>
{
public static readonly long[] Value=A198816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198816.Bytes);
public long this[int i]=>Value[i];

public static A198816Inst Instance=new A198816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198817
{
public static readonly long[] Value={ 1L,4L,5L,4L,6L,1L,8L,9L,2L,9L,2L,0L,8L,1L,1L,1L,2L,7L,8L,7L,9L,5L,8L,4L,2L,2L,2L,3L,3L,7L,8L,0L,9L,3L,2L,9L,1L,0L,4L,3L,2L,4L,7L,9L,6L,7L,5L,8L,6L,4L,2L,5L,8L,2L,7L,5L,9L,7L,3L,1L,8L,4L,8L,7L,1L,9L,5L,3L,9L,1L,2L,9L,9L,6L,9L,4L,2L,5L,4L,2L,9L,8L,5L,1L,4L,6L,0L,4L,8L,1L,3L,4L,3L,9L,9L,0L,8L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198817Inst : IEnumerable<long>
{
public static readonly long[] Value=A198817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198817.Bytes);
public long this[int i]=>Value[i];

public static A198817Inst Instance=new A198817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198818
{
public static readonly long[] Value={ 1L,6L,9L,5L,7L,0L,5L,0L,9L,9L,0L,8L,3L,0L,6L,6L,8L,0L,6L,1L,5L,7L,4L,9L,1L,2L,9L,9L,6L,4L,4L,3L,9L,7L,7L,9L,7L,5L,4L,3L,8L,8L,9L,7L,4L,2L,2L,4L,4L,5L,8L,9L,1L,5L,7L,9L,2L,6L,0L,8L,8L,9L,9L,4L,4L,5L,4L,2L,8L,9L,0L,4L,4L,4L,7L,7L,2L,1L,8L,5L,3L,9L,1L,2L,0L,8L,1L,3L,4L,5L,0L,2L,5L,5L,7L,2L,5L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198818Inst : IEnumerable<long>
{
public static readonly long[] Value=A198818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198818.Bytes);
public long this[int i]=>Value[i];

public static A198818Inst Instance=new A198818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198819
{
public static readonly long[] Value={ 1L,9L,1L,4L,0L,2L,0L,6L,1L,9L,0L,2L,5L,9L,8L,5L,3L,9L,1L,1L,9L,3L,9L,6L,3L,8L,3L,0L,1L,7L,1L,0L,9L,8L,0L,4L,2L,9L,3L,7L,9L,5L,9L,9L,7L,3L,2L,8L,1L,0L,6L,5L,5L,8L,5L,5L,0L,8L,5L,5L,4L,0L,9L,1L,0L,8L,0L,6L,4L,2L,8L,4L,8L,6L,2L,2L,4L,4L,5L,0L,3L,0L,8L,1L,9L,9L,2L,9L,7L,0L,5L,4L,9L,7L,0L,8L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198819Inst : IEnumerable<long>
{
public static readonly long[] Value=A198819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198819.Bytes);
public long this[int i]=>Value[i];

public static A198819Inst Instance=new A198819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198820
{
public static readonly long[] Value={ 8L,0L,9L,3L,2L,4L,5L,6L,9L,9L,4L,6L,0L,6L,7L,2L,0L,8L,5L,3L,6L,3L,2L,9L,7L,1L,4L,1L,9L,0L,7L,3L,1L,9L,0L,5L,9L,6L,0L,0L,5L,7L,7L,4L,4L,5L,0L,7L,6L,0L,6L,8L,4L,3L,9L,2L,2L,8L,5L,1L,1L,8L,7L,2L,6L,5L,7L,3L,7L,7L,0L,8L,5L,5L,0L,6L,2L,5L,4L,7L,9L,6L,1L,9L,5L,5L,9L,3L,2L,1L,9L,5L,4L,4L,1L,5L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198820Inst : IEnumerable<long>
{
public static readonly long[] Value=A198820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198820.Bytes);
public long this[int i]=>Value[i];

public static A198820Inst Instance=new A198820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198821
{
public static readonly long[] Value={ 1L,2L,6L,5L,4L,2L,3L,7L,0L,5L,8L,6L,9L,3L,3L,4L,9L,5L,5L,9L,4L,9L,5L,6L,9L,3L,2L,5L,7L,5L,5L,3L,2L,7L,0L,5L,6L,0L,7L,1L,8L,3L,2L,1L,7L,6L,1L,7L,7L,6L,7L,9L,8L,0L,5L,4L,1L,8L,2L,7L,8L,3L,4L,7L,4L,4L,9L,1L,6L,3L,5L,0L,6L,5L,0L,1L,4L,0L,7L,1L,5L,6L,7L,5L,2L,7L,0L,8L,1L,8L,7L,1L,3L,1L,5L,9L,7L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198821Inst : IEnumerable<long>
{
public static readonly long[] Value=A198821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198821.Bytes);
public long this[int i]=>Value[i];

public static A198821Inst Instance=new A198821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198822
{
public static readonly long[] Value={ 1L,4L,7L,8L,1L,7L,0L,2L,6L,6L,4L,3L,0L,3L,2L,1L,2L,8L,3L,3L,1L,0L,6L,2L,4L,1L,7L,5L,3L,4L,7L,7L,4L,6L,8L,0L,8L,0L,2L,6L,8L,2L,3L,5L,1L,7L,8L,0L,1L,5L,1L,4L,9L,2L,9L,9L,3L,1L,3L,6L,1L,2L,7L,1L,5L,4L,6L,5L,6L,9L,3L,0L,9L,7L,6L,7L,0L,9L,5L,1L,8L,9L,1L,9L,8L,7L,5L,2L,2L,1L,3L,6L,5L,6L,9L,6L,9L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198822Inst : IEnumerable<long>
{
public static readonly long[] Value=A198822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198822.Bytes);
public long this[int i]=>Value[i];

public static A198822Inst Instance=new A198822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198823
{
public static readonly long[] Value={ 1L,6L,7L,2L,4L,4L,1L,3L,0L,4L,8L,7L,3L,5L,2L,9L,5L,1L,3L,4L,3L,2L,9L,6L,0L,4L,5L,2L,0L,8L,9L,4L,0L,1L,9L,9L,7L,3L,8L,0L,1L,2L,6L,6L,8L,0L,9L,7L,1L,9L,8L,0L,0L,3L,5L,5L,4L,9L,6L,6L,6L,6L,6L,8L,4L,4L,7L,5L,4L,7L,0L,2L,4L,8L,4L,3L,7L,1L,3L,1L,3L,4L,3L,3L,9L,0L,1L,4L,0L,8L,7L,2L,2L,7L,5L,5L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198823Inst : IEnumerable<long>
{
public static readonly long[] Value=A198823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198823.Bytes);
public long this[int i]=>Value[i];

public static A198823Inst Instance=new A198823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198824
{
public static readonly long[] Value={ 1L,8L,5L,4L,6L,7L,8L,2L,4L,7L,9L,1L,4L,9L,3L,1L,4L,9L,4L,7L,5L,6L,7L,5L,5L,1L,3L,2L,0L,3L,3L,0L,6L,5L,0L,6L,8L,2L,6L,1L,4L,0L,1L,6L,8L,8L,4L,7L,6L,3L,2L,9L,7L,9L,4L,4L,8L,7L,0L,5L,4L,2L,3L,2L,5L,7L,4L,2L,4L,2L,6L,6L,4L,7L,3L,3L,8L,3L,6L,1L,7L,3L,9L,5L,5L,7L,3L,7L,2L,3L,9L,3L,1L,6L,7L,5L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198824Inst : IEnumerable<long>
{
public static readonly long[] Value=A198824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198824.Bytes);
public long this[int i]=>Value[i];

public static A198824Inst Instance=new A198824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198825
{
public static readonly long[] Value={ 7L,1L,4L,6L,2L,1L,0L,5L,7L,7L,7L,9L,2L,8L,3L,5L,7L,1L,3L,0L,7L,6L,0L,2L,6L,8L,1L,4L,9L,2L,2L,6L,1L,1L,5L,1L,3L,1L,7L,1L,8L,9L,3L,0L,0L,0L,0L,5L,5L,8L,0L,5L,6L,5L,3L,8L,1L,1L,2L,8L,4L,2L,0L,0L,8L,7L,1L,9L,2L,0L,8L,9L,2L,5L,7L,3L,5L,9L,3L,6L,7L,9L,3L,6L,9L,5L,7L,0L,7L,1L,1L,9L,2L,8L,0L,7L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198825Inst : IEnumerable<long>
{
public static readonly long[] Value=A198825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198825.Bytes);
public long this[int i]=>Value[i];

public static A198825Inst Instance=new A198825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198826
{
public static readonly long[] Value={ 1L,3L,2L,0L,3L,8L,3L,3L,5L,6L,9L,4L,3L,9L,6L,2L,6L,4L,7L,4L,8L,1L,6L,3L,5L,3L,0L,2L,1L,7L,6L,8L,2L,9L,4L,9L,6L,5L,5L,4L,8L,5L,7L,3L,9L,0L,8L,2L,4L,4L,3L,1L,6L,5L,9L,7L,8L,9L,5L,1L,4L,2L,1L,3L,0L,8L,9L,1L,6L,2L,1L,8L,1L,6L,1L,2L,9L,7L,6L,8L,4L,3L,9L,1L,4L,2L,0L,6L,4L,2L,3L,9L,2L,7L,0L,0L,7L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198826Inst : IEnumerable<long>
{
public static readonly long[] Value=A198826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198826.Bytes);
public long this[int i]=>Value[i];

public static A198826Inst Instance=new A198826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198827
{
public static readonly long[] Value={ 1L,1L,3L,5L,3L,9L,0L,0L,6L,7L,0L,2L,6L,9L,1L,7L,2L,0L,7L,3L,6L,5L,4L,2L,3L,8L,3L,9L,7L,6L,4L,5L,8L,0L,0L,0L,0L,4L,0L,9L,1L,5L,3L,4L,5L,8L,9L,6L,7L,2L,7L,2L,0L,3L,0L,6L,2L,9L,6L,2L,2L,0L,6L,8L,9L,0L,0L,5L,8L,5L,3L,4L,3L,4L,9L,3L,0L,6L,8L,8L,1L,8L,1L,7L,9L,7L,0L,3L,2L,3L,2L,6L,4L,3L,8L,0L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198827Inst : IEnumerable<long>
{
public static readonly long[] Value=A198827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198827.Bytes);
public long this[int i]=>Value[i];

public static A198827Inst Instance=new A198827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198828
{
public static readonly long[] Value={ 1L,4L,9L,3L,6L,8L,6L,6L,5L,7L,8L,3L,4L,6L,5L,2L,5L,7L,6L,6L,4L,8L,7L,9L,0L,7L,9L,9L,2L,2L,3L,9L,0L,5L,7L,1L,6L,1L,4L,1L,1L,1L,4L,9L,5L,3L,7L,3L,6L,5L,3L,4L,1L,8L,5L,3L,3L,1L,3L,6L,2L,5L,2L,8L,8L,7L,8L,6L,1L,6L,0L,9L,6L,4L,1L,3L,9L,7L,5L,1L,0L,9L,6L,4L,4L,0L,1L,9L,9L,1L,1L,8L,4L,9L,1L,9L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198828Inst : IEnumerable<long>
{
public static readonly long[] Value=A198828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198828.Bytes);
public long this[int i]=>Value[i];

public static A198828Inst Instance=new A198828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198829
{
public static readonly long[] Value={ 1L,6L,5L,6L,3L,7L,4L,8L,5L,7L,4L,5L,0L,9L,3L,8L,9L,1L,4L,1L,8L,7L,3L,4L,9L,9L,4L,0L,4L,1L,7L,6L,7L,1L,1L,0L,2L,0L,0L,7L,4L,3L,6L,9L,4L,1L,0L,0L,2L,2L,9L,4L,1L,2L,5L,9L,8L,8L,8L,3L,5L,4L,5L,2L,2L,6L,0L,6L,9L,9L,0L,5L,8L,3L,6L,3L,5L,1L,5L,8L,3L,9L,5L,4L,5L,1L,8L,5L,9L,0L,0L,6L,2L,0L,6L,7L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198829Inst : IEnumerable<long>
{
public static readonly long[] Value=A198829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198829.Bytes);
public long this[int i]=>Value[i];

public static A198829Inst Instance=new A198829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198830
{
public static readonly long[] Value={ 1L,8L,1L,2L,0L,0L,6L,2L,8L,9L,8L,3L,9L,4L,2L,3L,4L,2L,8L,9L,7L,7L,3L,2L,0L,9L,3L,8L,2L,4L,0L,6L,6L,7L,8L,4L,8L,6L,2L,7L,8L,5L,7L,2L,9L,8L,9L,1L,9L,1L,5L,8L,1L,1L,2L,0L,8L,2L,3L,6L,5L,5L,0L,1L,7L,8L,3L,0L,9L,3L,4L,7L,2L,9L,7L,5L,3L,6L,4L,2L,7L,1L,5L,3L,8L,6L,1L,9L,9L,7L,6L,0L,5L,9L,2L,2L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198830Inst : IEnumerable<long>
{
public static readonly long[] Value=A198830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198830.Bytes);
public long this[int i]=>Value[i];

public static A198830Inst Instance=new A198830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198831
{
public static readonly long[] Value={ 0L,4L,20L,28L,39L,47L,81L,135L,152L,207L,216L,270L,496L,546L,615L,732L,832L,1148L,1208L,1343L,1391L,1541L,1750L,2000L,2260L,2548L,2575L,2825L,3679L,3807L,4220L,4604L,5076L,5508L,5835L,5859L,6291L,7538L,7656L,8188L,8423L,8712L,8964L,12092L,12205L,12511L,12926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198831Inst : IEnumerable<long>
{
public static readonly long[] Value=A198831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198831.Bytes);
public long this[int i]=>Value[i];

public static A198831Inst Instance=new A198831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198832
{
public static readonly long[] Value={ 1L,2L,6L,8L,10L,12L,13L,19L,26L,31L,33L,39L,40L,43L,46L,52L,68L,72L,78L,84L,90L,93L,95L,105L,109L,133L,139L,149L,152L,162L,176L,180L,190L,202L,211L,219L,231L,243L,265L,269L,272L,306L,330L,336L,341L,346L,351L,356L,366L,393L,407L,422L,436L,446L,450L,467L,501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198832Inst : IEnumerable<long>
{
public static readonly long[] Value=A198832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198832.Bytes);
public long this[int i]=>Value[i];

public static A198832Inst Instance=new A198832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198833
{
public static readonly long[] Value={ 1L,10L,56L,220L,680L,1771L,4060L,8436L,16215L,29260L,50116L,82160L,129766L,198485L,295240L,428536L,608685L,848046L,1161280L,1565620L,2081156L,2731135L,3542276L,4545100L,5774275L,7268976L,9073260L,11236456L,13813570L,16865705L,20460496L,24672560L,29583961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198833Inst : IEnumerable<long>
{
public static readonly long[] Value=A198833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198833.Bytes);
public long this[int i]=>Value[i];

public static A198833Inst Instance=new A198833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198834
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,6L,10L,16L,26L,42L,68L,110L,178L,288L,466L,754L,1220L,1974L,3194L,5168L,8362L,13530L,21892L,35422L,57314L,92736L,150050L,242786L,392836L,635622L,1028458L,1664080L,2692538L,4356618L,7049156L,11405774L,18454930L,29860704L,48315634L,78176338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198834Inst : IEnumerable<long>
{
public static readonly long[] Value=A198834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198834.Bytes);
public long this[int i]=>Value[i];

public static A198834Inst Instance=new A198834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198835
{
public static readonly long[] Value={ 9L,1L,3L,1L,3L,2L,0L,0L,0L,7L,8L,5L,9L,1L,6L,0L,4L,1L,7L,3L,6L,8L,0L,8L,6L,0L,0L,1L,2L,3L,1L,6L,5L,7L,4L,6L,8L,7L,3L,0L,2L,8L,8L,6L,2L,2L,9L,7L,7L,5L,6L,4L,7L,1L,7L,7L,8L,2L,3L,4L,5L,1L,2L,9L,8L,8L,2L,7L,5L,5L,0L,2L,8L,5L,8L,0L,0L,7L,1L,3L,9L,1L,2L,9L,9L,6L,3L,9L,0L,7L,0L,5L,8L,9L,4L,3L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198835Inst : IEnumerable<long>
{
public static readonly long[] Value=A198835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198835.Bytes);
public long this[int i]=>Value[i];

public static A198835Inst Instance=new A198835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198836
{
public static readonly long[] Value={ 6L,3L,8L,9L,2L,0L,6L,5L,7L,6L,0L,4L,5L,9L,4L,5L,3L,8L,9L,0L,8L,2L,5L,7L,4L,6L,2L,6L,4L,4L,2L,5L,9L,6L,7L,6L,3L,0L,1L,0L,5L,8L,0L,6L,6L,0L,6L,3L,6L,8L,8L,9L,0L,7L,7L,5L,8L,0L,5L,9L,9L,7L,0L,7L,7L,5L,5L,8L,6L,4L,2L,4L,9L,9L,7L,3L,0L,0L,3L,0L,7L,6L,4L,7L,7L,5L,5L,4L,3L,0L,0L,7L,7L,1L,2L,0L,5L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198836Inst : IEnumerable<long>
{
public static readonly long[] Value=A198836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198836.Bytes);
public long this[int i]=>Value[i];

public static A198836Inst Instance=new A198836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198837
{
public static readonly long[] Value={ 1L,3L,8L,0L,3L,4L,3L,5L,1L,9L,9L,5L,5L,4L,3L,1L,1L,4L,4L,2L,0L,6L,9L,4L,9L,1L,5L,7L,5L,5L,6L,8L,8L,1L,5L,5L,7L,1L,5L,5L,6L,4L,6L,4L,6L,9L,7L,8L,5L,3L,6L,8L,3L,2L,8L,5L,5L,3L,7L,1L,2L,9L,3L,9L,9L,6L,5L,2L,9L,7L,9L,7L,3L,9L,9L,1L,0L,4L,3L,4L,5L,9L,1L,3L,8L,5L,1L,7L,4L,0L,7L,2L,4L,5L,9L,2L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198837Inst : IEnumerable<long>
{
public static readonly long[] Value=A198837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198837.Bytes);
public long this[int i]=>Value[i];

public static A198837Inst Instance=new A198837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198838
{
public static readonly long[] Value={ 1L,3L,5L,8L,0L,9L,2L,3L,4L,9L,7L,9L,6L,9L,3L,5L,9L,1L,5L,2L,2L,9L,3L,4L,4L,7L,8L,2L,9L,4L,8L,7L,3L,2L,1L,8L,3L,3L,8L,3L,9L,9L,6L,9L,6L,0L,5L,6L,2L,0L,9L,2L,1L,9L,2L,8L,5L,9L,0L,0L,7L,8L,6L,1L,2L,0L,3L,9L,1L,1L,8L,7L,3L,4L,6L,8L,2L,7L,7L,9L,1L,2L,0L,2L,0L,7L,7L,2L,7L,5L,8L,6L,3L,6L,8L,4L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198838Inst : IEnumerable<long>
{
public static readonly long[] Value=A198838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198838.Bytes);
public long this[int i]=>Value[i];

public static A198838Inst Instance=new A198838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198839
{
public static readonly long[] Value={ 1L,5L,0L,4L,7L,1L,0L,1L,0L,6L,8L,5L,0L,9L,4L,5L,4L,9L,9L,7L,7L,7L,2L,5L,1L,4L,4L,9L,0L,7L,7L,7L,0L,9L,6L,5L,7L,1L,8L,8L,8L,5L,9L,0L,3L,7L,4L,3L,3L,2L,3L,4L,8L,1L,9L,6L,2L,5L,1L,3L,3L,0L,5L,9L,3L,6L,0L,9L,0L,3L,1L,2L,1L,0L,4L,8L,3L,9L,0L,9L,7L,4L,9L,7L,6L,2L,8L,1L,8L,9L,3L,3L,2L,2L,4L,9L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198839Inst : IEnumerable<long>
{
public static readonly long[] Value=A198839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198839.Bytes);
public long this[int i]=>Value[i];

public static A198839Inst Instance=new A198839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198840
{
public static readonly long[] Value={ 1L,6L,4L,4L,6L,4L,7L,2L,7L,4L,3L,1L,3L,4L,6L,2L,7L,1L,7L,7L,1L,4L,6L,4L,2L,3L,2L,5L,5L,6L,8L,1L,5L,9L,2L,4L,6L,7L,0L,5L,8L,7L,0L,1L,4L,1L,3L,4L,1L,8L,6L,0L,7L,1L,5L,0L,7L,2L,8L,0L,1L,8L,6L,7L,6L,3L,9L,9L,6L,8L,8L,5L,4L,0L,8L,5L,6L,3L,4L,9L,7L,8L,2L,1L,7L,1L,1L,6L,4L,8L,5L,9L,3L,7L,8L,5L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198840Inst : IEnumerable<long>
{
public static readonly long[] Value=A198840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198840.Bytes);
public long this[int i]=>Value[i];

public static A198840Inst Instance=new A198840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198841
{
public static readonly long[] Value={ 1L,7L,8L,0L,1L,1L,7L,2L,2L,3L,4L,1L,3L,3L,4L,6L,8L,8L,9L,5L,9L,0L,3L,8L,5L,8L,7L,8L,9L,0L,2L,8L,3L,5L,8L,8L,2L,5L,4L,6L,2L,0L,1L,9L,4L,0L,3L,4L,4L,7L,7L,3L,5L,4L,7L,0L,5L,6L,8L,9L,9L,7L,1L,0L,4L,6L,8L,8L,4L,3L,4L,3L,5L,8L,3L,2L,6L,7L,0L,9L,7L,7L,0L,2L,8L,8L,5L,3L,0L,2L,8L,5L,8L,8L,8L,7L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198841Inst : IEnumerable<long>
{
public static readonly long[] Value=A198841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198841.Bytes);
public long this[int i]=>Value[i];

public static A198841Inst Instance=new A198841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198842
{
public static readonly long[] Value={ 1L,0L,2L,9L,7L,0L,4L,0L,0L,0L,7L,3L,6L,0L,5L,4L,5L,5L,8L,4L,1L,1L,6L,7L,9L,2L,6L,7L,9L,8L,2L,9L,0L,6L,9L,5L,8L,9L,4L,5L,5L,8L,8L,8L,3L,4L,8L,1L,5L,9L,5L,7L,8L,4L,0L,6L,8L,8L,0L,7L,9L,2L,9L,7L,4L,9L,5L,7L,2L,7L,6L,2L,9L,7L,4L,3L,4L,7L,2L,6L,5L,2L,4L,8L,3L,5L,7L,7L,1L,8L,8L,8L,9L,1L,0L,5L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198842Inst : IEnumerable<long>
{
public static readonly long[] Value=A198842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198842.Bytes);
public long this[int i]=>Value[i];

public static A198842Inst Instance=new A198842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198843
{
public static readonly long[] Value={ 8L,3L,2L,2L,9L,6L,4L,6L,2L,4L,2L,0L,4L,5L,4L,8L,1L,5L,8L,3L,2L,6L,8L,9L,6L,3L,9L,1L,5L,4L,8L,3L,8L,2L,7L,3L,9L,2L,3L,2L,7L,3L,3L,4L,7L,5L,9L,0L,9L,2L,0L,9L,5L,3L,8L,4L,6L,3L,3L,1L,8L,2L,9L,9L,0L,7L,2L,2L,1L,4L,3L,1L,4L,2L,2L,9L,9L,5L,9L,5L,8L,8L,0L,4L,2L,3L,4L,0L,0L,9L,8L,4L,3L,7L,6L,4L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198843Inst : IEnumerable<long>
{
public static readonly long[] Value=A198843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198843.Bytes);
public long this[int i]=>Value[i];

public static A198843Inst Instance=new A198843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198844
{
public static readonly long[] Value={ 5L,8L,2L,8L,1L,3L,0L,0L,3L,4L,7L,1L,8L,1L,3L,8L,3L,2L,1L,9L,9L,9L,4L,8L,8L,0L,1L,1L,0L,4L,9L,7L,0L,5L,9L,8L,5L,8L,7L,5L,3L,4L,5L,3L,2L,3L,3L,2L,6L,7L,1L,6L,4L,6L,4L,5L,7L,8L,0L,3L,1L,6L,0L,3L,8L,1L,6L,6L,0L,0L,2L,5L,0L,5L,2L,6L,0L,1L,8L,4L,0L,2L,6L,3L,0L,0L,9L,0L,5L,2L,0L,4L,6L,4L,3L,1L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198844Inst : IEnumerable<long>
{
public static readonly long[] Value=A198844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198844.Bytes);
public long this[int i]=>Value[i];

public static A198844Inst Instance=new A198844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198845
{
public static readonly long[] Value={ 7L,47L,287L,1727L,10367L,62207L,373247L,2239487L,13436927L,80621567L,483729407L,2902376447L,17414258687L,104485552127L,626913312767L,3761479876607L,22568879259647L,135413275557887L,812479653347327L,4874877920083967L,29249267520503807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198845Inst : IEnumerable<long>
{
public static readonly long[] Value=A198845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198845.Bytes);
public long this[int i]=>Value[i];

public static A198845Inst Instance=new A198845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198846
{
public static readonly long[] Value={ 8L,53L,323L,1943L,11663L,69983L,419903L,2519423L,15116543L,90699263L,544195583L,3265173503L,19591041023L,117546246143L,705277476863L,4231664861183L,25389989167103L,152339935002623L,914039610015743L,5484237660094463L,32905425960566783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198846Inst : IEnumerable<long>
{
public static readonly long[] Value=A198846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198846.Bytes);
public long this[int i]=>Value[i];

public static A198846Inst Instance=new A198846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198847
{
public static readonly long[] Value={ 9L,59L,359L,2159L,12959L,77759L,466559L,2799359L,16796159L,100776959L,604661759L,3627970559L,21767823359L,130606940159L,783641640959L,4701849845759L,28211099074559L,169266594447359L,1015599566684159L,6093597400104959L,36561584400629759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198847Inst : IEnumerable<long>
{
public static readonly long[] Value=A198847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198847.Bytes);
public long this[int i]=>Value[i];

public static A198847Inst Instance=new A198847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198848
{
public static readonly long[] Value={ 10L,65L,395L,2375L,14255L,85535L,513215L,3079295L,18475775L,110854655L,665127935L,3990767615L,23944605695L,143667634175L,862005805055L,5172034830335L,31032208982015L,186193253892095L,1117159523352575L,6702957140115455L,40217742840692735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198848Inst : IEnumerable<long>
{
public static readonly long[] Value=A198848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198848.Bytes);
public long this[int i]=>Value[i];

public static A198848Inst Instance=new A198848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198849
{
public static readonly long[] Value={ 2L,13L,79L,475L,2851L,17107L,102643L,615859L,3695155L,22170931L,133025587L,798153523L,4788921139L,28733526835L,172401161011L,1034406966067L,6206441796403L,37238650778419L,223431904670515L,1340591428023091L,8043548568138547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198849Inst : IEnumerable<long>
{
public static readonly long[] Value=A198849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198849.Bytes);
public long this[int i]=>Value[i];

public static A198849Inst Instance=new A198849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198850
{
public static readonly long[] Value={ 1L,15L,127L,1023L,8191L,65535L,524287L,4194303L,33554431L,268435455L,2147483647L,17179869183L,137438953471L,1099511627775L,8796093022207L,70368744177663L,562949953421311L,4503599627370495L,36028797018963967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198850Inst : IEnumerable<long>
{
public static readonly long[] Value=A198850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198850.Bytes);
public long this[int i]=>Value[i];

public static A198850Inst Instance=new A198850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198851
{
public static readonly long[] Value={ 2L,23L,191L,1535L,12287L,98303L,786431L,6291455L,50331647L,402653183L,3221225471L,25769803775L,206158430207L,1649267441663L,13194139533311L,105553116266495L,844424930131967L,6755399441055743L,54043195528445951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198851Inst : IEnumerable<long>
{
public static readonly long[] Value=A198851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198851.Bytes);
public long this[int i]=>Value[i];

public static A198851Inst Instance=new A198851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198852
{
public static readonly long[] Value={ 3L,31L,255L,2047L,16383L,131071L,1048575L,8388607L,67108863L,536870911L,4294967295L,34359738367L,274877906943L,2199023255551L,17592186044415L,140737488355327L,1125899906842623L,9007199254740991L,72057594037927935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198852Inst : IEnumerable<long>
{
public static readonly long[] Value=A198852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198852.Bytes);
public long this[int i]=>Value[i];

public static A198852Inst Instance=new A198852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198853
{
public static readonly long[] Value={ 4L,39L,319L,2559L,20479L,163839L,1310719L,10485759L,83886079L,671088639L,5368709119L,42949672959L,343597383679L,2748779069439L,21990232555519L,175921860444159L,1407374883553279L,11258999068426239L,90071992547409919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198853Inst : IEnumerable<long>
{
public static readonly long[] Value=A198853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198853.Bytes);
public long this[int i]=>Value[i];

public static A198853Inst Instance=new A198853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198854
{
public static readonly long[] Value={ 5L,47L,383L,3071L,24575L,196607L,1572863L,12582911L,100663295L,805306367L,6442450943L,51539607551L,412316860415L,3298534883327L,26388279066623L,211106232532991L,1688849860263935L,13510798882111487L,108086391056891903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198854Inst : IEnumerable<long>
{
public static readonly long[] Value=A198854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198854.Bytes);
public long this[int i]=>Value[i];

public static A198854Inst Instance=new A198854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198855
{
public static readonly long[] Value={ 6L,55L,447L,3583L,28671L,229375L,1835007L,14680063L,117440511L,939524095L,7516192767L,60129542143L,481036337151L,3848290697215L,30786325577727L,246290604621823L,1970324836974591L,15762598695796735L,126100789566373887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198855Inst : IEnumerable<long>
{
public static readonly long[] Value=A198855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198855.Bytes);
public long this[int i]=>Value[i];

public static A198855Inst Instance=new A198855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198856
{
public static readonly long[] Value={ 8L,71L,575L,4607L,36863L,294911L,2359295L,18874367L,150994943L,1207959551L,9663676415L,77309411327L,618475290623L,4947802324991L,39582418599935L,316659348799487L,2533274790395903L,20266198323167231L,162129586585337855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198856Inst : IEnumerable<long>
{
public static readonly long[] Value=A198856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198856.Bytes);
public long this[int i]=>Value[i];

public static A198856Inst Instance=new A198856Inst();

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