using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A270441
{
public static readonly long[] Value={ 17L,31L,50L,68L,69L,75L,80L,101L,103L,122L,147L,155L,159L,160L,164L,170L,173L,179L,182L,212L,230L,231L,236L,257L,263L,264L,274L,278L,293L,302L,325L,327L,335L,353L,362L,373L,374L,381L,394L,407L,411L,424L,431L,437L,440L,451L,459L,467L,471L,472L,485L,491L,495L,500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270441Inst : IEnumerable<long>
{
public static readonly long[] Value=A270441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270441.Bytes);
public long this[int i]=>Value[i];

public static A270441Inst Instance=new A270441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270442
{
public static readonly long[] Value={ 2L,3L,10L,941L,3052L,8173L,35359L,1526009L,30167284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270442Inst : IEnumerable<long>
{
public static readonly long[] Value=A270442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270442.Bytes);
public long this[int i]=>Value[i];

public static A270442Inst Instance=new A270442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270443
{
public static readonly long[] Value={ 2L,3L,2L,5L,2L,7L,3L,5L,3L,11L,2L,13L,3L,3L,4L,17L,3L,19L,3L,4L,4L,23L,3L,13L,5L,9L,4L,29L,3L,31L,7L,5L,5L,5L,3L,37L,6L,6L,4L,41L,3L,43L,4L,5L,6L,47L,3L,25L,5L,7L,5L,53L,4L,7L,4L,7L,7L,59L,3L,61L,7L,5L,11L,8L,4L,67L,6L,8L,4L,71L,4L,73L,8L,6L,6L,8L,4L,79L,4L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270443Inst : IEnumerable<long>
{
public static readonly long[] Value=A270443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270443.Bytes);
public long this[int i]=>Value[i];

public static A270443Inst Instance=new A270443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270444
{
public static readonly long[] Value={ 2L,20L,152L,1136L,8480L,63296L,472448L,3526400L,26321408L,196465664L,1466439680L,10945654784L,81699479552L,609813217280L,4551707820032L,33974409691136L,253588446248960L,1892809931227136L,14128125664821248L,105453765593661440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270444Inst : IEnumerable<long>
{
public static readonly long[] Value=A270444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270444.Bytes);
public long this[int i]=>Value[i];

public static A270444Inst Instance=new A270444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270445
{
public static readonly long[] Value={ 2L,32L,352L,3712L,38912L,407552L,4268032L,44695552L,468058112L,4901568512L,51329892352L,537533612032L,5629125066752L,58948963008512L,617321555034112L,6464675252273152L,67698958146732032L,708952693724413952L,7424248994345254912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270445Inst : IEnumerable<long>
{
public static readonly long[] Value=A270445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270445.Bytes);
public long this[int i]=>Value[i];

public static A270445Inst Instance=new A270445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270446
{
public static readonly long[] Value={ 906L,3342L,3432L,4152L,4812L,4842L,5730L,7388L,7812L,8922L,10236L,10512L,11082L,11436L,12372L,12732L,13092L,14022L,14142L,14382L,14532L,15042L,15120L,16026L,16866L,17370L,18210L,18612L,18896L,18898L,20142L,20322L,20382L,20652L,21672L,24132L,24432L,24462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270446Inst : IEnumerable<long>
{
public static readonly long[] Value=A270446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270446.Bytes);
public long this[int i]=>Value[i];

public static A270446Inst Instance=new A270446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270447
{
public static readonly long[] Value={ 1L,3L,11L,43L,174L,721L,3044L,13059L,56837L,250690L,1119612L,5059561L,23119628L,106753404L,497762380L,2342096579L,11113027686L,53138757319L,255892224332L,1240217043450L,6046131132030L,29631889507380L,145923474439800L,721733515299225L,3583733352377724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270447Inst : IEnumerable<long>
{
public static readonly long[] Value=A270447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270447.Bytes);
public long this[int i]=>Value[i];

public static A270447Inst Instance=new A270447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270448
{
public static readonly long[] Value={ 4L,6L,8L,11L,12L,14L,23L,26L,42L,50L,54L,55L,66L,136L,145L,151L,200L,214L,888L,896L,1674L,2311L,2799L,2836L,2912L,5192L,5907L,8644L,8681L,11914L,18140L,27383L,36549L,57358L,84582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270448Inst : IEnumerable<long>
{
public static readonly long[] Value=A270448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270448.Bytes);
public long this[int i]=>Value[i];

public static A270448Inst Instance=new A270448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270449
{
public static readonly long[] Value={ 13L,61L,157L,181L,193L,337L,385L,397L,541L,673L,733L,769L,877L,1153L,1201L,1213L,1453L,1873L,1933L,2017L,2029L,2557L,2593L,2797L,3217L,3313L,3517L,4177L,4273L,4561L,4621L,4657L,5101L,5233L,5437L,5581L,5641L,6337L,6637L,6781L,7057L,7213L,7393L,7481L,7537L,7561L,7933L,8221L,8317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270449Inst : IEnumerable<long>
{
public static readonly long[] Value=A270449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270449.Bytes);
public long this[int i]=>Value[i];

public static A270449Inst Instance=new A270449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270450
{
public static readonly long[] Value={ 1L,4L,9L,24L,29L,64L,49L,116L,101L,216L,89L,308L,181L,456L,137L,604L,293L,760L,233L,980L,413L,1160L,345L,1444L,541L,1656L,489L,1972L,717L,2240L,641L,2596L,909L,2912L,801L,3316L,1133L,3648L,1009L,4124L,1365L,4480L,1233L,5020L,1605L,5408L,1489L,5980L,1893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270450Inst : IEnumerable<long>
{
public static readonly long[] Value=A270450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270450.Bytes);
public long this[int i]=>Value[i];

public static A270450Inst Instance=new A270450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270451
{
public static readonly long[] Value={ 1L,4L,24L,116L,604L,2596L,10756L,43612L,175708L,705316L,2826244L,11314780L,45278812L,181154596L,724697092L,2898945628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270451Inst : IEnumerable<long>
{
public static readonly long[] Value=A270451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270451.Bytes);
public long this[int i]=>Value[i];

public static A270451Inst Instance=new A270451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270484
{
public static readonly BigInteger[] Value={ 1L,2L,4L,89L,9068L,835058212L,706520689948473399L,BigInteger.Parse("665544723372507655558044420003804576"),BigInteger.Parse("921289777990406079056333243486799853786011136213486552451787227837877619") };
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
public class A270484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270484Inst Instance=new A270484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270485
{
public static readonly BigInteger[] Value={ 1L,2L,8L,97L,11716L,172250929L,464527945899982923L,BigInteger.Parse("716536589150920535839270312752276315"),BigInteger.Parse("459309301489561677977334026730028085729138984938021544486509797638182462") };
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
public class A270485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270485Inst Instance=new A270485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270486
{
public static readonly BigInteger[] Value={ 1L,5L,19L,6299L,29244983L,2480906174586499L,BigInteger.Parse("9602583972368431818444689851565"),BigInteger.Parse("310901734358858530002531740085708821780321504952699749074732105") };
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
public class A270486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270486.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270486Inst Instance=new A270486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270487
{
public static readonly BigInteger[] Value={ 1L,2L,2L,6L,29L,860L,626907L,1582796431872L,BigInteger.Parse("4577382865450526674426008"),BigInteger.Parse("77218331531088831524423800072197013265311322482652"),BigInteger.Parse("10410509369911993512345323774444196964795747018426948027297775848734862056109801420845614477793011811") };
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
public class A270487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270487Inst Instance=new A270487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270488
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,3L,3L,3L,2L,2L,4L,2L,3L,1L,3L,3L,3L,3L,2L,2L,3L,2L,2L,2L,4L,6L,3L,3L,3L,1L,5L,3L,4L,4L,3L,4L,3L,2L,3L,3L,6L,2L,5L,2L,2L,5L,3L,3L,1L,4L,4L,4L,5L,3L,3L,5L,1L,1L,2L,3L,7L,4L,5L,4L,3L,3L,6L,2L,5L,4L,6L,2L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270488Inst : IEnumerable<long>
{
public static readonly long[] Value=A270488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270488.Bytes);
public long this[int i]=>Value[i];

public static A270488Inst Instance=new A270488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270489
{
public static readonly long[] Value={ 1L,3L,12L,54L,265L,1401L,7903L,47088L,293319L,1892440L,12548041L,84988566L,585314652L,4085026386L,28820064810L,205156454376L,1471492171068L,10622954509803L,77122189800121L,562684397212060L,4123449352097229L,30336562360256955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270489Inst : IEnumerable<long>
{
public static readonly long[] Value=A270489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270489.Bytes);
public long this[int i]=>Value[i];

public static A270489Inst Instance=new A270489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270490
{
public static readonly long[] Value={ 1L,2L,7L,24L,87L,320L,1195L,4504L,17102L,65304L,250501L,964480L,3724996L,14424504L,55983091L,217702880L,848042197L,3308490496L,12924954514L,50553798696L,197948515868L,775853655760L,3043672637457L,11950142769664L,46954356540812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270490Inst : IEnumerable<long>
{
public static readonly long[] Value=A270490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270490.Bytes);
public long this[int i]=>Value[i];

public static A270490Inst Instance=new A270490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270491
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,11138400L,2194264800L,970377408000L,194939999654400L,23386660116019200L,BigInteger.Parse("63018468582765696000"),BigInteger.Parse("81934202708323789824000"),BigInteger.Parse("118589068612624434080256000"),BigInteger.Parse("230237098382438262288036864000") };
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
public class A270491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270491Inst Instance=new A270491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270492
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,2L,6L,2L,6L,4L,10L,2L,12L,6L,2L,2L,16L,6L,18L,2L,2L,10L,22L,2L,20L,12L,18L,2L,28L,2L,30L,2L,2L,16L,2L,2L,36L,18L,2L,2L,40L,2L,42L,2L,2L,22L,46L,2L,42L,20L,2L,2L,52L,18L,2L,2L,2L,28L,58L,2L,60L,30L,6L,2L,4L,2L,66L,2L,2L,2L,70L,2L,72L,36L,2L,2L,2L,2L,78L,2L,54L,40L,82L,2L,4L,42L,2L,2L,88L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270492Inst : IEnumerable<long>
{
public static readonly long[] Value=A270492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270492.Bytes);
public long this[int i]=>Value[i];

public static A270492Inst Instance=new A270492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270493
{
public static readonly long[] Value={ 3L,10L,45L,1710L,308961L,601929L,732202L,2214702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270493Inst : IEnumerable<long>
{
public static readonly long[] Value=A270493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270493.Bytes);
public long this[int i]=>Value[i];

public static A270493Inst Instance=new A270493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270494
{
public static readonly long[] Value={ 1L,5L,21L,88L,387L,1816L,9123L,48971L,279855L,1695902L,10856879L,73173016L,517597981L,3831970709L,29617983433L,238460465120L,1995828043987L,17333096360920L,155936489571399L,1451019052068763L,13945778132786915L,138259832617525950L,1412263078623261399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270494Inst : IEnumerable<long>
{
public static readonly long[] Value=A270494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270494.Bytes);
public long this[int i]=>Value[i];

public static A270494Inst Instance=new A270494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270495
{
public static readonly long[] Value={ 1L,8L,47L,253L,1345L,7304L,41193L,243152L,1506521L,9799547L,66844755L,477297022L,3560469469L,27692022408L,224128400923L,1884299045789L,16427961558365L,148293477761232L,1384008870213057L,13336887952918752L,132535336519342301L,1356662080571809755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270495Inst : IEnumerable<long>
{
public static readonly long[] Value=A270495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270495.Bytes);
public long this[int i]=>Value[i];

public static A270495Inst Instance=new A270495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270496
{
public static readonly long[] Value={ 1L,12L,97L,675L,4418L,28396L,183615L,1211936L,8237223L,57944187L,422950882L,3206531728L,25247250641L,206313943476L,1747990803645L,15336960025775L,139187730958406L,1304967471569208L,12624893940830455L,125892638744630088L,1292581981392588771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270496Inst : IEnumerable<long>
{
public static readonly long[] Value=A270496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270496.Bytes);
public long this[int i]=>Value[i];

public static A270496Inst Instance=new A270496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270497
{
public static readonly ulong[] Value={ 1L,17L,184L,1641L,13276L,102244L,770989L,5795889L,43967302L,339403001L,2681449074L,21763977864L,181900742989L,1567473197429L,13932812925824L,127738400615689L,1207445992487256L,11759938209394472L,117926100082535985L,1216563820893322317L,12901060857158377838UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270497Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A270497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270497.Bytes);
public ulong this[int i]=>Value[i];

public static A270497Inst Instance=new A270497Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270498
{
public static readonly ulong[] Value={ 1L,23L,324L,3645L,36223L,334751L,2965654L,25691104L,220643295L,1897548384L,16463907354L,144927422746L,1299763249771L,11912250951457L,111803042249042L,1076045623549383L,10628068291940557L,107760039986995689L,1121581530251066296L,11980190581723881858UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270498Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A270498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270498.Bytes);
public ulong this[int i]=>Value[i];

public static A270498Inst Instance=new A270498Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270499
{
public static readonly BigInteger[] Value={ 1L,30L,536L,7473L,90223L,995191L,10354804L,103779309L,1016654053L,9840330258L,94884791378L,917358452410L,8938608738199L,88139900141632L,882388425916186L,8991438542446875L,93434278760386701L,991477889069432577L,10753621593467498170UL,BigInteger.Parse("119276548511953973463") };
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
public class A270499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270499Inst Instance=new A270499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270532
{
public static readonly long[] Value={ 1L,2L,4L,9L,14L,19L,23L,27L,31L,38L,39L,48L,49L,61L,73L,76L,86L,90L,91L,93L,96L,99L,101L,107L,111L,117L,118L,124L,129L,138L,143L,144L,150L,153L,154L,155L,161L,166L,179L,188L,192L,195L,208L,213L,217L,219L,224L,229L,236L,243L,247L,250L,253L,258L,261L,262L,269L,272L,276L,277L,283L,285L,292L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270532Inst : IEnumerable<long>
{
public static readonly long[] Value=A270532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270532.Bytes);
public long this[int i]=>Value[i];

public static A270532Inst Instance=new A270532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270533
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,3L,3L,3L,3L,3L,2L,4L,2L,3L,2L,2L,5L,2L,5L,2L,1L,3L,1L,4L,3L,5L,6L,4L,5L,4L,5L,3L,4L,4L,2L,4L,3L,5L,5L,4L,8L,4L,4L,4L,3L,3L,3L,3L,2L,4L,5L,9L,3L,5L,4L,3L,4L,2L,4L,3L,6L,4L,5L,3L,5L,4L,5L,4L,4L,2L,1L,6L,2L,7L,2L,7L,5L,2L,5L,4L,3L,5L,4L,3L,5L,3L,6L,1L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270533Inst : IEnumerable<long>
{
public static readonly long[] Value=A270533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270533.Bytes);
public long this[int i]=>Value[i];

public static A270533Inst Instance=new A270533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270534
{
public static readonly long[] Value={ 1L,2L,5L,15L,67L,362L,1479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270534Inst : IEnumerable<long>
{
public static readonly long[] Value=A270534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270534.Bytes);
public long this[int i]=>Value[i];

public static A270534Inst Instance=new A270534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270535
{
public static readonly long[] Value={ 5L,8L,10L,11L,15L,16L,17L,27L,36L,68L,69L,71L,111L,132L,189L,200L,212L,214L,234L,252L,262L,279L,317L,332L,343L,344L,364L,424L,426L,500L,506L,518L,520L,543L,563L,577L,606L,620L,658L,672L,696L,697L,737L,766L,882L,907L,982L,1009L,1064L,1087L,1089L,1091L,1162L,1164L,1172L,1226L,1256L,1268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270535Inst : IEnumerable<long>
{
public static readonly long[] Value=A270535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270535.Bytes);
public long this[int i]=>Value[i];

public static A270535Inst Instance=new A270535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270536
{
public static readonly long[] Value={ 0L,0L,0L,6L,0L,15L,6L,22L,28L,45L,33L,66L,35L,64L,74L,104L,102L,140L,129L,160L,182L,196L,170L,263L,241L,285L,257L,281L,319L,329L,372L,423L,414L,460L,491L,537L,520L,582L,623L,647L,724L,836L,731L,772L,817L,947L,887L,1062L,879L,834L,1076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270536Inst : IEnumerable<long>
{
public static readonly long[] Value=A270536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270536.Bytes);
public long this[int i]=>Value[i];

public static A270536Inst Instance=new A270536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270537
{
public static readonly long[] Value={ 1L,2080L,2376L,2580L,3784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270537Inst : IEnumerable<long>
{
public static readonly long[] Value=A270537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270537.Bytes);
public long this[int i]=>Value[i];

public static A270537Inst Instance=new A270537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270538
{
public static readonly long[] Value={ 0L,1L,81L,441L,3721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270538Inst : IEnumerable<long>
{
public static readonly long[] Value=A270538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270538.Bytes);
public long this[int i]=>Value[i];

public static A270538Inst Instance=new A270538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270539
{
public static readonly long[] Value={ 2L,3L,5L,17L,37L,101L,257L,401L,577L,1297L,1601L,2917L,4357L,8101L,8837L,12101L,13457L,14401L,22501L,25601L,28901L,30977L,32401L,33857L,41617L,52901L,55697L,57601L,62501L,65537L,69697L,72901L,80657L,90001L,93637L,115601L,147457L,160001L,193601L,217157L,220901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270539Inst : IEnumerable<long>
{
public static readonly long[] Value=A270539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270539.Bytes);
public long this[int i]=>Value[i];

public static A270539Inst Instance=new A270539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270540
{
public static readonly long[] Value={ 0L,1L,1232L,4100L,268542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270540Inst : IEnumerable<long>
{
public static readonly long[] Value=A270540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270540.Bytes);
public long this[int i]=>Value[i];

public static A270540Inst Instance=new A270540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270541
{
public static readonly long[] Value={ 4L,6L,6L,6L,0L,12L,-6L,0L,6L,0L,0L,-24L,18L,6L,0L,0L,0L,24L,42L,-24L,-42L,48L,18L,-30L,-30L,-6L,0L,126L,-6L,-144L,18L,18L,108L,-12L,-120L,0L,12L,48L,48L,-12L,-66L,-36L,6L,96L,6L,-78L,-18L,90L,6L,-72L,18L,-24L,36L,60L,-60L,-30L,12L,-6L,12L,6L,-24L,-30L,12L,-12L,78L,18L,-54L,0L,0L,138L,0L,-102L,-12L,-42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270541Inst : IEnumerable<long>
{
public static readonly long[] Value=A270541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270541.Bytes);
public long this[int i]=>Value[i];

public static A270541Inst Instance=new A270541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270542
{
public static readonly long[] Value={ 0L,1L,2704L,5184L,7744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270542Inst : IEnumerable<long>
{
public static readonly long[] Value=A270542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270542.Bytes);
public long this[int i]=>Value[i];

public static A270542Inst Instance=new A270542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270543
{
public static readonly long[] Value={ 1L,3L,11L,13L,25L,27L,39L,41L,57L,59L,71L,73L,93L,95L,107L,109L,129L,131L,147L,149L,169L,171L,183L,185L,213L,215L,227L,229L,249L,251L,271L,273L,297L,299L,311L,313L,341L,343L,355L,357L,385L,387L,407L,409L,439L,431L,443L,445L,481L,483L,499L,501L,521L,523L,543L,545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270543Inst : IEnumerable<long>
{
public static readonly long[] Value=A270543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270543.Bytes);
public long this[int i]=>Value[i];

public static A270543Inst Instance=new A270543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270544
{
public static readonly long[] Value={ 0L,6L,10L,20L,24L,34L,42L,52L,56L,70L,78L,88L,96L,106L,114L,132L,136L,146L,158L,168L,176L,194L,202L,212L,220L,234L,242L,260L,268L,278L,294L,304L,308L,326L,334L,352L,364L,374L,382L,400L,408L,418L,434L,444L,452L,478L,486L,496L,504L,518L,530L,548L,556L,566L,582L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270544Inst : IEnumerable<long>
{
public static readonly long[] Value=A270544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270544.Bytes);
public long this[int i]=>Value[i];

public static A270544Inst Instance=new A270544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270545
{
public static readonly long[] Value={ 1L,4L,9L,15L,21L,27L,33L,39L,45L,51L,57L,63L,69L,75L,81L,87L,93L,99L,105L,111L,117L,123L,129L,135L,141L,147L,153L,159L,165L,171L,177L,183L,189L,195L,201L,207L,213L,219L,225L,231L,237L,243L,249L,255L,261L,267L,273L,279L,285L,291L,297L,303L,309L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270545Inst : IEnumerable<long>
{
public static readonly long[] Value=A270545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270545.Bytes);
public long this[int i]=>Value[i];

public static A270545Inst Instance=new A270545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270546
{
public static readonly BigInteger[] Value={ 2L,2L,5L,325L,200533L,65627675599L,BigInteger.Parse("22975481891957121466348"),BigInteger.Parse("1958997403653886589078102754522745217186637162"),BigInteger.Parse("141280756113351994103874857935521871912536028357392961997286697261498102983722388787617517574") };
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
public class A270546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270546Inst Instance=new A270546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270547
{
public static readonly BigInteger[] Value={ 2L,5L,19L,909L,866969L,1391730212321L,BigInteger.Parse("3778000141026848185401614"),BigInteger.Parse("40721846314736913560423097666261109869051562216449"),BigInteger.Parse("2752670766792898979726597410050364093079267724156167495561617776950485371872363605942870860465128310") };
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
public class A270547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270547.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270547Inst Instance=new A270547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270564
{
public static readonly long[] Value={ 2L,24L,240L,264L,480L,504L,552L,1128L,1416L,1992L,2568L,4008L,4296L,5448L,5520L,5736L,6312L,6960L,8328L,8616L,9192L,10632L,11208L,11280L,11496L,12072L,12408L,12720L,13200L,13512L,13920L,14088L,14160L,15528L,15576L,15816L,16320L,17256L,18744L,19848L,19920L,20136L,20712L,21288L,21912L,22560L,23592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270564Inst : IEnumerable<long>
{
public static readonly long[] Value=A270564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270564.Bytes);
public long this[int i]=>Value[i];

public static A270564Inst Instance=new A270564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270565
{
public static readonly long[] Value={ 1L,5L,32L,192L,845L,3533L,14628L,58389L,233293L,932688L,3733873L,14934304L,59737865L,238944733L,955725656L,3822610688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270565Inst : IEnumerable<long>
{
public static readonly long[] Value=A270565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270565.Bytes);
public long this[int i]=>Value[i];

public static A270565Inst Instance=new A270565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270566
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,5L,4L,2L,2L,2L,2L,2L,2L,2L,2L,5L,7L,4L,4L,4L,5L,5L,3L,3L,1L,3L,5L,4L,3L,3L,5L,8L,4L,3L,4L,6L,6L,2L,6L,4L,4L,5L,4L,3L,3L,4L,5L,1L,3L,3L,2L,6L,2L,4L,5L,8L,8L,4L,3L,5L,6L,6L,2L,1L,4L,3L,5L,3L,2L,3L,7L,8L,3L,5L,5L,4L,3L,4L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270566Inst : IEnumerable<long>
{
public static readonly long[] Value=A270566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270566.Bytes);
public long this[int i]=>Value[i];

public static A270566Inst Instance=new A270566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270567
{
public static readonly long[] Value={ 1L,9L,45L,225L,1125L,5625L,28125L,140625L,703125L,3515625L,17578125L,87890625L,439453125L,2197265625L,10986328125L,54931640625L,274658203125L,1373291015625L,6866455078125L,34332275390625L,171661376953125L,858306884765625L,4291534423828125L,21457672119140625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270567Inst : IEnumerable<long>
{
public static readonly long[] Value=A270567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270567.Bytes);
public long this[int i]=>Value[i];

public static A270567Inst Instance=new A270567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270568
{
public static readonly long[] Value={ 1L,12L,96L,768L,6144L,49152L,393216L,3145728L,25165824L,201326592L,1610612736L,12884901888L,103079215104L,824633720832L,6597069766656L,52776558133248L,422212465065984L,3377699720527872L,27021597764222976L,216172782113783808L,1729382256910270464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270568Inst : IEnumerable<long>
{
public static readonly long[] Value=A270568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270568.Bytes);
public long this[int i]=>Value[i];

public static A270568Inst Instance=new A270568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270569
{
public static readonly long[] Value={ 1L,5L,5L,36L,9L,96L,17L,188L,21L,312L,25L,468L,29L,656L,33L,876L,37L,1128L,41L,1412L,45L,1728L,49L,2076L,53L,2456L,57L,2868L,61L,3312L,65L,3788L,69L,4296L,73L,4836L,77L,5408L,81L,6012L,85L,6648L,89L,7316L,93L,8016L,97L,8748L,101L,9512L,105L,10308L,109L,11136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270569Inst : IEnumerable<long>
{
public static readonly long[] Value=A270569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270569.Bytes);
public long this[int i]=>Value[i];

public static A270569Inst Instance=new A270569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270570
{
public static readonly long[] Value={ 1L,16L,2L,16L,16L,52L,4L,52L,16L,52L,16L,40L,52L,160L,8L,52L,52L,88L,16L,64L,52L,160L,16L,88L,40L,9232L,52L,88L,160L,9232L,16L,100L,52L,160L,52L,112L,88L,304L,20L,9232L,64L,196L,52L,136L,160L,9232L,24L,148L,88L,232L,40L,160L,9232L,9232L,52L,196L,88L,304L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270570Inst : IEnumerable<long>
{
public static readonly long[] Value=A270570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270570.Bytes);
public long this[int i]=>Value[i];

public static A270570Inst Instance=new A270570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270571
{
public static readonly long[] Value={ 12L,24L,36L,48L,60L,72L,84L,96L,105L,108L,120L,132L,144L,156L,168L,180L,192L,204L,216L,228L,240L,252L,264L,276L,288L,300L,312L,315L,324L,336L,348L,360L,372L,384L,396L,408L,420L,432L,444L,456L,468L,480L,492L,504L,516L,525L,528L,540L,552L,564L,576L,588L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270571Inst : IEnumerable<long>
{
public static readonly long[] Value=A270571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270571.Bytes);
public long this[int i]=>Value[i];

public static A270571Inst Instance=new A270571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270572
{
public static readonly long[] Value={ 3L,1L,1L,2L,1L,3L,2L,2L,3L,3L,4L,1L,4L,2L,4L,3L,5L,1L,5L,2L,5L,3L,6L,1L,6L,2L,6L,3L,7L,1L,7L,2L,7L,3L,8L,1L,8L,2L,8L,3L,9L,1L,9L,2L,9L,3L,10L,1L,10L,2L,10L,3L,11L,1L,11L,2L,11L,3L,12L,1L,12L,2L,12L,3L,13L,1L,13L,2L,13L,3L,14L,1L,14L,2L,14L,3L,15L,1L,15L,2L,15L,3L,16L,1L,16L,2L,16L,3L,17L,1L,17L,2L,17L,3L,18L,1L,18L,2L,18L,3L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270572Inst : IEnumerable<long>
{
public static readonly long[] Value=A270572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270572.Bytes);
public long this[int i]=>Value[i];

public static A270572Inst Instance=new A270572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270573
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,3L,0L,1L,0L,0L,6L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270573Inst : IEnumerable<long>
{
public static readonly long[] Value=A270573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270573.Bytes);
public long this[int i]=>Value[i];

public static A270573Inst Instance=new A270573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270574
{
public static readonly long[] Value={ 9L,15L,21L,25L,27L,28L,33L,35L,39L,45L,49L,51L,55L,57L,63L,65L,69L,75L,77L,81L,85L,87L,91L,93L,95L,99L,105L,111L,112L,115L,117L,119L,121L,123L,124L,125L,129L,133L,135L,141L,143L,145L,147L,148L,153L,155L,159L,161L,165L,169L,171L,175L,177L,183L,185L,187L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270574Inst : IEnumerable<long>
{
public static readonly long[] Value=A270574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270574.Bytes);
public long this[int i]=>Value[i];

public static A270574Inst Instance=new A270574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270575
{
public static readonly long[] Value={ 9L,55L,85L,259L,781L,91L,2737L,451L,645L,341L,481L,703L,4005L,4369L,4371L,2071L,7957L,8695L,561L,6697L,15251L,7107L,16705L,3201L,34133L,31609L,3277L,1105L,16589L,1891L,18705L,9881L,13833L,14701L,19345L,47197L,26335L,1729L,8321L,2821L,2701L,35371L,12801L,22177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270575Inst : IEnumerable<long>
{
public static readonly long[] Value=A270575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270575.Bytes);
public long this[int i]=>Value[i];

public static A270575Inst Instance=new A270575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270576
{
public static readonly long[] Value={ 1L,8L,48L,288L,1728L,10368L,62208L,373248L,2239488L,13436928L,80621568L,483729408L,2902376448L,17414258688L,104485552128L,626913312768L,3761479876608L,22568879259648L,135413275557888L,812479653347328L,4874877920083968L,29249267520503808L,175495605123022848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270576Inst : IEnumerable<long>
{
public static readonly long[] Value=A270576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270576.Bytes);
public long this[int i]=>Value[i];

public static A270576Inst Instance=new A270576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270577
{
public static readonly BigInteger[] Value={ 1L,4L,84L,2640L,100100L,4232592L,192203088L,9178678080L,455053212900L,23222793594000L,1212760632317520L,64534727833692480L,3488102039411078544L,BigInteger.Parse("191031492362224091200"),BigInteger.Parse("10580671081188491976000") };
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
public class A270577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270577Inst Instance=new A270577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270578
{
public static readonly long[] Value={ 20L,491L,7502L,52013L,297464L,1119791L,3900890L,11135201L,29329232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270578Inst : IEnumerable<long>
{
public static readonly long[] Value=A270578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270578.Bytes);
public long this[int i]=>Value[i];

public static A270578Inst Instance=new A270578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270579
{
public static readonly long[] Value={ 13L,145L,1237L,4813L,19225L,42901L,119725L,233065L,475609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270579Inst : IEnumerable<long>
{
public static readonly long[] Value=A270579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270579.Bytes);
public long this[int i]=>Value[i];

public static A270579Inst Instance=new A270579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270596
{
public static readonly long[] Value={ 131L,191L,239L,251L,311L,419L,431L,491L,599L,647L,659L,683L,743L,827L,911L,971L,1031L,1091L,1103L,1151L,1163L,1223L,1259L,1451L,1499L,1511L,1559L,1571L,1583L,1607L,1667L,1787L,1811L,1847L,1871L,1931L,2003L,2087L,2111L,2243L,2267L,2339L,2351L,2399L,2411L,2423L,2531L,2591L,2663L,2687L,2699L,2711L,2843L,2927L,2939L,3011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270596Inst : IEnumerable<long>
{
public static readonly long[] Value=A270596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270596.Bytes);
public long this[int i]=>Value[i];

public static A270596Inst Instance=new A270596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270597
{
public static readonly BigInteger[] Value={ 1L,2L,5L,21L,98L,575L,3979L,31304L,277248L,2739141L,29898743L,355083014L,4584190984L,63680965127L,949202526375L,15102175351080L,255427113948896L,4573909845546233L,86542053988578763L,1723504067599805402L,BigInteger.Parse("36054646740337797072"),BigInteger.Parse("790412592781303448523") };
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
public class A270597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270597.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270597Inst Instance=new A270597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270598
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,14L,70L,364L,2548L,21104L,189936L,1830968L,20140648L,241712272L,3142259536L,43472528384L,652087925760L,10396900456448L,176747307759616L,3162885135453952L,60094817573625088L,1198006583353972736L,BigInteger.Parse("25158138250433427456"),BigInteger.Parse("551506339507727783936") };
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
public class A270598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270598.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270598Inst Instance=new A270598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270599
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,10L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270599Inst : IEnumerable<long>
{
public static readonly long[] Value=A270599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270599.Bytes);
public long this[int i]=>Value[i];

public static A270599Inst Instance=new A270599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270600
{
public static readonly long[] Value={ 2L,4L,3L,10L,12L,8L,18L,11L,28L,5L,36L,20L,14L,23L,52L,58L,60L,66L,35L,9L,39L,82L,22L,48L,100L,51L,106L,72L,56L,7L,130L,68L,138L,148L,15L,104L,162L,83L,172L,178L,180L,95L,96L,196L,99L,210L,37L,226L,76L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270600Inst : IEnumerable<long>
{
public static readonly long[] Value=A270600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270600.Bytes);
public long this[int i]=>Value[i];

public static A270600Inst Instance=new A270600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270601
{
public static readonly BigInteger[] Value={ 0L,36L,312L,8808L,443088L,44168712L,8708857332L,3419936238138L,2684843924352546L,4225663875817457520L,BigInteger.Parse("13361604903790701175254"),BigInteger.Parse("85018381019087710839691584"),BigInteger.Parse("1089960283319115969602380739838"),BigInteger.Parse("28183582557929760913921018421335722") };
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
public class A270601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270601Inst Instance=new A270601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270602
{
public static readonly BigInteger[] Value={ 0L,36L,1716L,171576L,46957788L,38923001616L,98204118828408L,744477422244654948L,BigInteger.Parse("16863964449356423397084"),BigInteger.Parse("1140493290200331813320727636"),BigInteger.Parse("230373612505462103444572129923504") };
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
public class A270602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270602Inst Instance=new A270602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270603
{
public static readonly BigInteger[] Value={ 0L,96L,8148L,1728288L,1008327378L,1749723617976L,9214293422949066L,BigInteger.Parse("148852251780140286528"),BigInteger.Parse("7419587466656553186766902"),BigInteger.Parse("1145882508466597523549481797856") };
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
public class A270603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270603Inst Instance=new A270603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270604
{
public static readonly BigInteger[] Value={ 0L,120L,23448L,13177740L,25162747992L,176610474548304L,4757551848002860896L,BigInteger.Parse("504235830402554520290820"),BigInteger.Parse("213082697840230591135069403580") };
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
public class A270604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270604Inst Instance=new A270604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270605
{
public static readonly BigInteger[] Value={ 0L,204L,67788L,70129212L,271906503420L,4288332432901128L,BigInteger.Parse("285369749616515150016"),BigInteger.Parse("81692982509404218523971864") };
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
public class A270605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270605Inst Instance=new A270605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270606
{
public static readonly long[] Value={ 0L,0L,6L,0L,0L,0L,0L,36L,0L,0L,0L,36L,312L,0L,0L,0L,96L,1716L,8808L,0L,0L,0L,120L,8148L,171576L,443088L,0L,0L,0L,204L,23448L,1728288L,46957788L,44168712L,0L,0L,0L,252L,67788L,13177740L,1008327378L,38923001616L,8708857332L,0L,0L,0L,360L,144252L,70129212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270606Inst : IEnumerable<long>
{
public static readonly long[] Value=A270606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270606.Bytes);
public long this[int i]=>Value[i];

public static A270606Inst Instance=new A270606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270607
{
public static readonly long[] Value={ 6L,0L,36L,36L,96L,120L,204L,252L,360L,432L,564L,660L,816L,936L,1116L,1260L,1464L,1632L,1860L,2052L,2304L,2520L,2796L,3036L,3336L,3600L,3924L,4212L,4560L,4872L,5244L,5580L,5976L,6336L,6756L,7140L,7584L,7992L,8460L,8892L,9384L,9840L,10356L,10836L,11376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270607Inst : IEnumerable<long>
{
public static readonly long[] Value=A270607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270607.Bytes);
public long this[int i]=>Value[i];

public static A270607Inst Instance=new A270607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270608
{
public static readonly long[] Value={ 0L,0L,312L,1716L,8148L,23448L,67788L,144252L,315936L,568032L,1049532L,1692228L,2793240L,4176936L,6369012L,9014028L,12965136L,17596272L,24205356L,31786452L,42217992L,53986488L,69705060L,87206556L,110011392L,135134208L,167193756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270608Inst : IEnumerable<long>
{
public static readonly long[] Value=A270608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270608.Bytes);
public long this[int i]=>Value[i];

public static A270608Inst Instance=new A270608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270609
{
public static readonly long[] Value={ 0L,0L,8808L,171576L,1728288L,13177740L,70129212L,309511644L,1134068490L,3559466436L,10133969880L,25490692140L,60750723804L,131276815188L,274807319832L,531982013820L,1009843336080L,1799168710884L,3165521551848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270609Inst : IEnumerable<long>
{
public static readonly long[] Value=A270609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270609.Bytes);
public long this[int i]=>Value[i];

public static A270609Inst Instance=new A270609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270610
{
public static readonly long[] Value={ 0L,0L,443088L,46957788L,1008327378L,25162747992L,271906503420L,2992465755612L,20367499465482L,129329174634672L,624840436639956L,2766099092355012L,10373656913823810L,35810603737855596L,111074891756040534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270610Inst : IEnumerable<long>
{
public static readonly long[] Value=A270610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270610.Bytes);
public long this[int i]=>Value[i];

public static A270610Inst Instance=new A270610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270611
{
public static readonly BigInteger[] Value={ 0L,0L,44168712L,38923001616L,1749723617976L,176610474548304L,4288332432901128L,139782884096635692L,1969237211896886586L,BigInteger.Parse("29229202706222377392"),BigInteger.Parse("264578668721400632640"),BigInteger.Parse("2322718464029360624340"),BigInteger.Parse("14967526923376689281208") };
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
public class A270611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270611Inst Instance=new A270611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270628
{
public static readonly long[] Value={ 1L,9L,13L,57L,66L,174L,195L,399L,431L,764L,800L,1313L,1349L,2034L,2102L,2983L,3103L,4248L,4316L,5793L,5893L,7650L,7826L,9915L,10103L,12556L,12760L,15697L,15889L,19146L,19450L,23187L,23475L,27812L,28128L,32789L,33309L,38486L,39002L,44951L,45287L,51940L,52404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270628Inst : IEnumerable<long>
{
public static readonly long[] Value=A270628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270628.Bytes);
public long this[int i]=>Value[i];

public static A270628Inst Instance=new A270628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270629
{
public static readonly long[] Value={ 7L,-4L,40L,-35L,99L,-87L,183L,-172L,301L,-297L,477L,-477L,649L,-617L,813L,-761L,1025L,-1077L,1409L,-1377L,1657L,-1581L,1913L,-1901L,2265L,-2249L,2733L,-2745L,3065L,-2953L,3433L,-3449L,4049L,-4021L,4345L,-4141L,4657L,-4661L,5433L,-5613L,6317L,-6189L,6625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270629Inst : IEnumerable<long>
{
public static readonly long[] Value=A270629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270629.Bytes);
public long this[int i]=>Value[i];

public static A270629Inst Instance=new A270629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270630
{
public static readonly long[] Value={ 1L,5L,8L,20L,32L,36L,52L,60L,108L,120L,128L,132L,196L,240L,208L,312L,360L,380L,412L,408L,504L,528L,552L,640L,732L,708L,796L,884L,968L,912L,1056L,1236L,1236L,1272L,1520L,1460L,1676L,1640L,1832L,1748L,1972L,2224L,2128L,2044L,2588L,2272L,2584L,2768L,2896L,2892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270630Inst : IEnumerable<long>
{
public static readonly long[] Value=A270630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270630.Bytes);
public long this[int i]=>Value[i];

public static A270630Inst Instance=new A270630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270631
{
public static readonly long[] Value={ 1L,5L,20L,60L,312L,1236L,5132L,20308L,84836L,348436L,1422668L,5780620L,23307100L,93611056L,375155196L,1502087240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270631Inst : IEnumerable<long>
{
public static readonly long[] Value=A270631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270631.Bytes);
public long this[int i]=>Value[i];

public static A270631Inst Instance=new A270631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270632
{
public static readonly long[] Value={ 1L,6L,14L,34L,66L,102L,154L,214L,322L,442L,570L,702L,898L,1138L,1346L,1658L,2018L,2398L,2810L,3218L,3722L,4250L,4802L,5442L,6174L,6882L,7678L,8562L,9530L,10442L,11498L,12734L,13970L,15242L,16762L,18222L,19898L,21538L,23370L,25118L,27090L,29314L,31442L,33486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270632Inst : IEnumerable<long>
{
public static readonly long[] Value=A270632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270632.Bytes);
public long this[int i]=>Value[i];

public static A270632Inst Instance=new A270632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270633
{
public static readonly long[] Value={ 4L,3L,12L,12L,4L,16L,8L,48L,12L,8L,4L,64L,44L,-32L,104L,48L,20L,32L,-4L,96L,24L,24L,88L,92L,-24L,88L,88L,84L,-56L,144L,180L,0L,36L,248L,-60L,216L,-36L,192L,-84L,224L,252L,-96L,-84L,544L,-316L,312L,184L,128L,-4L,408L,-76L,156L,64L,356L,-260L,336L,336L,-116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270633Inst : IEnumerable<long>
{
public static readonly long[] Value=A270633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270633.Bytes);
public long this[int i]=>Value[i];

public static A270633Inst Instance=new A270633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270634
{
public static readonly long[] Value={ 1L,4L,9L,32L,33L,92L,65L,176L,53L,316L,113L,432L,189L,548L,284L,801L,300L,1028L,420L,1272L,476L,1488L,672L,1840L,676L,2180L,840L,2488L,976L,2828L,1212L,3320L,1260L,3716L,1424L,4272L,1448L,4656L,1780L,5256L,1932L,5700L,2212L,6284L,2432L,6740L,2816L,7564L,2828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270634Inst : IEnumerable<long>
{
public static readonly long[] Value=A270634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270634.Bytes);
public long this[int i]=>Value[i];

public static A270634Inst Instance=new A270634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270635
{
public static readonly long[] Value={ 1L,4L,32L,176L,801L,3320L,13352L,53896L,215808L,864260L,3460608L,13830736L,55378196L,221272552L,885845744L,3542787408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270635Inst : IEnumerable<long>
{
public static readonly long[] Value=A270635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270635.Bytes);
public long this[int i]=>Value[i];

public static A270635Inst Instance=new A270635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270636
{
public static readonly long[] Value={ 1L,5L,14L,46L,79L,171L,236L,412L,465L,781L,894L,1326L,1515L,2063L,2347L,3148L,3448L,4476L,4896L,6168L,6644L,8132L,8804L,10644L,11320L,13500L,14340L,16828L,17804L,20632L,21844L,25164L,26424L,30140L,31564L,35836L,37284L,41940L,43720L,48976L,50908L,56608L,58820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270636Inst : IEnumerable<long>
{
public static readonly long[] Value=A270636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270636.Bytes);
public long this[int i]=>Value[i];

public static A270636Inst Instance=new A270636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270637
{
public static readonly long[] Value={ 3L,5L,23L,1L,59L,-27L,111L,-123L,263L,-203L,319L,-243L,359L,-264L,517L,-501L,728L,-608L,852L,-796L,1012L,-816L,1168L,-1164L,1504L,-1340L,1648L,-1512L,1852L,-1616L,2108L,-2060L,2456L,-2292L,2848L,-2824L,3208L,-2876L,3476L,-3324L,3768L,-3488L,4072L,-3852L,4308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270637Inst : IEnumerable<long>
{
public static readonly long[] Value=A270637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270637.Bytes);
public long this[int i]=>Value[i];

public static A270637Inst Instance=new A270637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270638
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270638Inst : IEnumerable<long>
{
public static readonly long[] Value=A270638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270638.Bytes);
public long this[int i]=>Value[i];

public static A270638Inst Instance=new A270638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270639
{
public static readonly long[] Value={ 13741L,16705L,150851L,208465L,249841L,252601L,258511L,410041L,486737L,635401L,1052503L,1082401L,1457773L,1507963L,1579249L,1615681L,2113921L,2184571L,3090091L,3375487L,3726541L,4682833L,4895065L,5044033L,5133201L,6233977L,6255341L,6350941L,6474691L,6912079L,7259161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270639Inst : IEnumerable<long>
{
public static readonly long[] Value=A270639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270639.Bytes);
public long this[int i]=>Value[i];

public static A270639Inst Instance=new A270639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270640
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,4L,2L,0L,6L,4L,0L,9L,5L,0L,14L,8L,0L,20L,12L,0L,30L,16L,0L,41L,22L,0L,56L,32L,0L,76L,42L,0L,102L,56L,0L,136L,75L,0L,178L,97L,0L,232L,126L,0L,300L,164L,0L,384L,208L,0L,490L,264L,0L,620L,336L,0L,780L,420L,0L,977L,526L,0L,1218L,656L,0L,1512L,810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270640Inst : IEnumerable<long>
{
public static readonly long[] Value=A270640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270640.Bytes);
public long this[int i]=>Value[i];

public static A270640Inst Instance=new A270640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270641
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270641Inst : IEnumerable<long>
{
public static readonly long[] Value=A270641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270641.Bytes);
public long this[int i]=>Value[i];

public static A270641Inst Instance=new A270641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270642
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270642Inst : IEnumerable<long>
{
public static readonly long[] Value=A270642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270642.Bytes);
public long this[int i]=>Value[i];

public static A270642Inst Instance=new A270642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270643
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270643Inst : IEnumerable<long>
{
public static readonly long[] Value=A270643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270643.Bytes);
public long this[int i]=>Value[i];

public static A270643Inst Instance=new A270643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270660
{
public static readonly long[] Value={ 12L,18L,20L,24L,30L,32L,36L,38L,40L,42L,44L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L,138L,140L,142L,144L,146L,148L,150L,152L,154L,156L,158L,160L,162L,164L,166L,168L,170L,172L,174L,176L,178L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270660Inst : IEnumerable<long>
{
public static readonly long[] Value=A270660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270660.Bytes);
public long this[int i]=>Value[i];

public static A270660Inst Instance=new A270660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270661
{
public static readonly long[] Value={ 1L,5L,14L,45L,164L,662L,2862L,12957L,60590L,290218L,1416216L,7014714L,35172968L,178180968L,910542696L,4688140189L,24296295636L,126640986410L,663465473910L,3491674292814L,18450954171742L,97859178176632L,520755520521982L,2779633126026210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270661Inst : IEnumerable<long>
{
public static readonly long[] Value=A270661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270661.Bytes);
public long this[int i]=>Value[i];

public static A270661Inst Instance=new A270661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270662
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,48L,341L,2640L,23561L,228816L,2674153L,32749200L,440019469L,6504919080L,102077649805L,1724124159576L,31359633592769L,596774321099040L,12048020039472209L,259300490127149664L,5798531237450331797L,BigInteger.Parse("136619813565630980280"),BigInteger.Parse("3380131718416134261301") };
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
public class A270662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270662Inst Instance=new A270662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270663
{
public static readonly BigInteger[] Value={ 1L,-1L,-11L,-181L,-9239L,-148681L,-49402979L,6471717251L,42662277841L,658656817939439L,133531458273294661L,BigInteger.Parse("168943525289665105979"),BigInteger.Parse("19015164932231993967289"),BigInteger.Parse("62294481438650615377602599"),BigInteger.Parse("18546969159687034895328945901"),BigInteger.Parse("27398539855607539080934584895859") };
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
public class A270663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270663Inst Instance=new A270663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270664
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,48L,336L,2400L,22240L,220416L,2496256L,30286080L,411725568L,6004838400L,94609106944L,1588301524992L,28577718427648L,546685777182720L,11027370474504192L,234498341381603328L,5253826506085629952L,BigInteger.Parse("123695389756163358720"),BigInteger.Parse("3039894623920125116416") };
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
public class A270664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270664Inst Instance=new A270664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270665
{
public static readonly BigInteger[] Value={ 1L,1L,4L,20L,136L,1016L,10112L,102080L,1259648L,16501888L,243214592L,3792156928L,66314635264L,1201731751936L,23824296632320L,496708324364288L,11065302289285120L,257749924759273472L,6397599337673523200L,BigInteger.Parse("165009476729535463424"),BigInteger.Parse("4496775223731602063360") };
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
public class A270665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270665Inst Instance=new A270665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270666
{
public static readonly BigInteger[] Value={ 1L,1L,2L,14L,48L,416L,3360L,29504L,274176L,3503104L,45192960L,579956992L,8982251520L,138130720768L,2456648183808L,45868468109312L,871166211686400L,17536583860060160L,393972064172900352L,8704569607311982592L,BigInteger.Parse("210657904645299240960"),BigInteger.Parse("5322004254737369399296") };
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
public class A270666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270666Inst Instance=new A270666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270667
{
public static readonly long[] Value={ 1L,21L,39L,57L,91L,93L,111L,129L,133L,183L,201L,217L,219L,237L,247L,259L,273L,291L,301L,309L,327L,381L,399L,403L,417L,427L,453L,469L,471L,481L,489L,511L,543L,553L,559L,579L,589L,597L,633L,651L,669L,679L,687L,703L,721L,723L,741L,763L,777L,793L,813L,817L,831L,849L,871L,889L,903L,921L,939L,949L,973L,993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270667Inst : IEnumerable<long>
{
public static readonly long[] Value=A270667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270667.Bytes);
public long this[int i]=>Value[i];

public static A270667Inst Instance=new A270667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270668
{
public static readonly BigInteger[] Value={ 1L,0L,2L,1L,0L,196L,0L,32L,0L,75272L,1L,0L,31329L,0L,599466256L,0L,450L,0L,135663392L,0L,28838245503008L,1L,0L,4941729L,0L,10956424382401L,0L,BigInteger.Parse("22463213552677201984"),0L,6272L,0L,233075146752L,0L,5652453608244879872L,0L,BigInteger.Parse("123818965842734619629420672") };
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
public class A270668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270668Inst Instance=new A270668Inst();

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