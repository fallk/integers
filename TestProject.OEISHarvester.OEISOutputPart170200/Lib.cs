using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200657
{
public static readonly long[] Value={ 85580L,154396L,240004L,476425L,767125L,1235168L,1920032L,2555956L,5518439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200657Inst : IEnumerable<long>
{
public static readonly long[] Value=A200657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200657.Bytes);
public long this[int i]=>Value[i];

public static A200657Inst Instance=new A200657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200658
{
public static readonly long[] Value={ 52488L,15336L,-20088L,219375L,-293625L,981504L,-1285632L,-474552L,1367631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200658Inst : IEnumerable<long>
{
public static readonly long[] Value=A200658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200658.Bytes);
public long this[int i]=>Value[i];

public static A200658Inst Instance=new A200658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200659
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,13L,21L,9L,1L,71L,132L,76L,16L,1L,461L,955L,670L,200L,25L,1L,3447L,7782L,6309L,2374L,435L,36L,1L,29093L,70441L,63833L,28413L,6713L,833L,49L,1L,273343L,701352L,694500L,351512L,99868L,16240L,1456L,64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200659Inst : IEnumerable<long>
{
public static readonly long[] Value=A200659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200659.Bytes);
public long this[int i]=>Value[i];

public static A200659Inst Instance=new A200659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200660
{
public static readonly long[] Value={ 0L,1L,8L,49L,284L,1658L,9974L,62375L,406832L,2769493L,19668054L,145559632L,1121153604L,8974604065L,74553168520L,641808575961L,5718014325296L,52653303354906L,500515404889978L,4905937052293759L,49530189989912312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200660Inst : IEnumerable<long>
{
public static readonly long[] Value=A200660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200660.Bytes);
public long this[int i]=>Value[i];

public static A200660Inst Instance=new A200660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200661
{
public static readonly long[] Value={ 2L,3L,5L,8L,12L,17L,25L,36L,51L,72L,102L,144L,202L,284L,399L,560L,785L,1101L,1544L,2164L,3033L,4251L,5958L,8349L,11700L,16396L,22976L,32196L,45116L,63221L,88590L,124139L,173953L,243756L,341568L,478629L,670689L,939816L,1316935L,1845380L,2585874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200661Inst : IEnumerable<long>
{
public static readonly long[] Value=A200661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200661.Bytes);
public long this[int i]=>Value[i];

public static A200661Inst Instance=new A200661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200662
{
public static readonly long[] Value={ 3L,6L,12L,24L,46L,89L,176L,350L,697L,1391L,2780L,5555L,11098L,22170L,44288L,88472L,176729L,353032L,705224L,1408771L,2814203L,5621746L,11230193L,22433834L,44814616L,89523251L,178834811L,357246713L,713648606L,1425609609L,2847847987L,5688961529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200662Inst : IEnumerable<long>
{
public static readonly long[] Value=A200662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200662.Bytes);
public long this[int i]=>Value[i];

public static A200662Inst Instance=new A200662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200663
{
public static readonly long[] Value={ 4L,10L,26L,69L,175L,432L,1076L,2671L,6627L,16421L,40695L,100886L,250093L,619947L,1536810L,3809790L,9444489L,23412999L,58041252L,143885484L,356695266L,884255363L,2192088651L,5434237397L,13471597487L,33396394603L,82790419927L,205239329905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200663Inst : IEnumerable<long>
{
public static readonly long[] Value=A200663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200663.Bytes);
public long this[int i]=>Value[i];

public static A200663Inst Instance=new A200663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200664
{
public static readonly long[] Value={ 5L,15L,45L,135L,406L,1217L,3650L,10959L,32941L,99044L,297812L,895494L,2692703L,8096855L,24346869L,73209872L,220138513L,661945308L,1990435887L,5985139586L,17997009753L,54116091662L,162724331983L,489303778636L,1471311543936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200664Inst : IEnumerable<long>
{
public static readonly long[] Value=A200664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200664.Bytes);
public long this[int i]=>Value[i];

public static A200664Inst Instance=new A200664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200665
{
public static readonly long[] Value={ 6L,21L,75L,267L,938L,3283L,11516L,40399L,141745L,497298L,1744684L,6121152L,21475315L,75342932L,264330011L,927363850L,3253519870L,11414498822L,40046099291L,140495874086L,492909198404L,1729299730308L,6066994825927L,21285162746386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200665Inst : IEnumerable<long>
{
public static readonly long[] Value=A200665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200665.Bytes);
public long this[int i]=>Value[i];

public static A200665Inst Instance=new A200665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200666
{
public static readonly long[] Value={ 7L,28L,112L,448L,1813L,7322L,29536L,119066L,479993L,1935168L,7802161L,31456852L,126827111L,511338342L,2061602939L,8311924900L,33511832745L,135112262286L,544742594039L,2196280995578L,8854916583356L,35701054472646L,143938712300001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200666Inst : IEnumerable<long>
{
public static readonly long[] Value=A200666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200666.Bytes);
public long this[int i]=>Value[i];

public static A200666Inst Instance=new A200666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200667
{
public static readonly long[] Value={ 8L,36L,164L,750L,3414L,15504L,70412L,319532L,1449895L,6578528L,29850070L,135443522L,614568094L,2788573700L,12653014693L,57412388798L,260505742646L,1182031264628L,5363405068469L,24336170423291L,110424101519685L,501043586283665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200667Inst : IEnumerable<long>
{
public static readonly long[] Value=A200667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200667.Bytes);
public long this[int i]=>Value[i];

public static A200667Inst Instance=new A200667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200668
{
public static readonly long[] Value={ 2L,3L,3L,4L,6L,5L,5L,10L,12L,8L,6L,15L,26L,24L,12L,7L,21L,45L,69L,46L,17L,8L,28L,75L,135L,175L,89L,25L,9L,36L,112L,267L,406L,432L,176L,36L,10L,45L,164L,448L,938L,1217L,1076L,350L,51L,11L,55L,225L,750L,1813L,3283L,3650L,2671L,697L,72L,12L,66L,305L,1125L,3414L,7322L,11516L,10959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200668Inst : IEnumerable<long>
{
public static readonly long[] Value=A200668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200668.Bytes);
public long this[int i]=>Value[i];

public static A200668Inst Instance=new A200668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200669
{
public static readonly long[] Value={ 12L,46L,175L,406L,938L,1813L,3414L,5682L,9412L,14443L,22009L,31668L,45374L,62393L,85516L,113373L,149874L,193249L,248539L,312886L,393096L,485530L,598634L,727155L,881972L,1056600L,1264221L,1495936L,1768186L,2070552L,2422168L,2809532L,3256044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200669Inst : IEnumerable<long>
{
public static readonly long[] Value=A200669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200669.Bytes);
public long this[int i]=>Value[i];

public static A200669Inst Instance=new A200669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200670
{
public static readonly long[] Value={ 17L,89L,432L,1217L,3283L,7322L,15504L,28743L,52389L,87890L,145070L,225134L,345639L,507376L,738960L,1038003L,1448418L,1966975L,2656248L,3504620L,4603324L,5934897L,7622356L,9631810L,12132029L,15075684L,18682566L,22873460L,27937667L,33775988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200670Inst : IEnumerable<long>
{
public static readonly long[] Value=A200670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200670.Bytes);
public long this[int i]=>Value[i];

public static A200670Inst Instance=new A200670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200671
{
public static readonly long[] Value={ 25L,176L,1076L,3650L,11516L,29536L,70412L,145431L,291683L,534853L,956522L,1600651L,2633406L,4126715L,6386960L,9505210L,14002011L,20025031L,28396896L,39265235L,53923628L,72565437L,97086596L,127619975L,166939721L,215170884L,276186538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200671Inst : IEnumerable<long>
{
public static readonly long[] Value=A200671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200671.Bytes);
public long this[int i]=>Value[i];

public static A200671Inst Instance=new A200671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200672
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,13L,17L,21L,29L,37L,45L,61L,77L,93L,125L,157L,189L,253L,317L,381L,509L,637L,765L,1021L,1277L,1533L,2045L,2557L,3069L,4093L,5117L,6141L,8189L,10237L,12285L,16381L,20477L,24573L,32765L,40957L,49149L,65533L,81917L,98301L,131069L,163837L,196605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200672Inst : IEnumerable<long>
{
public static readonly long[] Value=A200672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200672.Bytes);
public long this[int i]=>Value[i];

public static A200672Inst Instance=new A200672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200673
{
public static readonly long[] Value={ 0L,0L,0L,1L,16L,170L,1549L,13253L,110970L,928822L,7862353L,67758488L,596837558L,5385257886L,49837119320L,473321736911L,4614233950422L,46168813528478L,474017189673555L,4992024759165631L,53902161267878974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200673Inst : IEnumerable<long>
{
public static readonly long[] Value=A200673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200673.Bytes);
public long this[int i]=>Value[i];

public static A200673Inst Instance=new A200673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200674
{
public static readonly long[] Value={ 0L,1L,9L,61L,385L,2365L,14353L,86605L,521089L,3130909L,18798577L,112830829L,677103073L,4062972733L,24378899281L,146276584333L,877669071937L,5266043129437L,31596344870065L,189578327500717L,1137470739845281L,6824826763594621L,40948967555136529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200674Inst : IEnumerable<long>
{
public static readonly long[] Value=A200674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200674.Bytes);
public long this[int i]=>Value[i];

public static A200674Inst Instance=new A200674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200675
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,4L,4L,8L,8L,8L,8L,16L,16L,16L,16L,32L,32L,32L,32L,64L,64L,64L,64L,128L,128L,128L,128L,256L,256L,256L,256L,512L,512L,512L,512L,1024L,1024L,1024L,1024L,2048L,2048L,2048L,2048L,4096L,4096L,4096L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200675Inst : IEnumerable<long>
{
public static readonly long[] Value=A200675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200675.Bytes);
public long this[int i]=>Value[i];

public static A200675Inst Instance=new A200675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200676
{
public static readonly long[] Value={ 1L,0L,0L,1L,5L,22L,96L,419L,1829L,7984L,34852L,152137L,664113L,2899006L,12654828L,55241235L,241140697L,1052634608L,4594992184L,20058197793L,87558647021L,382213633910L,1668450426280L,7283169876691L,31792711738525L,138782499488832L,605817532105276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200676Inst : IEnumerable<long>
{
public static readonly long[] Value=A200676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200676.Bytes);
public long this[int i]=>Value[i];

public static A200676Inst Instance=new A200676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200677
{
public static readonly long[] Value={ 0L,0L,0L,4L,6L,9L,10L,15L,14L,21L,0L,35L,22L,33L,26L,39L,0L,65L,34L,51L,38L,57L,0L,95L,46L,69L,0L,115L,0L,161L,58L,87L,62L,93L,0L,155L,0L,217L,74L,111L,0L,185L,82L,123L,86L,129L,0L,215L,94L,141L,0L,235L,0L,329L,106L,159L,0L,265L,0L,371L,118L,177L,122L,183L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200677Inst : IEnumerable<long>
{
public static readonly long[] Value=A200677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200677.Bytes);
public long this[int i]=>Value[i];

public static A200677Inst Instance=new A200677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200678
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,16L,20L,24L,28L,36L,44L,52L,60L,76L,92L,108L,124L,156L,188L,220L,252L,316L,380L,444L,508L,636L,764L,892L,1020L,1276L,1532L,1788L,2044L,2556L,3068L,3580L,4092L,5116L,6140L,7164L,8188L,10236L,12284L,14332L,16380L,20476L,24572L,28668L,32764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200678Inst : IEnumerable<long>
{
public static readonly long[] Value=A200678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200678.Bytes);
public long this[int i]=>Value[i];

public static A200678Inst Instance=new A200678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200679
{
public static readonly long[] Value={ 5L,5L,9L,7L,0L,4L,1L,5L,2L,2L,7L,3L,0L,8L,0L,6L,5L,0L,6L,1L,0L,3L,7L,7L,2L,1L,2L,8L,3L,5L,8L,8L,0L,2L,2L,9L,6L,9L,7L,4L,6L,8L,1L,6L,7L,1L,2L,6L,5L,9L,3L,6L,9L,3L,1L,3L,4L,8L,7L,3L,7L,8L,2L,6L,9L,0L,2L,3L,0L,0L,6L,6L,4L,1L,2L,7L,2L,9L,0L,3L,8L,0L,8L,3L,0L,1L,0L,8L,7L,4L,2L,3L,3L,0L,6L,4L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200679Inst : IEnumerable<long>
{
public static readonly long[] Value=A200679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200679.Bytes);
public long this[int i]=>Value[i];

public static A200679Inst Instance=new A200679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200680
{
public static readonly long[] Value={ 1L,2L,7L,0L,3L,4L,2L,6L,4L,7L,7L,9L,9L,5L,8L,2L,7L,1L,1L,0L,6L,3L,9L,9L,0L,3L,3L,5L,0L,3L,2L,0L,2L,1L,1L,2L,5L,1L,4L,7L,6L,9L,7L,3L,1L,0L,4L,6L,2L,8L,0L,7L,5L,6L,5L,6L,7L,6L,2L,5L,4L,0L,1L,2L,7L,6L,5L,4L,9L,0L,4L,4L,1L,1L,5L,6L,5L,0L,3L,4L,9L,6L,4L,1L,6L,9L,7L,1L,2L,3L,6L,3L,5L,9L,4L,4L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200680Inst : IEnumerable<long>
{
public static readonly long[] Value=A200680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200680.Bytes);
public long this[int i]=>Value[i];

public static A200680Inst Instance=new A200680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200681
{
public static readonly long[] Value={ 3L,4L,7L,4L,2L,5L,7L,6L,4L,4L,7L,7L,4L,3L,8L,7L,1L,1L,2L,8L,9L,0L,5L,6L,4L,1L,2L,9L,5L,5L,3L,2L,5L,8L,7L,6L,7L,2L,3L,1L,5L,3L,1L,7L,0L,2L,7L,7L,1L,9L,3L,9L,3L,7L,2L,0L,4L,8L,9L,6L,8L,3L,6L,8L,0L,0L,8L,0L,9L,5L,6L,5L,4L,2L,5L,1L,2L,3L,4L,8L,8L,8L,2L,7L,0L,5L,2L,9L,2L,2L,7L,5L,0L,5L,7L,8L,8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200681Inst : IEnumerable<long>
{
public static readonly long[] Value=A200681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200681.Bytes);
public long this[int i]=>Value[i];

public static A200681Inst Instance=new A200681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200682
{
public static readonly long[] Value={ 1L,4L,0L,3L,0L,6L,0L,4L,2L,0L,8L,0L,9L,3L,7L,1L,2L,3L,8L,8L,4L,8L,9L,2L,1L,3L,4L,9L,4L,4L,9L,4L,4L,2L,0L,1L,5L,7L,1L,2L,9L,3L,1L,3L,8L,4L,2L,4L,5L,1L,1L,1L,4L,6L,8L,9L,5L,9L,4L,8L,8L,5L,9L,1L,8L,5L,2L,9L,0L,1L,7L,3L,9L,6L,5L,1L,5L,1L,1L,0L,2L,5L,2L,8L,1L,8L,7L,6L,3L,1L,0L,6L,4L,1L,3L,8L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200682Inst : IEnumerable<long>
{
public static readonly long[] Value=A200682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200682.Bytes);
public long this[int i]=>Value[i];

public static A200682Inst Instance=new A200682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200683
{
public static readonly long[] Value={ 2L,5L,5L,5L,8L,9L,9L,6L,6L,7L,4L,6L,5L,6L,7L,8L,0L,3L,4L,7L,1L,4L,1L,2L,6L,3L,3L,5L,3L,9L,8L,1L,4L,6L,8L,1L,1L,2L,6L,6L,8L,4L,4L,8L,9L,0L,5L,1L,8L,6L,6L,1L,0L,0L,4L,3L,1L,2L,6L,8L,2L,7L,5L,1L,1L,2L,5L,9L,0L,7L,0L,3L,1L,5L,8L,8L,6L,2L,4L,3L,2L,0L,4L,1L,9L,7L,0L,8L,5L,0L,2L,3L,4L,2L,3L,5L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200683Inst : IEnumerable<long>
{
public static readonly long[] Value=A200683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200683.Bytes);
public long this[int i]=>Value[i];

public static A200683Inst Instance=new A200683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200684
{
public static readonly long[] Value={ 1L,4L,5L,2L,9L,1L,6L,1L,6L,0L,9L,1L,6L,5L,1L,4L,5L,1L,8L,7L,4L,2L,7L,4L,8L,6L,8L,7L,5L,9L,0L,4L,4L,8L,3L,2L,3L,2L,4L,0L,2L,2L,5L,9L,9L,9L,0L,3L,2L,5L,0L,9L,5L,1L,4L,9L,7L,6L,4L,6L,3L,1L,3L,0L,5L,3L,3L,6L,2L,8L,3L,7L,1L,6L,6L,5L,5L,6L,8L,6L,0L,7L,3L,1L,9L,9L,2L,4L,8L,3L,1L,1L,1L,7L,1L,5L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200684Inst : IEnumerable<long>
{
public static readonly long[] Value=A200684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200684.Bytes);
public long this[int i]=>Value[i];

public static A200684Inst Instance=new A200684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200685
{
public static readonly long[] Value={ 5L,8L,3L,2L,4L,8L,4L,6L,7L,2L,5L,5L,0L,4L,8L,0L,4L,1L,4L,8L,3L,8L,6L,6L,6L,2L,9L,9L,1L,3L,2L,0L,7L,5L,4L,0L,7L,3L,0L,4L,3L,4L,9L,7L,8L,7L,7L,2L,0L,5L,6L,0L,0L,6L,0L,3L,4L,8L,2L,7L,1L,1L,4L,9L,4L,2L,3L,2L,2L,7L,4L,9L,1L,5L,8L,8L,1L,3L,3L,6L,7L,3L,0L,2L,9L,7L,2L,1L,6L,1L,9L,4L,5L,9L,1L,4L,9L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200685Inst : IEnumerable<long>
{
public static readonly long[] Value=A200685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200685.Bytes);
public long this[int i]=>Value[i];

public static A200685Inst Instance=new A200685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200686
{
public static readonly long[] Value={ 8L,8L,3L,7L,5L,9L,9L,5L,7L,2L,0L,8L,3L,1L,5L,8L,6L,4L,5L,3L,1L,9L,4L,7L,2L,8L,9L,0L,5L,2L,1L,2L,8L,6L,2L,8L,6L,9L,7L,1L,6L,7L,9L,7L,9L,1L,6L,7L,2L,7L,5L,9L,2L,1L,3L,3L,0L,0L,1L,1L,6L,2L,5L,7L,1L,4L,5L,2L,8L,6L,9L,5L,1L,0L,0L,9L,8L,0L,1L,2L,4L,6L,1L,9L,0L,4L,4L,0L,4L,8L,5L,6L,9L,2L,2L,5L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200686Inst : IEnumerable<long>
{
public static readonly long[] Value=A200686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200686.Bytes);
public long this[int i]=>Value[i];

public static A200686Inst Instance=new A200686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200687
{
public static readonly long[] Value={ 1L,0L,7L,4L,3L,0L,7L,6L,1L,9L,5L,9L,3L,5L,8L,9L,1L,7L,7L,1L,9L,6L,3L,6L,3L,6L,3L,4L,6L,2L,8L,6L,8L,7L,2L,2L,8L,6L,3L,7L,8L,6L,5L,2L,1L,6L,3L,2L,7L,4L,8L,5L,0L,2L,3L,8L,3L,7L,3L,8L,7L,0L,4L,1L,7L,5L,0L,6L,4L,8L,9L,9L,8L,3L,5L,1L,5L,7L,8L,2L,6L,7L,7L,6L,8L,1L,7L,2L,6L,7L,9L,4L,8L,4L,1L,1L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200687Inst : IEnumerable<long>
{
public static readonly long[] Value=A200687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200687.Bytes);
public long this[int i]=>Value[i];

public static A200687Inst Instance=new A200687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200688
{
public static readonly long[] Value={ 1L,1L,9L,8L,7L,8L,3L,7L,4L,3L,1L,5L,4L,6L,7L,2L,3L,3L,0L,7L,6L,6L,9L,4L,2L,2L,1L,1L,4L,5L,5L,5L,5L,3L,3L,3L,0L,7L,1L,3L,1L,2L,9L,2L,9L,6L,7L,2L,9L,2L,5L,1L,6L,4L,0L,9L,2L,5L,6L,0L,3L,9L,6L,9L,1L,0L,7L,0L,7L,3L,1L,1L,2L,4L,5L,3L,0L,9L,6L,1L,1L,9L,0L,8L,4L,2L,0L,1L,4L,4L,6L,5L,2L,9L,4L,3L,8L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200688Inst : IEnumerable<long>
{
public static readonly long[] Value=A200688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200688.Bytes);
public long this[int i]=>Value[i];

public static A200688Inst Instance=new A200688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200689
{
public static readonly long[] Value={ 1L,2L,8L,1L,3L,6L,9L,9L,1L,6L,6L,2L,1L,1L,5L,5L,8L,6L,8L,0L,9L,8L,5L,7L,6L,9L,0L,4L,5L,3L,4L,8L,9L,4L,9L,8L,9L,6L,2L,9L,2L,2L,9L,3L,1L,0L,2L,9L,1L,2L,0L,6L,0L,3L,0L,1L,7L,2L,7L,7L,1L,0L,8L,9L,2L,9L,2L,0L,3L,2L,2L,9L,6L,1L,0L,7L,0L,5L,1L,3L,1L,9L,8L,6L,7L,5L,5L,1L,1L,3L,0L,5L,0L,3L,4L,4L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200689Inst : IEnumerable<long>
{
public static readonly long[] Value=A200689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200689.Bytes);
public long this[int i]=>Value[i];

public static A200689Inst Instance=new A200689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200690
{
public static readonly long[] Value={ 1L,3L,3L,7L,6L,2L,8L,4L,7L,2L,7L,2L,8L,0L,0L,8L,4L,8L,8L,4L,7L,1L,5L,7L,8L,3L,8L,8L,4L,1L,8L,8L,4L,5L,7L,0L,8L,7L,5L,8L,7L,1L,1L,0L,2L,0L,6L,7L,7L,3L,1L,8L,4L,9L,6L,4L,3L,6L,7L,9L,6L,3L,0L,9L,8L,8L,4L,2L,0L,5L,6L,8L,3L,5L,0L,3L,1L,7L,2L,3L,1L,3L,8L,2L,3L,8L,2L,1L,4L,8L,3L,6L,5L,6L,4L,0L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200690Inst : IEnumerable<long>
{
public static readonly long[] Value=A200690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200690.Bytes);
public long this[int i]=>Value[i];

public static A200690Inst Instance=new A200690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200691
{
public static readonly long[] Value={ 1L,3L,7L,7L,2L,8L,8L,1L,9L,6L,8L,0L,4L,0L,2L,9L,3L,6L,0L,2L,4L,2L,7L,6L,0L,4L,4L,1L,0L,7L,8L,4L,1L,3L,5L,2L,5L,5L,7L,4L,8L,6L,0L,9L,1L,9L,6L,7L,3L,0L,0L,1L,9L,9L,2L,2L,9L,0L,8L,9L,4L,5L,6L,9L,9L,7L,3L,7L,8L,5L,4L,4L,1L,3L,7L,3L,0L,4L,0L,8L,0L,6L,1L,8L,5L,6L,6L,9L,5L,3L,5L,2L,4L,6L,7L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200691Inst : IEnumerable<long>
{
public static readonly long[] Value=A200691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200691.Bytes);
public long this[int i]=>Value[i];

public static A200691Inst Instance=new A200691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200692
{
public static readonly long[] Value={ 1L,4L,0L,6L,2L,5L,2L,3L,2L,3L,2L,9L,7L,3L,6L,1L,4L,6L,8L,0L,8L,0L,5L,9L,3L,2L,9L,6L,3L,5L,2L,0L,4L,2L,3L,2L,1L,5L,4L,1L,6L,6L,8L,2L,3L,6L,6L,7L,5L,4L,7L,1L,9L,7L,4L,8L,7L,1L,2L,0L,1L,5L,0L,5L,1L,0L,3L,0L,8L,5L,5L,1L,2L,1L,8L,0L,8L,9L,4L,9L,7L,8L,9L,7L,4L,6L,0L,1L,2L,6L,4L,6L,7L,7L,5L,0L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200692Inst : IEnumerable<long>
{
public static readonly long[] Value=A200692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200692.Bytes);
public long this[int i]=>Value[i];

public static A200692Inst Instance=new A200692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200693
{
public static readonly long[] Value={ 1L,4L,2L,8L,1L,0L,5L,1L,9L,3L,9L,3L,4L,3L,8L,0L,7L,4L,9L,6L,9L,9L,5L,8L,6L,0L,5L,3L,7L,1L,3L,8L,8L,0L,6L,8L,6L,8L,4L,6L,8L,5L,5L,4L,3L,1L,1L,1L,4L,3L,9L,5L,2L,6L,2L,3L,4L,1L,3L,0L,3L,3L,5L,3L,1L,6L,9L,1L,5L,3L,5L,2L,3L,5L,7L,8L,6L,3L,7L,5L,1L,3L,6L,4L,0L,7L,0L,3L,8L,4L,1L,7L,1L,2L,7L,5L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200693Inst : IEnumerable<long>
{
public static readonly long[] Value=A200693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200693.Bytes);
public long this[int i]=>Value[i];

public static A200693Inst Instance=new A200693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200694
{
public static readonly long[] Value={ 1L,4L,4L,5L,0L,6L,9L,1L,2L,8L,7L,0L,5L,3L,2L,7L,6L,0L,5L,7L,4L,1L,0L,8L,4L,4L,7L,9L,3L,0L,3L,6L,2L,4L,8L,9L,9L,8L,4L,0L,3L,2L,5L,8L,6L,4L,5L,4L,8L,4L,4L,5L,1L,4L,7L,2L,7L,1L,6L,4L,0L,6L,5L,1L,4L,0L,8L,4L,6L,7L,2L,6L,8L,5L,6L,4L,1L,7L,2L,7L,3L,7L,1L,4L,1L,1L,9L,3L,5L,0L,8L,0L,5L,8L,1L,5L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200694Inst : IEnumerable<long>
{
public static readonly long[] Value=A200694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200694.Bytes);
public long this[int i]=>Value[i];

public static A200694Inst Instance=new A200694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200695
{
public static readonly long[] Value={ 4L,8L,5L,7L,9L,7L,3L,4L,8L,9L,4L,7L,5L,4L,4L,1L,7L,8L,7L,5L,5L,5L,9L,5L,4L,4L,1L,1L,3L,7L,5L,9L,3L,6L,1L,9L,5L,2L,6L,0L,3L,3L,0L,5L,2L,1L,4L,6L,3L,0L,8L,9L,9L,7L,8L,6L,8L,0L,6L,8L,7L,8L,4L,8L,3L,5L,1L,7L,5L,7L,2L,7L,9L,7L,2L,0L,1L,1L,1L,7L,9L,6L,9L,6L,3L,6L,3L,2L,6L,9L,9L,5L,4L,3L,7L,5L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200695Inst : IEnumerable<long>
{
public static readonly long[] Value=A200695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200695.Bytes);
public long this[int i]=>Value[i];

public static A200695Inst Instance=new A200695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200696
{
public static readonly long[] Value={ 9L,1L,9L,0L,5L,2L,4L,5L,5L,3L,3L,2L,6L,7L,3L,5L,1L,2L,1L,5L,9L,9L,5L,3L,1L,9L,0L,5L,3L,9L,4L,6L,3L,5L,6L,3L,2L,7L,5L,7L,7L,8L,8L,6L,5L,4L,4L,3L,3L,8L,6L,9L,1L,8L,6L,4L,3L,9L,0L,4L,4L,8L,5L,4L,0L,4L,4L,8L,0L,5L,4L,4L,8L,3L,0L,5L,6L,3L,2L,7L,0L,5L,9L,4L,3L,1L,8L,1L,6L,3L,5L,3L,0L,4L,0L,2L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200696Inst : IEnumerable<long>
{
public static readonly long[] Value=A200696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200696.Bytes);
public long this[int i]=>Value[i];

public static A200696Inst Instance=new A200696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200697
{
public static readonly long[] Value={ 4L,2L,6L,4L,7L,3L,8L,7L,2L,8L,0L,9L,1L,4L,5L,1L,3L,2L,9L,9L,5L,2L,9L,9L,1L,3L,5L,6L,3L,2L,8L,0L,1L,9L,1L,2L,1L,2L,8L,7L,1L,0L,3L,7L,7L,5L,9L,4L,7L,2L,9L,3L,3L,3L,9L,4L,8L,1L,0L,1L,8L,9L,3L,3L,6L,8L,1L,6L,0L,9L,1L,2L,5L,9L,4L,2L,7L,5L,8L,3L,3L,5L,2L,1L,5L,8L,5L,5L,7L,5L,4L,1L,2L,6L,6L,0L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200697Inst : IEnumerable<long>
{
public static readonly long[] Value=A200697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200697.Bytes);
public long this[int i]=>Value[i];

public static A200697Inst Instance=new A200697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200698
{
public static readonly long[] Value={ 6L,4L,4L,9L,2L,2L,7L,9L,6L,5L,0L,0L,9L,3L,2L,8L,2L,0L,0L,2L,6L,4L,2L,6L,7L,1L,8L,1L,2L,0L,3L,2L,5L,5L,5L,5L,6L,5L,6L,9L,5L,0L,5L,6L,6L,6L,3L,7L,4L,5L,2L,3L,4L,8L,0L,1L,4L,4L,4L,6L,2L,6L,9L,4L,7L,9L,7L,2L,8L,1L,4L,3L,6L,1L,3L,8L,8L,2L,7L,6L,7L,4L,9L,0L,8L,1L,9L,6L,4L,9L,8L,9L,5L,0L,6L,7L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200698Inst : IEnumerable<long>
{
public static readonly long[] Value=A200698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200698.Bytes);
public long this[int i]=>Value[i];

public static A200698Inst Instance=new A200698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200699
{
public static readonly long[] Value={ 3L,8L,5L,4L,4L,2L,2L,7L,3L,9L,4L,1L,3L,9L,4L,6L,8L,8L,4L,8L,6L,2L,7L,9L,7L,1L,4L,8L,2L,0L,2L,8L,9L,3L,1L,0L,6L,0L,7L,4L,1L,3L,6L,7L,1L,1L,9L,2L,2L,2L,7L,2L,4L,3L,2L,3L,7L,1L,9L,8L,5L,9L,2L,5L,4L,5L,0L,7L,8L,6L,4L,4L,1L,0L,6L,4L,0L,8L,3L,9L,8L,6L,3L,5L,5L,9L,3L,0L,8L,2L,6L,8L,2L,5L,7L,6L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200699Inst : IEnumerable<long>
{
public static readonly long[] Value=A200699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200699.Bytes);
public long this[int i]=>Value[i];

public static A200699Inst Instance=new A200699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200700
{
public static readonly long[] Value={ 3L,5L,4L,8L,2L,2L,8L,6L,5L,9L,8L,5L,9L,9L,0L,7L,5L,7L,7L,7L,6L,5L,2L,8L,8L,7L,1L,9L,5L,0L,1L,3L,6L,8L,4L,3L,4L,1L,5L,2L,4L,2L,4L,1L,9L,2L,4L,5L,4L,3L,8L,1L,1L,1L,8L,2L,2L,3L,5L,1L,3L,5L,5L,8L,6L,8L,2L,5L,8L,8L,9L,5L,3L,2L,5L,9L,3L,4L,8L,8L,7L,1L,6L,3L,5L,5L,1L,4L,4L,0L,2L,0L,7L,1L,0L,3L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200700Inst : IEnumerable<long>
{
public static readonly long[] Value=A200700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200700.Bytes);
public long this[int i]=>Value[i];

public static A200700Inst Instance=new A200700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200701
{
public static readonly long[] Value={ 3L,3L,0L,8L,0L,1L,8L,0L,6L,1L,0L,5L,5L,8L,6L,9L,9L,1L,4L,3L,4L,0L,8L,7L,8L,0L,3L,1L,0L,8L,9L,9L,0L,9L,3L,5L,7L,4L,3L,3L,6L,3L,3L,8L,1L,6L,8L,1L,9L,8L,0L,7L,0L,4L,0L,2L,4L,4L,2L,3L,2L,0L,8L,5L,2L,7L,1L,6L,4L,1L,4L,2L,9L,8L,2L,0L,7L,8L,0L,6L,5L,2L,9L,5L,2L,8L,4L,6L,4L,8L,5L,6L,4L,6L,0L,5L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200701Inst : IEnumerable<long>
{
public static readonly long[] Value=A200701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200701.Bytes);
public long this[int i]=>Value[i];

public static A200701Inst Instance=new A200701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200702
{
public static readonly long[] Value={ 3L,1L,1L,2L,7L,8L,8L,8L,4L,1L,7L,5L,9L,3L,6L,8L,6L,7L,8L,9L,6L,7L,9L,9L,2L,6L,5L,6L,8L,8L,2L,1L,3L,2L,1L,8L,1L,7L,1L,5L,2L,3L,7L,1L,0L,2L,3L,8L,9L,5L,0L,3L,3L,3L,3L,4L,3L,8L,6L,3L,6L,3L,2L,4L,4L,6L,7L,1L,2L,7L,6L,8L,5L,1L,4L,6L,8L,5L,2L,3L,3L,6L,6L,8L,7L,9L,3L,7L,5L,3L,3L,8L,5L,3L,8L,7L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200702Inst : IEnumerable<long>
{
public static readonly long[] Value=A200702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200702.Bytes);
public long this[int i]=>Value[i];

public static A200702Inst Instance=new A200702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200703
{
public static readonly long[] Value={ 2L,9L,4L,9L,8L,8L,6L,0L,6L,8L,2L,8L,9L,2L,6L,5L,3L,5L,7L,0L,8L,8L,8L,9L,6L,5L,2L,0L,4L,6L,7L,6L,1L,3L,8L,7L,7L,8L,8L,7L,1L,8L,2L,6L,0L,1L,4L,9L,7L,5L,2L,1L,3L,4L,8L,9L,2L,7L,6L,2L,8L,2L,8L,1L,8L,3L,4L,0L,4L,4L,1L,3L,7L,6L,4L,0L,7L,3L,0L,1L,8L,5L,9L,9L,2L,9L,1L,3L,8L,8L,9L,1L,1L,5L,5L,1L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200703Inst : IEnumerable<long>
{
public static readonly long[] Value=A200703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200703.Bytes);
public long this[int i]=>Value[i];

public static A200703Inst Instance=new A200703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200704
{
public static readonly long[] Value={ 2L,8L,1L,1L,1L,6L,1L,8L,8L,4L,1L,7L,6L,3L,9L,7L,5L,2L,5L,8L,6L,3L,9L,7L,0L,1L,0L,6L,2L,4L,2L,1L,0L,3L,6L,1L,5L,1L,8L,0L,0L,5L,4L,6L,2L,2L,9L,0L,8L,2L,6L,0L,6L,0L,1L,6L,4L,9L,2L,0L,8L,7L,8L,2L,1L,5L,5L,7L,5L,7L,3L,1L,5L,4L,7L,9L,8L,6L,7L,3L,0L,7L,8L,9L,8L,5L,9L,3L,8L,7L,6L,1L,1L,1L,7L,4L,5L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200704Inst : IEnumerable<long>
{
public static readonly long[] Value=A200704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200704.Bytes);
public long this[int i]=>Value[i];

public static A200704Inst Instance=new A200704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200705
{
public static readonly long[] Value={ 2L,6L,9L,1L,0L,9L,6L,7L,1L,2L,7L,8L,9L,4L,6L,5L,6L,6L,5L,2L,2L,4L,7L,0L,6L,4L,8L,2L,1L,9L,0L,2L,1L,0L,5L,8L,8L,3L,5L,6L,2L,1L,2L,2L,4L,0L,2L,4L,2L,2L,0L,3L,0L,8L,0L,4L,9L,1L,0L,9L,0L,4L,2L,1L,6L,2L,3L,8L,2L,2L,1L,7L,3L,9L,0L,8L,7L,4L,5L,0L,3L,9L,0L,8L,0L,3L,0L,7L,1L,4L,4L,5L,9L,5L,3L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200705Inst : IEnumerable<long>
{
public static readonly long[] Value=A200705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200705.Bytes);
public long this[int i]=>Value[i];

public static A200705Inst Instance=new A200705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200706
{
public static readonly long[] Value={ 8L,540L,317656L,1630978608L,71952946981858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200706Inst : IEnumerable<long>
{
public static readonly long[] Value=A200706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200706.Bytes);
public long this[int i]=>Value[i];

public static A200706Inst Instance=new A200706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200707
{
public static readonly long[] Value={ 8L,36L,154L,638L,2583L,10283L,40437L,157577L,609826L,2347039L,8992543L,34325682L,130610876L,495631814L,1876372121L,7089015135L,26734090034L,100657714409L,378448861732L,1421055725676L,5329855712676L,19969617365137L,74751054819223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200707Inst : IEnumerable<long>
{
public static readonly long[] Value=A200707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200707.Bytes);
public long this[int i]=>Value[i];

public static A200707Inst Instance=new A200707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200708
{
public static readonly long[] Value={ 36L,540L,7370L,95567L,1196837L,14599041L,174544948L,2054226643L,23879098633L,274805736757L,3136426281937L,35550221949225L,400585306584414L,4491028688561012L,50128085812559568L,557352332775257512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200708Inst : IEnumerable<long>
{
public static readonly long[] Value=A200708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200708.Bytes);
public long this[int i]=>Value[i];

public static A200708Inst Instance=new A200708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200709
{
public static readonly BigInteger[] Value={ 154L,7370L,317656L,12904303L,501622631L,18836416881L,688892422045L,24679562321720L,870010030574894L,30274045926194001L,1042315568516067529L,BigInteger.Parse("35569907932628823872"),BigInteger.Parse("1204745819326637993000"),BigInteger.Parse("40540325062931324645529") };
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
public class A200709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200709Inst Instance=new A200709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200710
{
public static readonly BigInteger[] Value={ 638L,95567L,12904303L,1630978608L,195675787426L,22525604271509L,2512851095363929L,273566206900264111L,BigInteger.Parse("29225435372492971841"),BigInteger.Parse("3075465941063432826683"),BigInteger.Parse("319691253286956006425052") };
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
public class A200710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200710Inst Instance=new A200710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200711
{
public static readonly long[] Value={ 2583L,1196837L,501622631L,195675787426L,71952946981858L,25239894694049776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200711Inst : IEnumerable<long>
{
public static readonly long[] Value=A200711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200711.Bytes);
public long this[int i]=>Value[i];

public static A200711Inst Instance=new A200711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200712
{
public static readonly long[] Value={ 10283L,14599041L,18836416881L,22525604271509L,25239894694049776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200712Inst : IEnumerable<long>
{
public static readonly long[] Value=A200712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200712.Bytes);
public long this[int i]=>Value[i];

public static A200712Inst Instance=new A200712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200713
{
public static readonly long[] Value={ 8L,36L,36L,154L,540L,154L,638L,7370L,7370L,638L,2583L,95567L,317656L,95567L,2583L,10283L,1196837L,12904303L,12904303L,1196837L,10283L,40437L,14599041L,501622631L,1630978608L,501622631L,14599041L,40437L,157577L,174544948L,18836416881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200713Inst : IEnumerable<long>
{
public static readonly long[] Value=A200713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200713.Bytes);
public long this[int i]=>Value[i];

public static A200713Inst Instance=new A200713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200714
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,5L,6L,15L,4L,11L,13L,14L,31L,10L,9L,23L,12L,27L,29L,30L,63L,8L,21L,19L,22L,47L,26L,25L,55L,28L,59L,61L,62L,127L,20L,17L,43L,18L,39L,45L,46L,95L,24L,53L,51L,54L,111L,58L,57L,119L,60L,123L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200714Inst : IEnumerable<long>
{
public static readonly long[] Value=A200714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200714.Bytes);
public long this[int i]=>Value[i];

public static A200714Inst Instance=new A200714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200715
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,-2L,-4L,3L,13L,0L,-36L,-23L,85L,118L,-160L,-429L,169L,1296L,360L,-3359L,-3143L,7294L,13364L,-11661L,-44459L,3888L,125604L,69481L,-303443L,-386282L,593528L,1448931L,-717935L,-4471200L,-868464L,11827201L,9961393L,-26388674L,-44445652L,44681763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200715Inst : IEnumerable<long>
{
public static readonly long[] Value=A200715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200715.Bytes);
public long this[int i]=>Value[i];

public static A200715Inst Instance=new A200715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200716
{
public static readonly long[] Value={ 1L,1L,4L,17L,84L,453L,2574L,15185L,92119L,571022L,3600981L,23029021L,149000790L,973581692L,6415198045L,42580369370L,284427460919L,1910594331920L,12898153658337L,87461992473577L,595455441375978L,4068652368270955L,27891991988552554L,191783482751813061L,1322319472577803761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200716Inst : IEnumerable<long>
{
public static readonly long[] Value=A200716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200716.Bytes);
public long this[int i]=>Value[i];

public static A200716Inst Instance=new A200716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200717
{
public static readonly long[] Value={ 1L,1L,4L,18L,93L,521L,3073L,18806L,118297L,760162L,4968480L,32928392L,220766739L,1494635330L,10203884795L,70167751762L,485574854049L,3379064343829L,23631314301088L,165998001901786L,1170706810318259L,8286253163771045L,58842370488310336L,419102145275264242L,2993221125640617827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200717Inst : IEnumerable<long>
{
public static readonly long[] Value=A200717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200717.Bytes);
public long this[int i]=>Value[i];

public static A200717Inst Instance=new A200717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200718
{
public static readonly long[] Value={ 1L,1L,3L,14L,75L,433L,2636L,16668L,108399L,720431L,4871555L,33409042L,231817448L,1624503716L,11480658056L,81731416480L,585579734959L,4219179476875L,30552067317233L,222225174139730L,1622894404239115L,11894991079960721L,87472260252499560L,645183802300787356L,4771926560361458884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200718Inst : IEnumerable<long>
{
public static readonly long[] Value=A200718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200718.Bytes);
public long this[int i]=>Value[i];

public static A200718Inst Instance=new A200718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200719
{
public static readonly long[] Value={ 1L,1L,3L,13L,64L,340L,1903L,11053L,65993L,402527L,2497439L,15712220L,100001459L,642719263L,4165537744L,27193644061L,178654643151L,1180282875483L,7836312619243L,52259258911091L,349902441457427L,2351240866736891L,15851508780927739L,107187240225220684L,726784821098903319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200719Inst : IEnumerable<long>
{
public static readonly long[] Value=A200719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200719.Bytes);
public long this[int i]=>Value[i];

public static A200719Inst Instance=new A200719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200720
{
public static readonly long[] Value={ 0L,80L,72L,112L,3014L,10882L,53528L,396930L,2434692L,15278390L,120425006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200720Inst : IEnumerable<long>
{
public static readonly long[] Value=A200720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200720.Bytes);
public long this[int i]=>Value[i];

public static A200720Inst Instance=new A200720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200721
{
public static readonly long[] Value={ 26L,1133L,20309L,51159L,3246905L,28673661L,5201685791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200721Inst : IEnumerable<long>
{
public static readonly long[] Value=A200721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200721.Bytes);
public long this[int i]=>Value[i];

public static A200721Inst Instance=new A200721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200722
{
public static readonly long[] Value={ 6L,8L,11L,13L,15L,16L,21L,27L,29L,31L,35L,37L,41L,43L,47L,53L,55L,59L,61L,65L,67L,71L,73L,77L,79L,81L,85L,91L,95L,115L,119L,125L,127L,131L,133L,137L,139L,143L,149L,151L,157L,161L,163L,167L,173L,179L,181L,187L,191L,193L,197L,199L,203L,209L,211L,217L,221L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200722Inst : IEnumerable<long>
{
public static readonly long[] Value=A200722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200722.Bytes);
public long this[int i]=>Value[i];

public static A200722Inst Instance=new A200722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200723
{
public static readonly long[] Value={ 1L,1L,3L,6L,10L,10L,21L,28L,36L,32L,55L,53L,78L,66L,69L,120L,136L,112L,171L,144L,153L,170L,253L,211L,300L,240L,351L,300L,406L,237L,465L,496L,384L,416L,445L,539L,666L,522L,558L,633L,820L,444L,903L,780L,772L,770L,1081L,887L,1176L,912L,951L,1104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200723Inst : IEnumerable<long>
{
public static readonly long[] Value=A200723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200723.Bytes);
public long this[int i]=>Value[i];

public static A200723Inst Instance=new A200723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200724
{
public static readonly BigInteger[] Value={ 1L,35L,1224L,42805L,1496951L,52350480L,1830769849L,64024594235L,2239030028376L,78302026398925L,2738331893933999L,95763314261291040L,3348977667251252401L,BigInteger.Parse("117118455039532542995"),BigInteger.Parse("4095796948716387752424"),BigInteger.Parse("143235774750034038791845"),BigInteger.Parse("5009156319302474969962151") };
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
public class A200724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200724Inst Instance=new A200724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200725
{
public static readonly long[] Value={ 1L,1L,4L,16L,76L,399L,2206L,12664L,74790L,451420L,2772313L,17267652L,108821293L,692609446L,4445642625L,28744599748L,187047449289L,1224027357216L,8050074481917L,53179900898596L,352726704965748L,2348036826102013L,15682048658695168L,105052549830928908L,705678173069959645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200725Inst : IEnumerable<long>
{
public static readonly long[] Value=A200725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200725.Bytes);
public long this[int i]=>Value[i];

public static A200725Inst Instance=new A200725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200726
{
public static readonly long[] Value={ 0L,1L,3L,2L,1L,0L,1L,3L,2L,2L,0L,1L,3L,2L,0L,0L,1L,3L,2L,3L,0L,1L,3L,2L,2L,0L,1L,3L,2L,1L,0L,1L,3L,2L,2L,0L,1L,3L,2L,0L,0L,1L,3L,2L,3L,0L,1L,3L,2L,3L,0L,1L,3L,2L,1L,0L,1L,3L,2L,2L,0L,1L,3L,2L,0L,0L,1L,3L,2L,3L,0L,1L,3L,2L,1L,0L,1L,3L,2L,1L,0L,1L,3L,2L,2L,0L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200726Inst : IEnumerable<long>
{
public static readonly long[] Value=A200726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200726.Bytes);
public long this[int i]=>Value[i];

public static A200726Inst Instance=new A200726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200727
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,8L,9L,16L,22L,33L,42L,61L,79L,110L,143L,192L,246L,325L,411L,535L,676L,865L,1081L,1371L,1704L,2136L,2642L,3283L,4035L,4979L,6082L,7453L,9067L,11043L,13365L,16197L,19516L,23531L,28239L,33894L,40513L,48425L,57667L,68661L,81497L,96679L,114370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200727Inst : IEnumerable<long>
{
public static readonly long[] Value=A200727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200727.Bytes);
public long this[int i]=>Value[i];

public static A200727Inst Instance=new A200727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200728
{
public static readonly long[] Value={ 2L,0L,0L,2L,6L,0L,2L,4L,7L,3L,4L,4L,9L,6L,5L,2L,6L,2L,9L,9L,5L,1L,7L,0L,5L,6L,4L,2L,1L,4L,2L,2L,3L,3L,8L,7L,1L,2L,7L,3L,6L,9L,8L,7L,9L,4L,9L,0L,7L,8L,5L,3L,0L,0L,3L,4L,6L,7L,2L,9L,8L,3L,8L,0L,3L,8L,4L,8L,3L,2L,5L,5L,5L,7L,9L,9L,0L,7L,7L,6L,4L,1L,3L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200728Inst : IEnumerable<long>
{
public static readonly long[] Value=A200728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200728.Bytes);
public long this[int i]=>Value[i];

public static A200728Inst Instance=new A200728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200729
{
public static readonly long[] Value={ 4L,8L,216L,2116L,551368L,47444544L,17649109134656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200729Inst : IEnumerable<long>
{
public static readonly long[] Value=A200729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200729.Bytes);
public long this[int i]=>Value[i];

public static A200729Inst Instance=new A200729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200730
{
public static readonly long[] Value={ 1L,5041L,1601613L,1221611509L,355183455415293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200730Inst : IEnumerable<long>
{
public static readonly long[] Value=A200730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200730.Bytes);
public long this[int i]=>Value[i];

public static A200730Inst Instance=new A200730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200731
{
public static readonly BigInteger[] Value={ 1L,1L,4L,22L,139L,953L,6894L,51796L,400269L,3161262L,25403536L,207043048L,1707345547L,14219399626L,119431172630L,1010495472960L,8604568715969L,73683710894255L,634142349130800L,5482062214763436L,47582484748270453L,414503778412715065L,3622792181209018168L,BigInteger.Parse("31758958747482608912") };
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
public class A200731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200731Inst Instance=new A200731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200732
{
public static readonly long[] Value={ 103L,251L,859L,1367L,6907L,8783L,27431L,37039L,55291L,87803L,119159L,143743L,157211L,186619L,237271L,296347L,318023L,442363L,530599L,562427L,1000183L,1048571L,1149979L,2370811L,3650687L,4244827L,5470519L,5926171L,6406447L,7086239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200732Inst : IEnumerable<long>
{
public static readonly long[] Value=A200732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200732.Bytes);
public long this[int i]=>Value[i];

public static A200732Inst Instance=new A200732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200733
{
public static readonly long[] Value={ 101L,857L,2909L,23321L,48661L,70297L,97549L,275677L,530597L,1257721L,1431637L,1898201L,2047993L,2125757L,3217421L,5038841L,5926169L,6243577L,9624409L,11696821L,11943929L,14895493L,15185657L,20000837L,25326493L,29205529L,41440921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200733Inst : IEnumerable<long>
{
public static readonly long[] Value=A200733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200733.Bytes);
public long this[int i]=>Value[i];

public static A200733Inst Instance=new A200733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200734
{
public static readonly long[] Value={ 23L,491L,2039L,8779L,27427L,31991L,97547L,131063L,157207L,171491L,821507L,1257719L,1371991L,1556059L,1620887L,1972147L,2819867L,3114743L,3650683L,3764759L,5619703L,6083491L,7263383L,7812491L,9410539L,13231787L,17643767L,24918007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200734Inst : IEnumerable<long>
{
public static readonly long[] Value=A200734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200734.Bytes);
public long this[int i]=>Value[i];

public static A200734Inst Instance=new A200734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200735
{
public static readonly long[] Value={ 3L,3643L,6653L,214373L,2657203L,4851493L,6125213L,9304333L,14016103L,22460623L,27726163L,33756343L,52517293L,53969303L,63246683L,73530623L,95170813L,101732083L,156279373L,255324053L,317605993L,337095713L,400314953L,591853853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200735Inst : IEnumerable<long>
{
public static readonly long[] Value=A200735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200735.Bytes);
public long this[int i]=>Value[i];

public static A200735Inst Instance=new A200735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200736
{
public static readonly long[] Value={ 131L,16871L,46301L,78121L,98411L,296591L,588241L,925961L,1503811L,2657201L,3070621L,3292511L,3767851L,4851491L,5788121L,6838151L,7604371L,11763181L,17907881L,20098391L,30642431L,35945281L,40603001L,46969651L,55447831L,75346111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200736Inst : IEnumerable<long>
{
public static readonly long[] Value=A200736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200736.Bytes);
public long this[int i]=>Value[i];

public static A200736Inst Instance=new A200736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200737
{
public static readonly long[] Value={ 3L,3L,5L,8L,12L,3L,5L,7L,8L,11L,12L,15L,16L,21L,27L,3L,5L,7L,8L,9L,11L,12L,14L,15L,16L,19L,20L,21L,24L,26L,27L,32L,33L,40L,48L,3L,5L,7L,8L,9L,11L,11L,12L,14L,15L,16L,17L,19L,20L,21L,23L,24L,24L,26L,27L,29L,31L,32L,33L,35L,38L,39L,40L,45L,47L,48L,55L,56L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200737Inst : IEnumerable<long>
{
public static readonly long[] Value=A200737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200737.Bytes);
public long this[int i]=>Value[i];

public static A200737Inst Instance=new A200737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200738
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,11L,14L,16L,20L,23L,26L,31L,35L,38L,43L,48L,51L,57L,63L,65L,72L,78L,83L,89L,94L,100L,107L,113L,118L,126L,133L,137L,146L,153L,158L,167L,175L,180L,190L,197L,203L,213L,221L,227L,234L,245L,253L,262L,271L,276L,288L,296L,304L,316L,323L,329L,342L,354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200738Inst : IEnumerable<long>
{
public static readonly long[] Value=A200738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200738.Bytes);
public long this[int i]=>Value[i];

public static A200738Inst Instance=new A200738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200739
{
public static readonly long[] Value={ 1L,0L,0L,1L,5L,24L,116L,561L,2713L,13120L,63448L,306833L,1483837L,7175800L,34701996L,167818017L,811563889L,3924703424L,18979771248L,91785716705L,443873515701L,2146561633048L,10380720366244L,50200913713873L,242770409836169L,1174031855833216L,5677589783043784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200739Inst : IEnumerable<long>
{
public static readonly long[] Value=A200739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200739.Bytes);
public long this[int i]=>Value[i];

public static A200739Inst Instance=new A200739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200740
{
public static readonly long[] Value={ 1L,1L,3L,12L,54L,261L,1324L,6954L,37493L,206316L,1154050L,6542485L,37507919L,217081155L,1266646114L,7443100944L,44008522719L,261631301144L,1562969609155L,9377744249277L,56486588669929L,341452466500382L,2070684006442310L,12594325039504367L,76808163066135791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200740Inst : IEnumerable<long>
{
public static readonly long[] Value=A200740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200740.Bytes);
public long this[int i]=>Value[i];

public static A200740Inst Instance=new A200740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200741
{
public static readonly long[] Value={ 3L,3L,5L,8L,12L,3L,5L,7L,8L,11L,12L,15L,16L,21L,27L,3L,5L,7L,8L,9L,11L,12L,14L,15L,16L,19L,20L,21L,24L,26L,27L,32L,33L,40L,48L,3L,5L,7L,8L,9L,11L,12L,14L,15L,16L,17L,19L,20L,21L,23L,24L,26L,27L,29L,31L,32L,33L,35L,38L,39L,40L,45L,47L,48L,55L,56L,65L,75L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200741Inst : IEnumerable<long>
{
public static readonly long[] Value=A200741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200741.Bytes);
public long this[int i]=>Value[i];

public static A200741Inst Instance=new A200741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200742
{
public static readonly long[] Value={ 1L,2L,4L,10L,7L,35L,33L,36L,31L,82L,17L,81L,78L,170L,55L,132L,28L,195L,247L,313L,439L,325L,415L,498L,376L,213L,161L,693L,608L,948L,739L,557L,831L,1007L,1252L,631L,1156L,1370L,148L,579L,1023L,1755L,1677L,1239L,1638L,1839L,2281L,2401L,1963L,2630L,2521L,2951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200742Inst : IEnumerable<long>
{
public static readonly long[] Value=A200742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200742.Bytes);
public long this[int i]=>Value[i];

public static A200742Inst Instance=new A200742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200743
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,24L,70L,192L,576L,1890L,6300L,21600L,78624L,294840L,1140480L,4561920L,18849600L,79968000L,348566400L,1559376000L,7147140000L,33522128640L,160745472000L,787652812800L,3938264064000L,20080974513600L,104348244639744L,552160113120000L,2973491173785600L,16286186592000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200743Inst : IEnumerable<long>
{
public static readonly long[] Value=A200743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200743.Bytes);
public long this[int i]=>Value[i];

public static A200743Inst Instance=new A200743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200744
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,30L,72L,210L,630L,1920L,6336L,22176L,79200L,295680L,1146600L,4586400L,18869760L,80061696L,348986880L,1560176640L,7148445696L,33530112000L,160825785120L,787718131200L,3938590656000L,20083261440000L,104351247000000L,552173794099200L,2973528918360000L,16286983961149440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200744Inst : IEnumerable<long>
{
public static readonly long[] Value=A200744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200744.Bytes);
public long this[int i]=>Value[i];

public static A200744Inst Instance=new A200744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200745
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,2L,1L,2L,2L,6L,1L,9L,5L,6L,5L,20L,4L,28L,7L,19L,24L,55L,6L,51L,45L,49L,27L,136L,16L,180L,50L,117L,143L,146L,28L,403L,242L,260L,68L,668L,91L,852L,246L,260L,649L,1370L,90L,1191L,493L,1110L,634L,2701L,386L,1635L,462L,2160L,2486L,5154L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200745Inst : IEnumerable<long>
{
public static readonly long[] Value=A200745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200745.Bytes);
public long this[int i]=>Value[i];

public static A200745Inst Instance=new A200745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200746
{
public static readonly long[] Value={ 1L,2L,6L,4L,15L,12L,35L,8L,36L,30L,77L,24L,143L,70L,90L,16L,221L,72L,323L,60L,210L,154L,437L,48L,225L,286L,216L,140L,667L,180L,899L,32L,462L,442L,525L,144L,1147L,646L,858L,120L,1517L,420L,1763L,308L,540L,874L,2021L,96L,1225L,450L,1326L,572L,2491L,432L,1155L,280L,1938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200746Inst : IEnumerable<long>
{
public static readonly long[] Value=A200746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200746.Bytes);
public long this[int i]=>Value[i];

public static A200746Inst Instance=new A200746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200747
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,1L,2L,2L,3L,3L,3L,2L,3L,3L,3L,3L,4L,3L,3L,3L,4L,4L,2L,1L,2L,2L,3L,3L,3L,2L,3L,3L,3L,3L,4L,3L,3L,3L,4L,4L,2L,3L,4L,4L,2L,2L,3L,2L,3L,3L,3L,3L,4L,3L,3L,3L,4L,4L,2L,3L,4L,4L,2L,2L,3L,4L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,2L,3L,4L,4L,2L,2L,3L,4L,2L,2L,3L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200747Inst : IEnumerable<long>
{
public static readonly long[] Value=A200747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200747.Bytes);
public long this[int i]=>Value[i];

public static A200747Inst Instance=new A200747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200748
{
public static readonly long[] Value={ 0L,1L,3L,5L,11L,17L,23L,47L,71L,95L,119L,239L,359L,479L,599L,719L,1439L,2159L,2879L,3599L,4319L,5039L,10079L,15119L,20159L,25199L,30239L,35279L,40319L,80639L,120959L,161279L,201599L,241919L,282239L,322559L,362879L,725759L,1088639L,1451519L,1814399L,2177279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200748Inst : IEnumerable<long>
{
public static readonly long[] Value=A200748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200748.Bytes);
public long this[int i]=>Value[i];

public static A200748Inst Instance=new A200748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200749
{
public static readonly BigInteger[] Value={ 1L,1L,0L,11L,320L,71648L,55717584L,213773992667L,3437213982024260L,BigInteger.Parse("249555807519163873078"),BigInteger.Parse("78627163663841340597702692"),BigInteger.Parse("109477494899001088619906813170744"),BigInteger.Parse("666376868834051436218404625691790011056"),BigInteger.Parse("17813932068751803215543399261217225231408150272"),BigInteger.Parse("2084618062581510894785237376608868017658716989948775752"),BigInteger.Parse("1069049587048126292657245511018395164729584995637677006604201633"),BigInteger.Parse("2399885835948485973061191866831331382214612321025714609065977840609754872") };
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
public class A200749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200749Inst Instance=new A200749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200750
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,8L,8L,14L,18L,28L,32L,48L,58L,82L,104L,144L,178L,240L,294L,386L,478L,616L,750L,958L,1172L,1476L,1808L,2262L,2752L,3418L,4144L,5096L,6168L,7532L,9056L,10998L,13174L,15888L,18968L,22772L,27074L,32364L,38366L,45662L,54006L,64062L,75534L,89324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200750Inst : IEnumerable<long>
{
public static readonly long[] Value=A200750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200750.Bytes);
public long this[int i]=>Value[i];

public static A200750Inst Instance=new A200750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200751
{
public static readonly long[] Value={ 1L,-1L,-2L,-2L,-3L,-1L,-2L,6L,12L,36L,74L,162L,301L,599L,1090L,1986L,3479L,5993L,9852L,15644L,23094L,30690L,31868L,9068L,-82372L,-345308L,-1010956L,-2577868L,-6098822L,-13751218L,-29962588L,-63604140L,-132205949L,-269982371L,-542866266L,-1076420666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200751Inst : IEnumerable<long>
{
public static readonly long[] Value=A200751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200751.Bytes);
public long this[int i]=>Value[i];

public static A200751Inst Instance=new A200751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200752
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,8L,22L,61L,169L,468L,1296L,3589L,9939L,27524L,76222L,211081L,584545L,1618776L,4482864L,12414361L,34378995L,95205488L,263651830L,730128997L,2021940649L,5599344780L,15506222688L,42941263933L,118916913891L,329315700428L,911971451326L,2525515567441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200752Inst : IEnumerable<long>
{
public static readonly long[] Value=A200752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200752.Bytes);
public long this[int i]=>Value[i];

public static A200752Inst Instance=new A200752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200753
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,89L,381L,1694L,7744L,36168L,171831L,827814L,4034589L,19857262L,98555324L,492710856L,2478897620L,12541604830L,63768192378L,325674039636L,1669922290311L,8593644472017L,44369362778645L,229767801472366L,1193126351099007L,6211253430642091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200753Inst : IEnumerable<long>
{
public static readonly long[] Value=A200753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200753.Bytes);
public long this[int i]=>Value[i];

public static A200753Inst Instance=new A200753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200754
{
public static readonly long[] Value={ 1L,1L,3L,13L,67L,380L,2288L,14351L,92737L,613063L,4126289L,28179766L,194780822L,1360053081L,9578997279L,67971291791L,485464864401L,3487203531460L,25176899072984L,182598098616625L,1329716528758651L,9718954060263384L,71273846758123552L,524279847227139350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200754Inst : IEnumerable<long>
{
public static readonly long[] Value=A200754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200754.Bytes);
public long this[int i]=>Value[i];

public static A200754Inst Instance=new A200754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200755
{
public static readonly long[] Value={ 1L,1L,2L,7L,29L,129L,602L,2910L,14447L,73234L,377487L,1972568L,10425930L,55640282L,299403552L,1622701202L,8850030065L,48534971244L,267486182192L,1480673755443L,8228819436898L,45895682480965L,256815165790211L,1441321638029496L,8111194646903282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200755Inst : IEnumerable<long>
{
public static readonly long[] Value=A200755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200755.Bytes);
public long this[int i]=>Value[i];

public static A200755Inst Instance=new A200755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200756
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,1L,12L,12L,6L,1L,40L,40L,24L,8L,1L,144L,144L,92L,40L,10L,1L,544L,544L,360L,176L,60L,12L,1L,2128L,2128L,1440L,752L,300L,84L,14L,1L,8544L,8544L,5872L,3200L,1400L,472L,112L,16L,1L,35008L,35008L,24336L,13664L,6352L,2400L,700L,144L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200756Inst : IEnumerable<long>
{
public static readonly long[] Value=A200756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200756.Bytes);
public long this[int i]=>Value[i];

public static A200756Inst Instance=new A200756Inst();

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