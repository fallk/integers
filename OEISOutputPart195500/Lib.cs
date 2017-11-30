using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A246162
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,8L,11L,7L,6L,9L,13L,14L,31L,47L,17L,25L,12L,10L,19L,15L,37L,59L,20L,21L,61L,185L,42L,319L,62L,24L,87L,137L,34L,18L,55L,16L,41L,97L,27L,22L,67L,229L,49L,415L,76L,28L,103L,29L,109L,425L,78L,1627L,222L,54L,283L,3053L,373L,79L,433L,33L,131L,647L,108L,1123L,166L,45L,203L,26L,91L,379L,71L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246162Inst : IEnumerable<long>
{
public static readonly long[] Value=A246162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246162.Bytes);
public long this[int i]=>Value[i];

public static A246162Inst Instance=new A246162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246163
{
public static readonly long[] Value={ 1L,2L,7L,3L,6L,9L,8L,5L,10L,27L,4L,24L,11L,15L,30L,45L,12L,40L,26L,29L,17L,34L,119L,20L,25L,120L,46L,39L,51L,102L,14L,153L,60L,43L,136L,114L,31L,105L,85L,170L,44L,18L,427L,68L,125L,408L,13L,150L,33L,187L,255L,510L,116L,54L,41L,765L,204L,135L,28L,680L,16L,23L,442L,99L,461L,257L,35L,514L,156L,90L,123L,1799L,118L,340L,393L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246163Inst : IEnumerable<long>
{
public static readonly long[] Value=A246163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246163.Bytes);
public long this[int i]=>Value[i];

public static A246163Inst Instance=new A246163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246164
{
public static readonly long[] Value={ 1L,2L,4L,11L,8L,5L,3L,7L,6L,9L,13L,17L,47L,31L,14L,61L,21L,42L,185L,24L,87L,319L,62L,12L,25L,19L,10L,59L,20L,15L,37L,229L,49L,22L,67L,76L,415L,103L,28L,18L,55L,137L,34L,41L,16L,27L,97L,78L,425L,109L,29L,1627L,222L,54L,283L,433L,79L,373L,3053L,33L,131L,647L,108L,847L,133L,745L,6943L,44L,193L,1053L,160L,504L,4333L,587L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246164Inst : IEnumerable<long>
{
public static readonly long[] Value=A246164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246164.Bytes);
public long this[int i]=>Value[i];

public static A246164Inst Instance=new A246164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246165
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,6L,11L,5L,12L,10L,17L,9L,23L,16L,19L,8L,29L,18L,35L,15L,28L,25L,41L,14L,31L,34L,30L,24L,51L,27L,59L,13L,44L,43L,47L,26L,67L,52L,58L,22L,77L,42L,83L,38L,49L,61L,89L,21L,70L,46L,73L,53L,99L,45L,69L,37L,88L,75L,111L,40L,119L,85L,72L,20L,94L,64L,127L,63L,103L,68L,137L,39L,143L,97L,79L,78L,106L,87L,151L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246165Inst : IEnumerable<long>
{
public static readonly long[] Value=A246165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246165.Bytes);
public long this[int i]=>Value[i];

public static A246165Inst Instance=new A246165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246166
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,5L,16L,12L,10L,7L,9L,32L,24L,20L,14L,11L,18L,15L,64L,48L,40L,13L,28L,22L,36L,30L,21L,17L,27L,25L,128L,96L,26L,19L,80L,56L,44L,72L,60L,23L,42L,34L,33L,54L,50L,35L,256L,45L,192L,29L,38L,52L,160L,112L,88L,144L,39L,31L,120L,46L,84L,68L,66L,108L,100L,37L,70L,55L,49L,512L,63L,51L,90L,58L,384L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246166Inst : IEnumerable<long>
{
public static readonly long[] Value=A246166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246166.Bytes);
public long this[int i]=>Value[i];

public static A246166Inst Instance=new A246166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246167
{
public static readonly long[] Value={ 1L,2L,5L,21L,46L,55L,66L,91L,574L,1362L,1419L,1654L,3497L,4607L,5263L,6463L,430261L,545869L,554111L,567583L,574823L,589843L,8781429L,14635735L,20490043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246167Inst : IEnumerable<long>
{
public static readonly long[] Value=A246167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246167.Bytes);
public long this[int i]=>Value[i];

public static A246167Inst Instance=new A246167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246168
{
public static readonly long[] Value={ -9L,-8L,-6L,-2L,6L,22L,54L,118L,246L,502L,1014L,2038L,4086L,8182L,16374L,32758L,65526L,131062L,262134L,524278L,1048566L,2097142L,4194294L,8388598L,16777206L,33554422L,67108854L,134217718L,268435446L,536870902L,1073741814L,2147483638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246168Inst : IEnumerable<long>
{
public static readonly long[] Value=A246168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246168.Bytes);
public long this[int i]=>Value[i];

public static A246168Inst Instance=new A246168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246169
{
public static readonly long[] Value={ 2L,5L,1L,7L,5L,4L,0L,3L,5L,2L,6L,3L,2L,0L,0L,3L,8L,9L,0L,7L,9L,5L,3L,5L,4L,5L,9L,8L,4L,6L,3L,4L,4L,7L,2L,7L,7L,3L,3L,5L,9L,8L,1L,2L,6L,6L,8L,0L,3L,1L,1L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246169Inst : IEnumerable<long>
{
public static readonly long[] Value=A246169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246169.Bytes);
public long this[int i]=>Value[i];

public static A246169Inst Instance=new A246169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246170
{
public static readonly long[] Value={ 3L,7L,11L,14L,18L,22L,26L,29L,33L,37L,41L,44L,48L,52L,56L,59L,63L,67L,71L,74L,78L,82L,86L,89L,93L,97L,101L,104L,108L,112L,115L,119L,123L,127L,130L,134L,138L,142L,145L,149L,153L,157L,160L,164L,168L,172L,175L,179L,183L,187L,190L,194L,198L,202L,205L,209L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246170Inst : IEnumerable<long>
{
public static readonly long[] Value=A246170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246170.Bytes);
public long this[int i]=>Value[i];

public static A246170Inst Instance=new A246170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246171
{
public static readonly long[] Value={ 3L,7L,11L,15L,19L,23L,27L,30L,34L,38L,42L,46L,50L,54L,58L,61L,65L,69L,73L,77L,81L,85L,89L,92L,96L,100L,104L,108L,112L,116L,120L,123L,127L,131L,135L,139L,143L,147L,151L,154L,158L,162L,166L,170L,174L,178L,182L,185L,189L,193L,197L,201L,205L,209L,213L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246171Inst : IEnumerable<long>
{
public static readonly long[] Value=A246171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246171.Bytes);
public long this[int i]=>Value[i];

public static A246171Inst Instance=new A246171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246172
{
public static readonly long[] Value={ 1L,7L,14L,22L,31L,41L,52L,64L,77L,91L,106L,122L,139L,157L,176L,196L,217L,239L,262L,286L,311L,337L,364L,392L,421L,451L,482L,514L,547L,581L,616L,652L,689L,727L,766L,806L,847L,889L,932L,976L,1021L,1067L,1114L,1162L,1211L,1261L,1312L,1364L,1417L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246172Inst : IEnumerable<long>
{
public static readonly long[] Value=A246172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246172.Bytes);
public long this[int i]=>Value[i];

public static A246172Inst Instance=new A246172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246173
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,1L,10L,11L,6L,1L,20L,28L,21L,8L,1L,38L,64L,62L,35L,10L,1L,71L,140L,164L,120L,53L,12L,1L,130L,293L,402L,360L,210L,75L,14L,1L,235L,596L,935L,984L,708L,340L,101L,16L,1L,420L,1183L,2086L,2517L,2142L,1280L,518L,131L,18L,1L,744L,2304L,4507L,6120L,5991L,4260L,2164L,752L,165L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246173Inst : IEnumerable<long>
{
public static readonly long[] Value=A246173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246173.Bytes);
public long this[int i]=>Value[i];

public static A246173Inst Instance=new A246173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246174
{
public static readonly long[] Value={ 2L,1L,3L,3L,8L,8L,4L,1L,15L,20L,15L,5L,30L,48L,44L,24L,6L,1L,56L,105L,119L,84L,35L,7L,104L,224L,296L,256L,144L,48L,8L,1L,189L,459L,696L,711L,495L,228L,63L,9L,340L,920L,1570L,1840L,1522L,880L,340L,80L,10L,1L,605L,1804L,3421L,4521L,4312L,2981L,1463L,484L,99L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246174Inst : IEnumerable<long>
{
public static readonly long[] Value=A246174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246174.Bytes);
public long this[int i]=>Value[i];

public static A246174Inst Instance=new A246174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246175
{
public static readonly long[] Value={ 1L,5L,23L,89L,325L,1123L,3750L,12174L,38682L,120750L,371478L,1128810L,3394159L,10112987L,29892425L,87737471L,255912115L,742272853L,2142128604L,6153811500L,17605105380L,50174676300L,142501128540L,403422149220L,1138714934125L,3205372562369L,8999834877995L,25209180070037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246175Inst : IEnumerable<long>
{
public static readonly long[] Value=A246175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246175.Bytes);
public long this[int i]=>Value[i];

public static A246175Inst Instance=new A246175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246176
{
public static readonly long[] Value={ 5L,12L,66L,215L,789L,2597L,8540L,27153L,85135L,262482L,799566L,2408718L,7189343L,21282450L,62550312L,182664881L,530391339L,1532152571L,4405406030L,12613400079L,35974991437L,102242458164L,289632199980L,818005152300L,2303856458345L,6471890313480L,18136792078398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246176Inst : IEnumerable<long>
{
public static readonly long[] Value=A246176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246176.Bytes);
public long this[int i]=>Value[i];

public static A246176Inst Instance=new A246176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246177
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,2L,1L,8L,5L,3L,1L,13L,10L,8L,4L,2L,21L,20L,18L,12L,7L,3L,1L,34L,38L,39L,30L,22L,12L,7L,2L,1L,55L,71L,80L,70L,57L,39L,26L,14L,7L,3L,1L,89L,130L,160L,154L,138L,106L,81L,52L,34L,18L,10L,4L,2L,144L,235L,312L,327L,315L,267L,220L,163L,118L,78L,49L,28L,16L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246177Inst : IEnumerable<long>
{
public static readonly long[] Value=A246177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246177.Bytes);
public long this[int i]=>Value[i];

public static A246177Inst Instance=new A246177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246178
{
public static readonly long[] Value={ 1L,9L,51L,234L,951L,3573L,12707L,43398L,143682L,464148L,1469778L,4578102L,14063653L,42695127L,128301453L,382144446L,1129360689L,3314619171L,9668400839L,28045947996L,80949547380L,232589050920L,665532883380L,1897176603420L,5389368930505L,15260830474869L,43085718922071L,121310066722194L,340684392838971L,954497114903169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246178Inst : IEnumerable<long>
{
public static readonly long[] Value=A246178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246178.Bytes);
public long this[int i]=>Value[i];

public static A246178Inst Instance=new A246178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246179
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,3L,8L,9L,13L,23L,1L,21L,56L,5L,34L,131L,20L,55L,300L,67L,1L,89L,678L,204L,7L,144L,1523L,581L,35L,233L,3416L,1580L,143L,1L,377L,7677L,4155L,517L,9L,610L,17329L,10663L,1716L,54L,987L,39353L,26880L,5352L,259L,1L,1597L,90000L,66891L,15924L,1079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246179Inst : IEnumerable<long>
{
public static readonly long[] Value=A246179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246179.Bytes);
public long this[int i]=>Value[i];

public static A246179Inst Instance=new A246179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246180
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,0L,2L,1L,0L,3L,1L,3L,1L,0L,3L,6L,3L,4L,1L,2L,0L,12L,11L,6L,5L,1L,0L,10L,6L,30L,19L,10L,6L,1L,0L,10L,30L,30L,61L,31L,15L,7L,1L,5L,0L,60L,80L,90L,110L,48L,21L,8L,1L,0L,35L,30L,210L,200L,211L,183L,71L,28L,9L,1L,0L,35L,140L,210L,575L,462L,426L,287L,101L,36L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246180Inst : IEnumerable<long>
{
public static readonly long[] Value=A246180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246180.Bytes);
public long this[int i]=>Value[i];

public static A246180Inst Instance=new A246180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246181
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,2L,0L,1L,1L,3L,3L,0L,1L,3L,3L,6L,4L,0L,1L,3L,12L,6L,10L,5L,0L,1L,6L,14L,30L,10L,15L,6L,0L,1L,11L,30L,40L,60L,15L,21L,7L,0L,1L,15L,65L,90L,90L,105L,21L,28L,8L,0L,1L,31L,95L,225L,210L,175L,168L,28L,36L,9L,0L,1L,50L,216L,350L,595L,420L,308L,252L,36L,45L,10L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246181Inst : IEnumerable<long>
{
public static readonly long[] Value=A246181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246181.Bytes);
public long this[int i]=>Value[i];

public static A246181Inst Instance=new A246181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246182
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,0L,1L,5L,2L,0L,1L,9L,5L,2L,0L,1L,19L,9L,6L,2L,0L,1L,39L,21L,12L,7L,2L,0L,1L,79L,53L,27L,15L,8L,2L,0L,1L,167L,118L,74L,34L,18L,9L,2L,0L,1L,357L,269L,180L,96L,42L,21L,10L,2L,0L,1L,763L,639L,419L,254L,119L,51L,24L,11L,2L,0L,1L,1651L,1486L,1045L,605L,340L,143L,61L,27L,12L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246182Inst : IEnumerable<long>
{
public static readonly long[] Value=A246182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246182.Bytes);
public long this[int i]=>Value[i];

public static A246182Inst Instance=new A246182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246183
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,1L,15L,2L,33L,3L,1L,71L,9L,2L,158L,23L,3L,1L,357L,54L,10L,2L,812L,136L,26L,3L,1L,1869L,338L,63L,11L,2L,4338L,835L,167L,29L,3L,1L,10134L,2087L,428L,72L,12L,2L,23829L,5216L,1092L,199L,32L,3L,1L,56341L,13046L,2826L,523L,81L,13L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246183Inst : IEnumerable<long>
{
public static readonly long[] Value=A246183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246183.Bytes);
public long this[int i]=>Value[i];

public static A246183Inst Instance=new A246183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246184
{
public static readonly long[] Value={ 1L,6L,6L,5L,3L,6L,6L,3L,5L,5L,3L,1L,1L,2L,0L,8L,6L,3L,9L,2L,1L,7L,5L,7L,2L,7L,2L,5L,0L,1L,7L,6L,7L,1L,5L,1L,3L,3L,2L,4L,1L,2L,4L,0L,9L,5L,7L,8L,7L,3L,3L,7L,6L,7L,2L,9L,8L,0L,4L,8L,0L,4L,8L,2L,4L,5L,1L,0L,7L,8L,4L,8L,5L,9L,8L,5L,6L,3L,3L,4L,2L,6L,1L,8L,4L,0L,5L,1L,3L,2L,4L,7L,9L,7L,3L,7L,3L,1L,9L,1L,8L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246184Inst : IEnumerable<long>
{
public static readonly long[] Value=A246184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246184.Bytes);
public long this[int i]=>Value[i];

public static A246184Inst Instance=new A246184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246185
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,2L,1L,8L,5L,3L,1L,13L,10L,8L,5L,1L,21L,20L,18L,14L,8L,1L,34L,38L,39L,35L,26L,12L,1L,55L,71L,80L,80L,70L,49L,17L,1L,89L,130L,160L,174L,169L,142L,90L,23L,1L,144L,235L,312L,365L,385L,363L,290L,158L,30L,1L,233L,420L,598L,745L,840L,861L,785L,588L,264L,38L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246185Inst : IEnumerable<long>
{
public static readonly long[] Value=A246185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246185.Bytes);
public long this[int i]=>Value[i];

public static A246185Inst Instance=new A246185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246186
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,3L,8L,9L,13L,23L,1L,21L,55L,6L,34L,125L,26L,55L,274L,93L,1L,89L,584L,295L,10L,144L,1218L,861L,60L,233L,2496L,2362L,281L,1L,377L,5042L,6176L,1125L,15L,610L,10064L,15542L,4036L,120L,987L,19887L,37906L,13341L,710L,1L,1597L,38963L,90071L,41371L,3479L,21L,2584L,75779L,209357L,121873L,14938L,217L,4181L,146451L,477520L,344160L,58108L,1583L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246186Inst : IEnumerable<long>
{
public static readonly long[] Value=A246186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246186.Bytes);
public long this[int i]=>Value[i];

public static A246186Inst Instance=new A246186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246187
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,0L,5L,1L,0L,0L,4L,9L,1L,0L,0L,0L,17L,14L,1L,0L,0L,0L,8L,46L,20L,1L,0L,0L,0L,0L,49L,100L,27L,1L,0L,0L,0L,0L,16L,180L,190L,35L,1L,0L,0L,0L,0L,0L,129L,510L,329L,44L,1L,0L,0L,0L,0L,0L,32L,603L,1225L,532L,54L,1L,0L,0L,0L,0L,0L,0L,321L,2121L,2618L,816L,65L,1L,0L,0L,0L,0L,0L,0L,64L,1827L,6202L,5124L,1200L,77L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246187Inst : IEnumerable<long>
{
public static readonly long[] Value=A246187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246187.Bytes);
public long this[int i]=>Value[i];

public static A246187Inst Instance=new A246187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246188
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,11L,2L,1L,31L,8L,2L,1L,92L,28L,9L,2L,1L,283L,99L,34L,10L,2L,1L,893L,354L,129L,40L,11L,2L,1L,2875L,1273L,492L,161L,46L,12L,2L,1L,9407L,4598L,1882L,646L,195L,52L,13L,2L,1L,31189L,16679L,7199L,2597L,816L,231L,58L,14L,2L,1L,104555L,60712L,27570L,10400L,3422L,1002L,269L,64L,15L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246188Inst : IEnumerable<long>
{
public static readonly long[] Value=A246188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246188.Bytes);
public long this[int i]=>Value[i];

public static A246188Inst Instance=new A246188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246189
{
public static readonly BigInteger[] Value={ 1L,6L,51L,580L,8265L,141246L,2810437L,63748728L,1622579985L,45775778950L,1417347491241L,47776074289164L,1741386177576409L,68238497945688630L,2860625245955274225L,BigInteger.Parse("127736893134458097136"),BigInteger.Parse("6052712065187733972513"),BigInteger.Parse("303322427195785592735502"),BigInteger.Parse("16028016368907840953165425") };
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
public class A246189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246189Inst Instance=new A246189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246190
{
public static readonly BigInteger[] Value={ 2L,24L,300L,4360L,74130L,1456224L,32562152L,817596000L,22785399450L,697951656160L,23306666102148L,842567564800416L,32781106696806650L,1365579024023558400L,BigInteger.Parse("60639189588419033040"),BigInteger.Parse("2859165143013913590016"),BigInteger.Parse("142651621238828972159538"),BigInteger.Parse("7508140027468431374563200") };
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
public class A246190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246190Inst Instance=new A246190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246191
{
public static readonly BigInteger[] Value={ 6L,120L,2160L,41160L,861420L,19949328L,510320160L,14348862000L,440879024520L,14716697990280L,530761366078944L,20577610843203960L,853717568817968400L,BigInteger.Parse("37746072677473752480"),BigInteger.Parse("1771994498414094109440"),BigInteger.Parse("88032162789004128733152"),BigInteger.Parse("4614300279345812506938720") };
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
public class A246191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246191Inst Instance=new A246191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246192
{
public static readonly BigInteger[] Value={ 24L,720L,17640L,430080L,11022480L,302472576L,8937981360L,284552040960L,9743091569640L,357820740076800L,14051646110285784L,588177615908413440L,BigInteger.Parse("26161789829441054880"),BigInteger.Parse("1232890909824506204160"),BigInteger.Parse("61387038018996808785120"),BigInteger.Parse("3221070809733138102829056") };
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
public class A246192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246192Inst Instance=new A246192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246193
{
public static readonly BigInteger[] Value={ 120L,5040L,161280L,4898880L,151200000L,4870182240L,165549605760L,5964805154880L,228051369786240L,9247246914906000L,397146441431900160L,18033691478872567680UL,BigInteger.Parse("864117601222345666560"),BigInteger.Parse("43606402916521420059840"),BigInteger.Parse("2312912761606956925440000"),BigInteger.Parse("128696545326829348772023680") };
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
public class A246193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246193Inst Instance=new A246193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246194
{
public static readonly BigInteger[] Value={ 720L,40320L,1632960L,60480000L,2213719200L,82771476480L,3211179491520L,130241382036480L,5541589755702000L,247667354552217600L,11627089698327143040UL,BigInteger.Parse("573008938660751523840"),BigInteger.Parse("29613698207957813302080"),BigInteger.Parse("1602975684200327700480000"),BigInteger.Parse("90757379602253683020931200") };
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
public class A246194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246194Inst Instance=new A246194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246195
{
public static readonly BigInteger[] Value={ 5040L,362880L,18144000L,804988800L,34488115200L,1482082842240L,65120246231040L,2955402450000000L,139296260790086400L,6837541748945107200L,BigInteger.Parse("349978565353512775680"),BigInteger.Parse("18685433917574232157440"),BigInteger.Parse("1040347501174674201600000"),BigInteger.Parse("60368458528123335777196800") };
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
public class A246195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246195Inst Instance=new A246195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246196
{
public static readonly BigInteger[] Value={ 40320L,3628800L,219542400L,11496038400L,570031862400L,27908676956160L,1379187810000000L,69648048665395200L,3619848890071814400L,BigInteger.Parse("194427690066299289600"),BigInteger.Parse("10817193383227574703360"),BigInteger.Parse("624124327363867459584000"),BigInteger.Parse("37361601302439627939398400"),BigInteger.Parse("2320453709453248711940505600") };
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
public class A246196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246196Inst Instance=new A246196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246197
{
public static readonly BigInteger[] Value={ 362880L,39916800L,2874009600L,175394419200L,9967384627200L,551675124000000L,30471021291110400L,1703458301210265600L,BigInteger.Parse("97213825272736972800"),BigInteger.Parse("5693251850259515942400"),BigInteger.Parse("343266609438110040883200"),BigInteger.Parse("21349182724237331665228800"),BigInteger.Parse("1371132989012608561874534400") };
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
public class A246197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246197Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246197.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246197Inst Instance=new A246197Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246198
{
public static readonly long[] Value={ 6L,12L,20L,24L,28L,30L,40L,42L,48L,54L,56L,60L,66L,70L,78L,80L,84L,88L,90L,96L,102L,104L,108L,112L,114L,120L,126L,132L,138L,140L,150L,156L,160L,168L,174L,176L,180L,186L,192L,198L,204L,208L,210L,216L,220L,222L,224L,225L,228L,234L,240L,246L,252L,258L,260L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246198Inst : IEnumerable<long>
{
public static readonly long[] Value=A246198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246198.Bytes);
public long this[int i]=>Value[i];

public static A246198Inst Instance=new A246198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246199
{
public static readonly long[] Value={ 225L,441L,1225L,2025L,3969L,5625L,11025L,18225L,21609L,27225L,35721L,38025L,50625L,53361L,65025L,74529L,81225L,99225L,119025L,127449L,140625L,148225L,159201L,164025L,184041L,189225L,194481L,207025L,216225L,233289L,245025L,275625L,308025L,314721L,321489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246199Inst : IEnumerable<long>
{
public static readonly long[] Value=A246199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246199.Bytes);
public long this[int i]=>Value[i];

public static A246199Inst Instance=new A246199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246200
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,19L,14L,15L,16L,17L,18L,13L,20L,21L,22L,27L,24L,35L,38L,23L,28L,39L,30L,31L,32L,33L,34L,25L,36L,41L,26L,29L,40L,37L,42L,43L,44L,75L,54L,59L,48L,67L,70L,51L,76L,83L,46L,55L,56L,71L,78L,47L,60L,79L,62L,63L,64L,65L,66L,49L,68L,81L,50L,57L,72L,73L,82L,45L,52L,77L,58L,61L,80L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246200Inst : IEnumerable<long>
{
public static readonly long[] Value=A246200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246200.Bytes);
public long this[int i]=>Value[i];

public static A246200Inst Instance=new A246200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246201
{
public static readonly long[] Value={ 1L,3L,7L,2L,6L,14L,15L,4L,12L,28L,5L,30L,13L,8L,24L,56L,10L,60L,29L,26L,16L,48L,112L,20L,31L,120L,58L,52L,32L,96L,9L,224L,40L,62L,240L,116L,25L,104L,64L,192L,57L,18L,448L,80L,124L,480L,11L,232L,50L,208L,128L,384L,114L,36L,61L,896L,160L,248L,27L,960L,17L,22L,464L,100L,416L,256L,49L,768L,228L,72L,122L,1792L,113L,320L,496L,54L,1920L,34L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246201Inst : IEnumerable<long>
{
public static readonly long[] Value=A246201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246201.Bytes);
public long this[int i]=>Value[i];

public static A246201Inst Instance=new A246201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246202
{
public static readonly long[] Value={ 1L,4L,2L,8L,11L,5L,3L,14L,31L,17L,47L,9L,13L,6L,7L,21L,61L,42L,185L,24L,87L,62L,319L,15L,37L,20L,59L,10L,19L,12L,25L,29L,109L,78L,425L,54L,283L,222L,1627L,33L,131L,108L,647L,79L,433L,373L,3053L,22L,67L,49L,229L,28L,103L,76L,415L,16L,41L,27L,97L,18L,55L,34L,137L,39L,167L,134L,859L,98L,563L,494L,4225L,70L,375L,331L,2705L,264L,2011L,1832L,19891L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246202Inst : IEnumerable<long>
{
public static readonly long[] Value=A246202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246202.Bytes);
public long this[int i]=>Value[i];

public static A246202Inst Instance=new A246202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246203
{
public static readonly long[] Value={ 1L,7L,3L,6L,2L,14L,15L,24L,8L,30L,13L,28L,5L,12L,4L,10L,56L,60L,29L,26L,16L,112L,48L,96L,9L,32L,52L,58L,120L,20L,31L,128L,208L,232L,50L,36L,61L,114L,384L,960L,17L,464L,22L,160L,896L,248L,27L,62L,240L,40L,224L,64L,104L,116L,25L,124L,80L,480L,11L,192L,57L,448L,18L,1536L,98L,456L,21L,928L,200L,512L,832L,3584L,121L,244L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246203Inst : IEnumerable<long>
{
public static readonly long[] Value=A246203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246203.Bytes);
public long this[int i]=>Value[i];

public static A246203Inst Instance=new A246203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246204
{
public static readonly long[] Value={ 1L,5L,3L,15L,13L,4L,2L,9L,25L,16L,59L,14L,11L,6L,7L,21L,41L,63L,211L,30L,67L,43L,299L,8L,55L,20L,47L,12L,19L,10L,31L,26L,109L,92L,451L,36L,285L,178L,1615L,50L,253L,108L,1019L,93L,477L,370L,3487L,23L,87L,35L,157L,27L,97L,95L,487L,17L,61L,28L,103L,18L,37L,48L,241L,52L,203L,249L,587L,101L,803L,401L,4591L,83L,369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246204Inst : IEnumerable<long>
{
public static readonly long[] Value=A246204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246204.Bytes);
public long this[int i]=>Value[i];

public static A246204Inst Instance=new A246204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246205
{
public static readonly long[] Value={ 1L,2L,7L,5L,3L,11L,23L,15L,4L,12L,22L,33L,6L,52L,17L,13L,35L,43L,25L,16L,137L,45L,53L,36L,58L,155L,29L,47L,462L,154L,66L,135L,37L,152L,426L,30L,8L,156L,1273L,428L,24L,148L,460L,41L,423L,1426L,71L,31L,9L,427L,4283L,1410L,34L,431L,75L,1274L,159L,1423L,21L,3707L,194L,99L,44L,10L,1412L,11115L,64L,3850L,38L,1404L,103L,4281L,26L,412L,3722L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246205Inst : IEnumerable<long>
{
public static readonly long[] Value=A246205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246205.Bytes);
public long this[int i]=>Value[i];

public static A246205Inst Instance=new A246205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246206
{
public static readonly long[] Value={ 1L,2L,5L,9L,4L,13L,3L,37L,49L,64L,6L,10L,16L,81L,8L,20L,15L,351L,229L,451L,59L,11L,7L,41L,19L,73L,92L,114L,27L,36L,48L,140L,12L,53L,17L,24L,33L,69L,86L,107L,44L,170L,18L,63L,22L,410L,28L,524L,76L,271L,101L,14L,23L,687L,529L,895L,253L,25L,97L,213L,145L,333L,3413L,67L,2091L,31L,607L,103L,415L,4531L,47L,131L,87L,193L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246206Inst : IEnumerable<long>
{
public static readonly long[] Value=A246206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246206.Bytes);
public long this[int i]=>Value[i];

public static A246206Inst Instance=new A246206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246207
{
public static readonly long[] Value={ 0L,1L,2L,5L,7L,3L,22L,15L,23L,11L,6L,4L,71L,35L,66L,52L,58L,33L,25L,12L,21L,16L,8L,17L,172L,99L,73L,36L,213L,148L,194L,137L,197L,152L,75L,43L,59L,29L,24L,13L,69L,49L,68L,47L,19L,9L,64L,45L,587L,419L,225L,127L,173L,104L,72L,37L,516L,304L,620L,431L,643L,447L,601L,462L,640L,441L,577L,423L,177L,103L,203L,155L,211L,150L,61L,30L,57L,34L,26L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246207Inst : IEnumerable<long>
{
public static readonly long[] Value=A246207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246207.Bytes);
public long this[int i]=>Value[i];

public static A246207Inst Instance=new A246207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246208
{
public static readonly long[] Value={ 0L,1L,2L,5L,11L,3L,10L,4L,22L,45L,91L,9L,19L,39L,183L,7L,21L,23L,90L,44L,182L,20L,6L,8L,38L,18L,78L,157L,315L,37L,75L,151L,631L,17L,77L,13L,27L,55L,155L,311L,623L,111L,1263L,35L,303L,47L,181L,43L,365L,41L,89L,367L,15L,79L,314L,156L,630L,76L,16L,36L,150L,74L,302L,180L,46L,88L,14L,366L,42L,40L,364L,12L,54L,26L,110L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246208Inst : IEnumerable<long>
{
public static readonly long[] Value=A246208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246208.Bytes);
public long this[int i]=>Value[i];

public static A246208Inst Instance=new A246208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246209
{
public static readonly long[] Value={ 0L,1L,5L,2L,15L,22L,3L,7L,52L,66L,35L,71L,4L,6L,11L,23L,137L,194L,148L,213L,36L,73L,99L,172L,17L,8L,16L,21L,12L,25L,33L,58L,462L,601L,447L,643L,431L,620L,304L,516L,37L,72L,104L,173L,127L,225L,419L,587L,45L,64L,9L,19L,47L,68L,49L,69L,13L,24L,29L,59L,43L,75L,152L,197L,1273L,1734L,1334L,1940L,1294L,1740L,899L,1556L,1404L,1837L,945L,1567L,389L,698L,1246L,1761L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246209Inst : IEnumerable<long>
{
public static readonly long[] Value=A246209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246209.Bytes);
public long this[int i]=>Value[i];

public static A246209Inst Instance=new A246209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246210
{
public static readonly long[] Value={ 0L,1L,3L,6L,12L,2L,13L,7L,25L,50L,100L,14L,28L,56L,200L,4L,26L,24L,101L,51L,201L,27L,5L,15L,57L,29L,113L,226L,452L,58L,116L,232L,904L,30L,114L,10L,20L,40L,228L,456L,912L,80L,1808L,60L,464L,48L,202L,52L,402L,54L,102L,400L,8L,112L,453L,227L,905L,115L,31L,59L,233L,117L,465L,203L,49L,103L,9L,401L,53L,55L,403L,11L,41L,21L,81L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246210Inst : IEnumerable<long>
{
public static readonly long[] Value=A246210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246210.Bytes);
public long this[int i]=>Value[i];

public static A246210Inst Instance=new A246210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246211
{
public static readonly long[] Value={ 0L,1L,5L,22L,71L,2L,35L,15L,99L,225L,531L,66L,213L,516L,1899L,7L,73L,172L,307L,127L,1369L,36L,3L,52L,304L,148L,1246L,5408L,17461L,620L,1567L,5321L,41591L,194L,698L,6L,21L,69L,1489L,5165L,16975L,174L,142234L,643L,17287L,587L,695L,173L,5195L,72L,605L,4770L,23L,1761L,12051L,4175L,24134L,389L,137L,431L,3758L,945L,11964L,392L,419L,482L,11L,2872L,104L,37L,3830L,4L,49L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246211Inst : IEnumerable<long>
{
public static readonly long[] Value=A246211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246211.Bytes);
public long this[int i]=>Value[i];

public static A246211Inst Instance=new A246211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246212
{
public static readonly long[] Value={ 1L,9L,93L,1155L,17025L,292383L,5752131L,127790505L,3167896005L,86756071545L,2602658092419L,84917405260779L,2994675198208785L,113538315994418175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246212Inst : IEnumerable<long>
{
public static readonly long[] Value=A246212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246212.Bytes);
public long this[int i]=>Value[i];

public static A246212Inst Instance=new A246212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246213
{
public static readonly BigInteger[] Value={ 2L,32L,500L,8600L,165690L,3568768L,85372280L,2251589600L,65007768650L,2041482333440L,69330316507452L,2533173484572640L,99124829660524850L,4137148176815360000L,BigInteger.Parse("183498069976613613680"),BigInteger.Parse("8620747043700633797888"),BigInteger.Parse("427712115490907106172050"),BigInteger.Parse("22350263436559575406220800") };
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
public class A246213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246213Inst Instance=new A246213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246214
{
public static readonly BigInteger[] Value={ 6L,150L,3240L,72030L,1719060L,44520840L,1252364400L,38167414560L,1255558958280L,44404434904830L,1681726757430720L,67953913291104750L,2919509551303952880L,BigInteger.Parse("132943540577100047760"),BigInteger.Parse("6397727538671302783680"),BigInteger.Parse("324511272091351156939200"),BigInteger.Parse("17306903935107005765263200") };
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
public class A246214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246214Inst Instance=new A246214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246215
{
public static readonly BigInteger[] Value={ 24L,864L,24696L,688128L,19840464L,604727424L,19632956112L,680195957760L,25130679950376L,988325574652416L,41277744231187464L,1826323584590389248L,BigInteger.Parse("85391029667937905184"),BigInteger.Parse("4209030460729215184896"),BigInteger.Parse("218223423136426488339744"),BigInteger.Parse("11875233973816788160610304") };
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
public class A246215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246215Inst Instance=new A246215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246216
{
public static readonly BigInteger[] Value={ 120L,5880L,215040L,7348320L,252000000L,8928667440L,331079253120L,12919902035040L,531665809234560L,23074929870993000L,1055390757120860160L,BigInteger.Parse("50802829404718896960"),BigInteger.Parse("2569731417499060039680"),BigInteger.Parse("136361684705644061566560"),BigInteger.Parse("7578327282420081922560000") };
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
public class A246216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246216Inst Instance=new A246216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246217
{
public static readonly BigInteger[] Value={ 720L,46080L,2099520L,86400000L,3478701600L,141893959680L,5963619055680L,260480095349760L,11874161338182000L,565994948205772800L,BigInteger.Parse("28225084763940704640"),BigInteger.Parse("1472185000741804277760"),BigInteger.Parse("80257688278285346487360"),BigInteger.Parse("4568639693232433397760000"),BigInteger.Parse("271256500003796168962953600") };
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
public class A246217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246217Inst Instance=new A246217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246218
{
public static readonly BigInteger[] Value={ 5040L,408240L,22680000L,1106859600L,51732172800L,2408384618640L,113960430904320L,5541379593750000L,278592031202284800L,14529619059476320800UL,BigInteger.Parse("787422201081850414080"),BigInteger.Parse("44373594768472437642720"),BigInteger.Parse("2600326096882824360960000"),BigInteger.Parse("158404803877320370312773600") };
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
public class A246218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246218Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246218.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246218Inst Instance=new A246218Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246219
{
public static readonly BigInteger[] Value={ 40320L,4032000L,268329600L,15328051200L,823379356800L,43413497487360L,2298646350000000L,123818753182924800L,6837492347913427200L,BigInteger.Parse("388855261570122547200"),BigInteger.Parse("22836250136299660220160"),BigInteger.Parse("1386932177757615390720000"),BigInteger.Parse("87175183432121364413433600"),BigInteger.Parse("5671938409008942797114572800") };
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
public class A246219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246219Inst Instance=new A246219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246220
{
public static readonly BigInteger[] Value={ 362880L,43908480L,3448811520L,228012744960L,13954338478080L,827512686000000L,48753634065776640L,2895879112057451520L,BigInteger.Parse("174984885490926551040"),BigInteger.Parse("10817178515493080290560"),BigInteger.Parse("686533182382689959116800"),BigInteger.Parse("44833266187415969387604480"),BigInteger.Parse("3016487768851293040555130880") };
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
public class A246220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246220Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246220.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246220Inst Instance=new A246220Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246221
{
public static readonly BigInteger[] Value={ 1L,3L,50L,270L,602L,5376L,139714L,1366016L,15302031L,161855232L,2600075865L,24776769024L,83295229293L,1553561635125L,93399961380678L,2499411984278178L,42789384888638364L,1138928547765375000L,15344070225505482050UL,BigInteger.Parse("450745170646586005994"),BigInteger.Parse("6999343174293499456470") };
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
public class A246221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246221Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246221.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246221Inst Instance=new A246221Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246222
{
public static readonly BigInteger[] Value={ 99L,0L,13303L,530432L,2715243L,14872704L,712988175L,2114735616L,14553496947L,22338508875L,9307563626682L,839345640802598L,8486108520773778L,298020352385025000L,10432593658200450596UL,BigInteger.Parse("210875469472380711300"),BigInteger.Parse("944599826416703171100"),BigInteger.Parse("12667164470975664000000") };
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
public class A246222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246222Inst Instance=new A246222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246223
{
public static readonly BigInteger[] Value={ 12L,0L,0L,158720L,74601L,0L,59062275L,17730048L,2099186631L,10006375L,206421198786L,135518026916798L,569885619485772L,13007265031125000L,5556193492800826418L,BigInteger.Parse("52483739349674666340"),BigInteger.Parse("51836903694327604380"),BigInteger.Parse("388109358965377200000"),BigInteger.Parse("302747316148839193725590") };
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
public class A246223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246223Inst Instance=new A246223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246224
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,255577419L,0L,0L,9542007262728L,6774382288791L,0L,2426035607748545873L,7229099931331250350L,1033055991550105110L,2319374753629800000L,BigInteger.Parse("19452094129713604966805"),BigInteger.Parse("438500213962184713953125"),BigInteger.Parse("45449834784068599467011795") };
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
public class A246224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246224Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246224.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246224Inst Instance=new A246224Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246225
{
public static readonly BigInteger[] Value={ 26546042L,0L,0L,222237912664L,0L,0L,902675188454625274L,523709583562561554L,4019286730558350L,0L,BigInteger.Parse("380750072712510202319"),BigInteger.Parse("378380322018952109375"),BigInteger.Parse("6458041428528147414728302"),BigInteger.Parse("18033623516991092062500"),BigInteger.Parse("51609923138804798955087048"),BigInteger.Parse("809786012867038620000000") };
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
public class A246225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246225Inst Instance=new A246225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246226
{
public static readonly BigInteger[] Value={ 2340699L,0L,0L,0L,0L,0L,264152543774143518L,12327936260780536L,0L,0L,0L,0L,BigInteger.Parse("672873380447205487461117"),0L,BigInteger.Parse("340824919595050237301116"),0L,BigInteger.Parse("5490319613423481676641190699"),0L,BigInteger.Parse("10557477888680231517368491"),BigInteger.Parse("44567941059064479980820469827072"),BigInteger.Parse("21711236330372841724318248158224") };
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
public class A246226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246226Inst Instance=new A246226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246227
{
public static readonly BigInteger[] Value={ 171470L,0L,0L,0L,0L,0L,64556303422787162L,0L,0L,0L,0L,0L,BigInteger.Parse("53330837507335912360442"),0L,0L,0L,BigInteger.Parse("510289061406183066554328264"),0L,0L,BigInteger.Parse("253410955069956058210029266688"),0L,BigInteger.Parse("3671524606283906345376361339863458448"),BigInteger.Parse("41993835528908638694682902028400861") };
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
public class A246227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246227Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246227.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246227Inst Instance=new A246227Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246228
{
public static readonly BigInteger[] Value={ 9690L,0L,0L,0L,0L,0L,15555589905976050L,0L,0L,0L,0L,0L,BigInteger.Parse("705927677520644167681"),0L,0L,0L,BigInteger.Parse("44817466764068599693530434"),0L,0L,0L,0L,BigInteger.Parse("327785215140138748862828534217850944"),0L,BigInteger.Parse("3576951943897328654730413638351518560"),0L,0L,0L };
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
public class A246228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246228Inst Instance=new A246228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246229
{
public static readonly BigInteger[] Value={ 571L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,BigInteger.Parse("3744763744425692221838464"),0L,0L,0L,0L,BigInteger.Parse("22782734075857073364773911020731544"),0L,0L,0L,0L,0L,BigInteger.Parse("2416100449345559771899241542815463200217246990336"),0L,0L,BigInteger.Parse("938240970212978118278669946671983079935585224737310") };
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
public class A246229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246229Inst Instance=new A246229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246230
{
public static readonly long[] Value={ 60L,285L,498L,1438L,2816L,5208L,11195L,24094L,38523L,85182L,148051L,255922L,512428L,991423L,1573152L,3318750L,5820718L,9712145L,19523028L,36637218L,58805129L,121712569L,216006156L,360123456L,720094287L,1340734558L,2184432420L,4453145090L,7987036106L,13417450294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246230Inst : IEnumerable<long>
{
public static readonly long[] Value=A246230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246230.Bytes);
public long this[int i]=>Value[i];

public static A246230Inst Instance=new A246230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246231
{
public static readonly long[] Value={ 12600L,78120L,189000L,549000L,1389960L,2858640L,6471699L,15289662L,29639082L,64025820L,134997382L,267550925L,545274648L,1161661901L,2223888268L,4552401195L,9185643748L,17829746962L,35102264675L,71613947350L,135793314152L,270167493481L,534784841445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246231Inst : IEnumerable<long>
{
public static readonly long[] Value=A246231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246231.Bytes);
public long this[int i]=>Value[i];

public static A246231Inst Instance=new A246231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246232
{
public static readonly long[] Value={ 37837800L,290089800L,913512600L,2870988120L,8647198560L,20798177400L,52611741000L,134182896120L,299814913440L,688027838400L,1598171790600L,3415039782840L,7488313184520L,16753428299160L,34973088459120L,74787505653264L,162128661286152L,333915200009352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246232Inst : IEnumerable<long>
{
public static readonly long[] Value=A246232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246232.Bytes);
public long this[int i]=>Value[i];

public static A246232Inst Instance=new A246232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246233
{
public static readonly long[] Value={ 2053230379200L,18772392038400L,73402986056400L,257607082933200L,886531102657200L,2509031227903200L,7078865111398080L,19909183290796800L,51039390957675120L,128693357256063600L,326570236365292920L,777083694958410840L,1847217791018559960L,4410908197048833480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246233Inst : IEnumerable<long>
{
public static readonly long[] Value=A246233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246233.Bytes);
public long this[int i]=>Value[i];

public static A246233Inst Instance=new A246233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246234
{
public static readonly BigInteger[] Value={ 2431106898187968000L,BigInteger.Parse("25830510793247160000"),BigInteger.Parse("121150160426367072000"),BigInteger.Parse("478913588068635720000"),BigInteger.Parse("1848522650426852400000"),BigInteger.Parse("6067325851827648408000"),BigInteger.Parse("19158973516499432616000"),BigInteger.Parse("59882095876893754464000"),BigInteger.Parse("173801554657753702680000"),BigInteger.Parse("487295849448575903736000") };
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
public class A246234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246234Inst Instance=new A246234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246235
{
public static readonly BigInteger[] Value={ 0L,1L,6L,57L,614L,7284L,91566L,1200705L,16232820L,224669049L,3167546164L,45332076360L,656839389030L,9616669678368L,142047629163678L,2114254565121153L,31678697416852592L,477435309876933207L,7232846873430148224L,BigInteger.Parse("110080098299375941607"),BigInteger.Parse("1682316692754904517268") };
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
public class A246235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246235Inst Instance=new A246235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246236
{
public static readonly BigInteger[] Value={ 0L,1L,7L,77L,966L,13342L,195384L,2984142L,46990952L,757504496L,12438875162L,207336046337L,3498937522808L,59663269192765L,1026407662358953L,17792842558962122L,310496318146483175L,5450092704153777190L,BigInteger.Parse("96160815834871877516"),BigInteger.Parse("1704498464976443234588") };
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
public class A246236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246236Inst Instance=new A246236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246237
{
public static readonly BigInteger[] Value={ 0L,1L,8L,100L,1432L,22570L,377320L,6578116L,118238600L,2175619923L,40778137032L,775828919936L,14944103723856L,290858342628604L,5711285455910096L,113005043943326568L,2250850657029983808L,BigInteger.Parse("45095294493866921469"),BigInteger.Parse("908159403846847306568"),BigInteger.Parse("18373705506139825769712") };
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
public class A246237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246237Inst Instance=new A246237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246238
{
public static readonly BigInteger[] Value={ 0L,1L,9L,126L,2028L,35919L,674964L,13225632L,267188229L,5525568297L,116400215521L,2488984609644L,53883301460607L,1178671076752803L,26011822261355487L,578441979200964897L,12948907700868521142UL,BigInteger.Parse("291569232606979152321"),BigInteger.Parse("6599274332502483541080") };
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
public class A246238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246238Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246238.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246238Inst Instance=new A246238Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246239
{
public static readonly BigInteger[] Value={ 0L,1L,10L,155L,2770L,54465L,1136402L,24723000L,554540590L,12732651160L,297795974970L,7069820334023L,169926110309380L,4126836768095315L,101114499262401970L,2496432769621336865L,BigInteger.Parse("62045482307629427354"),BigInteger.Parse("1551083997228106913910"),BigInteger.Parse("38976793037598171500920") };
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
public class A246239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246239Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246239.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246239Inst Instance=new A246239Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246240
{
public static readonly BigInteger[] Value={ 1L,1L,34L,9237L,11007556L,41262262505L,393602334214536L,8250608306349317503L,BigInteger.Parse("341379009411431516029576"),BigInteger.Parse("25693424488177173143564108049"),BigInteger.Parse("3298778490446719483156753593432700"),BigInteger.Parse("686045693667123232536420797701863401231"),BigInteger.Parse("221475400673152122602874526565943771742514376") };
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
public class A246240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246240Inst Instance=new A246240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246241
{
public static readonly BigInteger[] Value={ 1L,1L,66L,51033L,227263876L,3942914312505L,207874071367118436L,BigInteger.Parse("28034487027123336138967"),BigInteger.Parse("8522964991458712709499563784"),BigInteger.Parse("5302659152501095787067079018931409"),BigInteger.Parse("6255441983177258421672575234559926069140"),BigInteger.Parse("13154762734940720943667470423246456789300752691") };
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
public class A246241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246241Inst Instance=new A246241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246242
{
public static readonly BigInteger[] Value={ 1L,1L,130L,293061L,5018329348L,414999981562505L,BigInteger.Parse("124389170238814179336"),BigInteger.Parse("110807909819808911886548575"),BigInteger.Parse("253626563859350391170222920686088"),BigInteger.Parse("1334380576777390115212093953972864348177"),BigInteger.Parse("14777734823564325121187478504310896072495827020") };
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
public class A246242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246242Inst Instance=new A246242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246243
{
public static readonly BigInteger[] Value={ 1L,1L,258L,1718985L,115245958660L,46377854607812505L,BigInteger.Parse("80785609177262537107236"),BigInteger.Parse("486005483266096999009285275991"),BigInteger.Parse("8558639841332633529404511878004186120"),BigInteger.Parse("388791577542234912413815089860741309780872785"),BigInteger.Parse("41231194444310047390596429351583294775856761836687780") };
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
public class A246243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246243Inst Instance=new A246243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246244
{
public static readonly BigInteger[] Value={ 1L,1L,514L,10195797L,2703788516356L,5361940142039062505L,BigInteger.Parse("55063667396158825603112136"),BigInteger.Parse("2272169230481993564658922073502463"),BigInteger.Parse("312894608313254360747865383525129561090056"),BigInteger.Parse("124773193097402414339622625011223384066643153613969") };
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
public class A246244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246244Inst Instance=new A246244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246245
{
public static readonly BigInteger[] Value={ 1L,1L,1026L,60820473L,64146764716036L,BigInteger.Parse("631284899540195312505"),BigInteger.Parse("38539161299138154741325704036"),BigInteger.Parse("11011511482200093499929279574758403927"),BigInteger.Parse("11981061614421454177965724891826362153433952264"),BigInteger.Parse("42406820883646957465685129173683494532584922157233295569") };
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
public class A246245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246245Inst Instance=new A246245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246246
{
public static readonly BigInteger[] Value={ 3L,30L,270L,2322L,20772L,195372L,1958337L,20933154L,238789782L,2900868876L,37451986200L,512534035080L,7416327050415L,113185393797510L,1817654015037150L,30647027466113094L,541407973316966604L,10001886705503187732UL,BigInteger.Parse("192877025408450517501"),BigInteger.Parse("3876090406516703418282") };
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
public class A246246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246246Inst Instance=new A246246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246247
{
public static readonly BigInteger[] Value={ 99L,2214L,38394L,591543L,8826246L,131367258L,1989555210L,30951663300L,497599843140L,8291940960690L,143459287215300L,2578465192541220L,48147387009459165L,933704978071539690L,BigInteger.Parse("18794023286090727870"),BigInteger.Parse("392361396798154377681"),BigInteger.Parse("8489006744706293477274") };
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
public class A246247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246247Inst Instance=new A246247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246248
{
public static readonly BigInteger[] Value={ 11259L,443718L,12450834L,297195804L,6589314360L,141014406600L,2982538767870L,63210091744620L,1354523537530620L,29518995185712180L,656767731733672680L,14956075051814966040UL,BigInteger.Parse("349170616179434073825"),BigInteger.Parse("8366057002343951876610"),BigInteger.Parse("205839505389444095064510") };
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
public class A246248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246248Inst Instance=new A246248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246249
{
public static readonly BigInteger[] Value={ 3052323L,186723630L,7683652710L,260901740745L,8002149813810L,231524173618290L,6486876741415365L,178899784802719290L,4910005699045578270L,BigInteger.Parse("135118835430805648215"),BigInteger.Parse("3748167756629344500390"),BigInteger.Parse("105205858082972481706290"),BigInteger.Parse("2996195115836815163207370") };
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
public class A246249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246249Inst Instance=new A246249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246250
{
public static readonly BigInteger[] Value={ 1620265923L,142031290158L,8039798211078L,366995453376294L,14827018289073804L,555488440936519572L,BigInteger.Parse("19848769453749875607"),BigInteger.Parse("688735406876831016606"),BigInteger.Parse("23495176763112174568146"),BigInteger.Parse("794853120296757717355104"),BigInteger.Parse("26836227616917587293450368"),BigInteger.Parse("908479209956520414451380624") };
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
public class A246250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246250Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246250.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246250Inst Instance=new A246250Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246251
{
public static readonly BigInteger[] Value={ 1488257158851L,176902009674966L,13166075391964578L,775944032960346939L,BigInteger.Parse("39844140679287441918"),BigInteger.Parse("1872063201155821139178"),BigInteger.Parse("82897279832156950225548"),BigInteger.Parse("3526803545750650310760216"),BigInteger.Parse("146090377422354615989531688"),BigInteger.Parse("5948505245302032452585146020"),BigInteger.Parse("239776137775416266444362226760") };
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
public class A246251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246251Inst Instance=new A246251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246252
{
public static readonly BigInteger[] Value={ 2172534146099019L,336291324862551606L,BigInteger.Parse("31816048233798681066"),BigInteger.Parse("2348418329934108057072"),BigInteger.Parse("149140942861163014893024"),BigInteger.Parse("8573289075750149662810032"),BigInteger.Parse("460018114299281721089786796"),BigInteger.Parse("23509721961960146267578379640"),BigInteger.Parse("1160583084129910496820714859320") };
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
public class A246252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246252Inst Instance=new A246252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246253
{
public static readonly BigInteger[] Value={ 4736552519729393091L,BigInteger.Parse("925712659777722254622"),BigInteger.Parse("108450427756505074280046"),BigInteger.Parse("9790367872313042801164557"),BigInteger.Parse("752566904329661335915465770"),BigInteger.Parse("51895294413875186427307822050"),BigInteger.Parse("3313685917841456847408819072255"),BigInteger.Parse("200074814234955942882986408262750"),BigInteger.Parse("11591748407639299505418556743604770") };
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
public class A246253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246253Inst Instance=new A246253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246254
{
public static readonly BigInteger[] Value={ BigInteger.Parse("14708695606607601165843"),BigInteger.Parse("3541988733308075285027550"),BigInteger.Parse("503174667865819228904767230"),BigInteger.Parse("54504030281627517895808563770"),BigInteger.Parse("4983196403246326034913729334260"),BigInteger.Parse("405629500925435775383214597193020"),BigInteger.Parse("30367312487678851547450846684842845"),BigInteger.Parse("2136522202012396295876641497958908090") };
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
public class A246254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246254Inst Instance=new A246254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246255
{
public static readonly BigInteger[] Value={ BigInteger.Parse("62671742039942099631403299"),BigInteger.Parse("18231157381733294406542318214"),BigInteger.Parse("3087040831300287487055787449994"),BigInteger.Parse("394974982016287093640971012693311"),BigInteger.Parse("42334746925643499979072751981842422"),BigInteger.Parse("4013581941216432516413056735995683706"),BigInteger.Parse("347925850343780865770905714211197525182") };
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
public class A246255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246255Inst Instance=new A246255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246256
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,9L,6L,1L,45L,10L,1L,225L,135L,15L,1L,1575L,315L,21L,1L,11025L,6300L,630L,28L,1L,99225L,18900L,1134L,36L,1L,893025L,496125L,47250L,1890L,45L,1L,9823275L,1819125L,103950L,2970L,55L,1L,108056025L,58939650L,5457375L,207900L,4455L,66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246256Inst : IEnumerable<long>
{
public static readonly long[] Value=A246256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246256.Bytes);
public long this[int i]=>Value[i];

public static A246256Inst Instance=new A246256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246257
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,6L,6L,1L,30L,10L,1L,120L,90L,15L,1L,840L,210L,21L,1L,5565L,3360L,420L,28L,1L,50085L,10080L,756L,36L,1L,446985L,250425L,25200L,1260L,45L,1L,4916835L,918225L,55440L,1980L,55L,1L,54033210L,29501010L,2754675L,110880L,2970L,66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246257Inst : IEnumerable<long>
{
public static readonly long[] Value=A246257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246257.Bytes);
public long this[int i]=>Value[i];

public static A246257Inst Instance=new A246257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246258
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,4L,66L,6L,8L,9L,91L,70L,17L,15L,10L,55L,197L,94L,20L,18L,11L,21L,155L,259L,186L,24L,19L,12L,46L,84L,220L,364L,187L,26L,22L,13L,1362L,184L,87L,238L,377L,199L,41L,28L,14L,1654L,1981L,414L,189L,467L,413L,237L,45L,29L,16L,1419L,3055L,2378L,445L,309L,495L,479L,262L,54L,32L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246258Inst : IEnumerable<long>
{
public static readonly long[] Value=A246258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246258.Bytes);
public long this[int i]=>Value[i];

public static A246258Inst Instance=new A246258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246259
{
public static readonly long[] Value={ 1L,3L,2L,4L,7L,5L,9L,8L,6L,66L,10L,15L,17L,70L,91L,11L,18L,20L,94L,197L,55L,12L,19L,24L,186L,259L,155L,21L,13L,22L,26L,187L,364L,220L,84L,46L,14L,28L,41L,199L,377L,238L,87L,184L,1362L,16L,29L,45L,237L,413L,467L,189L,414L,1981L,1654L,23L,32L,54L,262L,479L,495L,309L,445L,2378L,3055L,1419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246259Inst : IEnumerable<long>
{
public static readonly long[] Value=A246259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246259.Bytes);
public long this[int i]=>Value[i];

public static A246259Inst Instance=new A246259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246260
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246260Inst : IEnumerable<long>
{
public static readonly long[] Value=A246260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246260.Bytes);
public long this[int i]=>Value[i];

public static A246260Inst Instance=new A246260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246261
{
public static readonly long[] Value={ 1L,3L,4L,9L,10L,11L,12L,13L,14L,16L,23L,25L,27L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,42L,44L,47L,48L,49L,52L,56L,58L,59L,64L,69L,71L,75L,81L,82L,83L,85L,86L,89L,90L,92L,93L,95L,97L,99L,100L,102L,105L,106L,107L,108L,109L,110L,111L,114L,117L,119L,120L,121L,122L,124L,126L,130L,131L,132L,133L,134L,136L,139L,140L,141L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246261Inst : IEnumerable<long>
{
public static readonly long[] Value=A246261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246261.Bytes);
public long this[int i]=>Value[i];

public static A246261Inst Instance=new A246261Inst();

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