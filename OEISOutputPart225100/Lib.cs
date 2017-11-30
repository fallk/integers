using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A275762
{
public static readonly long[] Value={ 2L,-1L,2L,-4L,7L,-12L,22L,-41L,74L,-133L,243L,-444L,806L,-1465L,2669L,-4859L,8840L,-16087L,29282L,-53296L,96994L,-176527L,321290L,-584755L,1064251L,-1936952L,3525296L,-6416092L,11677369L,-21252993L,38680798L,-70399646L,128128414L,-233195704L,424419826L,-772450633L,1405872057L,-2558708924L,4656889892L,-8475611623L,15425744240L,-28075093283L,51097104306L,-92997520459L,169256926243L,-308050225082L,560656176744L,-1020402917484L,1857149100126L,-3380040101304L,6151725289638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275762Inst : IEnumerable<long>
{
public static readonly long[] Value=A275762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275762.Bytes);
public long this[int i]=>Value[i];

public static A275762Inst Instance=new A275762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275763
{
public static readonly BigInteger[] Value={ 1L,1L,5L,63L,1514L,59685L,3512620L,289374295L,31846112564L,4518890895645L,804124456255680L,175478742025495755L,BigInteger.Parse("46106223230016643056"),BigInteger.Parse("14363471037818609599893"),BigInteger.Parse("5236804141734580288633760"),BigInteger.Parse("2209636417728549950873988255"),BigInteger.Parse("1068573377399399933312154968064"),BigInteger.Parse("587247047578198565707709826415149"),BigInteger.Parse("364003505996839798561347571968317760"),BigInteger.Parse("252786592402514515785220127177096089395") };
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
public class A275763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275763Inst Instance=new A275763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275764
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,16L,56L,426L,2262L,26944L,191536L,3126160L,27728240L,575175624L,6103078632L,153600146896L,1895624842048L,56097022625536L,789039958221824L,26841919568551488L,423728844983247552L,16289858574401789440UL,BigInteger.Parse("285136754661527448832"),BigInteger.Parse("12223695878727911987200"),BigInteger.Parse("234939121837394575935488"),BigInteger.Parse("11111439664638562836316800"),BigInteger.Parse("232614372016075736439705216"),BigInteger.Parse("12030859273551523180503859456"),BigInteger.Parse("272479395898122444403210189312") };
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
public class A275764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275764Inst Instance=new A275764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275765
{
public static readonly BigInteger[] Value={ 1L,2L,12L,106L,1148L,14156L,191400L,2775930L,42585412L,684496988L,11449962008L,198331811356L,3543990791480L,65136985937096L,1228531761076208L,23733123786608826L,468887742020767788L,9461919438245032500UL,BigInteger.Parse("194817077269127033944"),BigInteger.Parse("4089069139317823277548"),BigInteger.Parse("87426000975842460304792"),BigInteger.Parse("1902787414323673070857528"),BigInteger.Parse("42133267254272433484761584"),BigInteger.Parse("948695717599714654940068604"),BigInteger.Parse("21712101305047777916075831096"),BigInteger.Parse("504865916349551192319293625016") };
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
public class A275765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275765Inst Instance=new A275765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275766
{
public static readonly BigInteger[] Value={ 156L,3906L,97656L,2441406L,61035156L,1525878906L,38146972656L,953674316406L,23841857910156L,596046447753906L,14901161193847656L,372529029846191406L,9313225746154785156UL,BigInteger.Parse("232830643653869628906"),BigInteger.Parse("5820766091346740722656"),BigInteger.Parse("145519152283668518066406") };
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
public class A275766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275766Inst Instance=new A275766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275767
{
public static readonly long[] Value={ 2L,3L,9L,11L,291L,1263L,2661L,3165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275767Inst : IEnumerable<long>
{
public static readonly long[] Value=A275767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275767.Bytes);
public long this[int i]=>Value[i];

public static A275767Inst Instance=new A275767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275768
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,2L,1L,2L,0L,2L,0L,1L,1L,2L,0L,3L,0L,2L,1L,1L,0L,5L,0L,1L,0L,0L,0L,5L,0L,1L,0L,1L,0L,5L,0L,0L,1L,1L,0L,6L,0L,1L,1L,1L,0L,5L,0L,2L,0L,0L,0L,5L,0L,2L,0L,0L,0L,10L,0L,0L,0L,1L,0L,8L,0L,0L,1L,2L,0L,6L,0L,0L,0L,2L,0L,8L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275768Inst : IEnumerable<long>
{
public static readonly long[] Value=A275768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275768.Bytes);
public long this[int i]=>Value[i];

public static A275768Inst Instance=new A275768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275769
{
public static readonly long[] Value={ 1L,3L,2L,3L,4L,3L,10L,5L,5L,4L,9L,3L,6L,10L,4L,7L,8L,5L,14L,4L,11L,9L,12L,5L,21L,6L,14L,10L,42L,4L,6L,11L,9L,8L,14L,5L,36L,14L,6L,5L,22L,11L,35L,9L,5L,12L,24L,7L,13L,21L,8L,7L,69L,14L,9L,10L,14L,42L,60L,4L,21L,6L,14L,12L,8L,9L,45L,8L,12L,14L,20L,5L,10L,36L,21L,14L,10L,6L,40L,8L,14L,22L,81L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275769Inst : IEnumerable<long>
{
public static readonly long[] Value=A275769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275769.Bytes);
public long this[int i]=>Value[i];

public static A275769Inst Instance=new A275769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275770
{
public static readonly long[] Value={ 17L,47L,59L,71L,101L,107L,137L,149L,167L,197L,227L,257L,263L,269L,311L,317L,347L,353L,383L,389L,401L,449L,461L,467L,479L,503L,521L,557L,563L,569L,587L,599L,617L,647L,677L,701L,773L,797L,821L,827L,839L,857L,863L,881L,887L,929L,941L,947L,971L,977L,983L,1061L,1091L,1097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275770Inst : IEnumerable<long>
{
public static readonly long[] Value=A275770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275770.Bytes);
public long this[int i]=>Value[i];

public static A275770Inst Instance=new A275770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275771
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,4L,5L,8L,9L,12L,11L,14L,17L,20L,23L,24L,23L,24L,29L,36L,37L,38L,35L,36L,41L,48L,53L,56L,53L,50L,51L,56L,63L,76L,75L,74L,63L,74L,77L,94L,89L,90L,79L,90L,91L,112L,103L,106L,87L,108L,117L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275771Inst : IEnumerable<long>
{
public static readonly long[] Value=A275771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275771.Bytes);
public long this[int i]=>Value[i];

public static A275771Inst Instance=new A275771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275772
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,11L,22L,33L,44L,55L,22L,33L,44L,55L,66L,22L,33L,44L,55L,66L,33L,44L,55L,66L,77L,33L,44L,55L,66L,77L,44L,55L,66L,77L,88L,44L,55L,66L,77L,88L,55L,66L,77L,88L,99L,37L,74L,111L,148L,185L,222L,259L,296L,333L,370L,74L,111L,148L,185L,222L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275772Inst : IEnumerable<long>
{
public static readonly long[] Value=A275772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275772.Bytes);
public long this[int i]=>Value[i];

public static A275772Inst Instance=new A275772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275773
{
public static readonly long[] Value={ 4421L,4733L,5669L,5981L,8581L,9413L,10453L,11597L,13963L,14327L,14951L,19267L,22699L,22907L,23557L,25117L,25819L,26417L,28627L,31799L,32579L,35491L,37441L,41549L,44773L,44851L,45553L,46619L,46957L,48179L,49297L,49921L,49999L,50207L,52859L,53639L,60217L,64403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275773Inst : IEnumerable<long>
{
public static readonly long[] Value=A275773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275773.Bytes);
public long this[int i]=>Value[i];

public static A275773Inst Instance=new A275773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275774
{
public static readonly long[] Value={ 1L,2L,3L,6L,14L,35L,611L,3524579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275774Inst : IEnumerable<long>
{
public static readonly long[] Value=A275774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275774.Bytes);
public long this[int i]=>Value[i];

public static A275774Inst Instance=new A275774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275775
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,20L,10L,22L,12L,24L,14L,26L,16L,28L,18L,40L,21L,42L,23L,44L,25L,46L,27L,48L,29L,60L,30L,62L,32L,64L,34L,66L,36L,68L,38L,80L,41L,82L,43L,84L,45L,86L,47L,88L,49L,200L,50L,202L,52L,204L,54L,206L,56L,208L,58L,220L,61L,222L,63L,224L,65L,226L,67L,228L,69L,240L,70L,242L,72L,244L,74L,246L,76L,248L,78L,260L,81L,262L,83L,264L,85L,266L,87L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275775Inst : IEnumerable<long>
{
public static readonly long[] Value=A275775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275775.Bytes);
public long this[int i]=>Value[i];

public static A275775Inst Instance=new A275775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275776
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,31L,23L,33L,25L,35L,27L,37L,29L,39L,30L,51L,32L,53L,34L,55L,36L,57L,38L,59L,41L,71L,43L,73L,45L,75L,47L,77L,49L,79L,50L,91L,52L,93L,54L,95L,56L,97L,58L,99L,61L,111L,63L,113L,65L,115L,67L,117L,69L,119L,70L,131L,72L,133L,74L,135L,76L,137L,78L,139L,81L,151L,83L,153L,85L,155L,87L,157L,89L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275776Inst : IEnumerable<long>
{
public static readonly long[] Value=A275776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275776.Bytes);
public long this[int i]=>Value[i];

public static A275776Inst Instance=new A275776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275777
{
public static readonly long[] Value={ 7L,23L,31L,79L,167L,431L,479L,983L,1303L,1607L,1871L,2351L,4799L,6263L,6271L,9551L,10103L,10111L,11471L,11519L,12503L,12647L,12959L,14087L,17231L,17623L,21599L,23039L,25391L,25919L,25951L,28879L,29927L,33599L,35543L,43711L,48479L,48647L,49871L,56671L,57119L,62743L,71551L,71999L,79151L,81551L,82567L,91703L,96079L,97919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275777Inst : IEnumerable<long>
{
public static readonly long[] Value=A275777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275777.Bytes);
public long this[int i]=>Value[i];

public static A275777Inst Instance=new A275777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275778
{
public static readonly long[] Value={ 1L,2L,1L,4L,7L,12L,23L,42L,77L,142L,261L,480L,883L,1624L,2987L,5494L,10105L,18586L,34185L,62876L,115647L,212708L,391231L,719586L,1323525L,2434342L,4477453L,8235320L,15147115L,27859888L,51242323L,94249326L,173351537L,318843186L,586444049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275778Inst : IEnumerable<long>
{
public static readonly long[] Value=A275778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275778.Bytes);
public long this[int i]=>Value[i];

public static A275778Inst Instance=new A275778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275779
{
public static readonly BigInteger[] Value={ 2L,20L,584L,69904L,34636832L,69810262080L,567382630219904L,BigInteger.Parse("18519084246547628288"),BigInteger.Parse("2422583247133816584929792"),BigInteger.Parse("1268889750375080065623288448000") };
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
public class A275779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275779Inst Instance=new A275779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275780
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,43L,160L,668L,3098L,15465L,83100L,477651L,2914505L,18795814L,127790544L,911448954L,6808162094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275780Inst : IEnumerable<long>
{
public static readonly long[] Value=A275780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275780.Bytes);
public long this[int i]=>Value[i];

public static A275780Inst Instance=new A275780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275781
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,9L,43L,209L,1042L,5682L,32875L,200919L,1299092L,8848623L,63108778L,471509591L,3671980053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275781Inst : IEnumerable<long>
{
public static readonly long[] Value=A275781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275781.Bytes);
public long this[int i]=>Value[i];

public static A275781Inst Instance=new A275781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275782
{
public static readonly long[] Value={ 0L,11L,10L,100L,101L,102L,120L,1002L,1022L,1012L,1021L,1023L,1201L,1203L,1230L,10023L,10121L,10120L,10201L,10123L,10232L,10213L,10231L,10234L,12132L,12013L,12031L,12034L,12301L,12304L,12340L,100234L,101201L,101213L,101232L,101203L,101231L,101230L,102031L,101234L,102132L,102130L,102301L,102134L,102342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275782Inst : IEnumerable<long>
{
public static readonly long[] Value=A275782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275782.Bytes);
public long this[int i]=>Value[i];

public static A275782Inst Instance=new A275782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275783
{
public static readonly long[] Value={ 2L,3L,6L,11L,44L,64L,83L,123L,166L,381L,446L,1221L,1540L,3156L,5117L,5476L,6291L,6353L,13053L,15158L,23904L,78288L,82254L,91230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275783Inst : IEnumerable<long>
{
public static readonly long[] Value=A275783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275783.Bytes);
public long this[int i]=>Value[i];

public static A275783Inst Instance=new A275783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275784
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,4L,5L,1L,1L,0L,1L,12L,53L,16L,1L,1L,0L,1L,36L,761L,936L,61L,1L,1L,0L,1L,120L,12661L,87336L,25325L,272L,1L,1L,0L,1L,400L,229705L,9929000L,18528505L,933980L,1385L,1L,1L,0L,1L,1400L,4410665L,1267945800L,17504311533L,6376563600L,45504649L,7936L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275784Inst : IEnumerable<long>
{
public static readonly long[] Value=A275784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275784.Bytes);
public long this[int i]=>Value[i];

public static A275784Inst Instance=new A275784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275785
{
public static readonly long[] Value={ 3L,5L,11L,23L,29L,31L,37L,89L,113L,127L,139L,149L,199L,251L,293L,331L,337L,367L,409L,521L,523L,631L,701L,787L,797L,953L,1087L,1129L,1151L,1259L,1277L,1327L,1361L,1381L,1399L,1657L,1669L,1847L,1933L,1949L,1951L,1973L,2477L,2503L,2579L,2633L,2861L,2879L,2971L,2999L,3089L,3137L,3163L,3229L,3407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275785Inst : IEnumerable<long>
{
public static readonly long[] Value=A275785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275785.Bytes);
public long this[int i]=>Value[i];

public static A275785Inst Instance=new A275785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275786
{
public static readonly long[] Value={ 1L,3L,6L,30L,15L,378L,28L,1080L,270L,2475L,66L,294840L,91L,8820L,10800L,146880L,153L,2908710L,190L,5197500L,38808L,50094L,276L,3184272000L,4875L,95823L,102060L,35809200L,435L,17401230000L,496L,77552640L,222156L,273105L,264600L,1511016670800L,703L,422370L,425880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275786Inst : IEnumerable<long>
{
public static readonly long[] Value=A275786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275786.Bytes);
public long this[int i]=>Value[i];

public static A275786Inst Instance=new A275786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275787
{
public static readonly BigInteger[] Value={ 5L,41L,509L,8469L,176217L,4400325L,128203049L,4268957449L,159922273421L,6656731517249L,304797275277365L,15224868078068845L,823874409422614577L,BigInteger.Parse("48012621942105876301"),BigInteger.Parse("2997884066292303095889"),BigInteger.Parse("199666128081901473290833"),BigInteger.Parse("14129411123649333432720277"),BigInteger.Parse("1058688691179737704258634521"),BigInteger.Parse("83732563305101190468369022317"),BigInteger.Parse("6971039973751002759723517967941") };
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
public class A275787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275787Inst Instance=new A275787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275788
{
public static readonly long[] Value={ 0L,1L,3L,7L,13L,25L,49L,99L,199L,399L,797L,1593L,3185L,6371L,12743L,25487L,50973L,101945L,203889L,407779L,815559L,1631119L,3262237L,6524473L,13048945L,26097891L,52195783L,104391567L,208783133L,417566265L,835132529L,1670265059L,3340530119L,6681060239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275788Inst : IEnumerable<long>
{
public static readonly long[] Value=A275788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275788.Bytes);
public long this[int i]=>Value[i];

public static A275788Inst Instance=new A275788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275789
{
public static readonly long[] Value={ 1L,4L,6L,8L,12L,12L,6L,20L,7L,12L,12L,24L,24L,12L,12L,30L,12L,28L,30L,24L,24L,12L,12L,60L,30L,24L,30L,24L,60L,12L,24L,24L,12L,36L,12L,56L,18L,60L,24L,60L,24L,24L,30L,24L,84L,12L,12L,30L,36L,60L,12L,168L,36L,60L,12L,60L,60L,60L,60L,24L,30L,24L,42L,128L,24L,12L,18L,24L,24L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275789Inst : IEnumerable<long>
{
public static readonly long[] Value=A275789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275789.Bytes);
public long this[int i]=>Value[i];

public static A275789Inst Instance=new A275789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275790
{
public static readonly long[] Value={ 1L,8L,1L,-32L,11L,3L,-736L,-92L,9L,15L,2816L,-593L,-249L,-65L,35L,48976L,6122L,1581L,-970L,-1295L,315L,-951424L,61252L,67791L,46030L,18515L,-21735L,3465L,-1045952L,-130744L,-92082L,-30445L,14455L,53928L,-25179L,3003L,26933248L,1069361L,-1666047L,-634255L,-1167740L,-1258236L,1562253L,-471471L,45045L,634836808L,79354601L,24881793L,17914550L,30289840L,12635028L,-71064609L,42480438L,-9594585L,765765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275790Inst : IEnumerable<long>
{
public static readonly long[] Value=A275790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275790.Bytes);
public long this[int i]=>Value[i];

public static A275790Inst Instance=new A275790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275791
{
public static readonly long[] Value={ 1L,-4L,1L,4L,-5L,1L,0L,12L,-7L,1L,4L,-21L,25L,-9L,1L,-8L,30L,-63L,42L,-11L,1L,0L,-44L,131L,-138L,63L,-13L,1L,0L,72L,-246L,365L,-253L,88L,-15L,1L,4L,-85L,425L,-837L,808L,-416L,117L,-17L,1L,-4L,85L,-685L,1734L,-2200L,1552L,-635L,150L,-19L,1L,8L,-134L,1053L,-3319L,5326L,-4888L,2705L,-918L,187L,-21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275791Inst : IEnumerable<long>
{
public static readonly long[] Value=A275791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275791.Bytes);
public long this[int i]=>Value[i];

public static A275791Inst Instance=new A275791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275792
{
public static readonly long[] Value={ 1L,1L,5L,0L,9L,8L,2L,3L,6L,8L,0L,9L,4L,6L,7L,6L,3L,8L,6L,3L,6L,3L,6L,8L,9L,8L,9L,6L,9L,5L,2L,6L,7L,5L,0L,5L,8L,3L,0L,9L,6L,6L,7L,0L,9L,5L,5L,1L,8L,7L,4L,9L,1L,0L,9L,8L,3L,9L,6L,4L,5L,7L,8L,4L,5L,0L,5L,0L,4L,2L,6L,9L,1L,0L,9L,1L,3L,6L,6L,7L,4L,1L,4L,0L,9L,6L,6L,7L,5L,5L,3L,7L,0L,6L,3L,0L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275792Inst : IEnumerable<long>
{
public static readonly long[] Value=A275792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275792.Bytes);
public long this[int i]=>Value[i];

public static A275792Inst Instance=new A275792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275793
{
public static readonly long[] Value={ 9L,43L,249L,1451L,8457L,49291L,287289L,1674443L,9759369L,56881771L,331531257L,1932305771L,11262303369L,65641514443L,382586783289L,2229879185291L,12996688328457L,75750250785451L,441504816384249L,2573278647520043L,14998167068736009L,87415723764896011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275793Inst : IEnumerable<long>
{
public static readonly long[] Value=A275793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275793.Bytes);
public long this[int i]=>Value[i];

public static A275793Inst Instance=new A275793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275794
{
public static readonly long[] Value={ 2L,15L,88L,513L,2990L,17427L,101572L,592005L,3450458L,20110743L,117214000L,683173257L,3981825542L,23207779995L,135264854428L,788381346573L,4595023225010L,26781758003487L,156095524795912L,909791390771985L,5302652819835998L,30906125528244003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275794Inst : IEnumerable<long>
{
public static readonly long[] Value=A275794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275794.Bytes);
public long this[int i]=>Value[i];

public static A275794Inst Instance=new A275794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275795
{
public static readonly long[] Value={ 11L,57L,331L,1929L,11243L,65529L,381931L,2226057L,12974411L,75620409L,440748043L,2568867849L,14972459051L,87265886457L,508622859691L,2964471271689L,17278204770443L,100704757350969L,586950339335371L,3420997278661257L,19939033332632171L,116213202717131769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275795Inst : IEnumerable<long>
{
public static readonly long[] Value=A275795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275795.Bytes);
public long this[int i]=>Value[i];

public static A275795Inst Instance=new A275795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275796
{
public static readonly long[] Value={ 3L,20L,117L,682L,3975L,23168L,135033L,787030L,4587147L,26735852L,155827965L,908231938L,5293563663L,30853150040L,179825336577L,1048098869422L,6108767879955L,35604508410308L,207518282581893L,1209505187081050L,7049512839904407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275796Inst : IEnumerable<long>
{
public static readonly long[] Value=A275796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275796.Bytes);
public long this[int i]=>Value[i];

public static A275796Inst Instance=new A275796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275797
{
public static readonly long[] Value={ 9L,11L,21L,43L,57L,119L,249L,331L,693L,1451L,1929L,4039L,8457L,11243L,23541L,49291L,65529L,137207L,287289L,381931L,799701L,1674443L,2226057L,4660999L,9759369L,12974411L,27166293L,56881771L,75620409L,158336759L,331531257L,440748043L,922854261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275797Inst : IEnumerable<long>
{
public static readonly long[] Value=A275797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275797.Bytes);
public long this[int i]=>Value[i];

public static A275797Inst Instance=new A275797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275798
{
public static readonly BigInteger[] Value={ 1L,3L,51L,4274L,2105872L,4295278656L,35184441295872L,1152921514002096128L,BigInteger.Parse("151115727460762179076096"),BigInteger.Parse("79228162514269052299408048128") };
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
public class A275798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275798Inst Instance=new A275798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275799
{
public static readonly long[] Value={ 1L,22L,140L,578L,1785L,4612L,10416L,21340L,40425L,72010L,121836L,197582L,308945L,468328L,690880L,995352L,1404081L,1944030L,2646700L,3549370L,4694921L,6133292L,7921200L,10123828L,12814425L,16076242L,20001996L,24696070L,30273825L,36864080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275799Inst : IEnumerable<long>
{
public static readonly long[] Value=A275799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275799.Bytes);
public long this[int i]=>Value[i];

public static A275799Inst Instance=new A275799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275800
{
public static readonly long[] Value={ 5L,13L,17L,139L,173L,179L,467L,907L,1553L,1619L,1867L,2099L,2819L,2957L,3203L,3779L,3947L,4139L,4157L,4283L,4547L,4723L,5483L,6653L,6899L,7013L,7187L,7523L,7643L,8147L,8387L,8563L,8573L,8753L,9533L,9587L,10589L,10853L,10883L,10979L,11003L,12107L,12227L,13037L,13229L,13829L,14243L,14549L,14699L,14867L,15299L,16217L,16547L,16649L,17387L,18443L,18587L,19259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275800Inst : IEnumerable<long>
{
public static readonly long[] Value=A275800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275800.Bytes);
public long this[int i]=>Value[i];

public static A275800Inst Instance=new A275800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275801
{
public static readonly BigInteger[] Value={ 1L,0L,1L,4L,53L,936L,25325L,933980L,45504649L,2824517520L,217690037497L,20394614883316L,2282650939846781L,300814135522967736L,BigInteger.Parse("46103574973075123877"),BigInteger.Parse("8130996533576437261772"),BigInteger.Parse("1635028654501420083152785"),BigInteger.Parse("371853339350614571322913824"),BigInteger.Parse("94969025880924845123887493233") };
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
public class A275801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275801Inst Instance=new A275801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275802
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,16L,19L,28L,37L,41L,44L,53L,311L,490L,1252L,4360L,4732L,5575L,6833L,8878L,11171L,11396L,13079L,14903L,76615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275802Inst : IEnumerable<long>
{
public static readonly long[] Value=A275802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275802.Bytes);
public long this[int i]=>Value[i];

public static A275802Inst Instance=new A275802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275803
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,2L,2L,3L,4L,3L,4L,2L,3L,3L,4L,2L,4L,2L,3L,2L,4L,3L,4L,2L,2L,2L,3L,2L,3L,3L,3L,4L,5L,4L,5L,3L,4L,4L,5L,3L,5L,3L,4L,3L,5L,4L,5L,2L,2L,3L,4L,3L,4L,3L,3L,4L,5L,4L,5L,2L,3L,4L,5L,3L,5L,2L,3L,3L,5L,4L,5L,2L,3L,3L,4L,2L,4L,2L,3L,4L,5L,3L,5L,3L,4L,4L,5L,3L,5L,2L,4L,3L,5L,3L,5L,2L,3L,2L,4L,3L,4L,2L,3L,3L,5L,4L,5L,2L,4L,3L,5L,3L,5L,3L,4L,3L,5L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275803Inst : IEnumerable<long>
{
public static readonly long[] Value=A275803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275803.Bytes);
public long this[int i]=>Value[i];

public static A275803Inst Instance=new A275803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275804
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,16L,18L,20L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,36L,37L,40L,42L,44L,48L,49L,50L,51L,52L,60L,61L,64L,66L,68L,72L,73L,76L,78L,79L,82L,90L,96L,98L,102L,104L,108L,120L,121L,122L,123L,124L,126L,127L,128L,129L,130L,132L,133L,136L,138L,140L,144L,145L,146L,147L,148L,150L,151L,152L,153L,154L,156L,157L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275804Inst : IEnumerable<long>
{
public static readonly long[] Value=A275804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275804.Bytes);
public long this[int i]=>Value[i];

public static A275804Inst Instance=new A275804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275805
{
public static readonly long[] Value={ 5L,11L,14L,15L,17L,19L,21L,22L,23L,29L,35L,38L,39L,41L,43L,45L,46L,47L,53L,54L,55L,56L,57L,58L,59L,62L,63L,65L,67L,69L,70L,71L,74L,75L,77L,80L,81L,83L,84L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,97L,99L,100L,101L,103L,105L,106L,107L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,125L,131L,134L,135L,137L,139L,141L,142L,143L,149L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275805Inst : IEnumerable<long>
{
public static readonly long[] Value=A275805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275805.Bytes);
public long this[int i]=>Value[i];

public static A275805Inst Instance=new A275805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275806
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,3L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,2L,3L,2L,3L,3L,3L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275806Inst : IEnumerable<long>
{
public static readonly long[] Value=A275806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275806.Bytes);
public long this[int i]=>Value[i];

public static A275806Inst Instance=new A275806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275807
{
public static readonly long[] Value={ 1L,2L,9L,4L,6L,4L,75L,50L,27L,8L,12L,8L,45L,20L,27L,8L,18L,8L,30L,20L,18L,8L,12L,8L,735L,490L,441L,196L,294L,196L,375L,250L,81L,16L,24L,16L,135L,40L,81L,16L,54L,16L,60L,40L,36L,16L,24L,16L,525L,350L,189L,56L,84L,56L,375L,250L,81L,16L,24L,16L,225L,100L,81L,16L,36L,16L,150L,100L,54L,16L,24L,16L,315L,140L,189L,56L,126L,56L,225L,100L,81L,16L,36L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275807Inst : IEnumerable<long>
{
public static readonly long[] Value=A275807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275807.Bytes);
public long this[int i]=>Value[i];

public static A275807Inst Instance=new A275807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275808
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,0L,4L,5L,6L,7L,5L,4L,2L,3L,0L,1L,3L,2L,1L,0L,3L,2L,0L,1L,8L,9L,10L,11L,9L,8L,12L,13L,14L,15L,13L,12L,10L,11L,8L,9L,11L,10L,9L,8L,11L,10L,8L,9L,4L,5L,6L,7L,5L,4L,0L,1L,2L,3L,1L,0L,6L,7L,4L,5L,7L,6L,5L,4L,7L,6L,4L,5L,2L,3L,0L,1L,3L,2L,6L,7L,4L,5L,7L,6L,0L,1L,2L,3L,1L,0L,3L,2L,1L,0L,2L,3L,1L,0L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275808Inst : IEnumerable<long>
{
public static readonly long[] Value=A275808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275808.Bytes);
public long this[int i]=>Value[i];

public static A275808Inst Instance=new A275808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275809
{
public static readonly long[] Value={ 0L,5L,14L,19L,22L,54L,59L,74L,84L,89L,93L,97L,100L,111L,114L,119L,264L,269L,278L,283L,286L,366L,371L,408L,413L,422L,427L,430L,440L,463L,466L,482L,492L,497L,501L,536L,552L,557L,566L,571L,574L,579L,589L,592L,596L,601L,604L,615L,618L,623L,655L,658L,675L,685L,688L,692L,696L,701L,710L,715L,718L,1560L,1565L,1574L,1579L,1582L,1614L,1619L,1634L,1644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275809Inst : IEnumerable<long>
{
public static readonly long[] Value=A275809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275809.Bytes);
public long this[int i]=>Value[i];

public static A275809Inst Instance=new A275809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275810
{
public static readonly long[] Value={ 5L,9L,5L,3L,32L,5L,15L,10L,5L,4L,4L,3L,11L,3L,5L,145L,5L,9L,5L,3L,80L,5L,37L,5L,9L,5L,3L,10L,23L,3L,16L,10L,5L,4L,35L,16L,5L,9L,5L,3L,5L,10L,3L,4L,5L,3L,11L,3L,5L,32L,3L,17L,10L,3L,4L,4L,5L,9L,5L,3L,842L,5L,9L,5L,3L,32L,5L,15L,10L,5L,4L,4L,3L,11L,3L,5L,505L,5L,9L,5L,3L,194L,5L,9L,5L,3L,32L,5L,15L,10L,5L,4L,4L,3L,11L,3L,5L,31L,5L,111L,10L,5L,4L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275810Inst : IEnumerable<long>
{
public static readonly long[] Value=A275810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275810.Bytes);
public long this[int i]=>Value[i];

public static A275810Inst Instance=new A275810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275811
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,3L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,3L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,3L,3L,2L,2L,1L,2L,2L,2L,2L,3L,1L,2L,1L,2L,2L,3L,1L,2L,1L,2L,2L,3L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275811Inst : IEnumerable<long>
{
public static readonly long[] Value=A275811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275811.Bytes);
public long this[int i]=>Value[i];

public static A275811Inst Instance=new A275811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275812
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,0L,3L,2L,0L,0L,2L,0L,0L,0L,4L,0L,2L,0L,2L,0L,0L,0L,3L,2L,0L,3L,2L,0L,0L,0L,5L,0L,0L,0L,4L,0L,0L,0L,3L,0L,0L,0L,2L,2L,0L,0L,4L,2L,2L,0L,2L,0L,3L,0L,3L,0L,0L,0L,2L,0L,0L,2L,6L,0L,0L,0L,2L,0L,0L,0L,5L,0L,0L,2L,2L,0L,0L,0L,4L,4L,0L,0L,2L,0L,0L,0L,3L,0L,2L,0L,2L,0L,0L,0L,5L,0L,2L,2L,4L,0L,0L,0L,3L,0L,0L,0L,5L,0L,0L,0L,4L,0L,0L,0L,2L,2L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275812Inst : IEnumerable<long>
{
public static readonly long[] Value=A275812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275812.Bytes);
public long this[int i]=>Value[i];

public static A275812Inst Instance=new A275812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275813
{
public static readonly long[] Value={ 0L,3L,5L,8L,10L,13L,14L,19L,22L,30L,33L,35L,36L,39L,41L,42L,45L,47L,50L,52L,54L,57L,59L,63L,65L,69L,71L,73L,74L,81L,83L,84L,87L,89L,93L,95L,97L,100L,105L,107L,111L,113L,114L,117L,119L,144L,147L,149L,152L,154L,157L,158L,163L,166L,168L,171L,173L,176L,178L,181L,182L,187L,190L,192L,195L,197L,200L,202L,205L,206L,211L,214L,216L,219L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275813Inst : IEnumerable<long>
{
public static readonly long[] Value=A275813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275813.Bytes);
public long this[int i]=>Value[i];

public static A275813Inst Instance=new A275813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275814
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,11L,12L,15L,16L,17L,18L,20L,21L,23L,24L,25L,26L,27L,28L,29L,31L,32L,34L,37L,38L,40L,43L,44L,46L,48L,49L,51L,53L,55L,56L,58L,60L,61L,62L,64L,66L,67L,68L,70L,72L,75L,76L,77L,78L,79L,80L,82L,85L,86L,88L,90L,91L,92L,94L,96L,98L,99L,101L,102L,103L,104L,106L,108L,109L,110L,112L,115L,116L,118L,120L,121L,122L,123L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275814Inst : IEnumerable<long>
{
public static readonly long[] Value=A275814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275814.Bytes);
public long this[int i]=>Value[i];

public static A275814Inst Instance=new A275814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275815
{
public static readonly long[] Value={ 0L,4L,17L,40L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275815Inst : IEnumerable<long>
{
public static readonly long[] Value=A275815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275815.Bytes);
public long this[int i]=>Value[i];

public static A275815Inst Instance=new A275815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275816
{
public static readonly long[] Value={ 2L,4L,8L,16L,32L,64L,128L,256L,432L,1024L,864L,4096L,1728L,2592L,3456L,65536L,6912L,262144L,10368L,14400L,27648L,4194304L,21600L,32400L,110592L,50400L,43200L,268435456L,64800L,1073741824L,86400L,230400L,1769472L,129600L,151200L,68719476736L,7077888L,921600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275816Inst : IEnumerable<long>
{
public static readonly long[] Value=A275816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275816.Bytes);
public long this[int i]=>Value[i];

public static A275816Inst Instance=new A275816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275817
{
public static readonly long[] Value={ 2L,3L,2L,4L,5L,3L,2L,3L,6L,7L,4L,3L,2L,3L,4L,8L,9L,5L,3L,5L,2L,3L,4L,5L,10L,11L,6L,4L,3L,5L,2L,5L,3L,4L,6L,12L,13L,7L,5L,4L,3L,7L,2L,5L,3L,4L,5L,7L,14L,15L,8L,5L,4L,3L,5L,7L,2L,5L,3L,7L,4L,6L,8L,16L,17L,9L,6L,5L,4L,3L,5L,7L,2L,5L,8L,3L,4L,5L,6L,9L,18L,19L,10L,7L,5L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275817Inst : IEnumerable<long>
{
public static readonly long[] Value=A275817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275817.Bytes);
public long this[int i]=>Value[i];

public static A275817Inst Instance=new A275817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275818
{
public static readonly long[] Value={ 1L,4L,3L,7L,11L,7L,5L,8L,17L,22L,13L,10L,7L,11L,15L,31L,37L,21L,13L,22L,9L,14L,19L,24L,49L,56L,31L,21L,16L,27L,11L,28L,17L,23L,35L,71L,79L,43L,31L,25L,19L,45L,13L,33L,20L,27L,34L,48L,97L,106L,57L,36L,29L,22L,37L,52L,15L,38L,23L,54L,31L,47L,63L,127L,137L,73L,49L,41L,33L,25L,42L,59L,17L,43L,69L,26L,35L,44L,53L,80L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275818Inst : IEnumerable<long>
{
public static readonly long[] Value=A275818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275818.Bytes);
public long this[int i]=>Value[i];

public static A275818Inst Instance=new A275818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275819
{
public static readonly long[] Value={ 2L,60L,210L,2160L,1260L,77760L,4620L,12600L,18480L,3456000L,27720L,4730880L,302400L,453600L,120120L,1990656000L,180180L,1238630400L,997920L,1108800L,10644480L,1146617856000L,720720L,2494800L,70963200L,3880800L,2882880L,11415217766400L,5821200L,18602577100800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275819Inst : IEnumerable<long>
{
public static readonly long[] Value=A275819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275819.Bytes);
public long this[int i]=>Value[i];

public static A275819Inst Instance=new A275819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275820
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,3L,1L,3L,3L,3L,2L,7L,3L,8L,7L,10L,7L,16L,8L,17L,17L,21L,17L,35L,22L,37L,36L,46L,37L,69L,46L,74L,71L,91L,81L,128L,96L,144L,139L,173L,154L,236L,185L,263L,257L,314L,286L,417L,345L,470L,462L,557L,517L,719L,617L,815L,802L,960L,904L,1211L,1068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275820Inst : IEnumerable<long>
{
public static readonly long[] Value=A275820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275820.Bytes);
public long this[int i]=>Value[i];

public static A275820Inst Instance=new A275820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275821
{
public static readonly long[] Value={ 1L,0L,1L,-1L,1L,0L,1L,-1L,1L,-1L,3L,-2L,3L,-3L,2L,-1L,4L,-3L,4L,-4L,7L,-7L,7L,-7L,9L,-6L,11L,-10L,10L,-11L,15L,-14L,18L,-19L,21L,-17L,24L,-22L,26L,-29L,35L,-34L,42L,-43L,43L,-39L,52L,-52L,59L,-59L,74L,-72L,79L,-87L,93L,-87L,107L,-108L,118L,-126L,149L,-146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275821Inst : IEnumerable<long>
{
public static readonly long[] Value=A275821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275821.Bytes);
public long this[int i]=>Value[i];

public static A275821Inst Instance=new A275821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275822
{
public static readonly BigInteger[] Value={ 1L,7L,209L,7791L,335209L,15667799L,773221225L,39651016343L,2092095886657L,112840936041343L,6193764391911873L,344853399798469695L,BigInteger.Parse("19429178297906958721"),BigInteger.Parse("1105629520934309041279"),BigInteger.Parse("63455683531507986958721"),BigInteger.Parse("3668895994183490904049279") };
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
public class A275822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275822Inst Instance=new A275822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275823
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,4L,9L,5L,11L,6L,13L,7L,15L,8L,17L,9L,19L,5L,7L,11L,23L,12L,25L,13L,9L,14L,29L,15L,31L,8L,33L,17L,35L,18L,37L,19L,13L,10L,41L,7L,43L,22L,45L,23L,47L,12L,49L,25L,51L,13L,53L,9L,11L,28L,19L,29L,59L,15L,61L,31L,21L,16L,65L,33L,67L,17L,69L,35L,71L,36L,73L,37L,75L,38L,77L,13L,79L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275823Inst : IEnumerable<long>
{
public static readonly long[] Value=A275823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275823.Bytes);
public long this[int i]=>Value[i];

public static A275823Inst Instance=new A275823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275824
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,3L,3L,2L,3L,2L,3L,1L,1L,2L,1L,3L,2L,6L,4L,3L,4L,2L,3L,2L,2L,3L,1L,5L,4L,4L,5L,4L,4L,1L,3L,3L,1L,3L,5L,7L,6L,4L,5L,3L,5L,3L,3L,4L,4L,5L,4L,6L,7L,3L,5L,4L,4L,3L,2L,6L,3L,6L,5L,5L,7L,7L,7L,3L,6L,7L,5L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275824Inst : IEnumerable<long>
{
public static readonly long[] Value=A275824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275824.Bytes);
public long this[int i]=>Value[i];

public static A275824Inst Instance=new A275824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275825
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,5L,14L,52L,238L,1288L,8144L,59150L,486080L,4464304L,45352840L,505200280L,6124903616L,80304039608L,1132339758992L,17089219746352L,274872988654576L,4694355262548640L,84840179120802560L,1617735736056994736L,BigInteger.Parse("32457990536915964800"),BigInteger.Parse("683569125395013719680") };
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
public class A275825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275825Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275825.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275825Inst Instance=new A275825Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275826
{
public static readonly long[] Value={ 1L,2L,6L,8L,20L,20L,28L,36L,36L,56L,90L,90L,120L,126L,126L,126L,172L,172L,342L,342L,374L,380L,464L,464L,464L,464L,464L,464L,464L,464L,847L,847L,1056L,1105L,1105L,1105L,1105L,1105L,1330L,1330L,1728L,1728L,1728L,1728L,1728L,2410L,2856L,2856L,2856L,2856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275826Inst : IEnumerable<long>
{
public static readonly long[] Value=A275826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275826.Bytes);
public long this[int i]=>Value[i];

public static A275826Inst Instance=new A275826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275827
{
public static readonly long[] Value={ 1L,7L,50L,364L,2688L,20064L,151008L,1144000L,8712704L,66646528L,511673344L,3940579328L,30429184000L,235521884160L,1826663915520L,14192851599360L,110453212446720L,860819570688000L,6717522904350720L,52482715893104640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275827Inst : IEnumerable<long>
{
public static readonly long[] Value=A275827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275827.Bytes);
public long this[int i]=>Value[i];

public static A275827Inst Instance=new A275827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275828
{
public static readonly long[] Value={ 1L,8L,6L,6L,7L,6L,0L,3L,9L,9L,1L,7L,3L,8L,6L,2L,0L,9L,2L,9L,9L,0L,8L,7L,2L,0L,6L,2L,4L,9L,6L,4L,6L,3L,6L,4L,2L,1L,9L,2L,2L,1L,8L,8L,2L,6L,7L,0L,5L,7L,6L,1L,3L,4L,8L,8L,3L,5L,5L,3L,0L,8L,1L,2L,9L,0L,4L,9L,0L,8L,0L,7L,0L,1L,2L,1L,6L,6L,8L,7L,2L,7L,0L,5L,2L,8L,4L,2L,7L,1L,6L,8L,5L,7L,3L,4L,2L,1L,5L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275828Inst : IEnumerable<long>
{
public static readonly long[] Value=A275828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275828.Bytes);
public long this[int i]=>Value[i];

public static A275828Inst Instance=new A275828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275829
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,140L,2564L,68728L,2539632L,123686800L,7677924688L,591741636128L,55438330474944L,6204888219697856L,817697605612952384L,BigInteger.Parse("125322509904814743424"),BigInteger.Parse("22102340129003429880576"),BigInteger.Parse("4444468680409243484516608"),BigInteger.Parse("1010802175212828388101900544"),BigInteger.Parse("258152577318424951261637001728") };
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
public class A275829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275829Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275829.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275829Inst Instance=new A275829Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275830
{
public static readonly long[] Value={ 3L,-7L,49L,-196L,1029L,-4802L,24010L,-117649L,588245L,-2941225L,14823774L,-74942413L,380476866L,-1936973136L,9886633715L,-50563069571L,259029803333L,-1328763571296L,6823754590093L,-35073821767334L,180407337377834L,-928487386730281L,4780794440512601L,-24625601552074341L,126883328914736618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275830Inst : IEnumerable<long>
{
public static readonly long[] Value=A275830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275830.Bytes);
public long this[int i]=>Value[i];

public static A275830Inst Instance=new A275830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275831
{
public static readonly long[] Value={ 3L,0L,14L,21L,98L,245L,833L,2401L,7546L,22638L,69629L,211288L,645869L,1966419L,6000099L,18286016L,55765626L,170002805L,518361494L,1580379017L,4818550093L,14691183577L,44792503770L,136568135690L,416385811429L,1269524476220L,3870677629833L,11801372013543L,35981414742371L,109704347503632L,334479507291398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275831Inst : IEnumerable<long>
{
public static readonly long[] Value=A275831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275831.Bytes);
public long this[int i]=>Value[i];

public static A275831Inst Instance=new A275831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275832
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,1L,2L,1L,4L,3L,4L,1L,3L,1L,4L,2L,4L,2L,3L,2L,4L,3L,4L,1L,2L,1L,3L,2L,3L,1L,2L,1L,5L,4L,5L,1L,4L,1L,5L,2L,5L,3L,4L,3L,5L,4L,5L,1L,2L,1L,4L,3L,4L,1L,2L,1L,5L,4L,5L,1L,3L,1L,5L,3L,5L,2L,3L,2L,5L,4L,5L,1L,3L,1L,4L,2L,4L,1L,3L,1L,5L,3L,5L,1L,4L,1L,5L,2L,5L,2L,4L,2L,5L,3L,5L,2L,3L,2L,4L,3L,4L,2L,3L,2L,5L,4L,5L,2L,4L,2L,5L,3L,5L,3L,4L,3L,5L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275832Inst : IEnumerable<long>
{
public static readonly long[] Value=A275832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275832.Bytes);
public long this[int i]=>Value[i];

public static A275832Inst Instance=new A275832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275833
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,10L,12L,13L,14L,19L,22L,24L,26L,27L,29L,30L,32L,33L,35L,36L,38L,39L,41L,42L,44L,45L,47L,48L,50L,52L,54L,56L,57L,59L,60L,61L,62L,63L,64L,65L,67L,69L,71L,72L,73L,74L,78L,79L,80L,81L,82L,83L,84L,86L,87L,89L,93L,94L,95L,97L,100L,103L,105L,107L,111L,112L,113L,114L,116L,117L,119L,120L,122L,123L,125L,126L,128L,130L,132L,133L,134L,139L,142L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275833Inst : IEnumerable<long>
{
public static readonly long[] Value=A275833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275833.Bytes);
public long this[int i]=>Value[i];

public static A275833Inst Instance=new A275833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275834
{
public static readonly long[] Value={ 1L,4L,7L,9L,11L,15L,16L,17L,18L,20L,21L,23L,25L,28L,31L,34L,37L,40L,43L,46L,49L,51L,53L,55L,58L,66L,68L,70L,75L,76L,77L,85L,88L,90L,91L,92L,96L,98L,99L,101L,102L,104L,106L,108L,109L,110L,115L,118L,121L,124L,127L,129L,131L,135L,136L,137L,138L,140L,141L,143L,145L,148L,151L,153L,155L,159L,160L,161L,162L,164L,165L,167L,169L,172L,175L,177L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275834Inst : IEnumerable<long>
{
public static readonly long[] Value=A275834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275834.Bytes);
public long this[int i]=>Value[i];

public static A275834Inst Instance=new A275834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275835
{
public static readonly long[] Value={ 0L,1L,6L,3L,4L,2L,56L,20L,36L,17L,21L,9L,48L,15L,30L,13L,16L,7L,18L,8L,24L,10L,12L,5L,495L,135L,74L,31L,132L,53L,582L,401L,147L,59L,157L,158L,361L,116L,216L,173L,117L,47L,136L,155L,380L,46L,78L,82L,420L,111L,61L,25L,108L,45L,490L,347L,123L,51L,133L,134L,312L,93L,192L,149L,94L,41L,112L,131L,327L,40L,64L,68L,360L,270L,80L,38L,88L,89L,416L,303L,99L,44L,109L,110L,288L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275835Inst : IEnumerable<long>
{
public static readonly long[] Value=A275835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275835.Bytes);
public long this[int i]=>Value[i];

public static A275835Inst Instance=new A275835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275836
{
public static readonly long[] Value={ 0L,1L,5L,3L,4L,23L,2L,17L,19L,11L,21L,99L,22L,15L,111L,13L,16L,9L,18L,95L,7L,10L,118L,119L,20L,51L,101L,98L,106L,107L,14L,27L,113L,110L,85L,89L,8L,623L,75L,91L,69L,65L,115L,707L,81L,53L,45L,41L,12L,103L,659L,57L,94L,29L,615L,611L,6L,93L,579L,33L,100L,50L,603L,695L,70L,689L,112L,97L,71L,507L,616L,719L,114L,109L,26L,711L,88L,647L,46L,641L,74L,117L,47L,441L,688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275836Inst : IEnumerable<long>
{
public static readonly long[] Value=A275836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275836.Bytes);
public long this[int i]=>Value[i];

public static A275836Inst Instance=new A275836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275837
{
public static readonly long[] Value={ 0L,1L,2L,4L,18L,5L,6L,22L,12L,3L,96L,20L,72L,17L,14L,19L,114L,13L,94L,10L,11L,23L,108L,15L,24L,79L,84L,100L,101L,21L,48L,102L,8L,9L,600L,71L,480L,49L,78L,118L,119L,16L,65L,73L,98L,99L,696L,27L,360L,594L,62L,63L,70L,112L,54L,113L,74L,7L,45L,95L,552L,116L,50L,117L,672L,603L,454L,569L,37L,40L,29L,106L,444L,41L,36L,107L,85L,97L,38L,621L,86L,82L,545L,110L,528L,59L,56L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275837Inst : IEnumerable<long>
{
public static readonly long[] Value=A275837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275837.Bytes);
public long this[int i]=>Value[i];

public static A275837Inst Instance=new A275837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275838
{
public static readonly long[] Value={ 0L,1L,2L,9L,3L,5L,6L,57L,32L,33L,19L,20L,8L,17L,14L,23L,41L,13L,4L,15L,11L,29L,7L,21L,24L,133L,272L,47L,293L,70L,150L,263L,152L,357L,109L,110L,74L,68L,78L,163L,69L,73L,135L,545L,249L,58L,230L,220L,30L,37L,62L,225L,100L,161L,54L,127L,86L,285L,209L,85L,182L,172L,50L,51L,197L,42L,104L,231L,105L,431L,52L,35L,12L,43L,56L,99L,213L,95L,38L,25L,134L,153L,81L,341L,26L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275838Inst : IEnumerable<long>
{
public static readonly long[] Value=A275838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275838.Bytes);
public long this[int i]=>Value[i];

public static A275838Inst Instance=new A275838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275839
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,14L,24L,54L,120L,145L,264L,411L,464L,720L,842L,1560L,2042L,2408L,2670L,5040L,5766L,10800L,13686L,16590L,18144L,40320L,45384L,85680L,105864L,106153L,131184L,141960L,145728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275839Inst : IEnumerable<long>
{
public static readonly long[] Value=A275839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275839.Bytes);
public long this[int i]=>Value[i];

public static A275839Inst Instance=new A275839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275840
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,2L,2L,2L,3L,4L,3L,3L,3L,2L,1L,1L,1L,0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,8L,8L,8L,9L,10L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,9L,9L,10L,10L,9L,9L,10L,10L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,9L,9L,9L,8L,7L,7L,7L,6L,5L,5L,5L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,2L,1L,1L,1L,0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275840Inst : IEnumerable<long>
{
public static readonly long[] Value=A275840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275840.Bytes);
public long this[int i]=>Value[i];

public static A275840Inst Instance=new A275840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275841
{
public static readonly long[] Value={ 0L,2L,12L,3L,16L,1L,72L,14L,11L,13L,90L,8L,70L,6L,7L,17L,84L,9L,58L,76L,77L,15L,78L,5L,480L,53L,36L,94L,95L,10L,47L,54L,74L,75L,576L,19L,474L,45L,52L,88L,89L,4L,33L,71L,92L,93L,552L,483L,358L,449L,26L,28L,21L,82L,29L,83L,62L,73L,501L,60L,431L,86L,43L,87L,528L,579L,206L,417L,493L,496L,485L,57L,203L,497L,492L,55L,38L,91L,494L,597L,48L,50L,294L,80L,288L,24L,25L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275841Inst : IEnumerable<long>
{
public static readonly long[] Value=A275841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275841.Bytes);
public long this[int i]=>Value[i];

public static A275841Inst Instance=new A275841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275842
{
public static readonly long[] Value={ 0L,5L,1L,3L,41L,23L,13L,14L,11L,17L,29L,8L,2L,9L,7L,21L,4L,15L,104L,35L,231L,52L,209L,285L,85L,86L,50L,127L,51L,54L,105L,431L,197L,42L,182L,172L,26L,177L,76L,125L,100L,225L,161L,62L,134L,37L,153L,30L,80L,183L,81L,341L,38L,25L,31L,75L,165L,71L,18L,119L,59L,269L,56L,141L,99L,137L,107L,111L,213L,95L,12L,43L,6L,57L,32L,33L,19L,20L,22L,129L,83L,87L,53L,55L,16L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275842Inst : IEnumerable<long>
{
public static readonly long[] Value=A275842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275842.Bytes);
public long this[int i]=>Value[i];

public static A275842Inst Instance=new A275842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275843
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,12L,23L,33L,53L,71L,75L,81L,119L,153L,252L,360L,361L,372L,492L,719L,873L,1493L,1511L,2183L,2231L,2279L,2879L,2889L,2913L,2961L,3033L,3675L,3681L,5039L,5913L,10332L,15195L,15201L,18081L,18795L,18801L,20160L,20161L,20163L,20165L,20213L,20235L,20520L,20521L,21653L,23835L,25253L,25271L,26693L,26711L,27431L,30732L,40319L,46233L,82133L,82151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275843Inst : IEnumerable<long>
{
public static readonly long[] Value=A275843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275843.Bytes);
public long this[int i]=>Value[i];

public static A275843Inst Instance=new A275843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275844
{
public static readonly long[] Value={ 2L,4L,6L,7L,8L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275844Inst : IEnumerable<long>
{
public static readonly long[] Value=A275844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275844.Bytes);
public long this[int i]=>Value[i];

public static A275844Inst Instance=new A275844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275845
{
public static readonly long[] Value={ 0L,1L,4L,2L,6L,3L,12L,8L,16L,5L,15L,10L,18L,21L,22L,7L,20L,13L,24L,27L,28L,9L,26L,17L,48L,30L,52L,33L,34L,11L,60L,32L,64L,23L,56L,36L,66L,61L,70L,39L,40L,14L,73L,38L,78L,29L,67L,42L,72L,80L,76L,74L,85L,45L,84L,46L,88L,19L,89L,44L,90L,97L,94L,35L,81L,49L,87L,99L,93L,91L,105L,53L,96L,104L,100L,54L,109L,25L,108L,110L,112L,51L,111L,121L,114L,117L,118L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275845Inst : IEnumerable<long>
{
public static readonly long[] Value=A275845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275845.Bytes);
public long this[int i]=>Value[i];

public static A275845Inst Instance=new A275845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275846
{
public static readonly long[] Value={ 0L,1L,3L,5L,2L,9L,4L,15L,7L,21L,11L,29L,6L,17L,41L,10L,8L,23L,12L,57L,16L,13L,14L,33L,18L,77L,22L,19L,20L,45L,25L,101L,31L,27L,28L,63L,35L,129L,43L,39L,40L,87L,47L,165L,59L,53L,55L,111L,24L,65L,213L,81L,26L,71L,75L,141L,34L,89L,269L,105L,30L,37L,95L,99L,32L,183L,36L,46L,113L,341L,38L,135L,48L,42L,51L,119L,50L,125L,44L,231L,49L,64L,143L,431L,54L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275846Inst : IEnumerable<long>
{
public static readonly long[] Value=A275846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275846.Bytes);
public long this[int i]=>Value[i];

public static A275846Inst Instance=new A275846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275847
{
public static readonly long[] Value={ 0L,1L,4L,2L,3L,5L,18L,6L,12L,7L,8L,9L,16L,10L,22L,11L,13L,14L,15L,17L,19L,20L,21L,23L,96L,24L,48L,25L,26L,27L,72L,28L,52L,29L,30L,31L,60L,32L,64L,33L,34L,35L,36L,37L,38L,39L,40L,41L,90L,42L,66L,43L,44L,45L,114L,46L,70L,47L,49L,50L,76L,51L,84L,53L,54L,55L,56L,57L,58L,59L,61L,62L,88L,63L,94L,65L,67L,68L,100L,69L,108L,71L,73L,74L,112L,75L,118L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275847Inst : IEnumerable<long>
{
public static readonly long[] Value=A275847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275847.Bytes);
public long this[int i]=>Value[i];

public static A275847Inst Instance=new A275847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275848
{
public static readonly long[] Value={ 0L,1L,3L,4L,2L,5L,7L,9L,10L,11L,13L,15L,8L,16L,17L,18L,12L,19L,6L,20L,21L,22L,14L,23L,25L,27L,28L,29L,31L,33L,34L,35L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,51L,52L,53L,55L,57L,26L,58L,59L,61L,32L,63L,64L,65L,66L,67L,68L,69L,36L,70L,71L,73L,38L,75L,50L,76L,77L,79L,56L,81L,30L,82L,83L,85L,60L,87L,88L,89L,90L,91L,92L,93L,62L,94L,95L,96L,72L,97L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275848Inst : IEnumerable<long>
{
public static readonly long[] Value=A275848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275848.Bytes);
public long this[int i]=>Value[i];

public static A275848Inst Instance=new A275848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275849
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,2L,1L,1L,0L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,2L,2L,1L,2L,2L,2L,1L,1L,0L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,2L,2L,1L,2L,2L,3L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,2L,3L,2L,2L,2L,2L,1L,2L,1L,1L,1L,3L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275849Inst : IEnumerable<long>
{
public static readonly long[] Value=A275849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275849.Bytes);
public long this[int i]=>Value[i];

public static A275849Inst Instance=new A275849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275850
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,0L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,0L,3L,3L,3L,3L,2L,2L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,3L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,3L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275850Inst : IEnumerable<long>
{
public static readonly long[] Value=A275850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275850.Bytes);
public long this[int i]=>Value[i];

public static A275850Inst Instance=new A275850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275851
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,1L,1L,0L,0L,0L,2L,1L,0L,0L,1L,0L,3L,1L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,1L,1L,0L,0L,0L,2L,1L,0L,0L,1L,0L,3L,1L,2L,1L,2L,1L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,3L,2L,2L,1L,1L,1L,1L,0L,1L,0L,0L,0L,2L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,3L,2L,1L,1L,2L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,2L,1L,0L,0L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275851Inst : IEnumerable<long>
{
public static readonly long[] Value=A275851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275851.Bytes);
public long this[int i]=>Value[i];

public static A275851Inst Instance=new A275851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275852
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,15L,16L,17L,20L,21L,23L,27L,29L,31L,33L,35L,39L,40L,41L,44L,45L,47L,55L,57L,59L,61L,63L,64L,65L,67L,68L,69L,71L,79L,81L,82L,83L,87L,88L,89L,92L,93L,94L,95L,103L,104L,105L,107L,110L,111L,112L,113L,116L,117L,119L,127L,129L,131L,135L,136L,137L,140L,141L,143L,147L,149L,151L,153L,155L,159L,160L,161L,164L,165L,167L,175L,177L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275852Inst : IEnumerable<long>
{
public static readonly long[] Value=A275852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275852.Bytes);
public long this[int i]=>Value[i];

public static A275852Inst Instance=new A275852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275853
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,1L,4L,3L,3L,3L,3L,2L,4L,3L,4L,4L,4L,3L,4L,4L,3L,3L,3L,3L,4L,3L,3L,3L,3L,2L,4L,3L,4L,4L,4L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,2L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,4L,3L,3L,3L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,2L,2L,3L,2L,2L,2L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275853Inst : IEnumerable<long>
{
public static readonly long[] Value=A275853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275853.Bytes);
public long this[int i]=>Value[i];

public static A275853Inst Instance=new A275853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275854
{
public static readonly BigInteger[] Value={ 1L,2L,16L,343L,14641L,1048576L,113379904L,17249876309L,3512479453921L,922190162669056L,303305489096114176L,BigInteger.Parse("122130132904968017083"),BigInteger.Parse("59091511031674153381441"),BigInteger.Parse("33825307664249166246182912"),BigInteger.Parse("22609039557544243501245546496"),BigInteger.Parse("17449402268886407318558803753801") };
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
public class A275854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275854Inst Instance=new A275854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275855
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275855Inst : IEnumerable<long>
{
public static readonly long[] Value=A275855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275855.Bytes);
public long this[int i]=>Value[i];

public static A275855Inst Instance=new A275855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275856
{
public static readonly long[] Value={ 1L,1L,3L,8L,24L,74L,231L,723L,2265L,7098L,22246L,69724L,218533L,684941L,2146791L,6728628L,21089356L,66099798L,207174811L,649342415L,2035216397L,6378923798L,19993288618L,62664424664L,196407414185L,615594454969L,1929441078187L,6047395073408L,18954187089376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275856Inst : IEnumerable<long>
{
public static readonly long[] Value=A275856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275856.Bytes);
public long this[int i]=>Value[i];

public static A275856Inst Instance=new A275856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275857
{
public static readonly long[] Value={ 1L,2L,6L,18L,56L,175L,548L,1717L,5381L,16865L,52859L,165674L,519267L,1627524L,5101104L,15988252L,50111546L,157063265L,492279150L,1542937247L,4835986551L,15157302067L,47507122597L,148900291588L,466694163381L,1462746914806L,4584648158602L,14369538930774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275857Inst : IEnumerable<long>
{
public static readonly long[] Value=A275857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275857.Bytes);
public long this[int i]=>Value[i];

public static A275857Inst Instance=new A275857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275858
{
public static readonly long[] Value={ 1L,1L,-1L,-4L,-4L,4L,17L,17L,-17L,-72L,-72L,72L,305L,305L,-305L,-1292L,-1292L,1292L,5473L,5473L,-5473L,-23184L,-23184L,23184L,98209L,98209L,-98209L,-416020L,-416020L,416020L,1762289L,1762289L,-1762289L,-7465176L,-7465176L,7465176L,31622993L,31622993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275858Inst : IEnumerable<long>
{
public static readonly long[] Value=A275858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275858.Bytes);
public long this[int i]=>Value[i];

public static A275858Inst Instance=new A275858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275859
{
public static readonly long[] Value={ 1L,1L,5L,19L,76L,304L,1220L,4898L,19667L,78971L,317103L,1273309L,5112902L,20530578L,82439414L,331030964L,1329236757L,5337477605L,21432349833L,86060430295L,345570957936L,1387621309348L,5571917587224L,22373730779190L,89840494074695L,360749597608127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275859Inst : IEnumerable<long>
{
public static readonly long[] Value=A275859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275859.Bytes);
public long this[int i]=>Value[i];

public static A275859Inst Instance=new A275859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275860
{
public static readonly long[] Value={ 1L,1L,7L,33L,164L,813L,4039L,20063L,99665L,495099L,2459470L,12217747L,60693301L,301502133L,1497752387L,7440286381L,36960623072L,183606865105L,912091791531L,4530938620963L,22508046862781L,111811749387479L,555439900107962L,2759222392297991L,13706808258965257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275860Inst : IEnumerable<long>
{
public static readonly long[] Value=A275860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275860.Bytes);
public long this[int i]=>Value[i];

public static A275860Inst Instance=new A275860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275861
{
public static readonly long[] Value={ 1L,1L,9L,51L,305L,1813L,10784L,64144L,381543L,2269503L,13499513L,80298135L,477631347L,2841058559L,16899254596L,100520563016L,597918892325L,3556555903317L,21155193548465L,125835844069155L,748499871500621L,4452245397810113L,26482955892270832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275861Inst : IEnumerable<long>
{
public static readonly long[] Value=A275861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275861.Bytes);
public long this[int i]=>Value[i];

public static A275861Inst Instance=new A275861Inst();

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