using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A074767
{
public static readonly long[] Value={ 4L,9L,6L,25L,9L,49L,10L,15L,25L,121L,15L,169L,49L,25L,18L,289L,21L,361L,25L,49L,121L,529L,27L,35L,169L,33L,49L,841L,35L,961L,34L,121L,289L,49L,39L,1369L,361L,169L,55L,1681L,49L,1849L,121L,55L,529L,2209L,51L,77L,55L,289L,169L,2809L,57L,121L,77L,361L,841L,3481L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074767Inst : IEnumerable<long>
{
public static readonly long[] Value=A074767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074767.Bytes);
public long this[int i]=>Value[i];

public static A074767Inst Instance=new A074767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074768
{
public static readonly BigInteger[] Value={ 0L,1L,-4L,42L,-736L,18200L,-582624L,22918672L,-1069947904L,57826348416L,-3551472064000L,244313618844416L,-18609923667234816L,1554954961060953088L,BigInteger.Parse("-141407678375562489856"),BigInteger.Parse("13904110871649987840000") };
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
public class A074768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074768Inst Instance=new A074768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074769
{
public static readonly long[] Value={ 2L,21L,16L,40L,120L,238L,96L,261L,150L,0L,288L,767L,2002L,405L,160L,170L,2016L,0L,1980L,693L,1078L,2645L,0L,625L,650L,0L,784L,0L,3540L,341L,256L,1815L,2414L,0L,720L,0L,0L,1638L,1680L,1271L,966L,8127L,2552L,0L,0L,4841L,2160L,2205L,1300L,1326L,3588L,7685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074769Inst : IEnumerable<long>
{
public static readonly long[] Value=A074769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074769.Bytes);
public long this[int i]=>Value[i];

public static A074769Inst Instance=new A074769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074770
{
public static readonly long[] Value={ 45L,117L,225L,273L,297L,345L,357L,405L,465L,513L,561L,621L,693L,705L,765L,777L,825L,837L,861L,885L,945L,1005L,1113L,1125L,1185L,1197L,1281L,1305L,1395L,1425L,1521L,1545L,1593L,1617L,1701L,1725L,1845L,1881L,1905L,1953L,1965L,2025L,2037L,2121L,2277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074770Inst : IEnumerable<long>
{
public static readonly long[] Value=A074770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074770.Bytes);
public long this[int i]=>Value[i];

public static A074770Inst Instance=new A074770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074771
{
public static readonly long[] Value={ 62L,74L,134L,146L,254L,398L,404L,458L,482L,494L,554L,566L,614L,626L,662L,674L,692L,758L,764L,794L,818L,854L,914L,998L,1034L,1094L,1124L,1214L,1238L,1286L,1322L,1394L,1454L,1514L,1538L,1646L,1658L,1682L,1826L,1844L,1874L,1934L,2078L,2114L,2174L,2234L,2246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074771Inst : IEnumerable<long>
{
public static readonly long[] Value=A074771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074771.Bytes);
public long this[int i]=>Value[i];

public static A074771Inst Instance=new A074771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074804
{
public static readonly long[] Value={ 3L,3L,3L,2L,2L,2L,3L,3L,3L,2L,2L,3L,3L,2L,2L,3L,3L,3L,2L,2L,2L,3L,3L,3L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,2L,2L,3L,3L,2L,2L,3L,3L,3L,2L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,2L,2L,3L,3L,2L,2L,3L,3L,3L,2L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074804Inst : IEnumerable<long>
{
public static readonly long[] Value=A074804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074804.Bytes);
public long this[int i]=>Value[i];

public static A074804Inst Instance=new A074804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074805
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,1L,2L,3L,4L,5L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074805Inst : IEnumerable<long>
{
public static readonly long[] Value=A074805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074805.Bytes);
public long this[int i]=>Value[i];

public static A074805Inst Instance=new A074805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074806
{
public static readonly long[] Value={ 1L,3L,9L,7L,8L,13L,17L,16L,23L,12L,28L,37L,19L,43L,15L,53L,56L,29L,67L,68L,73L,76L,83L,21L,97L,48L,103L,35L,53L,37L,127L,128L,137L,44L,73L,48L,157L,163L,167L,173L,176L,88L,188L,193L,197L,20L,40L,223L,227L,112L,25L,236L,119L,248L,257L,87L,133L,268L,277L,27L,283L,293L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074806Inst : IEnumerable<long>
{
public static readonly long[] Value=A074806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074806.Bytes);
public long this[int i]=>Value[i];

public static A074806Inst Instance=new A074806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074807
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,2L,4L,5L,4L,2L,4L,3L,5L,5L,3L,5L,3L,2L,1L,3L,2L,3L,4L,3L,4L,3L,1L,3L,1L,2L,1L,4L,6L,3L,3L,5L,1L,2L,6L,6L,5L,1L,5L,2L,4L,4L,2L,1L,1L,8L,4L,2L,2L,3L,3L,3L,1L,6L,2L,4L,1L,1L,5L,3L,2L,3L,6L,1L,2L,2L,5L,2L,4L,2L,5L,5L,2L,5L,13L,5L,1L,2L,2L,2L,7L,4L,1L,5L,1L,2L,3L,4L,4L,4L,7L,3L,1L,2L,2L,2L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074807Inst : IEnumerable<long>
{
public static readonly long[] Value=A074807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074807.Bytes);
public long this[int i]=>Value[i];

public static A074807Inst Instance=new A074807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074808
{
public static readonly long[] Value={ 2L,1L,13L,8L,9L,34L,86L,51L,113L,348L,193L,152L,80L,199L,736L,579L,448L,502L,446L,281L,339L,532L,1521L,760L,438L,371L,971L,524L,1642L,988L,1613L,6856L,4494L,5146L,2793L,1348L,3916L,5531L,6544L,3570L,7982L,6415L,3211L,1633L,11634L,9462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074808Inst : IEnumerable<long>
{
public static readonly long[] Value=A074808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074808.Bytes);
public long this[int i]=>Value[i];

public static A074808Inst Instance=new A074808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074809
{
public static readonly BigInteger[] Value={ 2L,23L,47L,2357L,223L,35339L,214282847L,7717859L,806801L,185176472401L,357211L,4967701595369L,104364752351L,27558919L,5269410931806332951L,274784055330749L,1191126125288819L,178258515898000387L,BigInteger.Parse("2313161253378144566969023310693"),BigInteger.Parse("8730041915527145606449758346652473"),BigInteger.Parse("26293517701186435480644832888393"),BigInteger.Parse("29890227360205834316383307128051"),3858432486690092813L,BigInteger.Parse("7122852423207105431971"),BigInteger.Parse("93753283248830261744671") };
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
public class A074809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074809Inst Instance=new A074809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074810
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,28L,65L,114L,174L,186L,246L,623L,1784L,1832L,1912L,5121L,13810L,14090L,39413L,40403L,808822L,809858L,810026L,2201505L,2202735L,6047408L,6048656L,16463939L,16467271L,16472371L,121482371L,121495747L,330358060L,898100679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074810Inst : IEnumerable<long>
{
public static readonly long[] Value=A074810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074810.Bytes);
public long this[int i]=>Value[i];

public static A074810Inst Instance=new A074810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074811
{
public static readonly long[] Value={ 1L,1L,1L,181L,1L,1061L,1L,1061L,181L,1061L,1L,40123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074811Inst : IEnumerable<long>
{
public static readonly long[] Value=A074811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074811.Bytes);
public long this[int i]=>Value[i];

public static A074811Inst Instance=new A074811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074812
{
public static readonly long[] Value={ 1L,21609L,22801L,299209L,5446183447063166809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074812Inst : IEnumerable<long>
{
public static readonly long[] Value=A074812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074812.Bytes);
public long this[int i]=>Value[i];

public static A074812Inst Instance=new A074812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074813
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,4L,1L,3L,6L,7L,9L,12L,14L,15L,17L,8L,3L,0L,3L,4L,6L,9L,11L,13L,15L,9L,6L,3L,0L,3L,5L,7L,10L,11L,12L,10L,7L,4L,3L,0L,2L,4L,7L,8L,9L,13L,9L,6L,5L,2L,0L,2L,5L,7L,8L,14L,12L,9L,7L,4L,2L,0L,3L,4L,5L,16L,14L,11L,10L,7L,5L,3L,0L,2L,4L,18L,15L,13L,11L,8L,7L,4L,2L,0L,2L,20L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074813Inst : IEnumerable<long>
{
public static readonly long[] Value=A074813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074813.Bytes);
public long this[int i]=>Value[i];

public static A074813Inst Instance=new A074813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074814
{
public static readonly long[] Value={ 10L,25L,37L,40L,81L,102L,120L,204L,295L,340L,350L,387L,397L,1620L,1743L,2995L,3627L,3997L,4450L,4629L,4999L,8090L,8490L,9201L,9301L,10002L,12310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074814Inst : IEnumerable<long>
{
public static readonly long[] Value=A074814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074814.Bytes);
public long this[int i]=>Value[i];

public static A074814Inst Instance=new A074814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074815
{
public static readonly long[] Value={ 0L,14L,247L,298L,1003L,2998L,10003L,12473L,17525L,19995L,27528L,29998L,199995L,299998L,1000003L,1824745L,1875265L,1999995L,2124736L,2475247L,2700018L,3124739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074815Inst : IEnumerable<long>
{
public static readonly long[] Value=A074815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074815.Bytes);
public long this[int i]=>Value[i];

public static A074815Inst Instance=new A074815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074816
{
public static readonly long[] Value={ 1L,3L,3L,3L,3L,9L,3L,3L,3L,9L,3L,9L,3L,9L,9L,3L,3L,9L,3L,9L,9L,9L,3L,9L,3L,9L,3L,9L,3L,27L,3L,3L,9L,9L,9L,9L,3L,9L,9L,9L,3L,27L,3L,9L,9L,9L,3L,9L,3L,9L,9L,9L,3L,9L,9L,9L,9L,9L,3L,27L,3L,9L,9L,3L,9L,27L,3L,9L,9L,27L,3L,9L,3L,9L,9L,9L,9L,27L,3L,9L,3L,9L,3L,27L,9L,9L,9L,9L,3L,27L,9L,9L,9L,9L,9L,9L,3L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074816Inst : IEnumerable<long>
{
public static readonly long[] Value=A074816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074816.Bytes);
public long this[int i]=>Value[i];

public static A074816Inst Instance=new A074816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074817
{
public static readonly long[] Value={ 90L,102L,255L,306L,347L,357L,460L,850L,2274L,3430L,3620L,3908L,4038L,4140L,4309L,5050L,5650L,6040L,6840L,27320L,31336L,33076L,40130L,48140L,50130L,59340L,63340L,65440L,69250L,90270L,94660L,182010L,185773L,247105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074817Inst : IEnumerable<long>
{
public static readonly long[] Value=A074817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074817.Bytes);
public long this[int i]=>Value[i];

public static A074817Inst Instance=new A074817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074818
{
public static readonly long[] Value={ 2L,2L,4L,4L,9L,5L,15L,10L,16L,12L,29L,13L,38L,19L,26L,27L,56L,21L,64L,29L,42L,36L,80L,30L,78L,47L,69L,46L,106L,31L,123L,66L,84L,66L,103L,51L,153L,78L,104L,70L,175L,52L,187L,88L,106L,96L,207L,75L,195L,92L,147L,111L,237L,84L,187L,113L,170L,131L,273L,75L,279L,142L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074818Inst : IEnumerable<long>
{
public static readonly long[] Value=A074818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074818.Bytes);
public long this[int i]=>Value[i];

public static A074818Inst Instance=new A074818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074819
{
public static readonly long[] Value={ 1L,5L,6L,8L,10L,13L,22L,24L,27L,37L,44L,46L,48L,49L,58L,61L,63L,65L,69L,73L,75L,77L,80L,82L,98L,99L,105L,106L,110L,114L,116L,120L,124L,125L,129L,135L,147L,152L,154L,157L,165L,166L,168L,171L,175L,178L,182L,185L,186L,188L,193L,194L,207L,210L,221L,224L,226L,237L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074819Inst : IEnumerable<long>
{
public static readonly long[] Value=A074819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074819.Bytes);
public long this[int i]=>Value[i];

public static A074819Inst Instance=new A074819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074820
{
public static readonly long[] Value={ 3L,5L,11L,16L,17L,18L,25L,29L,33L,41L,48L,50L,52L,54L,55L,59L,71L,85L,88L,90L,91L,93L,96L,98L,101L,103L,105L,107L,124L,126L,137L,141L,143L,148L,149L,150L,159L,160L,162L,163L,165L,169L,179L,183L,185L,191L,193L,195L,196L,197L,198L,201L,203L,213L,215L,217L,219L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074820Inst : IEnumerable<long>
{
public static readonly long[] Value=A074820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074820.Bytes);
public long this[int i]=>Value[i];

public static A074820Inst Instance=new A074820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074821
{
public static readonly long[] Value={ 2L,3L,4L,5L,10L,11L,23L,27L,29L,34L,38L,41L,46L,53L,55L,57L,62L,76L,77L,83L,89L,91L,93L,106L,113L,118L,123L,129L,131L,133L,136L,143L,145L,159L,161L,173L,177L,179L,185L,191L,201L,203L,205L,206L,212L,213L,218L,226L,232L,233L,235L,239L,251L,259L,267L,281L,291L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074821Inst : IEnumerable<long>
{
public static readonly long[] Value=A074821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074821.Bytes);
public long this[int i]=>Value[i];

public static A074821Inst Instance=new A074821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074822
{
public static readonly long[] Value={ 19L,79L,109L,229L,349L,379L,439L,499L,739L,769L,859L,1009L,1279L,1429L,1489L,1549L,1579L,1609L,1999L,2239L,2269L,2389L,2539L,2659L,2689L,2749L,3019L,3079L,3319L,3529L,3919L,4129L,4519L,4639L,4729L,4789L,4969L,4999L,5479L,5569L,5689L,5779L,5839L,6199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074822Inst : IEnumerable<long>
{
public static readonly long[] Value=A074822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074822.Bytes);
public long this[int i]=>Value[i];

public static A074822Inst Instance=new A074822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074823
{
public static readonly long[] Value={ 1L,2L,2L,0L,2L,4L,2L,0L,0L,4L,2L,0L,2L,4L,4L,0L,2L,0L,2L,0L,4L,4L,2L,0L,0L,4L,0L,0L,2L,8L,2L,0L,4L,4L,4L,0L,2L,4L,4L,0L,2L,8L,2L,0L,0L,4L,2L,0L,0L,0L,4L,0L,2L,0L,4L,0L,4L,4L,2L,0L,2L,4L,0L,0L,4L,8L,2L,0L,4L,8L,2L,0L,2L,4L,0L,0L,4L,8L,2L,0L,0L,4L,2L,0L,4L,4L,4L,0L,2L,0L,4L,0L,4L,4L,4L,0L,2L,0L,0L,0L,2L,8L,2L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074823Inst : IEnumerable<long>
{
public static readonly long[] Value=A074823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074823.Bytes);
public long this[int i]=>Value[i];

public static A074823Inst Instance=new A074823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074824
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,11L,16L,19L,44L,88L,224L,349L,520L,1187L,2044L,2636L,2645L,3994L,6851L,12016L,16304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074824Inst : IEnumerable<long>
{
public static readonly long[] Value=A074824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074824.Bytes);
public long this[int i]=>Value[i];

public static A074824Inst Instance=new A074824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074825
{
public static readonly long[] Value={ 5L,4L,2L,-2L,-10L,-16L,-4L,46L,142L,250L,262L,4L,-652L,-1530L,-1818L,38L,5662L,14760L,22028L,15014L,-22490L,-95846L,-172434L,-154740L,110500L,733134L,1556206L,1875238L,365334L,-4306496L,-11734244L,-17112802L,-9496002L,25050298L,90586134L,157886356L,142006676L,-87803882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074825Inst : IEnumerable<long>
{
public static readonly long[] Value=A074825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074825.Bytes);
public long this[int i]=>Value[i];

public static A074825Inst Instance=new A074825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074826
{
public static readonly long[] Value={ 5L,6L,6L,6L,6L,-4L,-60L,-246L,-722L,-1758L,-3754L,-7144L,-11868L,-15646L,-9458L,32726L,174750L,555668L,1446564L,3310642L,6788406L,12366066L,19107358L,21047904L,-1585148L,-101419654L,-400928730L,-1155269658L,-2838111242L,-6203242964L,-12144929980L,-20857830310L,-29087301442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074826Inst : IEnumerable<long>
{
public static readonly long[] Value=A074826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074826.Bytes);
public long this[int i]=>Value[i];

public static A074826Inst Instance=new A074826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074827
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,16L,18L,20L,22L,24L,28L,30L,32L,36L,40L,42L,45L,46L,48L,50L,52L,54L,56L,58L,60L,64L,66L,68L,70L,72L,76L,78L,80L,81L,82L,84L,88L,90L,92L,96L,100L,102L,105L,106L,108L,110L,112L,114L,117L,120L,124L,126L,128L,130L,132L,136L,138L,140L,144L,148L,150L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074827Inst : IEnumerable<long>
{
public static readonly long[] Value=A074827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074827.Bytes);
public long this[int i]=>Value[i];

public static A074827Inst Instance=new A074827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074828
{
public static readonly long[] Value={ 1L,4L,6L,2L,10L,2L,14L,2L,3L,2L,22L,2L,26L,2L,3L,2L,34L,2L,38L,2L,3L,2L,46L,2L,5L,2L,3L,2L,58L,2L,62L,2L,3L,2L,5L,2L,74L,2L,3L,2L,82L,2L,86L,2L,3L,2L,94L,2L,7L,2L,3L,2L,106L,2L,5L,2L,3L,2L,118L,2L,122L,2L,3L,2L,5L,2L,134L,2L,3L,2L,142L,2L,146L,2L,3L,2L,7L,2L,158L,2L,3L,2L,166L,2L,5L,2L,3L,2L,178L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074828Inst : IEnumerable<long>
{
public static readonly long[] Value=A074828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074828.Bytes);
public long this[int i]=>Value[i];

public static A074828Inst Instance=new A074828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074829
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,4L,4L,3L,5L,7L,8L,7L,5L,8L,12L,15L,15L,12L,8L,13L,20L,27L,30L,27L,20L,13L,21L,33L,47L,57L,57L,47L,33L,21L,34L,54L,80L,104L,114L,104L,80L,54L,34L,55L,88L,134L,184L,218L,218L,184L,134L,88L,55L,89L,143L,222L,318L,402L,436L,402L,318L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074829Inst : IEnumerable<long>
{
public static readonly long[] Value=A074829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074829.Bytes);
public long this[int i]=>Value[i];

public static A074829Inst Instance=new A074829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074830
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,2L,5L,2L,1L,3L,7L,3L,10L,4L,3L,3L,12L,4L,9L,5L,4L,7L,14L,4L,11L,5L,5L,7L,15L,3L,20L,9L,6L,6L,12L,3L,19L,11L,9L,6L,23L,4L,26L,8L,6L,10L,24L,7L,17L,11L,7L,15L,33L,4L,19L,9L,12L,12L,22L,5L,30L,16L,11L,13L,15L,4L,38L,15L,14L,8L,36L,5L,40L,17L,7L,13L,32L,4L,39L,13L,6L,13L,38L,4L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074830Inst : IEnumerable<long>
{
public static readonly long[] Value=A074830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074830.Bytes);
public long this[int i]=>Value[i];

public static A074830Inst Instance=new A074830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074831
{
public static readonly long[] Value={ 3L,20L,101L,508L,3053L,20053L,141772L,1045600L,8038954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074831Inst : IEnumerable<long>
{
public static readonly long[] Value=A074831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074831.Bytes);
public long this[int i]=>Value[i];

public static A074831Inst Instance=new A074831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074832
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,23L,29L,31L,37L,41L,43L,47L,53L,61L,67L,71L,73L,83L,97L,101L,107L,113L,127L,131L,151L,163L,167L,173L,181L,193L,197L,199L,223L,227L,229L,233L,251L,257L,263L,269L,277L,283L,307L,313L,331L,337L,349L,353L,359L,373L,383L,409L,421L,431L,433L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074832Inst : IEnumerable<long>
{
public static readonly long[] Value=A074832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074832.Bytes);
public long this[int i]=>Value[i];

public static A074832Inst Instance=new A074832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074833
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,19L,23L,31L,37L,41L,47L,53L,61L,67L,79L,83L,101L,103L,113L,127L,131L,151L,163L,167L,173L,179L,181L,191L,193L,211L,227L,233L,263L,281L,293L,311L,331L,349L,353L,359L,401L,409L,419L,421L,431L,439L,449L,463L,467L,491L,499L,503L,521L,523L,541L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074833Inst : IEnumerable<long>
{
public static readonly long[] Value=A074833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074833.Bytes);
public long this[int i]=>Value[i];

public static A074833Inst Instance=new A074833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074834
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,23L,29L,31L,53L,59L,61L,67L,73L,79L,83L,89L,97L,101L,107L,193L,197L,199L,211L,233L,239L,241L,251L,257L,269L,277L,281L,293L,311L,313L,337L,353L,367L,373L,383L,397L,401L,409L,419L,433L,443L,449L,457L,461L,467L,487L,491L,499L,509L,787L,797L,809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074834Inst : IEnumerable<long>
{
public static readonly long[] Value=A074834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074834.Bytes);
public long this[int i]=>Value[i];

public static A074834Inst Instance=new A074834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074835
{
public static readonly long[] Value={ 4L,59L,6186L,12846L,18003L,19677L,52364L,293565L,984636L,1894557L,1965537L,9946704L,31849014L,138419397L,250780145L,1650149334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074835Inst : IEnumerable<long>
{
public static readonly long[] Value=A074835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074835.Bytes);
public long this[int i]=>Value[i];

public static A074835Inst Instance=new A074835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074836
{
public static readonly BigInteger[] Value={ 53L,353L,2160617L,479L,146053847L,18533465459L,18588601L,444444443L,10987654321234567891UL,BigInteger.Parse("41824630287288128897"),BigInteger.Parse("24899126702236725259"),BigInteger.Parse("131211109876543212345678910111213"),59722151033999393L,BigInteger.Parse("1081735780698166140181"),BigInteger.Parse("40378532802777469135803086419727527803285379") };
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
public class A074836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074836Inst Instance=new A074836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074837
{
public static readonly long[] Value={ 6L,18L,42L,54L,66L,78L,102L,114L,126L,138L,162L,174L,186L,198L,222L,234L,246L,258L,282L,294L,306L,318L,342L,354L,366L,378L,402L,414L,426L,438L,462L,474L,486L,498L,522L,534L,546L,558L,582L,594L,606L,618L,642L,654L,666L,678L,702L,714L,726L,738L,762L,774L,786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074837Inst : IEnumerable<long>
{
public static readonly long[] Value=A074837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074837.Bytes);
public long this[int i]=>Value[i];

public static A074837Inst Instance=new A074837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074838
{
public static readonly long[] Value={ 1L,6L,8L,16L,20L,24L,54L,60L,72L,96L,126L,128L,180L,216L,243L,256L,384L,441L,486L,500L,504L,540L,648L,704L,729L,864L,891L,972L,1100L,1152L,1260L,1500L,1536L,1620L,1782L,1792L,1944L,2016L,2048L,2112L,2205L,2560L,3300L,3456L,3528L,3564L,3645L,3888L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074838Inst : IEnumerable<long>
{
public static readonly long[] Value=A074838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074838.Bytes);
public long this[int i]=>Value[i];

public static A074838Inst Instance=new A074838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074839
{
public static readonly long[] Value={ 1L,3L,8L,19L,42L,85L,174L,353L,712L,1431L,2864L,5743L,11492L,22989L,45982L,91971L,183968L,367939L,735888L,1471789L,2943596L,5887195L,11774408L,23548837L,47097690L,94195387L,188390808L,376781617L,753563240L,1507126509L,3014253028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074839Inst : IEnumerable<long>
{
public static readonly long[] Value=A074839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074839.Bytes);
public long this[int i]=>Value[i];

public static A074839Inst Instance=new A074839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074840
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,4L,5L,5L,6L,7L,7L,8L,8L,9L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,15L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,26L,27L,28L,28L,29L,29L,30L,31L,31L,32L,32L,33L,33L,34L,35L,35L,36L,36L,37L,38L,38L,39L,39L,40L,41L,41L,42L,42L,43L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074840Inst : IEnumerable<long>
{
public static readonly long[] Value=A074840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074840.Bytes);
public long this[int i]=>Value[i];

public static A074840Inst Instance=new A074840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074841
{
public static readonly long[] Value={ 8L,77L,5711L,9797L,77327L,997997L,8053139L,60755907L,62996069L,99979997L,9999799997L,71515443427L,76933604839L,93445113269L,999997999997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074841Inst : IEnumerable<long>
{
public static readonly long[] Value=A074841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074841.Bytes);
public long this[int i]=>Value[i];

public static A074841Inst Instance=new A074841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074842
{
public static readonly long[] Value={ 111L,222L,333L,444L,555L,666L,777L,888L,999L,101010L,111111L,121212L,131313L,141414L,151515L,161616L,171717L,181818L,191919L,202020L,212121L,222222L,232323L,242424L,252525L,262626L,272727L,282828L,292929L,303030L,313131L,323232L,333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074842Inst : IEnumerable<long>
{
public static readonly long[] Value=A074842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074842.Bytes);
public long this[int i]=>Value[i];

public static A074842Inst Instance=new A074842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074843
{
public static readonly long[] Value={ 1111L,2222L,3333L,4444L,5555L,6666L,7777L,8888L,9999L,10101010L,11111111L,12121212L,13131313L,14141414L,15151515L,16161616L,17171717L,18181818L,19191919L,20202020L,21212121L,22222222L,23232323L,24242424L,25252525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074843Inst : IEnumerable<long>
{
public static readonly long[] Value=A074843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074843.Bytes);
public long this[int i]=>Value[i];

public static A074843Inst Instance=new A074843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074844
{
public static readonly long[] Value={ 4L,345L,6489L,88473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074844Inst : IEnumerable<long>
{
public static readonly long[] Value=A074844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074844.Bytes);
public long this[int i]=>Value[i];

public static A074844Inst Instance=new A074844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074845
{
public static readonly long[] Value={ 6L,8L,9L,10L,14L,22L,26L,34L,38L,46L,58L,62L,74L,82L,86L,94L,106L,118L,122L,134L,142L,146L,158L,166L,178L,194L,202L,206L,214L,218L,226L,254L,262L,274L,278L,298L,302L,314L,326L,334L,346L,358L,362L,382L,386L,394L,398L,422L,446L,454L,458L,466L,478L,482L,502L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074845Inst : IEnumerable<long>
{
public static readonly long[] Value=A074845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074845.Bytes);
public long this[int i]=>Value[i];

public static A074845Inst Instance=new A074845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074846
{
public static readonly long[] Value={ 2L,3L,4L,7L,6L,7L,10L,9L,12L,13L,18L,13L,24L,15L,16L,21L,18L,21L,22L,2L,22L,28L,26L,25L,28L,33L,28L,34L,32L,33L,36L,36L,34L,37L,42L,43L,40L,39L,48L,43L,42L,46L,46L,47L,48L,51L,50L,54L,52L,51L,56L,55L,56L,55L,58L,60L,58L,61L,60L,67L,66L,63L,66L,67L,68L,67L,70L,75L,70L,79L,72L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074846Inst : IEnumerable<long>
{
public static readonly long[] Value=A074846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074846.Bytes);
public long this[int i]=>Value[i];

public static A074846Inst Instance=new A074846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074847
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,12L,8L,15L,13L,18L,12L,28L,14L,24L,24L,17L,18L,39L,20L,42L,32L,36L,24L,60L,31L,42L,40L,56L,30L,72L,32L,51L,48L,54L,48L,91L,38L,60L,56L,90L,42L,96L,44L,84L,78L,72L,48L,68L,57L,93L,72L,98L,54L,120L,72L,120L,80L,90L,60L,168L,62L,96L,104L,119L,84L,144L,68L,126L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074847Inst : IEnumerable<long>
{
public static readonly long[] Value=A074847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074847.Bytes);
public long this[int i]=>Value[i];

public static A074847Inst Instance=new A074847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074848
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,2L,6L,2L,4L,4L,2L,2L,6L,2L,6L,4L,4L,2L,8L,3L,4L,4L,6L,2L,8L,2L,4L,4L,4L,4L,9L,2L,4L,4L,8L,2L,8L,2L,6L,6L,4L,2L,4L,3L,6L,4L,6L,2L,8L,4L,8L,4L,4L,2L,12L,2L,4L,6L,6L,4L,8L,2L,6L,4L,8L,2L,12L,2L,4L,6L,6L,4L,8L,2L,4L,2L,4L,2L,12L,4L,4L,4L,8L,2L,12L,4L,6L,4L,4L,4L,8L,2L,6L,6L,9L,2L,8L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074848Inst : IEnumerable<long>
{
public static readonly long[] Value=A074848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074848.Bytes);
public long this[int i]=>Value[i];

public static A074848Inst Instance=new A074848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074849
{
public static readonly long[] Value={ 6L,28L,36720L,222768L,12646368L,5154170112L,34725010231296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074849Inst : IEnumerable<long>
{
public static readonly long[] Value=A074849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074849.Bytes);
public long this[int i]=>Value[i];

public static A074849Inst Instance=new A074849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074850
{
public static readonly long[] Value={ 3L,3L,12L,12L,60L,540L,1080L,6480L,32400L,97200L,486000L,3888000L,34992000L,244944000L,2204496000L,6613488000L,13226976000L,39680928000L,317447424000L,1269789696000L,7618738176000L,15237476352000L,91424858112000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074850Inst : IEnumerable<long>
{
public static readonly long[] Value=A074850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074850.Bytes);
public long this[int i]=>Value[i];

public static A074850Inst Instance=new A074850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074851
{
public static readonly long[] Value={ 14L,20L,21L,33L,34L,35L,38L,39L,44L,45L,50L,51L,54L,55L,56L,57L,62L,68L,74L,75L,76L,85L,86L,87L,91L,92L,93L,94L,95L,98L,99L,111L,115L,116L,117L,118L,122L,123L,133L,134L,135L,141L,142L,143L,144L,145L,146L,147L,152L,158L,159L,160L,161L,171L,175L,176L,177L,183L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074851Inst : IEnumerable<long>
{
public static readonly long[] Value=A074851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074851.Bytes);
public long this[int i]=>Value[i];

public static A074851Inst Instance=new A074851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074852
{
public static readonly long[] Value={ 9L,25L,27L,81L,125L,6561L,24389L,59049L,161051L,357911L,571787L,1442897L,4782969L,5177717L,14348907L,18191447L,30080231L,73560059L,80062991L,118370771L,127263527L,131872229L,318611987L,344472101L,440711081L,461889917L,590589719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074852Inst : IEnumerable<long>
{
public static readonly long[] Value=A074852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074852.Bytes);
public long this[int i]=>Value[i];

public static A074852Inst Instance=new A074852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074853
{
public static readonly long[] Value={ 900L,1764L,4356L,4900L,6084L,7560L,10404L,11025L,11880L,12100L,12996L,13440L,14040L,16632L,16900L,18360L,19044L,19656L,20520L,21000L,21120L,23716L,24840L,24960L,25704L,27225L,28728L,28900L,29568L,30276L,30888L,31320L,32640L,33000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074853Inst : IEnumerable<long>
{
public static readonly long[] Value=A074853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074853.Bytes);
public long this[int i]=>Value[i];

public static A074853Inst Instance=new A074853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074854
{
public static readonly long[] Value={ 1L,3L,5L,13L,17L,57L,65L,209L,321L,801L,1025L,3905L,4097L,9407L,21505L,53505L,65537L,233985L,262145L,885761L,1327105L,3147777L,4194305L,16060417L,17825793L,50339841L,84148225L,220217345L,268435457L,990937089L,1073741825L,3506503681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074854Inst : IEnumerable<long>
{
public static readonly long[] Value=A074854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074854.Bytes);
public long this[int i]=>Value[i];

public static A074854Inst Instance=new A074854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074855
{
public static readonly long[] Value={ 2L,3L,7L,19L,29L,37L,61L,211L,521L,613L,1579L,2131L,2467L,2551L,3331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074855Inst : IEnumerable<long>
{
public static readonly long[] Value=A074855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074855.Bytes);
public long this[int i]=>Value[i];

public static A074855Inst Instance=new A074855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074856
{
public static readonly long[] Value={ 2L,5L,13L,17L,31L,37L,61L,79L,89L,97L,109L,127L,139L,193L,229L,277L,307L,311L,313L,349L,373L,379L,401L,409L,439L,457L,499L,541L,569L,571L,577L,653L,661L,691L,701L,709L,751L,811L,823L,829L,877L,991L,1021L,1069L,1087L,1201L,1291L,1381L,1429L,1483L,1549L,1597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074856Inst : IEnumerable<long>
{
public static readonly long[] Value=A074856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074856.Bytes);
public long this[int i]=>Value[i];

public static A074856Inst Instance=new A074856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074857
{
public static readonly long[] Value={ 2L,17L,19L,23L,31L,37L,43L,53L,59L,137L,139L,151L,157L,179L,181L,191L,197L,199L,211L,307L,317L,337L,347L,367L,397L,599L,1423L,1433L,1453L,1483L,1493L,1523L,1543L,1583L,1613L,1693L,1723L,1733L,1753L,1759L,1777L,1783L,1787L,1789L,1801L,1811L,1823L,1831L,1847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074857Inst : IEnumerable<long>
{
public static readonly long[] Value=A074857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074857.Bytes);
public long this[int i]=>Value[i];

public static A074857Inst Instance=new A074857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074858
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,17L,31L,57L,159L,229L,463L,1643L,3028L,5035L,11524L,24762L,41591L,108864L,177197L,305575L,951573L,2048919L,3575995L,6000073L,18774470L,30770296L,53244772L,91462849L,213915324L,333122408L,641864151L,1398505871L,2844591355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074858Inst : IEnumerable<long>
{
public static readonly long[] Value=A074858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074858.Bytes);
public long this[int i]=>Value[i];

public static A074858Inst Instance=new A074858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074859
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,6L,20L,240L,420L,2688L,18144L,120960L,2661120L,7983360L,103783680L,1037836800L,12454041600L,149448499200L,1693749657600L,60974987673600L,289631191449600L,5792623828992000L,121645100408832000L,3568256278659072000L,BigInteger.Parse("30776210403434496000"),BigInteger.Parse("738629049682427904000"),BigInteger.Parse("12310484161373798400000") };
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
public class A074859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074859Inst Instance=new A074859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074860
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,17L,31L,111L,195L,319L,1021L,2525L,4639L,11092L,25708L,64083L,173846L,292644L,979061L,2073724L,2680995L,7115676L,17380240L,30136219L,41109707L,136581181L,298634398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074860Inst : IEnumerable<long>
{
public static readonly long[] Value=A074860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074860.Bytes);
public long this[int i]=>Value[i];

public static A074860Inst Instance=new A074860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074861
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,17L,85L,138L,960L,958L,1759L,10499L,109831L,247873L,617044L,958359L,1773317L,8528346L,14525888L,102424570L,170715000L,164793813L,394338733L,656748025L,1177078610L,1027388860L,1378392568L,9510483643L,12805616091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074861Inst : IEnumerable<long>
{
public static readonly long[] Value=A074861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074861.Bytes);
public long this[int i]=>Value[i];

public static A074861Inst Instance=new A074861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074862
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,7L,13L,43L,76L,139L,1063L,4633L,7963L,11593L,50173L,83677L,157951L,314005L,774907L,1447279L,11097082L,39016342L,62877022L,84245371L,91872178L,150920986L,815588944L,1243396636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074862Inst : IEnumerable<long>
{
public static readonly long[] Value=A074862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074862.Bytes);
public long this[int i]=>Value[i];

public static A074862Inst Instance=new A074862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074863
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,7L,13L,25L,49L,94L,199L,394L,781L,1423L,3589L,6286L,11485L,24601L,52225L,95137L,230374L,388378L,766114L,1458025L,3085549L,6183571L,11138812L,25616473L,52394659L,90903760L,190798003L,371558074L,748909162L,1317996148L,2739360475L,5277120958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074863Inst : IEnumerable<long>
{
public static readonly long[] Value=A074863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074863.Bytes);
public long this[int i]=>Value[i];

public static A074863Inst Instance=new A074863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074864
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,7L,13L,25L,49L,112L,244L,502L,1051L,2206L,3904L,7816L,19243L,37174L,66697L,144349L,292510L,563698L,1879315L,3401746L,6192718L,15630610L,33434152L,63708721L,106919440L,197375245L,342218854L,597294436L,1527006682L,3125687152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074864Inst : IEnumerable<long>
{
public static readonly long[] Value=A074864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074864.Bytes);
public long this[int i]=>Value[i];

public static A074864Inst Instance=new A074864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074865
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,7L,13L,25L,67L,157L,316L,1195L,2635L,9910L,21796L,33268L,108541L,264685L,566431L,1384927L,2251855L,10267813L,23278831L,68031385L,119376340L,223452859L,339327088L,1399568407L,3282220573L,12169858759L,23849465446L,130434244321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074865Inst : IEnumerable<long>
{
public static readonly long[] Value=A074865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074865.Bytes);
public long this[int i]=>Value[i];

public static A074865Inst Instance=new A074865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074866
{
public static readonly long[] Value={ 46L,134L,138L,161L,184L,230L,299L,322L,402L,414L,483L,552L,598L,623L,644L,670L,690L,805L,874L,897L,966L,1173L,1196L,1208L,1242L,1246L,1288L,1495L,1608L,1610L,1702L,1794L,1869L,1909L,1932L,1990L,1992L,2010L,2024L,2070L,2185L,2202L,2346L,2415L,2576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074866Inst : IEnumerable<long>
{
public static readonly long[] Value=A074866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074866.Bytes);
public long this[int i]=>Value[i];

public static A074866Inst Instance=new A074866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074867
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,13L,11L,4L,5L,9L,14L,13L,7L,10L,7L,7L,14L,11L,5L,6L,11L,7L,8L,15L,13L,8L,11L,9L,10L,9L,9L,18L,17L,15L,12L,7L,9L,16L,15L,11L,6L,7L,13L,10L,3L,3L,6L,9L,15L,14L,9L,13L,12L,5L,7L,12L,9L,11L,10L,1L,1L,2L,3L,5L,8L,13L,11L,4L,5L,9L,14L,13L,7L,10L,7L,7L,14L,11L,5L,6L,11L,7L,8L,15L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074867Inst : IEnumerable<long>
{
public static readonly long[] Value=A074867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074867.Bytes);
public long this[int i]=>Value[i];

public static A074867Inst Instance=new A074867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074948
{
public static readonly long[] Value={ 2L,9L,3L,7L,5L,7L,2L,1L,6L,9L,3L,2L,7L,9L,3L,0L,6L,4L,3L,2L,4L,6L,2L,5L,2L,9L,0L,9L,9L,2L,2L,2L,4L,1L,0L,0L,7L,4L,1L,8L,0L,4L,1L,7L,2L,6L,0L,9L,6L,5L,7L,0L,8L,7L,9L,7L,8L,2L,3L,2L,1L,8L,1L,3L,9L,8L,6L,1L,0L,5L,3L,8L,1L,3L,7L,5L,3L,6L,0L,7L,3L,5L,0L,2L,7L,4L,0L,1L,8L,9L,5L,4L,5L,3L,4L,4L,1L,4L,3L,1L,6L,1L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074948Inst : IEnumerable<long>
{
public static readonly long[] Value=A074948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074948.Bytes);
public long this[int i]=>Value[i];

public static A074948Inst Instance=new A074948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074949
{
public static readonly long[] Value={ 1L,1L,6L,6L,60L,60L,140L,420L,2520L,2520L,27720L,27720L,360360L,360360L,72072L,360360L,12252240L,12252240L,77597520L,46558512L,25865840L,33256080L,118982864L,5354228880L,8923714800L,3824449200L,80313433200L,80313433200L,2329089562800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074949Inst : IEnumerable<long>
{
public static readonly long[] Value=A074949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074949.Bytes);
public long this[int i]=>Value[i];

public static A074949Inst Instance=new A074949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074950
{
public static readonly long[] Value={ 2L,9L,1L,4L,6L,4L,7L,4L,8L,9L,0L,6L,6L,2L,6L,6L,1L,8L,0L,1L,0L,7L,1L,0L,9L,6L,3L,1L,0L,7L,5L,6L,0L,5L,9L,3L,7L,5L,0L,4L,3L,6L,7L,9L,4L,0L,9L,5L,8L,3L,3L,2L,1L,9L,7L,4L,6L,7L,1L,6L,5L,7L,6L,1L,0L,5L,2L,6L,7L,4L,9L,0L,0L,8L,2L,8L,2L,3L,2L,8L,0L,1L,0L,4L,3L,5L,0L,3L,3L,9L,0L,8L,5L,5L,8L,0L,9L,8L,8L,6L,5L,4L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074950Inst : IEnumerable<long>
{
public static readonly long[] Value=A074950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074950.Bytes);
public long this[int i]=>Value[i];

public static A074950Inst Instance=new A074950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074951
{
public static readonly long[] Value={ 2L,1L,10L,1L,2L,1L,1L,10L,1L,1L,2L,1L,11L,1L,5L,1L,1L,7L,58L,3L,1L,2L,2L,7L,13L,3L,1L,20L,1L,20L,1L,2L,8L,2L,1L,1L,2L,1L,1L,14L,3L,4L,1L,1L,1L,1L,8L,1L,6L,4L,1L,3L,1L,2L,2L,1L,1L,12L,42L,9L,1L,1L,1L,1L,6L,1L,1L,3L,8L,2L,7L,1L,1L,2L,2L,1L,1L,3L,1L,17L,1L,3L,2L,4L,1L,2L,1L,4L,3L,1L,1L,1L,7L,13L,22L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074951Inst : IEnumerable<long>
{
public static readonly long[] Value=A074951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074951.Bytes);
public long this[int i]=>Value[i];

public static A074951Inst Instance=new A074951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074952
{
public static readonly long[] Value={ 2L,1L,15L,54L,15L,1L,2L,2L,1L,2L,19L,3L,2L,1L,1L,19L,1L,3L,2L,4L,1L,5L,1L,1L,1L,1L,5L,8L,2L,1L,1L,2L,3L,1L,1L,2L,3L,1L,2L,9L,2L,3L,18L,5L,63L,2L,1L,1L,4L,13L,3L,10L,1L,5L,1L,20L,1L,6L,1L,38L,2L,1L,4L,57L,1L,8L,12L,9L,2L,1L,2L,1L,1L,4L,10L,1L,1L,1L,15L,2L,4L,1L,1L,1L,1L,9L,2L,2L,3L,54L,1L,39L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074952Inst : IEnumerable<long>
{
public static readonly long[] Value=A074952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074952.Bytes);
public long this[int i]=>Value[i];

public static A074952Inst Instance=new A074952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074953
{
public static readonly long[] Value={ 5L,9L,15L,24L,36L,51L,66L,87L,105L,123L,144L,165L,186L,195L,213L,234L,255L,276L,297L,330L,384L,426L,447L,492L,546L,585L,609L,630L,651L,735L,816L,825L,843L,870L,951L,1026L,1041L,1056L,1077L,1122L,1191L,1254L,1284L,1296L,1311L,1374L,1440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074953Inst : IEnumerable<long>
{
public static readonly long[] Value=A074953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074953.Bytes);
public long this[int i]=>Value[i];

public static A074953Inst Instance=new A074953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074954
{
public static readonly long[] Value={ 9L,27L,4L,8L,9L,0L,8L,9L,25L,2197L,27L,16L,49L,0L,16L,25L,25L,27L,27L,36L,25L,49L,27L,25L,125L,27L,36L,32L,225L,6889L,32L,36L,49L,0L,36L,100L,64L,1369L,64L,49L,49L,0L,484L,125L,49L,289L,128L,49L,81L,0L,100L,196L,729L,81L,64L,64L,121L,0L,900L,64L,125L,0L,64L,100L,81L,0L,1156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074954Inst : IEnumerable<long>
{
public static readonly long[] Value=A074954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074954.Bytes);
public long this[int i]=>Value[i];

public static A074954Inst Instance=new A074954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074955
{
public static readonly long[] Value={ 2L,1L,13L,3L,1L,1L,1L,42L,1L,2L,1L,5L,5L,1L,1L,1L,1L,4L,2L,1L,2L,4L,8L,1L,3L,1L,1L,1L,1L,1L,1L,1L,4L,18L,1L,1L,1L,12L,3L,1L,8L,1L,1L,2L,3L,1L,2L,5L,2L,2L,2L,1L,2L,6L,2L,4L,4L,3L,1L,1L,19L,730L,1L,30L,1L,51L,2L,1L,2L,6L,1L,1L,1L,4L,7L,20L,96L,38L,5L,3L,3L,10L,1L,1L,3L,3L,2L,2L,3L,74L,1L,1L,941L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074955Inst : IEnumerable<long>
{
public static readonly long[] Value=A074955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074955.Bytes);
public long this[int i]=>Value[i];

public static A074955Inst Instance=new A074955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074956
{
public static readonly long[] Value={ 2L,1L,12L,1L,1L,6L,1L,136L,11L,1L,1L,4L,1L,5L,2L,9L,1L,2L,1L,4L,3L,2L,4L,2L,3L,2L,1L,46L,7L,1L,6L,2L,1L,3L,14L,4L,6L,8L,6L,3L,1L,2L,1L,6L,1L,2L,1L,3L,2L,1L,1L,1L,1L,1L,7L,1L,1L,6L,1L,3L,9L,10L,1L,1L,227L,1L,2L,1L,1L,9L,2L,7L,1L,2L,2L,1L,2L,1L,3L,1L,2L,1L,5L,1L,170L,1L,17L,1L,5L,2L,3L,10L,7L,1L,10L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074956Inst : IEnumerable<long>
{
public static readonly long[] Value=A074956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074956.Bytes);
public long this[int i]=>Value[i];

public static A074956Inst Instance=new A074956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074957
{
public static readonly long[] Value={ 2L,9L,2L,6L,1L,0L,8L,5L,5L,1L,5L,7L,2L,3L,0L,4L,6L,9L,6L,6L,6L,5L,8L,9L,5L,7L,1L,0L,1L,7L,0L,5L,5L,8L,5L,3L,1L,0L,6L,6L,2L,0L,5L,7L,5L,5L,3L,7L,9L,8L,4L,5L,6L,2L,7L,4L,4L,2L,4L,1L,5L,5L,1L,2L,4L,2L,1L,5L,2L,6L,8L,6L,8L,5L,1L,1L,9L,8L,6L,4L,4L,5L,1L,9L,3L,9L,4L,0L,9L,3L,5L,4L,6L,3L,2L,2L,7L,4L,5L,6L,4L,1L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074957Inst : IEnumerable<long>
{
public static readonly long[] Value=A074957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074957.Bytes);
public long this[int i]=>Value[i];

public static A074957Inst Instance=new A074957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074958
{
public static readonly long[] Value={ 2L,4L,7L,4L,6L,8L,0L,4L,3L,6L,2L,3L,6L,3L,0L,4L,4L,6L,2L,6L,0L,6L,6L,5L,9L,6L,0L,3L,5L,9L,1L,4L,0L,1L,4L,8L,9L,2L,5L,1L,6L,7L,4L,0L,9L,4L,0L,6L,6L,7L,3L,5L,8L,6L,6L,8L,2L,6L,1L,8L,2L,7L,4L,0L,6L,3L,0L,4L,8L,5L,8L,9L,6L,2L,0L,7L,0L,0L,7L,2L,5L,2L,3L,9L,2L,6L,8L,3L,4L,9L,4L,6L,3L,8L,2L,6L,6L,9L,9L,7L,9L,9L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074958Inst : IEnumerable<long>
{
public static readonly long[] Value=A074958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074958.Bytes);
public long this[int i]=>Value[i];

public static A074958Inst Instance=new A074958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074959
{
public static readonly long[] Value={ 3L,9L,3L,6L,2L,3L,5L,5L,0L,3L,6L,4L,9L,5L,5L,5L,4L,7L,7L,9L,7L,8L,9L,2L,6L,1L,7L,5L,5L,0L,0L,7L,4L,7L,8L,9L,7L,8L,2L,7L,8L,9L,7L,6L,4L,0L,7L,3L,7L,1L,6L,3L,9L,4L,2L,4L,5L,8L,2L,0L,1L,2L,2L,6L,3L,4L,9L,5L,9L,8L,9L,7L,8L,7L,9L,1L,4L,7L,2L,9L,8L,0L,7L,8L,6L,2L,6L,6L,5L,4L,4L,1L,9L,8L,7L,2L,6L,9L,1L,1L,6L,5L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074959Inst : IEnumerable<long>
{
public static readonly long[] Value=A074959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074959.Bytes);
public long this[int i]=>Value[i];

public static A074959Inst Instance=new A074959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074960
{
public static readonly long[] Value={ 3L,1L,14L,1L,2L,6L,1L,1L,2L,5L,2L,1L,2L,1L,4L,7L,1L,7L,9L,1L,4L,1L,20L,1L,1L,1L,1L,1L,1L,4L,2L,10L,1L,2L,1L,5L,1L,4L,2L,2L,2L,30L,1L,18L,2L,6L,1L,1L,1L,1L,6L,1L,1L,2L,12L,6L,1L,2L,6L,1L,17L,5L,2L,1L,6L,2L,3L,1L,5L,1L,1L,3L,1L,1L,2L,4L,11L,1L,4L,2L,11L,1L,1L,23L,1L,1L,3L,1L,5L,3L,1L,1L,1L,2L,21L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074960Inst : IEnumerable<long>
{
public static readonly long[] Value=A074960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074960.Bytes);
public long this[int i]=>Value[i];

public static A074960Inst Instance=new A074960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074961
{
public static readonly long[] Value={ 2L,2L,9L,2L,1L,2L,12L,1L,1L,16L,3L,3L,1L,7L,21L,1L,3L,1L,1L,2L,19L,7L,2L,1L,15L,1L,6L,1L,6L,4L,1L,5L,2L,2L,1L,1L,1L,2L,1L,12L,1L,12L,3L,1L,1L,1L,3L,18L,1L,1L,2L,4L,8L,16L,1L,3L,1L,30L,1L,4L,13L,1L,2L,1L,3L,9L,3L,5L,4L,7L,4L,1L,1L,3L,3L,30L,3L,7L,4L,10L,2L,19L,1L,4L,4L,1L,1L,9L,33L,1L,3L,1L,7L,8L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074961Inst : IEnumerable<long>
{
public static readonly long[] Value=A074961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074961.Bytes);
public long this[int i]=>Value[i];

public static A074961Inst Instance=new A074961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074962
{
public static readonly long[] Value={ 1L,2L,8L,2L,4L,2L,7L,1L,2L,9L,1L,0L,0L,6L,2L,2L,6L,3L,6L,8L,7L,5L,3L,4L,2L,5L,6L,8L,8L,6L,9L,7L,9L,1L,7L,2L,7L,7L,6L,7L,6L,8L,8L,9L,2L,7L,3L,2L,5L,0L,0L,1L,1L,9L,2L,0L,6L,3L,7L,4L,0L,0L,2L,1L,7L,4L,0L,4L,0L,6L,3L,0L,8L,8L,5L,8L,8L,2L,6L,4L,6L,1L,1L,2L,9L,7L,3L,6L,4L,9L,1L,9L,5L,8L,2L,0L,2L,3L,7L,4L,3L,9L,4L,2L,0L,6L,4L,6L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074962Inst : IEnumerable<long>
{
public static readonly long[] Value=A074962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074962.Bytes);
public long this[int i]=>Value[i];

public static A074962Inst Instance=new A074962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074963
{
public static readonly long[] Value={ 1L,7L,13L,31L,42L,91L,96L,127L,195L,234L,234L,403L,403L,480L,576L,744L,744L,847L,847L,1170L,1344L,1344L,1344L,1651L,1860L,1860L,1860L,2240L,2240L,2880L,2880L,3048L,3048L,3048L,3048L,4368L,4368L,4368L,4368L,5040L,5040L,5952L,5952L,5952L,6552L,6552L,6552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074963Inst : IEnumerable<long>
{
public static readonly long[] Value=A074963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074963.Bytes);
public long this[int i]=>Value[i];

public static A074963Inst Instance=new A074963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075012
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,981L,114462L,13082645L,1471900839L,1635537203L,1799173568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075012Inst : IEnumerable<long>
{
public static readonly long[] Value=A075012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075012.Bytes);
public long this[int i]=>Value[i];

public static A075012Inst Instance=new A075012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075013
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,5L,5L,4L,9L,16L,1L,7L,5L,4L,19L,3L,13L,22L,19L,16L,27L,2L,19L,24L,7L,31L,5L,31L,19L,27L,19L,16L,3L,9L,31L,26L,41L,7L,19L,28L,37L,20L,27L,4L,51L,20L,19L,16L,49L,52L,35L,32L,31L,49L,5L,22L,31L,66L,19L,32L,27L,58L,19L,9L,49L,6L,35L,28L,9L,26L,67L,13L,63L,49L,79L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075013Inst : IEnumerable<long>
{
public static readonly long[] Value=A075013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075013.Bytes);
public long this[int i]=>Value[i];

public static A075013Inst Instance=new A075013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075014
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,2L,3L,5L,1L,17L,17L,6L,9L,11L,3L,16L,5L,7L,21L,2L,17L,18L,29L,26L,17L,5L,33L,8L,11L,35L,3L,17L,33L,26L,41L,11L,7L,17L,21L,13L,47L,4L,17L,41L,41L,27L,29L,9L,51L,50L,17L,21L,5L,61L,61L,35L,27L,52L,41L,29L,35L,68L,45L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075014Inst : IEnumerable<long>
{
public static readonly long[] Value=A075014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075014.Bytes);
public long this[int i]=>Value[i];

public static A075014Inst Instance=new A075014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075015
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,2L,5L,4L,2L,8L,8L,4L,2L,104L,3L,18L,17L,2L,4L,18L,5L,8L,3L,4L,23L,2L,5L,118L,37L,8L,39L,18L,8L,34L,118L,14L,110L,4L,2L,18L,1L,104L,47L,10L,8L,32L,49L,18L,104L,48L,17L,142L,48L,8L,8L,118L,4L,66L,21L,18L,48L,70L,5L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075015Inst : IEnumerable<long>
{
public static readonly long[] Value=A075015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075015.Bytes);
public long this[int i]=>Value[i];

public static A075015Inst Instance=new A075015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075016
{
public static readonly long[] Value={ 2L,2L,2L,4L,2L,2L,2L,4L,4L,2L,12L,4L,105L,2L,2L,4L,7L,4L,18L,22L,2L,12L,11L,4L,27L,118L,4L,106L,21L,2L,23L,14L,12L,34L,2L,4L,112L,18L,105L,22L,15L,2L,39L,34L,7L,14L,9L,4L,141L,52L,7L,118L,58L,4L,12L,106L,18L,50L,38L,22L,10L,54L,106L,14L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075016Inst : IEnumerable<long>
{
public static readonly long[] Value=A075016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075016.Bytes);
public long this[int i]=>Value[i];

public static A075016Inst Instance=new A075016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075017
{
public static readonly long[] Value={ 1L,1L,3L,3L,2L,3L,2L,3L,3L,7L,8L,3L,7L,17L,12L,3L,5L,3L,19L,17L,24L,15L,17L,3L,22L,7L,3L,17L,17L,27L,6L,3L,15L,5L,2L,3L,9L,19L,15L,17L,15L,45L,44L,37L,12L,17L,39L,3L,45L,47L,21L,41L,52L,3L,37L,17L,57L,17L,62L,57L,53L,53L,66L,3L,7L,15L,2L,21L,63L,17L,12L,3L,6L,9L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075017Inst : IEnumerable<long>
{
public static readonly long[] Value=A075017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075017.Bytes);
public long this[int i]=>Value[i];

public static A075017Inst Instance=new A075017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075018
{
public static readonly long[] Value={ 3L,3L,3L,5L,3L,3L,5L,5L,6L,3L,18L,9L,11L,5L,3L,15L,13L,15L,19L,23L,18L,29L,29L,15L,28L,11L,33L,5L,4L,3L,40L,15L,18L,13L,18L,15L,28L,19L,24L,23L,26L,39L,7L,51L,33L,29L,55L,15L,53L,53L,30L,63L,54L,33L,18L,5L,57L,41L,56L,63L,69L,71L,60L,15L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075018Inst : IEnumerable<long>
{
public static readonly long[] Value=A075018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075018.Bytes);
public long this[int i]=>Value[i];

public static A075018Inst Instance=new A075018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075019
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,2L,127L,2L,3L,2L,3L,2L,113L,2L,3L,2L,3L,2L,13L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,29L,2L,3L,2L,3L,2L,71L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,23L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,10386763L,2L,3L,2L,3L,2L,397L,2L,3L,2L,3L,2L,37907L,2L,3L,2L,3L,2L,73L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,37L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075019Inst : IEnumerable<long>
{
public static readonly long[] Value=A075019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075019.Bytes);
public long this[int i]=>Value[i];

public static A075019Inst Instance=new A075019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075020
{
public static readonly long[] Value={ 1L,3L,3L,29L,3L,3L,19L,3L,3L,7L,3L,3L,17L,3L,3L,23L,3L,3L,17L,3L,3L,13L,3L,3L,11L,3L,3L,23L,3L,3L,7L,3L,3L,89L,3L,3L,29L,3L,3L,11L,3L,3L,52433L,3L,3L,23L,3L,3L,71L,3L,3L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075020Inst : IEnumerable<long>
{
public static readonly long[] Value=A075020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075020.Bytes);
public long this[int i]=>Value[i];

public static A075020Inst Instance=new A075020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075021
{
public static readonly BigInteger[] Value={ 1L,7L,107L,149L,953L,218107L,402859L,4877L,379721L,54421L,370329218107L,5767189888301L,237927839L,1728836281L,136133374970881L,1190788477118549L,677181889L,399048049L,40617114482123L,BigInteger.Parse("629639170774346584751") };
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
public class A075021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075021Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075021.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075021Inst Instance=new A075021Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075022
{
public static readonly long[] Value={ 1L,3L,41L,617L,823L,643L,9721L,14593L,3803L,1234567891L,630803L,2110805449L,869211457L,205761315168520219L,8230452606740808761L,1231026625769L,584538396786764503L,801309546900123763L,833929457045867563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075022Inst : IEnumerable<long>
{
public static readonly long[] Value=A075022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075022.Bytes);
public long this[int i]=>Value[i];

public static A075022Inst Instance=new A075022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075023
{
public static readonly BigInteger[] Value={ 1L,11L,3L,11L,41L,3L,239L,11L,3L,12345678910987654321UL,7L,3L,1109L,7L,3L,71L,7L,3L,251L,7L,3L,70607L,7L,3L,BigInteger.Parse("989931671244066864878631629"),7L,3L,149L,7L,3L,827L,7L,3L,197L,7L,3L,39907897297L,7L,3L,17047L,7L,3L,191L,7L,3L,967L,7L,3L,139121L,7L,3L,109L,7L,3L,5333L,7L,3L };
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
public class A075023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075023Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075023.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075023Inst Instance=new A075023Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075024
{
public static readonly BigInteger[] Value={ 1L,11L,37L,101L,271L,37L,4649L,137L,333667L,12345678910987654321UL,BigInteger.Parse("17636684157301569664903"),BigInteger.Parse("2799473675762179389994681"),BigInteger.Parse("2354041513534224607850261"),2068140300159522133L,498056174529497L,BigInteger.Parse("112240064764214229701"),BigInteger.Parse("4188353169004802474320231191377") };
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
public class A075024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075024Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A075024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075024.Bytes);
public BigInteger this[int i]=>Value[i];

public static A075024Inst Instance=new A075024Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075025
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,49L,51L,53L,55L,59L,61L,65L,67L,69L,71L,73L,77L,79L,83L,89L,91L,97L,101L,103L,107L,109L,111L,113L,115L,121L,125L,127L,129L,131L,137L,139L,149L,151L,153L,155L,157L,161L,163L,167L,169L,173L,175L,179L,181L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075025Inst : IEnumerable<long>
{
public static readonly long[] Value=A075025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075025.Bytes);
public long this[int i]=>Value[i];

public static A075025Inst Instance=new A075025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A075026
{
public static readonly long[] Value={ 9L,25L,49L,51L,55L,65L,69L,77L,91L,111L,115L,121L,125L,129L,153L,155L,161L,169L,175L,183L,185L,187L,209L,221L,235L,237L,247L,249L,259L,265L,267L,274L,287L,289L,291L,295L,305L,309L,319L,321L,323L,329L,339L,341L,343L,351L,355L,361L,365L,369L,371L,377L,386L,391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A075026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A075026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A075026Inst : IEnumerable<long>
{
public static readonly long[] Value=A075026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A075026.Bytes);
public long this[int i]=>Value[i];

public static A075026Inst Instance=new A075026Inst();

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