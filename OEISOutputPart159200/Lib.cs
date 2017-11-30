using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A202305
{
public static readonly long[] Value={ 0L,2L,3L,3L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202305Inst : IEnumerable<long>
{
public static readonly long[] Value=A202305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202305.Bytes);
public long this[int i]=>Value[i];

public static A202305Inst Instance=new A202305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202306
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,5L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202306Inst : IEnumerable<long>
{
public static readonly long[] Value=A202306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202306.Bytes);
public long this[int i]=>Value[i];

public static A202306Inst Instance=new A202306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202307
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,7L,8L,8L,9L,9L,10L,11L,11L,11L,12L,12L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,22L,22L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202307Inst : IEnumerable<long>
{
public static readonly long[] Value=A202307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202307.Bytes);
public long this[int i]=>Value[i];

public static A202307Inst Instance=new A202307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202308
{
public static readonly long[] Value={ 0L,3L,5L,6L,7L,8L,8L,9L,10L,10L,11L,11L,12L,13L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,26L,26L,26L,26L,26L,27L,27L,27L,27L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202308Inst : IEnumerable<long>
{
public static readonly long[] Value=A202308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202308.Bytes);
public long this[int i]=>Value[i];

public static A202308Inst Instance=new A202308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202309
{
public static readonly BigInteger[] Value={ 108L,1530L,60362L,5792412L,1298560926L,664688048868L,772570552594066L,2032346650939236958L,BigInteger.Parse("12089324170480855906196"),BigInteger.Parse("162516419233430324967146120"),BigInteger.Parse("4936419547564362889228206714104") };
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
public class A202309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202309.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202309Inst Instance=new A202309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202310
{
public static readonly long[] Value={ 108L,333L,1144L,4048L,14743L,54250L,201098L,747683L,2785178L,10383774L,38732585L,144511028L,539243500L,2012324661L,7509786472L,28026278000L,104594259855L,390348614698L,1456795959866L,5436826706395L,20290493971290L,75725115284622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202310Inst : IEnumerable<long>
{
public static readonly long[] Value=A202310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202310.Bytes);
public long this[int i]=>Value[i];

public static A202310Inst Instance=new A202310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202311
{
public static readonly long[] Value={ 333L,1530L,7835L,41657L,226004L,1235783L,6782829L,37288278L,205145785L,1129013615L,6214483528L,34209181595L,188319539951L,1036704795848L,5707135200185L,31418307187167L,172960983499418L,952168615072689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202311Inst : IEnumerable<long>
{
public static readonly long[] Value=A202311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202311.Bytes);
public long this[int i]=>Value[i];

public static A202311Inst Instance=new A202311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202312
{
public static readonly long[] Value={ 1144L,7835L,60362L,482118L,3922195L,32097834L,263496670L,2165338373L,17804391712L,146424450894L,1204339423235L,9906059804694L,81482199760950L,670236253192389L,5513089719967306L,45348496409163712L,373019148392286317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202312Inst : IEnumerable<long>
{
public static readonly long[] Value=A202312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202312.Bytes);
public long this[int i]=>Value[i];

public static A202312Inst Instance=new A202312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202313
{
public static readonly long[] Value={ 4048L,41657L,482118L,5792412L,70757101L,869323542L,10708740246L,132045501007L,1628956232144L,20098992430100L,248014058768603L,3060507912802688L,37767462823987648L,466063500543300373L,5751402407934594914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202313Inst : IEnumerable<long>
{
public static readonly long[] Value=A202313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202313.Bytes);
public long this[int i]=>Value[i];

public static A202313Inst Instance=new A202313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202314
{
public static readonly BigInteger[] Value={ 14743L,226004L,3922195L,70757101L,1298560926L,23966292639L,443521643383L,8215338474276L,152244358697251L,2821802991486057L,52305839852038732L,969586430998725601L,17973396749417435147UL,BigInteger.Parse("333177931075395176824") };
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
public class A202314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202314Inst Instance=new A202314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202315
{
public static readonly BigInteger[] Value={ 54250L,1235783L,32097834L,869323542L,23966292639L,664688048868L,18484607981704L,514540668174263L,14329370884754954L,399124012126897012L,11117935807977349491UL,BigInteger.Parse("309709187634183606862"),BigInteger.Parse("8627612991815294081922") };
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
public class A202315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202315Inst Instance=new A202315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202316
{
public static readonly BigInteger[] Value={ 201098L,6782829L,263496670L,10708740246L,443521643383L,18484607981704L,772570552594066L,32321227655005461L,1352830955510633908L,BigInteger.Parse("56633187705365343332"),BigInteger.Parse("2371021744221926513161"),BigInteger.Parse("99268859616436938516952") };
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
public class A202316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202316Inst Instance=new A202316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202317
{
public static readonly long[] Value={ 108L,333L,333L,1144L,1530L,1144L,4048L,7835L,7835L,4048L,14743L,41657L,60362L,41657L,14743L,54250L,226004L,482118L,482118L,226004L,54250L,201098L,1235783L,3922195L,5792412L,3922195L,1235783L,201098L,747683L,6782829L,32097834L,70757101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202317Inst : IEnumerable<long>
{
public static readonly long[] Value=A202317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202317.Bytes);
public long this[int i]=>Value[i];

public static A202317Inst Instance=new A202317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202318
{
public static readonly long[] Value={ 1L,10L,21L,20L,11L,2730L,1L,680L,1197L,550L,23L,5460L,1L,290L,7161L,1360L,1L,5757570L,1L,45100L,6321L,230L,47L,185640L,11L,530L,3591L,580L,59L,283933650L,1L,2720L,32361L,10L,781L,840605220L,1L,10L,1659L,1533400L,83L,23830170L,1L,40940L,408177L,470L,1L,36014160L,1L,277750L,2163L,1060L,107L,1882725390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202318Inst : IEnumerable<long>
{
public static readonly long[] Value=A202318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202318.Bytes);
public long this[int i]=>Value[i];

public static A202318Inst Instance=new A202318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202319
{
public static readonly long[] Value={ 214L,143098L,194758L,206134L,273418L,684898L,807658L,1373938L,1391758L,1516534L,1591594L,1610998L,1774798L,1882978L,1891762L,2046454L,2051494L,2163418L,2163958L,2338054L,2359978L,2522518L,2913838L,3108202L,4221754L,4297318L,4334938L,4866118L,4988878L,5108794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202319Inst : IEnumerable<long>
{
public static readonly long[] Value=A202319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202319.Bytes);
public long this[int i]=>Value[i];

public static A202319Inst Instance=new A202319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202320
{
public static readonly long[] Value={ 1L,8L,4L,1L,4L,0L,5L,6L,6L,0L,4L,3L,6L,9L,6L,0L,6L,3L,7L,8L,4L,6L,6L,0L,4L,6L,5L,8L,0L,1L,2L,4L,8L,6L,1L,0L,6L,0L,5L,0L,3L,7L,1L,3L,1L,4L,3L,7L,7L,6L,3L,9L,6L,6L,9L,5L,6L,4L,8L,5L,0L,0L,8L,9L,5L,4L,8L,1L,8L,4L,0L,8L,1L,2L,1L,8L,3L,1L,7L,0L,0L,0L,5L,1L,0L,3L,4L,5L,6L,7L,1L,6L,9L,1L,3L,0L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202320Inst : IEnumerable<long>
{
public static readonly long[] Value=A202320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202320.Bytes);
public long this[int i]=>Value[i];

public static A202320Inst Instance=new A202320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202321
{
public static readonly long[] Value={ 1L,1L,4L,6L,1L,9L,3L,2L,2L,0L,6L,2L,0L,5L,8L,2L,5L,8L,5L,2L,3L,7L,0L,6L,1L,0L,2L,8L,5L,2L,1L,3L,6L,8L,2L,5L,2L,8L,8L,8L,6L,6L,2L,0L,4L,6L,1L,8L,2L,4L,8L,8L,4L,2L,6L,0L,3L,4L,6L,1L,9L,2L,9L,1L,2L,8L,6L,7L,7L,5L,1L,6L,3L,9L,8L,7L,5L,4L,8L,8L,7L,0L,7L,7L,4L,3L,9L,6L,0L,6L,6L,1L,6L,9L,0L,4L,4L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202321Inst : IEnumerable<long>
{
public static readonly long[] Value=A202321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202321.Bytes);
public long this[int i]=>Value[i];

public static A202321Inst Instance=new A202321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202322
{
public static readonly long[] Value={ 4L,4L,2L,8L,5L,4L,4L,0L,1L,0L,0L,2L,3L,8L,8L,5L,8L,3L,1L,4L,1L,3L,2L,7L,9L,9L,9L,9L,9L,9L,3L,3L,6L,8L,1L,9L,7L,1L,6L,2L,6L,2L,1L,2L,9L,3L,7L,3L,4L,7L,9L,6L,8L,4L,7L,1L,7L,7L,3L,3L,0L,7L,6L,9L,8L,2L,0L,1L,5L,9L,9L,2L,1L,4L,2L,0L,0L,4L,0L,7L,8L,4L,9L,0L,8L,6L,5L,9L,2L,4L,8L,1L,7L,8L,7L,3L,9L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202322Inst : IEnumerable<long>
{
public static readonly long[] Value=A202322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202322.Bytes);
public long this[int i]=>Value[i];

public static A202322Inst Instance=new A202322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202323
{
public static readonly long[] Value={ 7L,9L,2L,0L,5L,9L,9L,6L,8L,4L,3L,0L,6L,7L,7L,0L,0L,1L,4L,1L,8L,3L,9L,5L,8L,7L,7L,8L,8L,5L,4L,2L,2L,0L,6L,1L,8L,6L,5L,9L,2L,2L,1L,9L,3L,1L,7L,0L,0L,9L,7L,8L,8L,2L,9L,0L,8L,0L,5L,0L,5L,5L,9L,7L,9L,3L,6L,2L,7L,3L,7L,2L,1L,0L,8L,5L,5L,1L,5L,4L,5L,7L,3L,2L,8L,1L,5L,0L,0L,8L,7L,3L,2L,3L,8L,3L,5L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202323Inst : IEnumerable<long>
{
public static readonly long[] Value=A202323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202323.Bytes);
public long this[int i]=>Value[i];

public static A202323Inst Instance=new A202323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202324
{
public static readonly long[] Value={ 2L,9L,4L,7L,5L,3L,0L,9L,0L,2L,5L,4L,2L,2L,8L,5L,1L,2L,7L,5L,9L,0L,1L,2L,6L,3L,8L,8L,7L,1L,3L,9L,8L,1L,6L,4L,1L,4L,4L,5L,8L,0L,0L,7L,6L,4L,5L,3L,9L,9L,6L,8L,9L,0L,4L,8L,9L,6L,6L,1L,8L,2L,8L,6L,6L,9L,1L,5L,6L,3L,9L,3L,7L,8L,3L,2L,2L,1L,1L,0L,0L,2L,3L,9L,5L,4L,7L,7L,7L,6L,5L,5L,4L,3L,8L,9L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202324Inst : IEnumerable<long>
{
public static readonly long[] Value=A202324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202324.Bytes);
public long this[int i]=>Value[i];

public static A202324Inst Instance=new A202324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202325
{
public static readonly long[] Value={ 1L,5L,0L,5L,2L,4L,1L,4L,9L,5L,7L,9L,2L,8L,8L,3L,3L,6L,6L,9L,9L,8L,6L,2L,4L,4L,3L,2L,1L,3L,7L,3L,5L,3L,9L,4L,0L,0L,7L,6L,8L,4L,3L,5L,6L,0L,1L,9L,0L,2L,1L,9L,8L,1L,1L,6L,4L,3L,7L,9L,4L,4L,0L,9L,2L,4L,6L,7L,9L,9L,9L,0L,3L,9L,9L,2L,5L,4L,5L,0L,8L,0L,7L,1L,7L,4L,7L,1L,0L,9L,0L,4L,4L,2L,2L,2L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202325Inst : IEnumerable<long>
{
public static readonly long[] Value=A202325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202325.Bytes);
public long this[int i]=>Value[i];

public static A202325Inst Instance=new A202325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202326
{
public static readonly long[] Value={ 5L,24L,52L,93L,145L,206L,280L,363L,456L,566L,670L,774L,886L,990L,1094L,1206L,1310L,1414L,1526L,1630L,1734L,1842L,1946L,2054L,2162L,2266L,2374L,2482L,2586L,2690L,2794L,2902L,3010L,3114L,3222L,3328L,3432L,3542L,3646L,3750L,3862L,3966L,4070L,4182L,4286L,4390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202326Inst : IEnumerable<long>
{
public static readonly long[] Value=A202326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202326.Bytes);
public long this[int i]=>Value[i];

public static A202326Inst Instance=new A202326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202327
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,2L,1L,-3L,1L,-3L,4L,3L,-4L,1L,-1L,-10L,5L,6L,-5L,1L,11L,4L,-21L,4L,10L,-6L,1L,-15L,28L,21L,-35L,0L,15L,-7L,1L,-13L,-64L,42L,56L,-50L,-8L,21L,-8L,1L,77L,9L,-162L,36L,114L,-63L,-21L,28L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202327Inst : IEnumerable<long>
{
public static readonly long[] Value=A202327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202327.Bytes);
public long this[int i]=>Value[i];

public static A202327Inst Instance=new A202327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202328
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,4L,0L,1L,2L,0L,6L,0L,1L,0L,8L,0L,8L,0L,1L,2L,0L,18L,0L,10L,0L,1L,0L,12L,0L,32L,0L,12L,0L,1L,2L,0L,38L,0L,50L,0L,14L,0L,1L,0L,16L,0L,88L,0L,72L,0L,16L,0L,1L,2L,0L,66L,0L,170L,0L,98L,0L,18L,0L,1L,0L,20L,0L,192L,0L,292L,0L,128L,0L,20L,0L,1L,2L,0L,102L,0L,450L,0L,462L,0L,162L,0L,22L,0L,1L,0L,24L,0L,360L,0L,912L,0L,688L,0L,200L,0L,24L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202328Inst : IEnumerable<long>
{
public static readonly long[] Value=A202328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202328.Bytes);
public long this[int i]=>Value[i];

public static A202328Inst Instance=new A202328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202329
{
public static readonly long[] Value={ 16L,48L,162L,576L,2102L,7790L,29174L,110112L,418134L,1595622L,6113746L,23505358L,90633802L,350351642L,1357278302L,5268292832L,20483876822L,79765662902L,311038321442L,1214362277702L,4746455801882L,18570960418922L,72728638093802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202329Inst : IEnumerable<long>
{
public static readonly long[] Value=A202329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202329.Bytes);
public long this[int i]=>Value[i];

public static A202329Inst Instance=new A202329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202330
{
public static readonly long[] Value={ 36L,82L,162L,289L,478L,746L,1112L,1597L,2224L,3018L,4006L,5217L,6682L,8434L,10508L,12941L,15772L,19042L,22794L,27073L,31926L,37402L,43552L,50429L,58088L,66586L,75982L,86337L,97714L,110178L,123796L,138637L,154772L,172274L,191218L,211681L,233742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202330Inst : IEnumerable<long>
{
public static readonly long[] Value=A202330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202330.Bytes);
public long this[int i]=>Value[i];

public static A202330Inst Instance=new A202330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202331
{
public static readonly long[] Value={ 49L,129L,289L,576L,1052L,1796L,2906L,4501L,6723L,9739L,13743L,18958L,25638L,34070L,44576L,57515L,73285L,92325L,115117L,142188L,174112L,211512L,255062L,305489L,363575L,430159L,506139L,592474L,690186L,800362L,924156L,1062791L,1217561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202331Inst : IEnumerable<long>
{
public static readonly long[] Value=A202331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202331.Bytes);
public long this[int i]=>Value[i];

public static A202331Inst Instance=new A202331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202332
{
public static readonly long[] Value={ 64L,191L,478L,1052L,2102L,3896L,6800L,11299L,18020L,27757L,41498L,60454L,86090L,120158L,164732L,222245L,295528L,387851L,502966L,645152L,819262L,1030772L,1285832L,1591319L,1954892L,2385049L,2891186L,3483658L,4173842L,4974202L,5898356L,6961145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202332Inst : IEnumerable<long>
{
public static readonly long[] Value=A202332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202332.Bytes);
public long this[int i]=>Value[i];

public static A202332Inst Instance=new A202332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202333
{
public static readonly long[] Value={ 81L,270L,746L,1796L,3896L,7790L,14588L,25885L,43903L,71658L,113154L,173606L,259694L,379850L,544580L,766823L,1062349L,1450198L,1953162L,2598312L,3417572L,4448342L,5734172L,7325489L,9280379L,11665426L,14556610L,18040266L,22214106L,27188306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202333Inst : IEnumerable<long>
{
public static readonly long[] Value=A202333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202333.Bytes);
public long this[int i]=>Value[i];

public static A202333Inst Instance=new A202333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202334
{
public static readonly long[] Value={ 100L,368L,1112L,2906L,6800L,14588L,29174L,55057L,98958L,170614L,283766L,457370L,717062L,1096910L,1641488L,2408309L,3470656L,4920852L,6874012L,9472322L,12889892L,17338232L,23072402L,30397889L,39678266L,51343690L,65900298L,83940562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202334Inst : IEnumerable<long>
{
public static readonly long[] Value=A202334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202334.Bytes);
public long this[int i]=>Value[i];

public static A202334Inst Instance=new A202334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202335
{
public static readonly long[] Value={ 16L,25L,25L,36L,48L,36L,49L,82L,82L,49L,64L,129L,162L,129L,64L,81L,191L,289L,289L,191L,81L,100L,270L,478L,576L,478L,270L,100L,121L,368L,746L,1052L,1052L,746L,368L,121L,144L,487L,1112L,1796L,2102L,1796L,1112L,487L,144L,169L,629L,1597L,2906L,3896L,3896L,2906L,1597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202335Inst : IEnumerable<long>
{
public static readonly long[] Value=A202335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202335.Bytes);
public long this[int i]=>Value[i];

public static A202335Inst Instance=new A202335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202336
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,15L,84L,561L,4260L,36413L,346276L,3628801L,41569064L,516929544L,6936548425L,99917483647L,1537944393896L,25193549397053L,437655212248536L,8036723680196724L,155554110186062367L,3165278489148945082L,BigInteger.Parse("67553429525569109411"),BigInteger.Parse("1508884070229326953381") };
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
public class A202336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202336Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202336.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202336.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202336Inst Instance=new A202336Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202337
{
public static readonly long[] Value={ 1L,2L,6L,12L,36L,108L,324L,972L,2916L,8748L,26244L,78732L,236196L,708588L,2125764L,6377292L,19131876L,57395628L,172186884L,516560652L,1549681956L,4649045868L,13947137604L,41841412812L,125524238436L,376572715308L,1129718145924L,3389154437772L,10167463313316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202337Inst : IEnumerable<long>
{
public static readonly long[] Value=A202337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202337.Bytes);
public long this[int i]=>Value[i];

public static A202337Inst Instance=new A202337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202338
{
public static readonly long[] Value={ 1L,3L,1L,1L,3L,1L,1L,3L,377L,1L,3L,13L,1L,89L,1L,3L,3L,1L,1L,89L,1L,3L,3L,1L,1L,3L,1L,1L,3L,89L,1L,21L,1L,13L,3L,13L,3L,3L,89L,1L,233L,1L,1L,3L,13L,1L,21L,13L,1L,3L,13L,1L,233L,1L,21L,3L,1L,13L,3L,1L,3L,21L,1L,1L,3L,1L,3L,3L,1L,1L,21L,13L,3L,3L,1L,1L,3L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202338Inst : IEnumerable<long>
{
public static readonly long[] Value=A202338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202338.Bytes);
public long this[int i]=>Value[i];

public static A202338Inst Instance=new A202338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202339
{
public static readonly long[] Value={ 1L,1L,1L,0L,3L,10L,9L,2L,0L,1L,7L,17L,17L,6L,0L,0L,15L,180L,830L,1848L,2015L,900L,20L,0L,-48L,3L,55L,410L,1598L,3467L,4055L,2120L,52L,-240L,0L,0L,63L,1638L,17955L,107954L,387009L,837426L,1038681L,606606L,9828L,-113624L,-2016L,11520L,0L,9L,315L,4767L,40859L,217973L,747021L,1628877L,2122953L,1344798L,-5516L,-374024L,-2592L,80640L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202339Inst : IEnumerable<long>
{
public static readonly long[] Value=A202339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202339.Bytes);
public long this[int i]=>Value[i];

public static A202339Inst Instance=new A202339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202340
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202340Inst : IEnumerable<long>
{
public static readonly long[] Value=A202340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202340.Bytes);
public long this[int i]=>Value[i];

public static A202340Inst Instance=new A202340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202341
{
public static readonly long[] Value={ 0L,2L,3L,6L,8L,9L,11L,12L,15L,16L,19L,21L,22L,25L,27L,28L,30L,31L,34L,36L,37L,39L,40L,43L,44L,47L,49L,50L,52L,53L,56L,57L,60L,62L,63L,66L,68L,69L,71L,72L,75L,76L,79L,81L,82L,85L,87L,88L,90L,91L,94L,96L,97L,99L,100L,103L,104L,107L,109L,110L,113L,115L,116L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202341Inst : IEnumerable<long>
{
public static readonly long[] Value=A202341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202341.Bytes);
public long this[int i]=>Value[i];

public static A202341Inst Instance=new A202341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202342
{
public static readonly long[] Value={ 1L,4L,5L,7L,10L,13L,14L,17L,18L,20L,23L,24L,26L,29L,32L,33L,35L,38L,41L,42L,45L,46L,48L,51L,54L,55L,58L,59L,61L,64L,65L,67L,70L,73L,74L,77L,78L,80L,83L,84L,86L,89L,92L,93L,95L,98L,101L,102L,105L,106L,108L,111L,112L,114L,117L,120L,121L,123L,126L,129L,130L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202342Inst : IEnumerable<long>
{
public static readonly long[] Value=A202342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202342.Bytes);
public long this[int i]=>Value[i];

public static A202342Inst Instance=new A202342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202343
{
public static readonly long[] Value={ 1L,2L,5L,6L,4L,3L,1L,2L,0L,8L,6L,2L,6L,1L,6L,9L,6L,7L,6L,9L,8L,2L,7L,3L,7L,6L,1L,6L,6L,0L,9L,2L,1L,6L,3L,2L,6L,9L,1L,6L,4L,1L,6L,8L,3L,1L,7L,0L,1L,3L,2L,3L,7L,1L,1L,1L,2L,5L,8L,9L,4L,7L,2L,7L,0L,4L,8L,3L,0L,0L,4L,7L,8L,5L,4L,1L,0L,5L,1L,9L,0L,3L,5L,3L,3L,6L,6L,4L,7L,5L,0L,9L,4L,7L,2L,5L,0L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202343Inst : IEnumerable<long>
{
public static readonly long[] Value=A202343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202343.Bytes);
public long this[int i]=>Value[i];

public static A202343Inst Instance=new A202343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202344
{
public static readonly long[] Value={ 1L,9L,0L,3L,8L,1L,3L,6L,9L,4L,4L,4L,0L,3L,8L,3L,4L,8L,4L,7L,1L,0L,1L,4L,0L,3L,6L,0L,8L,2L,8L,1L,3L,5L,1L,2L,7L,2L,8L,0L,3L,6L,4L,8L,0L,4L,5L,6L,1L,9L,8L,7L,4L,4L,5L,8L,7L,9L,3L,8L,9L,8L,1L,8L,2L,8L,1L,9L,4L,5L,8L,7L,5L,4L,4L,5L,2L,5L,1L,7L,4L,2L,9L,3L,5L,8L,9L,7L,2L,2L,1L,2L,0L,9L,0L,7L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202344Inst : IEnumerable<long>
{
public static readonly long[] Value=A202344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202344.Bytes);
public long this[int i]=>Value[i];

public static A202344Inst Instance=new A202344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202345
{
public static readonly long[] Value={ 7L,6L,8L,0L,3L,9L,0L,4L,7L,0L,1L,3L,4L,6L,5L,5L,6L,5L,2L,5L,5L,6L,8L,3L,5L,2L,6L,0L,7L,7L,5L,4L,7L,9L,9L,0L,9L,0L,6L,8L,4L,9L,1L,4L,8L,8L,7L,1L,9L,1L,8L,1L,9L,4L,5L,1L,0L,3L,1L,0L,3L,2L,7L,2L,4L,8L,3L,7L,8L,8L,9L,0L,1L,2L,7L,6L,2L,3L,4L,2L,0L,7L,0L,9L,1L,4L,5L,1L,3L,9L,0L,2L,0L,3L,3L,9L,5L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202345Inst : IEnumerable<long>
{
public static readonly long[] Value=A202345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202345.Bytes);
public long this[int i]=>Value[i];

public static A202345Inst Instance=new A202345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202346
{
public static readonly long[] Value={ 1L,6L,7L,8L,3L,4L,6L,9L,9L,0L,0L,1L,6L,6L,6L,0L,6L,5L,3L,4L,1L,2L,8L,8L,4L,5L,1L,2L,0L,9L,4L,5L,2L,3L,0L,8L,4L,8L,2L,4L,4L,5L,8L,7L,6L,5L,3L,5L,1L,6L,0L,2L,2L,1L,6L,3L,9L,8L,3L,4L,1L,8L,6L,8L,3L,9L,9L,0L,4L,7L,6L,4L,5L,6L,8L,5L,7L,1L,3L,4L,3L,6L,9L,9L,7L,4L,6L,9L,8L,2L,4L,1L,8L,8L,1L,2L,0L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202346Inst : IEnumerable<long>
{
public static readonly long[] Value=A202346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202346.Bytes);
public long this[int i]=>Value[i];

public static A202346Inst Instance=new A202346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202347
{
public static readonly long[] Value={ 2L,6L,4L,7L,4L,5L,0L,2L,4L,2L,0L,4L,9L,9L,6L,6L,7L,2L,0L,7L,2L,7L,2L,0L,1L,2L,2L,2L,1L,4L,6L,4L,1L,5L,2L,4L,3L,5L,5L,9L,2L,9L,7L,3L,7L,7L,0L,8L,0L,1L,9L,6L,6L,8L,3L,0L,5L,4L,0L,3L,2L,2L,2L,7L,8L,8L,5L,8L,1L,1L,9L,4L,6L,0L,7L,5L,9L,2L,2L,7L,8L,4L,5L,5L,2L,1L,4L,9L,0L,3L,3L,5L,7L,2L,7L,8L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202347Inst : IEnumerable<long>
{
public static readonly long[] Value=A202347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202347.Bytes);
public long this[int i]=>Value[i];

public static A202347Inst Instance=new A202347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202348
{
public static readonly long[] Value={ 1L,5L,8L,5L,9L,4L,3L,3L,9L,5L,6L,3L,0L,3L,9L,3L,6L,2L,1L,5L,3L,3L,9L,5L,3L,4L,1L,9L,8L,7L,5L,1L,3L,8L,9L,3L,9L,4L,9L,6L,2L,8L,6L,8L,5L,6L,2L,2L,3L,6L,0L,3L,3L,0L,4L,3L,5L,1L,4L,9L,9L,1L,0L,4L,5L,1L,8L,1L,5L,9L,1L,8L,7L,8L,1L,6L,8L,2L,9L,9L,9L,4L,8L,9L,6L,5L,4L,3L,2L,8L,3L,0L,8L,6L,9L,5L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202348Inst : IEnumerable<long>
{
public static readonly long[] Value=A202348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202348.Bytes);
public long this[int i]=>Value[i];

public static A202348Inst Instance=new A202348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202349
{
public static readonly long[] Value={ 1L,3L,9L,20L,39L,75L,148L,297L,597L,1196L,2391L,4779L,9556L,19113L,38229L,76460L,152919L,305835L,611668L,1223337L,2446677L,4893356L,9786711L,19573419L,39146836L,78293673L,156587349L,313174700L,626349399L,1252698795L,2505397588L,5010795177L,10021590357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202349Inst : IEnumerable<long>
{
public static readonly long[] Value=A202349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202349.Bytes);
public long this[int i]=>Value[i];

public static A202349Inst Instance=new A202349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202350
{
public static readonly long[] Value={ 1L,7L,5L,0L,7L,8L,6L,7L,2L,2L,6L,8L,0L,1L,4L,6L,3L,6L,7L,5L,7L,0L,0L,1L,4L,8L,7L,7L,2L,5L,5L,3L,3L,2L,8L,9L,4L,1L,3L,7L,8L,6L,6L,3L,4L,9L,4L,0L,8L,2L,6L,8L,4L,9L,0L,8L,0L,5L,9L,4L,5L,7L,5L,6L,1L,6L,0L,8L,4L,7L,8L,6L,1L,9L,5L,5L,1L,7L,3L,2L,0L,6L,4L,9L,0L,1L,6L,9L,1L,4L,7L,2L,5L,8L,0L,3L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202350Inst : IEnumerable<long>
{
public static readonly long[] Value=A202350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202350.Bytes);
public long this[int i]=>Value[i];

public static A202350Inst Instance=new A202350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202351
{
public static readonly long[] Value={ 6L,1L,9L,0L,6L,1L,2L,8L,6L,7L,3L,5L,9L,4L,5L,1L,1L,2L,1L,5L,2L,3L,2L,6L,9L,9L,4L,0L,2L,0L,9L,2L,2L,2L,3L,3L,3L,0L,1L,4L,7L,1L,7L,7L,7L,2L,6L,2L,9L,6L,9L,3L,5L,2L,4L,5L,9L,8L,3L,6L,0L,7L,4L,4L,9L,2L,9L,3L,7L,3L,5L,2L,2L,5L,5L,0L,8L,8L,7L,3L,4L,6L,1L,1L,0L,4L,6L,9L,2L,6L,1L,8L,8L,2L,5L,8L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202351Inst : IEnumerable<long>
{
public static readonly long[] Value=A202351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202351.Bytes);
public long this[int i]=>Value[i];

public static A202351Inst Instance=new A202351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202352
{
public static readonly long[] Value={ 1L,5L,1L,2L,1L,3L,4L,5L,5L,1L,6L,5L,7L,8L,4L,2L,4L,7L,3L,8L,9L,6L,7L,3L,9L,6L,7L,8L,0L,7L,2L,0L,3L,8L,7L,0L,4L,6L,0L,3L,6L,5L,0L,3L,8L,5L,1L,3L,5L,3L,5L,9L,4L,5L,4L,2L,5L,9L,2L,8L,5L,4L,7L,3L,9L,9L,8L,9L,7L,7L,1L,6L,0L,5L,1L,1L,5L,7L,4L,8L,2L,7L,3L,2L,4L,2L,6L,5L,4L,8L,8L,1L,5L,2L,7L,7L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202352Inst : IEnumerable<long>
{
public static readonly long[] Value=A202352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202352.Bytes);
public long this[int i]=>Value[i];

public static A202352Inst Instance=new A202352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202353
{
public static readonly long[] Value={ 3L,1L,4L,9L,2L,3L,0L,5L,7L,8L,4L,5L,4L,0L,6L,0L,5L,3L,9L,7L,1L,7L,5L,0L,5L,1L,9L,4L,6L,2L,3L,6L,9L,8L,1L,1L,5L,8L,5L,9L,4L,4L,2L,8L,4L,3L,1L,9L,1L,7L,9L,4L,6L,6L,4L,5L,9L,0L,1L,9L,8L,4L,5L,0L,1L,2L,4L,9L,6L,1L,2L,1L,4L,8L,8L,8L,1L,1L,8L,5L,2L,1L,8L,8L,0L,3L,4L,4L,4L,4L,4L,8L,2L,0L,8L,0L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202353Inst : IEnumerable<long>
{
public static readonly long[] Value=A202353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202353.Bytes);
public long this[int i]=>Value[i];

public static A202353Inst Instance=new A202353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202354
{
public static readonly long[] Value={ 7L,0L,1L,5L,0L,2L,0L,6L,3L,5L,6L,6L,8L,4L,4L,6L,1L,1L,0L,8L,2L,4L,9L,6L,9L,1L,7L,1L,5L,8L,6L,5L,0L,7L,6L,3L,9L,8L,4L,6L,2L,9L,2L,5L,6L,9L,3L,6L,2L,5L,3L,1L,7L,2L,5L,2L,5L,9L,3L,4L,5L,5L,5L,5L,8L,1L,3L,2L,6L,0L,5L,5L,8L,6L,2L,5L,5L,7L,5L,9L,5L,4L,1L,8L,9L,4L,2L,7L,3L,3L,8L,4L,9L,8L,2L,4L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202354Inst : IEnumerable<long>
{
public static readonly long[] Value=A202354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202354.Bytes);
public long this[int i]=>Value[i];

public static A202354Inst Instance=new A202354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202355
{
public static readonly long[] Value={ 1L,2L,7L,8L,4L,6L,4L,5L,4L,2L,7L,6L,1L,0L,7L,3L,7L,9L,5L,1L,0L,9L,3L,5L,8L,7L,3L,9L,0L,2L,2L,9L,8L,0L,1L,5L,5L,4L,3L,9L,4L,7L,7L,4L,8L,8L,6L,1L,9L,7L,4L,5L,7L,6L,5L,4L,5L,3L,1L,7L,8L,1L,0L,5L,5L,3L,5L,0L,2L,9L,3L,7L,5L,4L,5L,9L,9L,4L,9L,8L,9L,8L,1L,9L,2L,0L,4L,9L,8L,4L,2L,8L,1L,1L,2L,9L,9L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202355Inst : IEnumerable<long>
{
public static readonly long[] Value=A202355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202355.Bytes);
public long this[int i]=>Value[i];

public static A202355Inst Instance=new A202355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202356
{
public static readonly long[] Value={ 3L,5L,1L,7L,3L,3L,7L,1L,1L,2L,4L,9L,1L,9L,5L,8L,2L,6L,0L,2L,4L,9L,0L,9L,3L,0L,0L,9L,2L,9L,9L,5L,1L,0L,6L,5L,1L,7L,1L,4L,6L,4L,2L,1L,5L,5L,1L,7L,1L,1L,1L,8L,0L,4L,0L,4L,6L,6L,4L,3L,8L,4L,6L,1L,0L,9L,9L,6L,0L,6L,1L,0L,7L,2L,0L,3L,3L,8L,7L,1L,0L,8L,9L,6L,8L,3L,2L,3L,0L,3L,8L,3L,2L,1L,9L,1L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202356Inst : IEnumerable<long>
{
public static readonly long[] Value=A202356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202356.Bytes);
public long this[int i]=>Value[i];

public static A202356Inst Instance=new A202356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202357
{
public static readonly long[] Value={ 2L,7L,8L,4L,6L,4L,5L,4L,2L,7L,6L,1L,0L,7L,3L,7L,9L,5L,1L,0L,9L,3L,5L,8L,7L,3L,9L,0L,2L,2L,9L,8L,0L,1L,5L,5L,4L,3L,9L,4L,7L,7L,4L,8L,8L,6L,1L,9L,7L,4L,5L,7L,6L,5L,4L,5L,3L,1L,7L,8L,1L,0L,5L,5L,3L,5L,0L,2L,9L,3L,7L,5L,4L,5L,9L,9L,4L,9L,8L,9L,8L,1L,9L,2L,0L,4L,9L,8L,4L,2L,8L,1L,1L,2L,9L,9L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202357Inst : IEnumerable<long>
{
public static readonly long[] Value=A202357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202357.Bytes);
public long this[int i]=>Value[i];

public static A202357Inst Instance=new A202357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202358
{
public static readonly long[] Value={ 0L,1L,4L,18L,73L,334L,2592L,18919L,164476L,1558521L,1L,187044031L,2326111614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202358Inst : IEnumerable<long>
{
public static readonly long[] Value=A202358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202358.Bytes);
public long this[int i]=>Value[i];

public static A202358Inst Instance=new A202358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202359
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,27L,648L,68040L,136080L,51030L,653184L,4849891200L,203695430400L,43649020800L,1466607098880L,285988384281600L,8579651528448000L,15014390174784000L,64061398079078400L,BigInteger.Parse("2793397263238213632000"),BigInteger.Parse("184364219373722099712000"),BigInteger.Parse("9669452065055354880000"),BigInteger.Parse("46459783282177969127424000"),BigInteger.Parse("16028625232351399348961280000") };
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
public class A202359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202359Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202359.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202359Inst Instance=new A202359Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202360
{
public static readonly BigInteger[] Value={ 1L,2L,4L,16L,144L,768L,10560L,92160L,1585920L,21127680L,419973120L,7431782400L,177081569280L,3923981107200L,105929096232960L,2868863206809600L,87449689674547200L,2742391916199936000L,BigInteger.Parse("94359281224797388800"),BigInteger.Parse("3356687705428721664000") };
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
public class A202360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202360Inst Instance=new A202360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202361
{
public static readonly long[] Value={ 12102794130L,141702673770L,424052301750L,699699330330L,714303547230L,739544215410L,1623198312120L,2691533434590L,4207848555330L,4936074819480L,5887574660310L,6562654104930L,7205070907650L,8129061524010L,8362548652500L,9741706748970L,9967327212570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202361Inst : IEnumerable<long>
{
public static readonly long[] Value=A202361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202361.Bytes);
public long this[int i]=>Value[i];

public static A202361Inst Instance=new A202361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202362
{
public static readonly long[] Value={ 9853497737L,22741837817L,242360943257L,1418575498577L,4396774576277L,8639103445097L,11105292314087L,12728490626207L,119057768524127L,226608256438997L,581653272077387L,896217252921227L,987041423819807L,1408999953009347L,1419018243046487L,2189095026865907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202362Inst : IEnumerable<long>
{
public static readonly long[] Value=A202362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202362.Bytes);
public long this[int i]=>Value[i];

public static A202362Inst Instance=new A202362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202363
{
public static readonly long[] Value={ 1L,6L,3L,36L,24L,12L,240L,180L,120L,60L,1800L,1440L,1080L,720L,360L,15120L,12600L,10080L,7560L,5040L,2520L,141120L,120960L,100800L,80640L,60480L,40320L,20160L,1451520L,1270080L,1088640L,907200L,725760L,544320L,362880L,181440L,16329600L,14515200L,12700800L,10886400L,9072000L,7257600L,5443200L,3628800L,1814400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202363Inst : IEnumerable<long>
{
public static readonly long[] Value=A202363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202363.Bytes);
public long this[int i]=>Value[i];

public static A202363Inst Instance=new A202363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202364
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,6L,54L,444L,3828L,34404L,331812L,3457224L,38902104L,472682088L,6185876904L,86896701072L,1305666612144L,20907918062064L,355572850545648L,6401460197543904L,121637573726005152L,2432837939316094944L,BigInteger.Parse("51090380436082401504"),BigInteger.Parse("1123995659389121919168") };
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
public class A202364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202364Inst Instance=new A202364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202365
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,54L,336L,2400L,19440L,176400L,1774080L,19595520L,235872000L,3073593600L,43110144000L,647610163200L,10374216652800L,176536039680000L,3180264062976000L,60466862776320000L,1210048630382592000L,BigInteger.Parse("25423825985445888000"),BigInteger.Parse("559567461880627200000"),BigInteger.Parse("12874917427270778880000") };
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
public class A202365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202365Inst Instance=new A202365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202366
{
public static readonly BigInteger[] Value={ 0L,6L,18L,-36L,-360L,-1350L,27162L,337608L,-606528L,-90432450L,-880859934L,18455713503L,693789107544L,1701104157090L,-385899715094310L,-8961561593356464L,131483054194960485L,11226865165557040813UL,BigInteger.Parse("130224770734566143291"),BigInteger.Parse("-10087278971257481285822") };
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
public class A202366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202366Inst Instance=new A202366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202367
{
public static readonly BigInteger[] Value={ 1L,6L,360L,45360L,5443200L,359251200L,5884534656000L,35307207936000L,144053408378880000L,BigInteger.Parse("1034591578977116160000"),BigInteger.Parse("3414152210624483328000000"),BigInteger.Parse("471153005066178699264000000"),BigInteger.Parse("15434972445968014187888640000000"),BigInteger.Parse("92609834675808085127331840000000"),BigInteger.Parse("161141112335906068121557401600000000") };
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
public class A202367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202367Inst Instance=new A202367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202368
{
public static readonly BigInteger[] Value={ 1L,4L,672L,13440L,58705920L,234823680L,11243357798400L,494707743129600L,4321766843980185600L,BigInteger.Parse("86435336879603712000"),BigInteger.Parse("450155234468976132096000") };
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
public class A202368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202368Inst Instance=new A202368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202369
{
public static readonly BigInteger[] Value={ 1L,30L,1800L,14742000L,30073680000L,49621572000000L,812801349360000000L,BigInteger.Parse("707137173943200000000"),BigInteger.Parse("2885119669688256000000000"),BigInteger.Parse("49833835369821036293760000000000"),BigInteger.Parse("6742517925536786210545728000000000000") };
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
public class A202369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202369Inst Instance=new A202369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202370
{
public static readonly long[] Value={ 98L,824L,7349L,62033L,589613L,5444710L,51833855L,500733797L,4838603161L,47316275496L,463941283342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202370Inst : IEnumerable<long>
{
public static readonly long[] Value=A202370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202370.Bytes);
public long this[int i]=>Value[i];

public static A202370Inst Instance=new A202370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202371
{
public static readonly long[] Value={ 98L,257L,611L,1326L,2815L,5718L,11362L,22164L,42507L,80633L,151352L,281811L,521224L,958418L,1754004L,3196693L,5805401L,10510754L,18978585L,34187852L,61457038L,110271668L,197530737L,353309613L,631087988L,1125880395L,2006365746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202371Inst : IEnumerable<long>
{
public static readonly long[] Value=A202371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202371.Bytes);
public long this[int i]=>Value[i];

public static A202371Inst Instance=new A202371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202372
{
public static readonly long[] Value={ 257L,824L,2293L,5677L,13751L,31240L,68965L,148281L,310793L,640839L,1299608L,2601118L,5148674L,10088995L,19604270L,37808312L,72431966L,137955751L,261370700L,492867363L,925469673L,1731093570L,3226750237L,5995509954L,11107634611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202372Inst : IEnumerable<long>
{
public static readonly long[] Value=A202372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202372.Bytes);
public long this[int i]=>Value[i];

public static A202372Inst Instance=new A202372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202373
{
public static readonly long[] Value={ 611L,2293L,7349L,20247L,54611L,136304L,327679L,763588L,1721033L,3799888L,8211737L,17438746L,36502015L,75371771L,153887886L,310995366L,622783262L,1237165150L,2439654168L,4779420957L,9307434062L,18026860476L,34742343252L,66653403132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202373Inst : IEnumerable<long>
{
public static readonly long[] Value=A202373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202373.Bytes);
public long this[int i]=>Value[i];

public static A202373Inst Instance=new A202373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202374
{
public static readonly long[] Value={ 1326L,5677L,20247L,62033L,182411L,494783L,1285065L,3207444L,7727120L,18118987L,41455583L,92866560L,204327155L,442336864L,944080705L,1989776449L,4146042739L,8551843243L,17477022964L,35418893825L,71235013646L,142269636195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202374Inst : IEnumerable<long>
{
public static readonly long[] Value=A202374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202374.Bytes);
public long this[int i]=>Value[i];

public static A202374Inst Instance=new A202374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202375
{
public static readonly long[] Value={ 2815L,13751L,54611L,182411L,589613L,1727073L,4830102L,12936204L,33205183L,82794590L,200519323L,474103610L,1097910960L,2494672305L,5575864988L,12279125958L,26681330332L,57283519350L,121646873615L,255765799468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202375Inst : IEnumerable<long>
{
public static readonly long[] Value=A202375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202375.Bytes);
public long this[int i]=>Value[i];

public static A202375Inst Instance=new A202375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202376
{
public static readonly long[] Value={ 5718L,31240L,136304L,494783L,1727073L,5444710L,16261405L,46335444L,126119710L,331945481L,846671739L,2101007170L,5094691890L,12091711430L,28168737260L,64529826592L,145583250696L,323993788947L,712036717070L,1547097770520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202376Inst : IEnumerable<long>
{
public static readonly long[] Value=A202376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202376.Bytes);
public long this[int i]=>Value[i];

public static A202376Inst Instance=new A202376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202377
{
public static readonly long[] Value={ 11362L,68965L,327679L,1285065L,4830102L,16261405L,51833855L,156557263L,450660848L,1250551900L,3351714309L,8722793052L,22118866900L,54801500414L,132976157412L,316751623141L,741810250017L,1710936850978L,3891524278627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202377Inst : IEnumerable<long>
{
public static readonly long[] Value=A202377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202377.Bytes);
public long this[int i]=>Value[i];

public static A202377Inst Instance=new A202377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202378
{
public static readonly long[] Value={ 98L,257L,257L,611L,824L,611L,1326L,2293L,2293L,1326L,2815L,5677L,7349L,5677L,2815L,5718L,13751L,20247L,20247L,13751L,5718L,11362L,31240L,54611L,62033L,54611L,31240L,11362L,22164L,68965L,136304L,182411L,182411L,136304L,68965L,22164L,42507L,148281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202378Inst : IEnumerable<long>
{
public static readonly long[] Value=A202378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202378.Bytes);
public long this[int i]=>Value[i];

public static A202378Inst Instance=new A202378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202379
{
public static readonly BigInteger[] Value={ 1L,2L,8L,8L,960L,288L,1152L,17280L,5806080L,89600L,87091200L,17418240L,213497856000L,402361344000L,62768369664000L,295206912L,102437979291648000L,342372925440000L,256094948229120000L,5377993912811520000L,BigInteger.Parse("61309130606051328000000"),89903156428800000L,BigInteger.Parse("12450469599998115840000"),BigInteger.Parse("73570956727261593600000") };
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
public class A202379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202379Inst Instance=new A202379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202380
{
public static readonly BigInteger[] Value={ 1L,3L,15L,5670L,1134L,311850L,364864500L,3831077250L,390769879500L,3508136593211250L,58468943220187500L,4437792790412231250L,3234019037547375000L,BigInteger.Parse("18172761476738086968750"),BigInteger.Parse("1054020165650809044187500"),BigInteger.Parse("3329928708628872161217656250"),BigInteger.Parse("3396527282801449604442009375000"),BigInteger.Parse("3331209450439883265895047656250") };
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
public class A202380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202380Inst Instance=new A202380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202381
{
public static readonly BigInteger[] Value={ 6L,1296L,145152L,156764160L,893931945984L,46352026828800L,2402889070804992L,BigInteger.Parse("5903898446967865344000"),BigInteger.Parse("205118300328940693094400"),BigInteger.Parse("869939530623090109924245504000"),BigInteger.Parse("60506034233897163325451123294208000"),BigInteger.Parse("105227885624168979696436736163840000"),BigInteger.Parse("5629853769947846827574282979744153600000") };
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
public class A202381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202381.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202381Inst Instance=new A202381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202382
{
public static readonly BigInteger[] Value={ 1L,6L,72L,1296L,31104L,6531840L,235146240L,1410877440L,67722117120L,40226937569280L,16895313779097600L,4054875306983424L,291951022102806528L,BigInteger.Parse("569304493100472729600"),BigInteger.Parse("6831653917205672755200"),BigInteger.Parse("331072459064582602752000"),BigInteger.Parse("82635685782519817646899200"),BigInteger.Parse("800739795232617032998453248000"),BigInteger.Parse("190255775347269807040432491724800") };
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
public class A202382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202382.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202382Inst Instance=new A202382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202383
{
public static readonly BigInteger[] Value={ 1L,6L,12L,2835L,2520L,467775L,935550L,127702575L,10216206000L,31892150847375L,18561569276250L,147926426347074375L,34806217964017500L,BigInteger.Parse("144228265688397515625"),BigInteger.Parse("9086380738369043484375"),BigInteger.Parse("3691877481305923483089140625"),BigInteger.Parse("3920955016221009644377500000"),BigInteger.Parse("206217727884373725983979140625"),BigInteger.Parse("43305722855718482456635619531250") };
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
public class A202383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202383Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202383.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202383.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202383Inst Instance=new A202383Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202384
{
public static readonly BigInteger[] Value={ 1L,30L,1800L,1134000L,27216000L,583783200000L,735566832000000L,53591297760000000L,256505356800000000L,BigInteger.Parse("215539912286899200000000"),BigInteger.Parse("9246662237107975680000000000"),BigInteger.Parse("6380196943604503219200000000000"),BigInteger.Parse("846215594625439374336000000000000"),BigInteger.Parse("608171468659065776424960000000000000") };
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
public class A202384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202384Inst Instance=new A202384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202385
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,2L,0L,1L,0L,4L,0L,3L,0L,1L,0L,5L,0L,8L,0L,2L,0L,5L,0L,10L,0L,4L,0L,13L,0L,15L,0L,3L,1L,13L,0L,19L,0L,9L,1L,24L,0L,20L,2L,13L,2L,29L,0L,34L,2L,17L,2L,34L,1L,49L,2L,21L,3L,58L,2L,63L,3L,20L,7L,72L,2L,81L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202385Inst : IEnumerable<long>
{
public static readonly long[] Value=A202385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202385.Bytes);
public long this[int i]=>Value[i];

public static A202385Inst Instance=new A202385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202386
{
public static readonly long[] Value={ 65L,5625L,6565L,50721L,65065L,71555L,75515L,84295L,541063L,557931L,650065L,650606L,656565L,699796L,809325L,827372L,934065L,2855182L,4637061L,4854634L,5791775L,5883141L,5951693L,6129084L,6500065L,6731076L,6752626L,6791774L,7768827L,8084505L,9349065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202386Inst : IEnumerable<long>
{
public static readonly long[] Value=A202386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202386.Bytes);
public long this[int i]=>Value[i];

public static A202386Inst Instance=new A202386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202387
{
public static readonly long[] Value={ 22L,58L,85L,94L,166L,202L,265L,274L,319L,346L,355L,382L,391L,438L,454L,483L,517L,526L,535L,562L,627L,634L,645L,654L,663L,690L,706L,762L,778L,861L,895L,913L,915L,922L,958L,985L,1086L,1111L,1165L,1219L,1255L,1282L,1507L,1581L,1626L,1633L,1642L,1678L,1795L,1822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202387Inst : IEnumerable<long>
{
public static readonly long[] Value=A202387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202387.Bytes);
public long this[int i]=>Value[i];

public static A202387Inst Instance=new A202387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202388
{
public static readonly long[] Value={ 4L,4L,9L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,9L,4L,4L,6L,4L,6L,4L,4L,4L,4L,9L,3L,6L,4L,6L,6L,9L,6L,6L,9L,6L,4L,8L,9L,6L,4L,6L,6L,6L,4L,4L,6L,4L,4L,4L,6L,4L,4L,4L,4L,4L,6L,8L,9L,4L,6L,6L,4L,4L,4L,8L,9L,3L,4L,4L,6L,4L,9L,9L,4L,4L,9L,4L,9L,8L,9L,4L,4L,6L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202388Inst : IEnumerable<long>
{
public static readonly long[] Value=A202388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202388.Bytes);
public long this[int i]=>Value[i];

public static A202388Inst Instance=new A202388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202389
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,2L,-1L,-2L,2L,3L,1L,-2L,-5L,3L,5L,1L,3L,-5L,-10L,5L,8L,-1L,3L,9L,-10L,-20L,8L,13L,-1L,-4L,9L,22L,-20L,-38L,13L,21L,1L,-4L,-14L,22L,51L,-38L,-71L,21L,34L,1L,5L,-14L,-40L,51L,111L,-71L,130L,34L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202389Inst : IEnumerable<long>
{
public static readonly long[] Value=A202389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202389.Bytes);
public long this[int i]=>Value[i];

public static A202389Inst Instance=new A202389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202390
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,8L,3L,1L,10L,21L,17L,5L,1L,15L,45L,58L,35L,8L,1L,21L,85L,154L,144L,68L,13L,1L,28L,147L,350L,452L,330L,129L,21L,1L,36L,238L,714L,1195L,1198L,719L,239L,34L,1L,45L,366L,1344L,2799L,3611L,2959L,1506L,436L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202390Inst : IEnumerable<long>
{
public static readonly long[] Value=A202390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202390.Bytes);
public long this[int i]=>Value[i];

public static A202390Inst Instance=new A202390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202391
{
public static readonly long[] Value={ 5L,39L,237L,1391L,8117L,47319L,275805L,1607519L,9369317L,54608391L,318281037L,1855077839L,10812186005L,63018038199L,367296043197L,2140758220991L,12477253282757L,72722761475559L,423859315570605L,2470433131948079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202391Inst : IEnumerable<long>
{
public static readonly long[] Value=A202391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202391.Bytes);
public long this[int i]=>Value[i];

public static A202391Inst Instance=new A202391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202392
{
public static readonly long[] Value={ 2L,5L,7L,6L,2L,7L,6L,5L,3L,0L,4L,9L,7L,3L,6L,7L,0L,4L,2L,8L,2L,9L,1L,6L,2L,0L,1L,6L,2L,6L,0L,9L,7L,7L,9L,0L,9L,0L,9L,6L,9L,2L,6L,4L,7L,5L,0L,3L,2L,0L,4L,4L,9L,1L,5L,3L,3L,9L,5L,1L,1L,4L,4L,0L,6L,6L,3L,1L,9L,1L,2L,9L,2L,7L,5L,2L,0L,4L,3L,7L,2L,4L,5L,9L,6L,3L,9L,8L,8L,7L,9L,3L,4L,1L,0L,0L,2L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202392Inst : IEnumerable<long>
{
public static readonly long[] Value=A202392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202392.Bytes);
public long this[int i]=>Value[i];

public static A202392Inst Instance=new A202392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202393
{
public static readonly long[] Value={ 4L,4L,3L,4L,4L,1L,7L,4L,4L,9L,7L,4L,4L,2L,4L,3L,4L,4L,1L,4L,4L,4L,1L,6L,4L,6L,8L,6L,3L,4L,4L,4L,4L,6L,4L,5L,6L,2L,6L,3L,6L,6L,9L,4L,3L,6L,6L,4L,9L,5L,6L,4L,4L,6L,4L,3L,4L,4L,6L,4L,9L,5L,4L,4L,4L,4L,7L,3L,9L,8L,4L,2L,1L,6L,7L,1L,6L,4L,4L,3L,9L,4L,7L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202393Inst : IEnumerable<long>
{
public static readonly long[] Value=A202393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202393.Bytes);
public long this[int i]=>Value[i];

public static A202393Inst Instance=new A202393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202394
{
public static readonly long[] Value={ 1L,6L,0L,5L,0L,0L,-7L,0L,0L,0L,-18L,0L,0L,0L,0L,-11L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,30L,0L,0L,0L,0L,0L,0L,0L,17L,0L,0L,0L,0L,0L,0L,0L,0L,-19L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-42L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-23L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,25L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,54L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202394Inst : IEnumerable<long>
{
public static readonly long[] Value=A202394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202394.Bytes);
public long this[int i]=>Value[i];

public static A202394Inst Instance=new A202394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202395
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,13L,11L,3L,13L,40L,46L,24L,5L,34L,120L,172L,128L,50L,8L,89L,354L,603L,572L,319L,98L,13L,233L,1031L,2025L,2311L,1651L,733L,187L,21L,610L,2972L,6592L,8740L,7548L,4324L,1600L,348L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202395Inst : IEnumerable<long>
{
public static readonly long[] Value=A202395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202395.Bytes);
public long this[int i]=>Value[i];

public static A202395Inst Instance=new A202395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202396
{
public static readonly long[] Value={ 1L,2L,2L,5L,8L,3L,13L,27L,19L,5L,34L,86L,86L,42L,8L,89L,265L,338L,234L,85L,13L,233L,798L,1227L,1084L,567L,166L,21L,610L,2362L,4230L,4510L,3038L,1286L,314L,34L,1597L,6898L,14058L,17474L,14284L,7814L,2774L,582L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202396Inst : IEnumerable<long>
{
public static readonly long[] Value=A202396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202396.Bytes);
public long this[int i]=>Value[i];

public static A202396Inst Instance=new A202396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202397
{
public static readonly long[] Value={ 24L,3L,3L,51L,3L,24L,24L,51L,24L,24L,24L,24L,24L,3L,3L,51L,24L,24L,24L,24L,3L,51L,24L,24L,24L,51L,24L,42L,3L,24L,51L,51L,24L,24L,24L,24L,51L,24L,24L,24L,51L,51L,24L,24L,51L,24L,3L,24L,24L,24L,24L,24L,10L,24L,51L,24L,24L,24L,24L,24L,42L,51L,3L,51L,51L,51L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202397Inst : IEnumerable<long>
{
public static readonly long[] Value=A202397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202397.Bytes);
public long this[int i]=>Value[i];

public static A202397Inst Instance=new A202397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202398
{
public static readonly BigInteger[] Value={ 126L,2401L,127449L,15752961L,4005967518L,2318785835536L,3110996570522302L,9451749722490696481UL,BigInteger.Parse("64095230140132556496075"),BigInteger.Parse("982649737574821713976177041"),BigInteger.Parse("34173066616707050608156373933550"),BigInteger.Parse("2685436434473477364838752750506250000") };
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
public class A202398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202398Inst Instance=new A202398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202399
{
public static readonly long[] Value={ 126L,441L,1785L,7225L,27880L,107584L,422136L,1656369L,6459453L,25190361L,98462742L,384865924L,1503033070L,5869858225L,22931405805L,89584680249L,349930588752L,1366878986496L,5339482693488L,20857790423089L,81475946359561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202399Inst : IEnumerable<long>
{
public static readonly long[] Value=A202399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202399.Bytes);
public long this[int i]=>Value[i];

public static A202399Inst Instance=new A202399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202400
{
public static readonly long[] Value={ 441L,2401L,14161L,83521L,485809L,2825761L,16475481L,96059601L,559842921L,3262808641L,19017237409L,110841719041L,646031745121L,3765342321601L,21946029946281L,127910874833361L,745519173814809L,4345203949621921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202400Inst : IEnumerable<long>
{
public static readonly long[] Value=A202400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202400.Bytes);
public long this[int i]=>Value[i];

public static A202400Inst Instance=new A202400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202401
{
public static readonly long[] Value={ 1785L,14161L,127449L,1147041L,9967797L,86620249L,761992011L,6703188129L,58683373353L,513746331121L,4506684244009L,39533523929761L,346498326472137L,3036943796391729L,26627628912968223L,233468469969434001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202401Inst : IEnumerable<long>
{
public static readonly long[] Value=A202401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202401.Bytes);
public long this[int i]=>Value[i];

public static A202401Inst Instance=new A202401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202402
{
public static readonly long[] Value={ 7225L,83521L,1147041L,15752961L,204518601L,2655237841L,35242177441L,467758877041L,6151258109929L,80892053988001L,1067989132090609L,14100282166562881L,185843948311711089L,2449452622018343841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A202402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202402Inst : IEnumerable<long>
{
public static readonly long[] Value=A202402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A202402.Bytes);
public long this[int i]=>Value[i];

public static A202402Inst Instance=new A202402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202403
{
public static readonly BigInteger[] Value={ 27880L,485809L,9967797L,204518601L,4005967518L,78466093924L,1562067102398L,31096917284521L,615218671150193L,12171431974069369L,241399947765550678L,4787763256234789636L,BigInteger.Parse("94860433041088942266"),BigInteger.Parse("1879479263103655110921") };
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
public class A202403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202403Inst Instance=new A202403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202404
{
public static readonly BigInteger[] Value={ 107584L,2825761L,86620249L,2655237841L,78466093924L,2318785835536L,69236744423044L,2067343479866401L,61531154532577081L,1831375876811990161L,BigInteger.Parse("54564164587647312676"),BigInteger.Parse("1625689239901192934416"),BigInteger.Parse("48419665200235480053604") };
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
public class A202404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202404Inst Instance=new A202404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}