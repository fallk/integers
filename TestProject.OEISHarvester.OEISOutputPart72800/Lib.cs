using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A229600
{
public static readonly long[] Value={ 0L,6L,39L,202L,925L,3924L,15795L,61182L,230121L,845640L,3049407L,10825650L,37929141L,131403708L,450839115L,1533738726L,5178892545L,17371743408L,57926537559L,192131864730L,634207340493L,2084322230820L,6822862231779L,22252658047182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229600Inst : IEnumerable<long>
{
public static readonly long[] Value=A229600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229600.Bytes);
public long this[int i]=>Value[i];

public static A229600Inst Instance=new A229600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229601
{
public static readonly long[] Value={ 1L,39L,396L,3040L,20714L,131345L,792929L,4618048L,26165860L,145058507L,790042315L,4239980962L,22473980838L,117862612005L,612450538677L,3156938117780L,16157454978232L,82173962646319L,415564115855215L,2090880090793526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229601Inst : IEnumerable<long>
{
public static readonly long[] Value=A229601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229601.Bytes);
public long this[int i]=>Value[i];

public static A229601Inst Instance=new A229601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229602
{
public static readonly long[] Value={ 3L,202L,3040L,35182L,362100L,3476928L,31848813L,281845934L,2429033768L,20498682291L,170050970491L,1390738347774L,11237781105036L,89873465482971L,712350529942518L,5602092417764388L,43752038622648030L,339600817518201684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229602Inst : IEnumerable<long>
{
public static readonly long[] Value=A229602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229602.Bytes);
public long this[int i]=>Value[i];

public static A229602Inst Instance=new A229602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229603
{
public static readonly long[] Value={ 12L,925L,20714L,362100L,5655616L,82613904L,1153135492L,15568071652L,204858459714L,2641246065146L,33490766408662L,418803158565406L,5175912161534684L,63325575352273052L,768005500079367536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229603Inst : IEnumerable<long>
{
public static readonly long[] Value=A229603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229603.Bytes);
public long this[int i]=>Value[i];

public static A229603Inst Instance=new A229603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229604
{
public static readonly BigInteger[] Value={ 40L,3924L,131345L,3476928L,82613904L,1840258874L,39229935270L,809714005005L,16301446350838L,321725691680589L,6247090415396847L,119665707667897987L,2265983192057928009L,BigInteger.Parse("42485559978048128856"),BigInteger.Parse("789743391503380249568") };
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
public class A229604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229604Inst Instance=new A229604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229605
{
public static readonly BigInteger[] Value={ 120L,15795L,792929L,31848813L,1153135492L,39229935270L,1279020266434L,40413033646242L,1246326317951687L,37697561397216125L,1122224822297521683L,BigInteger.Parse("32965710304040001780"),BigInteger.Parse("957481537679788357971"),BigInteger.Parse("27540249663372893582723") };
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
public class A229605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229605Inst Instance=new A229605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229606
{
public static readonly long[] Value={ 0L,0L,0L,1L,6L,1L,3L,39L,39L,3L,12L,202L,396L,202L,12L,40L,925L,3040L,3040L,925L,40L,120L,3924L,20714L,35182L,20714L,3924L,120L,336L,15795L,131345L,362100L,362100L,131345L,15795L,336L,896L,61182L,792929L,3476928L,5655616L,3476928L,792929L,61182L,896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229606Inst : IEnumerable<long>
{
public static readonly long[] Value=A229606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229606.Bytes);
public long this[int i]=>Value[i];

public static A229606Inst Instance=new A229606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229607
{
public static readonly long[] Value={ 2L,3L,11L,5L,19L,17L,7L,37L,31L,29L,13L,73L,61L,53L,41L,23L,139L,113L,103L,79L,47L,43L,277L,223L,199L,157L,89L,59L,83L,547L,443L,397L,313L,173L,113L,67L,163L,1093L,883L,787L,619L,337L,223L,131L,71L,317L,2179L,1759L,1571L,1237L,673L,443L,257L,139L,97L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229607Inst : IEnumerable<long>
{
public static readonly long[] Value=A229607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229607.Bytes);
public long this[int i]=>Value[i];

public static A229607Inst Instance=new A229607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229608
{
public static readonly long[] Value={ 2L,5L,3L,11L,7L,13L,23L,17L,29L,19L,47L,37L,59L,41L,31L,97L,79L,127L,83L,67L,43L,197L,163L,257L,167L,137L,89L,53L,397L,331L,521L,337L,277L,179L,107L,61L,797L,673L,1049L,677L,557L,359L,223L,127L,71L,1597L,1361L,2099L,1361L,1117L,719L,449L,257L,149L,73L,3203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229608Inst : IEnumerable<long>
{
public static readonly long[] Value=A229608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229608.Bytes);
public long this[int i]=>Value[i];

public static A229608Inst Instance=new A229608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229609
{
public static readonly long[] Value={ 2L,5L,3L,13L,7L,11L,37L,19L,31L,17L,109L,53L,89L,47L,23L,317L,157L,263L,139L,67L,29L,947L,467L,787L,409L,199L,83L,41L,2837L,1399L,2357L,1223L,593L,241L,113L,43L,8501L,4177L,7069L,3659L,1777L,719L,337L,127L,59L,25471L,12527L,21193L,10973L,5323L,2153L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229609Inst : IEnumerable<long>
{
public static readonly long[] Value=A229609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229609.Bytes);
public long this[int i]=>Value[i];

public static A229609Inst Instance=new A229609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229610
{
public static readonly long[] Value={ 2L,7L,3L,23L,11L,5L,71L,37L,17L,13L,223L,113L,53L,41L,19L,673L,347L,163L,127L,59L,29L,2027L,1049L,491L,383L,179L,89L,31L,6089L,3163L,1481L,1151L,541L,269L,97L,43L,18269L,9491L,4447L,3457L,1627L,809L,293L,131L,47L,54829L,28477L,13367L,10391L,4889L,2437L,881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229610Inst : IEnumerable<long>
{
public static readonly long[] Value=A229610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229610.Bytes);
public long this[int i]=>Value[i];

public static A229610Inst Instance=new A229610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229611
{
public static readonly BigInteger[] Value={ 1L,14L,160L,1770L,19485L,214356L,2357944L,25937420L,285311665L,3138428370L,34522712136L,379749833574L,4177248169405L,45949729863560L,505447028499280L,5559917313492216L,61159090448414529L,672749994932559990L,7400249944258160080L,BigInteger.Parse("81402749386839761090") };
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
public class A229611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229611Inst Instance=new A229611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229612
{
public static readonly long[] Value={ 11L,37L,107L,181L,449L,457L,3583L,9133L,10139L,99689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229612Inst : IEnumerable<long>
{
public static readonly long[] Value=A229612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229612.Bytes);
public long this[int i]=>Value[i];

public static A229612Inst Instance=new A229612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229613
{
public static readonly long[] Value={ 5L,47L,113L,191L,293L,1117L,1487L,1733L,4057L,5153L,5737L,9767L,11633L,14321L,16607L,19013L,20681L,22469L,23677L,25561L,27191L,30937L,32369L,36833L,37991L,41959L,50591L,53327L,70717L,72869L,75037L,79493L,82889L,99191L,136861L,148957L,159167L,163979L,171341L,176369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229613Inst : IEnumerable<long>
{
public static readonly long[] Value=A229613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229613.Bytes);
public long this[int i]=>Value[i];

public static A229613Inst Instance=new A229613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229614
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,56L,104L,178L,314L,536L,930L,1558L,2666L,4482L,7574L,12686L,21360L,35812L,60152L,100812L,169122L,283498L,475356L,796292L,1334558L,2235888L,3746534L,6276048L,10515080L,17614726L,29510362L,49434792L,82815016L,138729368L,232399846L,389306052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229614Inst : IEnumerable<long>
{
public static readonly long[] Value=A229614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229614.Bytes);
public long this[int i]=>Value[i];

public static A229614Inst Instance=new A229614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229615
{
public static readonly long[] Value={ 1L,-2L,3L,0L,-1L,0L,7L,-8L,6L,0L,1L,0L,8L,-12L,15L,0L,-7L,0L,18L,-16L,12L,0L,5L,0L,14L,-26L,24L,0L,-6L,0L,31L,-24L,18L,0L,-5L,0L,20L,-28L,42L,0L,-8L,0L,36L,-48L,24L,0L,13L,0L,31L,-36L,42L,0L,-25L,0L,56L,-40L,30L,0L,6L,0L,32L,-64L,63L,0L,-12L,0L,54L,-48L,48L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229615Inst : IEnumerable<long>
{
public static readonly long[] Value=A229615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229615.Bytes);
public long this[int i]=>Value[i];

public static A229615Inst Instance=new A229615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229696
{
public static readonly long[] Value={ 0L,40L,626L,5077L,35825L,230383L,1400413L,8184819L,46455457L,257724695L,1403839397L,7532391243L,39908047865L,209177764015L,1086276818845L,5595663437379L,28620024582289L,145460267764487L,735134318022101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229696Inst : IEnumerable<long>
{
public static readonly long[] Value=A229696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229696.Bytes);
public long this[int i]=>Value[i];

public static A229696Inst Instance=new A229696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229697
{
public static readonly long[] Value={ 0L,336L,6732L,80757L,848937L,8186713L,75035643L,663220698L,5704874295L,48038840103L,397625913450L,3244798314423L,26164241721531L,208829737022022L,1652110212078675L,12969730076956551L,101126149198462638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229697Inst : IEnumerable<long>
{
public static readonly long[] Value=A229697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229697.Bytes);
public long this[int i]=>Value[i];

public static A229697Inst Instance=new A229697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229698
{
public static readonly long[] Value={ 0L,2304L,62856L,1125333L,17724789L,258006388L,3583403667L,48115029568L,629879095575L,8082470014816L,102040738816275L,1270988929203520L,15651508367076687L,190863964416217648L,2307849686574725259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229698Inst : IEnumerable<long>
{
public static readonly long[] Value=A229698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229698.Bytes);
public long this[int i]=>Value[i];

public static A229698Inst Instance=new A229698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229699
{
public static readonly BigInteger[] Value={ 0L,14080L,539568L,14461173L,342532665L,7551515197L,159377253183L,3259483737876L,65096269054893L,1275742582477605L,24619023091178172L,469011723417138726L,8837860575136215933L,BigInteger.Parse("164977425368113931622"),BigInteger.Parse("3054546692947278299664") };
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
public class A229699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229699Inst Instance=new A229699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229700
{
public static readonly BigInteger[] Value={ 0L,79872L,4377888L,175867605L,6279934941L,210095323918L,6749642728251L,210585483358218L,6425394969210939L,192588353994919005L,5688456451099770177L,BigInteger.Parse("165962586614349710061"),BigInteger.Parse("4791398443494607293804"),BigInteger.Parse("137079252918696683881476") };
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
public class A229700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229700Inst Instance=new A229700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229701
{
public static readonly long[] Value={ 1L,9L,63L,1L,522L,144L,487L,6921L,5202L,5203L,6534L,4806L,1828L,52011L,441L,69481L,90432L,14292L,163L,144L,16335L,90046L,67167L,9L,526501L,102321L,488241L,638461L,522981L,522612L,610642L,487872L,127413L,520453L,9693L,655344L,902494L,180945L,4806L,4276L,123147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229701Inst : IEnumerable<long>
{
public static readonly long[] Value=A229701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229701.Bytes);
public long this[int i]=>Value[i];

public static A229701Inst Instance=new A229701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229702
{
public static readonly long[] Value={ 1L,10L,70L,440L,2675L,16106L,96720L,580440L,3482805L,20897050L,125382586L,752295880L,4513775735L,27082654970L,162495930500L,974975583816L,5849853503865L,35099121024330L,210594726147310L,1263568356885400L,7581410141314171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229702Inst : IEnumerable<long>
{
public static readonly long[] Value=A229702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229702.Bytes);
public long this[int i]=>Value[i];

public static A229702Inst Instance=new A229702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229703
{
public static readonly long[] Value={ 2L,3L,3L,5L,3L,2L,4L,1L,7L,4L,8L,5L,1L,7L,1L,9L,8L,8L,7L,8L,7L,1L,6L,8L,1L,3L,9L,4L,8L,9L,6L,0L,3L,8L,2L,1L,7L,5L,6L,9L,1L,1L,2L,1L,6L,0L,1L,9L,6L,6L,6L,2L,5L,1L,8L,0L,6L,2L,4L,3L,5L,4L,3L,5L,9L,9L,3L,9L,3L,1L,3L,9L,2L,4L,3L,5L,4L,6L,7L,7L,8L,9L,0L,6L,4L,1L,1L,8L,6L,4L,7L,6L,3L,4L,4L,3L,8L,5L,7L,6L,4L,7L,7L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229703Inst : IEnumerable<long>
{
public static readonly long[] Value=A229703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229703.Bytes);
public long this[int i]=>Value[i];

public static A229703Inst Instance=new A229703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229704
{
public static readonly long[] Value={ 3L,0L,3L,5L,2L,1L,9L,0L,4L,9L,7L,2L,3L,4L,9L,1L,5L,4L,3L,7L,3L,7L,9L,0L,6L,3L,4L,7L,2L,9L,4L,7L,9L,6L,0L,1L,8L,8L,6L,2L,4L,7L,3L,9L,4L,2L,1L,6L,6L,7L,1L,3L,7L,8L,4L,3L,0L,3L,0L,6L,4L,2L,5L,3L,1L,8L,6L,9L,1L,7L,3L,5L,0L,6L,8L,2L,4L,3L,6L,5L,4L,1L,0L,1L,3L,1L,1L,5L,0L,1L,1L,7L,4L,2L,1L,7L,9L,2L,1L,6L,0L,3L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229704Inst : IEnumerable<long>
{
public static readonly long[] Value=A229704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229704.Bytes);
public long this[int i]=>Value[i];

public static A229704Inst Instance=new A229704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229705
{
public static readonly long[] Value={ 4L,1L,4L,3L,2L,2L,0L,4L,4L,3L,2L,1L,8L,2L,0L,3L,9L,1L,8L,6L,5L,0L,0L,3L,9L,4L,3L,8L,3L,1L,2L,4L,8L,9L,5L,0L,8L,4L,5L,2L,7L,2L,7L,4L,2L,1L,4L,3L,9L,5L,2L,7L,7L,6L,4L,7L,2L,9L,3L,5L,3L,3L,2L,5L,6L,7L,2L,0L,4L,6L,7L,1L,2L,4L,6L,0L,4L,3L,8L,5L,6L,8L,8L,1L,5L,6L,3L,5L,8L,2L,4L,3L,0L,5L,0L,5L,7L,7L,1L,8L,2L,5L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229705Inst : IEnumerable<long>
{
public static readonly long[] Value=A229705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229705.Bytes);
public long this[int i]=>Value[i];

public static A229705Inst Instance=new A229705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229706
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,2L,1L,1L,6L,5L,2L,1L,1L,9L,9L,5L,2L,1L,1L,12L,16L,10L,5L,2L,1L,1L,16L,25L,19L,10L,5L,2L,1L,1L,20L,39L,32L,20L,10L,5L,2L,1L,1L,25L,56L,54L,35L,20L,10L,5L,2L,1L,1L,30L,80L,84L,61L,36L,20L,10L,5L,2L,1L,1L,36L,109L,129L,99L,64L,36L,20L,10L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229706Inst : IEnumerable<long>
{
public static readonly long[] Value=A229706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229706.Bytes);
public long this[int i]=>Value[i];

public static A229706Inst Instance=new A229706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229707
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,1L,2L,1L,0L,0L,3L,2L,1L,0L,0L,4L,3L,2L,1L,0L,0L,3L,6L,3L,2L,1L,0L,0L,2L,7L,6L,3L,2L,1L,0L,0L,1L,8L,9L,6L,3L,2L,1L,0L,0L,0L,10L,12L,9L,6L,3L,2L,1L,0L,0L,0L,8L,16L,14L,9L,6L,3L,2L,1L,0L,0L,0L,7L,20L,20L,14L,9L,6L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229707Inst : IEnumerable<long>
{
public static readonly long[] Value=A229707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229707.Bytes);
public long this[int i]=>Value[i];

public static A229707Inst Instance=new A229707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229708
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,5L,3L,3L,2L,3L,2L,5L,2L,3L,2L,3L,3L,5L,2L,3L,2L,7L,5L,5L,2L,7L,2L,3L,2L,7L,3L,3L,2L,3L,2L,5L,2L,3L,2L,3L,7L,5L,3L,3L,2L,5L,5L,5L,3L,3L,5L,7L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,7L,5L,5L,5L,2L,3L,2L,7L,3L,3L,2L,7L,2L,5L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229708Inst : IEnumerable<long>
{
public static readonly long[] Value=A229708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229708.Bytes);
public long this[int i]=>Value[i];

public static A229708Inst Instance=new A229708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229709
{
public static readonly long[] Value={ 1L,2L,2L,5L,2L,2L,5L,2L,5L,2L,13L,2L,13L,5L,5L,2L,2L,2L,2L,13L,5L,29L,2L,13L,5L,2L,5L,2L,10L,5L,29L,2L,5L,2L,2L,13L,5L,2L,5L,2L,2L,2L,29L,5L,2L,34L,2L,5L,2L,10L,5L,13L,13L,18L,5L,5L,2L,26L,5L,13L,5L,2L,5L,17L,10L,2L,29L,10L,2L,2L,5L,13L,10L,2L,2L,5L,2L,5L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229709Inst : IEnumerable<long>
{
public static readonly long[] Value=A229709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229709.Bytes);
public long this[int i]=>Value[i];

public static A229709Inst Instance=new A229709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229710
{
public static readonly long[] Value={ 2L,5L,5L,5L,2L,13L,2L,5L,2L,5L,2L,5L,5L,5L,2L,13L,2L,13L,5L,5L,2L,37L,2L,5L,2L,13L,13L,5L,2L,5L,2L,5L,2L,13L,2L,13L,13L,5L,5L,13L,2L,5L,5L,5L,5L,13L,5L,37L,2L,5L,2L,5L,2L,37L,2L,13L,2L,13L,2L,5L,2L,5L,2L,5L,2L,17L,13L,5L,5L,5L,2L,13L,2L,37L,29L,13L,2L,13L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229710Inst : IEnumerable<long>
{
public static readonly long[] Value=A229710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229710.Bytes);
public long this[int i]=>Value[i];

public static A229710Inst Instance=new A229710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229711
{
public static readonly BigInteger[] Value={ 1L,1L,7L,154L,7329L,621054L,83287785L,16339143828L,4433073578739L,1595084475573057L,736780843688600494L,BigInteger.Parse("425703341782263982836"),BigInteger.Parse("301237142332910524156150"),BigInteger.Parse("256518292539312393631293756"),BigInteger.Parse("259004327874862610288497260501"),BigInteger.Parse("306183323229810278424153632807196") };
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
public class A229711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229711Inst Instance=new A229711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229744
{
public static readonly long[] Value={ 0L,1L,4L,6L,7L,10L,11L,20L,21L,23L,32L,33L,38L,47L,51L,52L,53L,54L,78L,101L,106L,122L,177L,205L,216L,370L,373L,383L,393L,411L,753L,757L,758L,763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229744Inst : IEnumerable<long>
{
public static readonly long[] Value=A229744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229744.Bytes);
public long this[int i]=>Value[i];

public static A229744Inst Instance=new A229744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229745
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,-1L,-1L,1L,1L,0L,0L,1L,-2L,-1L,-1L,1L,1L,0L,0L,1L,-1L,0L,0L,1L,0L,1L,1L,2L,-2L,-2L,-3L,1L,1L,0L,0L,1L,-1L,0L,0L,1L,0L,1L,1L,2L,-1L,-1L,-2L,1L,0L,1L,1L,2L,0L,0L,-1L,2L,1L,1L,-4L,-3L,-3L,-2L,-3L,1L,1L,0L,0L,1L,-1L,0L,0L,1L,0L,1L,1L,2L,-1L,-1L,-2L,1L,0L,1L,1L,2L,0L,0L,-1L,2L,1L,1L,-3L,-2L,-2L,-1L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229745Inst : IEnumerable<long>
{
public static readonly long[] Value=A229745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229745.Bytes);
public long this[int i]=>Value[i];

public static A229745Inst Instance=new A229745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229746
{
public static readonly long[] Value={ 6L,12L,30L,60L,66L,72L,114L,120L,180L,210L,240L,330L,336L,360L,396L,420L,456L,660L,756L,780L,840L,900L,984L,1116L,1200L,1248L,1260L,1290L,1320L,1584L,1590L,1680L,1710L,1716L,1770L,1800L,1980L,2100L,2310L,2400L,2460L,2496L,2520L,2604L,2640L,2940L,2970L,3060L,3120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229746Inst : IEnumerable<long>
{
public static readonly long[] Value=A229746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229746.Bytes);
public long this[int i]=>Value[i];

public static A229746Inst Instance=new A229746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229747
{
public static readonly long[] Value={ 13L,41L,113L,109L,2113L,1613L,1321L,26317L,525313L,14449L,30269L,268501L,279073L,536903681L,384773L,4327489L,47392381L,231769777L,21841L,43249589L,1759217765581L,29247661L,140737471578113L,4981857697937L,1326700741L,1801439824104653L,3630105520141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229747Inst : IEnumerable<long>
{
public static readonly long[] Value=A229747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229747.Bytes);
public long this[int i]=>Value[i];

public static A229747Inst Instance=new A229747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229748
{
public static readonly long[] Value={ 0L,3L,598L,6561L,29776L,102271L,314700L,914039L,2561548L,6994695L,18701748L,49101007L,126846084L,322964975L,811594012L,2015425287L,4951261596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229748Inst : IEnumerable<long>
{
public static readonly long[] Value=A229748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229748.Bytes);
public long this[int i]=>Value[i];

public static A229748Inst Instance=new A229748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229749
{
public static readonly long[] Value={ 0L,3L,60L,422L,1840L,6456L,20032L,57440L,155904L,406400L,1027072L,2532864L,6123520L,14563328L,34160640L,79192064L,181731328L,413368320L,932970496L,2091253760L,4658823168L,10321657856L,22754099200L,49935286272L,109135790080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229749Inst : IEnumerable<long>
{
public static readonly long[] Value=A229749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229749.Bytes);
public long this[int i]=>Value[i];

public static A229749Inst Instance=new A229749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229750
{
public static readonly long[] Value={ 1L,60L,598L,2347L,6809L,17404L,41872L,97565L,223075L,503650L,1126490L,2500555L,5515189L,12096536L,26401012L,57368137L,124167191L,267790942L,575680798L,1233926231L,2637709321L,5624580148L,11966370008L,25404922357L,53829723019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229750Inst : IEnumerable<long>
{
public static readonly long[] Value=A229750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229750.Bytes);
public long this[int i]=>Value[i];

public static A229750Inst Instance=new A229750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229751
{
public static readonly long[] Value={ 3L,422L,2347L,6561L,15075L,32548L,69198L,147376L,315786L,680124L,1468934L,3174760L,6855906L,14780020L,31793694L,68231136L,146079674L,312025516L,665011638L,1414360024L,3002176530L,6360776292L,13453355726L,28408158544L,59894811114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229751Inst : IEnumerable<long>
{
public static readonly long[] Value=A229751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229751.Bytes);
public long this[int i]=>Value[i];

public static A229751Inst Instance=new A229751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229752
{
public static readonly long[] Value={ 12L,1840L,6809L,15075L,29776L,57677L,113330L,228657L,473562L,1000381L,2139866L,4607729L,9947906L,21481485L,46333458L,99752209L,214296842L,459341309L,982407146L,2096608977L,4465367730L,9492005773L,20140323170L,42660619313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229752Inst : IEnumerable<long>
{
public static readonly long[] Value=A229752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229752.Bytes);
public long this[int i]=>Value[i];

public static A229752Inst Instance=new A229752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229753
{
public static readonly long[] Value={ 50L,6456L,17404L,32548L,57677L,102271L,186396L,354509L,704530L,1450667L,3059672L,6544921L,14099310L,30453719L,65785684L,141933029L,305639306L,656732227L,1407958032L,3011810033L,6428914918L,13695082991L,29117602316L,61795491133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229753Inst : IEnumerable<long>
{
public static readonly long[] Value=A229753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229753.Bytes);
public long this[int i]=>Value[i];

public static A229753Inst Instance=new A229753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229754
{
public static readonly long[] Value={ 210L,20032L,41872L,69198L,113330L,186396L,314700L,557578L,1046550L,2070144L,4258696L,8984046L,19221426L,41402836L,89392212L,192991026L,416096878L,895389192L,1922585088L,4119014998L,8805491466L,18784661532L,39993300364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229754Inst : IEnumerable<long>
{
public static readonly long[] Value=A229754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229754.Bytes);
public long this[int i]=>Value[i];

public static A229754Inst Instance=new A229754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229755
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,1L,3L,60L,60L,3L,12L,422L,598L,422L,12L,50L,1840L,2347L,2347L,1840L,50L,210L,6456L,6809L,6561L,6809L,6456L,210L,861L,20032L,17404L,15075L,15075L,17404L,20032L,861L,3416L,57440L,41872L,32548L,29776L,32548L,41872L,57440L,3416L,13140L,155904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229755Inst : IEnumerable<long>
{
public static readonly long[] Value=A229755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229755.Bytes);
public long this[int i]=>Value[i];

public static A229755Inst Instance=new A229755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229756
{
public static readonly long[] Value={ 2L,2L,4L,2L,12L,6L,2L,32L,28L,8L,2L,82L,110L,48L,10L,2L,206L,408L,224L,72L,12L,2L,516L,1454L,968L,378L,100L,14L,2L,1294L,5048L,4016L,1784L,578L,132L,16L,2L,3252L,17244L,16202L,7980L,2924L,830L,168L,18L,2L,8194L,58290L,64058L,34570L,13810L,4464L,1140L,208L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229756Inst : IEnumerable<long>
{
public static readonly long[] Value=A229756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229756.Bytes);
public long this[int i]=>Value[i];

public static A229756Inst Instance=new A229756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229757
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,15L,17L,20L,21L,23L,29L,36L,39L,41L,44L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229757Inst : IEnumerable<long>
{
public static readonly long[] Value=A229757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229757.Bytes);
public long this[int i]=>Value[i];

public static A229757Inst Instance=new A229757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229758
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,9L,9L,0L,9L,9L,18L,18L,0L,9L,9L,18L,27L,27L,0L,9L,18L,18L,27L,36L,36L,0L,9L,18L,27L,36L,36L,45L,54L,0L,9L,18L,27L,36L,45L,54L,63L,72L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,9L,9L,9L,9L,18L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229758Inst : IEnumerable<long>
{
public static readonly long[] Value=A229758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229758.Bytes);
public long this[int i]=>Value[i];

public static A229758Inst Instance=new A229758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229759
{
public static readonly long[] Value={ 1L,3L,1L,9L,6L,6L,0L,1L,1L,2L,5L,0L,1L,0L,5L,1L,5L,1L,7L,9L,5L,4L,1L,3L,1L,6L,5L,6L,3L,4L,3L,6L,1L,8L,8L,2L,2L,7L,9L,6L,9L,0L,8L,2L,0L,1L,9L,4L,2L,3L,7L,1L,3L,7L,8L,6L,4L,5L,5L,1L,3L,7L,7L,2L,9L,4L,7L,3L,9L,5L,3L,7L,1L,8L,1L,0L,9L,7L,5L,5L,0L,2L,9L,2L,7L,9L,2L,7L,9L,5L,8L,1L,0L,6L,0L,8L,8L,6L,2L,5L,1L,5L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229759Inst : IEnumerable<long>
{
public static readonly long[] Value=A229759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229759.Bytes);
public long this[int i]=>Value[i];

public static A229759Inst Instance=new A229759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230480
{
public static readonly long[] Value={ 2L,9L,7L,1L,9L,1L,6L,0L,3L,2L,2L,6L,2L,8L,1L,1L,8L,0L,4L,9L,6L,1L,0L,3L,5L,1L,2L,9L,9L,5L,5L,3L,1L,6L,8L,4L,4L,0L,4L,9L,6L,7L,1L,5L,8L,0L,3L,4L,9L,1L,4L,2L,5L,5L,5L,2L,2L,6L,3L,0L,1L,6L,9L,3L,0L,0L,6L,6L,9L,4L,3L,2L,6L,0L,1L,3L,6L,4L,5L,9L,2L,3L,4L,7L,6L,9L,9L,8L,2L,3L,5L,5L,7L,7L,1L,2L,5L,4L,6L,3L,9L,7L,1L,6L,9L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230480Inst : IEnumerable<long>
{
public static readonly long[] Value=A230480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230480.Bytes);
public long this[int i]=>Value[i];

public static A230480Inst Instance=new A230480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230481
{
public static readonly long[] Value={ -2L,4L,12L,24L,30L,56L,52L,78L,84L,82L,108L,88L,126L,144L,126L,162L,150L,204L,210L,210L,248L,242L,234L,348L,266L,268L,320L,362L,380L,394L,304L,396L,340L,480L,378L,420L,466L,486L,476L,464L,498L,578L,476L,566L,592L,678L,600L,456L,524L,660L,714L,742L,768L,756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230481Inst : IEnumerable<long>
{
public static readonly long[] Value=A230481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230481.Bytes);
public long this[int i]=>Value[i];

public static A230481Inst Instance=new A230481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230482
{
public static readonly long[] Value={ -1L,2L,6L,12L,15L,28L,26L,39L,42L,41L,54L,44L,63L,72L,63L,81L,75L,102L,105L,105L,124L,121L,117L,174L,133L,134L,160L,181L,190L,197L,152L,198L,170L,240L,189L,210L,233L,243L,238L,232L,249L,289L,238L,283L,296L,339L,300L,228L,262L,330L,357L,371L,384L,378L,372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230482Inst : IEnumerable<long>
{
public static readonly long[] Value=A230482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230482.Bytes);
public long this[int i]=>Value[i];

public static A230482Inst Instance=new A230482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230483
{
public static readonly long[] Value={ 4681L,29341L,42799L,49141L,52633L,85489L,90751L,104653L,458989L,1004653L,1082401L,1251949L,1302451L,1907851L,2510569L,2811271L,3090091L,3539101L,5044033L,5049001L,5489641L,5590621L,7177105L,9069229L,9073513L,9567673L,9995671L,10323769L,11473885L,12263131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230483Inst : IEnumerable<long>
{
public static readonly long[] Value=A230483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230483.Bytes);
public long this[int i]=>Value[i];

public static A230483Inst Instance=new A230483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230484
{
public static readonly long[] Value={ 253241L,280601L,580337L,1207361L,1678541L,1909001L,2419385L,5173601L,16324001L,18073817L,22849481L,25080101L,43363601L,60155201L,67194401L,82870517L,85519337L,97924217L,100943201L,102004421L,104857391L,116090081L,128987429L,134696801L,135969401L,145348529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230484Inst : IEnumerable<long>
{
public static readonly long[] Value=A230484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230484.Bytes);
public long this[int i]=>Value[i];

public static A230484Inst Instance=new A230484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230485
{
public static readonly ulong[] Value={ 3465253618401L,44202753561285411L,1640293473202755801L,10623546148468360251UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230485Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A230485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230485.Bytes);
public ulong this[int i]=>Value[i];

public static A230485Inst Instance=new A230485Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230486
{
public static readonly long[] Value={ 5L,10L,13L,17L,20L,25L,26L,29L,30L,34L,37L,40L,41L,50L,52L,53L,58L,60L,61L,65L,68L,70L,73L,74L,78L,80L,82L,85L,89L,90L,97L,100L,101L,102L,104L,106L,109L,110L,113L,116L,120L,122L,125L,130L,136L,137L,140L,145L,146L,148L,149L,150L,156L,157L,160L,164L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230486Inst : IEnumerable<long>
{
public static readonly long[] Value=A230486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230486.Bytes);
public long this[int i]=>Value[i];

public static A230486Inst Instance=new A230486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230487
{
public static readonly long[] Value={ 4681L,29341L,42799L,49141L,52633L,85489L,90751L,104653L,253241L,280601L,458989L,580337L,1004653L,1082401L,1207361L,1251949L,1302451L,1678541L,1907851L,1909001L,2419385L,2510569L,2811271L,3090091L,3539101L,5044033L,5049001L,5173601L,5489641L,5590621L,7177105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230487Inst : IEnumerable<long>
{
public static readonly long[] Value=A230487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230487.Bytes);
public long this[int i]=>Value[i];

public static A230487Inst Instance=new A230487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230488
{
public static readonly long[] Value={ 645L,33153L,129921L,157641L,451905L,656601L,1608465L,3020361L,3370641L,6212361L,19092921L,34487601L,38790753L,681942801L,940492785L,1109260545L,1574300001L,2693081973L,3037396461L,4160578521L,6424683105L,7384487181L,13671360561L,14966031345L,15731001105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230488Inst : IEnumerable<long>
{
public static readonly long[] Value=A230488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230488.Bytes);
public long this[int i]=>Value[i];

public static A230488Inst Instance=new A230488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230489
{
public static readonly long[] Value={ 87249L,831405L,1489665L,2113665L,31880577L,81612105L,84028407L,86559045L,274014885L,1778357505L,1853263365L,2276082537L,9090685605L,12300409857L,43620860865L,69654751377L,248342283645L,634038307449L,848282877345L,1123296404385L,1344952805505L,3307428792777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230489Inst : IEnumerable<long>
{
public static readonly long[] Value=A230489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230489.Bytes);
public long this[int i]=>Value[i];

public static A230489Inst Instance=new A230489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230490
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,12L,13L,14L,15L,15L,16L,16L,17L,18L,19L,20L,21L,22L,23L,23L,24L,25L,26L,26L,27L,28L,29L,30L,31L,32L,33L,33L,34L,35L,36L,36L,37L,38L,39L,39L,40L,41L,42L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,52L,52L,53L,54L,55L,55L,56L,57L,58L,59L,60L,61L,62L,62L,63L,64L,65L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,76L,77L,78L,79L,79L,80L,81L,81L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230490Inst : IEnumerable<long>
{
public static readonly long[] Value=A230490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230490.Bytes);
public long this[int i]=>Value[i];

public static A230490Inst Instance=new A230490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230491
{
public static readonly long[] Value={ 6L,84L,96L,108L,120L,132L,144L,156L,168L,180L,240L,264L,300L,324L,396L,420L,432L,468L,486L,504L,540L,594L,630L,684L,720L,756L,864L,990L,1026L,1080L,1116L,1134L,1152L,1224L,1332L,1344L,1404L,1440L,1494L,1536L,1584L,1638L,1680L,1710L,1728L,1782L,1824L,1872L,1890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230491Inst : IEnumerable<long>
{
public static readonly long[] Value=A230491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230491.Bytes);
public long this[int i]=>Value[i];

public static A230491Inst Instance=new A230491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230492
{
public static readonly long[] Value={ 6L,28L,117L,475L,496L,775L,2009L,8128L,13079L,13189L,14663L,16211L,23903L,26675L,30503L,35425L,37271L,41123L,43681L,44591L,46163L,47519L,55991L,59831L,63971L,66263L,66785L,73511L,76751L,78319L,81923L,88559L,88723L,107423L,112631L,127571L,130271L,140825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230492Inst : IEnumerable<long>
{
public static readonly long[] Value=A230492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230492.Bytes);
public long this[int i]=>Value[i];

public static A230492Inst Instance=new A230492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230493
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,2L,1L,3L,3L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,3L,3L,3L,2L,2L,3L,3L,2L,2L,2L,1L,1L,2L,2L,1L,3L,3L,1L,3L,2L,4L,1L,2L,2L,4L,3L,3L,2L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,2L,2L,2L,3L,3L,2L,4L,3L,2L,3L,5L,1L,4L,3L,3L,2L,4L,4L,3L,4L,5L,2L,4L,5L,4L,3L,2L,4L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230493Inst : IEnumerable<long>
{
public static readonly long[] Value=A230493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230493.Bytes);
public long this[int i]=>Value[i];

public static A230493Inst Instance=new A230493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230494
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,2L,3L,3L,1L,2L,4L,3L,2L,2L,3L,2L,3L,3L,4L,2L,2L,5L,2L,3L,3L,4L,3L,3L,4L,1L,3L,2L,3L,3L,2L,2L,3L,5L,3L,5L,2L,5L,6L,3L,3L,5L,5L,1L,4L,6L,4L,4L,5L,4L,3L,3L,4L,3L,5L,4L,4L,3L,4L,5L,3L,5L,4L,5L,1L,5L,4L,4L,4L,5L,4L,1L,6L,3L,3L,3L,5L,4L,2L,3L,8L,3L,4L,6L,6L,2L,4L,7L,1L,4L,4L,5L,1L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230494Inst : IEnumerable<long>
{
public static readonly long[] Value=A230494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230494.Bytes);
public long this[int i]=>Value[i];

public static A230494Inst Instance=new A230494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230495
{
public static readonly long[] Value={ 3L,3L,3L,27L,287L,287L,287L,287L,783L,783L,783L,19099L,20249L,34391L,80577L,92589L,211183L,211183L,211183L,1995137L,4270443L,4270443L,4270443L,4270443L,17026791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230495Inst : IEnumerable<long>
{
public static readonly long[] Value=A230495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230495.Bytes);
public long this[int i]=>Value[i];

public static A230495Inst Instance=new A230495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230576
{
public static readonly BigInteger[] Value={ 0L,0L,0L,58474L,98987768L,67978636208L,34266592666538L,17991771309348534L,9155613751914545266L,BigInteger.Parse("4619389107348901275470") };
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
public class A230576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230576Inst Instance=new A230576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230577
{
public static readonly long[] Value={ 45L,63L,75L,90L,99L,117L,126L,147L,150L,153L,171L,175L,180L,198L,207L,234L,243L,245L,252L,261L,275L,279L,294L,300L,306L,325L,333L,342L,350L,360L,363L,369L,387L,396L,414L,423L,425L,468L,475L,477L,486L,490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230577Inst : IEnumerable<long>
{
public static readonly long[] Value=A230577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230577.Bytes);
public long this[int i]=>Value[i];

public static A230577Inst Instance=new A230577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230578
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,2L,5L,5L,2L,2L,2L,3L,2L,7L,2L,2L,3L,2L,2L,2L,2L,3L,11L,2L,2L,11L,11L,2L,2L,2L,2L,3L,2L,2L,13L,13L,13L,2L,2L,2L,2L,3L,2L,2L,5L,2L,2L,2L,3L,17L,2L,17L,2L,17L,2L,2L,5L,2L,2L,2L,3L,19L,2L,2L,2L,3L,2L,2L,5L,19L,2L,2L,2L,3L,5L,2L,2L,2L,2L,23L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230578Inst : IEnumerable<long>
{
public static readonly long[] Value=A230578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230578.Bytes);
public long this[int i]=>Value[i];

public static A230578Inst Instance=new A230578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230579
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,256L,171L,1L,2L,4L,8L,16L,32L,64L,128L,256L,171L,1L,2L,4L,8L,16L,32L,64L,128L,256L,171L,1L,2L,4L,8L,16L,32L,64L,128L,256L,171L,1L,2L,4L,8L,16L,32L,64L,128L,256L,171L,1L,2L,4L,8L,16L,32L,64L,128L,256L,171L,1L,2L,4L,8L,16L,32L,64L,128L,256L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230579Inst : IEnumerable<long>
{
public static readonly long[] Value=A230579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230579.Bytes);
public long this[int i]=>Value[i];

public static A230579Inst Instance=new A230579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230580
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,3L,3L,5L,6L,9L,12L,16L,22L,29L,40L,54L,73L,100L,136L,184L,250L,340L,463L,629L,855L,1162L,1579L,2146L,2917L,3964L,5388L,7323L,9953L,13527L,18385L,24988L,33962L,46159L,62737L,85268L,115891L,157512L,214082L,290967L,395465L,537493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230580Inst : IEnumerable<long>
{
public static readonly long[] Value=A230580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230580.Bytes);
public long this[int i]=>Value[i];

public static A230580Inst Instance=new A230580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230581
{
public static readonly long[] Value={ 2L,4L,5L,6L,7L,14L,22L,25L,40L,47L,50L,57L,60L,69L,71L,76L,102L,107L,111L,114L,127L,137L,146L,152L,172L,189L,196L,197L,207L,212L,231L,251L,267L,277L,284L,291L,294L,296L,307L,309L,316L,319L,324L,371L,386L,392L,397L,412L,414L,445L,447L,467L,481L,494L,524L,527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230581Inst : IEnumerable<long>
{
public static readonly long[] Value=A230581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230581.Bytes);
public long this[int i]=>Value[i];

public static A230581Inst Instance=new A230581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230582
{
public static readonly long[] Value={ 1L,2L,1L,9L,0L,1L,0L,3L,3L,7L,8L,2L,9L,4L,5L,2L,1L,8L,4L,5L,7L,0L,0L,2L,4L,8L,6L,9L,9L,3L,0L,9L,8L,8L,5L,6L,6L,5L,9L,5L,0L,1L,2L,3L,3L,3L,3L,1L,9L,5L,6L,4L,5L,7L,3L,7L,1L,7L,0L,9L,5L,5L,9L,8L,1L,2L,6L,7L,3L,8L,9L,3L,2L,4L,5L,3L,4L,4L,0L,9L,0L,0L,6L,9L,7L,0L,2L,5L,6L,8L,5L,8L,1L,2L,0L,5L,8L,8L,6L,7L,6L,1L,5L,1L,6L,9L,5L,9L,6L,6L,4L,4L,1L,3L,8L,4L,9L,0L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230582Inst : IEnumerable<long>
{
public static readonly long[] Value=A230582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230582.Bytes);
public long this[int i]=>Value[i];

public static A230582Inst Instance=new A230582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230583
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,0L,3L,1L,1L,2L,3L,1L,3L,1L,2L,2L,2L,0L,4L,2L,2L,1L,3L,0L,4L,1L,3L,2L,1L,1L,5L,2L,1L,1L,4L,1L,4L,1L,2L,3L,2L,-1L,4L,2L,3L,2L,3L,0L,3L,2L,4L,3L,2L,-1L,6L,2L,1L,2L,3L,2L,5L,1L,2L,1L,3L,0L,6L,3L,2L,2L,3L,1L,4L,0L,5L,4L,2L,-1L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230583Inst : IEnumerable<long>
{
public static readonly long[] Value=A230583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230583.Bytes);
public long this[int i]=>Value[i];

public static A230583Inst Instance=new A230583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230584
{
public static readonly long[] Value={ 2L,3L,6L,7L,11L,14L,18L,23L,27L,34L,38L,47L,51L,62L,66L,79L,83L,98L,102L,119L,123L,142L,146L,167L,171L,194L,198L,223L,227L,254L,258L,287L,291L,322L,326L,359L,363L,398L,402L,439L,443L,482L,486L,527L,531L,574L,578L,623L,627L,674L,678L,727L,731L,782L,786L,839L,843L,898L,902L,959L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230584Inst : IEnumerable<long>
{
public static readonly long[] Value=A230584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230584.Bytes);
public long this[int i]=>Value[i];

public static A230584Inst Instance=new A230584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230585
{
public static readonly long[] Value={ 3L,5L,14L,42L,132L,429L,1430L,4862L,16796L,58786L,208012L,742900L,2674440L,9694845L,35357670L,129644790L,477638700L,1767263190L,6564120420L,24466267020L,91482563640L,343059613650L,1289904147324L,4861946401452L,18367353072152L,69533550916004L,263747951750360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230585Inst : IEnumerable<long>
{
public static readonly long[] Value=A230585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230585.Bytes);
public long this[int i]=>Value[i];

public static A230585Inst Instance=new A230585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230586
{
public static readonly long[] Value={ 1L,2L,123L,724L,2525L,6726L,15127L,30248L,55449L,95050L,154451L,240252L,360373L,524174L,742575L,1028176L,1395377L,1860498L,2441899L,3160100L,4037901L,5100502L,6375623L,7893624L,9687625L,11793626L,14250627L,17100748L,20389349L,24165150L,28480351L,33390752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230586Inst : IEnumerable<long>
{
public static readonly long[] Value=A230586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230586.Bytes);
public long this[int i]=>Value[i];

public static A230586Inst Instance=new A230586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230587
{
public static readonly long[] Value={ 18L,476L,1484L,1988L,2324L,3164L,4172L,4564L,5516L,7196L,7364L,7532L,8036L,8876L,9716L,9772L,10052L,10444L,10892L,11956L,12572L,13076L,13412L,14084L,16604L,16772L,18004L,19866L,20692L,21328L,21364L,21644L,22316L,22988L,23492L,23884L,23996L,24164L,24668L,24836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230587Inst : IEnumerable<long>
{
public static readonly long[] Value=A230587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230587.Bytes);
public long this[int i]=>Value[i];

public static A230587Inst Instance=new A230587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230588
{
public static readonly long[] Value={ 0L,0L,2L,8L,30L,120L,506L,2144L,9030L,37920L,159218L,668792L,2809710L,11804040L,49589354L,208325456L,875178390L,3676643760L,15445668962L,64887621608L,272594409150L,1145175432600L,4810908576986L,20210738740544L,84905783253990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230588Inst : IEnumerable<long>
{
public static readonly long[] Value=A230588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230588.Bytes);
public long this[int i]=>Value[i];

public static A230588Inst Instance=new A230588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230589
{
public static readonly long[] Value={ 0L,2L,28L,270L,2966L,34684L,405122L,4682406L,53977396L,622617950L,7184471690L,82901373580L,956544304506L,11036808012474L,127345448758460L,1469346402844134L,16953716335937734L,195616511948606684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230589Inst : IEnumerable<long>
{
public static readonly long[] Value=A230589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230589.Bytes);
public long this[int i]=>Value[i];

public static A230589Inst Instance=new A230589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230590
{
public static readonly BigInteger[] Value={ 0L,8L,270L,7078L,225010L,7476932L,239885668L,7573457652L,239197756936L,7567375830884L,239482620002238L,7578269700586628L,239803031035245668L,7588268963577159422L,BigInteger.Parse("240122303102460570488"),BigInteger.Parse("7598397555002280321334") };
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
public class A230590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230590.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230590Inst Instance=new A230590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230591
{
public static readonly BigInteger[] Value={ 0L,30L,2966L,225010L,20908278L,1902360932L,166037342468L,14405585585446L,1255996103473364L,109770330661494122L,9594687295739345186UL,BigInteger.Parse("838423302465551539930") };
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
public class A230591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230591Inst Instance=new A230591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230800
{
public static readonly long[] Value={ 0L,2L,2L,16L,34L,154L,432L,1618L,5058L,17664L,57586L,195866L,648928L,2185122L,7284482L,24435056L,81651394L,273490714L,914714512L,3062116338L,10245066178L,34289257824L,114738331026L,383986878106L,1284957453248L,4300144520002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230800Inst : IEnumerable<long>
{
public static readonly long[] Value=A230800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230800.Bytes);
public long this[int i]=>Value[i];

public static A230800Inst Instance=new A230800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230801
{
public static readonly long[] Value={ 0L,2L,14L,40L,298L,1546L,8704L,50450L,286426L,1650968L,9481842L,54537066L,313793424L,1805343618L,10388621898L,59779183384L,343996534162L,1979528849242L,11391230879008L,65551238025090L,377217128316090L,2170711959147608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230801Inst : IEnumerable<long>
{
public static readonly long[] Value=A230801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230801.Bytes);
public long this[int i]=>Value[i];

public static A230801Inst Instance=new A230801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230802
{
public static readonly long[] Value={ 0L,16L,40L,1370L,10448L,183088L,2045378L,29175688L,365502344L,4913369536L,63632416648L,840894973402L,10994101352914L,144572017467922L,1895295043605416L,24887788287735872L,326523191949148616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230802Inst : IEnumerable<long>
{
public static readonly long[] Value=A230802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230802.Bytes);
public long this[int i]=>Value[i];

public static A230802Inst Instance=new A230802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230803
{
public static readonly BigInteger[] Value={ 0L,34L,298L,10448L,243746L,6832578L,180981600L,4943014834L,133700619938L,3636674702224L,98739423076418L,2683583739212562L,72911555860683184L,1981321757121171674L,BigInteger.Parse("53837913037442724742"),BigInteger.Parse("1462968311880623328120") };
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
public class A230803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230803Inst Instance=new A230803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230804
{
public static readonly long[] Value={ 0L,154L,1546L,183088L,6832578L,485186602L,25669880656L,1576356652138L,90342705475634L,5358270247598784L,312733245050099786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230804Inst : IEnumerable<long>
{
public static readonly long[] Value=A230804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230804.Bytes);
public long this[int i]=>Value[i];

public static A230804Inst Instance=new A230804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230805
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,2L,2L,0L,0L,16L,14L,16L,0L,0L,34L,40L,40L,34L,0L,0L,154L,298L,1370L,298L,154L,0L,0L,432L,1546L,10448L,10448L,1546L,432L,0L,0L,1618L,8704L,183088L,243746L,183088L,8704L,1618L,0L,0L,5058L,50450L,2045378L,6832578L,6832578L,2045378L,50450L,5058L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230805Inst : IEnumerable<long>
{
public static readonly long[] Value=A230805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230805.Bytes);
public long this[int i]=>Value[i];

public static A230805Inst Instance=new A230805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230806
{
public static readonly long[] Value={ 1878781L,11782828711L,13828882831L,33694849633L,36331813363L,76093839067L,93121812139L,1018278728101L,1101228221011L,1200528250021L,1237788877321L,1296978796921L,1318608068131L,1449108019441L,1477968697741L,1608678768061L,1713708073171L,1792308032971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230806Inst : IEnumerable<long>
{
public static readonly long[] Value=A230806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230806.Bytes);
public long this[int i]=>Value[i];

public static A230806Inst Instance=new A230806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230807
{
public static readonly long[] Value={ 2L,2L,1878781L,1878781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230807Inst : IEnumerable<long>
{
public static readonly long[] Value=A230807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230807.Bytes);
public long this[int i]=>Value[i];

public static A230807Inst Instance=new A230807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230808
{
public static readonly long[] Value={ 3L,641L,643L,4369L,25759L,33149L,87249L,129917L,157637L,212419L,332947L,451901L,656597L,656599L,831405L,1489665L,1608461L,2113665L,3020357L,3370637L,6212357L,6212359L,19092917L,31880577L,34487597L,38790749L,63560683L,81612105L,84028407L,86559045L,274014885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230808Inst : IEnumerable<long>
{
public static readonly long[] Value=A230808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230808.Bytes);
public long this[int i]=>Value[i];

public static A230808Inst Instance=new A230808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230809
{
public static readonly long[] Value={ 179L,239L,359L,419L,659L,719L,1019L,1439L,1499L,1559L,2039L,2339L,2399L,2459L,2699L,2819L,2939L,3299L,3359L,3539L,3779L,4019L,4919L,5039L,5279L,5399L,5639L,6899L,7079L,9059L,9419L,9479L,9539L,10799L,11519L,11579L,11699L,11939L,12119L,12899L,12959L,13619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230809Inst : IEnumerable<long>
{
public static readonly long[] Value=A230809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230809.Bytes);
public long this[int i]=>Value[i];

public static A230809Inst Instance=new A230809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230810
{
public static readonly ulong[] Value={ 3L,3465253618399L,374166120095639L,12959269432331237L,44202753561285409L,1640293473202755797L,1640293473202755799L,10623546148468360249UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230810Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A230810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230810.Bytes);
public ulong this[int i]=>Value[i];

public static A230810Inst Instance=new A230810Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230811
{
public static readonly long[] Value={ 3L,3L,3L,1640293473202755797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230811Inst : IEnumerable<long>
{
public static readonly long[] Value=A230811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230811.Bytes);
public long this[int i]=>Value[i];

public static A230811Inst Instance=new A230811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230812
{
public static readonly long[] Value={ 5L,13L,41L,61L,85L,113L,145L,181L,221L,265L,313L,365L,421L,481L,545L,613L,685L,761L,1013L,1105L,1201L,1301L,1405L,1513L,1741L,1861L,1985L,2113L,2245L,2381L,2521L,2665L,2813L,2965L,3121L,3281L,3445L,3613L,3785L,3961L,4141L,4513L,4705L,5101L,5305L,5513L,5941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230812Inst : IEnumerable<long>
{
public static readonly long[] Value=A230812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230812.Bytes);
public long this[int i]=>Value[i];

public static A230812Inst Instance=new A230812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230813
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,12L,18L,56L,170L,420L,1162L,3200L,8562L,23292L,63298L,171336L,464890L,1261140L,3419322L,9274000L,25152322L,68211372L,184993778L,501712216L,1360654410L,3690150660L,10007829482L,27141578400L,73608971282L,199630236252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230813Inst : IEnumerable<long>
{
public static readonly long[] Value=A230813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230813.Bytes);
public long this[int i]=>Value[i];

public static A230813Inst Instance=new A230813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230814
{
public static readonly long[] Value={ 0L,2L,4L,12L,100L,326L,2114L,9226L,47220L,233480L,1135788L,5678402L,27785526L,137642146L,678271020L,3346581344L,16519160048L,81474120774L,402103867046L,1983757394910L,9788422760352L,48296742499360L,238296850975076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230814Inst : IEnumerable<long>
{
public static readonly long[] Value=A230814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230814.Bytes);
public long this[int i]=>Value[i];

public static A230814Inst Instance=new A230814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230815
{
public static readonly long[] Value={ 0L,0L,12L,174L,816L,12210L,108006L,1202184L,11797696L,124336446L,1262910682L,13078190344L,134042691720L,1381544758264L,14197831448766L,146130421941262L,1502841078520490L,15462124587630982L,159048324563923546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230815Inst : IEnumerable<long>
{
public static readonly long[] Value=A230815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230815.Bytes);
public long this[int i]=>Value[i];

public static A230815Inst Instance=new A230815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230912
{
public static readonly BigInteger[] Value={ 0L,2L,164L,5714L,221768L,9144134L,372256436L,15083831290L,611930935216L,24834134356510L,1007737924024732L,40891632273267442L,1659302731260314936L,BigInteger.Parse("67331404086209327030"),BigInteger.Parse("2732180126250261658692"),BigInteger.Parse("110866649653148718923818") };
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
public class A230912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230912Inst Instance=new A230912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230913
{
public static readonly BigInteger[] Value={ 0L,8L,1650L,154352L,16515468L,1821132074L,198872246508L,21679064102116L,2364862422099058L,257998825106362242L,BigInteger.Parse("28145414002555763394"),BigInteger.Parse("3070395667534086308108"),BigInteger.Parse("334951970767843594487436") };
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
public class A230913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230913Inst Instance=new A230913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230914
{
public static readonly BigInteger[] Value={ 0L,32L,17694L,4725576L,1406791226L,433315174684L,132452949993492L,40377009411879390L,12312133218182190396UL,BigInteger.Parse("3754741447813230806820"),BigInteger.Parse("1145012085042280823184860"),BigInteger.Parse("349169214981668401382285878") };
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
public class A230914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230914Inst Instance=new A230914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230915
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,8L,0L,0L,0L,0L,8L,164L,118L,0L,0L,0L,0L,32L,1650L,5714L,1506L,0L,0L,0L,0L,118L,17694L,154352L,221768L,20028L,0L,0L,0L,0L,440L,200654L,4725576L,16515468L,9144134L,271450L,0L,0L,0L,0L,1664L,2327434L,148720522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230915Inst : IEnumerable<long>
{
public static readonly long[] Value=A230915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230915.Bytes);
public long this[int i]=>Value[i];

public static A230915Inst Instance=new A230915Inst();

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