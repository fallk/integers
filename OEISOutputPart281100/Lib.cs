using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A093799
{
public static readonly long[] Value={ 1L,3L,6L,15L,21L,36L,55L,78L,105L,120L,153L,190L,210L,231L,276L,325L,378L,435L,465L,528L,595L,666L,741L,820L,903L,990L,1035L,1128L,1225L,1326L,1431L,1540L,1596L,1711L,1830L,1953L,2080L,2211L,2346L,2485L,2628L,2775L,2926L,3081L,3240L,3403L,3570L,3741L,3916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093799Inst : IEnumerable<long>
{
public static readonly long[] Value=A093799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093799.Bytes);
public long this[int i]=>Value[i];

public static A093799Inst Instance=new A093799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093800
{
public static readonly BigInteger[] Value={ 1L,3L,6L,36L,2016L,26335L,53091360L,1420353154080L,BigInteger.Parse("70356589837262316000") };
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
public class A093800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093800Inst Instance=new A093800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093801
{
public static readonly long[] Value={ 1L,12L,90L,594L,3726L,22842L,138510L,835434L,5025726L,30193722L,181280430L,1088036874L,6529284126L,39178893402L,235082926350L,1410526255914L,8463243628926L,50779720053882L,304679095164270L,1828076895508554L,10968468346620126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093801Inst : IEnumerable<long>
{
public static readonly long[] Value=A093801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093801.Bytes);
public long this[int i]=>Value[i];

public static A093801Inst Instance=new A093801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093802
{
public static readonly long[] Value={ 5L,15L,36L,74L,141L,250L,426L,696L,1106L,1711L,2593L,3852L,5635L,8118L,11548L,16231L,22577L,31092L,42447L,57464L,77213L,103009L,136529L,179830L,235514L,306751L,397506L,512607L,658030L,841020L,1070490L,1357195L,1714274L,2157539L,2706174L,3383187L,4216358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093802Inst : IEnumerable<long>
{
public static readonly long[] Value=A093802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093802.Bytes);
public long this[int i]=>Value[i];

public static A093802Inst Instance=new A093802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093803
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,3L,5L,1L,3L,1L,7L,5L,1L,1L,9L,1L,5L,7L,11L,1L,3L,5L,13L,9L,7L,1L,15L,1L,1L,11L,17L,7L,9L,1L,19L,13L,5L,1L,21L,1L,11L,15L,23L,1L,3L,7L,25L,17L,13L,1L,27L,11L,7L,19L,29L,1L,15L,1L,31L,21L,1L,13L,33L,1L,17L,23L,35L,1L,9L,1L,37L,25L,19L,11L,39L,1L,5L,27L,41L,1L,21L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093803Inst : IEnumerable<long>
{
public static readonly long[] Value=A093803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093803.Bytes);
public long this[int i]=>Value[i];

public static A093803Inst Instance=new A093803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093804
{
public static readonly long[] Value={ 2L,3L,11L,37L,41L,73L,26951L,110059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093804Inst : IEnumerable<long>
{
public static readonly long[] Value=A093804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093804.Bytes);
public long this[int i]=>Value[i];

public static A093804Inst Instance=new A093804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093805
{
public static readonly long[] Value={ 23L,25L,32L,52L,122L,133L,137L,155L,157L,173L,175L,203L,205L,212L,221L,223L,227L,229L,230L,232L,236L,238L,245L,247L,250L,254L,256L,263L,265L,272L,274L,278L,283L,287L,292L,302L,313L,317L,320L,322L,326L,328L,331L,335L,337L,353L,355L,359L,362L,371L,373L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093805Inst : IEnumerable<long>
{
public static readonly long[] Value=A093805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093805.Bytes);
public long this[int i]=>Value[i];

public static A093805Inst Instance=new A093805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093806
{
public static readonly long[] Value={ 23L,137L,157L,173L,223L,227L,229L,263L,283L,313L,317L,331L,337L,353L,359L,373L,379L,397L,557L,571L,577L,593L,733L,739L,751L,757L,773L,797L,823L,827L,937L,953L,977L,1033L,1123L,1213L,1217L,1231L,1237L,1259L,1277L,1279L,1297L,1303L,1307L,1321L,1327L,1367L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093806Inst : IEnumerable<long>
{
public static readonly long[] Value=A093806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093806.Bytes);
public long this[int i]=>Value[i];

public static A093806Inst Instance=new A093806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093807
{
public static readonly long[] Value={ 212L,232L,272L,292L,313L,353L,373L,515L,535L,575L,595L,737L,757L,797L,12121L,12521L,12721L,13331L,13531L,13931L,15151L,15551L,15751L,17171L,17371L,17771L,20102L,20302L,20702L,20902L,21112L,21512L,21712L,22322L,22522L,23332L,23732L,24142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093807Inst : IEnumerable<long>
{
public static readonly long[] Value=A093807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093807.Bytes);
public long this[int i]=>Value[i];

public static A093807Inst Instance=new A093807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093808
{
public static readonly long[] Value={ 313L,353L,373L,757L,797L,12721L,13331L,13931L,15551L,30103L,30703L,31513L,32323L,33533L,34543L,35353L,35753L,36563L,38183L,38783L,70507L,71317L,74747L,75557L,76367L,77377L,78787L,79997L,93739L,95959L,97579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093808Inst : IEnumerable<long>
{
public static readonly long[] Value=A093808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093808.Bytes);
public long this[int i]=>Value[i];

public static A093808Inst Instance=new A093808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093809
{
public static readonly long[] Value={ 0L,8L,29L,69L,154L,274L,463L,703L,1036L,1516L,2077L,2821L,3718L,4726L,5911L,7351L,9068L,10940L,13125L,15565L,18190L,21182L,24471L,28167L,32392L,36968L,41801L,47009L,52490L,58370L,65283L,72643L,80596L,88892L,98097L,107673L,117922L,128866L,140371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093809Inst : IEnumerable<long>
{
public static readonly long[] Value=A093809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093809.Bytes);
public long this[int i]=>Value[i];

public static A093809Inst Instance=new A093809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093810
{
public static readonly long[] Value={ 1L,5L,13L,29L,61L,5L,11L,509L,1021L,5L,4093L,19L,16381L,5L,13L,53L,11L,5L,1048573L,773L,4194301L,5L,16777213L,479L,37L,5L,11L,536870909L,23L,5L,9241L,29L,5113L,5L,242819L,47189L,11L,5L,13L,23L,47L,5L,5927L,2087L,227L,5L,11L,19L,59L,5L,13L,2203L,36217L,5L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093810Inst : IEnumerable<long>
{
public static readonly long[] Value=A093810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093810.Bytes);
public long this[int i]=>Value[i];

public static A093810Inst Instance=new A093810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093811
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,12L,8L,15L,13L,8L,2L,18L,4L,14L,14L,21L,8L,29L,10L,12L,13L,8L,7L,34L,16L,18L,27L,34L,19L,22L,4L,27L,14L,22L,28L,53L,22L,36L,34L,20L,5L,33L,13L,28L,43L,33L,29L,72L,44L,18L,16L,32L,16L,63L,32L,72L,48L,61L,46L,28L,7L,18L,40L,51L,39L,62L,43L,74L,64L,34L,8L,83L,22L,52L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093811Inst : IEnumerable<long>
{
public static readonly long[] Value=A093811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093811.Bytes);
public long this[int i]=>Value[i];

public static A093811Inst Instance=new A093811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093844
{
public static readonly BigInteger[] Value={ 1L,3L,17L,7L,1249L,15551L,235297L,419903L,86093441L,1999999999L,51874849201L,1486016741375L,46596170244961L,1587429546508287L,58385852050781249L,8191L,BigInteger.Parse("97322383751333736961"),BigInteger.Parse("4371823119477393063935"),BigInteger.Parse("208254700595822483065681") };
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
public class A093844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093844Inst Instance=new A093844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093845
{
public static readonly BigInteger[] Value={ 1L,4L,27L,16L,3125L,46656L,823543L,1679616L,387420489L,10000000000L,285311670611L,8916100448256L,302875106592253L,11112006825558016L,437893890380859375L,65536L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("39346408075296537575424") };
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
public class A093845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093845Inst Instance=new A093845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093846
{
public static readonly long[] Value={ 9L,54L,99L,399L,699L,999L,3249L,5499L,7749L,9999L,27999L,45999L,63999L,81999L,99999L,249999L,399999L,549999L,699999L,849999L,999999L,2285713L,3571427L,4857141L,6142855L,7428569L,8714283L,9999997L,21249999L,32499999L,43749999L,54999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093846Inst : IEnumerable<long>
{
public static readonly long[] Value=A093846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093846.Bytes);
public long this[int i]=>Value[i];

public static A093846Inst Instance=new A093846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093847
{
public static readonly long[] Value={ 9L,54L,399L,3249L,27999L,249999L,2285713L,21249999L,199999999L,1899999999L,18181818180L,174999999999L,1692307692306L,16428571428570L,159999999999999L,1562499999999999L,15294117647058822L,149999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093847Inst : IEnumerable<long>
{
public static readonly long[] Value=A093847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093847.Bytes);
public long this[int i]=>Value[i];

public static A093847Inst Instance=new A093847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093848
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,11L,12L,14L,16L,18L,20L,21L,23L,25L,27L,29L,31L,33L,34L,36L,38L,40L,42L,44L,46L,48L,50L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093848Inst : IEnumerable<long>
{
public static readonly long[] Value=A093848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093848.Bytes);
public long this[int i]=>Value[i];

public static A093848Inst Instance=new A093848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093849
{
public static readonly long[] Value={ 9L,153L,2097L,26496L,319995L,3749994L,42999985L,484999992L,5399999991L,59499999990L,649999999935L,7049999999988L,75999999999924L,814999999999941L,8699999999999985L,92499999999999984L,979999999999999902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093849Inst : IEnumerable<long>
{
public static readonly long[] Value=A093849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093849.Bytes);
public long this[int i]=>Value[i];

public static A093849Inst Instance=new A093849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093850
{
public static readonly long[] Value={ 4L,39L,69L,324L,549L,774L,2799L,4599L,6399L,8199L,24999L,39999L,54999L,69999L,84999L,228570L,357141L,485712L,614283L,742854L,871425L,2124999L,3249999L,4374999L,5499999L,6624999L,7749999L,8874999L,19999999L,29999999L,39999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093850Inst : IEnumerable<long>
{
public static readonly long[] Value=A093850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093850.Bytes);
public long this[int i]=>Value[i];

public static A093850Inst Instance=new A093850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093851
{
public static readonly ulong[] Value={ 4L,39L,324L,2799L,24999L,228570L,2124999L,19999999L,189999999L,1818181817L,17499999999L,169230769229L,1642857142856L,15999999999999L,156249999999999L,1529411764705881L,14999999999999999L,147368421052631577L,1449999999999999999L,14285714285714285713UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093851Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A093851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093851.Bytes);
public ulong this[int i]=>Value[i];

public static A093851Inst Instance=new A093851Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093852
{
public static readonly BigInteger[] Value={ 4L,69L,774L,8199L,84999L,871425L,8874999L,89999999L,909999999L,9181818179L,92499999999L,930769230759L,9357142857140L,93999999999999L,943749999999999L,9470588235294111L,94999999999999999L,952631578947368403L,9549999999999999999UL,BigInteger.Parse("95714285714285714279") };
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
public class A093852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093852Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093852.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093852Inst Instance=new A093852Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093853
{
public static readonly BigInteger[] Value={ 1L,1L,0L,0L,5L,918L,1045305L,34359063140L,72057592159917465L,BigInteger.Parse("19342813113675737866540892"),BigInteger.Parse("1329227995784915042800342940013202739") };
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
public class A093853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093853Inst Instance=new A093853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093854
{
public static readonly long[] Value={ 0L,0L,0L,4L,80L,480L,840L,0L,0L,0L,1L,200L,3840L,27720L,77280L,45360L,0L,0L,0L,0L,252L,14664L,263844L,2192400L,8709120L,13819680L,3991680L,0L,0L,0L,0L,210L,38340L,1518790L,26267360L,240765840L,1205492400L,3068881200L,3180038400L,605404800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093854Inst : IEnumerable<long>
{
public static readonly long[] Value=A093854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093854.Bytes);
public long this[int i]=>Value[i];

public static A093854Inst Instance=new A093854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093855
{
public static readonly long[] Value={ 3L,12L,7L,44L,80L,0L,12L,111L,440L,840L,630L,0L,18L,234L,1532L,6048L,13692L,13440L,0L,0L,25L,441L,4270L,26740L,106792L,248696L,277200L,75600L,0L,0L,33L,768L,10360L,92940L,557322L,2169416L,5158512L,6617520L,3326400L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093855Inst : IEnumerable<long>
{
public static readonly long[] Value=A093855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093855.Bytes);
public long this[int i]=>Value[i];

public static A093855Inst Instance=new A093855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093856
{
public static readonly BigInteger[] Value={ 1L,2L,3L,10L,57L,446L,4403L,52390L,729057L,11612522L,208296339L,4154314258L,91186617337L,2184324501830L,56701250430243L,1585450687544974L,47506819375918977L,1518632769341862290L,BigInteger.Parse("51586007338247398883") };
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
public class A093856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093856Inst Instance=new A093856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093857
{
public static readonly BigInteger[] Value={ 2L,0L,2L,22L,278L,4436L,88852L,2184456L,64459628L,2239805712L,90214284410L,4157479612606L,216841733604410L,12682329307742732L,825184186612617418L,BigInteger.Parse("59320610243634707134"),BigInteger.Parse("4683176986971809187614"),BigInteger.Parse("403867178883936416642928"),BigInteger.Parse("37864927166010206186524472"),BigInteger.Parse("3843160755696708555996620560") };
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
public class A093857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093857Inst Instance=new A093857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093858
{
public static readonly long[] Value={ 1L,2L,3L,8L,27L,116L,607L,3758L,26913L,219062L,1998471L,20203772L,224239963L,2711083328L,35468323227L,499267608506L,7524482450817L,120890986821578L,2062671258417643L,37248973638339152L,709793170386861531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093858Inst : IEnumerable<long>
{
public static readonly long[] Value=A093858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093858.Bytes);
public long this[int i]=>Value[i];

public static A093858Inst Instance=new A093858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093859
{
public static readonly long[] Value={ 2L,4L,9L,11L,18L,21L,23L,29L,36L,41L,43L,45L,47L,58L,61L,67L,72L,75L,82L,85L,89L,90L,94L,115L,116L,122L,128L,130L,143L,144L,149L,150L,162L,163L,165L,167L,168L,170L,175L,178L,180L,185L,202L,206L,207L,209L,211L,213L,214L,218L,219L,223L,227L,229L,230L,233L,237L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093859Inst : IEnumerable<long>
{
public static readonly long[] Value=A093859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093859.Bytes);
public long this[int i]=>Value[i];

public static A093859Inst Instance=new A093859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093924
{
public static readonly long[] Value={ 3L,2L,5L,11L,23L,47L,71L,107L,149L,191L,239L,307L,379L,461L,557L,643L,751L,877L,997L,1109L,1279L,1433L,1571L,1733L,1913L,2099L,2297L,2531L,2719L,2963L,3229L,3499L,3733L,4013L,4273L,4591L,4919L,5209L,5521L,5849L,6211L,6577L,6959L,7333L,7717L,8147L,8597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093924Inst : IEnumerable<long>
{
public static readonly long[] Value=A093924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093924.Bytes);
public long this[int i]=>Value[i];

public static A093924Inst Instance=new A093924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093925
{
public static readonly long[] Value={ 3L,15L,55L,78L,231L,528L,595L,1176L,1891L,2346L,3081L,4560L,5671L,7260L,9591L,11628L,16471L,29890L,21945L,24976L,37675L,34980L,38503L,50086L,54285L,63190L,65341L,73920L,85905L,93096L,104653L,119316L,130305L,145530L,155403L,182710L,188191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093925Inst : IEnumerable<long>
{
public static readonly long[] Value=A093925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093925.Bytes);
public long this[int i]=>Value[i];

public static A093925Inst Instance=new A093925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093926
{
public static readonly long[] Value={ 2L,7L,503L,58537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093926Inst : IEnumerable<long>
{
public static readonly long[] Value=A093926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093926.Bytes);
public long this[int i]=>Value[i];

public static A093926Inst Instance=new A093926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093927
{
public static readonly long[] Value={ 2L,2L,3L,4L,47L,28L,71L,80L,57L,52L,77L,62L,75L,154L,243L,236L,183L,448L,341L,380L,603L,508L,411L,1060L,837L,686L,765L,658L,569L,506L,479L,588L,1315L,2826L,3709L,2964L,2585L,2536L,2139L,1876L,1643L,1656L,1405L,1824L,1739L,1624L,1557L,1462L,1775L,1936L,1809L,1762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093927Inst : IEnumerable<long>
{
public static readonly long[] Value=A093927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093927.Bytes);
public long this[int i]=>Value[i];

public static A093927Inst Instance=new A093927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093928
{
public static readonly long[] Value={ 2L,3L,8L,5L,6L,7L,6L,35L,104L,71L,72L,221L,228L,185L,212L,193L,234L,329L,278L,295L,278L,221L,288L,3619L,2792L,2457L,1870L,3633L,3002L,2583L,2182L,2097L,1808L,1473L,1540L,51699L,39382L,30063L,23206L,27885L,21928L,17511L,14150L,11459L,9818L,8183L,6812L,7665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093928Inst : IEnumerable<long>
{
public static readonly long[] Value=A093928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093928.Bytes);
public long this[int i]=>Value[i];

public static A093928Inst Instance=new A093928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093929
{
public static readonly long[] Value={ 3L,5L,7L,11L,19L,23L,37L,17L,13L,29L,43L,53L,109L,71L,31L,47L,73L,227L,163L,59L,79L,113L,67L,41L,61L,89L,139L,131L,241L,149L,103L,167L,127L,101L,157L,83L,97L,137L,181L,179L,151L,191L,199L,173L,193L,233L,229L,269L,271L,251L,211L,317L,277L,107L,313L,293L,349L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093929Inst : IEnumerable<long>
{
public static readonly long[] Value=A093929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093929.Bytes);
public long this[int i]=>Value[i];

public static A093929Inst Instance=new A093929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093930
{
public static readonly long[] Value={ 17L,37L,79L,211L,439L,853L,631L,223L,379L,1249L,2281L,5779L,7741L,2203L,1459L,3433L,16573L,37003L,9619L,4663L,8929L,7573L,2749L,2503L,5431L,12373L,18211L,31573L,35911L,15349L,17203L,21211L,12829L,15859L,13033L,8053L,13291L,24799L,32401L,27031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093930Inst : IEnumerable<long>
{
public static readonly long[] Value=A093930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093930.Bytes);
public long this[int i]=>Value[i];

public static A093930Inst Instance=new A093930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093931
{
public static readonly long[] Value={ 3L,7L,11L,5L,19L,13L,17L,23L,29L,43L,37L,31L,41L,47L,53L,59L,73L,67L,61L,71L,97L,83L,79L,89L,103L,107L,101L,127L,113L,109L,131L,137L,151L,157L,163L,149L,139L,173L,167L,181L,191L,197L,193L,179L,241L,227L,223L,229L,233L,199L,257L,211L,269L,263L,277L,239L,313L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093931Inst : IEnumerable<long>
{
public static readonly long[] Value=A093931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093931.Bytes);
public long this[int i]=>Value[i];

public static A093931Inst Instance=new A093931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093932
{
public static readonly long[] Value={ 3L,7L,19L,31L,47L,17L,41L,13L,61L,97L,37L,103L,151L,73L,157L,67L,131L,29L,101L,367L,167L,83L,919L,137L,233L,383L,227L,389L,109L,283L,163L,349L,541L,79L,419L,769L,409L,557L,709L,1567L,1327L,1163L,71L,673L,937L,307L,491L,773L,293L,587L,787L,277L,797L,479L,263L,43L,379L,607L,839L,1193L,353L,719L,347L,599L,983L,593L,197L,13999L,2711L,89L,509L,8887L,3559L,3121L,1493L,443L,139L,601L,1069L,1543L,743L,257L,2389L,563L,59L,569L,53L,401L,929L,2887L,547L,911L,359L,1289L,3733L,503L,887L,499L,107L,701L,1301L,1907L,1499L,881L,1297L,877L,241L,883L,1531L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093932Inst : IEnumerable<long>
{
public static readonly long[] Value=A093932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093932.Bytes);
public long this[int i]=>Value[i];

public static A093932Inst Instance=new A093932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093933
{
public static readonly long[] Value={ 3L,5L,11L,31L,17L,61L,113L,79L,41L,179L,353L,43L,191L,109L,23L,211L,317L,199L,443L,577L,151L,881L,1039L,541L,7L,977L,1381L,557L,1627L,101L,1231L,1993L,421L,2339L,1783L,293L,3011L,499L,173L,3847L,733L,1091L,367L,2659L,2273L,1879L,1481L,3169L,47L,1409L,1867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093933Inst : IEnumerable<long>
{
public static readonly long[] Value=A093933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093933.Bytes);
public long this[int i]=>Value[i];

public static A093933Inst Instance=new A093933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093934
{
public static readonly BigInteger[] Value={ 1L,2L,4L,12L,48L,296L,3040L,54256L,1716608L,97213472L,9937755904L,1849103423168L,631027551238656L,397616229914793600L,BigInteger.Parse("465313769910614218240"),BigInteger.Parse("1016485858155549165160192"),BigInteger.Parse("4163516302794478683289989120"),BigInteger.Parse("32101177200132015985353543496192"),BigInteger.Parse("467507173926886632279989196725442560") };
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
public class A093934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093934.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093934Inst Instance=new A093934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093935
{
public static readonly long[] Value={ 1L,2L,8L,41L,249L,1754L,14084L,127057L,1272625L,14015014L,168323364L,2189619553L,30670104577L,460235322854L,7366138539416L,125257398648401L,2255126454472401L,42855262052316218L,857238357862313360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093935Inst : IEnumerable<long>
{
public static readonly long[] Value=A093935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093935.Bytes);
public long this[int i]=>Value[i];

public static A093935Inst Instance=new A093935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093936
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,5L,16L,11L,15L,7L,28L,47L,36L,52L,11L,79L,156L,166L,135L,203L,15L,134L,408L,588L,667L,566L,877L,22L,328L,1057L,2358L,2517L,2978L,2610L,4140L,30L,536L,3036L,6181L,10726L,11913L,14548L,13082L,21147L,42L,1197L,6826L,21336L,40130L,53690L,61421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093936Inst : IEnumerable<long>
{
public static readonly long[] Value=A093936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093936.Bytes);
public long this[int i]=>Value[i];

public static A093936Inst Instance=new A093936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093937
{
public static readonly BigInteger[] Value={ 8L,5383L,273976272L,1043065776718923L,BigInteger.Parse("296755610108278480324496"),BigInteger.Parse("6311874633104458029014418062576427"),BigInteger.Parse("10042431607269542604521005988830015956735912072"),BigInteger.Parse("1195803046003221669232199949110252888466561872833354476549925") };
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
public class A093937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093937Inst Instance=new A093937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093938
{
public static readonly BigInteger[] Value={ 2L,277L,2777L,2777777777L,2777777777777777L,2777777777777777777L,BigInteger.Parse("2777777777777777777777777777777777777"),BigInteger.Parse("2777777777777777777777777777777777777777777777777777777777777777") };
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
public class A093938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093938Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093938.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093938.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093938Inst Instance=new A093938Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093939
{
public static readonly long[] Value={ 3L,37L,377777777777L,377777777777777777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093939Inst : IEnumerable<long>
{
public static readonly long[] Value=A093939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093939.Bytes);
public long this[int i]=>Value[i];

public static A093939Inst Instance=new A093939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094068
{
public static readonly long[] Value={ 3L,29L,107L,239L,281L,857L,1061L,1151L,1619L,1667L,1721L,2267L,2339L,2801L,2999L,3167L,3257L,3467L,3557L,4271L,4337L,4547L,4799L,4931L,5279L,5501L,5849L,5867L,6359L,6659L,6689L,7349L,8009L,8219L,8231L,8387L,9857L,10007L,10859L,13001L,13691L,15269L,15971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094068Inst : IEnumerable<long>
{
public static readonly long[] Value=A094068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094068.Bytes);
public long this[int i]=>Value[i];

public static A094068Inst Instance=new A094068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094069
{
public static readonly long[] Value={ 7L,13L,37L,79L,349L,397L,457L,613L,769L,1213L,1429L,1783L,2347L,2377L,2473L,3907L,4129L,4513L,4783L,5437L,5647L,7477L,7603L,7879L,8803L,9829L,10429L,10453L,10627L,11443L,11863L,11923L,12109L,13033L,13099L,13327L,14173L,14779L,15679L,16057L,16069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094069Inst : IEnumerable<long>
{
public static readonly long[] Value=A094069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094069.Bytes);
public long this[int i]=>Value[i];

public static A094069Inst Instance=new A094069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094070
{
public static readonly BigInteger[] Value={ 1L,4L,20L,150L,1352L,15428L,203464L,3162960L,55405140L,1101298600L,24222234720L,590544046744L,15715973012248L,456341011254560L,14312979247985120L,484253161428902192L,17550722413456774848UL,BigInteger.Parse("680244627812139042016") };
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
public class A094070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094070Inst Instance=new A094070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094071
{
public static readonly BigInteger[] Value={ 1L,2L,10L,75L,572L,6293L,92962L,1395180L,25482135L,582310475L,13697614020L,364311810217L,11551145067139L,380339218683310L,13636394439014770L,563142483841155427L,BigInteger.Parse("24264229405883569164"),BigInteger.Parse("1114389674994185476663") };
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
public class A094071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094071Inst Instance=new A094071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094072
{
public static readonly BigInteger[] Value={ 1L,6L,50L,615L,10192L,214571L,5544394L,171367020L,6208928376L,259542887975L,12356823485580L,662921411131909L,39714830070598204L,2636484537372437498L,BigInteger.Parse("192653800829700013970"),BigInteger.Parse("15405383160836582657251") };
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
public class A094072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094072Inst Instance=new A094072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094073
{
public static readonly BigInteger[] Value={ 4L,240L,49938L,24608160L,23465221750L,38341895571708L,98780305524248572L,BigInteger.Parse("377796303580335320432"),BigInteger.Parse("2048907276496726375662702"),BigInteger.Parse("15198414983297581845761672560"),BigInteger.Parse("149768511689247547252666676150490") };
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
public class A094073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094073Inst Instance=new A094073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094074
{
public static readonly BigInteger[] Value={ 1L,5L,129L,7485L,755265L,116338005L,25263540225L,7328358482445L,2730934406225025L,1269262202389906725L,BigInteger.Parse("718835160819268317825"),BigInteger.Parse("486853691847850902700125"),BigInteger.Parse("388278919916351519293663425") };
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
public class A094074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094074Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094074.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094074.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094074Inst Instance=new A094074Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094075
{
public static readonly long[] Value={ 105L,13440L,229635L,1720320L,8203125L,29393280L,86472015L,220200960L,502211745L,1050000000L,2046152955L,3762339840L,6588594285L,11068417920L,17940234375L,28185722880L,43085560665L,64283103360L,93856532595L,134400000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094075Inst : IEnumerable<long>
{
public static readonly long[] Value=A094075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094075.Bytes);
public long this[int i]=>Value[i];

public static A094075Inst Instance=new A094075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094076
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,2L,3L,1L,4L,2L,1L,2L,5L,3L,1L,8L,2L,1L,4L,2L,7L,3L,2L,1L,2L,1L,2L,7L,2L,3L,1L,10L,1L,4L,4L,2L,5L,3L,1L,4L,1L,2L,1L,6L,4L,2L,1L,2L,3L,1L,4L,5L,9L,3L,1L,20L,2L,1L,6L,7L,2L,1L,2L,5L,4L,4L,1L,2L,27L,3L,4L,4L,2L,15L,3L,2L,3L,10L,1L,8L,1L,4L,2L,7L,3L,2L,1L,2L,5L,3L,2L,3L,2L,7L,5L,1L,6L,4L,4L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094076Inst : IEnumerable<long>
{
public static readonly long[] Value=A094076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094076.Bytes);
public long this[int i]=>Value[i];

public static A094076Inst Instance=new A094076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094077
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,10L,5L,13L,7L,17L,8L,20L,9L,23L,11L,27L,12L,30L,14L,34L,15L,37L,16L,40L,18L,44L,19L,47L,21L,51L,22L,54L,24L,58L,25L,61L,26L,64L,28L,68L,29L,71L,31L,75L,32L,78L,33L,81L,35L,85L,36L,88L,38L,92L,39L,95L,41L,99L,42L,102L,43L,105L,45L,109L,46L,112L,48L,116L,49L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094077Inst : IEnumerable<long>
{
public static readonly long[] Value=A094077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094077.Bytes);
public long this[int i]=>Value[i];

public static A094077Inst Instance=new A094077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094078
{
public static readonly long[] Value={ 4L,6L,6L,9L,2L,0L,1L,9L,3L,1L,8L,5L,9L,9L,0L,7L,7L,3L,1L,5L,5L,8L,8L,5L,2L,6L,2L,6L,0L,8L,2L,3L,9L,7L,8L,7L,4L,5L,5L,7L,3L,1L,5L,7L,1L,2L,5L,4L,9L,3L,2L,2L,9L,8L,0L,1L,2L,6L,8L,7L,1L,9L,7L,4L,3L,6L,0L,8L,5L,1L,7L,6L,6L,1L,2L,1L,9L,2L,2L,6L,2L,5L,4L,2L,5L,9L,0L,4L,6L,9L,9L,2L,7L,3L,1L,4L,8L,8L,0L,9L,1L,0L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094078Inst : IEnumerable<long>
{
public static readonly long[] Value=A094078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094078.Bytes);
public long this[int i]=>Value[i];

public static A094078Inst Instance=new A094078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094079
{
public static readonly long[] Value={ 5L,13L,25L,37L,41L,85L,65L,61L,85L,125L,101L,149L,113L,205L,173L,145L,145L,277L,265L,181L,197L,269L,377L,221L,293L,257L,317L,505L,265L,457L,433L,409L,365L,313L,569L,601L,493L,425L,365L,493L,445L,401L,557L,485L,421L,709L,641L,881L,533L,485L,481L,877L,785L,809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094079Inst : IEnumerable<long>
{
public static readonly long[] Value=A094079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094079.Bytes);
public long this[int i]=>Value[i];

public static A094079Inst Instance=new A094079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094080
{
public static readonly long[] Value={ 7L,17L,31L,47L,49L,113L,79L,71L,97L,161L,119L,191L,127L,271L,217L,167L,161L,367L,343L,199L,223L,329L,497L,241L,353L,287L,383L,673L,287L,593L,553L,511L,433L,337L,751L,791L,623L,503L,391L,607L,521L,439L,697L,569L,449L,919L,809L,1169L,617L,527L,511L,1153L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094080Inst : IEnumerable<long>
{
public static readonly long[] Value=A094080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094080.Bytes);
public long this[int i]=>Value[i];

public static A094080Inst Instance=new A094080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094081
{
public static readonly long[] Value={ 5L,185L,1313L,4925L,13325L,29585L,57545L,101813L,167765L,261545L,390065L,561005L,782813L,1064705L,1416665L,1849445L,2374565L,3004313L,3751745L,4630685L,5655725L,6842225L,8206313L,9764885L,11535605L,13536905L,15787985L,18308813L,21120125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094081Inst : IEnumerable<long>
{
public static readonly long[] Value=A094081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094081.Bytes);
public long this[int i]=>Value[i];

public static A094081Inst Instance=new A094081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094082
{
public static readonly long[] Value={ 1L,8L,7L,9L,8L,5L,3L,8L,6L,2L,1L,7L,5L,2L,5L,8L,5L,3L,3L,4L,8L,6L,3L,0L,6L,1L,4L,5L,0L,7L,0L,9L,6L,0L,0L,3L,8L,8L,1L,9L,8L,7L,3L,4L,0L,0L,4L,8L,9L,2L,8L,9L,9L,0L,4L,8L,2L,9L,6L,1L,7L,6L,6L,9L,1L,2L,2L,2L,9L,6L,3L,8L,6L,6L,6L,1L,2L,1L,4L,2L,1L,1L,3L,6L,1L,7L,6L,5L,0L,1L,9L,7L,3L,8L,9L,1L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094082Inst : IEnumerable<long>
{
public static readonly long[] Value=A094082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094082.Bytes);
public long this[int i]=>Value[i];

public static A094082Inst Instance=new A094082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094083
{
public static readonly long[] Value={ 1L,1L,1L,4L,9L,64L,25L,256L,1225L,16384L,3969L,65536L,53361L,1048576L,184041L,4194304L,41409225L,1073741824L,147744025L,4294967296L,2133423721L,68719476736L,7775536041L,274877906944L,457028729521L,17592186044416L,1690195005625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094083Inst : IEnumerable<long>
{
public static readonly long[] Value=A094083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094083.Bytes);
public long this[int i]=>Value[i];

public static A094083Inst Instance=new A094083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094132
{
public static readonly long[] Value={ 9L,7L,9L,5L,3L,6L,5L,7L,8L,7L,5L,7L,8L,5L,2L,5L,7L,2L,6L,7L,0L,2L,5L,3L,8L,3L,8L,3L,8L,4L,4L,6L,4L,9L,7L,6L,9L,5L,4L,5L,2L,0L,4L,7L,2L,9L,4L,4L,2L,4L,5L,6L,8L,9L,1L,0L,8L,4L,4L,6L,3L,1L,5L,9L,1L,7L,8L,6L,0L,9L,6L,6L,4L,1L,0L,1L,7L,5L,5L,4L,3L,6L,6L,8L,9L,5L,1L,0L,3L,8L,2L,7L,6L,0L,5L,5L,7L,9L,7L,3L,2L,4L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094132Inst : IEnumerable<long>
{
public static readonly long[] Value=A094132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094132.Bytes);
public long this[int i]=>Value[i];

public static A094132Inst Instance=new A094132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094133
{
public static readonly BigInteger[] Value={ 3L,17L,593L,32993L,2097593L,8589935681L,59604644783353249L,BigInteger.Parse("523347633027360537213687137"),BigInteger.Parse("43143988327398957279342419750374600193"),BigInteger.Parse("4318114567396436564035293097707729426477458833"),BigInteger.Parse("5052785737795758503064406447721934417290878968063369478337") };
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
public class A094133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094133Inst Instance=new A094133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094134
{
public static readonly long[] Value={ 9L,7L,1L,4L,6L,8L,9L,4L,4L,5L,5L,0L,7L,8L,9L,0L,1L,4L,3L,5L,2L,3L,9L,7L,7L,8L,8L,1L,4L,8L,5L,2L,7L,7L,7L,7L,4L,7L,5L,7L,3L,3L,5L,3L,5L,0L,6L,8L,7L,5L,0L,9L,9L,2L,8L,4L,8L,6L,6L,8L,0L,3L,4L,3L,4L,8L,5L,9L,2L,4L,7L,4L,5L,6L,2L,2L,5L,2L,9L,5L,9L,3L,5L,4L,0L,5L,4L,7L,8L,4L,8L,1L,5L,6L,4L,1L,8L,1L,7L,7L,8L,4L,9L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094134Inst : IEnumerable<long>
{
public static readonly long[] Value=A094134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094134.Bytes);
public long this[int i]=>Value[i];

public static A094134Inst Instance=new A094134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094135
{
public static readonly long[] Value={ 9L,8L,2L,0L,7L,1L,4L,2L,8L,2L,6L,5L,9L,9L,1L,4L,8L,8L,3L,3L,6L,9L,0L,6L,9L,5L,4L,7L,7L,4L,6L,1L,4L,8L,0L,5L,6L,6L,2L,5L,1L,6L,3L,8L,0L,9L,4L,0L,1L,7L,0L,4L,6L,5L,4L,0L,1L,6L,3L,6L,7L,3L,2L,7L,7L,3L,1L,9L,8L,0L,7L,0L,0L,9L,9L,1L,2L,7L,6L,2L,9L,6L,5L,3L,6L,5L,2L,3L,6L,8L,6L,6L,1L,6L,3L,7L,1L,2L,2L,9L,7L,0L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094135Inst : IEnumerable<long>
{
public static readonly long[] Value=A094135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094135.Bytes);
public long this[int i]=>Value[i];

public static A094135Inst Instance=new A094135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094136
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,3L,7L,1L,1L,9L,9L,3L,1L,5L,11L,3L,1L,5L,13L,1L,13L,3L,7L,1L,5L,15L,3L,7L,1L,17L,5L,17L,17L,1L,7L,9L,5L,3L,1L,7L,19L,19L,5L,3L,1L,7L,21L,9L,21L,21L,1L,11L,7L,23L,5L,9L,3L,1L,23L,23L,7L,5L,3L,1L,25L,7L,11L,25L,25L,5L,13L,9L,1L,7L,11L,5L,3L,9L,1L,27L,29L,7L,11L,29L,3L,1L,29L,29L,7L,29L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094136Inst : IEnumerable<long>
{
public static readonly long[] Value=A094136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094136.Bytes);
public long this[int i]=>Value[i];

public static A094136Inst Instance=new A094136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094137
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,5L,1L,5L,6L,2L,1L,7L,7L,8L,2L,8L,8L,9L,3L,9L,1L,10L,11L,10L,11L,1L,11L,12L,11L,4L,12L,3L,2L,12L,13L,14L,13L,13L,13L,14L,2L,1L,14L,14L,14L,15L,4L,16L,2L,1L,15L,17L,16L,5L,16L,17L,16L,16L,2L,1L,17L,17L,17L,17L,4L,18L,19L,3L,2L,18L,20L,19L,18L,19L,20L,19L,19L,20L,19L,1L,7L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094137Inst : IEnumerable<long>
{
public static readonly long[] Value=A094137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094137.Bytes);
public long this[int i]=>Value[i];

public static A094137Inst Instance=new A094137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094138
{
public static readonly long[] Value={ 2L,3L,4L,6L,5L,8L,8L,6L,7L,11L,10L,10L,8L,13L,13L,11L,9L,14L,16L,10L,14L,13L,18L,11L,16L,16L,14L,19L,12L,21L,17L,20L,19L,13L,20L,23L,18L,16L,14L,21L,21L,20L,19L,17L,15L,22L,25L,25L,23L,22L,16L,28L,23L,28L,21L,26L,19L,17L,25L,24L,24L,22L,20L,18L,29L,25L,30L,28L,27L,23L,33L,28L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094138Inst : IEnumerable<long>
{
public static readonly long[] Value=A094138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094138.Bytes);
public long this[int i]=>Value[i];

public static A094138Inst Instance=new A094138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094139
{
public static readonly long[] Value={ 9L,8L,4L,0L,4L,7L,5L,1L,2L,1L,1L,3L,1L,5L,4L,1L,1L,7L,0L,5L,6L,7L,5L,3L,3L,2L,1L,2L,9L,7L,8L,2L,7L,8L,8L,4L,0L,4L,3L,5L,8L,1L,6L,8L,2L,2L,6L,3L,4L,4L,5L,2L,7L,2L,8L,9L,8L,0L,2L,6L,2L,3L,0L,1L,4L,9L,0L,4L,1L,7L,9L,4L,5L,1L,6L,3L,5L,6L,8L,3L,2L,0L,6L,1L,6L,8L,3L,4L,4L,0L,7L,8L,0L,2L,4L,3L,4L,8L,8L,9L,4L,1L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094139Inst : IEnumerable<long>
{
public static readonly long[] Value=A094139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094139.Bytes);
public long this[int i]=>Value[i];

public static A094139Inst Instance=new A094139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094140
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,14L,7L,5L,6L,18L,9L,21L,7L,33L,22L,11L,8L,45L,39L,9L,13L,30L,60L,10L,30L,15L,33L,84L,11L,68L,60L,51L,34L,12L,91L,95L,65L,39L,13L,57L,38L,19L,70L,42L,14L,105L,84L,144L,42L,21L,15L,138L,112L,115L,80L,92L,48L,16L,46L,23L,119L,85L,51L,17L,100L,126L,209L,75L,50L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094140Inst : IEnumerable<long>
{
public static readonly long[] Value=A094140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094140.Bytes);
public long this[int i]=>Value[i];

public static A094140Inst Instance=new A094140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094141
{
public static readonly long[] Value={ 9L,8L,5L,6L,3L,1L,2L,4L,1L,6L,6L,7L,3L,8L,3L,9L,4L,5L,5L,2L,7L,2L,4L,8L,3L,8L,8L,7L,3L,1L,3L,2L,3L,9L,7L,6L,4L,0L,0L,2L,8L,4L,1L,6L,6L,0L,9L,5L,5L,2L,0L,7L,9L,9L,9L,5L,8L,3L,4L,1L,4L,6L,8L,9L,3L,0L,5L,6L,2L,4L,1L,9L,4L,7L,1L,5L,5L,6L,1L,1L,7L,6L,3L,3L,7L,9L,1L,7L,8L,0L,9L,1L,3L,3L,4L,4L,7L,2L,2L,3L,9L,3L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094141Inst : IEnumerable<long>
{
public static readonly long[] Value=A094141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094141.Bytes);
public long this[int i]=>Value[i];

public static A094141Inst Instance=new A094141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094142
{
public static readonly long[] Value={ 6L,15L,28L,42L,45L,99L,72L,66L,91L,143L,110L,170L,120L,238L,195L,156L,153L,322L,304L,190L,210L,299L,437L,231L,323L,272L,350L,589L,276L,525L,493L,460L,399L,325L,660L,696L,558L,464L,378L,550L,483L,420L,627L,527L,435L,814L,725L,1025L,575L,506L,496L,1015L,897L,924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094142Inst : IEnumerable<long>
{
public static readonly long[] Value=A094142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094142.Bytes);
public long this[int i]=>Value[i];

public static A094142Inst Instance=new A094142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094143
{
public static readonly long[] Value={ 6L,30L,84L,210L,180L,1386L,504L,330L,546L,2574L,990L,3570L,840L,7854L,4290L,1716L,1224L,14490L,11856L,1710L,2730L,8970L,26220L,2310L,9690L,4080L,11550L,49476L,3036L,35700L,29580L,23460L,13566L,3900L,60060L,66120L,36270L,18096L,4914L,31350L,18354L,7980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094143Inst : IEnumerable<long>
{
public static readonly long[] Value=A094143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094143.Bytes);
public long this[int i]=>Value[i];

public static A094143Inst Instance=new A094143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094144
{
public static readonly long[] Value={ 5L,7L,15L,17L,19L,51L,73L,89L,131L,153L,245L,333L,441L,463L,825L,1771L,2027L,9157L,10875L,20515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094144Inst : IEnumerable<long>
{
public static readonly long[] Value=A094144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094144.Bytes);
public long this[int i]=>Value[i];

public static A094144Inst Instance=new A094144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094145
{
public static readonly long[] Value={ 9L,8L,6L,9L,2L,8L,9L,1L,6L,0L,5L,4L,9L,8L,9L,9L,1L,9L,2L,7L,9L,3L,3L,8L,7L,1L,7L,9L,5L,3L,9L,2L,1L,3L,4L,9L,4L,0L,5L,2L,9L,5L,4L,1L,5L,9L,6L,7L,1L,3L,4L,7L,5L,4L,7L,0L,7L,2L,7L,2L,1L,3L,9L,9L,2L,9L,1L,5L,2L,5L,0L,4L,2L,9L,6L,3L,1L,8L,9L,6L,5L,3L,9L,9L,2L,6L,2L,6L,5L,5L,0L,9L,7L,7L,4L,1L,8L,4L,5L,0L,3L,0L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094145Inst : IEnumerable<long>
{
public static readonly long[] Value=A094145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094145.Bytes);
public long this[int i]=>Value[i];

public static A094145Inst Instance=new A094145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094146
{
public static readonly long[] Value={ 9L,8L,8L,0L,1L,1L,6L,1L,6L,3L,9L,2L,8L,1L,3L,2L,9L,1L,5L,8L,2L,4L,3L,9L,9L,0L,4L,6L,2L,3L,9L,0L,0L,7L,8L,9L,8L,6L,1L,9L,5L,1L,3L,4L,7L,1L,6L,9L,3L,5L,9L,9L,9L,2L,6L,2L,4L,5L,1L,7L,3L,9L,9L,6L,7L,9L,5L,6L,3L,1L,7L,4L,2L,8L,3L,2L,1L,3L,7L,7L,2L,8L,3L,9L,9L,7L,0L,5L,3L,3L,5L,7L,7L,9L,2L,7L,7L,0L,0L,9L,2L,1L,7L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094146Inst : IEnumerable<long>
{
public static readonly long[] Value=A094146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094146.Bytes);
public long this[int i]=>Value[i];

public static A094146Inst Instance=new A094146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094147
{
public static readonly long[] Value={ 2L,8L,18L,20L,32L,50L,72L,80L,90L,98L,128L,162L,180L,200L,242L,272L,288L,320L,338L,360L,392L,450L,468L,500L,512L,578L,648L,650L,720L,722L,800L,810L,882L,968L,980L,1058L,1088L,1152L,1250L,1280L,1332L,1352L,1440L,1458L,1568L,1620L,1682L,1800L,1872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094147Inst : IEnumerable<long>
{
public static readonly long[] Value=A094147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094147.Bytes);
public long this[int i]=>Value[i];

public static A094147Inst Instance=new A094147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094228
{
public static readonly long[] Value={ 1L,3L,5L,8L,11L,14L,17L,21L,24L,28L,32L,35L,39L,43L,47L,52L,56L,60L,64L,69L,73L,78L,82L,87L,91L,96L,101L,105L,110L,115L,120L,124L,129L,134L,139L,144L,149L,154L,159L,164L,169L,175L,180L,185L,190L,195L,200L,206L,211L,216L,222L,227L,232L,238L,243L,249L,254L,259L,265L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094228Inst : IEnumerable<long>
{
public static readonly long[] Value=A094228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094228.Bytes);
public long this[int i]=>Value[i];

public static A094228Inst Instance=new A094228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094229
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,27L,28L,30L,32L,36L,40L,42L,44L,45L,48L,50L,52L,54L,56L,60L,63L,64L,66L,68L,70L,72L,75L,76L,78L,80L,81L,84L,88L,90L,92L,96L,98L,99L,100L,102L,104L,105L,108L,110L,112L,114L,116L,117L,120L,124L,126L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094229Inst : IEnumerable<long>
{
public static readonly long[] Value=A094229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094229.Bytes);
public long this[int i]=>Value[i];

public static A094229Inst Instance=new A094229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094230
{
public static readonly long[] Value={ 1429L,1447L,1489L,2083L,2617L,2953L,3529L,4153L,5689L,8443L,10267L,10627L,12409L,13147L,15667L,15787L,20743L,22027L,22153L,24763L,24967L,26107L,27733L,28513L,33613L,34843L,35569L,37963L,39313L,43987L,44203L,46807L,47977L,51577L,54163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094230Inst : IEnumerable<long>
{
public static readonly long[] Value=A094230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094230.Bytes);
public long this[int i]=>Value[i];

public static A094230Inst Instance=new A094230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094231
{
public static readonly long[] Value={ 601L,42181L,70201L,240953L,277493L,414361L,418793L,619813L,632147L,637073L,723161L,732233L,739433L,761393L,781961L,879001L,934481L,979201L,1154233L,1320721L,1327673L,1357673L,1611361L,1685521L,1866233L,1877833L,1950457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094231Inst : IEnumerable<long>
{
public static readonly long[] Value=A094231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094231.Bytes);
public long this[int i]=>Value[i];

public static A094231Inst Instance=new A094231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094232
{
public static readonly BigInteger[] Value={ BigInteger.Parse("111111111111111111111111"),11000L,220L,120L,44L,40L,33L,30L,26L,24L,22L,20L };
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
public class A094232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094232Inst Instance=new A094232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094233
{
public static readonly long[] Value={ 1L,0L,2L,0L,6L,0L,20L,0L,70L,2L,252L,22L,924L,156L,3432L,910L,12870L,4760L,48622L,23256L,184796L,108528L,705894L,490314L,2708204L,2163150L,10430500L,9373652L,40313160L,40060078L,156305070L,169345560L,607812102L,709645552L,2369918628L,2952780320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094233Inst : IEnumerable<long>
{
public static readonly long[] Value=A094233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094233.Bytes);
public long this[int i]=>Value[i];

public static A094233Inst Instance=new A094233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094234
{
public static readonly long[] Value={ 1L,5L,10L,32L,76L,184L,408L,944L,2088L,4680L,10168L,22192L,47952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094234Inst : IEnumerable<long>
{
public static readonly long[] Value=A094234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094234.Bytes);
public long this[int i]=>Value[i];

public static A094234Inst Instance=new A094234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094235
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,4L,4L,5L,4L,5L,5L,3L,4L,3L,4L,4L,4L,3L,4L,3L,5L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,3L,4L,4L,5L,4L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,4L,5L,4L,4L,3L,3L,4L,5L,4L,4L,3L,4L,5L,5L,5L,4L,3L,4L,5L,5L,4L,4L,4L,5L,4L,4L,3L,3L,4L,5L,4L,4L,3L,4L,4L,3L,4L,3L,2L,4L,5L,4L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094235Inst : IEnumerable<long>
{
public static readonly long[] Value=A094235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094235.Bytes);
public long this[int i]=>Value[i];

public static A094235Inst Instance=new A094235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094236
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,5L,5L,21L,42L,42L,14L,84L,252L,462L,462L,42L,330L,1320L,3432L,6006L,6006L,132L,1287L,6435L,21450L,51480L,87516L,87516L,429L,5005L,30030L,121550L,364650L,831402L,1385670L,1385670L,1430L,19448L,136136L,646646L,2309450L,6466460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094236Inst : IEnumerable<long>
{
public static readonly long[] Value=A094236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094236.Bytes);
public long this[int i]=>Value[i];

public static A094236Inst Instance=new A094236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094237
{
public static readonly long[] Value={ 3L,4L,3L,3L,8L,1L,2L,8L,9L,4L,5L,3L,6L,7L,1L,4L,2L,9L,7L,6L,9L,9L,2L,0L,2L,0L,1L,9L,9L,5L,4L,4L,3L,0L,7L,9L,3L,8L,5L,6L,3L,7L,9L,2L,0L,4L,9L,3L,2L,2L,8L,6L,7L,8L,7L,4L,2L,5L,9L,6L,7L,9L,4L,5L,9L,1L,0L,1L,0L,7L,5L,8L,4L,0L,8L,1L,2L,9L,2L,4L,6L,2L,1L,5L,3L,1L,2L,1L,3L,6L,2L,8L,2L,1L,8L,6L,2L,1L,9L,1L,4L,4L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094237Inst : IEnumerable<long>
{
public static readonly long[] Value=A094237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094237.Bytes);
public long this[int i]=>Value[i];

public static A094237Inst Instance=new A094237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094238
{
public static readonly long[] Value={ 2L,0L,1L,2L,1L,7L,1L,2L,5L,5L,6L,8L,2L,5L,9L,5L,1L,5L,0L,6L,3L,7L,4L,7L,7L,8L,9L,7L,7L,1L,7L,8L,7L,6L,8L,1L,2L,3L,1L,2L,1L,5L,0L,5L,8L,3L,2L,0L,2L,6L,7L,3L,7L,7L,1L,2L,1L,0L,5L,4L,9L,7L,9L,1L,1L,5L,9L,3L,2L,5L,2L,9L,7L,5L,3L,8L,1L,1L,0L,8L,7L,3L,6L,2L,4L,6L,7L,3L,8L,8L,0L,2L,8L,5L,1L,2L,5L,3L,7L,4L,0L,1L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094238Inst : IEnumerable<long>
{
public static readonly long[] Value=A094238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094238.Bytes);
public long this[int i]=>Value[i];

public static A094238Inst Instance=new A094238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094239
{
public static readonly long[] Value={ 2L,4L,2L,0L,7L,1L,7L,7L,6L,1L,7L,4L,9L,3L,6L,1L,4L,9L,3L,2L,5L,4L,5L,1L,8L,2L,8L,3L,9L,8L,0L,0L,5L,5L,4L,3L,6L,6L,0L,9L,7L,0L,6L,4L,9L,7L,6L,6L,5L,8L,5L,4L,9L,4L,4L,1L,8L,4L,5L,8L,8L,8L,3L,9L,2L,2L,1L,7L,1L,2L,6L,5L,2L,3L,8L,2L,5L,3L,5L,6L,0L,3L,9L,4L,7L,3L,0L,5L,3L,5L,6L,4L,6L,0L,9L,6L,1L,8L,3L,2L,5L,7L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094239Inst : IEnumerable<long>
{
public static readonly long[] Value=A094239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094239.Bytes);
public long this[int i]=>Value[i];

public static A094239Inst Instance=new A094239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094240
{
public static readonly long[] Value={ 1L,8L,0L,2L,8L,6L,3L,1L,8L,8L,2L,9L,2L,3L,8L,5L,9L,0L,6L,7L,7L,0L,8L,5L,7L,9L,2L,0L,9L,1L,2L,0L,9L,5L,7L,3L,7L,7L,8L,1L,9L,8L,0L,3L,8L,6L,1L,1L,1L,6L,5L,9L,0L,0L,0L,1L,9L,4L,6L,8L,4L,5L,2L,5L,0L,5L,5L,7L,2L,4L,9L,8L,1L,8L,8L,6L,7L,4L,5L,4L,9L,5L,8L,4L,0L,4L,9L,2L,6L,3L,4L,2L,2L,5L,8L,4L,3L,0L,5L,2L,9L,2L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094240Inst : IEnumerable<long>
{
public static readonly long[] Value=A094240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094240.Bytes);
public long this[int i]=>Value[i];

public static A094240Inst Instance=new A094240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094241
{
public static readonly long[] Value={ 1L,7L,0L,6L,5L,2L,1L,1L,9L,4L,3L,7L,6L,0L,9L,7L,5L,7L,8L,2L,1L,4L,3L,3L,5L,9L,3L,3L,2L,1L,8L,9L,1L,7L,0L,5L,4L,3L,4L,4L,7L,1L,9L,6L,8L,1L,8L,7L,5L,5L,4L,5L,2L,4L,0L,9L,0L,0L,1L,8L,4L,5L,8L,2L,9L,0L,0L,4L,5L,4L,7L,5L,8L,2L,6L,3L,8L,3L,5L,1L,3L,6L,4L,2L,9L,4L,6L,1L,4L,8L,1L,4L,6L,5L,1L,5L,4L,4L,1L,3L,4L,3L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094241Inst : IEnumerable<long>
{
public static readonly long[] Value=A094241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094241.Bytes);
public long this[int i]=>Value[i];

public static A094241Inst Instance=new A094241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094242
{
public static readonly long[] Value={ 0L,2L,9L,1L,2L,2L,1L,4L,5L,8L,6L,8L,5L,4L,8L,2L,2L,6L,1L,2L,6L,1L,1L,1L,2L,3L,2L,7L,7L,6L,8L,6L,3L,8L,9L,7L,2L,4L,7L,0L,4L,5L,7L,6L,6L,2L,6L,3L,3L,1L,8L,2L,2L,2L,1L,7L,9L,2L,1L,7L,4L,6L,4L,5L,3L,4L,8L,6L,8L,0L,9L,3L,0L,5L,9L,2L,1L,3L,2L,1L,5L,2L,8L,9L,7L,2L,6L,4L,6L,9L,4L,9L,2L,7L,6L,7L,3L,7L,2L,4L,3L,5L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094242Inst : IEnumerable<long>
{
public static readonly long[] Value=A094242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094242.Bytes);
public long this[int i]=>Value[i];

public static A094242Inst Instance=new A094242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094243
{
public static readonly long[] Value={ 0L,0L,4L,9L,6L,9L,7L,5L,5L,9L,1L,5L,0L,3L,8L,9L,8L,5L,4L,4L,2L,8L,8L,7L,8L,9L,5L,2L,0L,6L,9L,4L,8L,5L,1L,8L,4L,5L,0L,3L,4L,6L,9L,4L,3L,2L,7L,2L,5L,3L,8L,0L,0L,8L,7L,7L,1L,1L,6L,2L,1L,8L,3L,4L,4L,7L,8L,9L,5L,8L,4L,1L,0L,4L,3L,5L,0L,9L,4L,7L,3L,6L,7L,0L,0L,8L,2L,0L,3L,2L,0L,3L,6L,8L,5L,5L,6L,4L,1L,1L,3L,0L,2L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094243Inst : IEnumerable<long>
{
public static readonly long[] Value=A094243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094243.Bytes);
public long this[int i]=>Value[i];

public static A094243Inst Instance=new A094243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094244
{
public static readonly long[] Value={ 4L,1L,3L,1L,0L,0L,6L,1L,6L,6L,0L,2L,7L,9L,5L,3L,9L,9L,1L,9L,4L,0L,6L,8L,6L,1L,8L,9L,0L,5L,6L,1L,2L,0L,4L,4L,9L,6L,4L,4L,0L,9L,6L,2L,3L,8L,4L,8L,8L,4L,0L,2L,0L,9L,9L,5L,2L,9L,7L,7L,3L,0L,6L,1L,8L,8L,8L,1L,4L,3L,2L,9L,3L,6L,5L,9L,3L,3L,0L,0L,1L,0L,9L,2L,2L,9L,6L,5L,4L,5L,6L,0L,0L,8L,7L,4L,6L,7L,2L,8L,1L,4L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094244Inst : IEnumerable<long>
{
public static readonly long[] Value=A094244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094244.Bytes);
public long this[int i]=>Value[i];

public static A094244Inst Instance=new A094244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094245
{
public static readonly long[] Value={ 5L,5L,4L,6L,7L,3L,2L,5L,8L,8L,9L,9L,4L,5L,5L,3L,0L,1L,4L,4L,9L,7L,1L,5L,9L,5L,2L,4L,0L,0L,0L,1L,7L,0L,3L,8L,7L,3L,1L,9L,1L,1L,2L,6L,4L,0L,4L,1L,3L,4L,7L,1L,0L,0L,8L,8L,9L,6L,3L,1L,4L,9L,4L,6L,2L,5L,1L,1L,4L,8L,9L,2L,6L,0L,2L,6L,0L,0L,3L,3L,6L,2L,7L,4L,6L,3L,7L,9L,9L,6L,1L,3L,2L,9L,9L,4L,7L,2L,4L,2L,5L,3L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094245Inst : IEnumerable<long>
{
public static readonly long[] Value=A094245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094245.Bytes);
public long this[int i]=>Value[i];

public static A094245Inst Instance=new A094245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094246
{
public static readonly long[] Value={ 1L,2L,2L,2L,7L,4L,7L,6L,8L,4L,4L,7L,3L,3L,1L,5L,8L,7L,0L,1L,0L,9L,6L,2L,4L,4L,8L,5L,0L,1L,6L,4L,8L,4L,1L,3L,8L,6L,0L,6L,6L,6L,6L,1L,7L,9L,5L,2L,7L,7L,1L,9L,8L,6L,7L,4L,7L,3L,8L,9L,2L,9L,9L,9L,6L,2L,9L,1L,6L,1L,0L,2L,0L,9L,8L,3L,8L,9L,3L,9L,7L,7L,2L,1L,7L,9L,0L,7L,1L,1L,8L,7L,8L,8L,3L,2L,9L,3L,7L,2L,7L,2L,2L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094246Inst : IEnumerable<long>
{
public static readonly long[] Value=A094246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094246.Bytes);
public long this[int i]=>Value[i];

public static A094246Inst Instance=new A094246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094247
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,0L,0L,-1L,1L,-1L,0L,0L,2L,0L,0L,-1L,2L,-1L,0L,-1L,0L,0L,0L,0L,1L,-2L,0L,0L,2L,0L,0L,-1L,0L,-2L,0L,-1L,2L,0L,0L,-1L,2L,0L,0L,0L,1L,0L,0L,0L,1L,-1L,0L,-2L,2L,0L,0L,0L,0L,-2L,0L,0L,2L,0L,0L,-1L,2L,0L,0L,-2L,0L,0L,0L,-1L,2L,-2L,0L,0L,0L,0L,0L,-1L,1L,-2L,0L,0L,2L,0L,0L,0L,2L,-1L,0L,0L,0L,0L,0L,0L,2L,-1L,0L,-1L,2L,0L,0L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094247Inst : IEnumerable<long>
{
public static readonly long[] Value=A094247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094247.Bytes);
public long this[int i]=>Value[i];

public static A094247Inst Instance=new A094247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094248
{
public static readonly long[] Value={ 1L,7L,7L,19L,49L,73L,193L,391L,751L,1747L,3457L,7249L,15649L,31783L,67543L,141811L,294001L,621337L,1297057L,2712679L,5700799L,11910643L,24964993L,52325281L,109483201L,229475527L,480592807L,1006367059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094248Inst : IEnumerable<long>
{
public static readonly long[] Value=A094248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094248.Bytes);
public long this[int i]=>Value[i];

public static A094248Inst Instance=new A094248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094249
{
public static readonly long[] Value={ 53L,353L,433L,733L,1609L,7789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094249Inst : IEnumerable<long>
{
public static readonly long[] Value=A094249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094249.Bytes);
public long this[int i]=>Value[i];

public static A094249Inst Instance=new A094249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094250
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,7L,1L,3L,8L,15L,1L,3L,9L,22L,31L,1L,3L,10L,31L,63L,63L,1L,3L,11L,42L,117L,185L,127L,1L,3L,12L,55L,199L,459L,550L,255L,1L,3L,13L,70L,315L,981L,1825L,1644L,511L,1L,3L,14L,87L,471L,1871L,4888L,7287L,4925L,1023L,1L,3L,15L,106L,673L,3273L,11203L,24420L,29133L,14767L,2047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094250Inst : IEnumerable<long>
{
public static readonly long[] Value=A094250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094250.Bytes);
public long this[int i]=>Value[i];

public static A094250Inst Instance=new A094250Inst();

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