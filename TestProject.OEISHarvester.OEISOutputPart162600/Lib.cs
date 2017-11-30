using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A284104
{
public static readonly long[] Value={ 0L,0L,0L,0L,5L,0L,0L,0L,0L,5L,11L,0L,0L,0L,5L,0L,17L,0L,0L,5L,0L,11L,23L,0L,5L,0L,0L,0L,29L,5L,0L,0L,11L,17L,40L,0L,0L,0L,0L,5L,41L,0L,0L,11L,5L,23L,47L,0L,0L,5L,17L,0L,53L,0L,16L,0L,0L,29L,59L,5L,0L,0L,0L,0L,70L,11L,0L,17L,23L,40L,71L,0L,0L,0L,5L,0L,88L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284104Inst : IEnumerable<long>
{
public static readonly long[] Value=A284104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284104.Bytes);
public long this[int i]=>Value[i];

public static A284104Inst Instance=new A284104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284105
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,6L,13L,0L,0L,0L,0L,6L,0L,20L,0L,0L,0L,6L,0L,13L,27L,0L,0L,6L,0L,0L,0L,34L,0L,6L,0L,0L,13L,20L,41L,6L,0L,0L,0L,0L,0L,54L,0L,0L,0L,13L,0L,33L,55L,0L,0L,0L,0L,26L,0L,62L,0L,0L,13L,6L,0L,34L,69L,0L,0L,6L,0L,0L,0L,76L,0L,19L,0L,20L,27L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284105Inst : IEnumerable<long>
{
public static readonly long[] Value=A284105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284105.Bytes);
public long this[int i]=>Value[i];

public static A284105Inst Instance=new A284105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284106
{
public static readonly BigInteger[] Value={ 1L,4L,25L,5896L,905327L,3514396333L,12336109217951L,635264284970617848L,BigInteger.Parse("46214926085757662096414") };
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
public class A284106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284106Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284106.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284106Inst Instance=new A284106Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284107
{
public static readonly long[] Value={ 2L,4L,13L,46L,160L,571L,2095L,7802L,29326L,111040L,422862L,1617611L,6210935L,23922207L,92387315L,357629430L,1387192894L,5390374430L,20979391112L,81768490420L,319107181678L,1246785919174L,4876478734046L,19091509694075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284107Inst : IEnumerable<long>
{
public static readonly long[] Value=A284107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284107.Bytes);
public long this[int i]=>Value[i];

public static A284107Inst Instance=new A284107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284108
{
public static readonly long[] Value={ 3L,13L,25L,435L,1230L,20275L,67957L,1057769L,4091201L,57977326L,251405237L,3267210309L,15553103766L,187647577263L,965234391129L,10933376520347L,60012823834203L,644348267987097L,3735767137025182L,38329302231936856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284108Inst : IEnumerable<long>
{
public static readonly long[] Value=A284108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284108.Bytes);
public long this[int i]=>Value[i];

public static A284108Inst Instance=new A284108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284109
{
public static readonly ulong[] Value={ 6L,46L,435L,5896L,80200L,1143533L,16442183L,240146980L,3538905880L,52568393480L,785872613710L,11812436439395L,178382105544907L,2704771593353921L,41159406062915663L,628343298365437332L,9619941922149572518UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284109Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284109.Bytes);
public ulong this[int i]=>Value[i];

public static A284109Inst Instance=new A284109Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284110
{
public static readonly BigInteger[] Value={ 10L,160L,1230L,80200L,905327L,61595318L,835390074L,51786529350L,809052347723L,45439256969227L,794944298301218L,40943771868824816L,785978026788227426L,BigInteger.Parse("37601651099754921818"),BigInteger.Parse("779704805295540859956"),BigInteger.Parse("35038029006397610068684") };
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
public class A284110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284110Inst Instance=new A284110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284111
{
public static readonly BigInteger[] Value={ 19L,571L,20275L,1143533L,61595318L,3514396333L,202053817163L,11804599876991L,696189477669561L,41397421665690592L,2478089134627067931L,BigInteger.Parse("149178023741969838411"),BigInteger.Parse("9023810344121753702370"),BigInteger.Parse("548148352070756658354415") };
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
public class A284111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284111Inst Instance=new A284111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284112
{
public static readonly BigInteger[] Value={ 33L,2095L,67957L,16442183L,835390074L,202053817163L,12336109217951L,2717300368732547L,189648871247418668L,BigInteger.Parse("38157272354610084376"),BigInteger.Parse("2957145586181369921070"),BigInteger.Parse("550690134528386541356991") };
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
public class A284112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284112Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284112.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284112Inst Instance=new A284112Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284113
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,6L,13L,13L,6L,10L,46L,25L,46L,10L,19L,160L,435L,435L,160L,19L,33L,571L,1230L,5896L,1230L,571L,33L,62L,2095L,20275L,80200L,80200L,20275L,2095L,62L,112L,7802L,67957L,1143533L,905327L,1143533L,67957L,7802L,112L,212L,29326L,1057769L,16442183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284113Inst : IEnumerable<long>
{
public static readonly long[] Value=A284113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284113.Bytes);
public long this[int i]=>Value[i];

public static A284113Inst Instance=new A284113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284114
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,5L,4L,7L,9L,12L,5L,22L,6L,17L,19L,55L,7L,50L,8L,60L,28L,32L,9L,166L,37L,41L,113L,122L,10L,137L,11L,631L,51L,56L,57L,475L,12L,64L,66L,620L,13L,258L,14L,282L,301L,83L,15L,2229L,90L,359L,95L,394L,16L,1302L,105L,1435L,109L,114L,17L,1708L,18L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284114Inst : IEnumerable<long>
{
public static readonly long[] Value=A284114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284114.Bytes);
public long this[int i]=>Value[i];

public static A284114Inst Instance=new A284114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284131
{
public static readonly long[] Value={ 9L,21L,21L,54L,49L,54L,141L,126L,126L,141L,369L,329L,324L,329L,369L,966L,861L,846L,846L,861L,966L,2529L,2254L,2214L,2209L,2214L,2254L,2529L,6621L,5901L,5796L,5781L,5781L,5796L,5901L,6621L,17334L,15449L,15174L,15134L,15129L,15134L,15174L,15449L,17334L,45381L,40446L,45381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284131Inst : IEnumerable<long>
{
public static readonly long[] Value=A284131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284131.Bytes);
public long this[int i]=>Value[i];

public static A284131Inst Instance=new A284131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284132
{
public static readonly long[] Value={ 4L,5L,7L,9L,13L,15L,17L,19L,23L,27L,41L,55L,63L,121L,177L,213L,219L,233L,241L,325L,335L,349L,357L,363L,373L,377L,421L,455L,503L,595L,775L,1053L,1297L,1447L,1501L,1765L,1871L,1915L,2111L,3039L,3801L,4993L,5273L,6753L,9247L,12063L,13433L,13663L,14783L,16295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284132Inst : IEnumerable<long>
{
public static readonly long[] Value=A284132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284132.Bytes);
public long this[int i]=>Value[i];

public static A284132Inst Instance=new A284132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284133
{
public static readonly BigInteger[] Value={ 1L,0L,1L,0L,101L,0L,10101L,0L,1011101L,1000L,101000001L,11100L,10111001001L,10000000L,1010000111101L,110011000L,101110000000001L,100111101100L,10100000011000001L,1111000001100L,1011100110011100001L,1000000001001100L,BigInteger.Parse("101000011110100000001"),11001100001001100L };
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
public class A284133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284133Inst Instance=new A284133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284134
{
public static readonly BigInteger[] Value={ 1L,0L,100L,0L,10100L,0L,1010100L,0L,101110100L,1000000L,10000010100L,1110000000L,1001001110100L,1000000L,101111000010100L,1100110000000L,10000000001110100L,1101111001000000L,1000001100000010100L,110000011110000000L,BigInteger.Parse("100001110011001110100"),11001000000001000000UL };
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
public class A284134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284134Inst Instance=new A284134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284135
{
public static readonly long[] Value={ 1L,0L,1L,0L,5L,0L,21L,0L,93L,8L,321L,28L,1481L,128L,5181L,408L,23553L,2540L,82113L,7692L,380129L,32844L,1326337L,104524L,6029569L,650364L,21020985L,1969168L,97313237L,8408208L,339542021L,26759056L,1543571205L,166490672L,5381365893L,504114864L,24912176453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284135Inst : IEnumerable<long>
{
public static readonly long[] Value=A284135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284135.Bytes);
public long this[int i]=>Value[i];

public static A284135Inst Instance=new A284135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284136
{
public static readonly long[] Value={ 1L,0L,4L,0L,20L,0L,84L,0L,372L,64L,1044L,896L,4724L,64L,24084L,6528L,65652L,56896L,268308L,198528L,1107572L,819264L,4218388L,3283328L,16842868L,16309824L,82057236L,8587136L,359720564L,38568000L,1342201364L,166861184L,5398134900L,825810496L,21611419668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284136Inst : IEnumerable<long>
{
public static readonly long[] Value=A284136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284136.Bytes);
public long this[int i]=>Value[i];

public static A284136Inst Instance=new A284136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284137
{
public static readonly ulong[] Value={ 1L,10L,101L,1010L,10111L,101011L,1011101L,10101010L,101111101L,1010111010L,10111010111L,101010111011L,1011111010101L,10101110101010L,101110101110101L,1010101110101010L,10111110101010101L,101011101111101010L,1011101010111010101L,10101011111010111010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284137Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284137.Bytes);
public ulong this[int i]=>Value[i];

public static A284137Inst Instance=new A284137Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284138
{
public static readonly long[] Value={ 1L,1L,101L,101L,11101L,110101L,1011101L,1010101L,101111101L,101110101L,11101011101L,110111010101L,1010101111101L,1010101110101L,101011101011101L,101010111010101L,10101010101111101L,10101111101110101L,1010101110101011101L,1011101011111010101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284138Inst : IEnumerable<long>
{
public static readonly long[] Value=A284138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284138.Bytes);
public long this[int i]=>Value[i];

public static A284138Inst Instance=new A284138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284139
{
public static readonly long[] Value={ 1L,2L,5L,10L,23L,43L,93L,170L,381L,698L,1495L,2747L,6101L,11178L,23925L,43946L,97621L,179178L,382421L,704186L,1563989L,2862058L,6125013L,11251370L,24991061L,45869738L,97899861L,180271786L,400381269L,732674730L,1567970645L,2880436906L,6397883733L,11742735018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284139Inst : IEnumerable<long>
{
public static readonly long[] Value=A284139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284139.Bytes);
public long this[int i]=>Value[i];

public static A284139Inst Instance=new A284139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284140
{
public static readonly long[] Value={ 1L,1L,5L,5L,29L,53L,93L,85L,381L,373L,1885L,3541L,5501L,5493L,22365L,21973L,87421L,89973L,351581L,382933L,1398653L,1439093L,5625693L,5600725L,22369661L,22372213L,89480541L,89511893L,357914493L,358053237L,1431656285L,1432352213L,5727311229L,5727281013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284140Inst : IEnumerable<long>
{
public static readonly long[] Value=A284140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284140.Bytes);
public long this[int i]=>Value[i];

public static A284140Inst Instance=new A284140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284141
{
public static readonly ulong[] Value={ 1L,11L,101L,1101L,10001L,111011L,1010001L,11011011L,100000001L,1110000011L,10101000101L,110101100101L,1000100000101L,11101110001101L,101000101000001L,1101101101100011L,10000000000000101L,111000000000001101L,1010100000000010001L,11010110000000010011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284141Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284141.Bytes);
public ulong this[int i]=>Value[i];

public static A284141Inst Instance=new A284141Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284142
{
public static readonly ulong[] Value={ 1L,11L,101L,1011L,10001L,110111L,1000101L,11011011L,100000001L,1100000111L,10100010101L,101001101011L,1010000010001L,10110001110111L,100000101000101L,1100011011011011L,10100000000000001L,101100000000000111L,1000100000000010101L,11001000000001101011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284142Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284142.Bytes);
public ulong this[int i]=>Value[i];

public static A284142Inst Instance=new A284142Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284143
{
public static readonly long[] Value={ 1L,3L,5L,13L,17L,59L,81L,219L,257L,899L,1349L,3429L,4357L,15245L,20801L,56163L,65541L,229389L,344081L,876563L,1114133L,3899421L,5324841L,14377007L,16781431L,58734755L,88085989L,224409287L,285214731L,998251529L,1363159053L,3678415891L,4299186709L,15038714647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284143Inst : IEnumerable<long>
{
public static readonly long[] Value=A284143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284143.Bytes);
public long this[int i]=>Value[i];

public static A284143Inst Instance=new A284143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284144
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,55L,69L,219L,257L,775L,1301L,2667L,5137L,11383L,16709L,50907L,81921L,180231L,278549L,819307L,1376273L,3014775L,4849989L,15992539L,31199233L,51671047L,87900181L,238469227L,436338705L,604897399L,1477050693L,3358851803L,5646320641L,15621953543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284144Inst : IEnumerable<long>
{
public static readonly long[] Value=A284144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284144.Bytes);
public long this[int i]=>Value[i];

public static A284144Inst Instance=new A284144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284145
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,4L,9L,11L,13L,17L,19L,8L,21L,23L,25L,29L,31L,37L,16L,27L,41L,43L,47L,53L,35L,59L,61L,67L,49L,71L,73L,33L,79L,83L,85L,89L,97L,101L,95L,103L,14L,107L,109L,113L,121L,127L,131L,137L,139L,143L,115L,149L,151L,157L,133L,163L,65L,167L,173L,179L,6L,181L,187L,191L,193L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284145Inst : IEnumerable<long>
{
public static readonly long[] Value=A284145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284145.Bytes);
public long this[int i]=>Value[i];

public static A284145Inst Instance=new A284145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284146
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,23L,17L,29L,13L,47L,19L,37L,41L,53L,61L,43L,59L,31L,67L,83L,71L,89L,73L,101L,79L,103L,97L,113L,227L,109L,223L,107L,229L,131L,257L,139L,277L,149L,233L,151L,239L,157L,263L,179L,283L,167L,293L,181L,269L,137L,409L,127L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284146Inst : IEnumerable<long>
{
public static readonly long[] Value=A284146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284146.Bytes);
public long this[int i]=>Value[i];

public static A284146Inst Instance=new A284146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284195
{
public static readonly long[] Value={ 6L,40L,412L,5268L,71181L,1001047L,14392557L,210449237L,3113715736L,46513546197L,700181791562L,10607318574496L,161549350874286L,2471455506147877L,37954136853757557L,584775548813145717L,9035444086858648868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284195Inst : IEnumerable<long>
{
public static readonly long[] Value=A284195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284195.Bytes);
public long this[int i]=>Value[i];

public static A284195Inst Instance=new A284195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284196
{
public static readonly BigInteger[] Value={ 10L,131L,1919L,71181L,1488503L,54333131L,1321614728L,45952259333L,1219757876905L,40859784312028L,1146325236883584L,37457479952593565L,1089802904379131200L,BigInteger.Parse("35049513938138368608"),BigInteger.Parse("1044879421569977298080"),BigInteger.Parse("33275440972162414040143") };
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
public class A284196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284196Inst Instance=new A284196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284197
{
public static readonly BigInteger[] Value={ 19L,455L,18842L,1001047L,54333131L,3083244672L,178138187113L,10468760423253L,622301968698475L,37339790561577376L,2256975037851499153L,BigInteger.Parse("137242646380023688189"),BigInteger.Parse("8386798450042067878075"),BigInteger.Parse("514631022193968182602408") };
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
public class A284197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284197Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284197.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284197Inst Instance=new A284197Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284198
{
public static readonly BigInteger[] Value={ 33L,1611L,105367L,14392557L,1321614728L,178138187113L,18564422929880L,2429325477564655L,271315506003954612L,BigInteger.Parse("34775052300161919967"),BigInteger.Parse("4048381878219586826112"),BigInteger.Parse("512565378120434864463849") };
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
public class A284198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284198Inst Instance=new A284198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284199
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,6L,13L,13L,6L,10L,40L,43L,40L,10L,19L,131L,412L,412L,131L,19L,33L,455L,1919L,5268L,1919L,455L,33L,62L,1611L,18842L,71181L,71181L,18842L,1611L,62L,112L,5818L,105367L,1001047L,1488503L,1001047L,105367L,5818L,112L,212L,21328L,983238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284199Inst : IEnumerable<long>
{
public static readonly long[] Value=A284199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284199.Bytes);
public long this[int i]=>Value[i];

public static A284199Inst Instance=new A284199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284200
{
public static readonly long[] Value={ 0L,1L,10L,100L,2L,110L,20L,3L,21L,11L,120L,4L,200L,5L,30L,22L,12L,13L,14L,15L,210L,6L,40L,220L,50L,7L,51L,300L,8L,23L,24L,16L,25L,17L,31L,18L,41L,19L,52L,26L,130L,9L,60L,400L,32L,42L,70L,35L,80L,27L,45L,61L,33L,90L,101L,81L,28L,34L,29L,43L,106L,62L,55L,71L,37L,53L,91L,111L,82L,44L,121L,39L,65L,72L,92L,36L,112L,310L,49L,46L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284200Inst : IEnumerable<long>
{
public static readonly long[] Value=A284200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284200.Bytes);
public long this[int i]=>Value[i];

public static A284200Inst Instance=new A284200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284201
{
public static readonly long[] Value={ 1L,10L,11L,0L,2L,12L,100L,3L,20L,13L,21L,110L,30L,4L,31L,200L,5L,14L,32L,22L,15L,16L,120L,6L,300L,7L,40L,33L,17L,210L,50L,8L,51L,18L,41L,34L,23L,24L,25L,19L,52L,106L,9L,102L,60L,26L,43L,70L,80L,27L,44L,90L,53L,63L,61L,37L,42L,71L,101L,500L,28L,35L,81L,91L,38L,54L,111L,36L,45L,29L,39L,204L,62L,55L,112L,92L,56L,201L,103L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284201Inst : IEnumerable<long>
{
public static readonly long[] Value=A284201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284201.Bytes);
public long this[int i]=>Value[i];

public static A284201Inst Instance=new A284201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284202
{
public static readonly long[] Value={ 3L,6L,10L,22L,34L,142L,214L,382L,862L,2302L,5182L,279934L,944782L,1572862L,1990654L,114791254L,127401982L,339738622L,8153726974L,21743271934L,4696546738174L,112717121716222L,158329674399742L,169075682574334L,300578991243262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284202Inst : IEnumerable<long>
{
public static readonly long[] Value=A284202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284202.Bytes);
public long this[int i]=>Value[i];

public static A284202Inst Instance=new A284202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284203
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,0L,2L,1L,2L,1L,0L,1L,2L,1L,1L,2L,1L,1L,2L,0L,0L,1L,1L,1L,2L,1L,0L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,0L,2L,2L,0L,1L,1L,2L,1L,1L,1L,0L,2L,1L,2L,2L,0L,1L,1L,1L,0L,2L,2L,1L,2L,1L,0L,2L,2L,0L,2L,0L,2L,1L,0L,1L,2L,1L,1L,2L,1L,1L,3L,0L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284203Inst : IEnumerable<long>
{
public static readonly long[] Value=A284203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284203.Bytes);
public long this[int i]=>Value[i];

public static A284203Inst Instance=new A284203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284204
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,5040L,35280L,287280L,2656080L,27422640L,312273360L,3884393520L,52370755920L,760381337520L,11824686110160L,196038409800240L,3450899827705680L,64272619406504880L,1262590566656060880L,BigInteger.Parse("26087355385405781040"),BigInteger.Parse("565510731026706254160") };
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
public class A284204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284204Inst Instance=new A284204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284205
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,40320L,322560L,2943360L,30078720L,339696000L,4196666880L,56255149440L,812752093440L,12585067447680L,207863095910400L,3646938237505920L,67723519234210560L,1326863186062565760L,BigInteger.Parse("27349945952061841920"),BigInteger.Parse("591598086412112035200") };
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
public class A284205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284205Inst Instance=new A284205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284206
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,362880L,3265920L,33022080L,369774720L,4536362880L,60451816320L,869007242880L,13397819541120L,220448163358080L,3854801333416320L,71370457471716480L,1394586705296776320L,BigInteger.Parse("28676809138124407680"),BigInteger.Parse("618948032364173877120") };
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
public class A284206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284206Inst Instance=new A284206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284207
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,3628800L,36288000L,402796800L,4906137600L,64988179200L,929459059200L,14266826784000L,233845982899200L,4075249496774400L,75225258805132800L,1465957162768492800L,BigInteger.Parse("30071395843421184000"),BigInteger.Parse("647624841502298284800") };
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
public class A284207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284207Inst Instance=new A284207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284208
{
public static readonly BigInteger[] Value={ 1L,111L,10001L,1101011L,101010101L,11100000111L,1000001000001L,110110111011011L,10100000000000101L,1110111011101110111L,BigInteger.Parse("100010100010001010001"),BigInteger.Parse("11010110000000001101011"),BigInteger.Parse("1010101000001000001010101"),BigInteger.Parse("111000000000111000000000111"),BigInteger.Parse("10000010100010001000101000001") };
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
public class A284208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284208Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284208.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284208Inst Instance=new A284208Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284209
{
public static readonly long[] Value={ 1L,7L,17L,107L,341L,1799L,4161L,28123L,81925L,489335L,1131601L,7012459L,22286421L,117469191L,273748289L,1840690907L,5390025989L,31943819383L,74441889105L,461363702635L,1465729172821L,7728532584199L,17872436875329L,120787365293531L,351860917551109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284209Inst : IEnumerable<long>
{
public static readonly long[] Value=A284209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284209.Bytes);
public long this[int i]=>Value[i];

public static A284209Inst Instance=new A284209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284210
{
public static readonly long[] Value={ 1L,1L,1L,7L,6L,280L,120L,25335L,11200L,276696L,362880L,374838255L,39916800L,2414617920L,11721790080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284210Inst : IEnumerable<long>
{
public static readonly long[] Value=A284210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284210.Bytes);
public long this[int i]=>Value[i];

public static A284210Inst Instance=new A284210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284291
{
public static readonly long[] Value={ 61L,67L,163L,167L,263L,269L,367L,461L,463L,467L,563L,569L,601L,607L,613L,617L,619L,631L,641L,643L,647L,653L,659L,661L,673L,677L,683L,691L,761L,769L,863L,967L,1061L,1063L,1069L,1163L,1361L,1367L,1567L,1601L,1607L,1609L,1613L,1619L,1621L,1627L,1637L,1657L,1663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284291Inst : IEnumerable<long>
{
public static readonly long[] Value=A284291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284291.Bytes);
public long this[int i]=>Value[i];

public static A284291Inst Instance=new A284291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284292
{
public static readonly long[] Value={ 83L,89L,181L,281L,283L,383L,389L,487L,587L,683L,787L,809L,811L,821L,823L,827L,829L,839L,853L,857L,859L,863L,877L,881L,883L,887L,983L,1087L,1181L,1187L,1283L,1289L,1381L,1481L,1483L,1487L,1489L,1583L,1783L,1787L,1789L,1801L,1811L,1823L,1831L,1847L,1861L,1867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284292Inst : IEnumerable<long>
{
public static readonly long[] Value=A284292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284292.Bytes);
public long this[int i]=>Value[i];

public static A284292Inst Instance=new A284292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284293
{
public static readonly long[] Value={ 1L,6L,11L,16L,61L,66L,111L,116L,161L,166L,611L,616L,661L,666L,1111L,1116L,1161L,1166L,1611L,1616L,1661L,1666L,6111L,6116L,6161L,6166L,6611L,6616L,6661L,6666L,11111L,11116L,11161L,11166L,11611L,11616L,11661L,11666L,16111L,16116L,16161L,16166L,16611L,16616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284293Inst : IEnumerable<long>
{
public static readonly long[] Value=A284293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284293.Bytes);
public long this[int i]=>Value[i];

public static A284293Inst Instance=new A284293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284294
{
public static readonly long[] Value={ 1L,9L,11L,19L,91L,99L,111L,119L,191L,199L,911L,919L,991L,999L,1111L,1119L,1191L,1199L,1911L,1919L,1991L,1999L,9111L,9119L,9191L,9199L,9911L,9919L,9991L,9999L,11111L,11119L,11191L,11199L,11911L,11919L,11991L,11999L,19111L,19119L,19191L,19199L,19911L,19919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284294Inst : IEnumerable<long>
{
public static readonly long[] Value=A284294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284294.Bytes);
public long this[int i]=>Value[i];

public static A284294Inst Instance=new A284294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284295
{
public static readonly long[] Value={ 1L,9L,11L,19L,33L,91L,99L,111L,119L,133L,191L,199L,313L,331L,339L,393L,911L,919L,933L,991L,999L,1111L,1119L,1133L,1191L,1199L,1313L,1331L,1339L,1393L,1911L,1919L,1933L,1991L,1999L,3113L,3131L,3139L,3193L,3311L,3319L,3333L,3391L,3399L,3913L,3931L,3939L,3993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284295Inst : IEnumerable<long>
{
public static readonly long[] Value=A284295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284295.Bytes);
public long this[int i]=>Value[i];

public static A284295Inst Instance=new A284295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284296
{
public static readonly ulong[] Value={ 1L,11L,111L,1011L,10011L,111111L,1010111L,11010011L,110111011L,1100111111L,11111110111L,111010110011L,1111001011011L,10101111111111L,111011110110111L,1101101111110011L,10011111110011011L,111011100111111111L,1010011111100110111L,10011101110111110011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284296Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284296.Bytes);
public ulong this[int i]=>Value[i];

public static A284296Inst Instance=new A284296Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284297
{
public static readonly long[] Value={ 1L,3L,7L,13L,25L,63L,117L,203L,443L,1011L,1919L,3287L,6991L,16373L,30455L,53211L,111609L,261751L,485349L,850873L,1773719L,4176225L,7765939L,13630991L,28562197L,67038375L,124219195L,217835989L,454274903L,1069328031L,1987313645L,3489646447L,7310569395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284297Inst : IEnumerable<long>
{
public static readonly long[] Value=A284297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284297.Bytes);
public long this[int i]=>Value[i];

public static A284297Inst Instance=new A284297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284298
{
public static readonly long[] Value={ 1L,3L,7L,11L,19L,63L,87L,211L,443L,831L,2039L,3763L,7771L,11263L,30647L,56307L,81819L,244223L,343863L,646643L,1909019L,2205567L,6750007L,15761395L,22124443L,60087807L,115849015L,179928563L,492747035L,1046040447L,1543497527L,4142137331L,6910966683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284298Inst : IEnumerable<long>
{
public static readonly long[] Value=A284298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284298.Bytes);
public long this[int i]=>Value[i];

public static A284298Inst Instance=new A284298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284299
{
public static readonly ulong[] Value={ 1L,0L,11L,101L,1010L,11101L,101010L,1110111L,10101011L,111011101L,1010101010L,11101110101L,101010101010L,1110111010101L,10101010101010L,111011111010101L,1010101110101010L,11101110101110101L,101010101010101010L,1110111010101111101L,10101010101010111010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284299Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284299.Bytes);
public ulong this[int i]=>Value[i];

public static A284299Inst Instance=new A284299Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284300
{
public static readonly ulong[] Value={ 1L,0L,110L,1010L,1010L,101110L,101010L,11101110L,110101010L,1011101110L,1010101010L,101011101110L,101010101010L,10101011101110L,10101010101010L,1010101111101110L,1010101110101010L,101011101011101110L,101010101010101010L,10111110101011101110UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284300Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284300.Bytes);
public ulong this[int i]=>Value[i];

public static A284300Inst Instance=new A284300Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284301
{
public static readonly long[] Value={ 1L,0L,3L,5L,10L,29L,42L,119L,171L,477L,682L,1909L,2730L,7637L,10922L,30677L,43946L,122229L,174762L,488829L,699066L,1955159L,2796219L,7853397L,11250366L,31290717L,44739306L,125138261L,178956970L,500520277L,715827882L,2010469717L,2880088746L,8010421589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284301Inst : IEnumerable<long>
{
public static readonly long[] Value=A284301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284301.Bytes);
public long this[int i]=>Value[i];

public static A284301Inst Instance=new A284301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284302
{
public static readonly long[] Value={ 1L,0L,6L,10L,10L,46L,42L,238L,426L,750L,682L,2798L,2730L,10990L,10922L,44014L,43946L,178926L,174762L,781038L,764586L,3844846L,7252650L,11185134L,16427946L,48937710L,45787818L,178973422L,178956970L,715827950L,715827882L,2863311854L,2863311786L,11453250286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284302Inst : IEnumerable<long>
{
public static readonly long[] Value=A284302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284302.Bytes);
public long this[int i]=>Value[i];

public static A284302Inst Instance=new A284302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284303
{
public static readonly ulong[] Value={ 1L,11L,101L,1101L,10001L,111011L,1010001L,11011011L,100000001L,1110000011L,10101000101L,110101101101L,1000100010001L,11101110111011L,101000100010101L,1101101110110111L,10000000100000011L,111000001110000101L,1010100010101001111L,11010110110111110111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284303Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284303.Bytes);
public ulong this[int i]=>Value[i];

public static A284303Inst Instance=new A284303Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284304
{
public static readonly ulong[] Value={ 1L,11L,101L,1011L,10001L,110111L,1000101L,11011011L,100000001L,1100000111L,10100010101L,101101101011L,1000100010001L,11011101110111L,101010001000101L,1110110111011011L,11000000100000001L,101000011100000111L,1111001010100010101L,11101111101101101011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284304Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284304.Bytes);
public ulong this[int i]=>Value[i];

public static A284304Inst Instance=new A284304Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284305
{
public static readonly long[] Value={ 1L,3L,5L,13L,17L,59L,81L,219L,257L,899L,1349L,3437L,4369L,15291L,20757L,56247L,65795L,230277L,345423L,880119L,1118443L,3914077L,5314507L,14400445L,16847131L,58964901L,88429887L,225312735L,286326671L,1002012503L,1360477787L,3686456805L,4313254111L,15094947119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284305Inst : IEnumerable<long>
{
public static readonly long[] Value=A284305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284305.Bytes);
public long this[int i]=>Value[i];

public static A284305Inst Instance=new A284305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284306
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,55L,69L,219L,257L,775L,1301L,2923L,4369L,14199L,21573L,60891L,98561L,165639L,496917L,981867L,1761553L,3057527L,6943813L,12443099L,28381441L,43480839L,132470037L,264239979L,507502865L,985638775L,1832809541L,2814074331L,8424378625L,16423155463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284306Inst : IEnumerable<long>
{
public static readonly long[] Value=A284306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284306.Bytes);
public long this[int i]=>Value[i];

public static A284306Inst Instance=new A284306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284339
{
public static readonly BigInteger[] Value={ 32L,467L,19385L,1000935L,53977741L,3063494246L,177476886878L,10461739893371L,624011970319158L,37553142489545970L,2275676365910034413L,BigInteger.Parse("138666493338168560209"),BigInteger.Parse("8487568981259644635313"),BigInteger.Parse("521456824010639311889624") };
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
public class A284339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284339Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284339.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284339Inst Instance=new A284339Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284340
{
public static readonly BigInteger[] Value={ 64L,1689L,122495L,14581112L,1544903012L,179138039472L,20513380740103L,2451428833201600L,290448052609643641L,BigInteger.Parse("35231200322704249292"),BigInteger.Parse("4253729721779461810333"),BigInteger.Parse("520640922794348063107735") };
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
public class A284340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284340Inst Instance=new A284340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284341
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,12L,8L,7L,13L,18L,12L,28L,14L,24L,24L,7L,18L,39L,20L,42L,32L,36L,24L,28L,31L,42L,40L,56L,30L,72L,32L,7L,48L,54L,48L,91L,38L,60L,56L,42L,42L,96L,44L,84L,78L,72L,48L,28L,57L,93L,72L,98L,54L,120L,72L,56L,80L,90L,60L,168L,62L,96L,104L,7L,84L,144L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284341Inst : IEnumerable<long>
{
public static readonly long[] Value=A284341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284341.Bytes);
public long this[int i]=>Value[i];

public static A284341Inst Instance=new A284341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284342
{
public static readonly long[] Value={ 12L,18L,24L,36L,40L,45L,48L,50L,54L,56L,60L,63L,72L,75L,80L,84L,90L,96L,98L,100L,108L,112L,120L,126L,132L,135L,144L,147L,150L,156L,160L,162L,168L,175L,176L,180L,189L,192L,196L,198L,200L,204L,208L,216L,224L,225L,228L,234L,240L,242L,245L,250L,252L,264L,270L,275L,276L,280L,288L,294L,297L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284342Inst : IEnumerable<long>
{
public static readonly long[] Value=A284342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284342.Bytes);
public long this[int i]=>Value[i];

public static A284342Inst Instance=new A284342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284343
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,4L,1L,1L,3L,1L,3L,2L,1L,3L,3L,2L,3L,5L,2L,3L,4L,6L,1L,3L,5L,1L,6L,1L,3L,7L,2L,2L,5L,6L,5L,6L,3L,6L,4L,1L,3L,4L,5L,4L,5L,7L,2L,3L,8L,6L,7L,3L,4L,8L,3L,2L,6L,3L,5L,7L,3L,8L,7L,2L,4L,10L,4L,4L,7L,9L,7L,2L,4L,2L,7L,3L,5L,11L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284343Inst : IEnumerable<long>
{
public static readonly long[] Value=A284343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284343.Bytes);
public long this[int i]=>Value[i];

public static A284343Inst Instance=new A284343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284344
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,12L,8L,15L,13L,8L,12L,28L,14L,24L,24L,31L,18L,39L,20L,12L,32L,36L,24L,60L,31L,42L,40L,56L,30L,32L,32L,63L,48L,54L,48L,91L,38L,60L,56L,20L,42L,96L,44L,84L,78L,72L,48L,124L,57L,33L,72L,98L,54L,120L,72L,120L,80L,90L,60L,48L,62L,96L,104L,127L,84L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284344Inst : IEnumerable<long>
{
public static readonly long[] Value=A284344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284344.Bytes);
public long this[int i]=>Value[i];

public static A284344Inst Instance=new A284344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284345
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,4L,1L,1L,1L,6L,1L,3L,1L,6L,1L,1L,1L,7L,2L,1L,4L,8L,1L,1L,1L,15L,1L,1L,1L,27L,1L,1L,1L,11L,1L,1L,1L,12L,6L,1L,1L,28L,2L,3L,1L,14L,1L,7L,1L,15L,1L,1L,1L,16L,1L,1L,8L,46L,1L,1L,1L,18L,1L,1L,1L,114L,1L,1L,4L,20L,1L,1L,1L,66L,11L,1L,1L,22L,1L,1L,1L,23L,1L,11L,1L,24L,1L,1L,1L,91L,1L,3L,12L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284345Inst : IEnumerable<long>
{
public static readonly long[] Value=A284345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284345.Bytes);
public long this[int i]=>Value[i];

public static A284345Inst Instance=new A284345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284346
{
public static readonly long[] Value={ 2L,1L,8L,1L,4L,1L,2L,3L,16L,3L,6L,7L,8L,1L,4L,1L,22L,5L,6L,3L,4L,17L,18L,5L,4L,1L,32L,5L,10L,29L,4L,27L,8L,15L,18L,1L,2L,15L,10L,3L,4L,247L,8L,15L,14L,19L,22L,35L,6L,19L,4L,27L,10L,11L,8L,1L,2L,5L,40L,13L,44L,127L,58L,61L,28L,1L,22L,13L,10L,19L,6L,7L,8L,15L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284346Inst : IEnumerable<long>
{
public static readonly long[] Value=A284346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284346.Bytes);
public long this[int i]=>Value[i];

public static A284346Inst Instance=new A284346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284347
{
public static readonly ulong[] Value={ 1L,0L,11L,101L,1010L,11101L,111010L,1011111L,10101111L,111110111L,1111111011L,10111110101L,101111111010L,1111111111101L,11111111111110L,101111111111111L,1010111111111111L,11111011111111111L,111111111111111111L,1011111111111111111L,10111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284347Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284347.Bytes);
public ulong this[int i]=>Value[i];

public static A284347Inst Instance=new A284347Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284348
{
public static readonly ulong[] Value={ 1L,0L,110L,1010L,1010L,101110L,101110L,11111010L,111101010L,1110111110L,11011111110L,101011111010L,101111111010L,10111111111110L,11111111111110L,1111111111111010L,11111111111101010L,111111111110111110L,1111111111111111110L,11111111111111111010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284348Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284348.Bytes);
public ulong this[int i]=>Value[i];

public static A284348Inst Instance=new A284348Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284349
{
public static readonly long[] Value={ 1L,0L,3L,5L,10L,29L,58L,95L,175L,503L,1019L,1525L,3066L,8189L,16382L,24575L,45055L,129023L,262143L,393215L,786431L,2097151L,4194303L,6291455L,11534335L,33030143L,67108863L,100663295L,201326591L,536870911L,1073741823L,1610612735L,2952790015L,8455716863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284349Inst : IEnumerable<long>
{
public static readonly long[] Value=A284349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284349.Bytes);
public long this[int i]=>Value[i];

public static A284349Inst Instance=new A284349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284350
{
public static readonly long[] Value={ 1L,0L,6L,10L,10L,46L,46L,250L,490L,958L,1790L,2810L,3066L,12286L,16382L,65530L,131050L,262078L,524286L,1048570L,2097146L,4194302L,8388606L,16777210L,33554410L,67108798L,134217726L,268435450L,536870906L,1073741822L,2147483646L,4294967290L,8589934570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284350Inst : IEnumerable<long>
{
public static readonly long[] Value=A284350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284350.Bytes);
public long this[int i]=>Value[i];

public static A284350Inst Instance=new A284350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284351
{
public static readonly ulong[] Value={ 1L,1L,111L,1101L,11111L,111101L,1111111L,11111101L,111111111L,1111111101L,11111111111L,111111111101L,1111111111111L,11111111111101L,111111111111111L,1111111111111101L,11111111111111111L,111111111111111101L,1111111111111111111L,11111111111111111101UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284351Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284351.Bytes);
public ulong this[int i]=>Value[i];

public static A284351Inst Instance=new A284351Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284352
{
public static readonly ulong[] Value={ 1L,10L,111L,1011L,11111L,101111L,1111111L,10111111L,111111111L,1011111111L,11111111111L,101111111111L,1111111111111L,10111111111111L,111111111111111L,1011111111111111L,11111111111111111L,101111111111111111L,1111111111111111111L,10111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284352Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284352.Bytes);
public ulong this[int i]=>Value[i];

public static A284352Inst Instance=new A284352Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284353
{
public static readonly long[] Value={ 1L,1L,7L,13L,31L,61L,127L,253L,511L,1021L,2047L,4093L,8191L,16381L,32767L,65533L,131071L,262141L,524287L,1048573L,2097151L,4194301L,8388607L,16777213L,33554431L,67108861L,134217727L,268435453L,536870911L,1073741821L,2147483647L,4294967293L,8589934591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284353Inst : IEnumerable<long>
{
public static readonly long[] Value=A284353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284353.Bytes);
public long this[int i]=>Value[i];

public static A284353Inst Instance=new A284353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284354
{
public static readonly long[] Value={ 1L,2L,7L,11L,31L,47L,127L,191L,511L,767L,2047L,3071L,8191L,12287L,32767L,49151L,131071L,196607L,524287L,786431L,2097151L,3145727L,8388607L,12582911L,33554431L,50331647L,134217727L,201326591L,536870911L,805306367L,2147483647L,3221225471L,8589934591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284354Inst : IEnumerable<long>
{
public static readonly long[] Value=A284354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284354.Bytes);
public long this[int i]=>Value[i];

public static A284354Inst Instance=new A284354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284371
{
public static readonly long[] Value={ 1L,4L,5L,6L,7L,10L,11L,14L,15L,18L,19L,22L,23L,24L,25L,28L,29L,32L,33L,34L,35L,38L,39L,42L,43L,44L,45L,48L,49L,52L,53L,54L,55L,58L,59L,62L,63L,66L,67L,70L,71L,72L,73L,76L,77L,80L,81L,82L,83L,86L,87L,90L,91L,94L,95L,98L,99L,100L,101L,104L,105L,108L,109L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284371Inst : IEnumerable<long>
{
public static readonly long[] Value=A284371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284371.Bytes);
public long this[int i]=>Value[i];

public static A284371Inst Instance=new A284371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284372
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,12L,13L,14L,1L,1L,1L,1L,1L,1L,1L,1L,12L,24L,37L,26L,14L,1L,1L,1L,1L,1L,1L,12L,1L,36L,49L,38L,1L,14L,1L,1L,1L,1L,12L,1L,24L,48L,85L,50L,26L,1L,14L,1L,1L,12L,1L,1L,1L,60L,73L,62L,1L,1L,1L,14L,12L,1L,1L,24L,36L,72L,145L,74L,38L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284372Inst : IEnumerable<long>
{
public static readonly long[] Value=A284372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284372.Bytes);
public long this[int i]=>Value[i];

public static A284372Inst Instance=new A284372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284373
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,4L,1L,2L,1L,2L,1L,3L,1L,6L,3L,1L,1L,1L,7L,4L,1L,4L,2L,1L,3L,2L,1L,4L,3L,1L,9L,6L,3L,1L,2L,1L,1L,10L,7L,4L,1L,5L,4L,2L,1L,4L,3L,2L,1L,6L,4L,3L,1L,12L,9L,6L,3L,1L,2L,2L,1L,1L,13L,10L,7L,4L,1L,7L,5L,4L,2L,1L,5L,4L,3L,2L,1L,7L,6L,4L,3L,1L,15L,12L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284373Inst : IEnumerable<long>
{
public static readonly long[] Value=A284373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284373.Bytes);
public long this[int i]=>Value[i];

public static A284373Inst Instance=new A284373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284374
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,3L,5L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,7L,13L,11L,7L,11L,13L,11L,13L,13L,13L,13L,13L,13L,13L,23L,13L,11L,19L,19L,13L,23L,19L,13L,23L,23L,19L,19L,23L,23L,19L,23L,23L,23L,23L,23L,23L,23L,43L,19L,29L,31L,23L,23L,43L,31L,31L,23L,31L,37L,31L,23L,43L,31L,23L,43L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284374Inst : IEnumerable<long>
{
public static readonly long[] Value=A284374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284374.Bytes);
public long this[int i]=>Value[i];

public static A284374Inst Instance=new A284374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284375
{
public static readonly long[] Value={ 0L,1L,10L,11L,20L,30L,40L,50L,60L,70L,80L,90L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,120L,130L,140L,150L,160L,170L,180L,190L,200L,201L,202L,203L,204L,205L,206L,207L,208L,209L,210L,220L,230L,240L,250L,260L,270L,280L,290L,300L,301L,302L,303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284375Inst : IEnumerable<long>
{
public static readonly long[] Value=A284375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284375.Bytes);
public long this[int i]=>Value[i];

public static A284375Inst Instance=new A284375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284376
{
public static readonly long[] Value={ 3L,1L,1L,0L,1L,2L,1L,0L,3L,4L,1L,0L,7L,2L,1L,2L,1L,2L,5L,0L,1L,4L,5L,0L,1L,4L,1L,2L,5L,4L,11L,0L,3L,2L,5L,2L,1L,2L,3L,10L,1L,4L,5L,0L,9L,2L,5L,0L,13L,4L,7L,4L,3L,10L,1L,4L,1L,2L,3L,0L,13L,10L,3L,32L,9L,2L,1L,0L,5L,10L,3L,0L,5L,2L,1L,4L,5L,10L,7L,0L,7L,4L,3L,0L,1L,2L,9L,2L,3L,4L,1L,4L,7L,8L,1L,2L,5L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284376Inst : IEnumerable<long>
{
public static readonly long[] Value=A284376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284376.Bytes);
public long this[int i]=>Value[i];

public static A284376Inst Instance=new A284376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284377
{
public static readonly BigInteger[] Value={ 1L,116L,11681L,11681256L,11681256625L,116812566251296L,1168125662512962401L,BigInteger.Parse("1681256625129624014096"),BigInteger.Parse("116812566251296240140966561"),BigInteger.Parse("11681256625129624014096656110000"),BigInteger.Parse("1168125662512962401409665611000014641"),BigInteger.Parse("116812566251296240140966561100001464120736") };
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
public class A284377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284377Inst Instance=new A284377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284378
{
public static readonly long[] Value={ 1L,2L,14L,3728L,3854L,249293L,748909L,1151514109050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284378Inst : IEnumerable<long>
{
public static readonly long[] Value=A284378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284378.Bytes);
public long this[int i]=>Value[i];

public static A284378Inst Instance=new A284378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284379
{
public static readonly long[] Value={ 3L,5L,33L,35L,53L,55L,333L,335L,353L,355L,533L,535L,553L,555L,3333L,3335L,3353L,3355L,3533L,3535L,3553L,3555L,5333L,5335L,5353L,5355L,5533L,5535L,5553L,5555L,33333L,33335L,33353L,33355L,33533L,33535L,33553L,33555L,35333L,35335L,35353L,35355L,35533L,35535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284379Inst : IEnumerable<long>
{
public static readonly long[] Value=A284379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284379.Bytes);
public long this[int i]=>Value[i];

public static A284379Inst Instance=new A284379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284380
{
public static readonly long[] Value={ 5L,7L,55L,57L,75L,77L,555L,557L,575L,577L,755L,757L,775L,777L,5555L,5557L,5575L,5577L,5755L,5757L,5775L,5777L,7555L,7557L,7575L,7577L,7755L,7757L,7775L,7777L,55555L,55557L,55575L,55577L,55755L,55757L,55775L,55777L,57555L,57557L,57575L,57577L,57755L,57757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284380Inst : IEnumerable<long>
{
public static readonly long[] Value=A284380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284380.Bytes);
public long this[int i]=>Value[i];

public static A284380Inst Instance=new A284380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284381
{
public static readonly long[] Value={ 5L,8L,55L,58L,85L,88L,555L,558L,585L,588L,855L,858L,885L,888L,5555L,5558L,5585L,5588L,5855L,5858L,5885L,5888L,8555L,8558L,8585L,8588L,8855L,8858L,8885L,8888L,55555L,55558L,55585L,55588L,55855L,55858L,55885L,55888L,58555L,58558L,58585L,58588L,58855L,58858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284381Inst : IEnumerable<long>
{
public static readonly long[] Value=A284381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284381.Bytes);
public long this[int i]=>Value[i];

public static A284381Inst Instance=new A284381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284382
{
public static readonly long[] Value={ 5L,9L,55L,59L,95L,99L,555L,559L,595L,599L,955L,959L,995L,999L,5555L,5559L,5595L,5599L,5955L,5959L,5995L,5999L,9555L,9559L,9595L,9599L,9955L,9959L,9995L,9999L,55555L,55559L,55595L,55599L,55955L,55959L,55995L,55999L,59555L,59559L,59595L,59599L,59955L,59959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284382Inst : IEnumerable<long>
{
public static readonly long[] Value=A284382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284382.Bytes);
public long this[int i]=>Value[i];

public static A284382Inst Instance=new A284382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284383
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,4L,6L,4L,6L,6L,8L,6L,10L,6L,10L,10L,12L,8L,14L,10L,14L,10L,16L,10L,16L,16L,16L,12L,22L,12L,20L,16L,22L,14L,24L,16L,24L,16L,26L,16L,26L,26L,24L,18L,30L,22L,28L,26L,30L,20L,34L,24L,36L,20L,38L,24L,36L,24L,40L,26L,38L,26L,40L,26L,42L,26L,42L,42L,32L,28L,50L,28L,46L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284383Inst : IEnumerable<long>
{
public static readonly long[] Value=A284383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284383.Bytes);
public long this[int i]=>Value[i];

public static A284383Inst Instance=new A284383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284384
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,6L,7L,10L,11L,14L,15L,18L,19L,23L,24L,29L,30L,35L,36L,41L,42L,47L,48L,53L,54L,60L,61L,68L,69L,76L,77L,84L,85L,92L,93L,100L,101L,108L,109L,116L,117L,125L,126L,135L,136L,145L,146L,155L,156L,165L,166L,175L,176L,185L,186L,195L,196L,205L,206L,215L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284384Inst : IEnumerable<long>
{
public static readonly long[] Value=A284384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284384.Bytes);
public long this[int i]=>Value[i];

public static A284384Inst Instance=new A284384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284385
{
public static readonly long[] Value={ 2L,3L,6L,8L,6L,7L,12L,15L,8L,9L,18L,18L,8L,15L,24L,23L,12L,12L,24L,30L,12L,17L,36L,31L,14L,21L,30L,30L,18L,24L,42L,42L,14L,21L,48L,38L,14L,33L,48L,45L,24L,18L,42L,54L,24L,35L,66L,48L,20L,36L,48L,44L,24L,40L,72L,63L,18L,27L,72L,60L,26L,51L,66L,62L,36L,30L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284385Inst : IEnumerable<long>
{
public static readonly long[] Value=A284385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284385.Bytes);
public long this[int i]=>Value[i];

public static A284385Inst Instance=new A284385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284386
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284386Inst : IEnumerable<long>
{
public static readonly long[] Value=A284386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284386.Bytes);
public long this[int i]=>Value[i];

public static A284386Inst Instance=new A284386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284515
{
public static readonly long[] Value={ 100L,1000L,1002L,1100L,1102L,10000L,10002L,10020L,10022L,10100L,10102L,10120L,10122L,11000L,11002L,11020L,11022L,11100L,11102L,11120L,11122L,30000L,30002L,30020L,30022L,30100L,30102L,30120L,30122L,31000L,31002L,31020L,31022L,31100L,31102L,31120L,31122L,100000L,100002L,100004L,100020L,100022L,100024L,100100L,100102L,100104L,100120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284515Inst : IEnumerable<long>
{
public static readonly long[] Value=A284515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284515.Bytes);
public long this[int i]=>Value[i];

public static A284515Inst Instance=new A284515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284516
{
public static readonly long[] Value={ 1L,2L,13L,24L,5L,3L,6L,7L,4L,8L,52L,9L,62L,73L,18L,131L,91L,21L,32L,41L,31L,54L,16L,12L,51L,216L,14L,15L,17L,42L,35L,26L,37L,19L,126L,82L,47L,529L,428L,57L,23L,121L,34L,25L,72L,43L,65L,83L,74L,96L,53L,48L,235L,29L,36L,27L,325L,86L,39L,75L,300L,81L,61L,92L,45L,261L,415L,28L,324L,63L,59L,482L,652L,141L,93L,64L,231L,2161L,38L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284516Inst : IEnumerable<long>
{
public static readonly long[] Value=A284516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284516.Bytes);
public long this[int i]=>Value[i];

public static A284516Inst Instance=new A284516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284517
{
public static readonly long[] Value={ 1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L,3L,4L,1L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284517Inst : IEnumerable<long>
{
public static readonly long[] Value=A284517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284517.Bytes);
public long this[int i]=>Value[i];

public static A284517Inst Instance=new A284517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284518
{
public static readonly long[] Value={ 1L,10L,9L,16L,1L,18L,1L,16L,9L,10L,1L,24L,1L,10L,9L,16L,1L,18L,1L,16L,9L,10L,1L,24L,1L,10L,9L,16L,1L,18L,1L,16L,9L,10L,1L,24L,1L,10L,9L,16L,1L,18L,1L,16L,9L,10L,1L,24L,1L,10L,9L,16L,1L,18L,1L,16L,9L,10L,1L,24L,1L,10L,9L,16L,1L,18L,1L,16L,9L,10L,1L,24L,1L,10L,9L,16L,1L,18L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284518Inst : IEnumerable<long>
{
public static readonly long[] Value=A284518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284518.Bytes);
public long this[int i]=>Value[i];

public static A284518Inst Instance=new A284518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284519
{
public static readonly long[] Value={ 1L,31775L,0L,1016800L,1301504L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6507520L,0L,0L,0L,0L,0L,15744000L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7936000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284519Inst : IEnumerable<long>
{
public static readonly long[] Value=A284519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284519.Bytes);
public long this[int i]=>Value[i];

public static A284519Inst Instance=new A284519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284520
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,4L,4L,4L,5L,6L,7L,8L,8L,8L,8L,8L,8L,9L,10L,11L,12L,13L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,18L,19L,19L,19L,19L,20L,22L,25L,28L,28L,26L,24L,23L,25L,29L,30L,31L,30L,30L,30L,31L,31L,31L,31L,32L,32L,32L,32L,32L,32L,32L,32L,33L,34L,35L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284520Inst : IEnumerable<long>
{
public static readonly long[] Value=A284520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284520.Bytes);
public long this[int i]=>Value[i];

public static A284520Inst Instance=new A284520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284521
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,18L,25L,33L,42L,47L,58L,62L,75L,82L,87L,103L,120L,129L,148L,153L,160L,171L,194L,202L,227L,240L,267L,274L,303L,308L,339L,371L,382L,399L,406L,415L,452L,471L,484L,492L,533L,540L,583L,594L,603L,626L,673L,689L,738L,763L,780L,793L,846L,873L,884L,892L,911L,940L,999L,1004L,1065L,1096L,1105L,1169L,1182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284521Inst : IEnumerable<long>
{
public static readonly long[] Value=A284521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284521.Bytes);
public long this[int i]=>Value[i];

public static A284521Inst Instance=new A284521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284522
{
public static readonly long[] Value={ 6L,85L,259L,527L,1177L,1963L,2881L,6403L,6887L,12319L,23701L,40363L,65473L,93011L,144377L,181429L,273487L,337499L,426347L,557983L,702157L,851927L,1044413L,1295017L,1437599L,1763537L,2211119L,2556751L,2982503L,3553027L,3853327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284522Inst : IEnumerable<long>
{
public static readonly long[] Value=A284522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284522.Bytes);
public long this[int i]=>Value[i];

public static A284522Inst Instance=new A284522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284523
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,3L,4L,5L,5L,5L,5L,5L,6L,8L,8L,8L,8L,8L,8L,8L,8L,9L,11L,13L,13L,13L,11L,13L,13L,13L,13L,13L,13L,13L,13L,14L,16L,19L,21L,19L,16L,14L,16L,17L,21L,21L,21L,21L,19L,21L,21L,21L,21L,21L,21L,21L,21L,22L,24L,27L,32L,29L,26L,24L,21L,29L,27L,34L,34L,27L,27L,29L,34L,34L,34L,29L,27L,29L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284523Inst : IEnumerable<long>
{
public static readonly long[] Value=A284523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284523.Bytes);
public long this[int i]=>Value[i];

public static A284523Inst Instance=new A284523Inst();

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