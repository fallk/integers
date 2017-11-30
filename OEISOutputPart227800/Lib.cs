using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278462
{
public static readonly BigInteger[] Value={ 1L,2L,10L,66L,504L,4148L,35794L,319384L,2922472L,27273568L,258591700L,2483951402L,24121423518L,236417231844L,2335648036770L,23234567806722L,232536604918010L,2339766365713070L,23655013692855212L,240175288588925992L,2447961627258995826L,BigInteger.Parse("25037715732340569328"),BigInteger.Parse("256899046844874628732") };
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
public class A278462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278462Inst Instance=new A278462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278463
{
public static readonly long[] Value={ 1L,2L,2L,3L,9L,4L,4L,36L,44L,12L,5L,110L,355L,250L,48L,6L,300L,2010L,3480L,1644L,240L,7L,777L,9625L,32235L,35728L,12348L,1440L,8L,1960L,42056L,242200L,498512L,390880L,104544L,10080L,9L,4860L,173754L,1605744L,5466321L,7745220L,4581036L,986256L,80640L,10L,11880L,691620L,9807840L,51506490L,117711720L,123330680L,57537360L,10265760L,725760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278463Inst : IEnumerable<long>
{
public static readonly long[] Value=A278463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278463.Bytes);
public long this[int i]=>Value[i];

public static A278463Inst Instance=new A278463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278464
{
public static readonly long[] Value={ 0L,1L,5L,17L,53L,145L,385L,957L,2333L,5493L,12741L,28941L,65049L,144225L,317229L,691457L,1497901L,3224145L,6906969L,14726701L,31282421L,66211253L,139720445L,294007373L,617154865L,1292516577L,2701451621L,5635565761L,11736442005L,24403092657L,50666528209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278464Inst : IEnumerable<long>
{
public static readonly long[] Value=A278464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278464.Bytes);
public long this[int i]=>Value[i];

public static A278464Inst Instance=new A278464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278465
{
public static readonly long[] Value={ 2L,4L,10L,12L,14L,20L,22L,24L,38L,40L,42L,44L,48L,50L,52L,54L,56L,58L,62L,64L,66L,68L,76L,80L,84L,90L,94L,98L,104L,108L,112L,142L,144L,150L,152L,154L,160L,162L,170L,172L,178L,180L,182L,184L,188L,190L,192L,194L,198L,202L,204L,206L,208L,212L,214L,216L,220L,222L,224L,226L,230L,232L,234L,240L,242L,244L,246L,250L,252L,254L,256L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278465Inst : IEnumerable<long>
{
public static readonly long[] Value=A278465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278465.Bytes);
public long this[int i]=>Value[i];

public static A278465Inst Instance=new A278465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278466
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1100L,1L,111100L,1L,11111100L,1001L,1111100000L,1111L,111111100000L,1111L,11111111100100L,1L,1111111111111100L,11001001L,111111111000000000L,11111111L,11111111111001001100UL,1L,BigInteger.Parse("1111111111111111111100"),1101011001L,BigInteger.Parse("111111111111100010000000"),1010111111L };
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
public class A278466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278466Inst Instance=new A278466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278467
{
public static readonly BigInteger[] Value={ 1L,0L,100L,11L,10000L,1111L,1000000L,111111L,100100000L,11111L,11110000000L,1111111L,1111000000000L,100111111111L,100000000000000L,11111111111111L,10010011000000000L,111111111L,1111111100000000000L,110010011111111111L,BigInteger.Parse("100000000000000000000") };
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
public class A278467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278467Inst Instance=new A278467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278468
{
public static readonly long[] Value={ 1L,0L,1L,12L,1L,60L,1L,252L,9L,992L,15L,4064L,15L,16356L,1L,65532L,201L,261632L,255L,1048140L,1L,4194300L,857L,16775296L,703L,67107280L,167L,268435104L,7631L,1073726084L,6449L,4294950916L,8181L,17179856200L,3L,68719476728L,3443L,274877899424L,3023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278468Inst : IEnumerable<long>
{
public static readonly long[] Value=A278468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278468.Bytes);
public long this[int i]=>Value[i];

public static A278468Inst Instance=new A278468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278469
{
public static readonly long[] Value={ 1L,0L,4L,3L,16L,15L,64L,63L,288L,31L,1920L,127L,7680L,2559L,16384L,16383L,75264L,511L,522240L,206847L,1048576L,1048575L,5070848L,73727L,33193984L,3047423L,120061952L,5767167L,511115264L,139526143L,1179385856L,537133055L,5904531456L,1255145471L,25769803776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278469Inst : IEnumerable<long>
{
public static readonly long[] Value=A278469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278469.Bytes);
public long this[int i]=>Value[i];

public static A278469Inst Instance=new A278469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278470
{
public static readonly long[] Value={ 13L,20L,40L,43L,73L,85L,576L,1676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278470Inst : IEnumerable<long>
{
public static readonly long[] Value=A278470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278470.Bytes);
public long this[int i]=>Value[i];

public static A278470Inst Instance=new A278470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278471
{
public static readonly long[] Value={ 16L,18L,38L,82L,98L,318L,1106L,1914L,2438L,2640L,3156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278471Inst : IEnumerable<long>
{
public static readonly long[] Value=A278471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278471.Bytes);
public long this[int i]=>Value[i];

public static A278471Inst Instance=new A278471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278472
{
public static readonly long[] Value={ 1L,5L,22L,92L,376L,1518L,6085L,24285L,96647L,383911L,1523117L,6037745L,23920853L,94737897L,375125126L,1485173396L,5879740780L,23277813786L,92160762514L,364906983652L,1444972555742L,5722488162840L,22665368420672L,89783494878902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278472Inst : IEnumerable<long>
{
public static readonly long[] Value=A278472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278472.Bytes);
public long this[int i]=>Value[i];

public static A278472Inst Instance=new A278472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278473
{
public static readonly long[] Value={ 1L,6L,25L,75L,76L,96L,99L,376L,625L,1376L,1875L,3568L,3751L,4375L,6875L,8001L,8125L,9376L,13568L,28125L,49376L,68751L,89376L,90625L,109375L,109376L,499999L,800001L,890624L,890625L,2890625L,5109376L,5781249L,6640625L,7109376L,8000001L,12109375L,12890625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278473Inst : IEnumerable<long>
{
public static readonly long[] Value=A278473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278473.Bytes);
public long this[int i]=>Value[i];

public static A278473Inst Instance=new A278473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278474
{
public static readonly long[] Value={ 24L,36L,76L,375L,376L,432L,624L,625L,693L,875L,999L,2499L,4557L,8307L,9375L,9376L,9999L,34375L,40625L,47943L,50001L,59375L,81249L,90624L,90625L,99999L,109376L,186432L,218751L,586432L,609375L,690624L,718751L,781249L,890625L,954193L,968751L,999999L,2109375L,2890624L,2890625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278474Inst : IEnumerable<long>
{
public static readonly long[] Value=A278474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278474.Bytes);
public long this[int i]=>Value[i];

public static A278474Inst Instance=new A278474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278475
{
public static readonly BigInteger[] Value={ 1L,29L,841L,24417L,708933L,20583473L,597629649L,17351843293L,503801085145L,14627583312497L,424703717147557L,12331035380591649L,358024729754305377L,10395048198255447581UL,BigInteger.Parse("301814422479162285225"),BigInteger.Parse("8763013300093961719105"),BigInteger.Parse("254429200125204052139269"),BigInteger.Parse("7387209816931011473757905") };
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
public class A278475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278475Inst Instance=new A278475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278476
{
public static readonly BigInteger[] Value={ 1L,14L,196L,2757L,38793L,545858L,7680804L,108077113L,1520760385L,21398722502L,301102875412L,4236838978269L,59616848571177L,838872718974746L,11803834914217620L,166092561518021425L,2337099696166517569L,BigInteger.Parse("32885488307849267390"),BigInteger.Parse("462733936006056261028") };
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
public class A278476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278476Inst Instance=new A278476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278477
{
public static readonly long[] Value={ 2L,3L,7L,23L,31L,127L,383L,991L,2039L,3583L,6143L,8191L,63487L,129023L,131071L,522239L,524287L,1966079L,4128767L,14680063L,33546239L,67108351L,201064447L,260046847L,536739839L,1073479679L,2147483647L,8581545983L,16911433727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278477Inst : IEnumerable<long>
{
public static readonly long[] Value=A278477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278477.Bytes);
public long this[int i]=>Value[i];

public static A278477Inst Instance=new A278477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278478
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,3L,0L,0L,0L,4L,0L,0L,0L,1L,0L,3L,1L,0L,0L,1L,2L,1L,1L,0L,2L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,2L,0L,1L,2L,2L,0L,0L,2L,0L,1L,1L,6L,0L,0L,0L,5L,0L,0L,0L,2L,3L,0L,0L,2L,1L,2L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,0L,0L,3L,0L,11L,1L,3L,0L,2L,1L,0L,1L,0L,0L,4L,0L,2L,7L,1L,0L,2L,2L,0L,0L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278478Inst : IEnumerable<long>
{
public static readonly long[] Value=A278478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278478.Bytes);
public long this[int i]=>Value[i];

public static A278478Inst Instance=new A278478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278479
{
public static readonly long[] Value={ 0L,2L,26L,11L,15L,70L,66L,109L,154L,478L,441L,96L,3693L,15005L,66934L,99420L,18978L,43002L,55943L,972190L,1151214L,2799146L,26801784L,46632889L,15519397L,122101417L,210553237L,289585489L,473093534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278479Inst : IEnumerable<long>
{
public static readonly long[] Value=A278479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278479.Bytes);
public long this[int i]=>Value[i];

public static A278479Inst Instance=new A278479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278480
{
public static readonly long[] Value={ 2L,4L,5L,5L,7L,5L,5L,8L,7L,5L,5L,8L,8L,7L,5L,5L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278480Inst : IEnumerable<long>
{
public static readonly long[] Value=A278480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278480.Bytes);
public long this[int i]=>Value[i];

public static A278480Inst Instance=new A278480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278481
{
public static readonly long[] Value={ 2L,4L,4L,4L,6L,4L,4L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278481Inst : IEnumerable<long>
{
public static readonly long[] Value=A278481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278481.Bytes);
public long this[int i]=>Value[i];

public static A278481Inst Instance=new A278481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278482
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,0L,3L,4L,2L,0L,4L,6L,6L,2L,0L,5L,8L,8L,6L,2L,0L,6L,10L,12L,12L,6L,2L,0L,7L,12L,14L,14L,12L,6L,2L,0L,8L,14L,18L,18L,18L,12L,6L,2L,0L,9L,16L,20L,24L,24L,18L,12L,6L,2L,0L,10L,18L,24L,26L,26L,26L,18L,12L,6L,2L,0L,11L,20L,26L,30L,30L,30L,26L,18L,12L,6L,2L,0L,12L,22L,30L,36L,38L,38L,38L,26L,18L,12L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278482Inst : IEnumerable<long>
{
public static readonly long[] Value=A278482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278482.Bytes);
public long this[int i]=>Value[i];

public static A278482Inst Instance=new A278482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278483
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,0L,2L,4L,3L,0L,2L,6L,6L,4L,0L,2L,6L,8L,8L,5L,0L,2L,6L,12L,12L,10L,6L,0L,2L,6L,12L,14L,14L,12L,7L,0L,2L,6L,12L,18L,18L,18L,14L,8L,0L,2L,6L,12L,18L,24L,24L,20L,16L,9L,0L,2L,6L,12L,18L,26L,26L,26L,24L,18L,10L,0L,2L,6L,12L,18L,26L,30L,30L,30L,26L,20L,11L,0L,2L,6L,12L,18L,26L,38L,38L,38L,36L,30L,22L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278483Inst : IEnumerable<long>
{
public static readonly long[] Value=A278483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278483.Bytes);
public long this[int i]=>Value[i];

public static A278483Inst Instance=new A278483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278484
{
public static readonly long[] Value={ 0L,2L,6L,12L,18L,26L,38L,48L,62L,78L,90L,108L,132L,146L,180L,206L,222L,252L,288L,306L,348L,386L,398L,458L,480L,528L,566L,612L,648L,708L,762L,806L,842L,926L,948L,1008L,1092L,1110L,1188L,1260L,1320L,1358L,1470L,1482L,1578L,1692L,1718L,1806L,1898L,1932L,2022L,2160L,2186L,2268L,2366L,2478L,2532L,2702L,2738L,2798L,2966L,3018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278484Inst : IEnumerable<long>
{
public static readonly long[] Value=A278484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278484.Bytes);
public long this[int i]=>Value[i];

public static A278484Inst Instance=new A278484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278485
{
public static readonly long[] Value={ 1L,2L,3L,7L,9L,11L,12L,14L,18L,27L,30L,34L,38L,40L,47L,56L,58L,62L,70L,72L,73L,81L,86L,95L,97L,98L,106L,113L,115L,123L,131L,134L,139L,141L,153L,157L,159L,160L,162L,166L,167L,173L,176L,181L,183L,188L,195L,214L,216L,219L,223L,227L,233L,235L,244L,255L,259L,262L,270L,278L,286L,291L,296L,301L,307L,309L,315L,317L,326L,329L,346L,352L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278485Inst : IEnumerable<long>
{
public static readonly long[] Value=A278485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278485.Bytes);
public long this[int i]=>Value[i];

public static A278485Inst Instance=new A278485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278486
{
public static readonly long[] Value={ 3L,6L,8L,18L,24L,30L,32L,38L,48L,72L,80L,90L,102L,108L,128L,152L,158L,168L,192L,198L,200L,224L,240L,264L,270L,272L,294L,312L,318L,338L,360L,368L,384L,390L,422L,434L,440L,444L,450L,462L,464L,480L,488L,504L,510L,522L,542L,594L,600L,608L,620L,632L,648L,654L,678L,710L,720L,728L,752L,774L,798L,810L,824L,840L,858L,864L,882L,888L,912L,920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278486Inst : IEnumerable<long>
{
public static readonly long[] Value=A278486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278486.Bytes);
public long this[int i]=>Value[i];

public static A278486Inst Instance=new A278486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278487
{
public static readonly long[] Value={ 2L,5L,7L,17L,23L,29L,31L,37L,47L,71L,79L,89L,101L,107L,127L,151L,157L,167L,191L,197L,199L,223L,239L,263L,269L,271L,293L,311L,317L,337L,359L,367L,383L,389L,421L,433L,439L,443L,449L,461L,463L,479L,487L,503L,509L,521L,541L,593L,599L,607L,619L,631L,647L,653L,677L,709L,719L,727L,751L,773L,797L,809L,823L,839L,857L,863L,881L,887L,911L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278487Inst : IEnumerable<long>
{
public static readonly long[] Value=A278487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278487.Bytes);
public long this[int i]=>Value[i];

public static A278487Inst Instance=new A278487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278488
{
public static readonly long[] Value={ 0L,3L,6L,0L,3L,7L,0L,2L,5L,0L,3L,6L,0L,3L,6L,0L,3L,5L,0L,3L,5L,0L,3L,7L,0L,3L,6L,0L,3L,6L,0L,3L,5L,0L,2L,5L,0L,3L,6L,1L,4L,0L,3L,5L,0L,3L,6L,0L,3L,6L,0L,3L,7L,0L,3L,5L,0L,3L,6L,0L,2L,5L,0L,3L,5L,0L,3L,7L,2L,5L,0L,3L,6L,0L,3L,7L,2L,5L,0L,3L,5L,0L,3L,7L,1L,4L,0L,3L,5L,0L,3L,7L,0L,3L,5L,0L,3L,6L,0L,3L,5L,0L,3L,6L,0L,3L,6L,0L,2L,5L,0L,2L,5L,0L,3L,6L,0L,3L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278488Inst : IEnumerable<long>
{
public static readonly long[] Value=A278488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278488.Bytes);
public long this[int i]=>Value[i];

public static A278488Inst Instance=new A278488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278489
{
public static readonly long[] Value={ 0L,3L,6L,8L,9L,11L,15L,16L,18L,19L,21L,24L,27L,30L,32L,35L,38L,39L,40L,41L,43L,45L,48L,50L,51L,53L,54L,56L,59L,63L,64L,66L,67L,70L,71L,72L,73L,74L,75L,78L,80L,81L,83L,85L,87L,88L,90L,91L,93L,95L,96L,99L,102L,104L,105L,107L,108L,111L,112L,114L,115L,117L,120L,123L,126L,128L,129L,130L,131L,134L,135L,136L,137L,138L,139L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278489Inst : IEnumerable<long>
{
public static readonly long[] Value=A278489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278489.Bytes);
public long this[int i]=>Value[i];

public static A278489Inst Instance=new A278489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278490
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,12L,13L,14L,17L,20L,22L,23L,25L,26L,28L,29L,31L,33L,34L,36L,37L,42L,44L,46L,47L,49L,52L,55L,57L,58L,60L,61L,62L,65L,68L,69L,76L,77L,79L,82L,84L,86L,89L,92L,94L,97L,98L,100L,101L,103L,106L,109L,110L,113L,116L,118L,119L,121L,122L,124L,125L,127L,132L,133L,140L,141L,142L,145L,148L,150L,153L,154L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278490Inst : IEnumerable<long>
{
public static readonly long[] Value=A278490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278490.Bytes);
public long this[int i]=>Value[i];

public static A278490Inst Instance=new A278490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278491
{
public static readonly long[] Value={ 0L,3L,24L,35L,99L,120L,195L,323L,440L,483L,675L,728L,899L,1155L,1368L,1443L,1763L,1848L,2115L,2499L,2808L,2915L,3363L,3480L,3843L,4355L,4760L,4899L,5475L,5624L,6083L,6723L,7224L,7395L,8099L,8280L,8835L,9603L,10200L,10403L,11235L,11448L,12099L,12995L,13688L,13923L,14883L,15128L,15875L,16899L,17688L,17955L,19043L,19320L,20163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278491Inst : IEnumerable<long>
{
public static readonly long[] Value=A278491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278491.Bytes);
public long this[int i]=>Value[i];

public static A278491Inst Instance=new A278491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278492
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,5L,3L,1L,5L,7L,7L,3L,1L,6L,9L,9L,7L,3L,1L,7L,11L,13L,13L,7L,3L,1L,8L,13L,15L,15L,13L,7L,3L,1L,9L,15L,19L,19L,19L,13L,7L,3L,1L,10L,17L,21L,25L,25L,19L,13L,7L,3L,1L,11L,19L,25L,27L,27L,27L,19L,13L,7L,3L,1L,12L,21L,27L,31L,31L,31L,27L,19L,13L,7L,3L,1L,13L,23L,31L,37L,39L,39L,39L,27L,19L,13L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278492Inst : IEnumerable<long>
{
public static readonly long[] Value=A278492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278492.Bytes);
public long this[int i]=>Value[i];

public static A278492Inst Instance=new A278492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278493
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,3L,5L,4L,1L,3L,7L,7L,5L,1L,3L,7L,9L,9L,6L,1L,3L,7L,13L,13L,11L,7L,1L,3L,7L,13L,15L,15L,13L,8L,1L,3L,7L,13L,19L,19L,19L,15L,9L,1L,3L,7L,13L,19L,25L,25L,21L,17L,10L,1L,3L,7L,13L,19L,27L,27L,27L,25L,19L,11L,1L,3L,7L,13L,19L,27L,31L,31L,31L,27L,21L,12L,1L,3L,7L,13L,19L,27L,39L,39L,39L,37L,31L,23L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278493Inst : IEnumerable<long>
{
public static readonly long[] Value=A278493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278493.Bytes);
public long this[int i]=>Value[i];

public static A278493Inst Instance=new A278493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278494
{
public static readonly long[] Value={ 2L,5L,7L,13L,17L,23L,29L,31L,37L,47L,61L,79L,89L,97L,101L,103L,109L,113L,127L,157L,167L,193L,197L,199L,223L,229L,241L,257L,269L,271L,281L,293L,313L,317L,337L,353L,359L,383L,389L,397L,401L,409L,421L,433L,439L,449L,461L,463L,487L,509L,541L,569L,577L,593L,601L,607L,631L,647L,653L,673L,677L,709L,719L,727L,751L,761L,769L,773L,797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278494Inst : IEnumerable<long>
{
public static readonly long[] Value=A278494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278494.Bytes);
public long this[int i]=>Value[i];

public static A278494Inst Instance=new A278494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278495
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,1L,1L,2L,4L,1L,2L,1L,3L,2L,4L,3L,3L,3L,5L,3L,2L,2L,4L,4L,4L,4L,3L,4L,4L,4L,4L,2L,3L,3L,2L,4L,2L,5L,4L,6L,3L,5L,4L,5L,5L,4L,6L,3L,3L,6L,8L,4L,5L,3L,5L,5L,5L,4L,6L,6L,7L,5L,5L,7L,6L,8L,8L,8L,8L,5L,5L,5L,8L,7L,7L,7L,3L,13L,5L,8L,6L,8L,7L,8L,5L,14L,7L,8L,8L,10L,7L,5L,8L,6L,7L,6L,9L,4L,10L,4L,9L,8L,6L,8L,8L,8L,6L,10L,11L,13L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278495Inst : IEnumerable<long>
{
public static readonly long[] Value=A278495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278495.Bytes);
public long this[int i]=>Value[i];

public static A278495Inst Instance=new A278495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278496
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,5L,5L,6L,6L,7L,8L,9L,9L,10L,10L,10L,10L,11L,12L,12L,13L,14L,14L,14L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,20L,21L,21L,21L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,26L,27L,27L,27L,27L,28L,28L,28L,29L,29L,29L,29L,30L,30L,30L,30L,31L,31L,31L,31L,32L,32L,32L,32L,33L,33L,34L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278496Inst : IEnumerable<long>
{
public static readonly long[] Value=A278496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278496.Bytes);
public long this[int i]=>Value[i];

public static A278496Inst Instance=new A278496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278497
{
public static readonly long[] Value={ 2L,6L,8L,2L,6L,16L,12L,6L,24L,8L,30L,32L,6L,6L,24L,2L,12L,48L,6L,2L,24L,2L,12L,64L,2L,30L,72L,12L,30L,48L,2L,6L,24L,60L,6L,96L,12L,30L,30L,72L,48L,6L,12L,120L,6L,60L,128L,2L,6L,24L,2L,6L,144L,12L,2L,24L,6L,6L,96L,48L,30L,120L,12L,2L,48L,2L,6L,30L,24L,192L,30L,60L,72L,6L,12L,210L,6L,216L,6L,6L,96L,2L,30L,2L,12L,240L,32L,12L,24L,2L,30L,256L,6L,12L,120L,6L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278497Inst : IEnumerable<long>
{
public static readonly long[] Value=A278497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278497.Bytes);
public long this[int i]=>Value[i];

public static A278497Inst Instance=new A278497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278498
{
public static readonly long[] Value={ 3L,6L,8L,3L,3L,16L,18L,9L,24L,27L,6L,32L,3L,6L,8L,3L,9L,48L,3L,1L,24L,3L,27L,64L,3L,6L,72L,3L,6L,16L,3L,1L,24L,18L,9L,96L,27L,6L,9L,108L,48L,3L,9L,24L,3L,54L,128L,3L,6L,8L,3L,3L,144L,27L,1L,24L,3L,6L,32L,162L,9L,72L,27L,1L,48L,3L,3L,18L,81L,192L,3L,54L,8L,3L,27L,18L,9L,216L,3L,1L,96L,3L,27L,1L,12L,48L,243L,9L,24L,3L,3L,256L,3L,9L,72L,3L,54L,16L,3L,1L,24L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278498Inst : IEnumerable<long>
{
public static readonly long[] Value=A278498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278498.Bytes);
public long this[int i]=>Value[i];

public static A278498Inst Instance=new A278498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278499
{
public static readonly long[] Value={ 0L,3L,2L,0L,3L,3L,0L,2L,1L,0L,3L,2L,0L,3L,2L,0L,3L,1L,0L,3L,1L,0L,3L,3L,0L,3L,2L,0L,3L,2L,0L,3L,1L,0L,2L,1L,0L,3L,2L,1L,0L,0L,3L,1L,0L,3L,2L,0L,3L,2L,0L,3L,3L,0L,3L,1L,0L,3L,2L,0L,2L,1L,0L,3L,1L,0L,3L,3L,2L,1L,0L,3L,2L,0L,3L,3L,2L,1L,0L,3L,1L,0L,3L,3L,1L,0L,0L,3L,1L,0L,3L,3L,0L,3L,1L,0L,3L,2L,0L,3L,1L,0L,3L,2L,0L,3L,2L,0L,2L,1L,0L,2L,1L,0L,3L,2L,0L,3L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278499Inst : IEnumerable<long>
{
public static readonly long[] Value=A278499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278499.Bytes);
public long this[int i]=>Value[i];

public static A278499Inst Instance=new A278499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278500
{
public static readonly long[] Value={ 1L,2L,0L,2L,0L,1L,0L,0L,0L,1L,0L,3L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,3L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278500Inst : IEnumerable<long>
{
public static readonly long[] Value=A278500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278500.Bytes);
public long this[int i]=>Value[i];

public static A278500Inst Instance=new A278500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278501
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,6L,2L,4L,8L,6L,2L,6L,12L,6L,4L,8L,16L,6L,2L,12L,12L,6L,12L,6L,6L,4L,24L,6L,12L,30L,8L,16L,32L,6L,2L,6L,36L,12L,12L,6L,6L,12L,24L,30L,12L,6L,6L,6L,4L,24L,48L,12L,6L,12L,12L,30L,8L,24L,24L,6L,60L,6L,16L,32L,64L,6L,2L,30L,12L,6L,36L,30L,12L,12L,72L,6L,12L,6L,6L,30L,12L,24L,48L,6L,30L,12L,60L,6L,6L,6L,24L,60L,12L,6L,4L,6L,24L,48L,96L,12L,12L,6L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278501Inst : IEnumerable<long>
{
public static readonly long[] Value=A278501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278501.Bytes);
public long this[int i]=>Value[i];

public static A278501Inst Instance=new A278501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278502
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,6L,2L,4L,6L,6L,2L,8L,12L,6L,4L,6L,12L,6L,2L,12L,30L,8L,12L,6L,6L,4L,16L,24L,12L,12L,6L,12L,30L,6L,2L,36L,30L,12L,30L,6L,8L,12L,24L,60L,24L,6L,6L,60L,4L,16L,12L,30L,24L,12L,12L,12L,6L,32L,48L,24L,36L,30L,12L,30L,60L,6L,2L,60L,30L,36L,30L,6L,12L,30L,72L,60L,60L,6L,8L,210L,12L,24L,12L,24L,60L,24L,60L,6L,6L,48L,120L,72L,30L,60L,4L,30L,16L,12L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278502Inst : IEnumerable<long>
{
public static readonly long[] Value=A278502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278502.Bytes);
public long this[int i]=>Value[i];

public static A278502Inst Instance=new A278502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278503
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,4L,13L,9L,11L,6L,19L,15L,21L,17L,8L,27L,25L,37L,33L,23L,10L,39L,31L,51L,55L,45L,29L,12L,49L,43L,73L,85L,75L,57L,35L,14L,63L,61L,99L,121L,111L,97L,69L,41L,16L,79L,67L,127L,151L,159L,145L,115L,81L,47L,18L,91L,87L,163L,193L,211L,199L,171L,135L,93L,53L,20L,109L,103L,187L,247L,271L,267L,243L,205L,157L,105L,59L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278503Inst : IEnumerable<long>
{
public static readonly long[] Value=A278503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278503.Bytes);
public long this[int i]=>Value[i];

public static A278503Inst Instance=new A278503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278504
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,10L,4L,15L,8L,21L,9L,28L,7L,36L,12L,45L,14L,55L,11L,66L,13L,78L,20L,91L,17L,105L,16L,120L,27L,136L,23L,153L,19L,171L,35L,190L,18L,210L,22L,231L,44L,253L,30L,276L,26L,300L,54L,325L,29L,351L,24L,378L,65L,406L,25L,435L,34L,465L,77L,496L,38L,528L,37L,561L,90L,595L,47L,630L,43L,666L,104L,703L,31L,741L,33L,780L,119L,820L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278504Inst : IEnumerable<long>
{
public static readonly long[] Value=A278504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278504.Bytes);
public long this[int i]=>Value[i];

public static A278504Inst Instance=new A278504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278505
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,11L,9L,13L,8L,17L,21L,15L,19L,10L,23L,33L,37L,25L,27L,12L,29L,45L,55L,51L,31L,39L,14L,35L,57L,75L,85L,73L,43L,49L,16L,41L,69L,97L,111L,121L,99L,61L,63L,18L,47L,81L,115L,145L,159L,151L,127L,67L,79L,20L,53L,93L,135L,171L,199L,211L,193L,163L,87L,91L,22L,59L,105L,157L,205L,243L,267L,271L,247L,187L,103L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278505Inst : IEnumerable<long>
{
public static readonly long[] Value=A278505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278505.Bytes);
public long this[int i]=>Value[i];

public static A278505Inst Instance=new A278505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278506
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,11L,9L,16L,8L,22L,10L,29L,14L,37L,12L,46L,15L,56L,13L,67L,17L,79L,20L,92L,21L,106L,23L,121L,27L,137L,18L,154L,30L,172L,19L,191L,28L,211L,38L,232L,35L,254L,24L,277L,47L,301L,36L,326L,26L,352L,57L,379L,25L,407L,31L,436L,68L,466L,44L,497L,45L,529L,80L,562L,54L,596L,39L,631L,93L,667L,34L,704L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278506Inst : IEnumerable<long>
{
public static readonly long[] Value=A278506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278506.Bytes);
public long this[int i]=>Value[i];

public static A278506Inst Instance=new A278506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278507
{
public static readonly long[] Value={ 2L,4L,5L,6L,11L,9L,8L,17L,21L,15L,10L,23L,33L,37L,25L,12L,29L,45L,55L,51L,31L,14L,35L,57L,75L,85L,73L,43L,16L,41L,69L,97L,111L,121L,99L,61L,18L,47L,81L,115L,145L,159L,151L,127L,67L,20L,53L,93L,135L,171L,199L,211L,193L,163L,87L,22L,59L,105L,157L,205L,243L,267L,271L,247L,187L,103L,24L,65L,117L,175L,231L,283L,319L,343L,339L,303L,229L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278507Inst : IEnumerable<long>
{
public static readonly long[] Value=A278507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278507.Bytes);
public long this[int i]=>Value[i];

public static A278507Inst Instance=new A278507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278508
{
public static readonly long[] Value={ 2L,5L,4L,9L,11L,6L,15L,21L,17L,8L,25L,37L,33L,23L,10L,31L,51L,55L,45L,29L,12L,43L,73L,85L,75L,57L,35L,14L,61L,99L,121L,111L,97L,69L,41L,16L,67L,127L,151L,159L,145L,115L,81L,47L,18L,87L,163L,193L,211L,199L,171L,135L,93L,53L,20L,103L,187L,247L,271L,267L,243L,205L,157L,105L,59L,22L,123L,229L,303L,339L,343L,319L,283L,231L,175L,117L,65L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278508Inst : IEnumerable<long>
{
public static readonly long[] Value=A278508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278508.Bytes);
public long this[int i]=>Value[i];

public static A278508Inst Instance=new A278508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278509
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,3L,1L,9L,1L,3L,3L,1L,3L,3L,1L,1L,9L,3L,1L,9L,3L,3L,3L,1L,1L,27L,3L,1L,3L,3L,1L,9L,1L,3L,9L,1L,3L,3L,1L,1L,9L,3L,3L,9L,3L,3L,3L,9L,1L,3L,1L,1L,27L,3L,3L,9L,1L,3L,3L,1L,3L,27L,1L,1L,9L,3L,1L,9L,3L,3L,9L,1L,1L,3L,3L,9L,3L,3L,1L,81L,1L,3L,9L,1L,3L,3L,3L,1L,9L,3L,3L,9L,3L,3L,3L,1L,9L,27L,1L,1L,3L,3L,1L,9L,1L,3L,27L,1L,3L,3L,3L,1L,9L,3L,1L,9L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278509Inst : IEnumerable<long>
{
public static readonly long[] Value=A278509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278509.Bytes);
public long this[int i]=>Value[i];

public static A278509Inst Instance=new A278509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278510
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,4L,0L,9L,8L,7L,0L,16L,0L,10L,14L,28L,0L,28L,0L,27L,20L,15L,0L,47L,24L,18L,48L,38L,0L,47L,0L,75L,30L,23L,34L,78L,0L,26L,36L,78L,0L,66L,0L,57L,80L,31L,0L,122L,48L,78L,46L,68L,0L,128L,50L,109L,52L,38L,0L,129L,0L,41L,112L,186L,60L,99L,0L,87L,62L,109L,0L,197L,0L,48L,132L,98L,70L,118L,0L,201L,208L,53L,0L,180L,76L,56L,76L,164L,0L,211L,84L,117L,82L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278510Inst : IEnumerable<long>
{
public static readonly long[] Value=A278510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278510.Bytes);
public long this[int i]=>Value[i];

public static A278510Inst Instance=new A278510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278511
{
public static readonly long[] Value={ 2L,4L,3L,6L,5L,7L,8L,11L,9L,13L,10L,17L,21L,15L,19L,12L,23L,33L,37L,25L,27L,14L,29L,45L,55L,51L,31L,39L,16L,35L,57L,75L,85L,73L,43L,49L,18L,41L,69L,97L,111L,121L,99L,61L,63L,20L,47L,81L,115L,145L,159L,151L,127L,67L,79L,22L,53L,93L,135L,171L,199L,211L,193L,163L,87L,91L,24L,59L,105L,157L,205L,243L,267L,271L,247L,187L,103L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278511Inst : IEnumerable<long>
{
public static readonly long[] Value=A278511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278511.Bytes);
public long this[int i]=>Value[i];

public static A278511Inst Instance=new A278511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278512
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,7L,8L,10L,12L,9L,17L,11L,23L,15L,30L,13L,38L,16L,47L,14L,57L,18L,68L,21L,80L,22L,93L,24L,107L,28L,122L,19L,138L,31L,155L,20L,173L,29L,192L,39L,212L,36L,233L,25L,255L,48L,278L,37L,302L,27L,327L,58L,353L,26L,380L,32L,408L,69L,437L,45L,467L,46L,498L,81L,530L,55L,563L,40L,597L,94L,632L,35L,668L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278512Inst : IEnumerable<long>
{
public static readonly long[] Value=A278512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278512.Bytes);
public long this[int i]=>Value[i];

public static A278512Inst Instance=new A278512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278513
{
public static readonly long[] Value={ -1L,1L,0L,-1L,1L,0L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,-1L,0L,0L,1L,-1L,0L,-1L,0L,0L,-1L,-1L,0L,0L,-1L,0L,-1L,1L,0L,0L,1L,0L,0L,-1L,-1L,0L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,-1L,1L,0L,0L,-1L,0L,1L,1L,0L,0L,-1L,0L,0L,-1L,0L,-1L,1L,-1L,0L,0L,-1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,0L,0L,1L,0L,0L,0L,-1L,0L,-1L,-1L,0L,1L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278513Inst : IEnumerable<long>
{
public static readonly long[] Value=A278513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278513.Bytes);
public long this[int i]=>Value[i];

public static A278513Inst Instance=new A278513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278514
{
public static readonly long[] Value={ 0L,-1L,0L,0L,-1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,2L,2L,1L,1L,1L,2L,1L,1L,0L,0L,0L,-1L,-2L,-2L,-2L,-3L,-3L,-4L,-3L,-3L,-3L,-2L,-2L,-2L,-3L,-4L,-4L,-4L,-3L,-3L,-3L,-2L,-2L,-2L,-3L,-2L,-2L,-3L,-2L,-2L,-2L,-3L,-3L,-2L,-1L,-1L,-1L,-2L,-2L,-2L,-3L,-3L,-4L,-3L,-4L,-4L,-4L,-5L,-5L,-5L,-4L,-4L,-3L,-2L,-2L,-1L,0L,0L,-1L,-2L,-3L,-3L,-3L,-3L,-3L,-3L,-4L,-5L,-5L,-4L,-4L,-4L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278514Inst : IEnumerable<long>
{
public static readonly long[] Value=A278514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278514.Bytes);
public long this[int i]=>Value[i];

public static A278514Inst Instance=new A278514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278515
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,0L,0L,1L,4L,0L,3L,0L,0L,2L,0L,0L,1L,0L,0L,4L,0L,0L,3L,0L,2L,0L,0L,1L,0L,0L,5L,0L,4L,0L,0L,3L,0L,2L,0L,0L,1L,0L,0L,5L,0L,4L,0L,0L,3L,0L,0L,2L,0L,0L,0L,1L,7L,0L,0L,6L,0L,0L,5L,0L,4L,0L,0L,3L,0L,0L,2L,0L,1L,0L,0L,7L,0L,6L,0L,0L,5L,0L,4L,0L,0L,3L,0L,0L,2L,0L,0L,1L,0L,0L,7L,0L,0L,6L,0L,0L,5L,0L,0L,0L,4L,0L,0L,3L,0L,2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278515Inst : IEnumerable<long>
{
public static readonly long[] Value=A278515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278515.Bytes);
public long this[int i]=>Value[i];

public static A278515Inst Instance=new A278515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278516
{
public static readonly long[] Value={ 4L,4L,1L,3L,3L,2L,2L,2L,1L,4L,3L,2L,2L,4L,1L,1L,3L,1L,3L,3L,1L,3L,3L,3L,1L,2L,1L,2L,2L,1L,3L,3L,1L,3L,1L,1L,2L,4L,2L,1L,1L,1L,3L,1L,4L,3L,2L,2L,2L,1L,1L,2L,2L,2L,3L,1L,2L,3L,2L,2L,2L,1L,3L,3L,1L,2L,3L,2L,1L,1L,2L,4L,2L,2L,3L,1L,2L,1L,3L,3L,1L,3L,3L,1L,1L,1L,2L,3L,1L,3L,2L,3L,1L,3L,1L,1L,3L,2L,2L,3L,1L,2L,2L,1L,3L,3L,2L,2L,1L,1L,2L,1L,1L,3L,3L,2L,1L,4L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278516Inst : IEnumerable<long>
{
public static readonly long[] Value=A278516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278516.Bytes);
public long this[int i]=>Value[i];

public static A278516Inst Instance=new A278516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278517
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,12L,16L,18L,20L,24L,25L,29L,32L,34L,36L,40L,43L,45L,48L,49L,52L,56L,58L,61L,64L,67L,70L,72L,74L,77L,80L,81L,84L,88L,90L,93L,96L,98L,100L,104L,106L,109L,113L,116L,120L,121L,125L,128L,130L,133L,136L,139L,142L,144L,146L,148L,152L,155L,157L,160L,162L,164L,168L,169L,172L,176L,178L,180L,184L,187L,190L,193L,196L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278517Inst : IEnumerable<long>
{
public static readonly long[] Value=A278517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278517.Bytes);
public long this[int i]=>Value[i];

public static A278517Inst Instance=new A278517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278518
{
public static readonly long[] Value={ 1L,3L,4L,1L,3L,4L,2L,2L,4L,1L,4L,3L,2L,2L,4L,3L,2L,3L,1L,3L,4L,2L,3L,3L,3L,3L,2L,2L,3L,3L,1L,3L,4L,2L,3L,3L,2L,2L,4L,2L,3L,4L,3L,4L,1L,4L,3L,2L,3L,3L,3L,3L,2L,2L,2L,4L,3L,2L,3L,2L,2L,4L,1L,3L,4L,2L,2L,4L,3L,3L,3L,3L,4L,2L,3L,3L,3L,3L,3L,4L,3L,1L,3L,4L,2L,3L,4L,3L,4L,2L,3L,3L,3L,2L,3L,3L,2L,3L,2L,3L,3L,3L,3L,2L,1L,3L,4L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,1L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278518Inst : IEnumerable<long>
{
public static readonly long[] Value=A278518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278518.Bytes);
public long this[int i]=>Value[i];

public static A278518Inst Instance=new A278518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278519
{
public static readonly long[] Value={ 0L,3L,7L,8L,11L,15L,17L,19L,23L,24L,28L,31L,33L,35L,39L,42L,44L,47L,48L,51L,55L,57L,60L,63L,66L,69L,71L,73L,76L,79L,80L,83L,87L,89L,92L,95L,97L,99L,103L,105L,108L,112L,115L,119L,120L,124L,127L,129L,132L,135L,138L,141L,143L,145L,147L,151L,154L,156L,159L,161L,163L,167L,168L,171L,175L,177L,179L,183L,186L,189L,192L,195L,199L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278519Inst : IEnumerable<long>
{
public static readonly long[] Value=A278519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278519.Bytes);
public long this[int i]=>Value[i];

public static A278519Inst Instance=new A278519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278520
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,-1L,2L,0L,2L,0L,3L,0L,0L,0L,0L,0L,4L,1L,4L,0L,3L,-2L,5L,-2L,6L,0L,2L,0L,0L,2L,6L,-1L,1L,0L,7L,3L,6L,0L,4L,0L,8L,0L,8L,0L,4L,-3L,0L,4L,10L,0L,-1L,0L,9L,5L,9L,0L,4L,0L,10L,2L,0L,1L,6L,0L,12L,6L,2L,0L,2L,0L,11L,-2L,14L,-2L,8L,0L,8L,-3L,12L,0L,7L,2L,13L,7L,12L,0L,2L,-1L,16L,8L,14L,3L,5L,0L,0L,4L,2L,0L,10L,0L,15L,0L,15L,0L,0L,0L,4L,9L,12L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278520Inst : IEnumerable<long>
{
public static readonly long[] Value=A278520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278520.Bytes);
public long this[int i]=>Value[i];

public static A278520Inst Instance=new A278520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278521
{
public static readonly long[] Value={ 0L,2L,2L,0L,2L,3L,0L,0L,1L,0L,2L,1L,0L,1L,2L,0L,0L,0L,0L,2L,1L,0L,1L,2L,0L,0L,0L,0L,1L,1L,0L,2L,1L,0L,0L,0L,0L,1L,2L,1L,2L,3L,2L,1L,0L,2L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,1L,3L,2L,2L,2L,2L,2L,0L,1L,2L,2L,2L,2L,2L,0L,0L,2L,3L,1L,2L,3L,2L,1L,0L,1L,2L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278521Inst : IEnumerable<long>
{
public static readonly long[] Value=A278521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278521.Bytes);
public long this[int i]=>Value[i];

public static A278521Inst Instance=new A278521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278522
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,1L,2L,0L,1L,1L,1L,0L,1L,2L,1L,2L,0L,0L,2L,1L,1L,0L,2L,2L,1L,1L,1L,1L,0L,0L,2L,1L,2L,2L,1L,0L,1L,0L,0L,0L,0L,2L,0L,1L,1L,1L,1L,1L,2L,2L,0L,1L,0L,2L,2L,1L,1L,1L,1L,2L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,2L,1L,1L,0L,2L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,1L,0L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,2L,0L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278522Inst : IEnumerable<long>
{
public static readonly long[] Value=A278522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278522.Bytes);
public long this[int i]=>Value[i];

public static A278522Inst Instance=new A278522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278523
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,4L,6L,2L,12L,2L,6L,6L,16L,2L,12L,2L,12L,8L,6L,2L,24L,4L,6L,6L,12L,2L,30L,2L,32L,12L,6L,6L,36L,2L,6L,6L,24L,2L,30L,2L,12L,16L,6L,2L,48L,4L,12L,12L,12L,2L,24L,8L,24L,12L,6L,2L,60L,2L,6L,6L,64L,6L,30L,2L,12L,24L,30L,2L,72L,2L,6L,6L,12L,6L,30L,2L,48L,12L,6L,2L,60L,12L,6L,30L,24L,2L,60L,8L,12L,32L,6L,6L,96L,2L,12L,6L,36L,2L,30L,2L,24L,36L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278523Inst : IEnumerable<long>
{
public static readonly long[] Value=A278523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278523.Bytes);
public long this[int i]=>Value[i];

public static A278523Inst Instance=new A278523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278524
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,4L,6L,2L,12L,2L,6L,6L,16L,2L,12L,2L,12L,8L,6L,2L,24L,4L,6L,6L,12L,2L,30L,2L,32L,12L,6L,6L,36L,2L,6L,6L,24L,2L,24L,2L,12L,16L,6L,2L,48L,4L,12L,12L,12L,2L,30L,8L,24L,12L,6L,2L,60L,2L,6L,6L,64L,6L,60L,2L,12L,24L,30L,2L,72L,2L,6L,6L,12L,6L,30L,2L,48L,12L,6L,2L,72L,12L,6L,30L,24L,2L,48L,8L,12L,32L,6L,6L,96L,2L,12L,6L,36L,2L,60L,2L,24L,36L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278524Inst : IEnumerable<long>
{
public static readonly long[] Value=A278524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278524.Bytes);
public long this[int i]=>Value[i];

public static A278524Inst Instance=new A278524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278525
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,2L,8L,6L,4L,2L,8L,2L,4L,6L,16L,2L,12L,2L,8L,6L,4L,2L,16L,6L,4L,12L,8L,2L,12L,2L,32L,6L,4L,6L,24L,2L,4L,6L,16L,2L,12L,2L,8L,12L,4L,2L,32L,6L,12L,6L,8L,2L,36L,6L,16L,6L,4L,2L,24L,2L,4L,12L,64L,6L,12L,2L,8L,6L,12L,2L,48L,2L,4L,30L,8L,6L,12L,2L,32L,24L,4L,2L,24L,6L,4L,6L,16L,2L,36L,6L,8L,6L,4L,6L,64L,2L,12L,12L,24L,2L,12L,2L,16L,30L,4L,2L,72L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278525Inst : IEnumerable<long>
{
public static readonly long[] Value=A278525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278525.Bytes);
public long this[int i]=>Value[i];

public static A278525Inst Instance=new A278525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278526
{
public static readonly long[] Value={ 1L,2L,4L,2L,6L,2L,4L,2L,8L,2L,12L,2L,6L,2L,16L,2L,6L,2L,6L,2L,6L,2L,6L,2L,8L,2L,24L,2L,6L,2L,6L,2L,12L,2L,12L,2L,30L,2L,4L,2L,6L,2L,6L,2L,24L,2L,6L,2L,6L,2L,24L,2L,6L,2L,36L,2L,30L,2L,6L,2L,12L,2L,6L,2L,6L,2L,32L,2L,12L,2L,12L,2L,12L,2L,12L,2L,30L,2L,6L,2L,30L,2L,16L,2L,72L,2L,12L,2L,60L,2L,12L,2L,12L,2L,4L,2L,6L,2L,48L,2L,24L,2L,6L,2L,12L,2L,6L,2L,120L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278526Inst : IEnumerable<long>
{
public static readonly long[] Value=A278526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278526.Bytes);
public long this[int i]=>Value[i];

public static A278526Inst Instance=new A278526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278527
{
public static readonly long[] Value={ 1L,4L,2L,4L,2L,6L,2L,16L,2L,6L,2L,12L,2L,8L,2L,6L,2L,6L,2L,24L,2L,8L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,12L,2L,6L,2L,30L,2L,36L,2L,6L,2L,24L,2L,6L,2L,6L,2L,24L,2L,6L,2L,6L,2L,4L,2L,30L,2L,12L,2L,12L,2L,24L,2L,6L,2L,30L,2L,48L,2L,72L,2L,6L,2L,60L,2L,12L,2L,12L,2L,120L,2L,6L,2L,12L,2L,6L,2L,24L,2L,48L,2L,6L,2L,4L,2L,12L,2L,12L,2L,60L,2L,12L,2L,72L,2L,16L,2L,30L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278527Inst : IEnumerable<long>
{
public static readonly long[] Value=A278527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278527.Bytes);
public long this[int i]=>Value[i];

public static A278527Inst Instance=new A278527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278528
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,0L,1L,3L,1L,2L,1L,0L,1L,4L,1L,2L,1L,0L,1L,3L,1L,2L,1L,5L,1L,0L,1L,2L,1L,6L,1L,3L,1L,2L,1L,4L,1L,0L,1L,2L,1L,7L,1L,3L,1L,2L,1L,0L,1L,5L,1L,2L,1L,4L,1L,3L,1L,2L,1L,8L,1L,0L,1L,2L,1L,9L,1L,3L,1L,2L,1L,6L,1L,4L,1L,2L,1L,0L,1L,3L,1L,2L,1L,5L,1L,10L,1L,2L,1L,0L,1L,3L,1L,2L,1L,4L,1L,7L,1L,2L,1L,11L,1L,3L,1L,2L,1L,0L,1L,5L,1L,2L,1L,4L,1L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278528Inst : IEnumerable<long>
{
public static readonly long[] Value=A278528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278528.Bytes);
public long this[int i]=>Value[i];

public static A278528Inst Instance=new A278528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278529
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,4L,1L,5L,2L,6L,0L,7L,1L,8L,3L,9L,0L,10L,2L,11L,4L,12L,1L,13L,0L,14L,5L,15L,1L,16L,3L,17L,6L,18L,2L,19L,0L,20L,7L,21L,1L,22L,4L,23L,8L,24L,0L,25L,2L,26L,9L,27L,3L,28L,5L,29L,10L,30L,1L,31L,0L,32L,11L,33L,1L,34L,6L,35L,12L,36L,2L,37L,4L,38L,13L,39L,0L,40L,7L,41L,14L,42L,3L,43L,1L,44L,15L,45L,0L,46L,8L,47L,16L,48L,5L,49L,2L,50L,17L,51L,1L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278529Inst : IEnumerable<long>
{
public static readonly long[] Value=A278529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278529.Bytes);
public long this[int i]=>Value[i];

public static A278529Inst Instance=new A278529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278530
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,5L,5L,6L,4L,8L,8L,10L,7L,11L,9L,10L,5L,12L,12L,16L,11L,18L,15L,17L,9L,18L,16L,20L,12L,19L,14L,15L,6L,17L,17L,24L,16L,28L,23L,27L,14L,29L,26L,33L,20L,32L,24L,26L,11L,27L,25L,34L,21L,36L,28L,32L,15L,31L,26L,33L,18L,29L,20L,21L,7L,23L,23L,34L,22L,41L,33L,40L,20L,44L,39L,51L,30L,50L,37L,41L,17L,43L,40L,55L,34L,59L,46L,53L,25L,52L,44L,56L,31L,50L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278530Inst : IEnumerable<long>
{
public static readonly long[] Value=A278530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278530.Bytes);
public long this[int i]=>Value[i];

public static A278530Inst Instance=new A278530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278531
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,4L,6L,2L,16L,8L,12L,4L,12L,6L,6L,2L,32L,16L,24L,8L,36L,12L,12L,4L,24L,12L,30L,6L,12L,6L,6L,2L,64L,32L,48L,16L,72L,24L,24L,8L,72L,36L,60L,12L,36L,12L,12L,4L,48L,24L,60L,12L,60L,30L,30L,6L,24L,12L,30L,6L,12L,6L,6L,2L,128L,64L,96L,32L,144L,48L,48L,16L,216L,72L,120L,24L,72L,24L,24L,8L,144L,72L,180L,36L,180L,60L,60L,12L,72L,36L,60L,12L,36L,12L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278531Inst : IEnumerable<long>
{
public static readonly long[] Value=A278531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278531.Bytes);
public long this[int i]=>Value[i];

public static A278531Inst Instance=new A278531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278532
{
public static readonly long[] Value={ 1L,4L,4L,6L,16L,6L,6L,36L,24L,24L,6L,6L,4L,36L,64L,24L,60L,60L,24L,6L,6L,4L,36L,144L,60L,64L,216L,24L,6L,60L,96L,60L,60L,60L,24L,6L,6L,4L,36L,144L,60L,144L,60L,60L,144L,64L,96L,216L,216L,24L,6L,60L,240L,210L,96L,360L,60L,6L,60L,96L,60L,60L,60L,24L,6L,6L,4L,36L,144L,60L,144L,60L,60L,900L,144L,360L,360L,60L,60L,144L,144L,240L,384L,96L,360L,216L,360L,216L,216L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278532Inst : IEnumerable<long>
{
public static readonly long[] Value=A278532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278532.Bytes);
public long this[int i]=>Value[i];

public static A278532Inst Instance=new A278532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278533
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,4L,2L,16L,12L,12L,6L,8L,6L,4L,2L,32L,24L,36L,12L,24L,30L,12L,6L,16L,12L,12L,6L,8L,6L,4L,2L,64L,48L,72L,24L,72L,60L,36L,12L,48L,60L,60L,30L,24L,30L,12L,6L,32L,24L,36L,12L,24L,30L,12L,6L,16L,12L,12L,6L,8L,6L,4L,2L,128L,96L,144L,48L,216L,120L,72L,24L,144L,180L,180L,60L,72L,60L,36L,12L,96L,120L,180L,60L,120L,210L,60L,30L,48L,60L,60L,30L,24L,30L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278533Inst : IEnumerable<long>
{
public static readonly long[] Value=A278533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278533.Bytes);
public long this[int i]=>Value[i];

public static A278533Inst Instance=new A278533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278534
{
public static readonly long[] Value={ 1L,2L,2L,12L,6L,12L,4L,180L,360L,6L,12L,6L,420L,180L,360L,4L,36L,420L,1260L,1800L,24L,120L,360L,1080L,48L,48L,720L,75600L,6L,12L,6L,420L,180L,360L,6L,60L,2310L,4620L,2520L,60L,420L,1260L,2520L,120L,120L,360L,83160L,5040L,720L,75600L,4L,36L,420L,1260L,1800L,60L,420L,1260L,2520L,180L,180L,900L,12600L,360L,12600L,5400L,720L,277200L,529200L,24L,120L,360L,1080L,120L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278534Inst : IEnumerable<long>
{
public static readonly long[] Value=A278534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278534.Bytes);
public long this[int i]=>Value[i];

public static A278534Inst Instance=new A278534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278535
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,6L,8L,2L,4L,6L,8L,6L,12L,12L,16L,2L,4L,6L,8L,6L,12L,12L,16L,6L,12L,30L,24L,12L,36L,24L,32L,2L,4L,6L,8L,6L,12L,12L,16L,6L,12L,30L,24L,12L,36L,24L,32L,6L,12L,30L,24L,30L,60L,60L,48L,12L,36L,60L,72L,24L,72L,48L,64L,2L,4L,6L,8L,6L,12L,12L,16L,6L,12L,30L,24L,12L,36L,24L,32L,6L,12L,30L,24L,30L,60L,60L,48L,12L,36L,60L,72L,24L,72L,48L,64L,6L,12L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278535Inst : IEnumerable<long>
{
public static readonly long[] Value=A278535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278535.Bytes);
public long this[int i]=>Value[i];

public static A278535Inst Instance=new A278535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278536
{
public static readonly long[] Value={ 3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278536Inst : IEnumerable<long>
{
public static readonly long[] Value=A278536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278536.Bytes);
public long this[int i]=>Value[i];

public static A278536Inst Instance=new A278536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278537
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,1L,4L,2L,5L,3L,6L,1L,7L,2L,8L,4L,9L,1L,10L,3L,11L,5L,12L,2L,13L,1L,14L,6L,15L,2L,16L,4L,17L,7L,18L,3L,19L,1L,20L,8L,21L,2L,22L,5L,23L,9L,24L,1L,25L,3L,26L,10L,27L,4L,28L,6L,29L,11L,30L,2L,31L,1L,32L,12L,33L,2L,34L,7L,35L,13L,36L,3L,37L,5L,38L,14L,39L,1L,40L,8L,41L,15L,42L,4L,43L,2L,44L,16L,45L,1L,46L,9L,47L,17L,48L,6L,49L,3L,50L,18L,51L,2L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278537Inst : IEnumerable<long>
{
public static readonly long[] Value=A278537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278537.Bytes);
public long this[int i]=>Value[i];

public static A278537Inst Instance=new A278537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278538
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,4L,1L,4L,1L,2L,1L,5L,1L,3L,1L,2L,1L,5L,1L,6L,1L,2L,1L,6L,1L,3L,1L,2L,1L,4L,1L,7L,1L,2L,1L,7L,1L,3L,1L,2L,1L,8L,1L,5L,1L,2L,1L,4L,1L,3L,1L,2L,1L,8L,1L,9L,1L,2L,1L,9L,1L,3L,1L,2L,1L,6L,1L,4L,1L,2L,1L,10L,1L,3L,1L,2L,1L,5L,1L,10L,1L,2L,1L,11L,1L,3L,1L,2L,1L,4L,1L,7L,1L,2L,1L,11L,1L,3L,1L,2L,1L,12L,1L,5L,1L,2L,1L,4L,1L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278538Inst : IEnumerable<long>
{
public static readonly long[] Value=A278538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278538.Bytes);
public long this[int i]=>Value[i];

public static A278538Inst Instance=new A278538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278539
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,1L,5L,2L,6L,3L,7L,1L,8L,2L,9L,4L,10L,1L,11L,3L,12L,5L,13L,2L,14L,1L,15L,6L,16L,2L,17L,4L,18L,7L,19L,3L,20L,1L,21L,8L,22L,2L,23L,5L,24L,9L,25L,1L,26L,3L,27L,10L,28L,4L,29L,6L,30L,11L,31L,2L,32L,1L,33L,12L,34L,2L,35L,7L,36L,13L,37L,3L,38L,5L,39L,14L,40L,1L,41L,8L,42L,15L,43L,4L,44L,2L,45L,16L,46L,1L,47L,9L,48L,17L,49L,6L,50L,3L,51L,18L,52L,2L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278539Inst : IEnumerable<long>
{
public static readonly long[] Value=A278539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278539.Bytes);
public long this[int i]=>Value[i];

public static A278539Inst Instance=new A278539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278540
{
public static readonly long[] Value={ 1L,2L,4L,2L,2L,8L,2L,6L,16L,6L,2L,12L,2L,6L,12L,4L,2L,32L,2L,6L,12L,6L,2L,24L,4L,6L,64L,6L,2L,24L,2L,12L,12L,6L,6L,48L,2L,6L,12L,30L,2L,24L,2L,6L,48L,6L,2L,36L,4L,12L,12L,6L,2L,128L,6L,30L,12L,6L,2L,60L,2L,6L,48L,8L,6L,24L,2L,6L,12L,30L,2L,96L,2L,6L,36L,6L,6L,24L,2L,12L,256L,6L,2L,60L,6L,6L,12L,30L,2L,96L,6L,6L,12L,6L,6L,72L,2L,12L,48L,12L,2L,24L,2L,30L,60L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278540Inst : IEnumerable<long>
{
public static readonly long[] Value=A278540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278540.Bytes);
public long this[int i]=>Value[i];

public static A278540Inst Instance=new A278540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278541
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,2L,2L,16L,12L,6L,6L,2L,2L,2L,2L,32L,24L,12L,12L,6L,6L,6L,6L,2L,2L,2L,2L,2L,2L,2L,2L,64L,48L,24L,24L,12L,12L,12L,12L,6L,6L,6L,6L,6L,6L,6L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,128L,96L,48L,48L,24L,24L,24L,24L,12L,12L,12L,12L,12L,12L,12L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278541Inst : IEnumerable<long>
{
public static readonly long[] Value=A278541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278541.Bytes);
public long this[int i]=>Value[i];

public static A278541Inst Instance=new A278541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278542
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,2L,6L,8L,2L,2L,2L,2L,6L,6L,12L,16L,2L,2L,2L,2L,2L,2L,2L,2L,6L,6L,6L,6L,12L,12L,24L,32L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,6L,6L,6L,6L,6L,6L,6L,12L,12L,12L,12L,24L,24L,48L,64L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278542Inst : IEnumerable<long>
{
public static readonly long[] Value=A278542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278542.Bytes);
public long this[int i]=>Value[i];

public static A278542Inst Instance=new A278542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278543
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,6L,1L,1L,6L,6L,2L,2L,6L,30L,1L,1L,30L,12L,2L,2L,24L,60L,2L,2L,60L,60L,6L,6L,30L,210L,1L,1L,210L,60L,12L,6L,120L,360L,2L,2L,720L,240L,6L,12L,360L,1260L,2L,2L,1260L,360L,12L,12L,1080L,2520L,6L,6L,1260L,1260L,30L,30L,210L,2310L,1L,1L,2310L,420L,60L,60L,7560L,7560L,6L,6L,15120L,6480L,24L,24L,2160L,37800L,2L,2L,75600L,6480L,48L,48L,12960L,90720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278543Inst : IEnumerable<long>
{
public static readonly long[] Value=A278543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278543.Bytes);
public long this[int i]=>Value[i];

public static A278543Inst Instance=new A278543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278544
{
public static readonly long[] Value={ 0L,1L,1L,5L,1L,21L,8L,31L,1L,123L,55L,459L,12L,705L,71L,247L,1L,951L,460L,14175L,119L,49275L,2825L,19305L,18L,30075L,3745L,105975L,167L,40845L,886L,2927L,1L,11091L,5585L,789075L,1554L,10546875L,175175L,4276125L,275L,14482125L,1004500L,186553125L,13573L,77371875L,264775L,1656585L,24L,2599275L,354515L,169509375L,19789L,566409375L,2055550L,48691125L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278544Inst : IEnumerable<long>
{
public static readonly long[] Value=A278544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278544.Bytes);
public long this[int i]=>Value[i];

public static A278544Inst Instance=new A278544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278545
{
public static readonly long[] Value={ 3L,5L,5L,5L,8L,5L,5L,8L,8L,5L,5L,8L,8L,8L,5L,5L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278545Inst : IEnumerable<long>
{
public static readonly long[] Value=A278545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278545.Bytes);
public long this[int i]=>Value[i];

public static A278545Inst Instance=new A278545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278546
{
public static readonly long[] Value={ 8L,18L,28L,130L,134L,138L,148L,158L,176L,318L,530L,538L,548L,576L,644L,1300L,2170L,2202L,2212L,2228L,2230L,2248L,8706L,8938L,8948L,34970L,35082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278546Inst : IEnumerable<long>
{
public static readonly long[] Value=A278546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278546.Bytes);
public long this[int i]=>Value[i];

public static A278546Inst Instance=new A278546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278547
{
public static readonly long[] Value={ 0L,0L,4L,65L,456L,2128L,7728L,23607L,63460L,154518L,347568L,732524L,1461824L,2784600L,5095376L,9002010L,15418728L,25691420L,41763900L,66395595L,103443144L,158220680L,237956160L,352364025L,514357740L,740929410L,1054227720L,1482869934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278547Inst : IEnumerable<long>
{
public static readonly long[] Value=A278547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278547.Bytes);
public long this[int i]=>Value[i];

public static A278547Inst Instance=new A278547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278548
{
public static readonly long[] Value={ 0L,70L,1531L,25402L,385040L,4880813L,50476458L,435272199L,3222371162L,21002624643L,122940347621L,656384657007L,3235421775340L,14866063786408L,64169850484506L,261881056692205L,1015819011059751L,3761887253493383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278548Inst : IEnumerable<long>
{
public static readonly long[] Value=A278548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278548.Bytes);
public long this[int i]=>Value[i];

public static A278548Inst Instance=new A278548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278549
{
public static readonly BigInteger[] Value={ 4L,1531L,124564L,6207774L,256173362L,9647190761L,327443433750L,9777854836324L,255595250091256L,5894080544358413L,121339401663068582L,2256920347962876651L,BigInteger.Parse("38335567041339845608"),BigInteger.Parse("600100691863091778854"),BigInteger.Parse("8724164918493189698726") };
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
public class A278549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278549Inst Instance=new A278549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278550
{
public static readonly BigInteger[] Value={ 65L,25402L,6207774L,1116456061L,157222953688L,19154084929099L,2139517647414832L,221564412439675221L,BigInteger.Parse("21066414746632008713"),BigInteger.Parse("1822505605184517876456"),BigInteger.Parse("143141100456641625969627") };
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
public class A278550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278550Inst Instance=new A278550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278551
{
public static readonly BigInteger[] Value={ 456L,385040L,256173362L,157222953688L,81144920762300L,35461508433808988L,13763018389926177995UL,BigInteger.Parse("4934142560387144138930"),BigInteger.Parse("1663165686767641686800894"),BigInteger.Parse("527405729349278899694924962"),BigInteger.Parse("156386875782050138370221520321") };
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
public class A278551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278551Inst Instance=new A278551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278552
{
public static readonly BigInteger[] Value={ 2128L,4880813L,9647190761L,19154084929099L,35461508433808988L,BigInteger.Parse("57645968168131680420"),BigInteger.Parse("82417111259567413303205"),BigInteger.Parse("106532272120153272376122742"),BigInteger.Parse("128078032305270145287175836766") };
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
public class A278552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278552Inst Instance=new A278552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278553
{
public static readonly long[] Value={ 0L,0L,0L,4L,70L,4L,65L,1531L,1531L,65L,456L,25402L,124564L,25402L,456L,2128L,385040L,6207774L,6207774L,385040L,2128L,7728L,4880813L,256173362L,1116456061L,256173362L,4880813L,7728L,23607L,50476458L,9647190761L,157222953688L,157222953688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278553Inst : IEnumerable<long>
{
public static readonly long[] Value=A278553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278553.Bytes);
public long this[int i]=>Value[i];

public static A278553Inst Instance=new A278553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278554
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,29L,55L,101L,175L,323L,583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278554Inst : IEnumerable<long>
{
public static readonly long[] Value=A278554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278554.Bytes);
public long this[int i]=>Value[i];

public static A278554Inst Instance=new A278554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278555
{
public static readonly long[] Value={ 1L,13L,104L,637L,3276L,14808L,60541L,228124L,803010L,2667054L,8422715L,25446304L,73907808L,207209614L,562673618L,1484147681L,3811882087L,9553588317L,23407932874L,56161135485L,132132608899L,305240006266L,693150485885L,1548871015291L,3408852663762L,7395582677152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278555Inst : IEnumerable<long>
{
public static readonly long[] Value=A278555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278555.Bytes);
public long this[int i]=>Value[i];

public static A278555Inst Instance=new A278555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278556
{
public static readonly long[] Value={ 1L,19L,209L,1710L,11495L,66862L,347339L,1645875L,7221520L,29668595L,115116233L,424720338L,1498263563L,5076482415L,16583497160L,52399330389L,160586833362L,478482249548L,1388989067820L,3935549005725L,10901608510397L,29565343541110L,78604103339462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278556Inst : IEnumerable<long>
{
public static readonly long[] Value=A278556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278556.Bytes);
public long this[int i]=>Value[i];

public static A278556Inst Instance=new A278556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278557
{
public static readonly long[] Value={ 1L,25L,350L,3575L,29575L,209381L,1312075L,7443825L,38854075L,188836375L,862496902L,3729343275L,15356254650L,60511763600L,229125615600L,836555203223L,2953900713000L,10113407774450L,33649438734125L,109017926343725L,344525085375315L,1063718962906450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278557Inst : IEnumerable<long>
{
public static readonly long[] Value=A278557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278557.Bytes);
public long this[int i]=>Value[i];

public static A278557Inst Instance=new A278557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278558
{
public static readonly long[] Value={ 1L,31L,527L,6448L,63240L,526443L,3852742L,25380847L,153068700L,855816380L,4479330091L,22117432019L,103672066076L,463698703204L,1987628351600L,8195086588810L,32603090921532L,125497791966435L,468512597653134L,1699911932127300L,6005651320362628L,20693956328627358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278558Inst : IEnumerable<long>
{
public static readonly long[] Value=A278558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278558.Bytes);
public long this[int i]=>Value[i];

public static A278558Inst Instance=new A278558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278559
{
public static readonly BigInteger[] Value={ 1575L,173525L,7089500L,169229875L,2841940500L,37027355200L,397125074750L,3646072432125L,29454549941750L,213636919820625L,1412749565173450L,8620496275465025L,49005643635237875L,261578907351144125L,1319510599727473500L,6324621482504294325L,BigInteger.Parse("28938037257084798150") };
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
public class A278559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278559Inst Instance=new A278559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278560
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,9L,10L,13L,14L,16L,17L,19L,21L,25L,26L,29L,30L,32L,37L,38L,40L,41L,42L,46L,48L,49L,50L,51L,54L,58L,59L,65L,66L,69L,70L,72L,73L,74L,77L,78L,81L,83L,85L,89L,90L,97L,98L,101L,102L,104L,105L,106L,109L,114L,117L,118L,120L,122L,125L,128L,129L,130L,131L,134L,136L,138L,139L,144L,145L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278560Inst : IEnumerable<long>
{
public static readonly long[] Value=A278560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278560.Bytes);
public long this[int i]=>Value[i];

public static A278560Inst Instance=new A278560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278561
{
public static readonly long[] Value={ 2L,3L,10L,7L,252L,396L,6435L,858L,680680L,1175720L,5290740L,9360540L,1029659400L,617795640L,116454478140L,1061790830100L,283144221360L,74511637200L,14060345939640L,14060345939640L,109530094869795600L,650075097225840L,51193413906534900L,481218090721428060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278561Inst : IEnumerable<long>
{
public static readonly long[] Value=A278561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278561.Bytes);
public long this[int i]=>Value[i];

public static A278561Inst Instance=new A278561Inst();

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