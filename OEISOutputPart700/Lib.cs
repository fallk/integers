using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A286826
{
public static readonly long[] Value={ 1L,1L,7L,7L,23L,31L,95L,127L,383L,511L,1535L,2047L,6143L,8191L,24575L,32767L,98303L,131071L,393215L,524287L,1572863L,2097151L,5996543L,8388607L,23199743L,33554431L,92798975L,134217727L,371195903L,536870911L,1505755135L,2147483647L,6014631935L,8539602943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286826Inst : IEnumerable<long>
{
public static readonly long[] Value=A286826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286826.Bytes);
public long this[int i]=>Value[i];

public static A286826Inst Instance=new A286826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286825
{
public static readonly long[] Value={ 1L,2L,7L,14L,29L,62L,125L,254L,509L,1022L,2045L,4094L,8189L,16382L,32765L,65534L,131069L,262142L,524285L,1048574L,2097149L,4194302L,8388461L,16777214L,33554189L,67108862L,134217485L,268435454L,536870669L,1073741822L,2147483341L,4294967294L,8589933773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286825Inst : IEnumerable<long>
{
public static readonly long[] Value=A286825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286825.Bytes);
public long this[int i]=>Value[i];

public static A286825Inst Instance=new A286825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286824
{
public static readonly long[] Value={ 1L,1L,111L,111L,10111L,11111L,1011111L,1111111L,101111111L,111111111L,10111111111L,11111111111L,1011111111111L,1111111111111L,101111111111111L,111111111111111L,10111111111111111L,11111111111111111L,1011111111111111111L,1111111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286824Inst : IEnumerable<long>
{
public static readonly long[] Value=A286824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286824.Bytes);
public long this[int i]=>Value[i];

public static A286824Inst Instance=new A286824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286823
{
public static readonly ulong[] Value={ 1L,10L,111L,1110L,11101L,111110L,1111101L,11111110L,111111101L,1111111110L,11111111101L,111111111110L,1111111111101L,11111111111110L,111111111111101L,1111111111111110L,11111111111111101L,111111111111111110L,1111111111111111101L,11111111111111111110UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286823Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286823.Bytes);
public ulong this[int i]=>Value[i];

public static A286823Inst Instance=new A286823Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286726
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286726Inst : IEnumerable<long>
{
public static readonly long[] Value=A286726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286726.Bytes);
public long this[int i]=>Value[i];

public static A286726Inst Instance=new A286726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286725
{
public static readonly BigInteger[] Value={ 1L,18L,288L,4800L,86400L,1693440L,36126720L,836075520L,20901888000L,562028544000L,16186422067200L,497364605337600L,16247243774361600L,562404592189440000L,BigInteger.Parse("20567939371499520000"),BigInteger.Parse("792551263781781504000"),BigInteger.Parse("32098326183162150912000"),BigInteger.Parse("1363234794367239585792000") };
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
public class A286725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286725Inst Instance=new A286725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286724
{
public static readonly long[] Value={ 1L,2L,1L,8L,8L,1L,48L,72L,18L,1L,384L,768L,288L,32L,1L,3840L,9600L,4800L,800L,50L,1L,46080L,138240L,86400L,19200L,1800L,72L,1L,645120L,2257920L,1693440L,470400L,58800L,3528L,98L,1L,10321920L,41287680L,36126720L,12042240L,1881600L,150528L,6272L,128L,1L,185794560L,836075520L,836075520L,325140480L,60963840L,6096384L,338688L,10368L,162L,1L,3715891200L,18579456000L,20901888000L,9289728000L,2032128000L,243855360L,16934400L,691200L,16200L,200L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286724Inst : IEnumerable<long>
{
public static readonly long[] Value=A286724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286724.Bytes);
public long this[int i]=>Value[i];

public static A286724Inst Instance=new A286724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286723
{
public static readonly BigInteger[] Value={ 1L,10L,131L,2196L,45189L,1105182L,31354119L,1012861224L,36717532425L,1476342400050L,65212709985675L,3139386801018300L,163605030141437325L,9176588125543758150L,BigInteger.Parse("551225830134140520975"),BigInteger.Parse("35305848011347321438800"),BigInteger.Parse("2401944921672748059294225"),BigInteger.Parse("172980447467901106243829850") };
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
public class A286723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286723Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286723.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286723Inst Instance=new A286723Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286722
{
public static readonly BigInteger[] Value={ 1L,15L,231L,4040L,80844L,1835988L,46819324L,1327098024L,41436870696L,1414064576672L,52383613213920L,2094099207620160L,89873259151044160L,4122137910567440640L,BigInteger.Parse("201246677825480820480"),BigInteger.Parse("10420702442559832716800"),BigInteger.Parse("570477791902749185318400"),BigInteger.Parse("32923432900388514432614400") };
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
public class A286722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286722Inst Instance=new A286722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286721
{
public static readonly BigInteger[] Value={ 1L,12L,159L,2485L,45474L,959070L,22963996L,616224492L,18331744896L,599061555136L,21339235262784L,823098817664448L,34183157124707200L,1520908498941532800L,BigInteger.Parse("72182781516370886400"),BigInteger.Parse("3640264913563748243200"),BigInteger.Parse("194408478299496756556800"),BigInteger.Parse("10961007293837647131724800") };
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
public class A286721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286721Inst Instance=new A286721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286720
{
public static readonly long[] Value={ 4L,6L,6L,4L,6L,6L,4L,6L,6L,6L,8L,6L,6L,10L,6L,6L,8L,6L,12L,10L,10L,4L,6L,6L,6L,8L,6L,6L,8L,10L,6L,6L,8L,8L,6L,10L,6L,8L,6L,8L,6L,10L,6L,10L,6L,10L,6L,10L,6L,8L,8L,6L,8L,8L,8L,6L,6L,6L,10L,8L,6L,8L,10L,12L,8L,10L,6L,8L,8L,8L,10L,8L,6L,8L,10L,6L,8L,8L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286720Inst : IEnumerable<long>
{
public static readonly long[] Value=A286720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286720.Bytes);
public long this[int i]=>Value[i];

public static A286720Inst Instance=new A286720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286719
{
public static readonly BigInteger[] Value={ 1L,25L,395L,5075L,58086L,618870L,6289690L,61885450L,595122671L,5629238615L,52605474285L,487197745125L,4481780785756L,41018845739260L,373968405050180L,3399402534376100L,30830907772159341L,279134548584080805L,2523817507756513375L,BigInteger.Parse("22795663165336810375"),BigInteger.Parse("205730405672107235426"),BigInteger.Parse("1855561201430080303250"),BigInteger.Parse("16727971116048518559870"),BigInteger.Parse("150747219419372400319950"),BigInteger.Parse("1358093516662781192486011") };
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
public class A286719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286719Inst Instance=new A286719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286718
{
public static readonly long[] Value={ 1L,1L,1L,4L,5L,1L,28L,39L,12L,1L,280L,418L,159L,22L,1L,3640L,5714L,2485L,445L,35L,1L,58240L,95064L,45474L,9605L,1005L,51L,1L,1106560L,1864456L,959070L,227969L,28700L,1974L,70L,1L,24344320L,42124592L,22963996L,5974388L,859369L,72128L,3514L,92L,1L,608608000L,1077459120L,616224492L,172323696L,27458613L,2662569L,159978L,5814L,117L,1L,17041024000L,30777463360L,18331744896L,5441287980L,941164860L,102010545L,7141953L,322770L,9090L,145L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286718Inst : IEnumerable<long>
{
public static readonly long[] Value=A286718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286718.Bytes);
public long this[int i]=>Value[i];

public static A286718Inst Instance=new A286718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286717
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,5L,6L,5L,6L,7L,8L,9L,8L,9L,10L,11L,12L,11L,12L,13L,14L,15L,14L,15L,16L,17L,18L,17L,18L,19L,20L,21L,20L,21L,22L,23L,24L,23L,24L,25L,26L,27L,26L,27L,28L,29L,30L,29L,30L,31L,32L,33L,32L,33L,34L,35L,36L,35L,36L,37L,38L,39L,38L,39L,40L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286717Inst : IEnumerable<long>
{
public static readonly long[] Value=A286717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286717.Bytes);
public long this[int i]=>Value[i];

public static A286717Inst Instance=new A286717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286716
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,3L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,5L,6L,6L,7L,7L,7L,7L,8L,8L,9L,8L,9L,9L,10L,10L,10L,10L,11L,11L,12L,11L,12L,12L,13L,13L,13L,13L,14L,14L,15L,14L,15L,15L,16L,16L,16L,16L,17L,17L,18L,17L,18L,18L,19L,19L,19L,19L,20L,20L,21L,20L,21L,21L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286716Inst : IEnumerable<long>
{
public static readonly long[] Value=A286716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286716.Bytes);
public long this[int i]=>Value[i];

public static A286716Inst Instance=new A286716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286715
{
public static readonly long[] Value={ 3L,2381L,3851L,14561L,17291L,20021L,20231L,26951L,34511L,41231L,47741L,50051L,52361L,55931L,57191L,65171L,67211L,67271L,70841L,82811L,87011L,98561L,101501L,101531L,108461L,117041L,119771L,126491L,129221L,134681L,136991L,142871L,145601L,150221L,156941L,165551L,166601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286715Inst : IEnumerable<long>
{
public static readonly long[] Value=A286715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286715.Bytes);
public long this[int i]=>Value[i];

public static A286715Inst Instance=new A286715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286714
{
public static readonly long[] Value={ -1L,0L,0L,2L,4L,4L,12L,0L,8L,16L,20L,32L,40L,8L,24L,40L,32L,60L,4L,24L,60L,84L,24L,56L,24L,136L,104L,36L,44L,116L,184L,48L,84L,184L,68L,252L,72L,280L,68L,144L,56L,292L,140L,192L,120L,338L,276L,120L,144L,262L,192L,376L,120L,268L,192L,236L,64L,168L,240L,492L,348L,388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286714Inst : IEnumerable<long>
{
public static readonly long[] Value=A286714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286714.Bytes);
public long this[int i]=>Value[i];

public static A286714Inst Instance=new A286714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286713
{
public static readonly long[] Value={ 2L,5L,9L,19L,20L,25L,32L,46L,54L,69L,80L,99L,130L,136L,160L,188L,206L,218L,268L,300L,330L,339L,360L,398L,411L,453L,516L,536L,552L,577L,641L,702L,753L,797L,824L,859L,948L,985L,1072L,1111L,1196L,1237L,1320L,1337L,1444L,1489L,1568L,1597L,1649L,1741L,1816L,1838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286713Inst : IEnumerable<long>
{
public static readonly long[] Value=A286713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286713.Bytes);
public long this[int i]=>Value[i];

public static A286713Inst Instance=new A286713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286712
{
public static readonly long[] Value={ 1L,2L,6L,4L,13L,6L,14L,8L,25L,21L,27L,28L,61L,56L,47L,32L,17L,50L,38L,52L,42L,54L,46L,56L,50L,26L,54L,28L,58L,30L,62L,96L,66L,34L,99L,72L,101L,76L,39L,104L,82L,106L,86L,44L,90L,110L,94L,112L,99L,50L,102L,52L,107L,118L,111L,112L,57L,122L,119L,60L,122L,62L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286712Inst : IEnumerable<long>
{
public static readonly long[] Value=A286712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286712.Bytes);
public long this[int i]=>Value[i];

public static A286712Inst Instance=new A286712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286711
{
public static readonly long[] Value={ 5L,22L,67L,126L,138L,1253L,1586L,1356L,3524L,2129L,10464L,14174L,19633L,23354L,44754L,52872L,194426L,122046L,209609L,249329L,256005L,493543L,335001L,116305L,895479L,1698315L,1324483L,2783617L,679305L,1015023L,2217824L,3625328L,1595431L,6660573L,13611829L,4061952L,14641489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286711Inst : IEnumerable<long>
{
public static readonly long[] Value=A286711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286711.Bytes);
public long this[int i]=>Value[i];

public static A286711Inst Instance=new A286711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286614
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,2L,5L,5L,2L,6L,2L,3L,5L,6L,2L,2L,2L,6L,7L,5L,2L,8L,6L,2L,5L,5L,2L,6L,6L,2L,5L,3L,6L,5L,6L,5L,2L,9L,5L,10L,6L,2L,5L,11L,2L,9L,5L,5L,9L,5L,5L,8L,12L,2L,6L,13L,5L,14L,2L,2L,9L,5L,5L,5L,5L,2L,2L,13L,6L,2L,2L,5L,2L,13L,8L,5L,5L,12L,6L,5L,5L,5L,2L,5L,6L,6L,5L,2L,2L,6L,6L,9L,5L,6L,15L,5L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286614Inst : IEnumerable<long>
{
public static readonly long[] Value=A286614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286614.Bytes);
public long this[int i]=>Value[i];

public static A286614Inst Instance=new A286614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286613
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,8L,2L,6L,6L,2L,12L,2L,4L,6L,12L,2L,2L,2L,12L,32L,6L,2L,24L,12L,2L,6L,6L,2L,12L,12L,2L,6L,4L,12L,6L,12L,6L,2L,30L,6L,72L,12L,2L,6L,120L,2L,30L,6L,6L,30L,6L,6L,24L,48L,2L,12L,60L,6L,210L,2L,2L,30L,6L,6L,6L,6L,2L,2L,60L,12L,2L,2L,6L,2L,60L,24L,6L,6L,48L,12L,6L,6L,6L,2L,6L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286613Inst : IEnumerable<long>
{
public static readonly long[] Value=A286613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286613.Bytes);
public long this[int i]=>Value[i];

public static A286613Inst Instance=new A286613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286612
{
public static readonly long[] Value={ 65L,513L,1026L,4107L,8200L,8256L,16400L,16450L,16512L,16544L,16641L,32800L,32900L,33024L,33282L,33920L,49184L,65600L,65800L,66048L,66080L,131200L,131334L,132096L,132160L,163968L,262400L,262668L,264192L,264320L,274432L,327936L,524342L,524610L,524800L,524832L,525826L,528384L,532500L,540736L,548864L,655872L,786467L,1048617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286612Inst : IEnumerable<long>
{
public static readonly long[] Value=A286612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286612.Bytes);
public long this[int i]=>Value[i];

public static A286612Inst Instance=new A286612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286611
{
public static readonly long[] Value={ 17L,19L,34L,37L,41L,43L,47L,53L,59L,61L,65L,67L,69L,71L,73L,74L,79L,82L,83L,86L,89L,97L,101L,103L,106L,107L,109L,113L,118L,122L,127L,129L,131L,134L,137L,139L,141L,142L,145L,146L,148L,149L,151L,157L,158L,163L,164L,166L,167L,173L,177L,178L,179L,181L,183L,191L,193L,194L,197L,199L,201L,202L,206L,211L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286611Inst : IEnumerable<long>
{
public static readonly long[] Value=A286611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286611.Bytes);
public long this[int i]=>Value[i];

public static A286611Inst Instance=new A286611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286610
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,3L,4L,3L,5L,3L,6L,4L,7L,7L,8L,4L,9L,7L,6L,5L,10L,7L,11L,6L,9L,6L,12L,7L,13L,8L,11L,8L,14L,6L,15L,9L,14L,8L,16L,6L,17L,11L,14L,10L,18L,8L,17L,11L,19L,14L,20L,9L,16L,14L,15L,12L,21L,8L,22L,13L,15L,19L,23L,11L,24L,19L,25L,14L,26L,14L,27L,15L,16L,15L,22L,14L,28L,19L,29L,16L,30L,14L,31L,17L,32L,16L,33L,14L,27L,25L,22L,18L,27L,19L,34L,17L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286610Inst : IEnumerable<long>
{
public static readonly long[] Value=A286610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286610.Bytes);
public long this[int i]=>Value[i];

public static A286610Inst Instance=new A286610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286609
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,23L,26L,29L,31L,34L,37L,38L,41L,43L,46L,47L,51L,53L,57L,58L,59L,61L,62L,67L,69L,71L,73L,74L,76L,79L,82L,83L,86L,87L,89L,92L,93L,94L,95L,97L,101L,103L,106L,107L,109L,111L,113L,114L,115L,116L,118L,122L,123L,124L,127L,129L,131L,133L,134L,137L,138L,139L,141L,142L,145L,146L,148L,149L,151L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286609Inst : IEnumerable<long>
{
public static readonly long[] Value=A286609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286609.Bytes);
public long this[int i]=>Value[i];

public static A286609Inst Instance=new A286609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286608
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,25L,27L,28L,30L,32L,33L,35L,36L,39L,40L,42L,44L,45L,48L,49L,50L,52L,54L,55L,56L,60L,63L,64L,65L,66L,68L,70L,72L,75L,77L,78L,80L,81L,84L,85L,88L,90L,91L,96L,98L,99L,100L,102L,104L,105L,108L,110L,112L,117L,119L,120L,121L,125L,126L,128L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286608Inst : IEnumerable<long>
{
public static readonly long[] Value=A286608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286608.Bytes);
public long this[int i]=>Value[i];

public static A286608Inst Instance=new A286608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286607
{
public static readonly long[] Value={ 3L,5L,7L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,25L,28L,29L,31L,32L,33L,34L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,53L,55L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,71L,73L,74L,76L,77L,78L,79L,81L,82L,83L,84L,85L,86L,87L,88L,89L,92L,93L,94L,95L,97L,98L,99L,100L,101L,102L,103L,104L,106L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286607Inst : IEnumerable<long>
{
public static readonly long[] Value=A286607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286607.Bytes);
public long this[int i]=>Value[i];

public static A286607Inst Instance=new A286607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286606
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,0L,4L,5L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,0L,4L,5L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,10L,11L,0L,1L,2L,0L,4L,5L,0L,1L,2L,0L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,2L,3L,0L,1L,2L,3L,4L,5L,6L,7L,0L,1L,6L,7L,8L,9L,22L,23L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286606Inst : IEnumerable<long>
{
public static readonly long[] Value=A286606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286606.Bytes);
public long this[int i]=>Value[i];

public static A286606Inst Instance=new A286606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286605
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,2L,5L,2L,4L,4L,6L,2L,5L,2L,5L,4L,4L,2L,7L,3L,4L,4L,5L,2L,7L,2L,5L,4L,4L,4L,8L,2L,4L,4L,7L,2L,7L,2L,5L,5L,4L,2L,9L,3L,5L,4L,5L,2L,7L,4L,7L,4L,4L,2L,10L,2L,4L,5L,11L,4L,7L,2L,5L,4L,7L,2L,10L,2L,4L,5L,5L,4L,7L,2L,9L,6L,4L,2L,10L,4L,4L,4L,7L,2L,10L,4L,5L,4L,4L,4L,10L,2L,5L,5L,8L,2L,7L,2L,7L,7L,4L,2L,10L,2L,7L,4L,9L,2L,7L,4L,5L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286605Inst : IEnumerable<long>
{
public static readonly long[] Value=A286605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286605.Bytes);
public long this[int i]=>Value[i];

public static A286605Inst Instance=new A286605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286604
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,0L,0L,1L,3L,0L,1L,2L,3L,0L,2L,0L,3L,0L,1L,2L,5L,0L,1L,0L,0L,1L,1L,0L,1L,2L,1L,2L,0L,0L,1L,2L,4L,0L,5L,2L,3L,4L,3L,4L,5L,0L,1L,2L,3L,0L,3L,0L,3L,0L,2L,3L,5L,0L,1L,2L,3L,4L,2L,1L,1L,2L,6L,0L,7L,0L,1L,2L,0L,1L,5L,2L,4L,0L,3L,4L,6L,4L,1L,2L,3L,4L,1L,0L,0L,1L,5L,6L,5L,0L,2L,3L,3L,4L,3L,2L,1L,2L,0L,1L,3L,0L,4L,5L,7L,0L,5L,2L,3L,4L,0L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286604Inst : IEnumerable<long>
{
public static readonly long[] Value=A286604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286604.Bytes);
public long this[int i]=>Value[i];

public static A286604Inst Instance=new A286604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286603
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,6L,11L,12L,13L,13L,14L,10L,15L,16L,17L,18L,19L,13L,20L,14L,17L,21L,22L,23L,24L,18L,25L,26L,27L,26L,28L,29L,20L,22L,30L,17L,31L,32L,33L,34L,24L,26L,35L,36L,37L,24L,38L,27L,39L,24L,39L,40L,30L,20L,41L,42L,31L,43L,44L,33L,45L,46L,47L,31L,45L,24L,48L,49L,50L,35L,51L,31L,41L,40L,52L,53L,47L,33L,54L,55L,56L,39L,57L,30L,58L,59L,41L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286603Inst : IEnumerable<long>
{
public static readonly long[] Value=A286603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286603.Bytes);
public long this[int i]=>Value[i];

public static A286603Inst Instance=new A286603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286602
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,3L,5L,6L,5L,3L,7L,4L,7L,4L,2L,4L,2L,4L,7L,4L,8L,9L,7L,6L,10L,9L,5L,11L,7L,3L,7L,11L,7L,3L,7L,11L,12L,13L,7L,6L,14L,15L,10L,9L,5L,9L,12L,4L,7L,4L,2L,9L,7L,4L,8L,13L,7L,9L,14L,4L,8L,13L,8L,16L,8L,13L,17L,4L,8L,13L,8L,13L,18L,13L,7L,19L,14L,9L,17L,4L,8L,9L,7L,4L,2L,4L,7L,13L,8L,4L,8L,9L,14L,13L,7L,11L,12L,13L,7L,11L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286602Inst : IEnumerable<long>
{
public static readonly long[] Value=A286602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286602.Bytes);
public long this[int i]=>Value[i];

public static A286602Inst Instance=new A286602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286601
{
public static readonly long[] Value={ 1L,2L,4L,2L,6L,2L,4L,8L,16L,8L,4L,12L,6L,12L,6L,2L,6L,2L,6L,12L,6L,30L,24L,12L,16L,32L,24L,8L,36L,12L,4L,12L,36L,12L,4L,12L,36L,72L,60L,12L,16L,48L,64L,32L,24L,8L,24L,72L,6L,12L,6L,2L,24L,12L,6L,30L,60L,12L,24L,48L,6L,30L,60L,30L,210L,30L,60L,120L,6L,30L,60L,30L,60L,180L,60L,12L,96L,48L,24L,120L,6L,30L,24L,12L,6L,2L,6L,12L,60L,30L,6L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286601Inst : IEnumerable<long>
{
public static readonly long[] Value=A286601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286601.Bytes);
public long this[int i]=>Value[i];

public static A286601Inst Instance=new A286601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286600
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,3L,5L,7L,5L,3L,6L,4L,6L,4L,2L,4L,2L,4L,6L,4L,8L,9L,6L,7L,11L,9L,5L,10L,6L,3L,6L,10L,6L,3L,6L,10L,14L,12L,6L,7L,13L,15L,11L,9L,5L,9L,14L,4L,6L,4L,2L,9L,6L,4L,8L,12L,6L,9L,13L,4L,8L,12L,8L,16L,8L,12L,17L,4L,8L,12L,8L,12L,18L,12L,6L,19L,13L,9L,17L,4L,8L,9L,6L,4L,2L,4L,6L,12L,8L,4L,8L,9L,13L,12L,6L,10L,14L,12L,6L,10L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286600Inst : IEnumerable<long>
{
public static readonly long[] Value=A286600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286600.Bytes);
public long this[int i]=>Value[i];

public static A286600Inst Instance=new A286600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286599
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,2L,3L,6L,4L,7L,5L,6L,5L,2L,3L,6L,6L,8L,4L,9L,7L,10L,5L,11L,6L,9L,5L,6L,5L,2L,3L,6L,6L,8L,6L,12L,8L,13L,4L,9L,9L,13L,7L,14L,10L,15L,5L,11L,11L,12L,6L,12L,9L,14L,5L,11L,6L,9L,5L,6L,5L,2L,3L,6L,6L,8L,6L,12L,8L,13L,6L,12L,12L,16L,8L,16L,13L,17L,4L,9L,9L,13L,9L,18L,13L,19L,7L,14L,14L,17L,10L,20L,15L,21L,5L,11L,11L,12L,11L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286599Inst : IEnumerable<long>
{
public static readonly long[] Value=A286599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286599.Bytes);
public long this[int i]=>Value[i];

public static A286599Inst Instance=new A286599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286518
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,4L,2L,4L,1L,20L,1L,4L,4L,8L,1L,20L,1L,20L,4L,4L,1L,88L,2L,4L,4L,20L,1L,96L,1L,16L,4L,4L,4L,196L,1L,4L,4L,88L,1L,96L,1L,20L,20L,4L,1L,368L,2L,20L,4L,20L,1L,88L,4L,88L,4L,4L,1L,1824L,1L,4L,20L,32L,4L,96L,1L,20L,4L,96L,1L,1688L,1L,4L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286518Inst : IEnumerable<long>
{
public static readonly long[] Value=A286518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286518.Bytes);
public long this[int i]=>Value[i];

public static A286518Inst Instance=new A286518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286517
{
public static readonly long[] Value={ 3L,5L,7L,3L,11L,13L,5L,17L,19L,7L,23L,5L,3L,29L,31L,11L,35L,37L,13L,41L,43L,1L,47L,7L,17L,53L,55L,19L,59L,61L,7L,13L,67L,23L,71L,73L,5L,77L,79L,3L,83L,17L,29L,89L,13L,31L,19L,97L,11L,101L,103L,7L,107L,109L,37L,113L,23L,13L,119L,11L,41L,5L,127L,43L,131L,19L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286517Inst : IEnumerable<long>
{
public static readonly long[] Value=A286517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286517.Bytes);
public long this[int i]=>Value[i];

public static A286517Inst Instance=new A286517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286516
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,1L,13L,7L,15L,2L,17L,3L,19L,5L,7L,11L,23L,1L,5L,13L,3L,7L,29L,5L,31L,2L,11L,17L,7L,1L,37L,19L,13L,5L,41L,21L,43L,11L,3L,23L,47L,1L,7L,5L,17L,13L,53L,3L,11L,7L,19L,29L,59L,1L,61L,31L,7L,2L,65L,11L,67L,17L,23L,5L,71L,1L,73L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286516Inst : IEnumerable<long>
{
public static readonly long[] Value=A286516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286516.Bytes);
public long this[int i]=>Value[i];

public static A286516Inst Instance=new A286516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286515
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,6L,1L,6L,1L,10L,1L,6L,1L,210L,5L,6L,1L,30L,5L,210L,7L,330L,5L,30L,1L,546L,7L,14L,1L,30L,1L,462L,77L,3570L,35L,6L,1L,51870L,455L,210L,7L,2310L,55L,2310L,7L,4830L,35L,210L,1L,6630L,221L,858L,11L,330L,55L,798L,19L,870L,5L,30L,1L,930930L,5005L,4290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286515Inst : IEnumerable<long>
{
public static readonly long[] Value=A286515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286515.Bytes);
public long this[int i]=>Value[i];

public static A286515Inst Instance=new A286515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286514
{
public static readonly long[] Value={ 1L,3L,3L,5L,11L,7L,9L,41L,51L,11L,17L,149L,383L,183L,21L,31L,547L,2865L,2629L,663L,39L,57L,2007L,21449L,38437L,18635L,2435L,71L,105L,7361L,160579L,561743L,531669L,133709L,8935L,131L,193L,27001L,1202181L,8207075L,15179657L,7455797L,956009L,32775L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286514Inst : IEnumerable<long>
{
public static readonly long[] Value=A286514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286514.Bytes);
public long this[int i]=>Value[i];

public static A286514Inst Instance=new A286514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286513
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,4L,1L,17L,13L,7L,1L,41L,43L,35L,11L,1L,99L,142L,181L,81L,18L,1L,239L,469L,933L,621L,199L,29L,1L,577L,1549L,4811L,4741L,2309L,477L,47L,1L,1393L,5116L,24807L,36211L,26660L,8303L,1155L,76L,1L,3363L,16897L,127913L,276561L,307983L,143697L,30277L,2785L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286513Inst : IEnumerable<long>
{
public static readonly long[] Value=A286513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286513.Bytes);
public long this[int i]=>Value[i];

public static A286513Inst Instance=new A286513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286512
{
public static readonly long[] Value={ 17L,31L,63L,86L,91L,103L,118L,133L,155L,157L,211L,270L,290L,301L,338L,352L,421L,432L,440L,441L,450L,478L,513L,533L,693L,853L,1051L,1237L,1363L,1459L,1526L,1665L,2781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286512Inst : IEnumerable<long>
{
public static readonly long[] Value=A286512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286512.Bytes);
public long this[int i]=>Value[i];

public static A286512Inst Instance=new A286512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286511
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,10L,17L,1L,22L,29L,35L,40L,28L,74L,5L,1L,70L,73L,90L,109L,103L,125L,30L,89L,158L,172L,165L,123L,171L,212L,228L,262L,242L,52L,264L,274L,167L,349L,1L,383L,288L,423L,404L,445L,412L,394L,514L,427L,478L,527L,626L,229L,602L,581L,536L,665L,710L,698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286511Inst : IEnumerable<long>
{
public static readonly long[] Value=A286511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286511.Bytes);
public long this[int i]=>Value[i];

public static A286511Inst Instance=new A286511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286510
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,2L,1L,6L,5L,2L,9L,11L,12L,5L,7L,9L,8L,8L,17L,12L,11L,16L,12L,23L,20L,16L,17L,17L,23L,17L,26L,18L,19L,25L,26L,32L,38L,21L,21L,18L,27L,25L,24L,27L,52L,30L,44L,33L,19L,44L,54L,45L,57L,14L,29L,27L,39L,58L,28L,41L,39L,62L,26L,25L,69L,48L,51L,61L,44L,47L,37L,63L,77L,55L,55L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286510Inst : IEnumerable<long>
{
public static readonly long[] Value=A286510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286510.Bytes);
public long this[int i]=>Value[i];

public static A286510Inst Instance=new A286510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286509
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,1L,0L,1L,-3L,3L,0L,0L,1L,-4L,6L,-2L,-1L,0L,1L,-5L,10L,-7L,-1L,1L,0L,1L,-6L,15L,-16L,3L,4L,-1L,0L,1L,-7L,21L,-30L,15L,6L,-6L,1L,0L,1L,-8L,28L,-50L,40L,0L,-17L,6L,0L,0L,1L,-9L,36L,-77L,84L,-26L,-30L,24L,-3L,-1L,0L,1L,-10L,45L,-112L,154L,-90L,-30L,64L,-21L,-2L,2L,0L,1L,-11L,55L,-156L,258L,-217L,15L,125L,-81L,6L,9L,-3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286509Inst : IEnumerable<long>
{
public static readonly long[] Value=A286509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286509.Bytes);
public long this[int i]=>Value[i];

public static A286509Inst Instance=new A286509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286508
{
public static readonly long[] Value={ 1L,10L,10L,100L,100L,1000L,1000L,10000L,10000L,100000L,100000L,1000000L,1000000L,10000000L,10000000L,100000000L,100000000L,1000000000L,1000000000L,10000000000L,10000000000L,100000000000L,100000000000L,1000000000000L,1000000000000L,10000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286508Inst : IEnumerable<long>
{
public static readonly long[] Value=A286508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286508.Bytes);
public long this[int i]=>Value[i];

public static A286508Inst Instance=new A286508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286507
{
public static readonly long[] Value={ 1L,1L,10L,10L,100L,100L,1000L,1000L,10000L,10000L,100000L,100000L,1000000L,1000000L,10000000L,10000000L,100000000L,100000000L,1000000000L,1000000000L,10000000000L,10000000000L,100000000000L,100000000000L,1000000000000L,1000000000000L,10000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286507Inst : IEnumerable<long>
{
public static readonly long[] Value=A286507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286507.Bytes);
public long this[int i]=>Value[i];

public static A286507Inst Instance=new A286507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286506
{
public static readonly long[] Value={ 1L,1L,0L,7L,24L,15L,96L,63L,0L,1023L,0L,4095L,0L,4095L,24576L,16383L,0L,262143L,196608L,393215L,786432L,2097151L,3145728L,6291455L,14680064L,4194303L,58720256L,218103807L,67108864L,973078527L,0L,4294967295L,0L,536870911L,29527900160L,2147483647L,109521666048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286506Inst : IEnumerable<long>
{
public static readonly long[] Value=A286506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286506.Bytes);
public long this[int i]=>Value[i];

public static A286506Inst Instance=new A286506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286505
{
public static readonly long[] Value={ 1L,2L,0L,14L,3L,60L,3L,252L,0L,1023L,0L,4095L,0L,16380L,3L,65532L,0L,262143L,6L,1048570L,6L,4194302L,6L,16777210L,14L,67108848L,14L,268435443L,4L,1073741799L,0L,4294967295L,0L,17179869152L,59L,68719476704L,51L,274877906936L,51L,1099511627728L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286505Inst : IEnumerable<long>
{
public static readonly long[] Value=A286505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286505.Bytes);
public long this[int i]=>Value[i];

public static A286505Inst Instance=new A286505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286504
{
public static readonly BigInteger[] Value={ 1L,1L,0L,111L,11000L,1111L,1100000L,111111L,0L,1111111111L,0L,111111111111L,0L,111111111111L,110000000000000L,11111111111111L,0L,111111111111111111L,110000000000000000L,1011111111111111111L,11000000000000000000UL,BigInteger.Parse("111111111111111111111"),BigInteger.Parse("1100000000000000000000") };
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
public class A286504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286504Inst Instance=new A286504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286503
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1110L,11L,111100L,11L,11111100L,0L,1111111111L,0L,111111111111L,0L,11111111111100L,11L,1111111111111100L,0L,111111111111111111L,110L,11111111111111111010UL,110L,BigInteger.Parse("1111111111111111111110"),110L,BigInteger.Parse("111111111111111111111010"),1110L,BigInteger.Parse("11111111111111111111110000") };
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
public class A286503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286503Inst Instance=new A286503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286438
{
public static readonly long[] Value={ 0L,4L,63L,494L,2247L,7396L,19739L,45518L,94259L,179732L,321031L,543774L,881423L,1376724L,2083267L,3067166L,4408859L,6205028L,8570639L,11641102L,15574551L,20554244L,26791083L,34526254L,44033987L,55624436L,69646679L,86491838L,106596319L,130445172L,158575571L,191580414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286438Inst : IEnumerable<long>
{
public static readonly long[] Value=A286438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286438.Bytes);
public long this[int i]=>Value[i];

public static A286438Inst Instance=new A286438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286437
{
public static readonly long[] Value={ 0L,9L,48L,153L,372L,765L,1404L,2373L,3768L,5697L,8280L,11649L,15948L,21333L,27972L,36045L,45744L,57273L,70848L,86697L,105060L,126189L,150348L,177813L,208872L,243825L,282984L,326673L,375228L,428997L,488340L,553629L,625248L,703593L,789072L,882105L,983124L,1092573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286437Inst : IEnumerable<long>
{
public static readonly long[] Value=A286437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286437.Bytes);
public long this[int i]=>Value[i];

public static A286437Inst Instance=new A286437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286436
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,7L,9L,4L,1L,1L,13L,48L,63L,25L,1L,21L,153L,494L,747L,546L,219L,57L,9L,1L,1L,31L,372L,2247L,7459L,14064L,15160L,9233L,3069L,480L,14L,1L,43L,765L,7396L,42983L,157248L,369787L,563287L,556932L,358974L,153520L,45282L,9634L,1529L,186L,16L,1L,1L,57L,1404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286436Inst : IEnumerable<long>
{
public static readonly long[] Value=A286436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286436.Bytes);
public long this[int i]=>Value[i];

public static A286436Inst Instance=new A286436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286435
{
public static readonly long[] Value={ 2L,3L,6L,9L,27L,48L,60L,74L,161L,242L,269L,518L,1092L,1220L,1883L,2618L,3266L,6699L,8855L,17022L,17454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286435Inst : IEnumerable<long>
{
public static readonly long[] Value=A286435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286435.Bytes);
public long this[int i]=>Value[i];

public static A286435Inst Instance=new A286435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286434
{
public static readonly long[] Value={ 2L,3L,6L,9L,10L,14L,15L,34L,56L,138L,250L,350L,357L,374L,392L,1594L,4794L,5290L,6702L,11936L,22296L,55762L,55834L,96195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286434Inst : IEnumerable<long>
{
public static readonly long[] Value=A286434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286434.Bytes);
public long this[int i]=>Value[i];

public static A286434Inst Instance=new A286434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286433
{
public static readonly long[] Value={ 1L,6L,25L,98L,399L,1746L,8271L,42284L,231939L,1357128L,8427181L,55288860L,381798629L,2765917074L,20960284277L,165729739590L,1364153612299L,11665484410094L,103448316470723L,949739632313480L,9013431476894623L,88304011710168668L,891917738589610553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286433Inst : IEnumerable<long>
{
public static readonly long[] Value=A286433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286433.Bytes);
public long this[int i]=>Value[i];

public static A286433Inst Instance=new A286433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286432
{
public static readonly BigInteger[] Value={ 0L,1L,12L,151L,2545L,54466L,1417318L,43472780L,1536228588L,61466251616L,2746907348768L,135619260805568L,7331022129923648L,430638151053316480L,BigInteger.Parse("27315015477709844352"),BigInteger.Parse("1860627613021322933248"),BigInteger.Parse("135465573609158928964096"),BigInteger.Parse("10498038569346091127451136"),BigInteger.Parse("862792664850194915870874112") };
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
public class A286432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286432Inst Instance=new A286432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286431
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,9L,16L,17L,18L,36L,54L,69L,183L,200L,240L,846L,1424L,2511L,4750L,13854L,15414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286431Inst : IEnumerable<long>
{
public static readonly long[] Value=A286431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286431.Bytes);
public long this[int i]=>Value[i];

public static A286431Inst Instance=new A286431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286430
{
public static readonly long[] Value={ 0L,0L,0L,0L,36L,78L,136L,210L,300L,406L,528L,666L,820L,990L,1176L,1378L,1596L,1830L,2080L,2346L,2628L,2926L,3240L,3570L,3916L,4278L,4656L,5050L,5460L,5886L,6328L,6786L,7260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286430Inst : IEnumerable<long>
{
public static readonly long[] Value=A286430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286430.Bytes);
public long this[int i]=>Value[i];

public static A286430Inst Instance=new A286430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286429
{
public static readonly long[] Value={ 0L,0L,0L,0L,16L,27L,40L,55L,72L,91L,112L,135L,160L,187L,216L,247L,280L,315L,352L,391L,432L,475L,520L,567L,616L,667L,720L,775L,832L,891L,952L,1015L,1080L,1147L,1216L,1287L,1360L,1435L,1512L,1591L,1672L,1755L,1840L,1927L,2016L,2107L,2200L,2295L,2392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286429Inst : IEnumerable<long>
{
public static readonly long[] Value=A286429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286429.Bytes);
public long this[int i]=>Value[i];

public static A286429Inst Instance=new A286429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286428
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,9L,11L,12L,14L,15L,16L,18L,19L,21L,22L,23L,25L,26L,28L,29L,30L,32L,33L,35L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,61L,63L,64L,66L,67L,68L,70L,71L,73L,74L,75L,77L,78L,80L,81L,82L,84L,85L,87L,88L,89L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286428Inst : IEnumerable<long>
{
public static readonly long[] Value=A286428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286428.Bytes);
public long this[int i]=>Value[i];

public static A286428Inst Instance=new A286428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286427
{
public static readonly long[] Value={ 1L,0L,3L,5L,24L,78L,325L,1272L,5373L,22572L,97762L,425716L,1882062L,8375064L,37601643L,169773435L,771096972L,3518065767L,16119884297L,74125225732L,341970676466L,1582133854847L,7338641255894L,34117910537671L,158946919835352L,741884929970516L,3468677541274922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286427Inst : IEnumerable<long>
{
public static readonly long[] Value=A286427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286427.Bytes);
public long this[int i]=>Value[i];

public static A286427Inst Instance=new A286427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286426
{
public static readonly long[] Value={ 0L,1L,2L,6L,20L,23L,86L,146L,167L,340L,472L,500L,898L,907L,936L,1133L,2069L,3166L,4207L,5275L,9700L,20407L,28009L,32923L,53264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286426Inst : IEnumerable<long>
{
public static readonly long[] Value=A286426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286426.Bytes);
public long this[int i]=>Value[i];

public static A286426Inst Instance=new A286426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286425
{
public static readonly long[] Value={ 1L,2L,8L,44L,285L,2028L,15338L,120960L,983108L,8172094L,69116592L,592590616L,5136777504L,44928712804L,395907022448L,3510622573064L,31296093794827L,280275392413204L,2520017580255461L,22736733105613548L,205767848345966976L,1867240544055742660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286425Inst : IEnumerable<long>
{
public static readonly long[] Value=A286425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286425.Bytes);
public long this[int i]=>Value[i];

public static A286425Inst Instance=new A286425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286424
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,110L,1432L,23338L,397661L,8193828L,212858328L,5941706227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286424Inst : IEnumerable<long>
{
public static readonly long[] Value=A286424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286424.Bytes);
public long this[int i]=>Value[i];

public static A286424Inst Instance=new A286424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286423
{
public static readonly BigInteger[] Value={ 2L,7L,130L,4207L,1166928L,541240697L,2907639077764L,25886034363696809L,BigInteger.Parse("3341096345926174809912"),BigInteger.Parse("713738790204487208874991935"),BigInteger.Parse("2645105778378736719464340469683304"),BigInteger.Parse("16238808907214611705432043192158547965751") };
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
public class A286423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286423Inst Instance=new A286423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286342
{
public static readonly long[] Value={ 2399L,3511L,4919L,6661L,2129L,11311L,14281L,17729L,21701L,26209L,26407L,37049L,43441L,50527L,252823L,66931L,64153L,86561L,19531L,109673L,122651L,136601L,151561L,167593L,184703L,202949L,222361L,242971L,50441L,287933L,261707L,338137L,365291L,393847L,79259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286342Inst : IEnumerable<long>
{
public static readonly long[] Value=A286342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286342.Bytes);
public long this[int i]=>Value[i];

public static A286342Inst Instance=new A286342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286341
{
public static readonly long[] Value={ 2L,5L,6L,9L,11L,14L,16L,17L,20L,23L,24L,27L,29L,30L,33L,36L,38L,41L,42L,45L,47L,50L,52L,53L,56L,59L,61L,64L,65L,68L,70L,71L,74L,77L,78L,81L,83L,86L,88L,89L,92L,95L,96L,99L,101L,102L,105L,108L,110L,113L,114L,117L,119L,120L,123L,126L,127L,130L,132L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286341Inst : IEnumerable<long>
{
public static readonly long[] Value=A286341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286341.Bytes);
public long this[int i]=>Value[i];

public static A286341Inst Instance=new A286341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286340
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,12L,13L,15L,18L,19L,21L,22L,25L,26L,28L,31L,32L,34L,35L,37L,39L,40L,43L,44L,46L,48L,49L,51L,54L,55L,57L,58L,60L,62L,63L,66L,67L,69L,72L,73L,75L,76L,79L,80L,82L,84L,85L,87L,90L,91L,93L,94L,97L,98L,100L,103L,104L,106L,107L,109L,111L,112L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286340Inst : IEnumerable<long>
{
public static readonly long[] Value=A286340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286340.Bytes);
public long this[int i]=>Value[i];

public static A286340Inst Instance=new A286340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286339
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286339Inst : IEnumerable<long>
{
public static readonly long[] Value=A286339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286339.Bytes);
public long this[int i]=>Value[i];

public static A286339Inst Instance=new A286339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286338
{
public static readonly long[] Value={ 5L,6L,9L,14L,16L,17L,23L,24L,27L,29L,30L,36L,41L,42L,45L,50L,52L,53L,59L,64L,65L,68L,70L,71L,77L,78L,81L,86L,88L,89L,95L,96L,99L,101L,102L,108L,113L,114L,117L,119L,120L,126L,127L,130L,135L,137L,138L,144L,149L,150L,153L,158L,160L,161L,167L,168L,171L,173L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286338Inst : IEnumerable<long>
{
public static readonly long[] Value=A286338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286338.Bytes);
public long this[int i]=>Value[i];

public static A286338Inst Instance=new A286338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286337
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,8L,10L,11L,12L,13L,15L,18L,19L,20L,21L,22L,25L,26L,28L,31L,32L,33L,34L,35L,37L,38L,39L,40L,43L,44L,46L,47L,48L,49L,51L,54L,55L,56L,57L,58L,60L,61L,62L,63L,66L,67L,69L,72L,73L,74L,75L,76L,79L,80L,82L,83L,84L,85L,87L,90L,91L,92L,93L,94L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286337Inst : IEnumerable<long>
{
public static readonly long[] Value=A286337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286337.Bytes);
public long this[int i]=>Value[i];

public static A286337Inst Instance=new A286337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286336
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286336Inst : IEnumerable<long>
{
public static readonly long[] Value=A286336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286336.Bytes);
public long this[int i]=>Value[i];

public static A286336Inst Instance=new A286336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286335
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,2L,0L,1L,4L,6L,6L,2L,0L,1L,5L,10L,13L,9L,3L,0L,1L,6L,15L,24L,24L,14L,4L,0L,1L,7L,21L,40L,51L,42L,22L,5L,0L,1L,8L,28L,62L,95L,100L,73L,32L,6L,0L,1L,9L,36L,91L,162L,206L,190L,120L,46L,8L,0L,1L,10L,45L,128L,259L,384L,425L,344L,192L,66L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286335Inst : IEnumerable<long>
{
public static readonly long[] Value=A286335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286335.Bytes);
public long this[int i]=>Value[i];

public static A286335Inst Instance=new A286335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286334
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,2L,3L,1L,3L,2L,3L,4L,1L,5L,3L,5L,2L,3L,4L,6L,1L,10L,6L,4L,7L,3L,7L,2L,7L,5L,3L,4L,5L,6L,7L,10L,17L,1L,18L,11L,8L,7L,6L,5L,4L,7L,10L,3L,11L,8L,5L,7L,11L,19L,2L,13L,9L,7L,5L,13L,8L,14L,3L,13L,10L,7L,11L,4L,13L,9L,5L,16L,11L,6L,13L,7L,8L,9L,10L,11L,13L,15L,18L,22L,28L,39L,66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286334Inst : IEnumerable<long>
{
public static readonly long[] Value=A286334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286334.Bytes);
public long this[int i]=>Value[i];

public static A286334Inst Instance=new A286334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286333
{
public static readonly long[] Value={ 19L,23L,29L,41L,43L,47L,53L,59L,61L,67L,83L,89L,101L,103L,107L,127L,149L,157L,163L,181L,191L,307L,317L,331L,359L,367L,701L,709L,727L,739L,757L,761L,787L,797L,907L,937L,941L,947L,983L,1103L,1109L,1123L,1181L,1301L,1319L,1327L,1949L,1951L,1979L,1987L,1993L,3121L,3187L,3361L,3373L,3701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286333Inst : IEnumerable<long>
{
public static readonly long[] Value=A286333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286333.Bytes);
public long this[int i]=>Value[i];

public static A286333Inst Instance=new A286333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286332
{
public static readonly long[] Value={ 0L,2L,2L,1L,4L,3L,3L,1L,4L,2L,6L,5L,0L,2L,7L,1L,4L,3L,3L,1L,4L,7L,7L,5L,0L,2L,8L,4L,4L,6L,3L,1L,8L,7L,7L,5L,0L,2L,2L,1L,4L,6L,3L,1L,8L,2L,7L,5L,0L,2L,8L,1L,4L,6L,3L,1L,4L,2L,7L,5L,0L,2L,8L,1L,4L,6L,3L,1L,8L,7L,7L,5L,0L,2L,8L,1L,4L,6L,3L,1L,8L,2L,7L,5L,0L,2L,8L,1L,4L,6L,3L,1L,8L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286332Inst : IEnumerable<long>
{
public static readonly long[] Value=A286332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286332.Bytes);
public long this[int i]=>Value[i];

public static A286332Inst Instance=new A286332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286331
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,6L,1L,49L,294L,168L,1L,225L,7350L,37800L,20160L,1L,961L,144150L,4036200L,19373760L,9999360L,1L,3969L,2542806L,326932200L,8543828160L,39687459840L,20158709760L,1L,16129L,42677334L,23435953128L,2812314375360L,71124337751040L,325139829719040L,163849992929280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286331Inst : IEnumerable<long>
{
public static readonly long[] Value=A286331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286331.Bytes);
public long this[int i]=>Value[i];

public static A286331Inst Instance=new A286331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286330
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,7L,10L,11L,15L,19L,26L,32L,42L,50L,66L,78L,101L,118L,150L,178L,224L,263L,327L,382L,471L,551L,670L,781L,944L,1098L,1317L,1526L,1821L,2105L,2498L,2879L,3399L,3908L,4592L,5266L,6164L,7056L,8220L,9388L,10897L,12424L,14368L,16342L,18843L,21394L,24585L,27858L,31932L,36119L,41277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286330Inst : IEnumerable<long>
{
public static readonly long[] Value=A286330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286330.Bytes);
public long this[int i]=>Value[i];

public static A286330Inst Instance=new A286330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286329
{
public static readonly BigInteger[] Value={ 1L,-104L,6444L,-311744L,13018830L,-493025760L,17411253944L,-583472867840L,18770817643749L,-584450497233840L,17716721171780388L,-525192444572011776L,15276991910654781638UL,BigInteger.Parse("-437229195695756884672"),BigInteger.Parse("12338641730218147891560"),BigInteger.Parse("-343932138212987023388672") };
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
public class A286329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286329Inst Instance=new A286329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286328
{
public static readonly long[] Value={ 4L,3L,24L,60L,14L,9L,180L,264L,20L,480L,19L,84L,924L,1104L,51L,1740L,155L,2244L,2520L,2664L,3120L,3444L,99L,51L,51L,5304L,5724L,65L,399L,8064L,8580L,9384L,9660L,221L,11400L,12324L,13284L,13944L,14964L,16020L,819L,18240L,194L,99L,19800L,22260L,24864L,25764L,26220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286328Inst : IEnumerable<long>
{
public static readonly long[] Value=A286328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286328.Bytes);
public long this[int i]=>Value[i];

public static A286328Inst Instance=new A286328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286327
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,1L,4L,5L,1L,9L,4L,5L,13L,1L,10L,9L,4L,17L,5L,13L,16L,1L,20L,10L,9L,25L,4L,25L,17L,5L,34L,13L,16L,26L,1L,41L,20L,10L,37L,9L,25L,29L,4L,50L,25L,17L,40L,5L,36L,34L,13L,53L,16L,26L,45L,1L,49L,41L,20L,58L,10L,37L,52L,9L,64L,25L,29L,65L,4L,50L,61L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286327Inst : IEnumerable<long>
{
public static readonly long[] Value=A286327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286327.Bytes);
public long this[int i]=>Value[i];

public static A286327Inst Instance=new A286327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286246
{
public static readonly long[] Value={ 1L,3L,2L,3L,0L,4L,10L,0L,5L,7L,3L,0L,0L,0L,11L,21L,0L,0L,5L,8L,16L,3L,0L,0L,0L,0L,0L,22L,36L,0L,0L,0L,14L,0L,12L,29L,10L,0L,0L,0L,0L,0L,8L,0L,37L,21L,0L,0L,0L,0L,5L,0L,0L,17L,46L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,56L,78L,0L,0L,0L,0L,0L,27L,0L,19L,12L,23L,67L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,79L,21L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,30L,92L,21L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,17L,0L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286246Inst : IEnumerable<long>
{
public static readonly long[] Value=A286246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286246.Bytes);
public long this[int i]=>Value[i];

public static A286246Inst Instance=new A286246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286245
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,3L,7L,5L,3L,10L,11L,5L,3L,10L,3L,16L,8L,5L,10L,3L,21L,22L,8L,5L,10L,3L,21L,3L,29L,12L,5L,14L,3L,21L,3L,36L,37L,12L,8L,14L,3L,21L,3L,36L,10L,46L,17L,8L,14L,5L,21L,3L,36L,10L,21L,56L,17L,8L,14L,5L,21L,3L,36L,10L,21L,3L,67L,23L,12L,19L,5L,27L,3L,36L,10L,21L,3L,78L,79L,23L,12L,19L,5L,27L,3L,36L,10L,21L,3L,78L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286245Inst : IEnumerable<long>
{
public static readonly long[] Value=A286245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286245.Bytes);
public long this[int i]=>Value[i];

public static A286245Inst Instance=new A286245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286244
{
public static readonly long[] Value={ 1L,3L,2L,3L,3L,4L,10L,3L,5L,7L,3L,10L,3L,5L,11L,21L,3L,10L,5L,8L,16L,3L,21L,3L,10L,5L,8L,22L,36L,3L,21L,3L,14L,5L,12L,29L,10L,36L,3L,21L,3L,14L,8L,12L,37L,21L,10L,36L,3L,21L,5L,14L,8L,17L,46L,3L,21L,10L,36L,3L,21L,5L,14L,8L,17L,56L,78L,3L,21L,10L,36L,3L,27L,5L,19L,12L,23L,67L,3L,78L,3L,21L,10L,36L,3L,27L,5L,19L,12L,23L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286244Inst : IEnumerable<long>
{
public static readonly long[] Value=A286244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286244.Bytes);
public long this[int i]=>Value[i];

public static A286244Inst Instance=new A286244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286243
{
public static readonly long[] Value={ 2L,2L,4L,6L,2L,8L,12L,4L,12L,6L,6L,12L,6L,2L,24L,24L,8L,16L,32L,12L,30L,30L,4L,60L,12L,12L,48L,30L,6L,60L,72L,6L,6L,48L,12L,12L,24L,6L,12L,30L,2L,48L,24L,24L,60L,72L,24L,36L,60L,8L,12L,60L,16L,72L,180L,32L,180L,24L,12L,6L,12L,30L,36L,24L,30L,128L,210L,4L,12L,30L,60L,60L,30L,12L,60L,210L,12L,120L,120L,48L,96L,120L,30L,60L,48L,6L,120L,60L,60L,420L,180L,72L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286243Inst : IEnumerable<long>
{
public static readonly long[] Value=A286243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286243.Bytes);
public long this[int i]=>Value[i];

public static A286243Inst Instance=new A286243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286242
{
public static readonly long[] Value={ 1L,5L,12L,14L,12L,84L,40L,44L,12L,142L,216L,183L,40L,265L,86L,152L,12L,142L,826L,265L,216L,1860L,607L,489L,40L,832L,607L,1117L,86L,619L,226L,560L,12L,142L,826L,265L,826L,5080L,2497L,619L,216L,2956L,4308L,4155L,607L,8575L,1105L,1533L,40L,832L,2497L,2116L,607L,5731L,4501L,3475L,86L,1402L,1105L,3475L,226L,1759L,698L,2144L,12L,142L,826L,265L,826L,5080L,2497L,619L,826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286242Inst : IEnumerable<long>
{
public static readonly long[] Value=A286242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286242.Bytes);
public long this[int i]=>Value[i];

public static A286242Inst Instance=new A286242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286241
{
public static readonly long[] Value={ 2L,12L,14L,12L,59L,86L,27L,12L,109L,363L,269L,86L,142L,148L,27L,12L,109L,1093L,1117L,363L,1097L,1517L,489L,86L,601L,1408L,619L,148L,142L,148L,27L,12L,109L,1093L,1117L,1093L,5707L,8587L,2545L,363L,1969L,6153L,4529L,1517L,4489L,4537L,489L,86L,601L,3946L,3976L,1408L,2509L,5719L,2545L,148L,601L,1408L,619L,148L,142L,148L,27L,12L,109L,1093L,1117L,1093L,5707L,8587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286241Inst : IEnumerable<long>
{
public static readonly long[] Value=A286241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286241.Bytes);
public long this[int i]=>Value[i];

public static A286241Inst Instance=new A286241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286240
{
public static readonly long[] Value={ 2L,5L,12L,14L,23L,42L,59L,44L,23L,61L,142L,117L,109L,183L,261L,152L,23L,61L,142L,148L,601L,850L,607L,375L,109L,265L,1093L,939L,473L,765L,1097L,560L,23L,61L,142L,148L,601L,850L,607L,430L,601L,1741L,3946L,2545L,2497L,3463L,2509L,1323L,109L,265L,1093L,1117L,2497L,4525L,5707L,3153L,473L,1105L,4489L,3813L,1969L,3129L,4497L,2144L,23L,61L,142L,148L,601L,850L,607L,430L,601L,1741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286240Inst : IEnumerable<long>
{
public static readonly long[] Value=A286240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286240.Bytes);
public long this[int i]=>Value[i];

public static A286240Inst Instance=new A286240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286239
{
public static readonly long[] Value={ 1L,1L,2L,3L,0L,4L,3L,2L,0L,7L,10L,0L,0L,0L,11L,3L,5L,4L,0L,0L,16L,21L,0L,0L,0L,0L,0L,22L,10L,5L,0L,7L,0L,0L,0L,29L,21L,0L,8L,0L,0L,0L,0L,0L,37L,10L,14L,0L,0L,11L,0L,0L,0L,0L,46L,55L,0L,0L,0L,0L,0L,0L,0L,0L,0L,56L,10L,5L,8L,12L,0L,16L,0L,0L,0L,0L,0L,67L,78L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,79L,21L,27L,0L,0L,0L,0L,22L,0L,0L,0L,0L,0L,0L,92L,36L,0L,19L,0L,17L,0L,0L,0L,0L,0L,0L,0L,0L,0L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286239Inst : IEnumerable<long>
{
public static readonly long[] Value=A286239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286239.Bytes);
public long this[int i]=>Value[i];

public static A286239Inst Instance=new A286239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286238
{
public static readonly long[] Value={ 1L,2L,1L,4L,0L,3L,7L,0L,2L,3L,11L,0L,0L,0L,10L,16L,0L,0L,4L,5L,3L,22L,0L,0L,0L,0L,0L,21L,29L,0L,0L,0L,7L,0L,5L,10L,37L,0L,0L,0L,0L,0L,8L,0L,21L,46L,0L,0L,0L,0L,11L,0L,0L,14L,10L,56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,55L,67L,0L,0L,0L,0L,0L,16L,0L,12L,8L,5L,10L,79L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,78L,92L,0L,0L,0L,0L,0L,0L,22L,0L,0L,0L,0L,27L,21L,106L,0L,0L,0L,0L,0L,0L,0L,0L,0L,17L,0L,19L,0L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286238Inst : IEnumerable<long>
{
public static readonly long[] Value=A286238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286238.Bytes);
public long this[int i]=>Value[i];

public static A286238Inst Instance=new A286238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286237
{
public static readonly long[] Value={ 1L,2L,1L,4L,0L,3L,7L,2L,0L,3L,11L,0L,0L,0L,10L,16L,4L,5L,0L,0L,3L,22L,0L,0L,0L,0L,0L,21L,29L,7L,0L,5L,0L,0L,0L,10L,37L,0L,8L,0L,0L,0L,0L,0L,21L,46L,11L,0L,0L,14L,0L,0L,0L,0L,10L,56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,55L,67L,16L,12L,8L,0L,5L,0L,0L,0L,0L,0L,10L,79L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,78L,92L,22L,0L,0L,0L,0L,27L,0L,0L,0L,0L,0L,0L,21L,106L,0L,17L,0L,19L,0L,0L,0L,0L,0L,0L,0L,0L,0L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286237Inst : IEnumerable<long>
{
public static readonly long[] Value=A286237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286237.Bytes);
public long this[int i]=>Value[i];

public static A286237Inst Instance=new A286237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286236
{
public static readonly long[] Value={ 1L,1L,2L,3L,0L,4L,3L,0L,2L,7L,10L,0L,0L,0L,11L,3L,0L,0L,5L,4L,16L,21L,0L,0L,0L,0L,0L,22L,10L,0L,0L,0L,5L,0L,7L,29L,21L,0L,0L,0L,0L,0L,8L,0L,37L,10L,0L,0L,0L,0L,14L,0L,0L,11L,46L,55L,0L,0L,0L,0L,0L,0L,0L,0L,0L,56L,10L,0L,0L,0L,0L,0L,5L,0L,8L,12L,16L,67L,78L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,79L,21L,0L,0L,0L,0L,0L,0L,27L,0L,0L,0L,0L,22L,92L,36L,0L,0L,0L,0L,0L,0L,0L,0L,0L,19L,0L,17L,0L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286236Inst : IEnumerable<long>
{
public static readonly long[] Value=A286236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286236.Bytes);
public long this[int i]=>Value[i];

public static A286236Inst Instance=new A286236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286235
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,3L,7L,2L,3L,3L,11L,2L,3L,3L,10L,16L,4L,5L,3L,10L,3L,22L,4L,5L,3L,10L,3L,21L,29L,7L,5L,5L,10L,3L,21L,10L,37L,7L,8L,5L,10L,3L,21L,10L,21L,46L,11L,8L,5L,14L,3L,21L,10L,21L,10L,56L,11L,8L,5L,14L,3L,21L,10L,21L,10L,55L,67L,16L,12L,8L,14L,5L,21L,10L,21L,10L,55L,10L,79L,16L,12L,8L,14L,5L,21L,10L,21L,10L,55L,10L,78L,92L,22L,12L,8L,14L,5L,27L,10L,21L,10L,55L,10L,78L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286235Inst : IEnumerable<long>
{
public static readonly long[] Value=A286235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286235.Bytes);
public long this[int i]=>Value[i];

public static A286235Inst Instance=new A286235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286234
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,4L,3L,3L,2L,7L,10L,3L,3L,2L,11L,3L,10L,3L,5L,4L,16L,21L,3L,10L,3L,5L,4L,22L,10L,21L,3L,10L,5L,5L,7L,29L,21L,10L,21L,3L,10L,5L,8L,7L,37L,10L,21L,10L,21L,3L,14L,5L,8L,11L,46L,55L,10L,21L,10L,21L,3L,14L,5L,8L,11L,56L,10L,55L,10L,21L,10L,21L,5L,14L,8L,12L,16L,67L,78L,10L,55L,10L,21L,10L,21L,5L,14L,8L,12L,16L,79L,21L,78L,10L,55L,10L,21L,10L,27L,5L,14L,8L,12L,22L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286234Inst : IEnumerable<long>
{
public static readonly long[] Value=A286234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286234.Bytes);
public long this[int i]=>Value[i];

public static A286234Inst Instance=new A286234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286233
{
public static readonly long[] Value={ 579L,639L,14911L,18207L,38575L,47223L,310399L,492855L,16632919L,20238207L,34696495L,37400607L,37852351L,52463103L,84250111L,122992023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286233Inst : IEnumerable<long>
{
public static readonly long[] Value=A286233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286233.Bytes);
public long this[int i]=>Value[i];

public static A286233Inst Instance=new A286233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286232
{
public static readonly long[] Value={ 1L,5L,1L,19L,10L,1L,75L,57L,17L,1L,323L,285L,145L,26L,1L,1512L,1421L,975L,317L,37L,1L,7630L,7395L,5999L,2865L,616L,50L,1L,41245L,40726L,36183L,22411L,7315L,1094L,65L,1L,237573L,237759L,221689L,163488L,72581L,16630L,1812L,82L,1L,1451359L,1468162L,1405001L,1160764L,649723L,206249L,34425L,2840L,101L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286232Inst : IEnumerable<long>
{
public static readonly long[] Value=A286232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286232.Bytes);
public long this[int i]=>Value[i];

public static A286232Inst Instance=new A286232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286231
{
public static readonly long[] Value={ 1L,5L,1L,25L,10L,1L,143L,79L,17L,1L,942L,634L,197L,26L,1L,7074L,5462L,2129L,417L,37L,1L,59832L,51214L,23381L,5856L,786L,50L,1L,563688L,523386L,269033L,80053L,13934L,1360L,65L,1L,5858640L,5813892L,3281206L,1111498L,232349L,29728L,2204L,82L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286231Inst : IEnumerable<long>
{
public static readonly long[] Value=A286231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286231.Bytes);
public long this[int i]=>Value[i];

public static A286231Inst Instance=new A286231Inst();

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