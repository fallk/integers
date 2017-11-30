using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A093907
{
public static readonly long[] Value={ 2L,8L,8L,18L,18L,32L,32L,50L,50L,72L,72L,98L,98L,128L,128L,162L,162L,200L,200L,242L,242L,288L,288L,338L,338L,392L,392L,450L,450L,512L,512L,578L,578L,648L,648L,722L,722L,800L,800L,882L,882L,968L,968L,1058L,1058L,1152L,1152L,1250L,1250L,1352L,1352L,1458L,1458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093907Inst : IEnumerable<long>
{
public static readonly long[] Value=A093907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093907.Bytes);
public long this[int i]=>Value[i];

public static A093907Inst Instance=new A093907Inst();

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

public static class A094148
{
public static readonly long[] Value={ 7L,9L,2L,4L,8L,1L,2L,5L,0L,3L,6L,0L,5L,7L,8L,0L,9L,0L,7L,2L,6L,8L,6L,9L,4L,7L,1L,9L,7L,3L,9L,0L,8L,2L,5L,4L,3L,7L,9L,9L,0L,7L,2L,0L,3L,8L,4L,6L,2L,4L,0L,5L,3L,0L,2L,2L,7L,8L,7L,6L,3L,2L,7L,2L,7L,0L,5L,4L,9L,1L,1L,3L,8L,9L,7L,1L,7L,9L,2L,8L,1L,2L,6L,1L,1L,4L,0L,2L,3L,7L,4L,5L,9L,0L,4L,4L,1L,2L,1L,0L,4L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094148Inst : IEnumerable<long>
{
public static readonly long[] Value=A094148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094148.Bytes);
public long this[int i]=>Value[i];

public static A094148Inst Instance=new A094148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094149
{
public static readonly long[] Value={ 1L,3L,12L,57L,303L,1747L,10727L,69331L,467963L,3280353L,23785699L,177877932L,1368977132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094149Inst : IEnumerable<long>
{
public static readonly long[] Value=A094149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094149.Bytes);
public long this[int i]=>Value[i];

public static A094149Inst Instance=new A094149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094150
{
public static readonly long[] Value={ 5L,13L,12L,3L,11L,10L,15L,3L,14L,3L,5L,18L,13L,4L,18L,18L,5L,2L,4L,3L,12L,10L,21L,12L,18L,16L,11L,19L,20L,4L,6L,12L,13L,6L,6L,5L,3L,16L,5L,12L,12L,11L,18L,16L,18L,17L,12L,5L,12L,12L,18L,19L,14L,4L,5L,12L,18L,10L,16L,6L,13L,17L,21L,19L,6L,13L,19L,4L,3L,7L,15L,10L,21L,4L,18L,3L,5L,20L,11L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094150Inst : IEnumerable<long>
{
public static readonly long[] Value=A094150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094150.Bytes);
public long this[int i]=>Value[i];

public static A094150Inst Instance=new A094150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094151
{
public static readonly long[] Value={ 0L,1L,0L,3L,4L,3L,4L,7L,0L,9L,4L,3L,12L,9L,9L,7L,1L,9L,7L,19L,12L,15L,18L,15L,24L,9L,0L,11L,27L,9L,7L,7L,15L,9L,9L,27L,29L,21L,21L,39L,22L,33L,5L,15L,9L,39L,45L,39L,39L,49L,27L,51L,33L,27L,4L,23L,15L,49L,49L,39L,32L,13L,54L,7L,9L,15L,41L,59L,0L,39L,47L,63L,41L,17L,24L,23L,37L,21L,75L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094151Inst : IEnumerable<long>
{
public static readonly long[] Value=A094151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094151.Bytes);
public long this[int i]=>Value[i];

public static A094151Inst Instance=new A094151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094152
{
public static readonly long[] Value={ 3L,3L,15L,1L,5L,6L,5L,24L,10L,6L,7L,6L,5L,4L,7L,5L,3L,5L,6L,16L,5L,6L,5L,28L,6L,3L,5L,36L,7L,15L,4L,15L,7L,7L,8L,7L,7L,5L,7L,14L,5L,6L,19L,16L,17L,5L,4L,12L,5L,8L,10L,17L,5L,5L,8L,10L,3L,5L,7L,30L,5L,5L,20L,3L,5L,6L,6L,4L,9L,9L,3L,9L,5L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094152Inst : IEnumerable<long>
{
public static readonly long[] Value=A094152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094152.Bytes);
public long this[int i]=>Value[i];

public static A094152Inst Instance=new A094152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094153
{
public static readonly long[] Value={ 7L,0L,2L,43L,11L,13L,31L,149L,347L,23L,439L,223L,461L,173L,5L,71L,197L,1153L,191L,307L,1657L,971L,9473L,19L,2399L,1607L,6781L,89L,9187L,281L,23623L,15077L,25579L,17203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094153Inst : IEnumerable<long>
{
public static readonly long[] Value=A094153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094153.Bytes);
public long this[int i]=>Value[i];

public static A094153Inst Instance=new A094153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094154
{
public static readonly BigInteger[] Value={ 1L,4L,54L,2246L,164950L,18423144L,2905943328L,615376173184L,168483518571798L,57926238289970076L,BigInteger.Parse("24434798429947993054"),BigInteger.Parse("12408968034664788792008"),BigInteger.Parse("7468360391233437715595634"),BigInteger.Parse("5256695596753687250025931048"),BigInteger.Parse("4278271932454694494134007741950"),BigInteger.Parse("3986830862631720154048770746485900") };
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
public class A094154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094154Inst Instance=new A094154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094155
{
public static readonly BigInteger[] Value={ 2L,14L,332L,18264L,1664354L,222406776L,40865005494L,9880209206458L,3041127561315224L,1161157777643184900L,BigInteger.Parse("538583682082245127336"),BigInteger.Parse("298292500833816420226008"),BigInteger.Parse("194444097328912809590995986"),BigInteger.Parse("147362699895662080130636012160"),BigInteger.Parse("128481853971530055408959624233748"),BigInteger.Parse("127695847335468919414701788927638656") };
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
public class A094155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094155Inst Instance=new A094155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094156
{
public static readonly BigInteger[] Value={ 1L,4L,39L,1219L,83435L,9223092L,1453132944L,307690667072L,84241805734539L,28963120073957838L,12217399235411398127UL,BigInteger.Parse("6204484017822892034404"),BigInteger.Parse("3734180195629471796396217"),BigInteger.Parse("2628347798377200707293720724"),BigInteger.Parse("2139135966227357959535426526975"),BigInteger.Parse("1993415431315860419823374898234950") };
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
public class A094156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094156Inst Instance=new A094156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094157
{
public static readonly BigInteger[] Value={ 2L,12L,202L,9468L,836017L,111255228L,20433309147L,4940118795869L,1520564059349452L,580578894859915650L,BigInteger.Parse("269291841184184374868"),BigInteger.Parse("149146250420586942401004"),BigInteger.Parse("97222048664558428304285193"),BigInteger.Parse("73681349947834075264704425280"),BigInteger.Parse("64240926985765124116695616020874"),BigInteger.Parse("63847923667734462963941294951243328") };
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
public class A094157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094157Inst Instance=new A094157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094158
{
public static readonly long[] Value={ 1L,2L,5L,13L,19L,32L,53L,89L,139L,199L,293L,887L,1129L,1331L,5591L,8467L,9551L,15683L,19609L,31397L,155921L,360653L,370261L,492113L,1349533L,1357201L,2010733L,4652353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094158Inst : IEnumerable<long>
{
public static readonly long[] Value=A094158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094158.Bytes);
public long this[int i]=>Value[i];

public static A094158Inst Instance=new A094158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094159
{
public static readonly long[] Value={ 0L,3L,18L,45L,84L,135L,198L,273L,360L,459L,570L,693L,828L,975L,1134L,1305L,1488L,1683L,1890L,2109L,2340L,2583L,2838L,3105L,3384L,3675L,3978L,4293L,4620L,4959L,5310L,5673L,6048L,6435L,6834L,7245L,7668L,8103L,8550L,9009L,9480L,9963L,10458L,10965L,11484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094159Inst : IEnumerable<long>
{
public static readonly long[] Value=A094159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094159.Bytes);
public long this[int i]=>Value[i];

public static A094159Inst Instance=new A094159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094160
{
public static readonly long[] Value={ 0L,4L,76L,344L,936L,1980L,3604L,5936L,9104L,13236L,18460L,24904L,32696L,41964L,52836L,65440L,79904L,96356L,114924L,135736L,158920L,184604L,212916L,243984L,277936L,314900L,355004L,398376L,445144L,495436L,549380L,607104L,668736L,734404L,804236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094160Inst : IEnumerable<long>
{
public static readonly long[] Value=A094160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094160.Bytes);
public long this[int i]=>Value[i];

public static A094160Inst Instance=new A094160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094161
{
public static readonly long[] Value={ 0L,5L,315L,2670L,10810L,30475L,69405L,137340L,246020L,409185L,642575L,963930L,1392990L,1951495L,2663185L,3553800L,4651080L,5984765L,7586595L,9490310L,11731650L,14348355L,17380165L,20868820L,24858060L,29393625L,34523255L,40296690L,46765670L,53983935L,62007225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094161Inst : IEnumerable<long>
{
public static readonly long[] Value=A094161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094161.Bytes);
public long this[int i]=>Value[i];

public static A094161Inst Instance=new A094161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094162
{
public static readonly long[] Value={ 1L,6L,26L,78L,390L,2262L,7878L,30966L,154830L,890214L,3127566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094162Inst : IEnumerable<long>
{
public static readonly long[] Value=A094162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094162.Bytes);
public long this[int i]=>Value[i];

public static A094162Inst Instance=new A094162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094163
{
public static readonly long[] Value={ 14L,26L,28L,30L,35L,36L,39L,41L,42L,43L,46L,47L,48L,54L,56L,58L,59L,65L,66L,67L,73L,74L,75L,76L,77L,81L,82L,83L,85L,86L,88L,89L,90L,91L,93L,97L,98L,99L,100L,101L,102L,105L,106L,107L,108L,109L,116L,121L,122L,123L,124L,125L,127L,130L,131L,133L,134L,135L,140L,141L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094163Inst : IEnumerable<long>
{
public static readonly long[] Value=A094163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094163.Bytes);
public long this[int i]=>Value[i];

public static A094163Inst Instance=new A094163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094164
{
public static readonly long[] Value={ 1L,3L,9L,28L,90L,282L,875L,2700L,8271L,25265L,77088L,235014L,716261L,2182257L,6646200L,20234080L,61581327L,187366482L,569947883L,1733389620L,5270937735L,16025807017L,48719131461L,148092422604L,450116618125L,1367983011213L,4157227183617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094164Inst : IEnumerable<long>
{
public static readonly long[] Value=A094164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094164.Bytes);
public long this[int i]=>Value[i];

public static A094164Inst Instance=new A094164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094165
{
public static readonly long[] Value={ 1L,6L,33L,176L,930L,4884L,25564L,133512L,696231L,3626710L,18876363L,98186556L,510472118L,2652899130L,13782560610L,71585293504L,371724613716L,1929911381586L,10018066789546L,51996091023360L,269839578888159L,1400217128810676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094165Inst : IEnumerable<long>
{
public static readonly long[] Value=A094165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094165.Bytes);
public long this[int i]=>Value[i];

public static A094165Inst Instance=new A094165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094166
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,9L,1L,5L,18L,28L,1L,6L,30L,76L,90L,1L,7L,33L,180L,315L,282L,1L,8L,42L,176L,1075L,1296L,875L,1L,9L,60L,252L,930L,6366L,5320L,2700L,1L,10L,81L,440L,1505L,4884L,37520L,21800L,8271L,1L,11L,105L,732L,3230L,8946L,25564L,220500L,89190L,25265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094166Inst : IEnumerable<long>
{
public static readonly long[] Value=A094166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094166.Bytes);
public long this[int i]=>Value[i];

public static A094166Inst Instance=new A094166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094167
{
public static readonly long[] Value={ 1L,5L,30L,180L,1075L,6366L,37520L,220500L,1293615L,7581240L,44398387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094167Inst : IEnumerable<long>
{
public static readonly long[] Value=A094167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094167.Bytes);
public long this[int i]=>Value[i];

public static A094167Inst Instance=new A094167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094168
{
public static readonly long[] Value={ 1L,7L,42L,252L,1505L,8946L,53165L,315980L,1878597L,11171930L,66456082L,395399760L,2352979538L,14004512886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094168Inst : IEnumerable<long>
{
public static readonly long[] Value=A094168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094168.Bytes);
public long this[int i]=>Value[i];

public static A094168Inst Instance=new A094168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094169
{
public static readonly long[] Value={ 1L,8L,60L,440L,3230L,23688L,173796L,1275240L,9359748L,68708320L,504466468L,3704376384L,27205146592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094169Inst : IEnumerable<long>
{
public static readonly long[] Value=A094169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094169.Bytes);
public long this[int i]=>Value[i];

public static A094169Inst Instance=new A094169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094170
{
public static readonly long[] Value={ 0L,0L,1L,10L,33L,88L,187L,360L,625L,1024L,1581L,2350L,3361L,4680L,6343L,8428L,10977L,14080L,17785L,22194L,27361L,33400L,40371L,48400L,57553L,67968L,79717L,92950L,107745L,124264L,142591L,162900L,185281L,209920L,236913L,266458L,298657L,333720L,371755L,412984L,457521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094170Inst : IEnumerable<long>
{
public static readonly long[] Value=A094170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094170.Bytes);
public long this[int i]=>Value[i];

public static A094170Inst Instance=new A094170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094171
{
public static readonly long[] Value={ 0L,0L,1L,20L,147L,670L,2239L,6138L,14531L,30904L,60369L,110300L,190671L,314910L,500247L,768810L,110300L,190671L,314910L,500247L,768810L,1147959L,1671648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094171Inst : IEnumerable<long>
{
public static readonly long[] Value=A094171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094171.Bytes);
public long this[int i]=>Value[i];

public static A094171Inst Instance=new A094171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094172
{
public static readonly long[] Value={ 0L,0L,0L,21L,390L,3427L,18380L,73413L,237459L,659774L,1629116L,3666785L,7651680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094172Inst : IEnumerable<long>
{
public static readonly long[] Value=A094172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094172.Bytes);
public long this[int i]=>Value[i];

public static A094172Inst Instance=new A094172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094173
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,5L,3L,6L,7L,4L,3L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094173Inst : IEnumerable<long>
{
public static readonly long[] Value=A094173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094173.Bytes);
public long this[int i]=>Value[i];

public static A094173Inst Instance=new A094173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094174
{
public static readonly long[] Value={ 1L,6L,0L,3L,4L,17L,14L,21L,23L,24L,34L,43L,44L,54L,74L,84L,97L,94L,174L,184L,197L,194L,274L,284L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094174Inst : IEnumerable<long>
{
public static readonly long[] Value=A094174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094174.Bytes);
public long this[int i]=>Value[i];

public static A094174Inst Instance=new A094174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094175
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,6L,4L,3L,3L,3L,2L,2L,2L,2L,10L,7L,6L,5L,4L,4L,3L,3L,3L,3L,10L,8L,6L,6L,5L,4L,4L,4L,3L,3L,10L,8L,7L,6L,6L,5L,5L,4L,4L,4L,10L,9L,7L,7L,6L,6L,5L,5L,4L,4L,10L,9L,8L,7L,6L,6L,6L,5L,5L,5L,10L,9L,8L,7L,7L,6L,6L,6L,5L,5L,10L,9L,8L,8L,7L,7L,6L,6L,6L,5L,10L,9L,8L,8L,7L,7L,6L,6L,6L,6L,100L,51L,34L,26L,21L,18L,15L,13L,12L,11L,55L,37L,28L,23L,19L,16L,15L,13L,12L,11L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094175Inst : IEnumerable<long>
{
public static readonly long[] Value=A094175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094175.Bytes);
public long this[int i]=>Value[i];

public static A094175Inst Instance=new A094175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094176
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,5L,15L,43L,127L,383L,1143L,3423L,10264L,30785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094176Inst : IEnumerable<long>
{
public static readonly long[] Value=A094176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094176.Bytes);
public long this[int i]=>Value[i];

public static A094176Inst Instance=new A094176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094177
{
public static readonly long[] Value={ 4L,3L,4L,9L,21L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094177Inst : IEnumerable<long>
{
public static readonly long[] Value=A094177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094177.Bytes);
public long this[int i]=>Value[i];

public static A094177Inst Instance=new A094177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094178
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,13L,15L,16L,18L,21L,22L,24L,25L,27L,28L,31L,34L,36L,37L,39L,42L,43L,45L,46L,48L,49L,51L,55L,57L,58L,60L,64L,66L,67L,69L,70L,72L,73L,76L,78L,79L,81L,84L,87L,88L,91L,93L,94L,97L,99L,100L,102L,105L,106L,108L,111L,112L,114L,115L,120L,121L,123L,126L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094178Inst : IEnumerable<long>
{
public static readonly long[] Value=A094178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094178.Bytes);
public long this[int i]=>Value[i];

public static A094178Inst Instance=new A094178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094179
{
public static readonly long[] Value={ 3L,7L,11L,19L,23L,27L,31L,43L,47L,59L,63L,67L,71L,79L,83L,99L,103L,107L,127L,131L,139L,147L,151L,163L,167L,171L,179L,191L,199L,207L,211L,223L,227L,231L,239L,243L,251L,263L,271L,279L,283L,307L,311L,331L,343L,347L,359L,363L,367L,379L,383L,387L,399L,419L,423L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094179Inst : IEnumerable<long>
{
public static readonly long[] Value=A094179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094179.Bytes);
public long this[int i]=>Value[i];

public static A094179Inst Instance=new A094179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094180
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,11L,12L,15L,16L,17L,18L,20L,21L,25L,26L,27L,32L,33L,35L,37L,38L,41L,42L,43L,45L,48L,50L,52L,53L,56L,57L,58L,60L,61L,63L,66L,68L,70L,71L,77L,78L,83L,86L,87L,90L,91L,92L,95L,96L,97L,100L,105L,106L,108L,110L,111L,116L,117L,120L,121L,122L,123L,125L,126L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094180Inst : IEnumerable<long>
{
public static readonly long[] Value=A094180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094180.Bytes);
public long this[int i]=>Value[i];

public static A094180Inst Instance=new A094180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094181
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,8L,5L,16L,18L,36L,9L,48L,11L,80L,77L,88L,15L,144L,17L,168L,153L,216L,21L,256L,110L,308L,207L,352L,27L,484L,29L,416L,377L,540L,341L,648L,35L,680L,525L,768L,39L,1020L,41L,912L,819L,1008L,45L,1216L,322L,1320L,893L,1288L,51L,1656L,765L,1536L,1113L,1620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094181Inst : IEnumerable<long>
{
public static readonly long[] Value=A094181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094181.Bytes);
public long this[int i]=>Value[i];

public static A094181Inst Instance=new A094181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094182
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,6L,5L,7L,6L,10L,7L,12L,9L,8L,15L,14L,15L,9L,11L,10L,20L,18L,13L,21L,11L,21L,12L,15L,22L,28L,13L,24L,30L,17L,14L,26L,35L,15L,33L,36L,19L,35L,30L,16L,30L,42L,21L,17L,40L,33L,39L,45L,44L,18L,34L,23L,45L,19L,20L,25L,39L,38L,55L,52L,56L,21L,27L,42L,22L,63L,51L,55L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094182Inst : IEnumerable<long>
{
public static readonly long[] Value=A094182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094182.Bytes);
public long this[int i]=>Value[i];

public static A094182Inst Instance=new A094182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094183
{
public static readonly long[] Value={ 6L,15L,20L,28L,45L,35L,42L,66L,72L,91L,63L,120L,77L,110L,153L,88L,99L,104L,190L,156L,231L,117L,143L,130L,210L,276L,170L,325L,272L,195L,165L,378L,209L,187L,342L,435L,255L,204L,496L,238L,221L,228L,420L,299L,561L,323L,247L,506L,630L,273L,350L,304L,266L,285L,703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094183Inst : IEnumerable<long>
{
public static readonly long[] Value=A094183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094183.Bytes);
public long this[int i]=>Value[i];

public static A094183Inst Instance=new A094183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094184
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,0L,1L,3L,1L,-1L,1L,4L,3L,-2L,0L,1L,5L,6L,-2L,-2L,2L,1L,6L,10L,0L,-6L,4L,0L,1L,7L,15L,5L,-11L,3L,5L,-5L,1L,8L,21L,14L,-15L,-4L,15L,-10L,0L,1L,9L,28L,28L,-15L,-19L,26L,-6L,-14L,14L,1L,10L,36L,48L,-7L,-42L,30L,16L,-42L,28L,0L,1L,11L,45L,75L,14L,-70L,16L,60L,-70L,14L,42L,-42L,1L,12L,55L,110L,54L,-96L,-28L,120L,-70L,-56L,126L,-84L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094184Inst : IEnumerable<long>
{
public static readonly long[] Value=A094184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094184.Bytes);
public long this[int i]=>Value[i];

public static A094184Inst Instance=new A094184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094185
{
public static readonly long[] Value={ 1L,6L,12L,24L,24L,49L,41L,59L,61L,100L,56L,132L,76L,127L,122L,165L,87L,223L,95L,207L,176L,190L,110L,318L,187L,232L,211L,342L,137L,440L,127L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094185Inst : IEnumerable<long>
{
public static readonly long[] Value=A094185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094185.Bytes);
public long this[int i]=>Value[i];

public static A094185Inst Instance=new A094185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094186
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094186Inst : IEnumerable<long>
{
public static readonly long[] Value=A094186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094186.Bytes);
public long this[int i]=>Value[i];

public static A094186Inst Instance=new A094186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094187
{
public static readonly BigInteger[] Value={ 1L,35L,2271L,218793L,28137345L,4539496635L,882318678255L,200816025228945L,52409174427470385L,15432871959522241875UL,BigInteger.Parse("5062570863876165491775"),BigInteger.Parse("1830983671801954093988025"),BigInteger.Parse("723885864573750477727953825") };
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
public class A094187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094187Inst Instance=new A094187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094188
{
public static readonly long[] Value={ 1L,0L,3L,2L,8L,10L,23L,36L,69L,116L,208L,356L,621L,1064L,1831L,3126L,5336L,9070L,15395L,26060L,44041L,74280L,125088L,210312L,353113L,592080L,991563L,1658666L,2771624L,4626706L,7716143L,12857076L,21405261L,35608604L,59192176L,98325356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094188Inst : IEnumerable<long>
{
public static readonly long[] Value=A094188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094188.Bytes);
public long this[int i]=>Value[i];

public static A094188Inst Instance=new A094188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094189
{
public static readonly long[] Value={ 0L,2L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,3L,2L,2L,2L,3L,4L,4L,3L,4L,3L,3L,4L,5L,4L,3L,4L,5L,4L,4L,5L,4L,4L,5L,5L,2L,6L,6L,5L,4L,6L,4L,5L,7L,7L,3L,7L,8L,4L,5L,10L,7L,5L,6L,5L,5L,10L,7L,8L,8L,6L,10L,7L,5L,5L,8L,7L,7L,5L,10L,7L,8L,10L,7L,7L,10L,10L,9L,12L,7L,11L,10L,10L,9L,7L,13L,11L,10L,10L,11L,10L,11L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094189Inst : IEnumerable<long>
{
public static readonly long[] Value=A094189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094189.Bytes);
public long this[int i]=>Value[i];

public static A094189Inst Instance=new A094189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094190
{
public static readonly long[] Value={ 0L,25L,376L,9376L,90625L,109376L,2890625L,12890625L,212890625L,1787109376L,18212890625L,918212890625L,9918212890625L,40081787109376L,259918212890625L,3740081787109376L,43740081787109376L,256259918212890625L,2256259918212890625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094190Inst : IEnumerable<long>
{
public static readonly long[] Value=A094190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094190.Bytes);
public long this[int i]=>Value[i];

public static A094190Inst Instance=new A094190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094191
{
public static readonly long[] Value={ 3L,15L,45L,96L,192L,240L,576L,480L,720L,960L,12288L,1440L,3600L,3840L,2880L,3360L,20736L,5040L,147456L,6720L,11520L,14400L,50331648L,10080L,25920L,245760L,25200L,26880L,3221225472L,20160L,57600L,30240L,184320L,3932160L,103680L,40320L,129600L,2985984L,737280L,60480L,13194139533312L,80640L,52776558133248L,430080L,100800L,251658240L,84934656L,110880L,921600L,181440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094191Inst : IEnumerable<long>
{
public static readonly long[] Value=A094191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094191.Bytes);
public long this[int i]=>Value[i];

public static A094191Inst Instance=new A094191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094192
{
public static readonly long[] Value={ 2L,3L,4L,4L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094192Inst : IEnumerable<long>
{
public static readonly long[] Value=A094192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094192.Bytes);
public long this[int i]=>Value[i];

public static A094192Inst Instance=new A094192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094193
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,1L,5L,2L,4L,6L,1L,3L,5L,7L,2L,4L,8L,1L,3L,7L,9L,2L,4L,6L,8L,10L,1L,5L,7L,11L,2L,4L,6L,8L,10L,12L,1L,3L,5L,9L,11L,13L,2L,4L,8L,14L,1L,3L,5L,7L,9L,11L,13L,15L,2L,4L,6L,8L,10L,12L,14L,16L,1L,5L,7L,11L,13L,17L,2L,4L,6L,8L,10L,12L,14L,16L,18L,1L,3L,7L,9L,11L,13L,17L,19L,2L,4L,8L,10L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094193Inst : IEnumerable<long>
{
public static readonly long[] Value=A094193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094193.Bytes);
public long this[int i]=>Value[i];

public static A094193Inst Instance=new A094193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094194
{
public static readonly long[] Value={ 5L,13L,17L,25L,29L,41L,37L,61L,53L,65L,85L,65L,73L,89L,113L,85L,97L,145L,101L,109L,149L,181L,125L,137L,157L,185L,221L,145L,169L,193L,265L,173L,185L,205L,233L,269L,313L,197L,205L,221L,277L,317L,365L,229L,241L,289L,421L,257L,265L,281L,305L,337L,377L,425L,481L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094194Inst : IEnumerable<long>
{
public static readonly long[] Value=A094194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094194.Bytes);
public long this[int i]=>Value[i];

public static A094194Inst Instance=new A094194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094195
{
public static readonly long[] Value={ 1L,3L,10L,42L,199L,981L,4888L,24420L,122077L,610359L,3051766L,15258798L,76293955L,381469737L,1907348644L,9536743176L,47683715833L,238418579115L,1192092895522L,5960464477554L,29802322387711L,149011611938493L,745058059692400L,3725290298461932L,18626451492309589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094195Inst : IEnumerable<long>
{
public static readonly long[] Value=A094195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094195.Bytes);
public long this[int i]=>Value[i];

public static A094195Inst Instance=new A094195Inst();

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

public static class A094564
{
public static readonly long[] Value={ 6L,10L,15L,16L,24L,26L,30L,39L,40L,42L,48L,63L,65L,68L,78L,80L,102L,104L,105L,110L,120L,126L,130L,165L,168L,170L,178L,195L,204L,208L,210L,267L,272L,273L,275L,288L,312L,315L,330L,336L,340L,432L,440L,442L,445L,466L,504L,510L,520L,534L,544L,546L,550L,699L,712L,714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094564Inst : IEnumerable<long>
{
public static readonly long[] Value=A094564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094564.Bytes);
public long this[int i]=>Value[i];

public static A094564Inst Instance=new A094564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094565
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,13L,15L,16L,21L,34L,39L,40L,42L,55L,89L,102L,104L,105L,110L,144L,233L,267L,272L,273L,275L,288L,377L,610L,699L,712L,714L,715L,720L,754L,987L,1597L,1830L,1864L,1869L,1870L,1872L,1885L,1974L,2584L,4181L,4791L,4880L,4893L,4895L,4896L,4901L,4935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094565Inst : IEnumerable<long>
{
public static readonly long[] Value=A094565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094565.Bytes);
public long this[int i]=>Value[i];

public static A094565Inst Instance=new A094565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094566
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,8L,9L,10L,13L,21L,24L,25L,26L,34L,55L,63L,64L,65L,68L,89L,144L,165L,168L,169L,170L,178L,233L,377L,432L,440L,441L,442L,445L,466L,610L,987L,1131L,1152L,1155L,1156L,1157L,1165L,1220L,1597L,2584L,2961L,3016L,3024L,3025L,3026L,3029L,3050L,3194L,4181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094566Inst : IEnumerable<long>
{
public static readonly long[] Value=A094566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094566.Bytes);
public long this[int i]=>Value[i];

public static A094566Inst Instance=new A094566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094567
{
public static readonly long[] Value={ 1L,4L,30L,203L,1394L,9552L,65473L,448756L,3075822L,21081995L,144498146L,990405024L,6788337025L,46527954148L,318907342014L,2185823439947L,14981856737618L,102687173723376L,703828359326017L,4824111341558740L,33064951031585166L,226630545879537419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094567Inst : IEnumerable<long>
{
public static readonly long[] Value=A094567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094567.Bytes);
public long this[int i]=>Value[i];

public static A094567Inst Instance=new A094567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094568
{
public static readonly long[] Value={ 2L,3L,5L,8L,10L,13L,21L,24L,26L,34L,55L,63L,65L,68L,89L,144L,165L,168L,170L,178L,233L,377L,432L,440L,442L,445L,466L,610L,987L,1131L,1152L,1155L,1157L,1165L,1220L,1597L,2584L,2961L,3016L,3024L,3026L,3029L,3050L,3194L,4181L,6765L,7752L,7896L,7917L,7920L,7922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094568Inst : IEnumerable<long>
{
public static readonly long[] Value=A094568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094568.Bytes);
public long this[int i]=>Value[i];

public static A094568Inst Instance=new A094568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094569
{
public static readonly long[] Value={ 2L,11L,78L,532L,3649L,25008L,171410L,1174859L,8052606L,55193380L,378301057L,2592914016L,17772097058L,121811765387L,834910260654L,5722560059188L,39223010153665L,268838511016464L,1842646566961586L,12629687457714635L,86565165637040862L,593326472001571396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094569Inst : IEnumerable<long>
{
public static readonly long[] Value=A094569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094569.Bytes);
public long this[int i]=>Value[i];

public static A094569Inst Instance=new A094569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094570
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,3L,2L,3L,3L,5L,4L,3L,3L,4L,5L,8L,6L,4L,4L,4L,6L,8L,13L,9L,6L,5L,5L,6L,9L,13L,21L,14L,9L,7L,6L,7L,9L,14L,21L,34L,22L,14L,10L,8L,8L,10L,14L,22L,34L,55L,35L,22L,15L,11L,10L,11L,15L,22L,35L,55L,89L,56L,35L,23L,16L,13L,13L,16L,23L,35L,56L,89L,144L,90L,56L,36L,24L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094570Inst : IEnumerable<long>
{
public static readonly long[] Value=A094570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094570.Bytes);
public long this[int i]=>Value[i];

public static A094570Inst Instance=new A094570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094571
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,4L,2L,2L,4L,9L,5L,2L,5L,9L,25L,10L,5L,5L,10L,25L,64L,26L,10L,8L,10L,26L,64L,169L,65L,26L,13L,13L,26L,65L,169L,441L,170L,65L,29L,18L,29L,65L,170L,441L,1156L,442L,170L,68L,34L,34L,68L,170L,442L,1156L,3025L,1157L,442L,173L,73L,50L,73L,173L,442L,1157L,3025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094571Inst : IEnumerable<long>
{
public static readonly long[] Value=A094571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094571.Bytes);
public long this[int i]=>Value[i];

public static A094571Inst Instance=new A094571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094572
{
public static readonly long[] Value={ 2L,0L,4L,2L,4L,0L,4L,4L,6L,0L,4L,4L,4L,0L,8L,6L,4L,0L,4L,4L,8L,0L,4L,8L,6L,0L,8L,4L,4L,0L,4L,8L,8L,0L,8L,6L,4L,0L,8L,8L,4L,0L,4L,4L,12L,0L,4L,12L,6L,0L,8L,4L,4L,0L,8L,8L,8L,0L,4L,8L,4L,0L,12L,10L,8L,0L,4L,4L,8L,0L,4L,12L,4L,0L,12L,4L,8L,0L,4L,12L,10L,0L,4L,8L,8L,0L,8L,8L,4L,0L,8L,4L,8L,0L,8L,16L,4L,0L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094572Inst : IEnumerable<long>
{
public static readonly long[] Value=A094572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094572.Bytes);
public long this[int i]=>Value[i];

public static A094572Inst Instance=new A094572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094573
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,12L,20L,7L,1L,39L,169L,186L,59L,3L,1L,120L,1160L,2755L,2243L,661L,55L,1L,363L,7381L,33270L,52060L,33604L,9167L,910L,15L,1L,1092L,45500L,367087L,988750L,1126874L,601262L,151726L,16401L,525L,1L,3279L,276529L,3873786L,17005149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094573Inst : IEnumerable<long>
{
public static readonly long[] Value=A094573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094573.Bytes);
public long this[int i]=>Value[i];

public static A094573Inst Instance=new A094573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094574
{
public static readonly BigInteger[] Value={ 1L,1L,5L,40L,457L,6995L,136771L,3299218L,95668354L,3268445951L,129468914524L,5868774803537L,301122189141524L,17327463910351045L,1109375488487304027L,BigInteger.Parse("78484513540137938209"),BigInteger.Parse("6098627708074641312182"),BigInteger.Parse("517736625823888411991202") };
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
public class A094574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094574Inst Instance=new A094574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094575
{
public static readonly long[] Value={ 2L,3L,5L,7L,16L,21L,25L,29L,41L,43L,46L,67L,73L,78L,89L,92L,105L,111L,127L,141L,154L,157L,171L,188L,191L,205L,210L,211L,221L,229L,232L,239L,241L,267L,277L,300L,305L,309L,313L,316L,323L,326L,331L,346L,369L,379L,415L,421L,430L,436L,441L,443L,451L,460L,461L,465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094575Inst : IEnumerable<long>
{
public static readonly long[] Value=A094575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094575.Bytes);
public long this[int i]=>Value[i];

public static A094575Inst Instance=new A094575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094576
{
public static readonly long[] Value={ 3L,4L,5L,6L,8L,14L,17L,20L,22L,26L,30L,42L,44L,47L,68L,74L,79L,86L,90L,93L,101L,106L,112L,122L,128L,142L,155L,158L,172L,189L,192L,200L,206L,211L,212L,218L,222L,230L,233L,240L,242L,268L,275L,278L,301L,306L,310L,314L,317L,324L,327L,332L,338L,344L,347L,370L,380L,416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094576Inst : IEnumerable<long>
{
public static readonly long[] Value=A094576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094576.Bytes);
public long this[int i]=>Value[i];

public static A094576Inst Instance=new A094576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094577
{
public static readonly BigInteger[] Value={ 1L,3L,27L,409L,9089L,272947L,10515147L,501178937L,28773452321L,1949230218691L,153281759047387L,13806215066685433L,1408621900803060705L,BigInteger.Parse("161278353358629226675"),BigInteger.Parse("20555596673435403499083"),BigInteger.Parse("2896227959507289559616217"),BigInteger.Parse("448371253145121338801335489") };
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
public class A094577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094577Inst Instance=new A094577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094578
{
public static readonly long[] Value={ 0L,0L,1L,4L,19L,76L,316L,1264L,5101L,20404L,81796L,327184L,1309444L,5237776L,20953936L,83815744L,335274259L,1341097036L,5364433276L,21457733104L,85831112764L,343324451056L,1373298525616L,5493194102464L,21972779294716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094578Inst : IEnumerable<long>
{
public static readonly long[] Value=A094578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094578.Bytes);
public long this[int i]=>Value[i];

public static A094578Inst Instance=new A094578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094579
{
public static readonly long[] Value={ 1L,3L,31L,1145L,154881L,77899563L,147226330175L,1053765855157617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094579Inst : IEnumerable<long>
{
public static readonly long[] Value=A094579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094579.Bytes);
public long this[int i]=>Value[i];

public static A094579Inst Instance=new A094579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094596
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,7L,1L,0L,0L,2L,1L,1L,0L,3L,2L,1L,2L,2L,1L,0L,0L,3L,0L,1L,2L,1L,8L,0L,0L,3L,3L,0L,0L,1L,0L,0L,0L,4L,1L,0L,0L,0L,1L,2L,0L,5L,3L,2L,0L,0L,0L,3L,1L,3L,2L,0L,0L,0L,6L,1L,0L,5L,3L,1L,0L,1L,0L,0L,0L,4L,2L,0L,2L,0L,2L,1L,0L,2L,1L,2L,0L,2L,0L,0L,0L,3L,0L,1L,0L,0L,2L,0L,0L,2L,1L,1L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094596Inst : IEnumerable<long>
{
public static readonly long[] Value=A094596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094596.Bytes);
public long this[int i]=>Value[i];

public static A094596Inst Instance=new A094596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094597
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,5L,1L,0L,0L,2L,1L,1L,0L,2L,2L,1L,2L,2L,1L,0L,0L,3L,0L,1L,2L,1L,6L,0L,0L,2L,3L,0L,0L,1L,0L,0L,0L,3L,1L,0L,0L,0L,1L,2L,0L,5L,2L,2L,0L,0L,0L,2L,1L,2L,2L,0L,0L,0L,4L,1L,0L,3L,2L,1L,0L,1L,0L,0L,0L,3L,2L,0L,2L,0L,2L,1L,0L,2L,1L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,2L,0L,0L,2L,1L,1L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094597Inst : IEnumerable<long>
{
public static readonly long[] Value=A094597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094597.Bytes);
public long this[int i]=>Value[i];

public static A094597Inst Instance=new A094597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094598
{
public static readonly long[] Value={ 3L,5L,6L,9L,10L,14L,21L,22L,24L,29L,30L,33L,34L,36L,37L,38L,41L,42L,43L,46L,50L,51L,52L,57L,58L,59L,62L,66L,68L,69L,70L,73L,75L,78L,82L,84L,85L,86L,88L,90L,91L,93L,94L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094598Inst : IEnumerable<long>
{
public static readonly long[] Value=A094598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094598.Bytes);
public long this[int i]=>Value[i];

public static A094598Inst Instance=new A094598Inst();

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