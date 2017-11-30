using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A231605
{
public static readonly long[] Value={ 1L,9L,7L,37L,9L,13L,9L,47L,7L,13L,11L,17L,7L,87L,3L,63L,147L,1L,67L,137L,21L,1L,23L,19L,163L,9L,9L,57L,371L,63L,51L,351L,17L,471L,89L,257L,39L,81L,109L,63L,3L,7L,973L,47L,39L,109L,737L,201L,429L,143L,7L,261L,9L,7L,129L,221L,69L,63L,167L,77L,493L,459L,587L,183L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231605Inst : IEnumerable<long>
{
public static readonly long[] Value=A231605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231605.Bytes);
public long this[int i]=>Value[i];

public static A231605Inst Instance=new A231605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231606
{
public static readonly long[] Value={ 1L,3L,11L,25L,137L,127L,949L,2003L,7129L,7381L,83711L,86021L,1145993L,1171733L,1195757L,2436559L,42142223L,41461543L,800021557L,788381929L,799467289L,810048769L,18863914247L,19087007117L,99182995801L,100212655201L,312536252003L,315404588903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231606Inst : IEnumerable<long>
{
public static readonly long[] Value=A231606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231606.Bytes);
public long this[int i]=>Value[i];

public static A231606Inst Instance=new A231606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231607
{
public static readonly long[] Value={ 7L,13L,17L,19L,31L,41L,43L,47L,53L,59L,61L,73L,83L,101L,109L,127L,139L,151L,157L,173L,197L,211L,223L,227L,229L,239L,257L,263L,277L,281L,283L,307L,311L,337L,347L,353L,367L,383L,397L,409L,419L,421L,431L,433L,439L,449L,461L,463L,487L,491L,503L,509L,523L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231607Inst : IEnumerable<long>
{
public static readonly long[] Value=A231607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231607.Bytes);
public long this[int i]=>Value[i];

public static A231607Inst Instance=new A231607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231608
{
public static readonly long[] Value={ 3L,3L,5L,5L,7L,11L,3L,7L,13L,17L,3L,5L,11L,19L,29L,5L,7L,11L,13L,37L,41L,3L,7L,13L,23L,17L,43L,59L,3L,5L,11L,19L,29L,23L,67L,71L,5L,7L,17L,17L,31L,53L,31L,79L,101L,3L,11L,13L,23L,19L,37L,59L,37L,97L,107L,7L,11L,13L,31L,29L,29L,43L,71L,41L,103L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231608Inst : IEnumerable<long>
{
public static readonly long[] Value=A231608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231608.Bytes);
public long this[int i]=>Value[i];

public static A231608Inst Instance=new A231608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231609
{
public static readonly long[] Value={ 3L,7L,5L,23L,13L,11L,89L,31L,19L,17L,139L,359L,47L,37L,29L,199L,181L,389L,53L,43L,41L,113L,211L,241L,401L,61L,67L,59L,1831L,293L,467L,283L,449L,73L,79L,71L,523L,1933L,317L,509L,337L,479L,83L,97L,101L,887L,1069L,2113L,773L,619L,409L,491L,131L,103L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231609Inst : IEnumerable<long>
{
public static readonly long[] Value=A231609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231609.Bytes);
public long this[int i]=>Value[i];

public static A231609Inst Instance=new A231609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231610
{
public static readonly long[] Value={ 1L,2L,4L,8L,3L,32L,21L,128L,75L,512L,151L,2048L,1365L,8192L,5461L,32768L,14563L,131072L,87381L,524288L,184111L,2097152L,932067L,8388608L,5592405L,33554432L,13256071L,134217728L,26512143L,536870912L,357913941L,2147483648L,1431655765L,8589934592L,3817748707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231610Inst : IEnumerable<long>
{
public static readonly long[] Value=A231610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231610.Bytes);
public long this[int i]=>Value[i];

public static A231610Inst Instance=new A231610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231611
{
public static readonly long[] Value={ 2L,1L,12L,105L,330L,385L,770L,1365L,1995L,1785L,3570L,5610L,2805L,6279L,3135L,14245L,13209L,6545L,7917L,12903L,17017L,21385L,22715L,11165L,22330L,21505L,29393L,20930L,10465L,16555L,31395L,19285L,38570L,37961L,35581L,35105L,52003L,79373L,18445L,35245L,23205L,46345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231611Inst : IEnumerable<long>
{
public static readonly long[] Value=A231611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231611.Bytes);
public long this[int i]=>Value[i];

public static A231611Inst Instance=new A231611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231612
{
public static readonly long[] Value={ 2L,90750L,194468L,229592L,388332L,868592L,1054868L,1148390L,1380380L,1415920L,1461372L,1496010L,1614800L,1706398L,1992210L,2439042L,2478212L,2644498L,2791910L,3073300L,3264448L,3824370L,3892780L,3939222L,3941938L,4425970L,4468980L,4594138L,4683700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231612Inst : IEnumerable<long>
{
public static readonly long[] Value=A231612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231612.Bytes);
public long this[int i]=>Value[i];

public static A231612Inst Instance=new A231612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231613
{
public static readonly long[] Value={ 32034L,162006L,339105L,458811L,1780425L,2989119L,2993100L,3080205L,4375404L,6129597L,6280221L,7565142L,8489820L,10268277L,11343741L,12065076L,13067295L,13333182L,15866508L,16472802L,17040537L,18028605L,19066758L,22633629L,24256362L,24365259L,25031349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231613Inst : IEnumerable<long>
{
public static readonly long[] Value=A231613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231613.Bytes);
public long this[int i]=>Value[i];

public static A231613Inst Instance=new A231613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231614
{
public static readonly long[] Value={ 4069124L,8919014L,8942756L,46503870L,75151624L,82805744L,189326670L,197155324L,271490544L,365746304L,648120564L,1031944990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231614Inst : IEnumerable<long>
{
public static readonly long[] Value=A231614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231614.Bytes);
public long this[int i]=>Value[i];

public static A231614Inst Instance=new A231614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231615
{
public static readonly BigInteger[] Value={ 1L,2L,14L,116L,1068L,10512L,108288L,1152944L,12586256L,140119328L,1584718432L,18156868096L,210302739712L,2458400698368L,28966931629056L,343671253924608L,4102106153148672L,49225440239052288L,593522724752742912L,7186802279959262208L,BigInteger.Parse("87357857306307234816"),BigInteger.Parse("1065563386236346036224") };
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
public class A231615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231615Inst Instance=new A231615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231616
{
public static readonly BigInteger[] Value={ 1L,2L,17L,166L,1790L,20604L,248073L,3086094L,39356942L,511795708L,6760681466L,90467976284L,1223761027216L,16706620420208L,229885828148601L,3185065661014494L,44395697055015126L,622123980321483372L,8759383095619677246L,BigInteger.Parse("123855964409644396212"),BigInteger.Parse("1758025089785401513140") };
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
public class A231616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231616Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231616.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231616Inst Instance=new A231616Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231617
{
public static readonly BigInteger[] Value={ 1L,1L,8L,75L,788L,8914L,106006L,1306629L,16544772L,213925368L,2812797588L,37494368574L,505536154470L,6882295486576L,94473351706766L,1306171811733083L,18172571198392164L,254235687592867548L,3574318400418780952L,BigInteger.Parse("50473259265229118344"),BigInteger.Parse("715565619086065023572"),BigInteger.Parse("10181073360665458354752") };
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
public class A231617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231617Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231617.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231617Inst Instance=new A231617Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231618
{
public static readonly BigInteger[] Value={ 1L,8L,92L,1264L,19220L,311736L,5285868L,92578656L,1661895332L,30416141032L,565437707516L,10647518728016L,202669742580916L,3893175999963032L,75376952791465356L,1469420261169552576L,BigInteger.Parse("28817874206182559556"),BigInteger.Parse("568178789630200669128"),BigInteger.Parse("11255461001317809903516") };
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
public class A231618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231618Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231618.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231618Inst Instance=new A231618Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231619
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,18L,174L,2394L,43488L,993150L,27560142L,906516252L,34681891932L,1520713138896L,75519376934904L,4206425439922920L,260667523550924424L,17848073907441578484UL,BigInteger.Parse("1342326288499671643956"),BigInteger.Parse("110319548590679184794880"),BigInteger.Parse("9862994518551295719972264"),BigInteger.Parse("955390360741496204485599576") };
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
public class A231619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231619Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231619.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231619Inst Instance=new A231619Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231620
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,277L,8641L,578949L,83316385L,25753389181L,17098272199297L,24382819596721629L,BigInteger.Parse("74684329652984094451"),BigInteger.Parse("491347682599497451569523"),BigInteger.Parse("6943240361573523613067995729"),BigInteger.Parse("210741152533202801182666172606913"),BigInteger.Parse("13738849457010997118546333815068560833"),BigInteger.Parse("1923823572225984354415961546862346889944243") };
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
public class A231620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231620Inst Instance=new A231620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231621
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,28L,189L,1873L,27201L,578949L,18059374L,825604416L,55315679788L,5431645680297L,781666575692345L,164861247948842305L,BigInteger.Parse("50959194632488457965"),BigInteger.Parse("23085190353310504913320"),BigInteger.Parse("15326793132326730009566200"),BigInteger.Parse("14913379277290330452859885202"),BigInteger.Parse("21267074956884103635776195255433"),BigInteger.Parse("44447403127130268192387935737712641") };
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
public class A231621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231621Inst Instance=new A231621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231622
{
public static readonly BigInteger[] Value={ 2L,-1L,1L,4L,31L,293L,3326L,44189L,673471L,11588884L,222304897L,4704612119L,108897613826L,2737023412199L,74236203425281L,2161288643251828L,67228358271588991L,2225173863019549229L,BigInteger.Parse("78087247031912850686"),BigInteger.Parse("2896042595237791161749"),BigInteger.Parse("113184512236563589997407") };
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
public class A231622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231622Inst Instance=new A231622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231623
{
public static readonly long[] Value={ 1L,1L,1L,2987L,801339L,221355125L,221355125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231623Inst : IEnumerable<long>
{
public static readonly long[] Value=A231623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231623.Bytes);
public long this[int i]=>Value[i];

public static A231623Inst Instance=new A231623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231624
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,9L,13L,14L,15L,17L,21L,25L,27L,31L,32L,33L,37L,39L,43L,44L,45L,49L,50L,51L,53L,57L,61L,62L,63L,67L,69L,73L,74L,75L,77L,81L,85L,87L,91L,92L,93L,97L,99L,101L,105L,109L,111L,115L,116L,117L,121L,122L,123L,127L,128L,129L,133L,134L,135L,137L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231624Inst : IEnumerable<long>
{
public static readonly long[] Value=A231624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231624.Bytes);
public long this[int i]=>Value[i];

public static A231624Inst Instance=new A231624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231625
{
public static readonly long[] Value={ 1L,2L,7L,8L,13L,14L,31L,32L,43L,44L,49L,50L,61L,62L,73L,74L,91L,92L,99L,115L,116L,121L,122L,127L,128L,133L,134L,145L,146L,151L,152L,163L,164L,169L,170L,181L,182L,187L,188L,195L,211L,212L,219L,229L,230L,235L,236L,241L,242L,247L,248L,253L,254L,265L,266L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231625Inst : IEnumerable<long>
{
public static readonly long[] Value=A231625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231625.Bytes);
public long this[int i]=>Value[i];

public static A231625Inst Instance=new A231625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231626
{
public static readonly long[] Value={ 1L,7L,13L,31L,43L,49L,61L,73L,91L,115L,121L,127L,133L,145L,151L,163L,169L,181L,187L,211L,229L,235L,241L,247L,253L,265L,283L,289L,295L,313L,325L,331L,343L,347L,355L,373L,385L,403L,409L,421L,427L,433L,451L,469L,481L,505L,511L,523L,535L,553L,565L,583L,589L,595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231626Inst : IEnumerable<long>
{
public static readonly long[] Value=A231626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231626.Bytes);
public long this[int i]=>Value[i];

public static A231626Inst Instance=new A231626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231627
{
public static readonly long[] Value={ 3L,5L,20L,24L,26L,29L,38L,41L,44L,45L,54L,56L,59L,60L,65L,78L,80L,81L,83L,87L,90L,92L,95L,101L,102L,108L,110L,114L,120L,122L,123L,135L,136L,137L,142L,143L,146L,147L,150L,153L,158L,159L,164L,167L,168L,174L,176L,177L,178L,180L,184L,185L,187L,190L,194L,197L,203L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231627Inst : IEnumerable<long>
{
public static readonly long[] Value=A231627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231627.Bytes);
public long this[int i]=>Value[i];

public static A231627Inst Instance=new A231627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231628
{
public static readonly long[] Value={ 2987L,4727L,9723L,18843L,22983L,30543L,35147L,39947L,45047L,50463L,55787L,56807L,58055L,58779L,69183L,78047L,81947L,85743L,101147L,106143L,108255L,109247L,117123L,134087L,139743L,139803L,152567L,171287L,174347L,175907L,182643L,189767L,197027L,199803L,202127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231628Inst : IEnumerable<long>
{
public static readonly long[] Value=A231628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231628.Bytes);
public long this[int i]=>Value[i];

public static A231628Inst Instance=new A231628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231629
{
public static readonly long[] Value={ 801339L,962649L,7353339L,21964299L,41642139L,48049689L,55455939L,89034939L,89851449L,92253849L,105259539L,107948379L,109455339L,114295449L,116754939L,122349369L,135575979L,156009849L,159521049L,173645439L,188586699L,192674169L,193137849L,220301769L,221355125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231629Inst : IEnumerable<long>
{
public static readonly long[] Value=A231629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231629.Bytes);
public long this[int i]=>Value[i];

public static A231629Inst Instance=new A231629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231630
{
public static readonly long[] Value={ 221355125L,221355127L,402640539L,402640541L,668862579L,668862581L,739577139L,739577141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231630Inst : IEnumerable<long>
{
public static readonly long[] Value=A231630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231630.Bytes);
public long this[int i]=>Value[i];

public static A231630Inst Instance=new A231630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231631
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,2L,3L,2L,1L,4L,1L,3L,3L,2L,1L,4L,1L,2L,3L,2L,1L,3L,2L,3L,6L,2L,1L,3L,1L,2L,3L,6L,2L,3L,1L,2L,6L,3L,1L,5L,1L,6L,5L,2L,1L,3L,3L,2L,4L,2L,1L,3L,2L,2L,6L,2L,1L,11L,1L,5L,5L,3L,2L,3L,1L,5L,3L,2L,1L,6L,1L,7L,3L,2L,2L,4L,1L,2L,6L,4L,1L,3L,2L,3L,4L,2L,1L,3L,2L,2L,3L,3L,6L,7L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231631Inst : IEnumerable<long>
{
public static readonly long[] Value=A231631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231631.Bytes);
public long this[int i]=>Value[i];

public static A231631Inst Instance=new A231631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231632
{
public static readonly long[] Value={ 169L,225L,289L,625L,676L,841L,900L,1156L,1225L,1369L,1521L,1681L,2025L,2500L,2601L,2704L,2809L,3025L,3364L,3600L,3721L,4225L,4624L,4900L,5329L,5476L,5625L,6084L,6724L,7225L,7569L,7921L,8100L,8281L,9025L,9409L,10000L,10201L,10404L,10816L,11025L,11236L,11881L,12100L,12321L,12769L,13225L,13456L,13689L,14161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231632Inst : IEnumerable<long>
{
public static readonly long[] Value=A231632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231632.Bytes);
public long this[int i]=>Value[i];

public static A231632Inst Instance=new A231632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231633
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,1L,3L,2L,5L,2L,4L,2L,7L,2L,5L,3L,5L,3L,10L,4L,5L,3L,8L,3L,14L,6L,5L,4L,11L,5L,11L,3L,11L,9L,4L,5L,10L,5L,11L,9L,12L,3L,19L,7L,11L,6L,12L,9L,11L,7L,17L,7L,13L,5L,22L,3L,3L,15L,16L,5L,25L,4L,9L,11L,13L,5L,19L,6L,22L,6L,11L,6L,39L,6L,24L,7L,7L,6L,25L,8L,21L,11L,24L,7L,31L,7L,19L,11L,33L,10L,14L,8L,15L,27L,18L,9L,21L,4L,27L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231633Inst : IEnumerable<long>
{
public static readonly long[] Value=A231633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231633.Bytes);
public long this[int i]=>Value[i];

public static A231633Inst Instance=new A231633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231634
{
public static readonly BigInteger[] Value={ 1L,3L,15L,105L,2835L,31185L,2027025L,91216125L,10854718875L,206239658625L,7795859096025L,4482618980214375L,72512954091703125L,BigInteger.Parse("99850337784275203125"),BigInteger.Parse("37643577344671751578125"),BigInteger.Parse("8168656283793770092453125"),BigInteger.Parse("12518528979807790079765625") };
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
public class A231634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231634Inst Instance=new A231634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231635
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,3L,2L,1L,1L,4L,2L,6L,1L,3L,2L,8L,4L,5L,4L,3L,2L,7L,5L,6L,2L,3L,2L,8L,5L,10L,6L,3L,1L,8L,3L,9L,4L,4L,4L,14L,6L,16L,7L,7L,2L,12L,6L,8L,4L,5L,5L,21L,5L,8L,6L,4L,8L,11L,7L,12L,5L,6L,4L,10L,8L,22L,6L,10L,6L,17L,9L,23L,7L,11L,12L,18L,10L,19L,10L,10L,7L,23L,8L,15L,4L,7L,8L,14L,11L,19L,9L,2L,4L,11L,10L,35L,6L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231635Inst : IEnumerable<long>
{
public static readonly long[] Value=A231635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231635.Bytes);
public long this[int i]=>Value[i];

public static A231635Inst Instance=new A231635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231636
{
public static readonly long[] Value={ 1L,5L,25L,124L,599L,2907L,14098L,68345L,331411L,1606976L,7792087L,37783439L,183209634L,888373029L,4307670407L,20887647824L,101283014043L,491115562211L,2381391364586L,11547230982705L,55991864805211L,271501360719136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231636Inst : IEnumerable<long>
{
public static readonly long[] Value=A231636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231636.Bytes);
public long this[int i]=>Value[i];

public static A231636Inst Instance=new A231636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231637
{
public static readonly long[] Value={ 3L,25L,362L,5110L,69671L,953726L,13036446L,178192422L,2435768976L,33294651915L,455108952124L,6220940586463L,85034818039884L,1162351701934606L,15888332641640874L,217179633334137617L,2968655946926989630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231637Inst : IEnumerable<long>
{
public static readonly long[] Value=A231637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231637.Bytes);
public long this[int i]=>Value[i];

public static A231637Inst Instance=new A231637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231638
{
public static readonly BigInteger[] Value={ 8L,124L,5110L,193596L,7176194L,266730604L,9902703284L,367678630271L,13651615789060L,506869469707295L,18819548834677196L,698750427030584024L,BigInteger.Parse("25943883731772910738"),BigInteger.Parse("963269692028936919099"),BigInteger.Parse("35765211805260137301887") };
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
public class A231638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231638Inst Instance=new A231638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231639
{
public static readonly BigInteger[] Value={ 21L,599L,69671L,7176194L,722149510L,72839521581L,7337927223290L,739300928401336L,74484943708241718L,7504342874539244449L,BigInteger.Parse("756062619205812384051"),BigInteger.Parse("76173283584466268712696"),BigInteger.Parse("7674456207021624430421367") };
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
public class A231639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231639Inst Instance=new A231639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231640
{
public static readonly BigInteger[] Value={ 55L,2907L,953726L,266730604L,72839521581L,19935360619245L,5448852806527104L,1489472227762012570L,BigInteger.Parse("407153748122282833931"),BigInteger.Parse("111296504708033952837061"),BigInteger.Parse("30423245413711787972071775"),BigInteger.Parse("8316285148242091648350745493") };
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
public class A231640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231640Inst Instance=new A231640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231641
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,3L,8L,25L,25L,8L,21L,124L,362L,124L,21L,55L,599L,5110L,5110L,599L,55L,144L,2907L,69671L,193596L,69671L,2907L,144L,377L,14098L,953726L,7176194L,7176194L,953726L,14098L,377L,987L,68345L,13036446L,266730604L,722149510L,266730604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231641Inst : IEnumerable<long>
{
public static readonly long[] Value=A231641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231641.Bytes);
public long this[int i]=>Value[i];

public static A231641Inst Instance=new A231641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231642
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,0L,1L,0L,3L,2L,3L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,4L,0L,6L,0L,4L,0L,1L,0L,0L,3L,0L,0L,3L,0L,0L,1L,0L,5L,0L,0L,2L,0L,0L,5L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,6L,4L,3L,0L,0L,0L,3L,4L,6L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,7L,0L,7L,0L,7L,2L,7L,0L,7L,0L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231642Inst : IEnumerable<long>
{
public static readonly long[] Value=A231642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231642.Bytes);
public long this[int i]=>Value[i];

public static A231642Inst Instance=new A231642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231643
{
public static readonly long[] Value={ 10L,15L,25L,45L,85L,165L,325L,645L,1285L,2565L,5125L,10245L,20485L,40965L,81925L,163845L,327685L,655365L,1310725L,2621445L,5242885L,10485765L,20971525L,41943045L,83886085L,167772165L,335544325L,671088645L,1342177285L,2684354565L,5368709125L,10737418245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231643Inst : IEnumerable<long>
{
public static readonly long[] Value=A231643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231643.Bytes);
public long this[int i]=>Value[i];

public static A231643Inst Instance=new A231643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231644
{
public static readonly BigInteger[] Value={ 3L,35L,920L,137961L,96014413L,374409597564L,7673178325424236L,BigInteger.Parse("823755531731133088630"),BigInteger.Parse("468550736330699430524865279") };
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
public class A231644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231644Inst Instance=new A231644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231645
{
public static readonly long[] Value={ 3L,35L,104L,341L,1189L,4040L,13560L,45803L,155131L,524683L,1773770L,5998876L,20290918L,68629108L,232120783L,785115525L,2655576210L,8982247095L,30381769982L,102764504913L,347595681724L,1175726561166L,3976846922803L,13451535863780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231645Inst : IEnumerable<long>
{
public static readonly long[] Value=A231645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231645.Bytes);
public long this[int i]=>Value[i];

public static A231645Inst Instance=new A231645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231646
{
public static readonly long[] Value={ 9L,104L,920L,7682L,61574L,490760L,3929027L,31501117L,252454167L,2022844426L,16209670759L,129896538285L,1040912909763L,8341204621591L,66841228911422L,535624801555647L,4292168448581044L,34394795269925139L,275618732897288063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231646Inst : IEnumerable<long>
{
public static readonly long[] Value=A231646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231646.Bytes);
public long this[int i]=>Value[i];

public static A231646Inst Instance=new A231646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231647
{
public static readonly BigInteger[] Value={ 22L,341L,7682L,137961L,2412274L,42882766L,765163605L,13643499478L,243317286312L,4340128403053L,77412117578960L,1380680024126767L,24625023800964584L,439200986311182069L,7833405373009045177L,BigInteger.Parse("139713294059336266128") };
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
public class A231647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231647Inst Instance=new A231647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231648
{
public static readonly BigInteger[] Value={ 51L,1189L,61574L,2412274L,96014413L,3936913977L,161357952814L,6602715583511L,270337779895196L,11069019817530645L,453147169968161944L,BigInteger.Parse("18550832129905355953"),BigInteger.Parse("759448690449540291323"),BigInteger.Parse("31091056859424132422442") };
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
public class A231648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231648Inst Instance=new A231648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231649
{
public static readonly BigInteger[] Value={ 121L,4040L,490760L,42882766L,3936913977L,374409597564L,35384751611050L,3335789961947404L,314852421269523851L,BigInteger.Parse("29721381118553717447"),BigInteger.Parse("2805039910196136173308"),BigInteger.Parse("264733396758705184183618") };
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
public class A231649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231649Inst Instance=new A231649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231650
{
public static readonly BigInteger[] Value={ 292L,13560L,3929027L,765163605L,161357952814L,35384751611050L,7673178325424236L,1659606986967401246L,BigInteger.Parse("359651366294031374125"),BigInteger.Parse("77952234653703371179457"),BigInteger.Parse("16890753872192197103219139") };
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
public class A231650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231650Inst Instance=new A231650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231651
{
public static readonly long[] Value={ 3L,3L,3L,9L,35L,9L,22L,104L,104L,22L,51L,341L,920L,341L,51L,121L,1189L,7682L,7682L,1189L,121L,292L,4040L,61574L,137961L,61574L,4040L,292L,704L,13560L,490760L,2412274L,2412274L,490760L,13560L,704L,1691L,45803L,3929027L,42882766L,96014413L,42882766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231651Inst : IEnumerable<long>
{
public static readonly long[] Value=A231651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231651.Bytes);
public long this[int i]=>Value[i];

public static A231651Inst Instance=new A231651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231652
{
public static readonly long[] Value={ 5L,11L,17L,29L,71L,197L,269L,1277L,1289L,1607L,2027L,2111L,2267L,2687L,3467L,4649L,6359L,6761L,6827L,7877L,9461L,10529L,12917L,13337L,13691L,13829L,13931L,17291L,17579L,20441L,20771L,26249L,29021L,29129L,34589L,34649L,38237L,39239L,44027L,47417L,49547L,51347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231652Inst : IEnumerable<long>
{
public static readonly long[] Value=A231652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231652.Bytes);
public long this[int i]=>Value[i];

public static A231652Inst Instance=new A231652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231653
{
public static readonly long[] Value={ 0L,0L,4L,41L,244L,1029L,3485L,9926L,25030L,57126L,120570L,238330L,446344L,797825L,1370684L,2274259L,3660612L,5734776L,8771181L,13127940L,19270240L,27789713L,39435814L,55142010L,76066910L,103627784L,139554142L,185929971L,245260890L,320527585L,415268815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231653Inst : IEnumerable<long>
{
public static readonly long[] Value=A231653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231653.Bytes);
public long this[int i]=>Value[i];

public static A231653Inst Instance=new A231653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231654
{
public static readonly long[] Value={ 0L,0L,2L,48L,526L,3450L,16536L,63104L,204202L,580669L,1491096L,3520768L,7754502L,16098425L,31770760L,59998736L,109022244L,191454654L,326158974L,540703008L,874630262L,1383621756L,2144889472L,3263884272L,4882793214L,7190910467L,10437526372L,14947411024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231654Inst : IEnumerable<long>
{
public static readonly long[] Value=A231654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231654.Bytes);
public long this[int i]=>Value[i];

public static A231654Inst Instance=new A231654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231655
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,4L,6L,4L,2L,1L,1L,3L,10L,25L,41L,48L,41L,25L,10L,3L,1L,1L,4L,22L,87L,244L,526L,870L,1110L,1110L,870L,526L,244L,87L,22L,4L,1L,1L,5L,41L,238L,1029L,3450L,9147L,19524L,34104L,49231L,59038L,59038L,49231L,34104L,19524L,9147L,3450L,1029L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231655Inst : IEnumerable<long>
{
public static readonly long[] Value=A231655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231655.Bytes);
public long this[int i]=>Value[i];

public static A231655Inst Instance=new A231655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231656
{
public static readonly BigInteger[] Value={ 3L,15L,1197L,345519L,434469343L,2825994465190L,92942728755412088L,BigInteger.Parse("14666832942979847986346"),BigInteger.Parse("11206356242764353017982723900") };
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
public class A231656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231656Inst Instance=new A231656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231657
{
public static readonly long[] Value={ 3L,15L,93L,458L,2163L,10789L,53813L,265397L,1311447L,6493700L,32130833L,158937397L,786355013L,3890673454L,19249161646L,95235762295L,471186213619L,2331226488364L,11533889645847L,57064690337149L,282331462742945L,1396854097460108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231657Inst : IEnumerable<long>
{
public static readonly long[] Value=A231657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231657.Bytes);
public long this[int i]=>Value[i];

public static A231657Inst Instance=new A231657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231658
{
public static readonly long[] Value={ 9L,93L,1197L,13434L,144465L,1607589L,17962078L,199451319L,2215334132L,24630393761L,273787728195L,3042987314978L,33822943262208L,375948173660383L,4178682035747595L,46446248901585653L,516253337817244309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231658Inst : IEnumerable<long>
{
public static readonly long[] Value=A231658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231658.Bytes);
public long this[int i]=>Value[i];

public static A231658Inst Instance=new A231658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231659
{
public static readonly BigInteger[] Value={ 22L,458L,13434L,345519L,8300390L,206363144L,5175246459L,128866716238L,3207643017150L,79935039912485L,1991696428397289L,49618927570423938L,1236219496604319805L,BigInteger.Parse("30799762343804253281"),BigInteger.Parse("767351257510286891977") };
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
public class A231659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231659Inst Instance=new A231659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231660
{
public static readonly BigInteger[] Value={ 51L,2163L,144465L,8300390L,434469343L,23632808750L,1304771142134L,71426776678405L,3902799543486962L,213611346097185990L,11693195116075740433UL,BigInteger.Parse("639903225251107962333"),BigInteger.Parse("35018805296966170944821"),BigInteger.Parse("1916494358794580661283650") };
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
public class A231660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231660Inst Instance=new A231660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231661
{
public static readonly BigInteger[] Value={ 121L,10789L,1607589L,206363144L,23632808750L,2825994465190L,344368908016123L,41555342706134920L,5000894272327355414L,BigInteger.Parse("603091853962176844424"),BigInteger.Parse("72751735500292340340157"),BigInteger.Parse("8772519253282465553808508") };
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
public class A231661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231661Inst Instance=new A231661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231662
{
public static readonly BigInteger[] Value={ 292L,53813L,17962078L,5175246459L,1304771142134L,344368908016123L,92942728755412088L,BigInteger.Parse("24824481518301027324"),BigInteger.Parse("6607709887190748201068"),BigInteger.Parse("1762843521573188604964896"),BigInteger.Parse("470500753688617535877145830") };
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
public class A231662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231662Inst Instance=new A231662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231663
{
public static readonly long[] Value={ 3L,3L,3L,9L,15L,9L,22L,93L,93L,22L,51L,458L,1197L,458L,51L,121L,2163L,13434L,13434L,2163L,121L,292L,10789L,144465L,345519L,144465L,10789L,292L,704L,53813L,1607589L,8300390L,8300390L,1607589L,53813L,704L,1691L,265397L,17962078L,206363144L,434469343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231663Inst : IEnumerable<long>
{
public static readonly long[] Value=A231663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231663.Bytes);
public long this[int i]=>Value[i];

public static A231663Inst Instance=new A231663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231664
{
public static readonly long[] Value={ 0L,1L,3L,6L,7L,9L,12L,16L,18L,21L,25L,30L,33L,37L,42L,48L,49L,51L,54L,58L,60L,63L,67L,72L,75L,79L,84L,90L,94L,99L,105L,112L,114L,117L,121L,126L,129L,133L,138L,144L,148L,153L,159L,166L,171L,177L,184L,192L,195L,199L,204L,210L,214L,219L,225L,232L,237L,243L,250L,258L,264L,271L,279L,288L,289L,291L,294L,298L,300L,303L,307L,312L,315L,319L,324L,330L,334L,339L,345L,352L,354L,357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231664Inst : IEnumerable<long>
{
public static readonly long[] Value=A231664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231664.Bytes);
public long this[int i]=>Value[i];

public static A231664Inst Instance=new A231664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231665
{
public static readonly long[] Value={ 0L,1L,5L,14L,15L,19L,28L,44L,48L,57L,73L,98L,107L,123L,148L,184L,185L,189L,198L,214L,218L,227L,243L,268L,277L,293L,318L,354L,370L,395L,431L,480L,484L,493L,509L,534L,543L,559L,584L,620L,636L,661L,697L,746L,771L,807L,856L,920L,929L,945L,970L,1006L,1022L,1047L,1083L,1132L,1157L,1193L,1242L,1306L,1342L,1391L,1455L,1536L,1537L,1541L,1550L,1566L,1570L,1579L,1595L,1620L,1629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231665Inst : IEnumerable<long>
{
public static readonly long[] Value=A231665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231665.Bytes);
public long this[int i]=>Value[i];

public static A231665Inst Instance=new A231665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231666
{
public static readonly long[] Value={ 0L,1L,9L,36L,37L,45L,72L,136L,144L,171L,235L,360L,387L,451L,576L,792L,793L,801L,828L,892L,900L,927L,991L,1116L,1143L,1207L,1332L,1548L,1612L,1737L,1953L,2296L,2304L,2331L,2395L,2520L,2547L,2611L,2736L,2952L,3016L,3141L,3357L,3700L,3825L,4041L,4384L,4896L,4923L,4987L,5112L,5328L,5392L,5517L,5733L,6076L,6201L,6417L,6760L,7272L,7488L,7831L,8343L,9072L,9073L,9081L,9108L,9172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231666Inst : IEnumerable<long>
{
public static readonly long[] Value=A231666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231666.Bytes);
public long this[int i]=>Value[i];

public static A231666Inst Instance=new A231666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231667
{
public static readonly long[] Value={ 0L,1L,17L,98L,99L,115L,196L,452L,468L,549L,805L,1430L,1511L,1767L,2392L,3688L,3689L,3705L,3786L,4042L,4058L,4139L,4395L,5020L,5101L,5357L,5982L,7278L,7534L,8159L,9455L,11856L,11872L,11953L,12209L,12834L,12915L,13171L,13796L,15092L,15348L,15973L,17269L,19670L,20295L,21591L,23992L,28088L,28169L,28425L,29050L,30346L,30602L,31227L,32523L,34924L,35549L,36845L,39246L,43342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231667Inst : IEnumerable<long>
{
public static readonly long[] Value=A231667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231667.Bytes);
public long this[int i]=>Value[i];

public static A231667Inst Instance=new A231667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231668
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,11L,13L,16L,20L,25L,27L,30L,34L,39L,45L,48L,52L,57L,63L,70L,74L,79L,85L,92L,100L,101L,103L,106L,110L,115L,117L,120L,124L,129L,135L,138L,142L,147L,153L,160L,164L,169L,175L,182L,190L,195L,201L,208L,216L,225L,227L,230L,234L,239L,245L,248L,252L,257L,263L,270L,274L,279L,285L,292L,300L,305L,311L,318L,326L,335L,341L,348L,356L,365L,375L,378L,382L,387L,393L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231668Inst : IEnumerable<long>
{
public static readonly long[] Value=A231668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231668.Bytes);
public long this[int i]=>Value[i];

public static A231668Inst Instance=new A231668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231669
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,31L,35L,44L,60L,85L,89L,98L,114L,139L,175L,184L,200L,225L,261L,310L,326L,351L,387L,436L,500L,501L,505L,514L,530L,555L,559L,568L,584L,609L,645L,654L,670L,695L,731L,780L,796L,821L,857L,906L,970L,995L,1031L,1080L,1144L,1225L,1229L,1238L,1254L,1279L,1315L,1324L,1340L,1365L,1401L,1450L,1466L,1491L,1527L,1576L,1640L,1665L,1701L,1750L,1814L,1895L,1931L,1980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231669Inst : IEnumerable<long>
{
public static readonly long[] Value=A231669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231669.Bytes);
public long this[int i]=>Value[i];

public static A231669Inst Instance=new A231669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231670
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,101L,109L,136L,200L,325L,333L,360L,424L,549L,765L,792L,856L,981L,1197L,1540L,1604L,1729L,1945L,2288L,2800L,2801L,2809L,2836L,2900L,3025L,3033L,3060L,3124L,3249L,3465L,3492L,3556L,3681L,3897L,4240L,4304L,4429L,4645L,4988L,5500L,5625L,5841L,6184L,6696L,7425L,7433L,7460L,7524L,7649L,7865L,7892L,7956L,8081L,8297L,8640L,8704L,8829L,9045L,9388L,9900L,10025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231670Inst : IEnumerable<long>
{
public static readonly long[] Value=A231670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231670.Bytes);
public long this[int i]=>Value[i];

public static A231670Inst Instance=new A231670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231671
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,355L,371L,452L,708L,1333L,1349L,1430L,1686L,2311L,3607L,3688L,3944L,4569L,5865L,8266L,8522L,9147L,10443L,12844L,16940L,16941L,16957L,17038L,17294L,17919L,17935L,18016L,18272L,18897L,20193L,20274L,20530L,21155L,22451L,24852L,25108L,25733L,27029L,29430L,33526L,34151L,35447L,37848L,41944L,48505L,48521L,48602L,48858L,49483L,50779L,50860L,51116L,51741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231671Inst : IEnumerable<long>
{
public static readonly long[] Value=A231671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231671.Bytes);
public long this[int i]=>Value[i];

public static A231671Inst Instance=new A231671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231672
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,16L,18L,21L,25L,30L,36L,38L,41L,45L,50L,56L,63L,66L,70L,75L,81L,88L,96L,100L,105L,111L,118L,126L,135L,140L,146L,153L,161L,170L,180L,181L,183L,186L,190L,195L,201L,203L,206L,210L,215L,221L,228L,231L,235L,240L,246L,253L,261L,265L,270L,276L,283L,291L,300L,305L,311L,318L,326L,335L,345L,351L,358L,366L,375L,385L,396L,398L,401L,405L,410L,416L,423L,426L,430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231672Inst : IEnumerable<long>
{
public static readonly long[] Value=A231672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231672.Bytes);
public long this[int i]=>Value[i];

public static A231672Inst Instance=new A231672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231673
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,55L,56L,60L,69L,85L,110L,146L,150L,159L,175L,200L,236L,285L,294L,310L,335L,371L,420L,484L,500L,525L,561L,610L,674L,755L,780L,816L,865L,929L,1010L,1110L,1111L,1115L,1124L,1140L,1165L,1201L,1205L,1214L,1230L,1255L,1291L,1340L,1349L,1365L,1390L,1426L,1475L,1539L,1555L,1580L,1616L,1665L,1729L,1810L,1835L,1871L,1920L,1984L,2065L,2165L,2201L,2250L,2314L,2395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231673Inst : IEnumerable<long>
{
public static readonly long[] Value=A231673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231673.Bytes);
public long this[int i]=>Value[i];

public static A231673Inst Instance=new A231673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231674
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,225L,226L,234L,261L,325L,450L,666L,674L,701L,765L,890L,1106L,1449L,1476L,1540L,1665L,1881L,2224L,2736L,2800L,2925L,3141L,3484L,3996L,4725L,4850L,5066L,5409L,5921L,6650L,7650L,7651L,7659L,7686L,7750L,7875L,8091L,8099L,8126L,8190L,8315L,8531L,8874L,8901L,8965L,9090L,9306L,9649L,10161L,10225L,10350L,10566L,10909L,11421L,12150L,12275L,12491L,12834L,13346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231674Inst : IEnumerable<long>
{
public static readonly long[] Value=A231674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231674.Bytes);
public long this[int i]=>Value[i];

public static A231674Inst Instance=new A231674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231675
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,979L,980L,996L,1077L,1333L,1958L,3254L,3270L,3351L,3607L,4232L,5528L,7929L,8010L,8266L,8891L,10187L,12588L,16684L,16940L,17565L,18861L,21262L,25358L,31919L,32544L,33840L,36241L,40337L,46898L,56898L,56899L,56915L,56996L,57252L,57877L,59173L,59189L,59270L,59526L,60151L,61447L,63848L,63929L,64185L,64810L,66106L,68507L,72603L,72859L,73484L,74780L,77181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231675Inst : IEnumerable<long>
{
public static readonly long[] Value=A231675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231675.Bytes);
public long this[int i]=>Value[i];

public static A231675Inst Instance=new A231675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231676
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,22L,24L,27L,31L,36L,42L,49L,51L,54L,58L,63L,69L,76L,84L,87L,91L,96L,102L,109L,117L,126L,130L,135L,141L,148L,156L,165L,175L,180L,186L,193L,201L,210L,220L,231L,237L,244L,252L,261L,271L,282L,294L,295L,297L,300L,304L,309L,315L,322L,324L,327L,331L,336L,342L,349L,357L,360L,364L,369L,375L,382L,390L,399L,403L,408L,414L,421L,429L,438L,448L,453L,459L,466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231676Inst : IEnumerable<long>
{
public static readonly long[] Value=A231676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231676.Bytes);
public long this[int i]=>Value[i];

public static A231676Inst Instance=new A231676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231677
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,55L,91L,92L,96L,105L,121L,146L,182L,231L,235L,244L,260L,285L,321L,370L,434L,443L,459L,484L,520L,569L,633L,714L,730L,755L,791L,840L,904L,985L,1085L,1110L,1146L,1195L,1259L,1340L,1440L,1561L,1597L,1646L,1710L,1791L,1891L,2012L,2156L,2157L,2161L,2170L,2186L,2211L,2247L,2296L,2300L,2309L,2325L,2350L,2386L,2435L,2499L,2508L,2524L,2549L,2585L,2634L,2698L,2779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231677Inst : IEnumerable<long>
{
public static readonly long[] Value=A231677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231677.Bytes);
public long this[int i]=>Value[i];

public static A231677Inst Instance=new A231677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231678
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,225L,441L,442L,450L,477L,541L,666L,882L,1225L,1233L,1260L,1324L,1449L,1665L,2008L,2520L,2547L,2611L,2736L,2952L,3295L,3807L,4536L,4600L,4725L,4941L,5284L,5796L,6525L,7525L,7650L,7866L,8209L,8721L,9450L,10450L,11781L,11997L,12340L,12852L,13581L,14581L,15912L,17640L,17641L,17649L,17676L,17740L,17865L,18081L,18424L,18432L,18459L,18523L,18648L,18864L,19207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231678Inst : IEnumerable<long>
{
public static readonly long[] Value=A231678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231678.Bytes);
public long this[int i]=>Value[i];

public static A231678Inst Instance=new A231678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231679
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,979L,2275L,2276L,2292L,2373L,2629L,3254L,4550L,6951L,6967L,7048L,7304L,7929L,9225L,11626L,15722L,15803L,16059L,16684L,17980L,20381L,24477L,31038L,31294L,31919L,33215L,35616L,39712L,46273L,56273L,56898L,58194L,60595L,64691L,71252L,81252L,95893L,97189L,99590L,103686L,110247L,120247L,134888L,155624L,155625L,155641L,155722L,155978L,156603L,157899L,160300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231679Inst : IEnumerable<long>
{
public static readonly long[] Value=A231679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231679.Bytes);
public long this[int i]=>Value[i];

public static A231679Inst Instance=new A231679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231680
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,29L,31L,34L,38L,43L,49L,56L,64L,66L,69L,73L,78L,84L,91L,99L,108L,111L,115L,120L,126L,133L,141L,150L,160L,164L,169L,175L,182L,190L,199L,209L,220L,225L,231L,238L,246L,255L,265L,276L,288L,294L,301L,309L,318L,328L,339L,351L,364L,371L,379L,388L,398L,409L,421L,434L,448L,449L,451L,454L,458L,463L,469L,476L,484L,486L,489L,493L,498L,504L,511L,519L,528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231680Inst : IEnumerable<long>
{
public static readonly long[] Value=A231680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231680.Bytes);
public long this[int i]=>Value[i];

public static A231680Inst Instance=new A231680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231681
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,55L,91L,140L,141L,145L,154L,170L,195L,231L,280L,344L,348L,357L,373L,398L,434L,483L,547L,628L,637L,653L,678L,714L,763L,827L,908L,1008L,1024L,1049L,1085L,1134L,1198L,1279L,1379L,1500L,1525L,1561L,1610L,1674L,1755L,1855L,1976L,2120L,2156L,2205L,2269L,2350L,2450L,2571L,2715L,2884L,2933L,2997L,3078L,3178L,3299L,3443L,3612L,3808L,3809L,3813L,3822L,3838L,3863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231681Inst : IEnumerable<long>
{
public static readonly long[] Value=A231681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231681.Bytes);
public long this[int i]=>Value[i];

public static A231681Inst Instance=new A231681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231682
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,225L,441L,784L,785L,793L,820L,884L,1009L,1225L,1568L,2080L,2088L,2115L,2179L,2304L,2520L,2863L,3375L,4104L,4131L,4195L,4320L,4536L,4879L,5391L,6120L,7120L,7184L,7309L,7525L,7868L,8380L,9109L,10109L,11440L,11565L,11781L,12124L,12636L,13365L,14365L,15696L,17424L,17640L,17983L,18495L,19224L,20224L,21555L,23283L,25480L,25823L,26335L,27064L,28064L,29395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231682Inst : IEnumerable<long>
{
public static readonly long[] Value=A231682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231682.Bytes);
public long this[int i]=>Value[i];

public static A231682Inst Instance=new A231682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231683
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,979L,2275L,4676L,4677L,4693L,4774L,5030L,5655L,6951L,9352L,13448L,13464L,13545L,13801L,14426L,15722L,18123L,22219L,28780L,28861L,29117L,29742L,31038L,33439L,37535L,44096L,54096L,54352L,54977L,56273L,58674L,62770L,69331L,79331L,93972L,94597L,95893L,98294L,102390L,108951L,118951L,133592L,154328L,155624L,158025L,162121L,168682L,178682L,193323L,214059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231683Inst : IEnumerable<long>
{
public static readonly long[] Value=A231683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231683.Bytes);
public long this[int i]=>Value[i];

public static A231683Inst Instance=new A231683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231684
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,37L,39L,42L,46L,51L,57L,64L,72L,81L,83L,86L,90L,95L,101L,108L,116L,125L,135L,138L,142L,147L,153L,160L,168L,177L,187L,198L,202L,207L,213L,220L,228L,237L,247L,258L,270L,275L,281L,288L,296L,305L,315L,326L,338L,351L,357L,364L,372L,381L,391L,402L,414L,427L,441L,448L,456L,465L,475L,486L,498L,511L,525L,540L,548L,557L,567L,578L,590L,603L,617L,632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231684Inst : IEnumerable<long>
{
public static readonly long[] Value=A231684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231684.Bytes);
public long this[int i]=>Value[i];

public static A231684Inst Instance=new A231684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231685
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,55L,91L,140L,204L,205L,209L,218L,234L,259L,295L,344L,408L,489L,493L,502L,518L,543L,579L,628L,692L,773L,873L,882L,898L,923L,959L,1008L,1072L,1153L,1253L,1374L,1390L,1415L,1451L,1500L,1564L,1645L,1745L,1866L,2010L,2035L,2071L,2120L,2184L,2265L,2365L,2486L,2630L,2799L,2835L,2884L,2948L,3029L,3129L,3250L,3394L,3563L,3759L,3808L,3872L,3953L,4053L,4174L,4318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231685Inst : IEnumerable<long>
{
public static readonly long[] Value=A231685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231685.Bytes);
public long this[int i]=>Value[i];

public static A231685Inst Instance=new A231685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231686
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,225L,441L,784L,1296L,1297L,1305L,1332L,1396L,1521L,1737L,2080L,2592L,3321L,3329L,3356L,3420L,3545L,3761L,4104L,4616L,5345L,6345L,6372L,6436L,6561L,6777L,7120L,7632L,8361L,9361L,10692L,10756L,10881L,11097L,11440L,11952L,12681L,13681L,15012L,16740L,16865L,17081L,17424L,17936L,18665L,19665L,20996L,22724L,24921L,25137L,25480L,25992L,26721L,27721L,29052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231686Inst : IEnumerable<long>
{
public static readonly long[] Value=A231686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231686.Bytes);
public long this[int i]=>Value[i];

public static A231686Inst Instance=new A231686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231687
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,979L,2275L,4676L,8772L,8773L,8789L,8870L,9126L,9751L,11047L,13448L,17544L,24105L,24121L,24202L,24458L,25083L,26379L,28780L,32876L,39437L,49437L,49518L,49774L,50399L,51695L,54096L,58192L,64753L,74753L,89394L,89650L,90275L,91571L,93972L,98068L,104629L,114629L,129270L,150006L,150631L,151927L,154328L,158424L,164985L,174985L,189626L,210362L,238923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231687Inst : IEnumerable<long>
{
public static readonly long[] Value=A231687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231687.Bytes);
public long this[int i]=>Value[i];

public static A231687Inst Instance=new A231687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231688
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,225L,441L,784L,1296L,2025L,2026L,2034L,2061L,2125L,2250L,2466L,2809L,3321L,4050L,5050L,5058L,5085L,5149L,5274L,5490L,5833L,6345L,7074L,8074L,9405L,9432L,9496L,9621L,9837L,10180L,10692L,11421L,12421L,13752L,15480L,15544L,15669L,15885L,16228L,16740L,17469L,18469L,19800L,21528L,23725L,23850L,24066L,24409L,24921L,25650L,26650L,27981L,29709L,31906L,34650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231688Inst : IEnumerable<long>
{
public static readonly long[] Value=A231688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231688.Bytes);
public long this[int i]=>Value[i];

public static A231688Inst Instance=new A231688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231689
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,979L,2275L,4676L,8772L,15333L,15334L,15350L,15431L,15687L,16312L,17608L,20009L,24105L,30666L,40666L,40682L,40763L,41019L,41644L,42940L,45341L,49437L,55998L,65998L,80639L,80720L,80976L,81601L,82897L,85298L,89394L,95955L,105955L,120596L,141332L,141588L,142213L,143509L,145910L,150006L,156567L,166567L,181208L,201944L,230505L,231130L,232426L,234827L,238923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231689Inst : IEnumerable<long>
{
public static readonly long[] Value=A231689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231689.Bytes);
public long this[int i]=>Value[i];

public static A231689Inst Instance=new A231689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231690
{
public static readonly BigInteger[] Value={ 1L,6L,56L,640L,8158L,111258L,1588544L,23446248L,354855218L,5477342222L,85893429256L,1364577254040L,21916000458014L,355251287893170L,5804407209709312L,95493879511032240L,1580592247322440642L,BigInteger.Parse("26301843121772151254"),BigInteger.Parse("439764358275666481496"),BigInteger.Parse("7384252698468635017936"),BigInteger.Parse("124469446338979722639294") };
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
public class A231690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231690Inst Instance=new A231690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231691
{
public static readonly BigInteger[] Value={ 1L,6L,74L,1476L,41032L,1464672L,63865328L,3290120832L,195537380704L,13169097667584L,991181618539136L,82450282595311104L,7511417235983147008L,BigInteger.Parse("743790032122343820288"),BigInteger.Parse("79541198937597284060672"),BigInteger.Parse("9136079502141558495310848"),BigInteger.Parse("1121720442822518015112749056"),BigInteger.Parse("146607501639123412303738884096"),BigInteger.Parse("20322509742114322789584125210624"),BigInteger.Parse("2978025324234142178848508363882496") };
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
public class A231691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231691Inst Instance=new A231691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231692
{
public static readonly long[] Value={ 0L,1L,1L,1L,5L,13L,1L,27L,19L,451L,199L,4709L,2399L,3467L,29207L,5183L,55411L,221267L,300649L,1628251L,5508127L,259001L,762881L,6460903L,5694791L,11476403L,27820203L,326206681L,5151783667L,69088293143L,146724611903L,2219373406193L,8951357840311L,4575492601111L,328329280711L,4454145077671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231692Inst : IEnumerable<long>
{
public static readonly long[] Value=A231692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231692.Bytes);
public long this[int i]=>Value[i];

public static A231692Inst Instance=new A231692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231693
{
public static readonly long[] Value={ 1L,1L,2L,6L,12L,60L,20L,140L,280L,2520L,2520L,27720L,27720L,360360L,360360L,360360L,720720L,12252240L,4084080L,77597520L,77597520L,11085360L,11085360L,254963280L,84987760L,424938800L,424938800L,11473347600L,80313433200L,2329089562800L,2329089562800L,72201776446800L,144403552893600L,144403552893600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231693Inst : IEnumerable<long>
{
public static readonly long[] Value=A231693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231693.Bytes);
public long this[int i]=>Value[i];

public static A231693Inst Instance=new A231693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231694
{
public static readonly long[] Value={ 4L,28L,272L,1998L,13260L,94996L,691229L,4926082L,35082734L,251198534L,1797886622L,12852933731L,91912956748L,657463618650L,4702487810918L,33632995941197L,240557644773042L,1720590474243847L,12306454228470804L,88021459865552231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231694Inst : IEnumerable<long>
{
public static readonly long[] Value=A231694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231694.Bytes);
public long this[int i]=>Value[i];

public static A231694Inst Instance=new A231694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231695
{
public static readonly BigInteger[] Value={ 16L,272L,5972L,115583L,2049855L,37872601L,711067486L,13223846355L,245394073602L,4563802124823L,84893857186798L,1578413939501222L,29347570955255809L,545714251340861077L,10147343140331608494UL,BigInteger.Parse("188682437852956208517") };
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
public class A231695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231695Inst Instance=new A231695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231696
{
public static readonly BigInteger[] Value={ 50L,1998L,115583L,6074096L,286808607L,14007173906L,696904625544L,34390368202345L,1693611631652448L,83546478885400765L,4121506683565058802L,BigInteger.Parse("203261277285880002250"),BigInteger.Parse("10024941696145652614843"),BigInteger.Parse("494455010365407138814774") };
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
public class A231696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231696Inst Instance=new A231696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231697
{
public static readonly BigInteger[] Value={ 144L,13260L,2049855L,286808607L,34764511754L,4333974317355L,556835183317668L,71067313709831125L,9020067185976407959L,BigInteger.Parse("1146622410485781036080"),BigInteger.Parse("145894809076844042966799"),BigInteger.Parse("18557178929287225291004307") };
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
public class A231697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231697Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231697.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231697Inst Instance=new A231697Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231698
{
public static readonly BigInteger[] Value={ 422L,94996L,37872601L,14007173906L,4333974317355L,1383168339985798L,458723384178436491L,BigInteger.Parse("151028533752547571008"),BigInteger.Parse("49335557302876746551356"),BigInteger.Parse("16145864650820204721710388"),BigInteger.Parse("5292025656827127971428710436") };
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
public class A231698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231698Inst Instance=new A231698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231699
{
public static readonly BigInteger[] Value={ 1268L,691229L,711067486L,696904625544L,556835183317668L,458723384178436491L,BigInteger.Parse("394600405782342943410"),BigInteger.Parse("337091385019548510376164"),BigInteger.Parse("285400541198740304070351399"),BigInteger.Parse("242059566770098900152264298823") };
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
public class A231699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231699Inst Instance=new A231699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231700
{
public static readonly long[] Value={ 4L,4L,4L,16L,28L,16L,50L,272L,272L,50L,144L,1998L,5972L,1998L,144L,422L,13260L,115583L,115583L,13260L,422L,1268L,94996L,2049855L,6074096L,2049855L,94996L,1268L,3823L,691229L,37872601L,286808607L,286808607L,37872601L,691229L,3823L,11472L,4926082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231700Inst : IEnumerable<long>
{
public static readonly long[] Value=A231700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231700.Bytes);
public long this[int i]=>Value[i];

public static A231700Inst Instance=new A231700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231701
{
public static readonly long[] Value={ 109L,111L,123L,135L,147L,159L,161L,173L,185L,197L,208L,210L,222L,234L,246L,258L,260L,272L,284L,296L,307L,319L,321L,333L,345L,357L,369L,371L,383L,395L,406L,418L,420L,432L,444L,456L,468L,470L,482L,494L,505L,517L,529L,531L,543L,555L,567L,579L,581L,593L,604L,616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231701Inst : IEnumerable<long>
{
public static readonly long[] Value=A231701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231701.Bytes);
public long this[int i]=>Value[i];

public static A231701Inst Instance=new A231701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231702
{
public static readonly BigInteger[] Value={ 5L,87L,2840L,332529L,115091431L,108702736653L,302778325808865L,2471353666263112035L,BigInteger.Parse("58118910922698278619927"),BigInteger.Parse("3968246179910884317349374115"),BigInteger.Parse("787645110600810210613646674667649") };
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
public class A231702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231702Inst Instance=new A231702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231703
{
public static readonly long[] Value={ 5L,17L,42L,121L,351L,978L,2768L,7851L,22168L,62688L,177333L,501398L,1417871L,4009693L,11338691L,32064185L,90673442L,256411571L,725096165L,2050472356L,5798450868L,16397214669L,46369052496L,131125251872L,370804035439L,1048582421408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231703Inst : IEnumerable<long>
{
public static readonly long[] Value=A231703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231703.Bytes);
public long this[int i]=>Value[i];

public static A231703Inst Instance=new A231703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231704
{
public static readonly long[] Value={ 17L,87L,387L,1903L,9352L,45126L,218976L,1063266L,5157832L,25029089L,121453256L,589322201L,2859633713L,13876023287L,67331513300L,326717840479L,1585356878661L,7692742049748L,37328056194113L,181129653079705L,878908640782024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231704Inst : IEnumerable<long>
{
public static readonly long[] Value=A231704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231704.Bytes);
public long this[int i]=>Value[i];

public static A231704Inst Instance=new A231704Inst();

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